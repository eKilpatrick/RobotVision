Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1
    Public cognexServerIP As IPAddress = IPAddress.Parse("169.254.245.128")
    Public cognexPort As Integer = 23
    Public cognexSocket As Socket
    Public cognexConnected As Boolean = False

    Public robotServerIP As IPAddress = IPAddress.Parse("169.254.245.125")
    Public robotPort As Integer = 29999
    Public robotSocket As Socket
    Public robotConnected As Boolean = False

    Public gripperServerIP As IPAddress = IPAddress.Parse("169.254.245.127")
    Public gripperPort As Integer = 29999
    Public gripperSocket As Socket
    Public gripperConnected As Boolean = False

    Public computerServerIP As IPAddress = IPAddress.Parse("169.254.245.130")
    Public computerPortScrewbot As Integer = 55555
    Public computerPortGripper As Integer = 55557

    Public xArr As New List(Of Double)()
    Public yArr As New List(Of Double)()

    'Hardcoded pixel values of hole location when the plane is properly calibrated.
    'Public xPos As Double = 0.04235
    'Public yPos As Double = 0.14075

    Public xPos1 As Double = 0.052165
    Public yPos1 As Double = 0.147907
    Public xPos2 As Double = 0.052348
    Public yPos2 As Double = 0.148056
    Public xPos3 As Double = 0.052538
    Public yPos3 As Double = 0.146895

    'Gripbot to Screwbot base plane translation vector
    Public originGS As New List(Of Double) From {1.376, 0.0046, -0.026, 0, -4.5, 0}

    Public Function ConnectToServer(IP As IPAddress, Port As Integer) As Socket
        Try
            Dim EP As New IPEndPoint(IP, Port)
            Dim Sock As New Socket(IP.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
            Dim connected = False
            Dim count As Integer = 0
            While connected = False And count < 15
                Try
                    Sock.Connect(EP)
                    connected = True
                    Return Sock
                Catch ex As Exception
                    count += 1
                End Try
            End While
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ListenToClient(IP As IPAddress, Port As Integer, Optional ByVal ListenFor As String = "", Optional ByVal Response As String = "")
        Try
            Dim tcpListener As New TcpListener(IP, Port)
            tcpListener.Start()

            Dim tcpClient As TcpClient = tcpListener.AcceptTcpClient()
            Dim stream As NetworkStream = tcpClient.GetStream()

            While tcpClient.Client.Connected()
                Dim arrayBytesRequest As Byte() = New Byte(tcpClient.Available - 1) {}
                Dim nRead = stream.Read(arrayBytesRequest, 0, arrayBytesRequest.Length)

                If nRead > 0 Then
                    Dim ReadStr = Encoding.ASCII.GetString(arrayBytesRequest)
                    If ListenFor = "" Then
                        tcpListener.Stop()
                        tcpClient.Close()
                        Return ReadStr
                    Else
                        If ReadStr = ListenFor Then
                            Dim respond = Encoding.ASCII.GetBytes(Response & Environment.NewLine)
                            stream.Write(respond, 0, respond.Length)
                            tcpListener.Stop()
                            tcpClient.Close()
                            Return "Success"
                        Else
                            Return String.Empty
                        End If
                    End If

                Else
                    If tcpClient.Available = 0 Then
                        Exit While
                    End If
                End If
            End While
            Return String.Empty
        Catch ex As Exception
            MsgBox("Error in ListenForCoords(): " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connects to Cognex Camera on the telnet port and logs in
        'Refreshes the desktop form to show the user that it connected properly to the camera
        cognexSocket = ConnectToServer(cognexServerIP, cognexPort)
        Threading.Thread.Sleep(250)
        Dim bytes(1024) As Byte
        Dim recBytes = cognexSocket.Receive(bytes)
        If Encoding.ASCII.GetString(bytes, 0, recBytes).Contains("User") Then
            Dim user = Encoding.ASCII.GetBytes("admin" & Environment.NewLine)
            cognexSocket.Send(user)
            Threading.Thread.Sleep(250)
            Dim recBytes3 = cognexSocket.Receive(bytes)
            If Encoding.ASCII.GetString(bytes, 0, recBytes3).Contains("Password") Then
                Dim password = Encoding.ASCII.GetBytes(Environment.NewLine)
                cognexSocket.Send(password)
                Threading.Thread.Sleep(250)
                Dim recBytes4 = cognexSocket.Receive(bytes)
                If Encoding.ASCII.GetString(bytes, 0, recBytes4).Contains("User Logged In") Then
                    lblConnected.Text = "Cognex: Connected/Logged In"
                    lblConnected.ForeColor = Color.Green
                    cognexConnected = True
                Else
                    lblConnected.Text = "Cognex: Disconnected"
                    lblConnected.ForeColor = Color.Red
                    cognexConnected = False
                End If
            End If
        Else
            MsgBox("Couldn't connect to the camera")
        End If
        lblIP.Text &= " " & cognexServerIP.ToString()
        lblPort.Text &= " " & cognexPort.ToString()
        If GetStatus() Then
            lblStatus.Text = "Cognex Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Cognex Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If

        'Connects to Universal Robot on the dashboard server port
        'Refreshes the dekstop form to show the user that it connected properly to the robot
        lblRobotIP.Text &= " " & robotServerIP.ToString()
        lblRobotPort.Text &= " " & robotPort.ToString()
        robotSocket = ConnectToServer(robotServerIP, robotPort)
        Dim bytes2(1024) As Byte
        Dim bytesRec = robotSocket.Receive(bytes2)
        If Encoding.ASCII.GetString(bytes2, 0, bytesRec).Contains("Connected") Then
            lblRobotStatus.Text = "Sbot Status: Connected"
            lblRobotStatus.ForeColor = Color.Green
            robotConnected = True
        Else
            lblRobotStatus.Text = "Sbot Status: Disconnected"
            lblRobotStatus.ForeColor = Color.Red
            robotConnected = False
        End If

        lblGbotIP.Text &= " " & gripperServerIP.ToString()
        lblGbotPort.Text &= " " & gripperPort.ToString()
        gripperSocket = ConnectToServer(gripperServerIP, gripperPort)
        Dim bytes3(1024) As Byte
        Dim bytesRec2 = gripperSocket.Receive(bytes3)
        If Encoding.ASCII.GetString(bytes3, 0, bytesRec2).Contains("Connected") Then
            lblGbotStatus.Text = "Gbot Status: Connected"
            lblGbotStatus.ForeColor = Color.Green
        Else
            lblGbotStatus.Text = "Gbot Status: Connected"
            lblGbotStatus.ForeColor = Color.Red
        End If

        lblComputerIP.Text &= " " & computerServerIP.ToString()
        lblComputerPortSbot.Text &= " " & computerPortScrewbot.ToString()
        lblComputerPortGbot.Text &= " " & computerPortGripper.ToString()
    End Sub


    Private Sub btnGF_Click(sender As Object, e As EventArgs) Handles btnGF.Click
        If cognexConnected = True Then
            Dim gfCmd = Encoding.ASCII.GetBytes("GF" & Environment.NewLine)
            cognexSocket.Send(gfCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                MsgBox("Loaded File: " & response.Split("/")(1))
            Else
                MsgBox("Error while sending command")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If
    End Sub

    Private Sub btnOn_Click(sender As Object, e As EventArgs) Handles btnOn.Click
        If cognexConnected = True Then
            Dim soCmd = Encoding.ASCII.GetBytes("SO1" & Environment.NewLine)
            cognexSocket.Send(soCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("1") = False Then
                    MsgBox("Error turning camera online")
                End If
            Else
                MsgBox("Error turning camera online")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If

        If GetStatus() Then
            lblStatus.Text = "Cognex Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Cognex Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        If cognexConnected = True Then
            Dim soCmd = Encoding.ASCII.GetBytes("SO0" & Environment.NewLine)
            cognexSocket.Send(soCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = cognexSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("1") = False Then
                    MsgBox("Error turning camera offline")
                End If
            Else
                MsgBox("Error turning camera offline")
            End If
        Else
            MsgBox("Camera isn't connected")
        End If

        If GetStatus() Then
            lblStatus.Text = "Cognex Status: Online"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Cognex Status: Offline"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Public Function GetStatus()
        If cognexConnected = True Then
            Dim goCmd = Encoding.ASCII.GetBytes("GO" & Environment.NewLine)
            cognexSocket.Send(goCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim recBytes = cognexSocket.Receive(bytes)
            If recBytes <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                If response.Contains("1") Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub btnTrigger_Click(sender As Object, e As EventArgs) Handles btnTrigger.Click
        If cognexConnected = True Then
            Dim trigCmd = Encoding.ASCII.GetBytes("SE8" & Environment.NewLine)
            cognexSocket.Send(trigCmd)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim recBytes = cognexSocket.Receive(bytes)
            If recBytes <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                If response.Contains("1") Then
                    Dim getXCmd = Encoding.ASCII.GetBytes("GVC24" & Environment.NewLine)
                    Dim getYCmd = Encoding.ASCII.GetBytes("GVD24" & Environment.NewLine)
                    cognexSocket.Send(getXCmd)
                    Threading.Thread.Sleep(250)
                    recBytes = cognexSocket.Receive(bytes)
                    If recBytes <> 0 Then
                        response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                        lblPastX.Text = "Previous X: " & lblX.Text.Split(":")(1)
                        lblX.Text = "X: " & response.Split(vbLf)(1).ToString().Trim() & " mm"
                        Dim xValue As Double = response.Split(vbLf)(1).Trim()
                        xArr.Add(response.Split(vbLf)(1).Trim())
                    End If
                    cognexSocket.Send(getYCmd)
                    Threading.Thread.Sleep(250)
                    recBytes = cognexSocket.Receive(bytes)
                    If recBytes <> 0 Then
                        response = Encoding.ASCII.GetString(bytes, 0, recBytes)
                        lblPastY.Text = "Previous Y: " & lblY.Text.Split(":")(1)
                        lblY.Text = "Y: " & response.Split(vbLf)(1).ToString().Trim() & " mm"
                        yArr.Add(response.Split(vbLf)(1).Trim())
                    End If
                Else
                    MsgBox("Error triggering the camera")
                End If
            End If

            'Calculates the average X and Y values of the hole location and refreshes the desktop form
            Dim sumX As Double = 0.0
            Dim sumY As Double = 0.0

            For Each number As Double In xArr
                sumX += number
            Next

            For Each number As Double In yArr
                sumY += number
            Next

            If sumX <> 0.0 And sumY <> 0.0 Then
                lblAvgX.Text = "Avg X: " & (sumX / xArr.Count).ToString("F3") & " mm"
                lblAvgY.Text = "Avg Y: " & (sumY / yArr.Count).ToString("F3") & " mm"
            End If

            'Calculates the standard deviation of the X and Y coordinates of the hole location that have been triggered since the form opened
            Dim sumVarX As Double = 0.0
            Dim sumVarY As Double = 0.0

            For Each number As Double In xArr
                sumVarX += ((number - (sumX / xArr.Count)) ^ 2)
            Next

            For Each number As Double In yArr
                sumVarY += ((number - (sumY / yArr.Count)) ^ 2)
            Next

            If sumVarX <> 0.0 And sumVarY <> 0.0 Then
                lblXDev.Text = "Avg X Dev: " & Math.Sqrt((sumVarX / xArr.Count)).ToString("F4") & " mm"
                lblYDev.Text = "Avg Y Dev: " & Math.Sqrt((sumVarY / yArr.Count)).ToString("F4") & " mm"
            End If
        Else
            MsgBox("Camera is not connected")
        End If
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/gohome.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Threading.Thread.Sleep(250)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    Threading.Thread.Sleep(250)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                Else
                    MsgBox("Error loading the program")
                End If
            Else
                MsgBox("Error receiving from the robot")
            End If
        Else
            MsgBox("Robot is not connected")
        End If
    End Sub

    Private Sub btnRobotPos_Click(sender As Object, e As EventArgs) Handles btnRobotPos.Click
        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/GetPose.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
            Dim pose As String = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim basePose As String = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim x = CDbl(basePose.Substring(2).Split(",")(0)) * 1000.0
            Dim y = CDbl(basePose.Substring(2).Split(",")(1)) * 1000.0
            Dim z = CDbl(basePose.Substring(2).Split(",")(2)) * 1000.0
            Dim rx = CDbl(basePose.Substring(2).Split(",")(3))
            Dim ry = CDbl(basePose.Substring(2).Split(",")(4))
            Dim rz = CDbl(basePose.Substring(2).Split(",")(5).Split("]")(0))
            lblRobotX.Text = "X: " & CStr(x) & " mm"
            lblRobotY.Text = "Y: " & CStr(y) & " mm"
            lblRobotZ.Text = "Z: " & CStr(z) & " mm"
            lblRobotRX.Text = "RX: " & CStr(rx) & " mm"
            lblRobotRY.Text = "RY: " & CStr(ry) & " mm"
            lblRobotRZ.Text = "RZ: " & CStr(rz) & " mm"

            x = CDbl(pose.Substring(2).Split(",")(0)) * 1000.0
            y = CDbl(pose.Substring(2).Split(",")(1)) * 1000.0
            z = CDbl(pose.Substring(2).Split(",")(2)) * 1000.0
            rx = CDbl(pose.Substring(2).Split(",")(3))
            ry = CDbl(pose.Substring(2).Split(",")(4))
            rz = CDbl(pose.Substring(2).Split(",")(5).Split("]")(0))
            lblPanelX.Text = "X: " & CStr(x) & " mm"
            lblPanelY.Text = "Y: " & CStr(y) & " mm"
            lblPanelZ.Text = "Z: " & CStr(z) & " mm"
            lblPanelRX.Text = "RX: " & CStr(rx) & " mm"
            lblPanelRY.Text = "RY: " & CStr(ry) & " mm"
            lblPanelRZ.Text = "RZ: " & CStr(rz) & " mm"
        Else
            MsgBox("Robot is not connected")
        End If

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/CalibratePlane.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If

            'Calculates the correct position of the origin hole based on current position, hardcoded x/y pixel values, and sends to robot
            Dim pose As String = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim x = CDbl(pose.Substring(2).Split(",")(0))
            Dim y = CDbl(pose.Substring(2).Split(",")(1))
            Dim z = CDbl(pose.Substring(2).Split(",")(2))
            Dim rx = CDbl(pose.Substring(2).Split(",")(3))
            Dim ry = CDbl(pose.Substring(2).Split(",")(4))
            Dim rz = CDbl(pose.Substring(2).Split(",")(5).Split("]")(0))

            Threading.Thread.Sleep(1000)
            btnTrigger_Click(sender, e)
            Dim realX As Double = CDbl(lblX.Text.Split(":")(1).Split("m")(0).Trim()) / 1000
            Dim realY As Double = CDbl(lblY.Text.Split(":")(1).Split("m")(0).Trim()) / 1000

            Dim xOffset As Double = xPos1 - realX
            Dim yOffset As Double = realY - yPos1

            Dim correctX As Double = x + xOffset
            Dim correctY As Double = y + yOffset

            Dim newHolePose = "(" & correctX & "," & correctY & ",0," & rx & "," & ry & "," & rz & ",0)"
            Dim response2 = ListenToClient(computerServerIP, computerPortScrewbot, "GetMove", newHolePose)

            'Calculates the correct position of the X-Direction hole based on the current position, hardcoded x/y pixel values, and sends to robot
            Dim pose2 As String = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim x2 = CDbl(pose2.Substring(2).Split(",")(0))
            Dim y2 = CDbl(pose2.Substring(2).Split(",")(1))
            Dim z2 = CDbl(pose2.Substring(2).Split(",")(2))
            Dim rx2 = CDbl(pose2.Substring(2).Split(",")(3))
            Dim ry2 = CDbl(pose2.Substring(2).Split(",")(4))
            Dim rz2 = CDbl(pose2.Substring(2).Split(",")(5).Split("]")(0))

            Threading.Thread.Sleep(1000)
            btnTrigger_Click(sender, e)
            Dim realX2 As Double = CDbl(lblX.Text.Split(":")(1).Split("m")(0).Trim()) / 1000
            Dim realY2 As Double = CDbl(lblY.Text.Split(":")(1).Split("m")(0).Trim()) / 1000

            Dim xOffset2 As Double = xPos2 - realX2
            Dim yOffset2 As Double = realY2 - yPos2

            Dim correctX2 As Double = x2 + xOffset2
            Dim correctY2 As Double = y2 + yOffset2

            Dim newHolePose2 = "(" & correctX2 & "," & correctY2 & ",0," & rx2 & "," & ry2 & "," & rz2 & ",0)"
            Dim response3 = ListenToClient(computerServerIP, computerPortScrewbot, "GetMove2", newHolePose2)

            'Calculates the correct position of the Y-Direction hole based on the current position, hardcoded x/y pixel values, and sends to robot
            Dim pose3 As String = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim x3 = CDbl(pose3.Substring(2).Split(",")(0))
            Dim y3 = CDbl(pose3.Substring(2).Split(",")(1))
            Dim z3 = CDbl(pose3.Substring(2).Split(",")(2))
            Dim rx3 = CDbl(pose3.Substring(2).Split(",")(3))
            Dim ry3 = CDbl(pose3.Substring(2).Split(",")(4))
            Dim rz3 = CDbl(pose3.Substring(2).Split(",")(5).Split("]")(0))

            Threading.Thread.Sleep(1000)
            btnTrigger_Click(sender, e)
            Dim realX3 As Double = CDbl(lblX.Text.Split(":")(1).Split("m")(0).Trim()) / 1000
            Dim realY3 As Double = CDbl(lblY.Text.Split(":")(1).Split("m")(0).Trim()) / 1000

            Dim xOffset3 As Double = xPos3 - realX3
            Dim yOffset3 As Double = realY3 - yPos3

            Dim correctX3 As Double = x3 + xOffset3
            Dim correctY3 As Double = y3 + yOffset3

            Dim newHolePose3 = "(" & correctX3 & "," & correctY3 & ",0," & rx3 & "," & ry3 & "," & rz3 & ",0)"
            Dim response4 = ListenToClient(computerServerIP, computerPortScrewbot, "GetMove3", newHolePose3)

            Dim NewPlanePoints = ListenToClient(computerServerIP, computerPortScrewbot)
            Dim NewPlaneArr As String() = NewPlanePoints.split("p")

            lblNewOrigin.Text = "Origin: p" & NewPlaneArr(1).Trim(",") 'Looks like this [0,0,0,0,0,0]
            lblNewX.Text = "X-Direction: p" & NewPlaneArr(2).Trim(",")
            lblNewY.Text = "Y-Direction: p" & NewPlaneArr(3).Trim("]") & "]"

            'Gets the x, y, z coordinates from all three points in terms of screwbots base plane and calculates the new panel plane
            Dim p1 As New List(Of Double)()
            p1.Add(CDbl(NewPlaneArr(1).Trim(",").Trim("[").Split(",")(0)))
            p1.Add(CDbl(NewPlaneArr(1).Trim(",").Trim("[").Split(",")(1)))
            p1.Add(CDbl(NewPlaneArr(1).Trim(",").Trim("[").Split(",")(2)))
            Dim p2 As New List(Of Double)()
            p2.Add(CDbl(NewPlaneArr(2).Trim(",").Trim("[").Split(",")(0)))
            p2.Add(CDbl(NewPlaneArr(2).Trim(",").Trim("[").Split(",")(1)))
            p2.Add(CDbl(NewPlaneArr(2).Trim(",").Trim("[").Split(",")(2)))
            Dim p3 As New List(Of Double)()
            p3.Add(CDbl(NewPlaneArr(3).Trim(",").Trim("[").Split(",")(0)))
            p3.Add(CDbl(NewPlaneArr(3).Trim(",").Trim("[").Split(",")(1)))
            p3.Add(CDbl(NewPlaneArr(3).Trim(",").Trim("[").Split(",")(2)))

            Dim NewPlaneScrewbot As List(Of Double) = CreatePlane(p1, p2, p3)
            For i As Integer = 0 To NewPlaneScrewbot.Count - 1
                lblSbotPlane.Text &= NewPlaneScrewbot(i) & ", "
            Next

            load = Encoding.ASCII.GetBytes("load /programs/CalibratePlane.urp" & Environment.NewLine)
            play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            Dim bytes2(1024) As Byte
            Dim bytesRec2 As Integer
            gripperSocket.Send(load)
            bytesRec2 = gripperSocket.Receive(bytes2)
            If bytesRec2 <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes2, 0, bytesRec2)
                If response.Contains("Loading") Then
                    gripperSocket.Send(play)
                    bytesRec2 = gripperSocket.Receive(bytes)
                    If bytesRec2 = 0 Then
                        MsgBox("Error playing the program")
                    End If
                Else
                    MsgBox("Incorrect response received")
                End If
            Else
                MsgBox("Error loading the program")
            End If

            Dim gripperPoint1 As String() = NewPlaneArr(1).Trim(",").Trim("[").Trim("]").Split(",")
            Dim gripperPoint2 As String() = NewPlaneArr(2).Trim(",").Trim("[").Trim("]").Split(",")
            Dim gripperPoint3 As String() = NewPlaneArr(3).Trim(",").Trim("[").Trim("]").Split(",")
            'For some reason the sbot is switching the signs of the rx, ry, and rz when using the getactualtcppose() function...
            gripperPoint1(3) *= -1
            gripperPoint2(3) *= -1
            gripperPoint3(3) *= -1
            gripperPoint1(4) *= -1
            gripperPoint2(4) *= -1
            gripperPoint3(4) *= -1
            gripperPoint1(5) *= -1
            gripperPoint2(5) *= -1
            gripperPoint3(5) *= -1
            For i As Integer = 0 To gripperPoint1.Count() - 1
                gripperPoint1(i) += originGS(i)
                gripperPoint2(i) += originGS(i)
                gripperPoint3(i) += originGS(i)
            Next

            Dim gripperPoint1Str As String = "(" & gripperPoint1(0) & "," & gripperPoint1(1) & "," & gripperPoint1(2) & "," & gripperPoint1(3) & "," & gripperPoint1(4) & "," & gripperPoint1(5) & ",0)"
            Dim gripperPoint2Str As String = "(" & gripperPoint2(0) & "," & gripperPoint2(1) & "," & gripperPoint2(2) & "," & gripperPoint2(3) & "," & gripperPoint2(4) & "," & gripperPoint2(5) & ",0)"
            Dim gripperPoint3Str As String = "(" & gripperPoint3(0) & "," & gripperPoint3(1) & "," & gripperPoint3(2) & "," & gripperPoint3(3) & "," & gripperPoint3(4) & "," & gripperPoint3(5) & ",0)"
            lblGbotOrigin.Text &= gripperPoint1Str
            lblGbotXDir.Text &= gripperPoint2Str
            lblGbotYDir.Text &= gripperPoint3Str
            ListenToClient(computerServerIP, computerPortGripper, "GetMove1", gripperPoint1Str)
            ListenToClient(computerServerIP, computerPortGripper, "GetMove2", gripperPoint2Str)
            ListenToClient(computerServerIP, computerPortGripper, "GetMove3", gripperPoint3Str)

            Dim gripperPoint1List As New List(Of Double) From {gripperPoint1(0), gripperPoint1(1), gripperPoint1(2), gripperPoint1(3), gripperPoint1(4), gripperPoint1(5)}
            Dim gripperPoint2List As New List(Of Double) From {gripperPoint2(0), gripperPoint2(1), gripperPoint2(2), gripperPoint2(3), gripperPoint2(4), gripperPoint2(5)}
            Dim gripperPoint3List As New List(Of Double) From {gripperPoint3(0), gripperPoint3(1), gripperPoint3(2), gripperPoint3(3), gripperPoint3(4), gripperPoint3(5)}

            Dim NewPlaneGripbot As List(Of Double) = CreatePlane(gripperPoint1List, gripperPoint2List, gripperPoint3List)
            For i As Integer = 0 To gripperPoint1List.Count - 1
                lblGbotPlane.Text &= NewPlaneGripbot(i) & ", "
            Next
        Else
            MsgBox("Robot is not connected")
        End If
    End Sub

    Private Sub btnAboveHole_Click(sender As Object, e As EventArgs) Handles btnAboveHole.Click
        If robotConnected = True Then
            Dim whichPoint As String = InputBox("Which point would you like to go to? Origin (1), X-Direction (2), or Y-Direction (3)")
            If whichPoint = "1" Then
                whichPoint = ">Origin<"
            ElseIf whichPoint = "2" Then
                whichPoint = ">XDir<"
            ElseIf whichPoint = "3" Then
                whichPoint = ">YDir<"
            Else
                MsgBox("Invalid option, please try again.")
                Exit Sub
            End If
            Dim load = Encoding.ASCII.GetBytes("load /programs/AboveOrigin.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                    ListenToClient(computerServerIP, computerPortScrewbot, "WhichPoint", whichPoint)
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If
    End Sub

    Private Sub btnMoveForward_Click(sender As Object, e As EventArgs) Handles btnMoveForward.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Forward<")
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Right<")
    End Sub

    Private Sub btnMoveBackward_Click(sender As Object, e As EventArgs) Handles btnMoveBackward.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Backward<")
    End Sub

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Left<")
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Up<")
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click

        If robotConnected = True Then
            Dim load = Encoding.ASCII.GetBytes("load /programs/MoveRobot.urp" & Environment.NewLine)
            Dim play = Encoding.ASCII.GetBytes("play" & Environment.NewLine)
            robotSocket.Send(load)
            Dim bytes(1024) As Byte
            Dim bytesRec = robotSocket.Receive(bytes)
            If bytesRec <> 0 Then
                Dim response As String = Encoding.ASCII.GetString(bytes, 0, bytesRec)
                If response.Contains("Loading") Then
                    robotSocket.Send(play)
                    bytesRec = robotSocket.Receive(bytes)
                    If bytesRec = 0 Then
                        MsgBox("Error playing the program")
                    End If
                End If
            Else
                MsgBox("Error loading the program")
            End If
        Else
            MsgBox("Robot is not connected")
        End If

        ListenToClient(computerServerIP, computerPortScrewbot, "Ready", ">Down<")
    End Sub

    Public Function CreatePlane(p1 As List(Of Double), p2 As List(Of Double), p3 As List(Of Double))
        'Tested all of the unit vector calculations, 100% correct
        '--------------------------------------------------------------------------
        Dim d12 As New List(Of Double)()
        d12.Add(p2(0) - p1(0))
        d12.Add(p2(1) - p1(1))
        d12.Add(p2(2) - p1(2))
        Console.WriteLine("d12: [" & d12(0) & "," & d12(1) & "," & d12(2) & "]")

        Dim d13 As New List(Of Double)()
        d13.Add(p3(0) - p1(0))
        d13.Add(p3(1) - p1(1))
        d13.Add(p3(2) - p1(2))
        Console.WriteLine("d13: [" & d13(0) & "," & d13(1) & "," & d13(2) & "]")

        Dim dz = cross_product(d12, d13)
        Console.WriteLine("dz: [" & dz(0) & "," & dz(1) & "," & dz(2) & "]")

        Dim temp = Magnitude(d12)
        Console.WriteLine("Magnitude(d12): " & temp)

        Dim ux As New List(Of Double)()
        ux.Add(d12(0) / temp)
        ux.Add(d12(1) / temp)
        ux.Add(d12(2) / temp)
        Console.WriteLine("ux: [" & ux(0) & "," & ux(1) & "," & ux(2) & "]")

        temp = Magnitude(dz)
        Console.WriteLine("Magnitude(dz): " & temp)

        Dim uz As New List(Of Double)()
        uz.Add(dz(0) / temp)
        uz.Add(dz(1) / temp)
        uz.Add(dz(2) / temp)
        Console.WriteLine("uz: [" & uz(0) & "," & uz(1) & "," & uz(2) & "]")

        Dim uy = cross_product(uz, ux)
        Console.WriteLine("uy: [" & uy(0) & "," & uy(1) & "," & uy(2) & "]")

        Dim rotmat As New List(Of Double)()
        rotmat.Add(ux(0))
        rotmat.Add(ux(1))
        rotmat.Add(ux(2))
        rotmat.Add(uy(0))
        rotmat.Add(uy(1))
        rotmat.Add(uy(2))
        rotmat.Add(uz(0))
        rotmat.Add(uz(1))
        rotmat.Add(uz(2))
        '--------------------------------------------------------------------------

        Dim rotvec = rotmat2rotvec(rotmat)

        Dim feature_plane As New List(Of Double)()
        feature_plane.Add(p1(0))
        feature_plane.Add(p1(1))
        feature_plane.Add(p1(2))
        feature_plane.Add(rotvec(0))
        feature_plane.Add(rotvec(1))
        feature_plane.Add(rotvec(2))

        Return feature_plane
    End Function

    Public Function cross_product(u As List(Of Double), v As List(Of Double)) As List(Of Double)
        Dim u1 = u(0)
        Dim u2 = u(1)
        Dim u3 = u(2)
        Dim v1 = v(0)
        Dim v2 = v(1)
        Dim v3 = v(2)

        Dim s As New List(Of Double)()
        s.Add((u2 * v3 - u3 * v2))
        s.Add((u3 * v1 - u1 * v3))
        s.Add((u1 * v2 - u2 * v1))

        Return s
    End Function

    Public Function rotmat2rotvec(rotmat As List(Of Double)) As List(Of Double)
        Dim r11 = rotmat(0)
        Dim r21 = rotmat(1)
        Dim r31 = rotmat(2)
        Dim r12 = rotmat(3)
        Dim r22 = rotmat(4)
        Dim r32 = rotmat(5)
        Dim r13 = rotmat(6)
        Dim r23 = rotmat(7)
        Dim r33 = rotmat(8)

        Dim theta = Math.Acos((r11 + r22 + r33 - 1) / 2)
        Dim sth = Math.Sin(theta)
        Dim ux As Double
        Dim uy As Double
        Dim uz As Double

        If ((theta > d2r(179.99)) Or (theta < d2r(-179.99))) Then
            theta = d2r(180)
            If (r21 < 0) Then
                If (r31 < 0) Then
                    ux = Math.Sqrt((r11 + 1) / 2)
                    uy = -Math.Sqrt((r22 + 1) / 2)
                    uz = -Math.Sqrt((r33 + 1) / 2)
                Else
                    ux = Math.Sqrt((r11 + 1) / 2)
                    uy = -Math.Sqrt((r22 + 1) / 2)
                    uz = Math.Sqrt((r33 + 1) / 2)
                End If
            Else
                If (r31 < 0) Then
                    ux = Math.Sqrt((r11 + 1) / 2)
                    uy = Math.Sqrt((r22 + 1) / 2)
                    uz = -Math.Sqrt((r33 + 1) / 2)
                Else
                    ux = Math.Sqrt((r11 + 1) / 2)
                    uy = Math.Sqrt((r22 + 1) / 2)
                    uz = Math.Sqrt((r33 + 1) / 2)

                End If
            End If
        Else
            ux = (r32 - r23) / (2 * sth)
            uy = (r13 - r31) / (2 * sth)
            uz = (r21 - r12) / (2 * sth)
        End If

        Dim rotvec As New List(Of Double)()
        rotvec.Add(theta * ux)
        rotvec.Add(theta * uy)
        rotvec.Add(theta * uz)
        Return rotvec
    End Function

    'Tested to be accurate
    Public Function Magnitude(vector As List(Of Double)) As Double
        Return Math.Sqrt(vector(0) ^ 2 + vector(1) ^ 2 + vector(2) ^ 2)
    End Function

    Public Function d2r(num As Double) As Double
        Return (num * Math.PI / 180)
    End Function
End Class

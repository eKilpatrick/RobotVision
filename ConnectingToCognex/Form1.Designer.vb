<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lblGbotPort = New System.Windows.Forms.Label()
        Me.lblGbotIP = New System.Windows.Forms.Label()
        Me.lblGbotStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRobotPort = New System.Windows.Forms.Label()
        Me.lblRobotIP = New System.Windows.Forms.Label()
        Me.lblRobotStatus = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblComputerPortGbot = New System.Windows.Forms.Label()
        Me.lblComputerPortSbot = New System.Windows.Forms.Label()
        Me.lblComputerIP = New System.Windows.Forms.Label()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.btnGF = New System.Windows.Forms.Button()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTrigger = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnRobotPos = New System.Windows.Forms.Button()
        Me.btnAboveHole = New System.Windows.Forms.Button()
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblPastY = New System.Windows.Forms.Label()
        Me.lblPastX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblYDev = New System.Windows.Forms.Label()
        Me.lblXDev = New System.Windows.Forms.Label()
        Me.lblAvgY = New System.Windows.Forms.Label()
        Me.lblAvgX = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblPanelRZ = New System.Windows.Forms.Label()
        Me.lblPanelRY = New System.Windows.Forms.Label()
        Me.lblPanelRX = New System.Windows.Forms.Label()
        Me.lblPanelZ = New System.Windows.Forms.Label()
        Me.lblPanelY = New System.Windows.Forms.Label()
        Me.lblPanelX = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblRobotRZ = New System.Windows.Forms.Label()
        Me.lblRobotRY = New System.Windows.Forms.Label()
        Me.lblRobotRX = New System.Windows.Forms.Label()
        Me.lblRobotZ = New System.Windows.Forms.Label()
        Me.lblRobotY = New System.Windows.Forms.Label()
        Me.lblRobotX = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblGbotYDir = New System.Windows.Forms.Label()
        Me.lblGbotXDir = New System.Windows.Forms.Label()
        Me.lblGbotOrigin = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNewY = New System.Windows.Forms.Label()
        Me.lblNewX = New System.Windows.Forms.Label()
        Me.lblNewOrigin = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnMoveDown = New System.Windows.Forms.Button()
        Me.btnMoveUp = New System.Windows.Forms.Button()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnMoveBackward = New System.Windows.Forms.Button()
        Me.btnMoveForward = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSbotPlane = New System.Windows.Forms.Label()
        Me.lblGbotPlane = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel14)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblConnected)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1435, 128)
        Me.Panel1.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.lblGbotPort)
        Me.Panel14.Controls.Add(Me.lblGbotIP)
        Me.Panel14.Controls.Add(Me.lblGbotStatus)
        Me.Panel14.Controls.Add(Me.Label2)
        Me.Panel14.Controls.Add(Me.lblRobotPort)
        Me.Panel14.Controls.Add(Me.lblRobotIP)
        Me.Panel14.Controls.Add(Me.lblRobotStatus)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(193, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(195, 128)
        Me.Panel14.TabIndex = 2
        '
        'lblGbotPort
        '
        Me.lblGbotPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotPort.Location = New System.Drawing.Point(0, 96)
        Me.lblGbotPort.Name = "lblGbotPort"
        Me.lblGbotPort.Size = New System.Drawing.Size(193, 16)
        Me.lblGbotPort.TabIndex = 14
        Me.lblGbotPort.Text = "Gbot Port:"
        Me.lblGbotPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGbotIP
        '
        Me.lblGbotIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotIP.Location = New System.Drawing.Point(0, 80)
        Me.lblGbotIP.Name = "lblGbotIP"
        Me.lblGbotIP.Size = New System.Drawing.Size(193, 16)
        Me.lblGbotIP.TabIndex = 13
        Me.lblGbotIP.Text = "Gbot IP:"
        Me.lblGbotIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGbotStatus
        '
        Me.lblGbotStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotStatus.Location = New System.Drawing.Point(0, 64)
        Me.lblGbotStatus.Name = "lblGbotStatus"
        Me.lblGbotStatus.Size = New System.Drawing.Size(193, 16)
        Me.lblGbotStatus.TabIndex = 15
        Me.lblGbotStatus.Text = "Gbot Status:"
        Me.lblGbotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRobotPort
        '
        Me.lblRobotPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotPort.Location = New System.Drawing.Point(0, 32)
        Me.lblRobotPort.Name = "lblRobotPort"
        Me.lblRobotPort.Size = New System.Drawing.Size(193, 16)
        Me.lblRobotPort.TabIndex = 17
        Me.lblRobotPort.Text = "Sbot Port:"
        Me.lblRobotPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRobotIP
        '
        Me.lblRobotIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotIP.Location = New System.Drawing.Point(0, 16)
        Me.lblRobotIP.Name = "lblRobotIP"
        Me.lblRobotIP.Size = New System.Drawing.Size(193, 16)
        Me.lblRobotIP.TabIndex = 16
        Me.lblRobotIP.Text = "Sbot IP:"
        Me.lblRobotIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRobotStatus
        '
        Me.lblRobotStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblRobotStatus.Name = "lblRobotStatus"
        Me.lblRobotStatus.Size = New System.Drawing.Size(193, 16)
        Me.lblRobotStatus.TabIndex = 18
        Me.lblRobotStatus.Text = "Sbot Status:"
        Me.lblRobotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblPort)
        Me.Panel4.Controls.Add(Me.lblIP)
        Me.Panel4.Controls.Add(Me.lblStatus)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.lblComputerPortGbot)
        Me.Panel4.Controls.Add(Me.lblComputerPortSbot)
        Me.Panel4.Controls.Add(Me.lblComputerIP)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(193, 128)
        Me.Panel4.TabIndex = 1
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(0, 96)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(191, 16)
        Me.lblPort.TabIndex = 5
        Me.lblPort.Text = "Cognex Port:"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(0, 80)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(191, 16)
        Me.lblIP.TabIndex = 4
        Me.lblIP.Text = "Cognex IP:"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(0, 64)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(191, 16)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Cognex Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputerPortGbot
        '
        Me.lblComputerPortGbot.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblComputerPortGbot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerPortGbot.Location = New System.Drawing.Point(0, 32)
        Me.lblComputerPortGbot.Name = "lblComputerPortGbot"
        Me.lblComputerPortGbot.Size = New System.Drawing.Size(191, 16)
        Me.lblComputerPortGbot.TabIndex = 21
        Me.lblComputerPortGbot.Text = "Computer Port Gbot:"
        Me.lblComputerPortGbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputerPortSbot
        '
        Me.lblComputerPortSbot.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblComputerPortSbot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerPortSbot.Location = New System.Drawing.Point(0, 16)
        Me.lblComputerPortSbot.Name = "lblComputerPortSbot"
        Me.lblComputerPortSbot.Size = New System.Drawing.Size(191, 16)
        Me.lblComputerPortSbot.TabIndex = 8
        Me.lblComputerPortSbot.Text = "Computer Port Sbot:"
        Me.lblComputerPortSbot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputerIP
        '
        Me.lblComputerIP.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblComputerIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerIP.Location = New System.Drawing.Point(0, 0)
        Me.lblComputerIP.Name = "lblComputerIP"
        Me.lblComputerIP.Size = New System.Drawing.Size(191, 16)
        Me.lblComputerIP.TabIndex = 9
        Me.lblComputerIP.Text = "Computer IP:"
        Me.lblComputerIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConnected
        '
        Me.lblConnected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblConnected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.Location = New System.Drawing.Point(0, 0)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(1435, 128)
        Me.lblConnected.TabIndex = 0
        Me.lblConnected.Text = "UR/Cognex Interaction"
        Me.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGF
        '
        Me.btnGF.BackColor = System.Drawing.Color.Yellow
        Me.btnGF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGF.Location = New System.Drawing.Point(300, 0)
        Me.btnGF.Name = "btnGF"
        Me.btnGF.Size = New System.Drawing.Size(150, 70)
        Me.btnGF.TabIndex = 1
        Me.btnGF.Text = "Get Loaded File"
        Me.btnGF.UseVisualStyleBackColor = False
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.Yellow
        Me.btnOn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOn.Location = New System.Drawing.Point(0, 0)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(150, 70)
        Me.btnOn.TabIndex = 2
        Me.btnOn.Text = "Turn Online"
        Me.btnOn.UseVisualStyleBackColor = False
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.Yellow
        Me.btnOff.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOff.Location = New System.Drawing.Point(150, 0)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(150, 70)
        Me.btnOff.TabIndex = 3
        Me.btnOff.Text = "Turn Offline"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnTrigger)
        Me.Panel2.Controls.Add(Me.btnGF)
        Me.Panel2.Controls.Add(Me.btnOff)
        Me.Panel2.Controls.Add(Me.btnOn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1435, 72)
        Me.Panel2.TabIndex = 7
        '
        'btnTrigger
        '
        Me.btnTrigger.BackColor = System.Drawing.Color.Yellow
        Me.btnTrigger.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrigger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTrigger.Location = New System.Drawing.Point(450, 0)
        Me.btnTrigger.Name = "btnTrigger"
        Me.btnTrigger.Size = New System.Drawing.Size(150, 70)
        Me.btnTrigger.TabIndex = 4
        Me.btnTrigger.Text = "Trigger"
        Me.btnTrigger.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnRun)
        Me.Panel5.Controls.Add(Me.btnRobotPos)
        Me.Panel5.Controls.Add(Me.btnAboveHole)
        Me.Panel5.Controls.Add(Me.btnGoHome)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 200)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1435, 72)
        Me.Panel5.TabIndex = 10
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Green
        Me.btnRun.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRun.Location = New System.Drawing.Point(450, 0)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(150, 70)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "Run Program"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'btnRobotPos
        '
        Me.btnRobotPos.BackColor = System.Drawing.Color.Gray
        Me.btnRobotPos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRobotPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRobotPos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRobotPos.Location = New System.Drawing.Point(300, 0)
        Me.btnRobotPos.Name = "btnRobotPos"
        Me.btnRobotPos.Size = New System.Drawing.Size(150, 70)
        Me.btnRobotPos.TabIndex = 6
        Me.btnRobotPos.Text = "Get Pose"
        Me.btnRobotPos.UseVisualStyleBackColor = False
        '
        'btnAboveHole
        '
        Me.btnAboveHole.BackColor = System.Drawing.Color.Gray
        Me.btnAboveHole.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAboveHole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboveHole.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAboveHole.Location = New System.Drawing.Point(150, 0)
        Me.btnAboveHole.Name = "btnAboveHole"
        Me.btnAboveHole.Size = New System.Drawing.Size(150, 70)
        Me.btnAboveHole.TabIndex = 8
        Me.btnAboveHole.Text = "Above Hole"
        Me.btnAboveHole.UseVisualStyleBackColor = False
        '
        'btnGoHome
        '
        Me.btnGoHome.BackColor = System.Drawing.Color.Gray
        Me.btnGoHome.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGoHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGoHome.Location = New System.Drawing.Point(0, 0)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(150, 70)
        Me.btnGoHome.TabIndex = 4
        Me.btnGoHome.Text = "Go Home"
        Me.btnGoHome.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblPastY)
        Me.Panel3.Controls.Add(Me.lblPastX)
        Me.Panel3.Controls.Add(Me.lblY)
        Me.Panel3.Controls.Add(Me.lblX)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 203)
        Me.Panel3.TabIndex = 11
        '
        'lblPastY
        '
        Me.lblPastY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPastY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastY.Location = New System.Drawing.Point(0, 100)
        Me.lblPastY.Name = "lblPastY"
        Me.lblPastY.Size = New System.Drawing.Size(265, 25)
        Me.lblPastY.TabIndex = 12
        Me.lblPastY.Text = "Previous Y: "
        '
        'lblPastX
        '
        Me.lblPastX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPastX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastX.Location = New System.Drawing.Point(0, 75)
        Me.lblPastX.Name = "lblPastX"
        Me.lblPastX.Size = New System.Drawing.Size(265, 25)
        Me.lblPastX.TabIndex = 11
        Me.lblPastX.Text = "Previous X: "
        '
        'lblY
        '
        Me.lblY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(0, 50)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(265, 25)
        Me.lblY.TabIndex = 10
        Me.lblY.Text = "Y: "
        '
        'lblX
        '
        Me.lblX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(0, 25)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(265, 25)
        Me.lblX.TabIndex = 9
        Me.lblX.Text = "X: "
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hole Coordinates"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lblYDev)
        Me.Panel6.Controls.Add(Me.lblXDev)
        Me.Panel6.Controls.Add(Me.lblAvgY)
        Me.Panel6.Controls.Add(Me.lblAvgX)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(267, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(281, 203)
        Me.Panel6.TabIndex = 12
        '
        'lblYDev
        '
        Me.lblYDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblYDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYDev.Location = New System.Drawing.Point(0, 100)
        Me.lblYDev.Name = "lblYDev"
        Me.lblYDev.Size = New System.Drawing.Size(279, 25)
        Me.lblYDev.TabIndex = 14
        Me.lblYDev.Text = "Avg Y Dev:"
        '
        'lblXDev
        '
        Me.lblXDev.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblXDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXDev.Location = New System.Drawing.Point(0, 75)
        Me.lblXDev.Name = "lblXDev"
        Me.lblXDev.Size = New System.Drawing.Size(279, 25)
        Me.lblXDev.TabIndex = 13
        Me.lblXDev.Text = "Avg X Dev:"
        '
        'lblAvgY
        '
        Me.lblAvgY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvgY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgY.Location = New System.Drawing.Point(0, 50)
        Me.lblAvgY.Name = "lblAvgY"
        Me.lblAvgY.Size = New System.Drawing.Size(279, 25)
        Me.lblAvgY.TabIndex = 12
        Me.lblAvgY.Text = "Avg Y:"
        '
        'lblAvgX
        '
        Me.lblAvgX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAvgX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgX.Location = New System.Drawing.Point(0, 25)
        Me.lblAvgX.Name = "lblAvgX"
        Me.lblAvgX.Size = New System.Drawing.Size(279, 25)
        Me.lblAvgX.TabIndex = 11
        Me.lblAvgX.Text = "Avg X:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Averages"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel13)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(349, 320)
        Me.Panel7.TabIndex = 13
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.lblPanelRZ)
        Me.Panel13.Controls.Add(Me.lblPanelRY)
        Me.Panel13.Controls.Add(Me.lblPanelRX)
        Me.Panel13.Controls.Add(Me.lblPanelZ)
        Me.Panel13.Controls.Add(Me.lblPanelY)
        Me.Panel13.Controls.Add(Me.lblPanelX)
        Me.Panel13.Controls.Add(Me.Label14)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 194)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(347, 179)
        Me.Panel13.TabIndex = 11
        '
        'lblPanelRZ
        '
        Me.lblPanelRZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelRZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelRZ.Location = New System.Drawing.Point(0, 150)
        Me.lblPanelRZ.Name = "lblPanelRZ"
        Me.lblPanelRZ.Size = New System.Drawing.Size(347, 23)
        Me.lblPanelRZ.TabIndex = 22
        Me.lblPanelRZ.Text = "RZ:"
        '
        'lblPanelRY
        '
        Me.lblPanelRY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelRY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelRY.Location = New System.Drawing.Point(0, 125)
        Me.lblPanelRY.Name = "lblPanelRY"
        Me.lblPanelRY.Size = New System.Drawing.Size(347, 25)
        Me.lblPanelRY.TabIndex = 21
        Me.lblPanelRY.Text = "RY:"
        '
        'lblPanelRX
        '
        Me.lblPanelRX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelRX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelRX.Location = New System.Drawing.Point(0, 100)
        Me.lblPanelRX.Name = "lblPanelRX"
        Me.lblPanelRX.Size = New System.Drawing.Size(347, 25)
        Me.lblPanelRX.TabIndex = 20
        Me.lblPanelRX.Text = "RX:"
        '
        'lblPanelZ
        '
        Me.lblPanelZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelZ.Location = New System.Drawing.Point(0, 75)
        Me.lblPanelZ.Name = "lblPanelZ"
        Me.lblPanelZ.Size = New System.Drawing.Size(347, 25)
        Me.lblPanelZ.TabIndex = 19
        Me.lblPanelZ.Text = "Z:"
        '
        'lblPanelY
        '
        Me.lblPanelY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelY.Location = New System.Drawing.Point(0, 50)
        Me.lblPanelY.Name = "lblPanelY"
        Me.lblPanelY.Size = New System.Drawing.Size(347, 25)
        Me.lblPanelY.TabIndex = 18
        Me.lblPanelY.Text = "Y:"
        '
        'lblPanelX
        '
        Me.lblPanelX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelX.Location = New System.Drawing.Point(0, 25)
        Me.lblPanelX.Name = "lblPanelX"
        Me.lblPanelX.Size = New System.Drawing.Size(347, 25)
        Me.lblPanelX.TabIndex = 17
        Me.lblPanelX.Text = "X:"
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(347, 25)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Panel Plane:"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.lblRobotRZ)
        Me.Panel12.Controls.Add(Me.lblRobotRY)
        Me.Panel12.Controls.Add(Me.lblRobotRX)
        Me.Panel12.Controls.Add(Me.lblRobotZ)
        Me.Panel12.Controls.Add(Me.lblRobotY)
        Me.Panel12.Controls.Add(Me.lblRobotX)
        Me.Panel12.Controls.Add(Me.Label13)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 25)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(347, 169)
        Me.Panel12.TabIndex = 10
        '
        'lblRobotRZ
        '
        Me.lblRobotRZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotRZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotRZ.Location = New System.Drawing.Point(0, 147)
        Me.lblRobotRZ.Name = "lblRobotRZ"
        Me.lblRobotRZ.Size = New System.Drawing.Size(347, 23)
        Me.lblRobotRZ.TabIndex = 22
        Me.lblRobotRZ.Text = "RZ:"
        '
        'lblRobotRY
        '
        Me.lblRobotRY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotRY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotRY.Location = New System.Drawing.Point(0, 122)
        Me.lblRobotRY.Name = "lblRobotRY"
        Me.lblRobotRY.Size = New System.Drawing.Size(347, 25)
        Me.lblRobotRY.TabIndex = 21
        Me.lblRobotRY.Text = "RY:"
        '
        'lblRobotRX
        '
        Me.lblRobotRX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotRX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotRX.Location = New System.Drawing.Point(0, 97)
        Me.lblRobotRX.Name = "lblRobotRX"
        Me.lblRobotRX.Size = New System.Drawing.Size(347, 25)
        Me.lblRobotRX.TabIndex = 20
        Me.lblRobotRX.Text = "RX:"
        '
        'lblRobotZ
        '
        Me.lblRobotZ.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotZ.Location = New System.Drawing.Point(0, 72)
        Me.lblRobotZ.Name = "lblRobotZ"
        Me.lblRobotZ.Size = New System.Drawing.Size(347, 25)
        Me.lblRobotZ.TabIndex = 19
        Me.lblRobotZ.Text = "Z:"
        '
        'lblRobotY
        '
        Me.lblRobotY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotY.Location = New System.Drawing.Point(0, 47)
        Me.lblRobotY.Name = "lblRobotY"
        Me.lblRobotY.Size = New System.Drawing.Size(347, 25)
        Me.lblRobotY.TabIndex = 18
        Me.lblRobotY.Text = "Y:"
        '
        'lblRobotX
        '
        Me.lblRobotX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRobotX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRobotX.Location = New System.Drawing.Point(0, 22)
        Me.lblRobotX.Name = "lblRobotX"
        Me.lblRobotX.Size = New System.Drawing.Size(347, 25)
        Me.lblRobotX.TabIndex = 17
        Me.lblRobotX.Text = "X:"
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(347, 22)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Base Plane:"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(347, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Robot Position"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel15)
        Me.Panel8.Controls.Add(Me.Panel11)
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 272)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1435, 203)
        Me.Panel8.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.lblGbotYDir)
        Me.Panel11.Controls.Add(Me.lblGbotXDir)
        Me.Panel11.Controls.Add(Me.lblGbotOrigin)
        Me.Panel11.Controls.Add(Me.Label5)
        Me.Panel11.Controls.Add(Me.lblNewY)
        Me.Panel11.Controls.Add(Me.lblNewX)
        Me.Panel11.Controls.Add(Me.lblNewOrigin)
        Me.Panel11.Controls.Add(Me.Label10)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(548, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(604, 203)
        Me.Panel11.TabIndex = 13
        '
        'lblGbotYDir
        '
        Me.lblGbotYDir.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotYDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotYDir.Location = New System.Drawing.Point(0, 175)
        Me.lblGbotYDir.Name = "lblGbotYDir"
        Me.lblGbotYDir.Size = New System.Drawing.Size(602, 25)
        Me.lblGbotYDir.TabIndex = 17
        Me.lblGbotYDir.Text = "Gbot Y-Direction:"
        '
        'lblGbotXDir
        '
        Me.lblGbotXDir.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotXDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotXDir.Location = New System.Drawing.Point(0, 150)
        Me.lblGbotXDir.Name = "lblGbotXDir"
        Me.lblGbotXDir.Size = New System.Drawing.Size(602, 25)
        Me.lblGbotXDir.TabIndex = 16
        Me.lblGbotXDir.Text = "Gbot X-Direction:"
        '
        'lblGbotOrigin
        '
        Me.lblGbotOrigin.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotOrigin.Location = New System.Drawing.Point(0, 125)
        Me.lblGbotOrigin.Name = "lblGbotOrigin"
        Me.lblGbotOrigin.Size = New System.Drawing.Size(602, 25)
        Me.lblGbotOrigin.TabIndex = 15
        Me.lblGbotOrigin.Text = "Gbot Origin:"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(602, 25)
        Me.Label5.TabIndex = 14
        '
        'lblNewY
        '
        Me.lblNewY.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNewY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewY.Location = New System.Drawing.Point(0, 75)
        Me.lblNewY.Name = "lblNewY"
        Me.lblNewY.Size = New System.Drawing.Size(602, 25)
        Me.lblNewY.TabIndex = 13
        Me.lblNewY.Text = "Sbot Y-Direction:"
        '
        'lblNewX
        '
        Me.lblNewX.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNewX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewX.Location = New System.Drawing.Point(0, 50)
        Me.lblNewX.Name = "lblNewX"
        Me.lblNewX.Size = New System.Drawing.Size(602, 25)
        Me.lblNewX.TabIndex = 12
        Me.lblNewX.Text = "Sbot X-Direction:"
        '
        'lblNewOrigin
        '
        Me.lblNewOrigin.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNewOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewOrigin.Location = New System.Drawing.Point(0, 25)
        Me.lblNewOrigin.Name = "lblNewOrigin"
        Me.lblNewOrigin.Size = New System.Drawing.Size(602, 25)
        Me.lblNewOrigin.TabIndex = 11
        Me.lblNewOrigin.Text = "Sbot Origin:"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(602, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "New Plane Origin Points"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.btnMoveDown)
        Me.Panel9.Controls.Add(Me.btnMoveUp)
        Me.Panel9.Controls.Add(Me.btnMoveRight)
        Me.Panel9.Controls.Add(Me.btnMoveLeft)
        Me.Panel9.Controls.Add(Me.btnMoveBackward)
        Me.Panel9.Controls.Add(Me.btnMoveForward)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(349, 475)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1086, 320)
        Me.Panel9.TabIndex = 15
        '
        'btnMoveDown
        '
        Me.btnMoveDown.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveDown.Location = New System.Drawing.Point(329, 189)
        Me.btnMoveDown.Name = "btnMoveDown"
        Me.btnMoveDown.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveDown.TabIndex = 19
        Me.btnMoveDown.Text = "↓"
        Me.btnMoveDown.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveDown.UseVisualStyleBackColor = False
        '
        'btnMoveUp
        '
        Me.btnMoveUp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveUp.Location = New System.Drawing.Point(329, 65)
        Me.btnMoveUp.Name = "btnMoveUp"
        Me.btnMoveUp.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveUp.TabIndex = 18
        Me.btnMoveUp.Text = "↑"
        Me.btnMoveUp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveUp.UseVisualStyleBackColor = False
        '
        'btnMoveRight
        '
        Me.btnMoveRight.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveRight.Location = New System.Drawing.Point(185, 126)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveRight.TabIndex = 14
        Me.btnMoveRight.Text = "→"
        Me.btnMoveRight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveRight.UseVisualStyleBackColor = False
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveLeft.Location = New System.Drawing.Point(39, 126)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveLeft.TabIndex = 13
        Me.btnMoveLeft.Text = "←"
        Me.btnMoveLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveLeft.UseVisualStyleBackColor = False
        '
        'btnMoveBackward
        '
        Me.btnMoveBackward.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveBackward.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveBackward.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveBackward.Location = New System.Drawing.Point(112, 189)
        Me.btnMoveBackward.Name = "btnMoveBackward"
        Me.btnMoveBackward.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveBackward.TabIndex = 12
        Me.btnMoveBackward.Text = "↓"
        Me.btnMoveBackward.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveBackward.UseVisualStyleBackColor = False
        '
        'btnMoveForward
        '
        Me.btnMoveForward.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMoveForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveForward.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMoveForward.Location = New System.Drawing.Point(112, 65)
        Me.btnMoveForward.Name = "btnMoveForward"
        Me.btnMoveForward.Size = New System.Drawing.Size(67, 61)
        Me.btnMoveForward.TabIndex = 11
        Me.btnMoveForward.Text = "↑"
        Me.btnMoveForward.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoveForward.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1086, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Move Robot"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 475)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(349, 320)
        Me.Panel10.TabIndex = 16
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.lblGbotPlane)
        Me.Panel15.Controls.Add(Me.lblSbotPlane)
        Me.Panel15.Controls.Add(Me.Label6)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(1152, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(283, 203)
        Me.Panel15.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "New Plane"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSbotPlane
        '
        Me.lblSbotPlane.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSbotPlane.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSbotPlane.Location = New System.Drawing.Point(0, 25)
        Me.lblSbotPlane.Name = "lblSbotPlane"
        Me.lblSbotPlane.Size = New System.Drawing.Size(283, 25)
        Me.lblSbotPlane.TabIndex = 12
        Me.lblSbotPlane.Text = "Sbot Plane: "
        '
        'lblGbotPlane
        '
        Me.lblGbotPlane.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGbotPlane.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGbotPlane.Location = New System.Drawing.Point(0, 50)
        Me.lblGbotPlane.Name = "lblGbotPlane"
        Me.lblGbotPlane.Size = New System.Drawing.Size(283, 25)
        Me.lblGbotPlane.TabIndex = 13
        Me.lblGbotPlane.Text = "Gbot Plane: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 795)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Cognex Connection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblConnected As Label
    Friend WithEvents btnGF As Button
    Friend WithEvents btnOn As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents lblIP As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTrigger As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnGoHome As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPastX As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblYDev As Label
    Friend WithEvents lblXDev As Label
    Friend WithEvents lblAvgY As Label
    Friend WithEvents lblAvgX As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnRobotPos As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents btnAboveHole As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnMoveRight As Button
    Friend WithEvents btnMoveLeft As Button
    Friend WithEvents btnMoveBackward As Button
    Friend WithEvents btnMoveForward As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnMoveDown As Button
    Friend WithEvents btnMoveUp As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblNewY As Label
    Friend WithEvents lblNewX As Label
    Friend WithEvents lblNewOrigin As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblPanelRZ As Label
    Friend WithEvents lblPanelRY As Label
    Friend WithEvents lblPanelRX As Label
    Friend WithEvents lblPanelZ As Label
    Friend WithEvents lblPanelY As Label
    Friend WithEvents lblPanelX As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblRobotRZ As Label
    Friend WithEvents lblRobotRY As Label
    Friend WithEvents lblRobotRX As Label
    Friend WithEvents lblRobotZ As Label
    Friend WithEvents lblRobotY As Label
    Friend WithEvents lblRobotX As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPastY As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lblRobotPort As Label
    Friend WithEvents lblRobotIP As Label
    Friend WithEvents lblRobotStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGbotPort As Label
    Friend WithEvents lblGbotIP As Label
    Friend WithEvents lblGbotStatus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblComputerPortGbot As Label
    Friend WithEvents lblComputerPortSbot As Label
    Friend WithEvents lblComputerIP As Label
    Friend WithEvents lblGbotYDir As Label
    Friend WithEvents lblGbotXDir As Label
    Friend WithEvents lblGbotOrigin As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblGbotPlane As Label
    Friend WithEvents lblSbotPlane As Label
    Friend WithEvents Label6 As Label
End Class

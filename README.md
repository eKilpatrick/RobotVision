# RobotVision
Provides a way to use a Cognex In-Sight vision system alongside a Universal Robots using socket connections and calculates coordinate positional data.

Program written to test the abilities of a Cognex In-sight Vision System on a Universal Robot. It connects to the camera via TCP/IP socket connection and then uses the built in commands to gather coordinate data of an image. The pattern recognition software created by Cognex allowed the creation of a program that was stored on the camera's SD card that gets the coordinate location of a hole on a panel in the camera's Field of View. Using the socket connection, this .Net program captures an image using the camera and receives said coordinate location. This allows the computer to know if the robot is in the correct location and if not, adjustments can be made.
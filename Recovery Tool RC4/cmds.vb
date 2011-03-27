Imports System.Management
Module cmds
    Public RecoveryToolVersion As String = "RC4 -2"
    Public UpdateVersion As String = ""
    Public SystemBit As String = ""
    Public iTunesStatus As String = ""
    Public RecoveryConnected As Boolean = False
    Dim temp = My.Computer.FileSystem.SpecialDirectories.Temp

    Public Sub Prep()
        Dim temp As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim recovery As String
        recovery = temp & "\StanTheRipper\Recovery"

        Form1.Label3.Visible = False
        Form1.PictureBox1.Visible = False

        If Not System.IO.Directory.Exists(recovery) Then
            Try
                System.IO.Directory.CreateDirectory(temp & "\StanTheRipper")
                System.IO.Directory.CreateDirectory(temp & "\StanTheRipper\Recovery")
            Catch ex As Exception
            End Try
        End If

        System.IO.File.WriteAllBytes(recovery & "\itunnel.exe", My.Resources.itunnel_mux_r61)
        'System.IO.File.WriteAllBytes(recovery & "\killall.exe", My.Resources.killall)
    End Sub

    Public Sub DetectiTunes()
        If System.Environment.Is64BitOperatingSystem.ToString = True Then

            'x64 Code
            SystemBit = "x64"
            If System.IO.Directory.Exists("C:\Program Files (x86)\iTunes") Then
            Else
                iTunesStatus = "Not Installed"
            End If
            System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", My.Resources.IPHUCWIN32)
            System.IO.File.WriteAllBytes("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\readline5.dll", My.Resources.readline5)
            If System.IO.File.Exists("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll") Then
                System.IO.File.Delete("C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
                System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            Else
                System.IO.File.Copy("C:\Program Files (x86)\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            End If
        Else

            'X86 Code
            SystemBit = "x86"
            If System.IO.Directory.Exists("C:\Program Files\iTunes") Then
            Else
                iTunesStatus = "Not Installed"
            End If
            System.IO.File.WriteAllBytes("C:\Program Files\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe", My.Resources.IPHUCWIN32)
            System.IO.File.WriteAllBytes("C:\Program Files\Common Files\Apple\Apple Application Support\readline5.dll", My.Resources.readline5)
            If System.IO.File.Exists("C:\Program Files\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll") Then
                System.IO.File.Delete("C:\Program Files\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
                System.IO.File.Copy("C:\Program Files\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            Else
                System.IO.File.Copy("C:\Program Files\Common Files\Apple\Mobile Device Support\iTunesMobileDevice.dll", "C:\Program Files\Common Files\Apple\Apple Application Support\iTunesMobileDevice.dll")
            End If
        End If


        If SystemBit = "x86" And iTunesStatus = "Not Installed" Then 'Epic Fail
            Form1.PictureBox1.Visible = True
            Form1.Button1.Enabled = False
            Form1.Button2.Enabled = False
            Form1.Label3.Visible = True
        End If

        If SystemBit = "x64" And iTunesStatus = "Not Installed" Then 'Epic Fail
            Form1.PictureBox1.Visible = True
            Form1.Label3.Visible = True
            Form1.Button1.Enabled = False
            Form1.Button2.Enabled = False
        End If
    End Sub


    Public Sub EnterRecoveryx86()
        Form1.searchingstatus.Visible = True
        Form1.idlestatus.Visible = False
        Form1.detectedstatus.Visible = False
        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Button1.Text = "Entering Recovery"
        Form1.Delay(1)
        Dim ProcessPropertiesenter As New ProcessStartInfo
        ProcessPropertiesenter.FileName = "C:\Program Files\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe"
        ProcessPropertiesenter.Arguments = "-qo enterrecovery"
        ProcessPropertiesenter.WindowStyle = ProcessWindowStyle.Hidden
        Dim myProcessenter As Process = Process.Start(ProcessPropertiesenter)
        myProcessenter.WaitForExit(8000)
        If Not myProcessenter.HasExited Then
            myProcessenter.Kill()
        End If
        Threading.Thread.Sleep(1)
        Form1.Button1.Text = "Entered Recovery"
        Form1.Delay(2)
        Form1.Button1.Text = "Enter Recovery"
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
    End Sub

    Public Sub EnterRecoveryx64()
        Form1.searchingstatus.Visible = True
        Form1.idlestatus.Visible = False
        Form1.detectedstatus.Visible = False
        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Button1.Text = "Entering Recovery"
        Form1.Delay(1)
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "C:\Program Files (x86)\Common Files\Apple\Apple Application Support\iPHUCWIN32.exe"
        ProcessProperties.Arguments = "-qo enterrecovery"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit(8000)
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If
        Threading.Thread.Sleep(1)
        Form1.Button1.Text = "Entered Recovery"
        Form1.Delay(2)
        Form1.Button1.Text = "Enter Recovery"
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
    End Sub

    Public Sub ExitRecovery()
        Dim temp As String
        temp = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim recovery As String
        recovery = temp & "\StanTheRipper\Recovery"

        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.Button2.Text = "Exiting Recovery"
        Form1.Delay(1)
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = recovery & "\itunnel.exe"
        ProcessProperties.Arguments = "--autoboot"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
        Dim myProcess As Process = Process.Start(ProcessProperties)
        myProcess.WaitForExit(8000)
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If
        Threading.Thread.Sleep(1)
        Form1.Button2.Text = "Exited Recovery"
        Form1.Delay(2)
        Form1.Button2.Text = "Exit Recovery"
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
    End Sub

    Public Sub CheckForUpdate()
        If Not My.Computer.Network.IsAvailable Then
            Exit Sub
        End If
        If System.IO.File.Exists(temp & "\recoveryversion.xml") Then
            System.IO.File.Delete(temp & "\recoveryversion.xml")
        End If
        Try
            My.Computer.Network.DownloadFile("http://stantheripper.com/recoveryversion.lol", temp & "\recoveryversion.xml")
            UpdateVersion = My.Computer.FileSystem.ReadAllText(temp & "\recoveryversion.xml")
            If Not RecoveryToolVersion = UpdateVersion Then
                If Not My.Settings.showupdatemessage = "No" Then
                    Dim answer = MsgBox("Update available!" & vbCrLf & vbCrLf & "Version: " & UpdateVersion & vbCrLf & "Would you like to download?", vbYesNo)
                    If answer = vbYes Then
                        System.Diagnostics.Process.Start("http://recovery.stantheripper.com")
                    End If

                    If answer = vbNo Then
                        Dim answer1 = MsgBox("Do you want this message to show again?", vbYesNo)
                        If answer1 = vbNo Then
                            My.Settings.showupdatemessage = "No"
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
        System.IO.File.Delete(temp & "\recoveryversion.xml")
    End Sub
End Module

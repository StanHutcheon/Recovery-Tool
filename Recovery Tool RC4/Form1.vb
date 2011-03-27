Imports System.Management

Public Class Form1
    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Prep()
        DetectiTunes()
        Dim a_strArgs() As String


        Dim i As Integer

        a_strArgs = Split(Command$, " ")
        For i = LBound(a_strArgs) To UBound(a_strArgs)
            Select Case LCase(a_strArgs(i))
                Case "-e"
                    Me.ShowInTaskbar = False
                    If SystemBit = "x64" Then
                        If iTunesStatus = "Not Installed" Then
                            MsgBox("You need iTunes installed")
                            Me.Close()
                        End If
                        EnterRecoveryx64()
                    ElseIf SystemBit = "x86" Then
                        If iTunesStatus = "Not Installed" Then
                            MsgBox("You need iTunes installed")
                            Me.Close()
                        End If
                        EnterRecoveryx86()
                    End If
                    Me.Close()
                Case "-x"
                    Me.ShowInTaskbar = False
                    ExitRecovery()
                    Me.Close()
                Case "-h"
                    Me.Hide()
                    Me.ShowInTaskbar = False
                    MsgBox("-h = Opens this window" & vbCrLf & "-e = Enter Recovery Mode" & vbCrLf & "-x = Exit Recovery Mode" & vbCrLf & "-d = Simulates iTunes not being installed (for diagnostics only)")
                    Me.Close()
                Case ""
                    CheckForUpdate()
                Case "-d"
                    'diags mode
                    My.Settings.itunesstatusx64 = "Not Installed"
                    My.Settings.itunesstatusx86 = "Not Installed"
                    PictureBox1.Visible = True
                    Label3.Visible = True
                    Button1.Enabled = False
                    Button2.Enabled = False
                Case Else
                    MsgBox("Invalid argument")
                    Me.Close()
            End Select
        Next
        Me.Show()
        MaximizeBox = False
        KeyPreview = True
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        HelpButton = True
        Label1.Select()
        searchingstatus.Visible = False
        detectedstatus.Visible = False
        My.Settings.itunesstatusx64 = ""
        My.Settings.itunesstatusx86 = ""
    End Sub

    'Enter Recovery
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.itunesstatusx64 = "Not Installed" Or My.Settings.itunesstatusx86 = "Not Installed" Then
            MsgBox("iTunes is required to enter recovery")
            Exit Sub
        Else
            If My.Settings.system = "x64" Then
                EnterRecoveryx64()
            End If

            If My.Settings.system = "x86" Then
                EnterRecoveryx86()
            End If
        End If
    End Sub

    'Exit Recovery
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Settings.itunesstatusx64 = "Not Installed" Or My.Settings.itunesstatusx86 = "Not Installed" Then
            MsgBox("iTunes is required to exit recovery")
            Exit Sub
        Else
            ExitRecovery()
        End If
    End Sub

    'Download iTunes
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("http://www.apple.com/itunes/download/")
    End Sub

    'Site Link
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://stantheripper.com")
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.E Then
            If My.Settings.system = "x64" Then
                EnterRecoveryx64()
            Else
                EnterRecoveryx86()
            End If
        End If

        If e.KeyCode = Keys.X Then
            ExitRecovery()
        End If

        If e.KeyCode = Keys.H Then
            MsgBox("Shortcuts:" & vbCrLf & " if e key pressed, you Enter Recovery" & vbCrLf & " if x key pressed, you Exit Recovery" & vbCrLf & " if F1 or h key pressed, This menu is shown", MsgBoxStyle.Information, "Recovery Tool | Help")
        End If

        If e.KeyCode = Keys.F1 Then
            MsgBox("Shortcuts:" & vbCrLf & " if e key pressed, you Enter Recovery" & vbCrLf & " if x key pressed, you Exit Recovery" & vbCrLf & " if F1 or h key pressed, This menu is shown", MsgBoxStyle.Information, "Recovery Tool | Help")

        End If
    End Sub

    Private Sub Button1_HelpRequested(ByVal sender As System.Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Button1.HelpRequested
        MsgBox("This button puts your device in Recovery Mode" & vbCrLf & "Or you can press the E key", MsgBoxStyle.Information, "Recovery Tool | Help")
    End Sub

    Private Sub Button2_HelpRequested(ByVal sender As System.Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles Button2.HelpRequested
        MsgBox("This button kicks your device out of Recovery Mode" & vbCrLf & "Or you can press the X key", MsgBoxStyle.Information, "Recovery Tool | Help")
    End Sub

    Private Sub Form1_HelpRequested(ByVal sender As System.Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles MyBase.HelpRequested
        MsgBox("Shortcuts:" & vbCrLf & "  if e key pressed, you Enter Recovery" & vbCrLf & "  if x key pressed, you Exit Recovery" & vbCrLf & "  if F1 or h key pressed, This menu is shown", MsgBoxStyle.Information, "Recovery Tool | Help")
    End Sub

    Private Sub LinkLabel1_HelpRequested(ByVal sender As System.Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs)
        MsgBox("This label will take you to my site", MsgBoxStyle.Information, "Recovery Tool | Help")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        System.Diagnostics.Process.Start("http://www.apple.com/itunes/download/")
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        System.Diagnostics.Process.Start("http://stantheripper.com")
    End Sub
End Class

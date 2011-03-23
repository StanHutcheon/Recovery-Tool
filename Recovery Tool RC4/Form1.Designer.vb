<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.console = New System.Windows.Forms.RichTextBox()
        Me.idlestatus = New System.Windows.Forms.Label()
        Me.detectedstatus = New System.Windows.Forms.Label()
        Me.searchingstatus = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 73)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter Recovery"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(283, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 73)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit Recovery"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recovery Tool RC4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(144, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "By StanTheRipper"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Recovery_Tool_RC4.My.Resources.Resources.Untitled_1
        Me.PictureBox1.Location = New System.Drawing.Point(184, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 71)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(185, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Download"
        '
        'console
        '
        Me.console.Location = New System.Drawing.Point(12, 295)
        Me.console.Name = "console"
        Me.console.Size = New System.Drawing.Size(10, 13)
        Me.console.TabIndex = 7
        Me.console.Text = ""
        Me.console.Visible = False
        '
        'idlestatus
        '
        Me.idlestatus.AutoSize = True
        Me.idlestatus.BackColor = System.Drawing.Color.Transparent
        Me.idlestatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.idlestatus.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idlestatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.idlestatus.Location = New System.Drawing.Point(179, 163)
        Me.idlestatus.Name = "idlestatus"
        Me.idlestatus.Size = New System.Drawing.Size(83, 13)
        Me.idlestatus.TabIndex = 8
        Me.idlestatus.Text = "Status: Idle"
        '
        'detectedstatus
        '
        Me.detectedstatus.AutoSize = True
        Me.detectedstatus.BackColor = System.Drawing.Color.Transparent
        Me.detectedstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detectedstatus.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.detectedstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.detectedstatus.Location = New System.Drawing.Point(103, 163)
        Me.detectedstatus.Name = "detectedstatus"
        Me.detectedstatus.Size = New System.Drawing.Size(234, 13)
        Me.detectedstatus.TabIndex = 9
        Me.detectedstatus.Text = "Status: Recovery Device Detected"
        '
        'searchingstatus
        '
        Me.searchingstatus.AutoSize = True
        Me.searchingstatus.BackColor = System.Drawing.Color.Transparent
        Me.searchingstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchingstatus.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchingstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchingstatus.Location = New System.Drawing.Point(115, 163)
        Me.searchingstatus.Name = "searchingstatus"
        Me.searchingstatus.Size = New System.Drawing.Size(210, 13)
        Me.searchingstatus.TabIndex = 10
        Me.searchingstatus.Text = "Status: Searching For Recovery"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Recovery_Tool_RC4.My.Resources.Resources.recbackground
        Me.ClientSize = New System.Drawing.Size(440, 159)
        Me.Controls.Add(Me.searchingstatus)
        Me.Controls.Add(Me.detectedstatus)
        Me.Controls.Add(Me.idlestatus)
        Me.Controls.Add(Me.console)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recovery Tool RC4 -2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents console As System.Windows.Forms.RichTextBox
    Friend WithEvents idlestatus As System.Windows.Forms.Label
    Friend WithEvents detectedstatus As System.Windows.Forms.Label
    Friend WithEvents searchingstatus As System.Windows.Forms.Label

End Class

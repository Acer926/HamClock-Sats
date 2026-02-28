<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHamClockeSats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHamClockeSats))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LblSatAge = New System.Windows.Forms.Label()
        Me.LblDebug = New System.Windows.Forms.Label()
        Me.LblRunning = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(472, 207)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(226, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(450, 22)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "https://www.amsat.org/tle/current/nasabare.txt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Path to TLE.txt  download"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path to your HamClock Folder"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(240, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(438, 22)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "\\wsl$\Ubuntu\home\YourCallSign\.hamclock\esats.txt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Change to your folders names and callsign if thats needed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 80)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "This is my install , " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "yours may be different" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your looking for the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "esats.txt fi" &
    "le."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(292, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(410, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "UpDate eSats.txt and START"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(94, 411)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Download new TLEs and replace the old file"
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "HamClock-eSats"
        Me.NotifyIcon1.Text = "HamClock-eSats"
        Me.NotifyIcon1.Visible = True
        '
        'LblSatAge
        '
        Me.LblSatAge.AutoSize = True
        Me.LblSatAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSatAge.Location = New System.Drawing.Point(10, 324)
        Me.LblSatAge.Name = "LblSatAge"
        Me.LblSatAge.Size = New System.Drawing.Size(108, 16)
        Me.LblSatAge.TabIndex = 10
        Me.LblSatAge.Text = "Sat File Age is"
        '
        'LblDebug
        '
        Me.LblDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDebug.Location = New System.Drawing.Point(21, 133)
        Me.LblDebug.Name = "LblDebug"
        Me.LblDebug.Size = New System.Drawing.Size(647, 19)
        Me.LblDebug.TabIndex = 11
        Me.LblDebug.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblRunning
        '
        Me.LblRunning.AutoSize = True
        Me.LblRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRunning.Location = New System.Drawing.Point(13, 359)
        Me.LblRunning.Name = "LblRunning"
        Me.LblRunning.Size = New System.Drawing.Size(70, 16)
        Me.LblRunning.TabIndex = 12
        Me.LblRunning.Text = "Timer Off"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem1.Text = "Open"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "If on then updates at 2.5hours"
        '
        'FrmHamClockeSats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblRunning)
        Me.Controls.Add(Me.LblDebug)
        Me.Controls.Add(Me.LblSatAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHamClockeSats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HamClock-eSats Fixer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LblSatAge As Label
    Friend WithEvents LblDebug As Label
    Friend WithEvents LblRunning As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label7 As Label
End Class

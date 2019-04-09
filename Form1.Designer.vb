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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LogInThemeContainer1 = New LoLPingCheckerBySleep1337.LogInThemeContainer()
        Me.LogInGroupBox1 = New LoLPingCheckerBySleep1337.LogInGroupBox()
        Me.LogInCheckBox4 = New LoLPingCheckerBySleep1337.LogInCheckBox()
        Me.LogInCheckBox3 = New LoLPingCheckerBySleep1337.LogInCheckBox()
        Me.LogInCheckBox2 = New LoLPingCheckerBySleep1337.LogInCheckBox()
        Me.LogInCheckBox1 = New LoLPingCheckerBySleep1337.LogInCheckBox()
        Me.LogInRadialProgressBar1 = New LoLPingCheckerBySleep1337.LogInRadialProgressBar()
        Me.LogInProgressBar1 = New LoLPingCheckerBySleep1337.LogInProgressBar()
        Me.LogInStatusBar1 = New LoLPingCheckerBySleep1337.LogInStatusBar()
        Me.LogInThemeContainer1.SuspendLayout()
        Me.LogInGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 25
        '
        'LogInThemeContainer1
        '
        Me.LogInThemeContainer1.AllowClose = True
        Me.LogInThemeContainer1.AllowMaximize = False
        Me.LogInThemeContainer1.AllowMinimize = True
        Me.LogInThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInThemeContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LogInThemeContainer1.ContainerColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LogInThemeContainer1.Controls.Add(Me.LogInGroupBox1)
        Me.LogInThemeContainer1.Controls.Add(Me.LogInStatusBar1)
        Me.LogInThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogInThemeContainer1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInThemeContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInThemeContainer1.FontSize = 12
        Me.LogInThemeContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.LogInThemeContainer1.Name = "LogInThemeContainer1"
        Me.LogInThemeContainer1.ShowIcon = True
        Me.LogInThemeContainer1.Size = New System.Drawing.Size(310, 531)
        Me.LogInThemeContainer1.TabIndex = 1
        Me.LogInThemeContainer1.Text = "LoL Pinger by sleep1337"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInCheckBox4)
        Me.LogInGroupBox1.Controls.Add(Me.LogInCheckBox3)
        Me.LogInGroupBox1.Controls.Add(Me.LogInCheckBox2)
        Me.LogInGroupBox1.Controls.Add(Me.LogInCheckBox1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadialProgressBar1)
        Me.LogInGroupBox1.Controls.Add(Me.LogInProgressBar1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(286, 460)
        Me.LogInGroupBox1.TabIndex = 3
        Me.LogInGroupBox1.Text = "Main"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInCheckBox4
        '
        Me.LogInCheckBox4.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox4.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox4.Checked = False
        Me.LogInCheckBox4.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LogInCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox4.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInCheckBox4.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox4.Location = New System.Drawing.Point(22, 120)
        Me.LogInCheckBox4.Name = "LogInCheckBox4"
        Me.LogInCheckBox4.Size = New System.Drawing.Size(244, 22)
        Me.LogInCheckBox4.TabIndex = 10
        Me.LogInCheckBox4.Text = "LAN"
        '
        'LogInCheckBox3
        '
        Me.LogInCheckBox3.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox3.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox3.Checked = False
        Me.LogInCheckBox3.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LogInCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox3.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInCheckBox3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox3.Location = New System.Drawing.Point(22, 92)
        Me.LogInCheckBox3.Name = "LogInCheckBox3"
        Me.LogInCheckBox3.Size = New System.Drawing.Size(244, 22)
        Me.LogInCheckBox3.TabIndex = 9
        Me.LogInCheckBox3.Text = "NA"
        '
        'LogInCheckBox2
        '
        Me.LogInCheckBox2.AllowDrop = True
        Me.LogInCheckBox2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox2.Checked = False
        Me.LogInCheckBox2.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LogInCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox2.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInCheckBox2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox2.Location = New System.Drawing.Point(22, 64)
        Me.LogInCheckBox2.Name = "LogInCheckBox2"
        Me.LogInCheckBox2.Size = New System.Drawing.Size(244, 22)
        Me.LogInCheckBox2.TabIndex = 8
        Me.LogInCheckBox2.Text = "EUNE"
        '
        'LogInCheckBox1
        '
        Me.LogInCheckBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInCheckBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInCheckBox1.Checked = False
        Me.LogInCheckBox1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.LogInCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInCheckBox1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInCheckBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInCheckBox1.Location = New System.Drawing.Point(22, 36)
        Me.LogInCheckBox1.Name = "LogInCheckBox1"
        Me.LogInCheckBox1.Size = New System.Drawing.Size(244, 22)
        Me.LogInCheckBox1.TabIndex = 7
        Me.LogInCheckBox1.Text = "EUW"
        '
        'LogInRadialProgressBar1
        '
        Me.LogInRadialProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.LogInRadialProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInRadialProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadialProgressBar1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInRadialProgressBar1.Location = New System.Drawing.Point(22, 161)
        Me.LogInRadialProgressBar1.Maximum = 400
        Me.LogInRadialProgressBar1.Name = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInRadialProgressBar1.RotationAngle = 365
        Me.LogInRadialProgressBar1.Size = New System.Drawing.Size(244, 241)
        Me.LogInRadialProgressBar1.StartingAngle = 90
        Me.LogInRadialProgressBar1.TabIndex = 0
        Me.LogInRadialProgressBar1.Text = "LogInRadialProgressBar1"
        Me.LogInRadialProgressBar1.Value = 0
        '
        'LogInProgressBar1
        '
        Me.LogInProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInProgressBar1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LogInProgressBar1.Location = New System.Drawing.Point(22, 420)
        Me.LogInProgressBar1.Maximum = 100
        Me.LogInProgressBar1.Name = "LogInProgressBar1"
        Me.LogInProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.LogInProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.LogInProgressBar1.Size = New System.Drawing.Size(244, 25)
        Me.LogInProgressBar1.TabIndex = 6
        Me.LogInProgressBar1.Text = "LogInProgressBar1"
        Me.LogInProgressBar1.TwoColour = True
        Me.LogInProgressBar1.Value = 0
        '
        'LogInStatusBar1
        '
        Me.LogInStatusBar1.Alignment = LoLPingCheckerBySleep1337.LogInStatusBar.Alignments.Left
        Me.LogInStatusBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInStatusBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogInStatusBar1.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogInStatusBar1.ForeColor = System.Drawing.Color.White
        Me.LogInStatusBar1.LinesToShow = LoLPingCheckerBySleep1337.LogInStatusBar.LinesCount.One
        Me.LogInStatusBar1.Location = New System.Drawing.Point(0, 508)
        Me.LogInStatusBar1.Name = "LogInStatusBar1"
        Me.LogInStatusBar1.RectangleColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.LogInStatusBar1.ShowBorder = True
        Me.LogInStatusBar1.ShowLine = True
        Me.LogInStatusBar1.Size = New System.Drawing.Size(310, 23)
        Me.LogInStatusBar1.TabIndex = 2
        Me.LogInStatusBar1.Text = "Loading..."
        Me.LogInStatusBar1.TextColour = System.Drawing.Color.White
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 531)
        Me.Controls.Add(Me.LogInThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lol ping checker by sleep1337"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LogInThemeContainer1.ResumeLayout(False)
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogInThemeContainer1 As LogInThemeContainer
    Friend WithEvents LogInGroupBox1 As LogInGroupBox
    Friend WithEvents LogInCheckBox4 As LogInCheckBox
    Friend WithEvents LogInCheckBox3 As LogInCheckBox
    Friend WithEvents LogInCheckBox2 As LogInCheckBox
    Friend WithEvents LogInCheckBox1 As LogInCheckBox
    Friend WithEvents LogInRadialProgressBar1 As LogInRadialProgressBar
    Friend WithEvents LogInProgressBar1 As LogInProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LogInStatusBar1 As LogInStatusBar
End Class

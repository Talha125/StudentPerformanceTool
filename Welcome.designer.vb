<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New ns1.BunifuImageButton()
        Me.BunifuImageButton4 = New ns1.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Progressbar = New ns1.BunifuCircleProgressbar()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.BunifuImageButton3 = New ns1.BunifuImageButton()
        Me.pass = New ns1.BunifuMaterialTextbox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.showpass = New ns1.BunifuCheckbox()
        Me.Reset = New ns1.BunifuFlatButton()
        Me.login = New ns1.BunifuFlatButton()
        Me.id = New ns1.BunifuMaterialTextbox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuImageButton4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 423)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(675, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(33, 24)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 16
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(0, 0)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(46, 40)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 16
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton3)
        Me.Panel2.Controls.Add(Me.pass)
        Me.Panel2.Controls.Add(Me.LinkLabel3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.showpass)
        Me.Panel2.Controls.Add(Me.Reset)
        Me.Panel2.Controls.Add(Me.login)
        Me.Panel2.Controls.Add(Me.id)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 385)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Progressbar)
        Me.Panel3.Controls.Add(Me.BunifuImageButton2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(717, 385)
        Me.Panel3.TabIndex = 14
        '
        'Progressbar
        '
        Me.Progressbar.animated = False
        Me.Progressbar.animationIterval = 10
        Me.Progressbar.animationSpeed = 100
        Me.Progressbar.AutoSize = True
        Me.Progressbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Progressbar.BackgroundImage = CType(resources.GetObject("Progressbar.BackgroundImage"), System.Drawing.Image)
        Me.Progressbar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Progressbar.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Progressbar.ForeColor = System.Drawing.Color.White
        Me.Progressbar.LabelVisible = True
        Me.Progressbar.LineProgressThickness = 8
        Me.Progressbar.LineThickness = 8
        Me.Progressbar.Location = New System.Drawing.Point(270, 149)
        Me.Progressbar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Progressbar.MaxValue = 100
        Me.Progressbar.Name = "Progressbar"
        Me.Progressbar.ProgressBackColor = System.Drawing.Color.White
        Me.Progressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Progressbar.Size = New System.Drawing.Size(175, 175)
        Me.Progressbar.TabIndex = 9
        Me.Progressbar.Value = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(232, 28)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(248, 98)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 20
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(232, 28)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(248, 98)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 20
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 0
        '
        'pass
        '
        Me.pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.White
        Me.pass.HintForeColor = System.Drawing.Color.White
        Me.pass.HintText = "Password"
        Me.pass.isPassword = False
        Me.pass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pass.LineIdleColor = System.Drawing.Color.White
        Me.pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pass.LineThickness = 4
        Me.pass.Location = New System.Drawing.Point(174, 205)
        Me.pass.Margin = New System.Windows.Forms.Padding(4)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(370, 44)
        Me.pass.TabIndex = 12
        Me.pass.TabStop = False
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(650, 361)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(56, 15)
        Me.LinkLabel3.TabIndex = 19
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "About Us"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(200, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Show Password"
        '
        'showpass
        '
        Me.showpass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.showpass.ChechedOffColor = System.Drawing.Color.WhiteSmoke
        Me.showpass.Checked = False
        Me.showpass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showpass.ForeColor = System.Drawing.Color.White
        Me.showpass.Location = New System.Drawing.Point(174, 259)
        Me.showpass.Name = "showpass"
        Me.showpass.Size = New System.Drawing.Size(20, 20)
        Me.showpass.TabIndex = 16
        '
        'Reset
        '
        Me.Reset.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Reset.BorderRadius = 0
        Me.Reset.ButtonText = "Reset"
        Me.Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reset.DisabledColor = System.Drawing.Color.Gray
        Me.Reset.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Reset.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Reset.Iconimage = Nothing
        Me.Reset.Iconimage_right = CType(resources.GetObject("Reset.Iconimage_right"), System.Drawing.Image)
        Me.Reset.Iconimage_right_Selected = Nothing
        Me.Reset.Iconimage_Selected = Nothing
        Me.Reset.IconMarginLeft = 0
        Me.Reset.IconMarginRight = 0
        Me.Reset.IconRightVisible = True
        Me.Reset.IconRightZoom = 0.0R
        Me.Reset.IconVisible = True
        Me.Reset.IconZoom = 50.0R
        Me.Reset.IsTab = False
        Me.Reset.Location = New System.Drawing.Point(384, 283)
        Me.Reset.Margin = New System.Windows.Forms.Padding(7)
        Me.Reset.Name = "Reset"
        Me.Reset.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Reset.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Reset.OnHoverTextColor = System.Drawing.Color.White
        Me.Reset.selected = False
        Me.Reset.Size = New System.Drawing.Size(160, 57)
        Me.Reset.TabIndex = 15
        Me.Reset.Text = "Reset"
        Me.Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Reset.Textcolor = System.Drawing.Color.White
        Me.Reset.TextFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'login
        '
        Me.login.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.login.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login.BorderRadius = 0
        Me.login.ButtonText = "Login"
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.DisabledColor = System.Drawing.Color.Gray
        Me.login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.login.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.login.Iconimage = Nothing
        Me.login.Iconimage_right = CType(resources.GetObject("login.Iconimage_right"), System.Drawing.Image)
        Me.login.Iconimage_right_Selected = Nothing
        Me.login.Iconimage_Selected = Nothing
        Me.login.IconMarginLeft = 0
        Me.login.IconMarginRight = 0
        Me.login.IconRightVisible = True
        Me.login.IconRightZoom = 0.0R
        Me.login.IconVisible = True
        Me.login.IconZoom = 50.0R
        Me.login.IsTab = False
        Me.login.Location = New System.Drawing.Point(174, 283)
        Me.login.Margin = New System.Windows.Forms.Padding(7)
        Me.login.Name = "login"
        Me.login.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.login.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.login.OnHoverTextColor = System.Drawing.Color.White
        Me.login.selected = False
        Me.login.Size = New System.Drawing.Size(160, 57)
        Me.login.TabIndex = 13
        Me.login.Text = "Login"
        Me.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.login.Textcolor = System.Drawing.Color.White
        Me.login.TextFont = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'id
        '
        Me.id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.id.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.HintForeColor = System.Drawing.Color.White
        Me.id.HintText = "Username"
        Me.id.isPassword = False
        Me.id.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.id.LineIdleColor = System.Drawing.Color.White
        Me.id.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.id.LineThickness = 4
        Me.id.Location = New System.Drawing.Point(174, 144)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(370, 44)
        Me.id.TabIndex = 11
        Me.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 110
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 423)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pass As ns1.BunifuMaterialTextbox
    Friend WithEvents id As ns1.BunifuMaterialTextbox
    Friend WithEvents Progressbar As ns1.BunifuCircleProgressbar
    Friend WithEvents login As ns1.BunifuFlatButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Reset As ns1.BunifuFlatButton
    Friend WithEvents showpass As ns1.BunifuCheckbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BunifuImageButton4 As ns1.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As ns1.BunifuImageButton
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As ns1.BunifuImageButton
End Class

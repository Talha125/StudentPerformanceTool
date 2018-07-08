<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_users
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_users))
        Dim MainColorScheme1 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim MainColorScheme2 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim MainColorScheme3 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.password_check = New System.Windows.Forms.PictureBox()
        Me.user_check = New System.Windows.Forms.PictureBox()
        Me.clear = New ns1.BunifuFlatButton()
        Me.create = New ns1.BunifuFlatButton()
        Me.confirmpassword = New MetroSuite.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New MetroSuite.MetroTextBox()
        Me.user_type = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username = New MetroSuite.MetroTextBox()
        Me.DB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.password_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.password_check)
        Me.Panel1.Controls.Add(Me.user_check)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.create)
        Me.Panel1.Controls.Add(Me.confirmpassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.user_type)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.DB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
        '
        'password_check
        '
        Me.password_check.Location = New System.Drawing.Point(392, 110)
        Me.password_check.Name = "password_check"
        Me.password_check.Size = New System.Drawing.Size(29, 29)
        Me.password_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.password_check.TabIndex = 44
        Me.password_check.TabStop = False
        '
        'user_check
        '
        Me.user_check.Location = New System.Drawing.Point(392, 40)
        Me.user_check.Name = "user_check"
        Me.user_check.Size = New System.Drawing.Size(29, 29)
        Me.user_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_check.TabIndex = 42
        Me.user_check.TabStop = False
        '
        'clear
        '
        Me.clear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clear.BorderRadius = 0
        Me.clear.ButtonText = "Clear"
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.DisabledColor = System.Drawing.Color.Gray
        Me.clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.clear.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.clear.Iconimage = CType(resources.GetObject("clear.Iconimage"), System.Drawing.Image)
        Me.clear.Iconimage_right = Nothing
        Me.clear.Iconimage_right_Selected = Nothing
        Me.clear.Iconimage_Selected = Nothing
        Me.clear.IconMarginLeft = 0
        Me.clear.IconMarginRight = 0
        Me.clear.IconRightVisible = False
        Me.clear.IconRightZoom = 0.0R
        Me.clear.IconVisible = True
        Me.clear.IconZoom = 50.0R
        Me.clear.IsTab = False
        Me.clear.Location = New System.Drawing.Point(250, 224)
        Me.clear.Margin = New System.Windows.Forms.Padding(5)
        Me.clear.Name = "clear"
        Me.clear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.clear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.clear.OnHoverTextColor = System.Drawing.Color.White
        Me.clear.selected = False
        Me.clear.Size = New System.Drawing.Size(127, 53)
        Me.clear.TabIndex = 41
        Me.clear.Text = "Clear"
        Me.clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clear.Textcolor = System.Drawing.Color.White
        Me.clear.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'create
        '
        Me.create.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.create.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.create.BorderRadius = 0
        Me.create.ButtonText = "Create"
        Me.create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.create.DisabledColor = System.Drawing.Color.Gray
        Me.create.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.create.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.create.Iconimage = CType(resources.GetObject("create.Iconimage"), System.Drawing.Image)
        Me.create.Iconimage_right = Nothing
        Me.create.Iconimage_right_Selected = Nothing
        Me.create.Iconimage_Selected = Nothing
        Me.create.IconMarginLeft = 0
        Me.create.IconMarginRight = 0
        Me.create.IconRightVisible = False
        Me.create.IconRightZoom = 0.0R
        Me.create.IconVisible = True
        Me.create.IconZoom = 50.0R
        Me.create.IsTab = False
        Me.create.Location = New System.Drawing.Point(98, 224)
        Me.create.Margin = New System.Windows.Forms.Padding(5)
        Me.create.Name = "create"
        Me.create.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.create.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.create.OnHoverTextColor = System.Drawing.Color.White
        Me.create.selected = False
        Me.create.Size = New System.Drawing.Size(127, 53)
        Me.create.TabIndex = 40
        Me.create.Text = "Create"
        Me.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.create.Textcolor = System.Drawing.Color.White
        Me.create.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'confirmpassword
        '
        Me.confirmpassword.BanChars = False
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme1.MainColor = System.Drawing.Color.White
        Me.confirmpassword.ColorScheme = MainColorScheme1
        Me.confirmpassword.DefaultText = Nothing
        Me.confirmpassword.DefaultTextColor = System.Drawing.Color.LightGray
        Me.confirmpassword.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.confirmpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpassword.ForeColor = System.Drawing.Color.LightGray
        Me.confirmpassword.IllegalChars = CType(resources.GetObject("confirmpassword.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.confirmpassword.Location = New System.Drawing.Point(231, 110)
        Me.confirmpassword.Name = "confirmpassword"
        Me.confirmpassword.Size = New System.Drawing.Size(155, 29)
        Me.confirmpassword.TabIndex = 39
        Me.confirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.confirmpassword.UseDefaultText = False
        Me.confirmpassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(74, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Confirm Password"
        '
        'password
        '
        Me.password.BanChars = False
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme2.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme2.MainColor = System.Drawing.Color.White
        Me.password.ColorScheme = MainColorScheme2
        Me.password.DefaultText = Nothing
        Me.password.DefaultTextColor = System.Drawing.Color.LightGray
        Me.password.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.LightGray
        Me.password.IllegalChars = CType(resources.GetObject("password.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.password.Location = New System.Drawing.Point(231, 75)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(155, 29)
        Me.password.TabIndex = 37
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.password.UseDefaultText = False
        Me.password.UseSystemPasswordChar = True
        '
        'user_type
        '
        Me.user_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.user_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user_type.ForeColor = System.Drawing.Color.White
        Me.user_type.FormattingEnabled = True
        Me.user_type.ItemHeight = 23
        Me.user_type.Items.AddRange(New Object() {"Assistant", "Teacher"})
        Me.user_type.Location = New System.Drawing.Point(231, 145)
        Me.user_type.Name = "user_type"
        Me.user_type.PromptText = "User Type"
        Me.user_type.Size = New System.Drawing.Size(155, 29)
        Me.user_type.TabIndex = 36
        Me.user_type.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(74, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = " Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Username"
        '
        'username
        '
        Me.username.BanChars = False
        MainColorScheme3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme3.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme3.MainColor = System.Drawing.Color.White
        Me.username.ColorScheme = MainColorScheme3
        Me.username.DefaultText = Nothing
        Me.username.DefaultTextColor = System.Drawing.Color.LightGray
        Me.username.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.LightGray
        Me.username.IllegalChars = CType(resources.GetObject("username.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.username.Location = New System.Drawing.Point(231, 40)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(155, 29)
        Me.username.TabIndex = 32
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.username.UseDefaultText = False
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(74, 83)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(84, 21)
        Me.DB.TabIndex = 31
        Me.DB.Text = "Password"
        '
        'add_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "add_users"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.password_check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents password As MetroSuite.MetroTextBox
    Friend WithEvents user_type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents username As MetroSuite.MetroTextBox
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents confirmpassword As MetroSuite.MetroTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clear As ns1.BunifuFlatButton
    Friend WithEvents create As ns1.BunifuFlatButton
    Friend WithEvents password_check As System.Windows.Forms.PictureBox
    Friend WithEvents user_check As System.Windows.Forms.PictureBox

End Class

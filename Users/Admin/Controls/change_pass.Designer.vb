<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_pass
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
        Dim MainColorScheme1 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(change_pass))
        Dim MainColorScheme2 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim MainColorScheme3 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user_check = New System.Windows.Forms.PictureBox()
        Me.curr_pass = New MetroSuite.MetroTextBox()
        Me.password_check = New System.Windows.Forms.PictureBox()
        Me.clear = New ns1.BunifuFlatButton()
        Me.change = New ns1.BunifuFlatButton()
        Me.con_pass = New MetroSuite.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.new_pass = New MetroSuite.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DB = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.user_check)
        Me.Panel1.Controls.Add(Me.curr_pass)
        Me.Panel1.Controls.Add(Me.password_check)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.change)
        Me.Panel1.Controls.Add(Me.con_pass)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.new_pass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DB)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
        '
        'user_check
        '
        Me.user_check.Location = New System.Drawing.Point(407, 54)
        Me.user_check.Name = "user_check"
        Me.user_check.Size = New System.Drawing.Size(29, 29)
        Me.user_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_check.TabIndex = 46
        Me.user_check.TabStop = False
        '
        'curr_pass
        '
        Me.curr_pass.BanChars = False
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme1.MainColor = System.Drawing.Color.White
        Me.curr_pass.ColorScheme = MainColorScheme1
        Me.curr_pass.DefaultText = Nothing
        Me.curr_pass.DefaultTextColor = System.Drawing.Color.LightGray
        Me.curr_pass.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.curr_pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curr_pass.ForeColor = System.Drawing.Color.LightGray
        Me.curr_pass.IllegalChars = CType(resources.GetObject("curr_pass.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.curr_pass.Location = New System.Drawing.Point(246, 54)
        Me.curr_pass.Name = "curr_pass"
        Me.curr_pass.Size = New System.Drawing.Size(155, 29)
        Me.curr_pass.TabIndex = 45
        Me.curr_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.curr_pass.UseDefaultText = False
        Me.curr_pass.UseSystemPasswordChar = True
        '
        'password_check
        '
        Me.password_check.Location = New System.Drawing.Point(407, 124)
        Me.password_check.Name = "password_check"
        Me.password_check.Size = New System.Drawing.Size(29, 29)
        Me.password_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.password_check.TabIndex = 44
        Me.password_check.TabStop = False
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
        Me.clear.Location = New System.Drawing.Point(274, 189)
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
        'change
        '
        Me.change.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.change.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.change.BorderRadius = 0
        Me.change.ButtonText = "Submit"
        Me.change.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change.DisabledColor = System.Drawing.Color.Gray
        Me.change.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.change.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.change.Iconimage = CType(resources.GetObject("change.Iconimage"), System.Drawing.Image)
        Me.change.Iconimage_right = Nothing
        Me.change.Iconimage_right_Selected = Nothing
        Me.change.Iconimage_Selected = Nothing
        Me.change.IconMarginLeft = 0
        Me.change.IconMarginRight = 0
        Me.change.IconRightVisible = False
        Me.change.IconRightZoom = 0.0R
        Me.change.IconVisible = True
        Me.change.IconZoom = 50.0R
        Me.change.IsTab = False
        Me.change.Location = New System.Drawing.Point(122, 189)
        Me.change.Margin = New System.Windows.Forms.Padding(5)
        Me.change.Name = "change"
        Me.change.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.change.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.change.OnHoverTextColor = System.Drawing.Color.White
        Me.change.selected = False
        Me.change.Size = New System.Drawing.Size(127, 53)
        Me.change.TabIndex = 40
        Me.change.Text = "Submit"
        Me.change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.change.Textcolor = System.Drawing.Color.White
        Me.change.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'con_pass
        '
        Me.con_pass.BanChars = False
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme2.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme2.MainColor = System.Drawing.Color.White
        Me.con_pass.ColorScheme = MainColorScheme2
        Me.con_pass.DefaultText = Nothing
        Me.con_pass.DefaultTextColor = System.Drawing.Color.LightGray
        Me.con_pass.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.con_pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.con_pass.ForeColor = System.Drawing.Color.LightGray
        Me.con_pass.IllegalChars = CType(resources.GetObject("con_pass.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.con_pass.Location = New System.Drawing.Point(246, 124)
        Me.con_pass.Name = "con_pass"
        Me.con_pass.Size = New System.Drawing.Size(155, 29)
        Me.con_pass.TabIndex = 39
        Me.con_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.con_pass.UseDefaultText = False
        Me.con_pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(89, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Confirm Password"
        '
        'new_pass
        '
        Me.new_pass.BanChars = False
        MainColorScheme3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme3.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme3.MainColor = System.Drawing.Color.White
        Me.new_pass.ColorScheme = MainColorScheme3
        Me.new_pass.DefaultText = Nothing
        Me.new_pass.DefaultTextColor = System.Drawing.Color.LightGray
        Me.new_pass.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.new_pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_pass.ForeColor = System.Drawing.Color.LightGray
        Me.new_pass.IllegalChars = CType(resources.GetObject("new_pass.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.new_pass.Location = New System.Drawing.Point(246, 89)
        Me.new_pass.Name = "new_pass"
        Me.new_pass.Size = New System.Drawing.Size(155, 29)
        Me.new_pass.TabIndex = 37
        Me.new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.new_pass.UseDefaultText = False
        Me.new_pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(89, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Current Password"
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(89, 97)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(123, 21)
        Me.DB.TabIndex = 31
        Me.DB.Text = "New Password"
        '
        'change_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "change_pass"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents new_pass As MetroSuite.MetroTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents con_pass As MetroSuite.MetroTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clear As ns1.BunifuFlatButton
    Friend WithEvents change As ns1.BunifuFlatButton
    Friend WithEvents password_check As System.Windows.Forms.PictureBox
    Friend WithEvents curr_pass As MetroSuite.MetroTextBox
    Friend WithEvents user_check As System.Windows.Forms.PictureBox

End Class

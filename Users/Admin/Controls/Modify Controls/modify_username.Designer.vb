﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modify_username
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modify_username))
        Dim MainColorScheme2 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user_check = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.new_user = New MetroSuite.MetroTextBox()
        Me.clear = New ns1.BunifuFlatButton()
        Me.submit = New ns1.BunifuFlatButton()
        Me.user_type = New MetroSuite.MetroTextBox()
        Me.userid = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.user_check)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.new_user)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Controls.Add(Me.user_type)
        Me.Panel1.Controls.Add(Me.userid)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
        '
        'user_check
        '
        Me.user_check.Location = New System.Drawing.Point(410, 124)
        Me.user_check.Name = "user_check"
        Me.user_check.Size = New System.Drawing.Size(29, 29)
        Me.user_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_check.TabIndex = 45
        Me.user_check.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "New Username"
        '
        'new_user
        '
        Me.new_user.BanChars = False
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme1.MainColor = System.Drawing.Color.White
        Me.new_user.ColorScheme = MainColorScheme1
        Me.new_user.DefaultText = Nothing
        Me.new_user.DefaultTextColor = System.Drawing.Color.LightGray
        Me.new_user.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.new_user.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_user.ForeColor = System.Drawing.Color.LightGray
        Me.new_user.IllegalChars = CType(resources.GetObject("new_user.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.new_user.Location = New System.Drawing.Point(249, 124)
        Me.new_user.Name = "new_user"
        Me.new_user.Size = New System.Drawing.Size(155, 29)
        Me.new_user.TabIndex = 43
        Me.new_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.new_user.UseDefaultText = False
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
        Me.clear.Location = New System.Drawing.Point(277, 193)
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
        'submit
        '
        Me.submit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.submit.BorderRadius = 0
        Me.submit.ButtonText = "Submit"
        Me.submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit.DisabledColor = System.Drawing.Color.Gray
        Me.submit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.submit.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.submit.Iconimage = CType(resources.GetObject("submit.Iconimage"), System.Drawing.Image)
        Me.submit.Iconimage_right = Nothing
        Me.submit.Iconimage_right_Selected = Nothing
        Me.submit.Iconimage_Selected = Nothing
        Me.submit.IconMarginLeft = 0
        Me.submit.IconMarginRight = 0
        Me.submit.IconRightVisible = False
        Me.submit.IconRightZoom = 0.0R
        Me.submit.IconVisible = True
        Me.submit.IconZoom = 50.0R
        Me.submit.IsTab = False
        Me.submit.Location = New System.Drawing.Point(125, 193)
        Me.submit.Margin = New System.Windows.Forms.Padding(5)
        Me.submit.Name = "submit"
        Me.submit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.submit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.submit.OnHoverTextColor = System.Drawing.Color.White
        Me.submit.selected = False
        Me.submit.Size = New System.Drawing.Size(127, 53)
        Me.submit.TabIndex = 40
        Me.submit.Text = "Submit"
        Me.submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit.Textcolor = System.Drawing.Color.White
        Me.submit.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'user_type
        '
        Me.user_type.BanChars = False
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme2.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme2.MainColor = System.Drawing.Color.White
        Me.user_type.ColorScheme = MainColorScheme2
        Me.user_type.DefaultText = Nothing
        Me.user_type.DefaultTextColor = System.Drawing.Color.LightGray
        Me.user_type.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.user_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_type.ForeColor = System.Drawing.Color.LightGray
        Me.user_type.IllegalChars = CType(resources.GetObject("user_type.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.user_type.Location = New System.Drawing.Point(249, 89)
        Me.user_type.Name = "user_type"
        Me.user_type.ReadOnly = True
        Me.user_type.Size = New System.Drawing.Size(155, 29)
        Me.user_type.TabIndex = 37
        Me.user_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.user_type.UseDefaultText = False
        '
        'userid
        '
        Me.userid.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.userid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.userid.ForeColor = System.Drawing.Color.White
        Me.userid.FormattingEnabled = True
        Me.userid.ItemHeight = 23
        Me.userid.Location = New System.Drawing.Point(249, 54)
        Me.userid.Name = "userid"
        Me.userid.PromptText = "Usernames"
        Me.userid.Size = New System.Drawing.Size(155, 29)
        Me.userid.TabIndex = 36
        Me.userid.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(92, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(92, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Username"
        '
        'modify_username
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "modify_username"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.user_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents user_type As MetroSuite.MetroTextBox
    Friend WithEvents userid As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear As ns1.BunifuFlatButton
    Friend WithEvents submit As ns1.BunifuFlatButton
    Friend WithEvents user_check As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents new_user As MetroSuite.MetroTextBox

End Class

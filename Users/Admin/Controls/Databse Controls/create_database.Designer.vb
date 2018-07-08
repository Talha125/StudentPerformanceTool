<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Database))
        Dim MainColorScheme3 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clear = New ns1.BunifuFlatButton()
        Me.create = New ns1.BunifuFlatButton()
        Me.db_name = New MetroSuite.MetroTextBox()
        Me.DB = New System.Windows.Forms.Label()
        Me.year_box = New MetroFramework.Controls.MetroComboBox()
        Me.year = New System.Windows.Forms.Label()
        Me.course_select = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.create)
        Me.Panel1.Controls.Add(Me.db_name)
        Me.Panel1.Controls.Add(Me.DB)
        Me.Panel1.Controls.Add(Me.year_box)
        Me.Panel1.Controls.Add(Me.year)
        Me.Panel1.Controls.Add(Me.course_select)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
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
        Me.clear.Location = New System.Drawing.Point(268, 216)
        Me.clear.Margin = New System.Windows.Forms.Padding(5)
        Me.clear.Name = "clear"
        Me.clear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.clear.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.clear.OnHoverTextColor = System.Drawing.Color.White
        Me.clear.selected = False
        Me.clear.Size = New System.Drawing.Size(127, 53)
        Me.clear.TabIndex = 12
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
        Me.create.Location = New System.Drawing.Point(116, 216)
        Me.create.Margin = New System.Windows.Forms.Padding(5)
        Me.create.Name = "create"
        Me.create.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.create.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.create.OnHoverTextColor = System.Drawing.Color.White
        Me.create.selected = False
        Me.create.Size = New System.Drawing.Size(127, 53)
        Me.create.TabIndex = 11
        Me.create.Text = "Create"
        Me.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.create.Textcolor = System.Drawing.Color.White
        Me.create.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'db_name
        '
        Me.db_name.BanChars = False
        MainColorScheme3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme3.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme3.MainColor = System.Drawing.Color.White
        Me.db_name.ColorScheme = MainColorScheme3
        Me.db_name.DefaultText = ""
        Me.db_name.DefaultTextColor = System.Drawing.Color.LightGray
        Me.db_name.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.db_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.db_name.ForeColor = System.Drawing.Color.LightGray
        Me.db_name.IllegalChars = CType(resources.GetObject("db_name.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.db_name.Location = New System.Drawing.Point(236, 157)
        Me.db_name.Name = "db_name"
        Me.db_name.ReadOnly = True
        Me.db_name.Size = New System.Drawing.Size(159, 29)
        Me.db_name.TabIndex = 10
        Me.db_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.db_name.UseDefaultText = False
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(111, 159)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(108, 27)
        Me.DB.TabIndex = 9
        Me.DB.Text = "DB Name"
        '
        'year_box
        '
        Me.year_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.year_box.Cursor = System.Windows.Forms.Cursors.Hand
        Me.year_box.DisplayMember = "1"
        Me.year_box.DropDownHeight = 300
        Me.year_box.ForeColor = System.Drawing.Color.White
        Me.year_box.FormattingEnabled = True
        Me.year_box.IntegralHeight = False
        Me.year_box.ItemHeight = 23
        Me.year_box.Location = New System.Drawing.Point(236, 107)
        Me.year_box.MaxDropDownItems = 90
        Me.year_box.Name = "year_box"
        Me.year_box.PromptText = "Year"
        Me.year_box.Size = New System.Drawing.Size(159, 29)
        Me.year_box.TabIndex = 8
        Me.year_box.UseSelectable = True
        Me.year_box.ValueMember = "0"
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.year.Location = New System.Drawing.Point(111, 107)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(57, 27)
        Me.year.TabIndex = 7
        Me.year.Text = "Year"
        '
        'course_select
        '
        Me.course_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.course_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.course_select.ForeColor = System.Drawing.Color.White
        Me.course_select.FormattingEnabled = True
        Me.course_select.ItemHeight = 23
        Me.course_select.Items.AddRange(New Object() {"BCA", "BBA", "BJMC"})
        Me.course_select.Location = New System.Drawing.Point(236, 63)
        Me.course_select.Name = "course_select"
        Me.course_select.PromptText = "Course"
        Me.course_select.Size = New System.Drawing.Size(159, 29)
        Me.course_select.TabIndex = 6
        Me.course_select.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(111, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Course"
        '
        'Create_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Create_Database"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents course_select As MetroFramework.Controls.MetroComboBox
    Friend WithEvents year_box As MetroFramework.Controls.MetroComboBox
    Friend WithEvents db_name As MetroSuite.MetroTextBox
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents year As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clear As ns1.BunifuFlatButton
    Friend WithEvents create As ns1.BunifuFlatButton

End Class

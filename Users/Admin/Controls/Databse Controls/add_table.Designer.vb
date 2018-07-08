<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_table
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
        Dim MainColorScheme4 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_table))
        Me.content = New System.Windows.Forms.Panel()
        Me.semester = New MetroFramework.Controls.MetroComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.table_type = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.columns_box = New System.Windows.Forms.Panel()
        Me.columns_head = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.database_select = New MetroFramework.Controls.MetroComboBox()
        Me.table_name = New MetroSuite.MetroTextBox()
        Me.DB = New System.Windows.Forms.Label()
        Me.columns_no = New MetroFramework.Controls.MetroComboBox()
        Me.year = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.submit = New ns1.BunifuFlatButton()
        Me.content.SuspendLayout()
        Me.columns_head.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'content
        '
        Me.content.AutoScroll = True
        Me.content.Controls.Add(Me.semester)
        Me.content.Controls.Add(Me.Label7)
        Me.content.Controls.Add(Me.table_type)
        Me.content.Controls.Add(Me.Label6)
        Me.content.Controls.Add(Me.columns_box)
        Me.content.Controls.Add(Me.columns_head)
        Me.content.Controls.Add(Me.Label1)
        Me.content.Controls.Add(Me.database_select)
        Me.content.Controls.Add(Me.table_name)
        Me.content.Controls.Add(Me.DB)
        Me.content.Controls.Add(Me.columns_no)
        Me.content.Controls.Add(Me.year)
        Me.content.Location = New System.Drawing.Point(0, 0)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(520, 293)
        Me.content.TabIndex = 0
        '
        'semester
        '
        Me.semester.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.semester.Cursor = System.Windows.Forms.Cursors.Hand
        Me.semester.Enabled = False
        Me.semester.ForeColor = System.Drawing.Color.White
        Me.semester.FormattingEnabled = True
        Me.semester.ItemHeight = 23
        Me.semester.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.semester.Location = New System.Drawing.Point(381, 49)
        Me.semester.Name = "semester"
        Me.semester.PromptText = "Semester"
        Me.semester.Size = New System.Drawing.Size(134, 29)
        Me.semester.TabIndex = 28
        Me.semester.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(284, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Semester"
        '
        'table_type
        '
        Me.table_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.table_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.table_type.ForeColor = System.Drawing.Color.White
        Me.table_type.FormattingEnabled = True
        Me.table_type.ItemHeight = 23
        Me.table_type.Items.AddRange(New Object() {"Personal", "Marks", "Attendance"})
        Me.table_type.Location = New System.Drawing.Point(381, 14)
        Me.table_type.Name = "table_type"
        Me.table_type.PromptText = "Table Type"
        Me.table_type.Size = New System.Drawing.Size(134, 29)
        Me.table_type.TabIndex = 26
        Me.table_type.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(284, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Table Type"
        '
        'columns_box
        '
        Me.columns_box.AutoScroll = True
        Me.columns_box.Location = New System.Drawing.Point(3, 149)
        Me.columns_box.Name = "columns_box"
        Me.columns_box.Size = New System.Drawing.Size(512, 141)
        Me.columns_box.TabIndex = 24
        '
        'columns_head
        '
        Me.columns_head.Controls.Add(Me.Label5)
        Me.columns_head.Controls.Add(Me.Label4)
        Me.columns_head.Controls.Add(Me.Label3)
        Me.columns_head.Controls.Add(Me.Label2)
        Me.columns_head.Location = New System.Drawing.Point(3, 116)
        Me.columns_head.Name = "columns_head"
        Me.columns_head.Size = New System.Drawing.Size(512, 35)
        Me.columns_head.TabIndex = 23
        Me.columns_head.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(385, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(262, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(147, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Field Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 21)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Select Database"
        '
        'database_select
        '
        Me.database_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.database_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.database_select.ForeColor = System.Drawing.Color.White
        Me.database_select.FormattingEnabled = True
        Me.database_select.ItemHeight = 23
        Me.database_select.Items.AddRange(New Object() {"BCA", "BBA", "BJMC"})
        Me.database_select.Location = New System.Drawing.Point(144, 14)
        Me.database_select.Name = "database_select"
        Me.database_select.PromptText = "Databases"
        Me.database_select.Size = New System.Drawing.Size(134, 29)
        Me.database_select.TabIndex = 21
        Me.database_select.UseSelectable = True
        '
        'table_name
        '
        Me.table_name.BanChars = False
        MainColorScheme4.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme4.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme4.MainColor = System.Drawing.Color.White
        Me.table_name.ColorScheme = MainColorScheme4
        Me.table_name.DefaultText = "Table Name"
        Me.table_name.DefaultTextColor = System.Drawing.Color.LightGray
        Me.table_name.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.table_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.table_name.ForeColor = System.Drawing.Color.LightGray
        Me.table_name.IllegalChars = CType(resources.GetObject("table_name.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.table_name.Location = New System.Drawing.Point(144, 49)
        Me.table_name.Name = "table_name"
        Me.table_name.ReadOnly = True
        Me.table_name.Size = New System.Drawing.Size(134, 29)
        Me.table_name.TabIndex = 18
        Me.table_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.table_name.UseDefaultText = True
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(3, 57)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(99, 21)
        Me.DB.TabIndex = 17
        Me.DB.Text = "Table Name"
        '
        'columns_no
        '
        Me.columns_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.columns_no.Cursor = System.Windows.Forms.Cursors.Hand
        Me.columns_no.DisplayMember = "1"
        Me.columns_no.DropDownHeight = 300
        Me.columns_no.Enabled = False
        Me.columns_no.ForeColor = System.Drawing.Color.White
        Me.columns_no.FormattingEnabled = True
        Me.columns_no.IntegralHeight = False
        Me.columns_no.ItemHeight = 23
        Me.columns_no.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.columns_no.Location = New System.Drawing.Point(144, 84)
        Me.columns_no.MaxDropDownItems = 90
        Me.columns_no.Name = "columns_no"
        Me.columns_no.PromptText = "Row Number"
        Me.columns_no.Size = New System.Drawing.Size(134, 29)
        Me.columns_no.TabIndex = 16
        Me.columns_no.UseSelectable = True
        Me.columns_no.ValueMember = "0"
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.year.Location = New System.Drawing.Point(3, 92)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(108, 21)
        Me.year.TabIndex = 15
        Me.year.Text = "No. of Rows"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.submit)
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 49)
        Me.Panel2.TabIndex = 23
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
        Me.submit.Location = New System.Drawing.Point(415, 5)
        Me.submit.Margin = New System.Windows.Forms.Padding(5)
        Me.submit.Name = "submit"
        Me.submit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.submit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.submit.OnHoverTextColor = System.Drawing.Color.White
        Me.submit.selected = False
        Me.submit.Size = New System.Drawing.Size(100, 37)
        Me.submit.TabIndex = 19
        Me.submit.Text = "Submit"
        Me.submit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.submit.Textcolor = System.Drawing.Color.White
        Me.submit.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'add_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.content)
        Me.Name = "add_table"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.content.ResumeLayout(False)
        Me.content.PerformLayout()
        Me.columns_head.ResumeLayout(False)
        Me.columns_head.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents content As System.Windows.Forms.Panel
    Friend WithEvents submit As ns1.BunifuFlatButton
    Friend WithEvents table_name As MetroSuite.MetroTextBox
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents columns_no As MetroFramework.Controls.MetroComboBox
    Friend WithEvents year As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents database_select As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents columns_head As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents columns_box As System.Windows.Forms.Panel
    Friend WithEvents table_type As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents semester As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class

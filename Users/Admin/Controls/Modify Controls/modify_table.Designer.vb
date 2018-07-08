<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modify_table
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modify_table))
        Me.content = New System.Windows.Forms.Panel()
        Me.table_name = New MetroFramework.Controls.MetroComboBox()
        Me.columns_box = New System.Windows.Forms.Panel()
        Me.columns_head = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.database_select = New MetroFramework.Controls.MetroComboBox()
        Me.DB = New System.Windows.Forms.Label()
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
        Me.content.Controls.Add(Me.table_name)
        Me.content.Controls.Add(Me.columns_box)
        Me.content.Controls.Add(Me.columns_head)
        Me.content.Controls.Add(Me.Label1)
        Me.content.Controls.Add(Me.database_select)
        Me.content.Controls.Add(Me.DB)
        Me.content.Location = New System.Drawing.Point(0, 0)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(520, 293)
        Me.content.TabIndex = 0
        '
        'table_name
        '
        Me.table_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.table_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.table_name.ForeColor = System.Drawing.Color.White
        Me.table_name.FormattingEnabled = True
        Me.table_name.ItemHeight = 23
        Me.table_name.Location = New System.Drawing.Point(247, 47)
        Me.table_name.Name = "table_name"
        Me.table_name.PromptText = "Tables"
        Me.table_name.Size = New System.Drawing.Size(134, 29)
        Me.table_name.TabIndex = 24
        Me.table_name.UseSelectable = True
        '
        'columns_box
        '
        Me.columns_box.AutoScroll = True
        Me.columns_box.Location = New System.Drawing.Point(5, 117)
        Me.columns_box.Name = "columns_box"
        Me.columns_box.Size = New System.Drawing.Size(512, 173)
        Me.columns_box.TabIndex = 24
        '
        'columns_head
        '
        Me.columns_head.Controls.Add(Me.Label5)
        Me.columns_head.Controls.Add(Me.Label4)
        Me.columns_head.Controls.Add(Me.Label3)
        Me.columns_head.Controls.Add(Me.Label2)
        Me.columns_head.Location = New System.Drawing.Point(5, 84)
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
        Me.Label1.Location = New System.Drawing.Point(113, 20)
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
        Me.database_select.Location = New System.Drawing.Point(247, 12)
        Me.database_select.Name = "database_select"
        Me.database_select.PromptText = "Databases"
        Me.database_select.Size = New System.Drawing.Size(134, 29)
        Me.database_select.TabIndex = 21
        Me.database_select.UseSelectable = True
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(113, 55)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(99, 21)
        Me.DB.TabIndex = 17
        Me.DB.Text = "Table Name"
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
        'modify_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.content)
        Me.Name = "modify_table"
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
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents database_select As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents columns_head As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents columns_box As System.Windows.Forms.Panel
    Friend WithEvents table_name As MetroFramework.Controls.MetroComboBox

End Class

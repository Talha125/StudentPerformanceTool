<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delete_fkey
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delete_fkey))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.table_name = New MetroFramework.Controls.MetroComboBox()
        Me.database_select = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clear = New ns1.BunifuFlatButton()
        Me.submit = New ns1.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.table_name)
        Me.Panel1.Controls.Add(Me.database_select)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.submit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
        '
        'table_name
        '
        Me.table_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.table_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.table_name.Enabled = False
        Me.table_name.ForeColor = System.Drawing.Color.White
        Me.table_name.FormattingEnabled = True
        Me.table_name.ItemHeight = 23
        Me.table_name.Location = New System.Drawing.Point(230, 81)
        Me.table_name.Name = "table_name"
        Me.table_name.PromptText = "Tables"
        Me.table_name.Size = New System.Drawing.Size(134, 29)
        Me.table_name.TabIndex = 47
        Me.table_name.UseSelectable = True
        '
        'database_select
        '
        Me.database_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.database_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.database_select.ForeColor = System.Drawing.Color.White
        Me.database_select.FormattingEnabled = True
        Me.database_select.ItemHeight = 23
        Me.database_select.Items.AddRange(New Object() {"BCA", "BBA", "BJMC"})
        Me.database_select.Location = New System.Drawing.Point(230, 46)
        Me.database_select.Name = "database_select"
        Me.database_select.PromptText = "Databases"
        Me.database_select.Size = New System.Drawing.Size(134, 29)
        Me.database_select.TabIndex = 46
        Me.database_select.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(151, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Table"
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
        Me.clear.Location = New System.Drawing.Point(279, 162)
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
        Me.submit.Location = New System.Drawing.Point(127, 162)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Database"
        '
        'delete_fkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "delete_fkey"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear As ns1.BunifuFlatButton
    Friend WithEvents submit As ns1.BunifuFlatButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents database_select As MetroFramework.Controls.MetroComboBox
    Friend WithEvents table_name As MetroFramework.Controls.MetroComboBox

End Class

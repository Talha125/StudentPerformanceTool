<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delete_database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delete_database))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.delete = New ns1.BunifuFlatButton()
        Me.DB = New System.Windows.Forms.Label()
        Me.database_select = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.DB)
        Me.Panel1.Controls.Add(Me.database_select)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 0
        '
        'delete
        '
        Me.delete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.BorderRadius = 0
        Me.delete.ButtonText = "Delete"
        Me.delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete.DisabledColor = System.Drawing.Color.Gray
        Me.delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.delete.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.delete.Iconimage = CType(resources.GetObject("delete.Iconimage"), System.Drawing.Image)
        Me.delete.Iconimage_right = Nothing
        Me.delete.Iconimage_right_Selected = Nothing
        Me.delete.Iconimage_Selected = Nothing
        Me.delete.IconMarginLeft = 0
        Me.delete.IconMarginRight = 0
        Me.delete.IconRightVisible = False
        Me.delete.IconRightZoom = 0.0R
        Me.delete.IconVisible = True
        Me.delete.IconZoom = 50.0R
        Me.delete.IsTab = False
        Me.delete.Location = New System.Drawing.Point(176, 161)
        Me.delete.Margin = New System.Windows.Forms.Padding(5)
        Me.delete.Name = "delete"
        Me.delete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.delete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.delete.OnHoverTextColor = System.Drawing.Color.White
        Me.delete.selected = False
        Me.delete.Size = New System.Drawing.Size(163, 53)
        Me.delete.TabIndex = 19
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.Textcolor = System.Drawing.Color.White
        Me.delete.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DB
        '
        Me.DB.AutoSize = True
        Me.DB.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.DB.Location = New System.Drawing.Point(106, 90)
        Me.DB.Name = "DB"
        Me.DB.Size = New System.Drawing.Size(108, 27)
        Me.DB.TabIndex = 17
        Me.DB.Text = "DB Name"
        '
        'database_select
        '
        Me.database_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.database_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.database_select.ForeColor = System.Drawing.Color.White
        Me.database_select.FormattingEnabled = True
        Me.database_select.ItemHeight = 23
        Me.database_select.Items.AddRange(New Object() {"BCA", "BBA", "BJMC"})
        Me.database_select.Location = New System.Drawing.Point(243, 88)
        Me.database_select.Name = "database_select"
        Me.database_select.PromptText = "Databases"
        Me.database_select.Size = New System.Drawing.Size(159, 29)
        Me.database_select.TabIndex = 14
        Me.database_select.UseSelectable = True
        '
        'delete_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "delete_database"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents delete As ns1.BunifuFlatButton
    Friend WithEvents DB As System.Windows.Forms.Label
    Friend WithEvents database_select As MetroFramework.Controls.MetroComboBox

End Class

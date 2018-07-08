<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_records_admin_database
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_records_admin_database))
        Me.Add_Users = New ns1.BunifuTileButton()
        Me.Add_Table = New ns1.BunifuTileButton()
        Me.Create_Database = New ns1.BunifuTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.foreign_key = New ns1.BunifuTileButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Add_Users
        '
        Me.Add_Users.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Add_Users.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Add_Users.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Add_Users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Users.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Users.ForeColor = System.Drawing.Color.White
        Me.Add_Users.Image = CType(resources.GetObject("Add_Users.Image"), System.Drawing.Image)
        Me.Add_Users.ImagePosition = 10
        Me.Add_Users.ImageZoom = 35
        Me.Add_Users.LabelPosition = 43
        Me.Add_Users.LabelText = "Add Users"
        Me.Add_Users.Location = New System.Drawing.Point(272, 192)
        Me.Add_Users.Margin = New System.Windows.Forms.Padding(6)
        Me.Add_Users.Name = "Add_Users"
        Me.Add_Users.Size = New System.Drawing.Size(215, 129)
        Me.Add_Users.TabIndex = 11
        '
        'Add_Table
        '
        Me.Add_Table.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Add_Table.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Add_Table.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Add_Table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Table.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Table.ForeColor = System.Drawing.Color.White
        Me.Add_Table.Image = CType(resources.GetObject("Add_Table.Image"), System.Drawing.Image)
        Me.Add_Table.ImagePosition = 10
        Me.Add_Table.ImageZoom = 40
        Me.Add_Table.LabelPosition = 43
        Me.Add_Table.LabelText = "Add Table"
        Me.Add_Table.Location = New System.Drawing.Point(26, 192)
        Me.Add_Table.Margin = New System.Windows.Forms.Padding(6)
        Me.Add_Table.Name = "Add_Table"
        Me.Add_Table.Size = New System.Drawing.Size(215, 129)
        Me.Add_Table.TabIndex = 12
        '
        'Create_Database
        '
        Me.Create_Database.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Create_Database.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Create_Database.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Create_Database.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create_Database.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create_Database.ForeColor = System.Drawing.Color.White
        Me.Create_Database.Image = CType(resources.GetObject("Create_Database.Image"), System.Drawing.Image)
        Me.Create_Database.ImagePosition = 10
        Me.Create_Database.ImageZoom = 35
        Me.Create_Database.LabelPosition = 43
        Me.Create_Database.LabelText = "Create Database"
        Me.Create_Database.Location = New System.Drawing.Point(26, 40)
        Me.Create_Database.Margin = New System.Windows.Forms.Padding(6)
        Me.Create_Database.Name = "Create_Database"
        Me.Create_Database.Size = New System.Drawing.Size(215, 129)
        Me.Create_Database.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.foreign_key)
        Me.Panel1.Controls.Add(Me.Add_Table)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 13
        '
        'foreign_key
        '
        Me.foreign_key.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.foreign_key.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.foreign_key.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.foreign_key.Cursor = System.Windows.Forms.Cursors.Hand
        Me.foreign_key.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foreign_key.ForeColor = System.Drawing.Color.White
        Me.foreign_key.Image = CType(resources.GetObject("foreign_key.Image"), System.Drawing.Image)
        Me.foreign_key.ImagePosition = 10
        Me.foreign_key.ImageZoom = 35
        Me.foreign_key.LabelPosition = 43
        Me.foreign_key.LabelText = "Add Foreign Key"
        Me.foreign_key.Location = New System.Drawing.Point(272, 40)
        Me.foreign_key.Margin = New System.Windows.Forms.Padding(6)
        Me.foreign_key.Name = "foreign_key"
        Me.foreign_key.Size = New System.Drawing.Size(215, 129)
        Me.foreign_key.TabIndex = 13
        '
        'add_records_admin_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Add_Users)
        Me.Controls.Add(Me.Create_Database)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "add_records_admin_database"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Add_Users As ns1.BunifuTileButton
    Friend WithEvents Add_Table As ns1.BunifuTileButton
    Friend WithEvents Create_Database As ns1.BunifuTileButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents foreign_key As ns1.BunifuTileButton

End Class

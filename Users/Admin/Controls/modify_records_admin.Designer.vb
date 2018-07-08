<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modify_records_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modify_records_admin))
        Me.Modify_Users = New ns1.BunifuTileButton()
        Me.Modify_Table = New ns1.BunifuTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Modify_Users
        '
        Me.Modify_Users.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Modify_Users.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Modify_Users.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Modify_Users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modify_Users.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modify_Users.ForeColor = System.Drawing.Color.White
        Me.Modify_Users.Image = CType(resources.GetObject("Modify_Users.Image"), System.Drawing.Image)
        Me.Modify_Users.ImagePosition = 10
        Me.Modify_Users.ImageZoom = 35
        Me.Modify_Users.LabelPosition = 43
        Me.Modify_Users.LabelText = "Modify Users"
        Me.Modify_Users.Location = New System.Drawing.Point(278, 42)
        Me.Modify_Users.Margin = New System.Windows.Forms.Padding(6)
        Me.Modify_Users.Name = "Modify_Users"
        Me.Modify_Users.Size = New System.Drawing.Size(215, 129)
        Me.Modify_Users.TabIndex = 11
        '
        'Modify_Table
        '
        Me.Modify_Table.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Modify_Table.color = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Modify_Table.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Modify_Table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modify_Table.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modify_Table.ForeColor = System.Drawing.Color.White
        Me.Modify_Table.Image = CType(resources.GetObject("Modify_Table.Image"), System.Drawing.Image)
        Me.Modify_Table.ImagePosition = 10
        Me.Modify_Table.ImageZoom = 40
        Me.Modify_Table.LabelPosition = 43
        Me.Modify_Table.LabelText = "Modify Table"
        Me.Modify_Table.Location = New System.Drawing.Point(24, 42)
        Me.Modify_Table.Margin = New System.Windows.Forms.Padding(6)
        Me.Modify_Table.Name = "Modify_Table"
        Me.Modify_Table.Size = New System.Drawing.Size(215, 129)
        Me.Modify_Table.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Modify_Users)
        Me.Panel1.Controls.Add(Me.Modify_Table)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.TabIndex = 13
        '
        'modify_records_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "modify_records_admin"
        Me.Size = New System.Drawing.Size(520, 345)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Modify_Users As ns1.BunifuTileButton
    Friend WithEvents Modify_Table As ns1.BunifuTileButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class

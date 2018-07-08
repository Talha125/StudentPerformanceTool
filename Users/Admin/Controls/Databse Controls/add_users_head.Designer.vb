<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_users_head
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_users_head))
        Me.heading = New System.Windows.Forms.Panel()
        Me.database_table = New System.Windows.Forms.Label()
        Me.marks_image = New ns1.BunifuImageButton()
        Me.heading.SuspendLayout()
        CType(Me.marks_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'heading
        '
        Me.heading.Controls.Add(Me.database_table)
        Me.heading.Controls.Add(Me.marks_image)
        Me.heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.heading.Location = New System.Drawing.Point(0, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(520, 47)
        Me.heading.TabIndex = 10
        '
        'database_table
        '
        Me.database_table.AutoSize = True
        Me.database_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.database_table.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.database_table.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.database_table.Location = New System.Drawing.Point(49, 11)
        Me.database_table.Name = "database_table"
        Me.database_table.Size = New System.Drawing.Size(79, 19)
        Me.database_table.TabIndex = 6
        Me.database_table.Text = "Add Users"
        '
        'marks_image
        '
        Me.marks_image.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.marks_image.Image = CType(resources.GetObject("marks_image.Image"), System.Drawing.Image)
        Me.marks_image.ImageActive = Nothing
        Me.marks_image.Location = New System.Drawing.Point(70, 21)
        Me.marks_image.Name = "marks_image"
        Me.marks_image.Size = New System.Drawing.Size(38, 40)
        Me.marks_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.marks_image.TabIndex = 1
        Me.marks_image.TabStop = False
        Me.marks_image.Zoom = 0
        '
        'add_users_head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.heading)
        Me.Name = "add_users_head"
        Me.Size = New System.Drawing.Size(520, 47)
        Me.heading.ResumeLayout(False)
        Me.heading.PerformLayout()
        CType(Me.marks_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents heading As System.Windows.Forms.Panel
    Friend WithEvents database_table As System.Windows.Forms.Label
    Friend WithEvents marks_image As ns1.BunifuImageButton

End Class

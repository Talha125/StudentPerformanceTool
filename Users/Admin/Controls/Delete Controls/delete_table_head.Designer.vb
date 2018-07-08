<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class delete_table_head
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(delete_table_head))
        Me.heading = New System.Windows.Forms.Panel()
        Me.add_table = New System.Windows.Forms.Label()
        Me.add_image = New ns1.BunifuImageButton()
        Me.heading.SuspendLayout()
        CType(Me.add_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'heading
        '
        Me.heading.Controls.Add(Me.add_table)
        Me.heading.Controls.Add(Me.add_image)
        Me.heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.heading.Location = New System.Drawing.Point(0, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(520, 47)
        Me.heading.TabIndex = 10
        '
        'add_table
        '
        Me.add_table.AutoSize = True
        Me.add_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_table.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_table.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.add_table.Location = New System.Drawing.Point(25, 12)
        Me.add_table.Name = "add_table"
        Me.add_table.Size = New System.Drawing.Size(95, 19)
        Me.add_table.TabIndex = 10
        Me.add_table.Text = "Delete Table"
        '
        'add_image
        '
        Me.add_image.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.add_image.Image = CType(resources.GetObject("add_image.Image"), System.Drawing.Image)
        Me.add_image.ImageActive = Nothing
        Me.add_image.Location = New System.Drawing.Point(55, 21)
        Me.add_image.Name = "add_image"
        Me.add_image.Size = New System.Drawing.Size(38, 40)
        Me.add_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.add_image.TabIndex = 9
        Me.add_image.TabStop = False
        Me.add_image.Zoom = 0
        '
        'delete_table_head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.heading)
        Me.Name = "delete_table_head"
        Me.Size = New System.Drawing.Size(520, 47)
        Me.heading.ResumeLayout(False)
        Me.heading.PerformLayout()
        CType(Me.add_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents heading As System.Windows.Forms.Panel
    Friend WithEvents add_table As System.Windows.Forms.Label
    Friend WithEvents add_image As ns1.BunifuImageButton

End Class

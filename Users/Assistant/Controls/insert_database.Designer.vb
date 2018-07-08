<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insert_database
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
        Me.photobutton = New ns1.BunifuTileButton()
        Me.studatabutton = New ns1.BunifuTileButton()
        Me.SuspendLayout()
        '
        'photobutton
        '
        Me.photobutton.BackColor = System.Drawing.Color.SeaGreen
        Me.photobutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.photobutton.color = System.Drawing.Color.SeaGreen
        Me.photobutton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.photobutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.photobutton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photobutton.ForeColor = System.Drawing.Color.White
        Me.photobutton.Image = Nothing
        Me.photobutton.ImagePosition = 30
        Me.photobutton.ImageZoom = 50
        Me.photobutton.LabelPosition = 62
        Me.photobutton.LabelText = "Photo"
        Me.photobutton.Location = New System.Drawing.Point(280, 101)
        Me.photobutton.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.photobutton.Name = "photobutton"
        Me.photobutton.Size = New System.Drawing.Size(215, 129)
        Me.photobutton.TabIndex = 3
        '
        'studatabutton
        '
        Me.studatabutton.BackColor = System.Drawing.Color.SeaGreen
        Me.studatabutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.studatabutton.color = System.Drawing.Color.SeaGreen
        Me.studatabutton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.studatabutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studatabutton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studatabutton.ForeColor = System.Drawing.Color.White
        Me.studatabutton.Image = Nothing
        Me.studatabutton.ImagePosition = 30
        Me.studatabutton.ImageZoom = 50
        Me.studatabutton.LabelPosition = 62
        Me.studatabutton.LabelText = "Student's Data"
        Me.studatabutton.Location = New System.Drawing.Point(25, 101)
        Me.studatabutton.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.studatabutton.Name = "studatabutton"
        Me.studatabutton.Size = New System.Drawing.Size(215, 129)
        Me.studatabutton.TabIndex = 2
        '
        'insert_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Controls.Add(Me.photobutton)
        Me.Controls.Add(Me.studatabutton)
        Me.Name = "insert_database"
        Me.Size = New System.Drawing.Size(520, 330)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents photobutton As ns1.BunifuTileButton
    Friend WithEvents studatabutton As ns1.BunifuTileButton

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_records
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
        Me.marksbutton = New ns1.BunifuTileButton()
        Me.attendbutton = New ns1.BunifuTileButton()
        Me.strengthsbutton = New ns1.BunifuTileButton()
        Me.SuspendLayout()
        '
        'marksbutton
        '
        Me.marksbutton.BackColor = System.Drawing.Color.SeaGreen
        Me.marksbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.marksbutton.color = System.Drawing.Color.SeaGreen
        Me.marksbutton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.marksbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.marksbutton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marksbutton.ForeColor = System.Drawing.Color.White
        Me.marksbutton.Image = Nothing
        Me.marksbutton.ImagePosition = 30
        Me.marksbutton.ImageZoom = 50
        Me.marksbutton.LabelPosition = 62
        Me.marksbutton.LabelText = "Marks"
        Me.marksbutton.Location = New System.Drawing.Point(23, 26)
        Me.marksbutton.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.marksbutton.Name = "marksbutton"
        Me.marksbutton.Size = New System.Drawing.Size(215, 129)
        Me.marksbutton.TabIndex = 0
        '
        'attendbutton
        '
        Me.attendbutton.BackColor = System.Drawing.Color.SeaGreen
        Me.attendbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.attendbutton.color = System.Drawing.Color.SeaGreen
        Me.attendbutton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.attendbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.attendbutton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendbutton.ForeColor = System.Drawing.Color.White
        Me.attendbutton.Image = Nothing
        Me.attendbutton.ImagePosition = 30
        Me.attendbutton.ImageZoom = 50
        Me.attendbutton.LabelPosition = 62
        Me.attendbutton.LabelText = "Attendance"
        Me.attendbutton.Location = New System.Drawing.Point(278, 26)
        Me.attendbutton.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.attendbutton.Name = "attendbutton"
        Me.attendbutton.Size = New System.Drawing.Size(215, 129)
        Me.attendbutton.TabIndex = 1
        '
        'strengthsbutton
        '
        Me.strengthsbutton.BackColor = System.Drawing.Color.SeaGreen
        Me.strengthsbutton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.strengthsbutton.color = System.Drawing.Color.SeaGreen
        Me.strengthsbutton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.strengthsbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.strengthsbutton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strengthsbutton.ForeColor = System.Drawing.Color.White
        Me.strengthsbutton.Image = Nothing
        Me.strengthsbutton.ImagePosition = 30
        Me.strengthsbutton.ImageZoom = 50
        Me.strengthsbutton.LabelPosition = 61
        Me.strengthsbutton.LabelText = "Strengths"
        Me.strengthsbutton.Location = New System.Drawing.Point(148, 172)
        Me.strengthsbutton.Margin = New System.Windows.Forms.Padding(8)
        Me.strengthsbutton.Name = "strengthsbutton"
        Me.strengthsbutton.Size = New System.Drawing.Size(215, 129)
        Me.strengthsbutton.TabIndex = 2
        '
        'student_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Controls.Add(Me.strengthsbutton)
        Me.Controls.Add(Me.attendbutton)
        Me.Controls.Add(Me.marksbutton)
        Me.Name = "student_records"
        Me.Size = New System.Drawing.Size(520, 330)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents marksbutton As ns1.BunifuTileButton
    Friend WithEvents attendbutton As ns1.BunifuTileButton
    Friend WithEvents strengthsbutton As ns1.BunifuTileButton

End Class

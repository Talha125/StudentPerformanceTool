<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about_us
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about_us))
        Me.Close_Btn = New ns1.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pk1 = New System.Windows.Forms.PictureBox()
        Me.pk3 = New System.Windows.Forms.PictureBox()
        Me.pk2 = New System.Windows.Forms.PictureBox()
        Me.pg2 = New System.Windows.Forms.PictureBox()
        Me.pg3 = New System.Windows.Forms.PictureBox()
        Me.pg1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.elipse = New ns1.BunifuElipse(Me.components)
        Me.DragControl1 = New ns1.BunifuDragControl(Me.components)
        CType(Me.Close_Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Close_Btn
        '
        Me.Close_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Btn.Image = CType(resources.GetObject("Close_Btn.Image"), System.Drawing.Image)
        Me.Close_Btn.ImageActive = Nothing
        Me.Close_Btn.Location = New System.Drawing.Point(455, 12)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(33, 24)
        Me.Close_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Close_Btn.TabIndex = 16
        Me.Close_Btn.TabStop = False
        Me.Close_Btn.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(29, 287)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(168, 178)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(292, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Piyush Goel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(268, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Pawan Kumar (PK)"
        '
        'pk1
        '
        Me.pk1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pk1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pk1.Image = CType(resources.GetObject("pk1.Image"), System.Drawing.Image)
        Me.pk1.Location = New System.Drawing.Point(243, 325)
        Me.pk1.Name = "pk1"
        Me.pk1.Size = New System.Drawing.Size(36, 36)
        Me.pk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pk1.TabIndex = 25
        Me.pk1.TabStop = False
        '
        'pk3
        '
        Me.pk3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pk3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pk3.Image = CType(resources.GetObject("pk3.Image"), System.Drawing.Image)
        Me.pk3.Location = New System.Drawing.Point(407, 325)
        Me.pk3.Name = "pk3"
        Me.pk3.Size = New System.Drawing.Size(38, 36)
        Me.pk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pk3.TabIndex = 27
        Me.pk3.TabStop = False
        '
        'pk2
        '
        Me.pk2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pk2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pk2.Image = CType(resources.GetObject("pk2.Image"), System.Drawing.Image)
        Me.pk2.Location = New System.Drawing.Point(326, 325)
        Me.pk2.Name = "pk2"
        Me.pk2.Size = New System.Drawing.Size(38, 36)
        Me.pk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pk2.TabIndex = 28
        Me.pk2.TabStop = False
        '
        'pg2
        '
        Me.pg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pg2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pg2.Image = CType(resources.GetObject("pg2.Image"), System.Drawing.Image)
        Me.pg2.Location = New System.Drawing.Point(326, 95)
        Me.pg2.Name = "pg2"
        Me.pg2.Size = New System.Drawing.Size(38, 36)
        Me.pg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pg2.TabIndex = 33
        Me.pg2.TabStop = False
        '
        'pg3
        '
        Me.pg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pg3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pg3.Image = CType(resources.GetObject("pg3.Image"), System.Drawing.Image)
        Me.pg3.Location = New System.Drawing.Point(407, 95)
        Me.pg3.Name = "pg3"
        Me.pg3.Size = New System.Drawing.Size(38, 36)
        Me.pg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pg3.TabIndex = 32
        Me.pg3.TabStop = False
        '
        'pg1
        '
        Me.pg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pg1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pg1.Image = CType(resources.GetObject("pg1.Image"), System.Drawing.Image)
        Me.pg1.Location = New System.Drawing.Point(243, 95)
        Me.pg1.Name = "pg1"
        Me.pg1.Size = New System.Drawing.Size(36, 36)
        Me.pg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pg1.TabIndex = 30
        Me.pg1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(183, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Developers"
        '
        'elipse
        '
        Me.elipse.ElipseRadius = 20
        Me.elipse.TargetControl = Me
        '
        'DragControl1
        '
        Me.DragControl1.Fixed = True
        Me.DragControl1.Horizontal = True
        Me.DragControl1.TargetControl = Me
        Me.DragControl1.Vertical = True
        '
        'about_us
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(500, 537)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pg2)
        Me.Controls.Add(Me.pg3)
        Me.Controls.Add(Me.pg1)
        Me.Controls.Add(Me.pk2)
        Me.Controls.Add(Me.pk3)
        Me.Controls.Add(Me.pk1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Close_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "about_us"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "about"
        CType(Me.Close_Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Close_Btn As ns1.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pk1 As System.Windows.Forms.PictureBox
    Friend WithEvents pk3 As System.Windows.Forms.PictureBox
    Friend WithEvents pk2 As System.Windows.Forms.PictureBox
    Friend WithEvents pg2 As System.Windows.Forms.PictureBox
    Friend WithEvents pg3 As System.Windows.Forms.PictureBox
    Friend WithEvents pg1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents elipse As ns1.BunifuElipse
    Friend WithEvents DragControl1 As ns1.BunifuDragControl
End Class

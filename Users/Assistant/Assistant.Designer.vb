<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assistant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assistant))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.x = New ns1.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logout = New ns1.BunifuFlatButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.updatedatabase = New ns1.BunifuFlatButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.studentrecords = New ns1.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.x, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 38)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(520, 330)
        Me.Panel6.TabIndex = 0
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 55)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(520, 368)
        Me.Panel5.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(520, 38)
        Me.Panel7.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel4.Controls.Add(Me.x)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 423)
        Me.Panel4.TabIndex = 6
        '
        'x
        '
        Me.x.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.x.Cursor = System.Windows.Forms.Cursors.Hand
        Me.x.Image = CType(resources.GetObject("x.Image"), System.Drawing.Image)
        Me.x.ImageActive = Nothing
        Me.x.Location = New System.Drawing.Point(475, 12)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(33, 24)
        Me.x.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.x.TabIndex = 2
        Me.x.TabStop = False
        Me.x.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 368)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel3.Controls.Add(Me.logout)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.updatedatabase)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.studentrecords)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 330)
        Me.Panel3.TabIndex = 1
        '
        'logout
        '
        Me.logout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logout.BorderRadius = 0
        Me.logout.ButtonText = "Logout"
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.DisabledColor = System.Drawing.Color.Gray
        Me.logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.logout.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.logout.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.logout.Iconimage = CType(resources.GetObject("logout.Iconimage"), System.Drawing.Image)
        Me.logout.Iconimage_right = Nothing
        Me.logout.Iconimage_right_Selected = Nothing
        Me.logout.Iconimage_Selected = Nothing
        Me.logout.IconMarginLeft = 0
        Me.logout.IconMarginRight = 0
        Me.logout.IconRightVisible = True
        Me.logout.IconRightZoom = 0.0R
        Me.logout.IconVisible = True
        Me.logout.IconZoom = 60.0R
        Me.logout.IsTab = False
        Me.logout.Location = New System.Drawing.Point(0, 98)
        Me.logout.Margin = New System.Windows.Forms.Padding(5)
        Me.logout.Name = "logout"
        Me.logout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.logout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.logout.OnHoverTextColor = System.Drawing.Color.White
        Me.logout.selected = False
        Me.logout.Size = New System.Drawing.Size(200, 43)
        Me.logout.TabIndex = 20
        Me.logout.Text = "Logout"
        Me.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout.Textcolor = System.Drawing.Color.White
        Me.logout.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 94)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'updatedatabase
        '
        Me.updatedatabase.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.updatedatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.updatedatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.updatedatabase.BorderRadius = 0
        Me.updatedatabase.ButtonText = "Student's Database"
        Me.updatedatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updatedatabase.DisabledColor = System.Drawing.Color.Gray
        Me.updatedatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.updatedatabase.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatedatabase.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.updatedatabase.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.updatedatabase.Iconimage = CType(resources.GetObject("updatedatabase.Iconimage"), System.Drawing.Image)
        Me.updatedatabase.Iconimage_right = Global.StudentBenchmarking.My.Resources.Resources.Forward_104px
        Me.updatedatabase.Iconimage_right_Selected = Nothing
        Me.updatedatabase.Iconimage_Selected = Nothing
        Me.updatedatabase.IconMarginLeft = 0
        Me.updatedatabase.IconMarginRight = 0
        Me.updatedatabase.IconRightVisible = False
        Me.updatedatabase.IconRightZoom = 0.0R
        Me.updatedatabase.IconVisible = True
        Me.updatedatabase.IconZoom = 60.0R
        Me.updatedatabase.IsTab = False
        Me.updatedatabase.Location = New System.Drawing.Point(0, 51)
        Me.updatedatabase.Margin = New System.Windows.Forms.Padding(5)
        Me.updatedatabase.Name = "updatedatabase"
        Me.updatedatabase.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.updatedatabase.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.updatedatabase.OnHoverTextColor = System.Drawing.Color.White
        Me.updatedatabase.selected = False
        Me.updatedatabase.Size = New System.Drawing.Size(200, 43)
        Me.updatedatabase.TabIndex = 15
        Me.updatedatabase.Text = "Student's Database"
        Me.updatedatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updatedatabase.Textcolor = System.Drawing.Color.White
        Me.updatedatabase.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'studentrecords
        '
        Me.studentrecords.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.studentrecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.studentrecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentrecords.BorderRadius = 0
        Me.studentrecords.ButtonText = "Student's Records"
        Me.studentrecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentrecords.DisabledColor = System.Drawing.Color.Gray
        Me.studentrecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.studentrecords.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentrecords.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.studentrecords.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.studentrecords.Iconimage = CType(resources.GetObject("studentrecords.Iconimage"), System.Drawing.Image)
        Me.studentrecords.Iconimage_right = Global.StudentBenchmarking.My.Resources.Resources.Forward_104px
        Me.studentrecords.Iconimage_right_Selected = Nothing
        Me.studentrecords.Iconimage_Selected = Nothing
        Me.studentrecords.IconMarginLeft = 0
        Me.studentrecords.IconMarginRight = 0
        Me.studentrecords.IconRightVisible = False
        Me.studentrecords.IconRightZoom = 0.0R
        Me.studentrecords.IconVisible = True
        Me.studentrecords.IconZoom = 60.0R
        Me.studentrecords.IsTab = False
        Me.studentrecords.Location = New System.Drawing.Point(0, 4)
        Me.studentrecords.Margin = New System.Windows.Forms.Padding(5)
        Me.studentrecords.Name = "studentrecords"
        Me.studentrecords.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.studentrecords.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.studentrecords.OnHoverTextColor = System.Drawing.Color.White
        Me.studentrecords.selected = False
        Me.studentrecords.Size = New System.Drawing.Size(200, 43)
        Me.studentrecords.TabIndex = 11
        Me.studentrecords.Text = "Student's Records"
        Me.studentrecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.studentrecords.Textcolor = System.Drawing.Color.White
        Me.studentrecords.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 423)
        Me.Panel1.TabIndex = 5
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BunifuImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(145, 55)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 1
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'Assistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 423)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Assistant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant"
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.x, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents x As ns1.BunifuImageButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents studentrecords As ns1.BunifuFlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents updatedatabase As ns1.BunifuFlatButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents logout As ns1.BunifuFlatButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class

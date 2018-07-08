<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher))
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.x = New ns1.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logout = New ns1.BunifuFlatButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.generate_report = New ns1.BunifuFlatButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.update_db = New ns1.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.showresult = New ns1.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.x, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 38)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(520, 330)
        Me.Panel6.TabIndex = 0
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
        Me.Panel4.TabIndex = 4
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
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.generate_report)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.update_db)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.showresult)
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
        Me.logout.IconZoom = 50.0R
        Me.logout.IsTab = False
        Me.logout.Location = New System.Drawing.Point(0, 145)
        Me.logout.Margin = New System.Windows.Forms.Padding(5)
        Me.logout.Name = "logout"
        Me.logout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.logout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.logout.OnHoverTextColor = System.Drawing.Color.White
        Me.logout.selected = False
        Me.logout.Size = New System.Drawing.Size(200, 43)
        Me.logout.TabIndex = 21
        Me.logout.Text = "Logout"
        Me.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout.Textcolor = System.Drawing.Color.White
        Me.logout.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 141)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'generate_report
        '
        Me.generate_report.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.generate_report.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.generate_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.generate_report.BorderRadius = 0
        Me.generate_report.ButtonText = "Generate Report"
        Me.generate_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generate_report.DisabledColor = System.Drawing.Color.Gray
        Me.generate_report.Dock = System.Windows.Forms.DockStyle.Top
        Me.generate_report.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generate_report.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.generate_report.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.generate_report.Iconimage = CType(resources.GetObject("generate_report.Iconimage"), System.Drawing.Image)
        Me.generate_report.Iconimage_right = Global.StudentBenchmarking.My.Resources.Resources.Forward_104px
        Me.generate_report.Iconimage_right_Selected = Nothing
        Me.generate_report.Iconimage_Selected = Nothing
        Me.generate_report.IconMarginLeft = 0
        Me.generate_report.IconMarginRight = 0
        Me.generate_report.IconRightVisible = False
        Me.generate_report.IconRightZoom = 0.0R
        Me.generate_report.IconVisible = True
        Me.generate_report.IconZoom = 50.0R
        Me.generate_report.IsTab = False
        Me.generate_report.Location = New System.Drawing.Point(0, 98)
        Me.generate_report.Margin = New System.Windows.Forms.Padding(5)
        Me.generate_report.Name = "generate_report"
        Me.generate_report.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.generate_report.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.generate_report.OnHoverTextColor = System.Drawing.Color.White
        Me.generate_report.selected = False
        Me.generate_report.Size = New System.Drawing.Size(200, 43)
        Me.generate_report.TabIndex = 19
        Me.generate_report.Text = "Generate Report"
        Me.generate_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.generate_report.Textcolor = System.Drawing.Color.White
        Me.generate_report.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Location = New System.Drawing.Point(0, 94)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'update_db
        '
        Me.update_db.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.update_db.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.update_db.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.update_db.BorderRadius = 0
        Me.update_db.ButtonText = "Update Database"
        Me.update_db.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_db.DisabledColor = System.Drawing.Color.Gray
        Me.update_db.Dock = System.Windows.Forms.DockStyle.Top
        Me.update_db.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_db.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.update_db.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.update_db.Iconimage = CType(resources.GetObject("update_db.Iconimage"), System.Drawing.Image)
        Me.update_db.Iconimage_right = Global.StudentBenchmarking.My.Resources.Resources.Forward_104px
        Me.update_db.Iconimage_right_Selected = Nothing
        Me.update_db.Iconimage_Selected = Nothing
        Me.update_db.IconMarginLeft = 0
        Me.update_db.IconMarginRight = 0
        Me.update_db.IconRightVisible = False
        Me.update_db.IconRightZoom = 0.0R
        Me.update_db.IconVisible = True
        Me.update_db.IconZoom = 50.0R
        Me.update_db.IsTab = False
        Me.update_db.Location = New System.Drawing.Point(0, 51)
        Me.update_db.Margin = New System.Windows.Forms.Padding(5)
        Me.update_db.Name = "update_db"
        Me.update_db.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.update_db.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.update_db.OnHoverTextColor = System.Drawing.Color.White
        Me.update_db.selected = False
        Me.update_db.Size = New System.Drawing.Size(200, 43)
        Me.update_db.TabIndex = 15
        Me.update_db.Text = "Update Database"
        Me.update_db.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_db.Textcolor = System.Drawing.Color.White
        Me.update_db.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'showresult
        '
        Me.showresult.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.showresult.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.showresult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.showresult.BorderRadius = 0
        Me.showresult.ButtonText = "Show Result"
        Me.showresult.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showresult.DisabledColor = System.Drawing.Color.Gray
        Me.showresult.Dock = System.Windows.Forms.DockStyle.Top
        Me.showresult.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showresult.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.showresult.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.showresult.Iconimage = CType(resources.GetObject("showresult.Iconimage"), System.Drawing.Image)
        Me.showresult.Iconimage_right = Global.StudentBenchmarking.My.Resources.Resources.Forward_104px
        Me.showresult.Iconimage_right_Selected = Nothing
        Me.showresult.Iconimage_Selected = Nothing
        Me.showresult.IconMarginLeft = 0
        Me.showresult.IconMarginRight = 0
        Me.showresult.IconRightVisible = False
        Me.showresult.IconRightZoom = 0.0R
        Me.showresult.IconVisible = True
        Me.showresult.IconZoom = 50.0R
        Me.showresult.IsTab = False
        Me.showresult.Location = New System.Drawing.Point(0, 4)
        Me.showresult.Margin = New System.Windows.Forms.Padding(5)
        Me.showresult.Name = "showresult"
        Me.showresult.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.showresult.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.showresult.OnHoverTextColor = System.Drawing.Color.White
        Me.showresult.selected = False
        Me.showresult.Size = New System.Drawing.Size(200, 43)
        Me.showresult.TabIndex = 13
        Me.showresult.Text = "Show Result"
        Me.showresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.showresult.Textcolor = System.Drawing.Color.White
        Me.showresult.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Panel1.TabIndex = 3
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
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 423)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.x, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents x As ns1.BunifuImageButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents update_db As ns1.BunifuFlatButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents showresult As ns1.BunifuFlatButton
    Friend WithEvents logout As ns1.BunifuFlatButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents generate_report As ns1.BunifuFlatButton
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class

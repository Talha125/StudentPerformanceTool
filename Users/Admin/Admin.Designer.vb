<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Control = New ns1.BunifuDragControl(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.close_button = New ns1.BunifuImageButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.content = New System.Windows.Forms.Panel()
        Me.heading = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logout = New ns1.BunifuFlatButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.settings = New ns1.BunifuFlatButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.delete = New ns1.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.modify = New ns1.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.add = New ns1.BunifuFlatButton()
        Me.Elipse = New ns1.BunifuElipse(Me.components)
        Me.BunifuImageButton2 = New ns1.BunifuImageButton()
        Me.Panel4.SuspendLayout()
        CType(Me.close_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Control
        '
        Me.Control.Fixed = True
        Me.Control.Horizontal = True
        Me.Control.TargetControl = Me.Panel4
        Me.Control.Vertical = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel4.Controls.Add(Me.close_button)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 423)
        Me.Panel4.TabIndex = 2
        '
        'close_button
        '
        Me.close_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.close_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_button.Image = CType(resources.GetObject("close_button.Image"), System.Drawing.Image)
        Me.close_button.ImageActive = Nothing
        Me.close_button.Location = New System.Drawing.Point(475, 4)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(33, 24)
        Me.close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.close_button.TabIndex = 2
        Me.close_button.TabStop = False
        Me.close_button.Zoom = 10
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel5.Controls.Add(Me.content)
        Me.Panel5.Controls.Add(Me.heading)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(520, 390)
        Me.Panel5.TabIndex = 1
        '
        'content
        '
        Me.content.BackColor = System.Drawing.Color.White
        Me.content.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.content.Location = New System.Drawing.Point(0, 45)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(520, 345)
        Me.content.TabIndex = 0
        '
        'heading
        '
        Me.heading.Location = New System.Drawing.Point(0, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(520, 38)
        Me.heading.TabIndex = 9
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
        Me.Panel1.TabIndex = 1
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
        Me.Panel3.Controls.Add(Me.settings)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.delete)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.modify)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.add)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 23)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 345)
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
        Me.logout.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.logout.Location = New System.Drawing.Point(0, 188)
        Me.logout.Margin = New System.Windows.Forms.Padding(5)
        Me.logout.Name = "logout"
        Me.logout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.logout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.logout.OnHoverTextColor = System.Drawing.Color.White
        Me.logout.selected = False
        Me.logout.Size = New System.Drawing.Size(200, 43)
        Me.logout.TabIndex = 17
        Me.logout.Text = "Logout"
        Me.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logout.Textcolor = System.Drawing.Color.White
        Me.logout.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Location = New System.Drawing.Point(0, 184)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'settings
        '
        Me.settings.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settings.BorderRadius = 0
        Me.settings.ButtonText = "Settings"
        Me.settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings.DisabledColor = System.Drawing.Color.Gray
        Me.settings.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.settings.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.settings.Iconimage = CType(resources.GetObject("settings.Iconimage"), System.Drawing.Image)
        Me.settings.Iconimage_right = CType(resources.GetObject("settings.Iconimage_right"), System.Drawing.Image)
        Me.settings.Iconimage_right_Selected = Nothing
        Me.settings.Iconimage_Selected = Nothing
        Me.settings.IconMarginLeft = 0
        Me.settings.IconMarginRight = 0
        Me.settings.IconRightVisible = False
        Me.settings.IconRightZoom = 0.0R
        Me.settings.IconVisible = True
        Me.settings.IconZoom = 50.0R
        Me.settings.IsTab = False
        Me.settings.Location = New System.Drawing.Point(0, 141)
        Me.settings.Margin = New System.Windows.Forms.Padding(5)
        Me.settings.Name = "settings"
        Me.settings.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.settings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.settings.OnHoverTextColor = System.Drawing.Color.White
        Me.settings.selected = False
        Me.settings.Size = New System.Drawing.Size(200, 43)
        Me.settings.TabIndex = 15
        Me.settings.Text = "Settings"
        Me.settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings.Textcolor = System.Drawing.Color.White
        Me.settings.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox5.Location = New System.Drawing.Point(0, 137)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
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
        Me.delete.Dock = System.Windows.Forms.DockStyle.Top
        Me.delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.delete.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.delete.Iconimage = CType(resources.GetObject("delete.Iconimage"), System.Drawing.Image)
        Me.delete.Iconimage_right = CType(resources.GetObject("delete.Iconimage_right"), System.Drawing.Image)
        Me.delete.Iconimage_right_Selected = Nothing
        Me.delete.Iconimage_Selected = Nothing
        Me.delete.IconMarginLeft = 0
        Me.delete.IconMarginRight = 0
        Me.delete.IconRightVisible = False
        Me.delete.IconRightZoom = 0.0R
        Me.delete.IconVisible = True
        Me.delete.IconZoom = 50.0R
        Me.delete.IsTab = False
        Me.delete.Location = New System.Drawing.Point(0, 94)
        Me.delete.Margin = New System.Windows.Forms.Padding(5)
        Me.delete.Name = "delete"
        Me.delete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.delete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.delete.OnHoverTextColor = System.Drawing.Color.White
        Me.delete.selected = False
        Me.delete.Size = New System.Drawing.Size(200, 43)
        Me.delete.TabIndex = 13
        Me.delete.Text = "Delete"
        Me.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.Textcolor = System.Drawing.Color.White
        Me.delete.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'modify
        '
        Me.modify.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.modify.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.modify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modify.BorderRadius = 0
        Me.modify.ButtonText = "Modify"
        Me.modify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modify.DisabledColor = System.Drawing.Color.Gray
        Me.modify.Dock = System.Windows.Forms.DockStyle.Top
        Me.modify.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modify.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.modify.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.modify.Iconimage = CType(resources.GetObject("modify.Iconimage"), System.Drawing.Image)
        Me.modify.Iconimage_right = CType(resources.GetObject("modify.Iconimage_right"), System.Drawing.Image)
        Me.modify.Iconimage_right_Selected = Nothing
        Me.modify.Iconimage_Selected = Nothing
        Me.modify.IconMarginLeft = 0
        Me.modify.IconMarginRight = 0
        Me.modify.IconRightVisible = False
        Me.modify.IconRightZoom = 0.0R
        Me.modify.IconVisible = True
        Me.modify.IconZoom = 50.0R
        Me.modify.IsTab = False
        Me.modify.Location = New System.Drawing.Point(0, 47)
        Me.modify.Margin = New System.Windows.Forms.Padding(5)
        Me.modify.Name = "modify"
        Me.modify.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.modify.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.modify.OnHoverTextColor = System.Drawing.Color.White
        Me.modify.selected = False
        Me.modify.Size = New System.Drawing.Size(200, 43)
        Me.modify.TabIndex = 7
        Me.modify.Text = "Modify"
        Me.modify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.modify.Textcolor = System.Drawing.Color.White
        Me.modify.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 4)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'add
        '
        Me.add.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.add.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.add.BorderRadius = 0
        Me.add.ButtonText = "Add"
        Me.add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add.DisabledColor = System.Drawing.Color.Gray
        Me.add.Dock = System.Windows.Forms.DockStyle.Top
        Me.add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.add.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.add.Iconimage = CType(resources.GetObject("add.Iconimage"), System.Drawing.Image)
        Me.add.Iconimage_right = CType(resources.GetObject("add.Iconimage_right"), System.Drawing.Image)
        Me.add.Iconimage_right_Selected = Nothing
        Me.add.Iconimage_Selected = Nothing
        Me.add.IconMarginLeft = 0
        Me.add.IconMarginRight = 0
        Me.add.IconRightVisible = True
        Me.add.IconRightZoom = 0.0R
        Me.add.IconVisible = True
        Me.add.IconZoom = 50.0R
        Me.add.IsTab = False
        Me.add.Location = New System.Drawing.Point(0, 0)
        Me.add.Margin = New System.Windows.Forms.Padding(5)
        Me.add.Name = "add"
        Me.add.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.add.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.add.OnHoverTextColor = System.Drawing.Color.White
        Me.add.selected = False
        Me.add.Size = New System.Drawing.Size(200, 43)
        Me.add.TabIndex = 0
        Me.add.Text = "Add"
        Me.add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add.Textcolor = System.Drawing.Color.White
        Me.add.TextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Elipse
        '
        Me.Elipse.ElipseRadius = 20
        Me.Elipse.TargetControl = Me
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
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 423)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.Panel4.ResumeLayout(False)
        CType(Me.close_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Control As ns1.BunifuDragControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents content As System.Windows.Forms.Panel
    Friend WithEvents add As ns1.BunifuFlatButton
    Friend WithEvents close_button As ns1.BunifuImageButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Elipse As ns1.BunifuElipse
    Friend WithEvents logout As ns1.BunifuFlatButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents settings As ns1.BunifuFlatButton
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents delete As ns1.BunifuFlatButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents modify As ns1.BunifuFlatButton
    Friend WithEvents add_records_assistant_attendance As StudentBenchmarking.add_records_admin_database
    Public WithEvents heading As System.Windows.Forms.Panel
    Friend WithEvents BunifuImageButton2 As ns1.BunifuImageButton

End Class

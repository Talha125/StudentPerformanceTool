<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mbox))
        Me.BunifuDragControl1 = New ns1.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton4 = New ns1.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ok = New ns1.BunifuFlatButton()
        Me.message = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 281)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BunifuImageButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(0, 0)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(35, 38)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 17
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ok)
        Me.Panel2.Controls.Add(Me.message)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 243)
        Me.Panel2.TabIndex = 0
        '
        'ok
        '
        Me.ok.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ok.BorderRadius = 0
        Me.ok.ButtonText = "OK"
        Me.ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ok.DisabledColor = System.Drawing.Color.Gray
        Me.ok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ok.Iconcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ok.Iconimage = Nothing
        Me.ok.Iconimage_right = CType(resources.GetObject("ok.Iconimage_right"), System.Drawing.Image)
        Me.ok.Iconimage_right_Selected = Nothing
        Me.ok.Iconimage_Selected = Nothing
        Me.ok.IconMarginLeft = 0
        Me.ok.IconMarginRight = 0
        Me.ok.IconRightVisible = True
        Me.ok.IconRightZoom = 0.0R
        Me.ok.IconVisible = True
        Me.ok.IconZoom = 50.0R
        Me.ok.IsTab = False
        Me.ok.Location = New System.Drawing.Point(255, 134)
        Me.ok.Margin = New System.Windows.Forms.Padding(7)
        Me.ok.Name = "ok"
        Me.ok.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ok.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.ok.OnHoverTextColor = System.Drawing.Color.White
        Me.ok.selected = False
        Me.ok.Size = New System.Drawing.Size(125, 57)
        Me.ok.TabIndex = 13
        Me.ok.Text = "OK"
        Me.ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ok.Textcolor = System.Drawing.Color.White
        Me.ok.TextFont = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'message
        '
        Me.message.AutoSize = True
        Me.message.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message.ForeColor = System.Drawing.Color.White
        Me.message.Location = New System.Drawing.Point(184, 67)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(0, 22)
        Me.message.TabIndex = 7
        Me.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'mbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 281)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Welcome"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuDragControl1 As ns1.BunifuDragControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents message As System.Windows.Forms.Label
    Friend WithEvents ok As ns1.BunifuFlatButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents BunifuImageButton4 As ns1.BunifuImageButton
End Class

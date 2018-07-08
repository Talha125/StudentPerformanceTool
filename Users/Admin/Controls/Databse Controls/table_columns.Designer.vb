<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablecolumns
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
        Dim MainColorScheme1 As MetroSuite.MetroTextBox.MainColorScheme = New MetroSuite.MetroTextBox.MainColorScheme()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tablecolumns))
        Me.heading = New System.Windows.Forms.Panel()
        Me.length_size = New MetroFramework.Controls.MetroComboBox()
        Me.type = New MetroFramework.Controls.MetroComboBox()
        Me.key_select = New MetroFramework.Controls.MetroComboBox()
        Me.column_name = New MetroSuite.MetroTextBox()
        Me.heading.SuspendLayout()
        Me.SuspendLayout()
        '
        'heading
        '
        Me.heading.BackColor = System.Drawing.Color.White
        Me.heading.Controls.Add(Me.length_size)
        Me.heading.Controls.Add(Me.type)
        Me.heading.Controls.Add(Me.key_select)
        Me.heading.Controls.Add(Me.column_name)
        Me.heading.Location = New System.Drawing.Point(0, 0)
        Me.heading.Name = "heading"
        Me.heading.Size = New System.Drawing.Size(502, 35)
        Me.heading.TabIndex = 10
        '
        'length_size
        '
        Me.length_size.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.length_size.Cursor = System.Windows.Forms.Cursors.Hand
        Me.length_size.DropDownHeight = 110
        Me.length_size.ForeColor = System.Drawing.Color.White
        Me.length_size.FormattingEnabled = True
        Me.length_size.IntegralHeight = False
        Me.length_size.ItemHeight = 23
        Me.length_size.Location = New System.Drawing.Point(261, 3)
        Me.length_size.Name = "length_size"
        Me.length_size.PromptText = "Size/Length"
        Me.length_size.Size = New System.Drawing.Size(101, 29)
        Me.length_size.TabIndex = 25
        Me.length_size.UseSelectable = True
        '
        'type
        '
        Me.type.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.type.ForeColor = System.Drawing.Color.White
        Me.type.FormattingEnabled = True
        Me.type.ItemHeight = 23
        Me.type.Items.AddRange(New Object() {"CHAR", "VARCHAR", "INT", "FLOAT"})
        Me.type.Location = New System.Drawing.Point(141, 3)
        Me.type.Name = "type"
        Me.type.PromptText = "Datatype"
        Me.type.Size = New System.Drawing.Size(101, 29)
        Me.type.TabIndex = 24
        Me.type.UseSelectable = True
        '
        'key_select
        '
        Me.key_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.key_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.key_select.ForeColor = System.Drawing.Color.White
        Me.key_select.FormattingEnabled = True
        Me.key_select.ItemHeight = 23
        Me.key_select.Items.AddRange(New Object() {"Primary Key", "Unique", "No Key"})
        Me.key_select.Location = New System.Drawing.Point(379, 3)
        Me.key_select.Name = "key_select"
        Me.key_select.PromptText = "Key"
        Me.key_select.Size = New System.Drawing.Size(101, 29)
        Me.key_select.TabIndex = 23
        Me.key_select.UseSelectable = True
        '
        'column_name
        '
        Me.column_name.BanChars = False
        MainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(240, Byte), Integer))
        MainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        MainColorScheme1.MainColor = System.Drawing.Color.White
        Me.column_name.ColorScheme = MainColorScheme1
        Me.column_name.DefaultText = Nothing
        Me.column_name.DefaultTextColor = System.Drawing.Color.LightGray
        Me.column_name.DefaultTextNormalForeColor = System.Drawing.SystemColors.ControlText
        Me.column_name.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.column_name.ForeColor = System.Drawing.Color.Gray
        Me.column_name.IllegalChars = CType(resources.GetObject("column_name.IllegalChars"), System.Collections.Generic.List(Of Char))
        Me.column_name.Location = New System.Drawing.Point(22, 3)
        Me.column_name.Name = "column_name"
        Me.column_name.Size = New System.Drawing.Size(101, 29)
        Me.column_name.TabIndex = 22
        Me.column_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.column_name.UseDefaultText = False
        '
        'tablecolumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.heading)
        Me.Name = "tablecolumns"
        Me.Size = New System.Drawing.Size(502, 35)
        Me.heading.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents heading As System.Windows.Forms.Panel
    Friend WithEvents key_select As MetroFramework.Controls.MetroComboBox
    Friend WithEvents column_name As MetroSuite.MetroTextBox
    Friend WithEvents length_size As MetroFramework.Controls.MetroComboBox
    Friend WithEvents type As MetroFramework.Controls.MetroComboBox

End Class

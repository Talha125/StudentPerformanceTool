Imports System.Data.SqlClient
Imports System.IO

Public Class insert_photo
    Dim s_pic As String = ""
    Dim f_pic As String = ""
    Dim m_pic As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Choose Father's Photo"
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"

        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofd.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox5.Image = Image.FromFile(ofd.FileName)
                f_pic = ofd.FileName
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Choose Student's Photo"
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"

        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofd.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox4.Image = Image.FromFile(ofd.FileName)
                s_pic = ofd.FileName
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Choose Mother's Photo"
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"

        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofd.FileName) = False Then
                MessageBox.Show("Sorry, The File You Specified Does Not Exist.")
            Else
                PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBox6.Image = Image.FromFile(ofd.FileName)
                m_pic = ofd.FileName
            End If

        End If

    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        db_select.Enabled = True
        db_select.Cursor = Cursors.Hand
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        db_select.SelectedItem = Nothing
        db_select.Items.Clear()

        cmd.CommandText = "SELECT count([name]) as max FROM master.dbo.sysdatabases where [name] like '" & course.SelectedItem & "%' and dbid>4;"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "SELECT [name] FROM master.dbo.sysdatabases where [name] like '" & course.SelectedItem & "%' and dbid>4;"
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            For i As Integer = 0 To count - 1
                rd.Read()
                db_select.Items.Add(rd("name"))

            Next

        End If
        con.Close()
    End Sub

    Private Sub db_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles db_select.SelectedIndexChanged
        table_select.Enabled = True
        table_select.Cursor = Cursors.Hand
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        table_select.SelectedItem = Nothing
        table_select.Items.Clear()

        cmd.CommandText = "select count(name) as max from sys.tables where name like 'photo%';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select name from sys.tables where name like 'photo%';"
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            For i As Integer = 0 To count - 1
                rd.Read()
                table_select.Items.Add(rd("name"))
            Next

        End If
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        TextBox1.Enabled = False

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "insert into " & table_select.SelectedItem & "(Enrollment_No,Student_Photo) select '" & TextBox1.Text & "', bulkcolumn from openrowset(bulk '" & s_pic & "',single_blob) as img;"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "update " & table_select.SelectedItem & " set[Father_Photo]= (select bulkcolumn from openrowset(bulk '" & f_pic & "',single_blob) as img) where Enrollment_No='" & TextBox1.Text & "';"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "update " & table_select.SelectedItem & " set[Mother_Photo]= (select bulkcolumn from openrowset(bulk '" & m_pic & "',single_blob) as img) where Enrollment_No='" & TextBox1.Text & "';"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please Enter Numbers Only")
            e.Handled = True

        End If
    End Sub

End Class

Imports System.Data.SqlClient
Imports System.IO

Public Class insert_attend

    Private Sub insert_attend_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    End Sub

    Private Sub table_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles table_select.SelectedIndexChanged
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim dt = New DataTable

        DataGridView1.DataSource = Nothing


        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from " & table_select.SelectedItem & ";"
        rd = cmd.ExecuteReader

        dt.Load(rd)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        con.Close()
    End Sub

    Private Sub db_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles db_select.SelectedIndexChanged
        sem.Enabled = True
        sem.Cursor = Cursors.Hand
        sem.SelectedItem = Nothing
    End Sub

    Private Sub sem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sem.SelectedIndexChanged
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

        cmd.CommandText = "select count(name) as max from sys.tables where name like 'sem" & sem.SelectedItem & "_attend%';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select name from sys.tables where name like 'sem" & sem.SelectedItem & "_attend%';"
        rd = cmd.ExecuteReader
        If rd.HasRows = True Then
            For i As Integer = 0 To count - 1
                rd.Read()
                table_select.Items.Add(rd("name"))
            Next

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.ReadOnly = False
        DataGridView1.ForeColor = Color.Black

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select count(Enrollment_No) as totalrows from " & table_select.SelectedItem & ";"
        rd = cmd.ExecuteReader

        If rd.HasRows = True Then
            rd.Read()
            For i As Integer = 0 To rd("totalrows") - 1
                DataGridView1.Rows(i).ReadOnly = True

            Next
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.ReadOnly = True
        DataGridView1.ForeColor = Color.Gray
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select count(name) as max from sys.columns where object_id=object_id('dbo." & table_select.SelectedItem & "');"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim count As Integer = rd("max")
        rd.Close()
        
        cmd.CommandText = "select count(Enrollment_No) as totalrows from " & table_select.SelectedItem & ";"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim totalrows As Integer = rd("totalrows")
        rd.Close()

        Dim temp(count) As String
        Dim str As String = ""
        Dim sb As New System.Text.StringBuilder()

        For i As Integer = totalrows To DataGridView1.RowCount - 2
            For j As Integer = 0 To count - 1

                temp(j) = DataGridView1.Rows(i).Cells(j).Value

                str = sb.Append("'").Append(temp(j)).Append("',").ToString

            Next

            str = str.Remove(str.Length - 1)

            cmd.CommandText = "insert into " & table_select.SelectedItem & "  values(" & str & ")"
            cmd.ExecuteNonQuery()
            str = str.Remove(0, str.Length)
            sb = sb.Remove(0, sb.Length)

        Next
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Choose a File"
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "Database Files(*.accdb;*.mdb;*.xlsx)|*.accdb;*.mdb;*.xlsx"

        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            If File.Exists(ofd.FileName) = False Then
                MsgBox("Sorry, The File You Specified Does Not Exist.")
            ElseIf ofd.AddExtension() Then


                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = ofd.FileName
                DataGridView1.Refresh()

            Else

                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = ofd.FileName
                DataGridView1.Refresh()

            End If

        End If
    End Sub
End Class

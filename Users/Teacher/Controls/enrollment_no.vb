Imports System.Data.SqlClient

Public Class enrollment_no

    Dim basic_info As New basic_info

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        eno.SelectedItem = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        db = db_select.SelectedItem
        smstr = sem.SelectedItem
        Teacher.enrollment_no_clicks(0)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            Button1_Click(Button1, New EventArgs)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

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
        sem.Enabled = True
        sem.Cursor = Cursors.Hand
        sem.SelectedItem = Nothing
    End Sub

    Private Sub sem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sem.SelectedIndexChanged
        eno.Enabled = True
        eno.Cursor = Cursors.Hand
        
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db_select.SelectedItem & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        eno.SelectedItem = Nothing
        eno.Items.Clear()


        cmd.CommandText = "Select count(Enrollment_No) as totaleno from stu_personal_data;"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim count As Integer = rd("totaleno")
        rd.Close()

        cmd.CommandText = "Select Enrollment_No from stu_personal_data;"
        rd = cmd.ExecuteReader

        If rd.HasRows = True Then
            For i As Integer = 0 To count - 1

                rd.Read()
                eno.Items.Add(rd("Enrollment_No"))

            Next
        End If
    End Sub

    Private Sub eno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eno.SelectedIndexChanged
        Button1.Enabled = True
        Button2.Enabled = True
        Button1.Cursor = Cursors.Hand
        Button2.Cursor = Cursors.Hand
        enroll = eno.SelectedItem

    End Sub
End Class

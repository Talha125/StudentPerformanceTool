Imports System.Data.SqlClient
Public Class Create_Database
    Dim msg As New mbox
    Dim database_name As String
    Dim j As Integer = 0
    Dim k As Integer = 0
    Dim years As String
    Dim course As String



    Private Sub create_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1990 To 2070
            year_box.Items.Add(i)
        Next i

    End Sub


    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        db_name.Text = ""
        year_box.SelectedIndex = -1
        course_select.SelectedIndex = -1
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        If (j = 0 Or k = 0) Then
            msg.mes("Cannot Be Blank.")
        Else
            Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=master;Integrated Security=True;Pooling=False")
            Dim myCommand As String
            Dim dbname As String
            Dim check As Integer
            dbname = db_name.Text
            myCommand = "CREATE database " & dbname
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                check = cmd.ExecuteNonQuery()
                If (check) Then
                    msg.mes("Database Sucessfully Created.")
                End If

            Catch
                msg.mes(" Database Already Created")
            Finally
                cmd.Connection.Close()
            End Try

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        db_name.Text = ""
        year_box.SelectedIndex = -1
        course_select.SelectedIndex = -1

    End Sub

    Private Sub course_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course_select.SelectedIndexChanged
        j = 1
        If (k = 1) Then
            db_name.Text = ""
            years = year_box.SelectedItem.ToString
            course = course_select.SelectedItem
            db_name.Text = course + "_" + years
        End If
    End Sub

    Private Sub year_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year_box.SelectedIndexChanged
        k = 1
        If (j = 1) Then
            db_name.Text = ""
            years = year_box.SelectedItem.ToString
            course = course_select.SelectedItem
            db_name.Text = course + "_" + years

        End If
    End Sub
End Class

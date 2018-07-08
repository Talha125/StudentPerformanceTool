Imports System.Data.SqlClient

Public Class delete_user
    Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=SPMS;Integrated Security=True;Pooling=False")
    Dim msg As New mbox
    Dim myCommand As String
    Dim rd As SqlDataReader

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        userid.SelectedIndex = -1
    End Sub


    Public Sub usernames()
        myCommand = "Select * from users"
        Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
        userid.Items.Clear()
        userid.SelectedIndex = -1
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            rd = cmd.ExecuteReader
            While (rd.Read)
                userid.Items.Add(rd.GetString(0))
            End While
            cmd.Connection.Close()
        Catch
            msg.mes("Table Doesn't Exist.")
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        userid.SelectedIndex = -1
        usernames()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (userid.SelectedIndex = -1) Then
            msg.mes("Please Select Username.")
        Else
            myCommand = "Delete from users where username='" + userid.SelectedItem + "'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                msg.mes("User Sucessfully Deleted.")
                cmd.Connection.Close()
                usernames()
            Catch
                msg.mes("Error.")
            End Try
        End If
    End Sub


End Class

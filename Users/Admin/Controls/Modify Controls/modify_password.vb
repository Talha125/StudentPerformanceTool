Imports System.Data.SqlClient

Public Class modify_password
    Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=SPMS;Integrated Security=True;Pooling=False")
    Dim msg As New mbox
    Dim myCommand As String
    Dim rd As SqlDataReader

    Private Sub userid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userid.SelectedIndexChanged
        If (userid.SelectedIndex = -1) Then

        Else
            myCommand = "select password from users where username='" + userid.SelectedItem + "'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                rd = cmd.ExecuteReader
                rd.Read()
                curr_pass.Text = rd("password").ToString()
                cmd.Connection.Close()
            Catch
                msg.mes("Username Doesn't Exist.")
            End Try
        End If
    End Sub

    Public Sub usernames()
        myCommand = "Select * from users"
        Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
        userid.Items.Clear()
        userid.SelectedIndex = -1
        new_pass.Text = ""
        curr_pass.Text = ""
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

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (userid.SelectedIndex = -1 Or new_pass.Text = "") Then
            msg.mes("Please Fill Fields.")
        Else
            myCommand = "Update users set password='" + new_pass.Text + "' Where username='" + userid.SelectedItem + "'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                msg.mes("Password Sucessfully Changed.")
                cmd.Connection.Close()
                usernames()
            Catch
                msg.mes("Error.")
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        userid.SelectedIndex = -1
        curr_pass.Text = ""
        new_pass.Text = ""
        usernames()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        userid.SelectedIndex = -1
        curr_pass.Text = ""
        new_pass.Text = ""
    End Sub
End Class

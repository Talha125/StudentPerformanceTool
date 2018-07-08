Imports System.Data.SqlClient

Public Class modify_username
    Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=SPMS;Integrated Security=True;Pooling=False")
    Dim msg As New mbox
    Dim check_pass As Integer = 0
    Dim check_user As Integer = 0
    Dim myCommand As String
    Dim rd As SqlDataReader


    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles new_user.TextChanged
        Dim user As String
        If (new_user.Text = "") Then
            user_check.Image = Nothing
        Else
            user = new_user.Text
            Dim myCommand As String
            myCommand = "Select username From users"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Dim rd As SqlDataReader
            Try
                cmd.Connection.Open()
                rd = cmd.ExecuteReader
                While (rd.Read())
                    If (new_user.Text = rd.GetString(0)) Then
                        user_check.Load(Application.StartupPath & "\Icons\wrong.png")
                        check_user = 0
                        Exit While
                    Else
                        user_check.Load(Application.StartupPath & "\Icons\right.png")
                        check_user = 1
                    End If
                End While
                cmd.Connection.Close()
            Catch
                msg.mes("Table Doesn't Exist")
            End Try
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        userid.SelectedIndex = -1
        new_user.Text = ""
        user_type.Text = ""

    End Sub

    
    Private Sub userid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userid.SelectedIndexChanged
        If (userid.SelectedIndex = -1) Then

        Else
            myCommand = "select type from users where username='" + userid.SelectedItem + "'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                rd = cmd.ExecuteReader
                rd.Read()
                user_type.Text = rd("type").ToString()
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
        user_type.Text = ""
        new_user.Text = ""
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
        new_user.Text = ""
        user_type.Text = ""
        usernames()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (userid.SelectedIndex = -1 Or new_user.Text = "") Then
            msg.mes("Please Fill Fields.")
        ElseIf (check_user = 0) Then
            msg.mes("Username Already Taken.")
        Else
            myCommand = "Update users set username='" + new_user.Text + "' Where username='" + userid.SelectedItem+"'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                msg.mes("Username Sucessfully Changed.")
                cmd.Connection.Close()
                usernames()
            Catch
                msg.mes("Error.")
            End Try
        End If
    End Sub
    
    
End Class

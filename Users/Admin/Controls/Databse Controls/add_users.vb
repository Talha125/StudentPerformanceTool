Imports System.Data.SqlClient

Public Class add_users
    Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=SPMS;Integrated Security=True;Pooling=False")
    Dim msg As New mbox
    Dim check_pass As Integer = 0
    Dim check_user As Integer = 0

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        username.Text = ""
        password.Text = ""
        confirmpassword.Text = ""
        user_type.SelectedIndex = -1
    End Sub

    Private Sub confirmpassword_Click(sender As Object, e As EventArgs) Handles confirmpassword.Click, confirmpassword.MouseClick
        If (password.Text = "") Then
            msg.mes("Password Field Cannot Be Blank.")
            password.Focus()
        End If
    End Sub

    Private Sub confirmpassword_TextChanged(sender As Object, e As EventArgs) Handles confirmpassword.TextChanged
        If (password.Text = "" And confirmpassword.Text = "") Then
            password_check.Image = Nothing
        ElseIf (password.Text = confirmpassword.Text) Then
            password_check.Load(Application.StartupPath & "\Icons\right.png")
            check_pass = 1
        Else
            password_check.Load(Application.StartupPath & "\Icons\wrong.png")
            check_pass = 0
        End If
    End Sub

    Private Sub confirmpassword_Click(sender As Object, e As MouseEventArgs) Handles confirmpassword.MouseClick, confirmpassword.Click
        If (password.Text = "") Then
            msg.mes("Password Field Cannot Be Blank.")
            password.Focus()
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        If (password.Text = "" And confirmpassword.Text = "") Then
            password_check.Image = Nothing
        ElseIf (password.Text = confirmpassword.Text) Then
            password_check.Load(Application.StartupPath & "\Icons\right.png")
            check_pass = 1
        Else
            password_check.Load(Application.StartupPath & "\Icons\wrong.png")
            check_pass = 0
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        username.Text = ""
        password.Text = ""
        confirmpassword.Text = ""
        user_type.SelectedIndex = -1
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        Dim user As String
        If (username.Text = "") Then
            user_check.Image = Nothing
        Else
            user = username.Text
            Dim myCommand As String
            myCommand = "Select username From users"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Dim rd As SqlDataReader
            Try
                cmd.Connection.Open()
                rd = cmd.ExecuteReader
                While (rd.Read())
                    If (username.Text = rd.GetString(0)) Then
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

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        If (username.Text = "" Or password.Text = "" Or confirmpassword.Text = "" Or user_type.SelectedIndex = -1) Then
            msg.mes("Please Fill All Fields.")
        Else
            If (check_user = 0) Then
                msg.mes("Username Already Taken.")
            ElseIf (check_pass = 0) Then
                msg.mes("Password Doesn't Match")
            Else
                Dim user As String = username.Text
                Dim type As String = user_type.SelectedItem.ToString
                Dim pass As String = password.Text
                Dim myCommand As String
                myCommand = "Insert Into users values('" + user + "','" + pass + "','" + type + "')"
                Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                    msg.mes("User Sucessfully Created.")
                    cmd.Connection.Close()
                Catch
                    msg.mes("Error")
                End Try
            End If
        End If
    End Sub


End Class

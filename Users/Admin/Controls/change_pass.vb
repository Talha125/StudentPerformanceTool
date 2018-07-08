Imports System.Data.SqlClient

Public Class change_pass
    Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=SPMS;Integrated Security=True;Pooling=False")
    Dim msg As New mbox
    Dim check_pass As Integer = 0
    Dim check_user As Integer = 0

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        curr_pass.Text = ""
        new_pass.Text = ""
        con_pass.Text = ""

    End Sub

    Private Sub con_password_Click(sender As Object, e As EventArgs) Handles con_pass.Click, con_pass.MouseClick
        If (new_pass.Text = "") Then
            msg.mes("Password Field Cannot Be Blank.")
            new_pass.Focus()
        End If
    End Sub

    Private Sub con_pass_TextChanged(sender As Object, e As EventArgs) Handles con_pass.TextChanged
        If (new_pass.Text = "" And con_pass.Text = "") Then
            password_check.Image = Nothing
        ElseIf (new_pass.Text = con_pass.Text) Then
            password_check.Load(Application.StartupPath & "\Icons\right.png")
            check_pass = 1
        Else
            password_check.Load(Application.StartupPath & "\Icons\wrong.png")
            check_pass = 0
        End If
    End Sub

    Private Sub new_pass_TextChanged(sender As Object, e As EventArgs) Handles new_pass.TextChanged
        If (new_pass.Text = "" And con_pass.Text = "") Then
            password_check.Image = Nothing
        ElseIf (new_pass.Text = con_pass.Text) Then
            password_check.Load(Application.StartupPath & "\Icons\right.png")
            check_pass = 1
        Else
            password_check.Load(Application.StartupPath & "\Icons\wrong.png")
            check_pass = 0
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        curr_pass.Text = ""
        new_pass.Text = ""
        con_pass.Text = ""

    End Sub

    Private Sub curr_pass_TextChanged(sender As Object, e As EventArgs) Handles curr_pass.TextChanged
        Dim pass As String
        If (curr_pass.Text = "") Then
            user_check.Image = Nothing
        Else
            pass = curr_pass.Text
            Dim myCommand As String
            myCommand = "Select password From users where username='" + userid + "'"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Dim rd As SqlDataReader
            Try
                cmd.Connection.Open()
                rd = cmd.ExecuteReader
                While (rd.Read())
                    If (curr_pass.Text = rd.GetString(0)) Then
                        user_check.Load(Application.StartupPath & "\Icons\right.png")
                        check_user = 1
                        Exit While
                    Else
                        user_check.Load(Application.StartupPath & "\Icons\wrong.png")
                        check_user = 0
                    End If
                End While
                cmd.Connection.Close()
            Catch
                msg.mes("Error")
            End Try
        End If

    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles change.Click
        If (curr_pass.Text = "" Or new_pass.Text = "" Or con_pass.Text = "") Then
            msg.mes("Please Fill All Fields.")
        Else
            If (check_user = 0) Then
                msg.mes("Wrong Password.")
            ElseIf (check_pass = 0) Then
                msg.mes("Password does not match the confirm password.")
            Else
                Dim newpass As String = new_pass.Text
                Dim pass As String = con_pass.Text
                Dim myCommand As String
                myCommand = "Update users set password='" + pass + "'Where username='" + userid + "'"
                Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
                Try
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                    msg.mes("Password Changed Sucessfully.")
                    ParentForm.Hide()
                    Welcome.Show()
                    cmd.Connection.Close()
                Catch
                    msg.mes("Error")
                End Try
            End If
        End If
    End Sub
End Class

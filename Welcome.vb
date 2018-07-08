Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data

Public Class Welcome
   
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        If id.Text = "" Or pass.Text = "" Then
            If id.Text = "" And pass.Text = "" Then
                MsgBox("Username and Password field is blank.")
                id.Focus()

            ElseIf pass.Text = "" Then
                MsgBox("Password field is blank.")
                pass.Focus()

            Else
                MsgBox("Username field is blank.")
                id.Focus()

            End If

        Else
            Dim uname As String = ""
            Dim pword As String
            Dim type As String = ""
           
            uname = id.Text
            pword = pass.Text

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=SPMS; Integrated Security=True"
            cmd.Connection = con
            con.Open()

            cmd.CommandText = "Select type From users where username= '" & uname & "'And password='" & pword & "';"
            rd = cmd.ExecuteReader
            rd.Read()

            Try
                type = rd("type").ToString
                userid = uname

            Catch ex As Exception

                MsgBox("Wrong Username And Password.")

            End Try

            If (type = "Assistant") Then
                userid = type
                Assistant.Show()

                If Assistant.Visible Then
                    Me.Hide()

                End If

            ElseIf (type = "Admin") Then
                userid = type
                Admin.Show()

                If Admin.Visible Then
                    Me.Hide()

                End If

            ElseIf (type = "Teacher") Then
                userid = type
                Teacher.Show()

                If Teacher.Visible Then
                    Me.Hide()

                End If

            Else
                MsgBox("Login failed.")
                id.Text = ""
                pass.Text = ""

            End If
        End If
    End Sub

    Private Sub Timer1_Splash_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Progressbar.Value < 100) Then
            Progressbar.Visible = True
            Panel3.Visible = True
            Progressbar.Value = Progressbar.Value + 10
        Else
            Panel3.Visible = False
        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Environment.Exit(0)
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        id.Text = ""
        pass.Text = ""
        Panel1.Focus()
    End Sub

    Private Sub showpass_OnChange(sender As Object, e As EventArgs) Handles showpass.OnChange
        If showpass.Checked Then
            pass.isPassword = False
        Else
            pass.isPassword = True
        End If
    End Sub

    Private Sub BunifuImageButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

        Environment.Exit(0)
    End Sub

    Private Sub pass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles pass.KeyDown
        If e.KeyCode = Keys.Enter Then

            login_Click(login, New EventArgs)

        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        about_us.Show()
    End Sub

    Private Sub pass_OnValueChanged(sender As Object, e As EventArgs) Handles pass.OnValueChanged
        If showpass.Checked Then
            pass.isPassword = False
        Else
            pass.isPassword = True
        End If
    End Sub

   
End Class
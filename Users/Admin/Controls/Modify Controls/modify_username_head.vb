Public Class modify_username_head

    
    Private Sub change_user_Click(sender As Object, e As EventArgs) Handles change_user.Click
        Dim modify_user As New modify_username
        change_pass.ForeColor = Color.DarkGray
        change_user.ForeColor = Color.FromArgb(1, 202, 254)
        Admin.content.Controls.Clear()
        Admin.content.Controls.Add(modify_user)
        change_u.Visible = True
        change_p.Visible = False
    End Sub

    Private Sub change_pass_Click(sender As Object, e As EventArgs) Handles change_pass.Click
        Dim modify_pass As New modify_password
        change_pass.ForeColor = Color.FromArgb(1, 202, 254)
        change_user.ForeColor = Color.DarkGray
        Admin.content.Controls.Clear()
        Admin.content.Controls.Add(modify_pass)
        change_u.Visible = False
        change_p.Visible = True
    End Sub

End Class

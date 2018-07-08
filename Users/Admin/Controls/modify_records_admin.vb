Public Class modify_records_admin

    Private Sub Modify_Table_Click(sender As Object, e As EventArgs) Handles Modify_Table.Click
        Admin.modify_control(0)
    End Sub

    Private Sub Add_Users_Click(sender As Object, e As EventArgs) Handles Modify_Users.Click
        Admin.modify_control(1)
    End Sub

End Class

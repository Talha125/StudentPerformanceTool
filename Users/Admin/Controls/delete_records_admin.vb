Public Class delete_records_admin
    Private Sub foreign_key_Click(sender As Object, e As EventArgs) Handles foreign_key.Click
        Admin.delete_control(0)
    End Sub

    Private Sub Modify_Table_Click(sender As Object, e As EventArgs) Handles Modify_Table.Click
        Admin.delete_control(1)
    End Sub

    Private Sub Add_Users_Click(sender As Object, e As EventArgs) Handles Modify_Users.Click
        Admin.delete_control(2)
    End Sub

    Private Sub Delete_Table_Click(sender As Object, e As EventArgs) Handles Delete_Table.Click
        Admin.add_records_assistant_database_clicks(2)
    End Sub
End Class

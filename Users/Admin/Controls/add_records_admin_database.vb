Public Class add_records_admin_database

    Private Sub Create_Database_Click(sender As Object, e As EventArgs) Handles Create_Database.Click
        Admin.add_records_assistant_database_clicks(0)
    End Sub

    Private Sub Add_Table_Click(sender As Object, e As EventArgs) Handles Add_Table.Click
        Admin.add_records_assistant_database_clicks(1)
    End Sub

    Private Sub Add_Users_Click(sender As Object, e As EventArgs) Handles Add_Users.Click
        Admin.add_records_assistant_database_clicks(3)
    End Sub

    Private Sub foreign_key_Click(sender As Object, e As EventArgs) Handles foreign_key.Click
        Admin.modify_control(0)
    End Sub
End Class

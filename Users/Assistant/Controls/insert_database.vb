Public Class insert_database

    Private Sub insert_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub studatabutton_Click(sender As Object, e As EventArgs) Handles studatabutton.Click
        Assistant.insert_database_clicks(0)
    End Sub

    Private Sub photobutton_Click(sender As Object, e As EventArgs) Handles photobutton.Click
        Assistant.insert_database_clicks(1)
    End Sub
End Class

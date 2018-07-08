Public Class student_records

   
   

    Private Sub strengthsbutton_Click(sender As Object, e As EventArgs) Handles strengthsbutton.Click
        Assistant.student_records_clicks(2)
    End Sub

    Private Sub marksbutton_Click(sender As Object, e As EventArgs) Handles marksbutton.Click
        Assistant.student_records_clicks(0)
    End Sub

    Private Sub attendbutton_Click(sender As Object, e As EventArgs) Handles attendbutton.Click
        Assistant.student_records_clicks(1)
    End Sub
End Class

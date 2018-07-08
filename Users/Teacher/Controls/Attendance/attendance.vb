Public Class attendance
    Dim attend_total As New attend_total
    Dim head_total_attend As New head_total_attend
    Dim a As Integer
   

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 10
        If (a = 100) Then

            Timer1.Stop()

            Teacher.Panel6.Controls.Clear()
            Teacher.Panel7.Controls.Add(head_total_attend)
            Teacher.Panel6.Controls.Add(attend_total)
        End If
    End Sub
End Class

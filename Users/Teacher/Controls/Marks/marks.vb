Public Class marks
    Dim stand As New stand
    Dim head_stand As New head_stand
    Dim a As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        a = a + 10
        If (a = 100) Then

            Timer1.Stop()

            Teacher.Panel6.Controls.Clear()
            Teacher.Panel7.Controls.Add(head_stand)
            Teacher.Panel6.Controls.Add(stand)

        End If
    End Sub
End Class

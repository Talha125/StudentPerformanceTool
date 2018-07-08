Public Class about_us

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Hide()
    End Sub

    Private Sub pg1_Click(sender As Object, e As EventArgs) Handles pg1.Click
        Dim webAddress As String = "https://www.facebook.com/piyush.goel.946179?fref=ts"
        Process.Start(webAddress)
    End Sub

    Private Sub pg2_Click(sender As Object, e As EventArgs) Handles pg2.Click
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub pg3_Click(sender As Object, e As EventArgs) Handles pg3.Click
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub pk1_Click(sender As Object, e As EventArgs) Handles pk1.Click
        Dim webAddress As String = "https://www.facebook.com/profile.php?id=100000913640038"
        Process.Start(webAddress)
    End Sub

    Private Sub pk2_Click(sender As Object, e As EventArgs) Handles pk2.Click
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub pk3_Click(sender As Object, e As EventArgs) Handles pk3.Click
        Dim webAddress As String = "http://www.example.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
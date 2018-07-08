Public Class mbox

    Public Sub New()

        InitializeComponent()

    End Sub
    Public Sub mes(ByVal text As String)
        message.Text = text
        Me.ShowDialog()
    End Sub
    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        Me.Close()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click

    End Sub
End Class
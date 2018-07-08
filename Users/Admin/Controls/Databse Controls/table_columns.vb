Public Class tablecolumns
    Dim msg As New mbox
    Dim col_data As New Dictionary(Of String, String)
    Dim column_no() As String
    Dim numbers As Integer

    Private Sub heading_Paint(sender As Object, e As PaintEventArgs) Handles heading.Paint
        For i = 1 To 100
            length_size.Items.Add(i)
        Next i

    End Sub

    Private Sub type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type.SelectedIndexChanged
        Dim l As String
        l = type.SelectedItem
        If (l = "INT") Then
            length_size.Enabled = False
            length_size.SelectedIndex = -1
            data_col()
        Else
            length_size.Enabled = True
            data_col()
        End If
    End Sub



    Private Sub length_size_Click(sender As Object, e As EventArgs) Handles length_size.Click
        Dim t As Integer
        t = type.SelectedIndex
        If (t = -1) Then
            msg.mes("Please Select Data Type.")
        Else
            data_col()
        End If
    End Sub


    Private Sub type_Click(sender As Object, e As EventArgs) Handles type.Click
        If (column_name.Text = "") Then
            msg.mes("Column Name Cannot Be Blank.")
        Else
            data_col()
        End If
    End Sub

    Private Sub key_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles key_select.SelectedIndexChanged
        If (length_size.Enabled And length_size.SelectedIndex = -1) Then
            msg.mes("Length Cannot Be Blank.")
        Else
            data_col()
        End If

    End Sub

    Public Sub data_col()
        col_data.Clear()
        Dim c_data As New add_table
        col_data.Add("field", Me.column_name.Text)
        col_data.Add("type", Me.type.SelectedItem)
        If (length_size.Enabled = True) Then
            col_data.Add("length", Me.length_size.SelectedItem)
        End If
        col_data.Add("key", Me.key_select.SelectedItem)
        column_no = Me.Name.Split("_")
        c_data.column_data(col_data, column_no(1))
    End Sub

    Private Sub column_name_TextChanged(sender As Object, e As EventArgs) Handles column_name.TextChanged
        data_col()
    End Sub
End Class

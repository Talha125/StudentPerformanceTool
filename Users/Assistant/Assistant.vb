Public Class Assistant

    'data controls
    Dim student_records As New student_records
    Dim insert_marks As New insert_marks
    Dim insert_attend As New insert_attend
    Dim insert_strengths As New insert_strengths
    Dim insert_database As New insert_database

    Dim insert_photo As New insert_photo
    Dim insert_student_data As New insert_student_data

    'header controls
    Dim head_student_records As New head_student_records
    Dim head_insert_marks As New head_insert_marks
    Dim head_insert_attend As New head_insert_attend
    Dim head_insert_strengths As New head_insert_strengths
    Dim head_insert_database As New head_insert_database

    Dim head_insert_photo As New head_insert_photo
    Dim head_insert_student_data As New head_insert_student_data

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()
    End Sub

    Private Sub x_Click(sender As Object, e As EventArgs) Handles x.Click
        Me.Hide()
        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()
    End Sub

    Private Sub assistant_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel7.Controls.Add(head_student_records)
        Panel6.Controls.Add(student_records)
        studentrecords.IconRightVisible = True
    End Sub

    Private Sub studentrecords_Click(sender As Object, e As EventArgs) Handles studentrecords.Click
        Panel7.Controls.Clear()
        Panel6.Controls.Clear()
        studentrecords.IconRightVisible = True
        updatedatabase.IconRightVisible = False


        Panel7.Controls.Add(head_student_records)
        Panel6.Controls.Add(student_records)
    End Sub

    Private Sub updatedatabase_Click(sender As Object, e As EventArgs) Handles updatedatabase.Click
        Panel7.Controls.Clear()
        Panel6.Controls.Clear()
        studentrecords.IconRightVisible = False
        updatedatabase.IconRightVisible = True


        Panel7.Controls.Add(head_insert_database)
        Panel6.Controls.Add(insert_database)
    End Sub

    Private Sub parentfeedback_Click(sender As Object, e As EventArgs)
        Panel7.Controls.Clear()
        Panel6.Controls.Clear()
        studentrecords.IconRightVisible = False
        updatedatabase.IconRightVisible = False

    End Sub

    Function student_records_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_insert_marks)
                Panel6.Controls.Add(insert_marks)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_insert_attend)
                Panel6.Controls.Add(insert_attend)

            Case 2
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_insert_strengths)
                Panel6.Controls.Add(insert_strengths)

        End Select
        Return 0
    End Function

    Function insert_database_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_insert_student_data)
                Panel6.Controls.Add(insert_student_data)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_insert_photo)
                Panel6.Controls.Add(insert_photo)


        End Select
        Return 0
    End Function

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
Public Class Teacher
    Dim btnclick As Boolean = False

    'basic result controls

    Dim enrollment_no As New enrollment_no
    Dim basic_info As New basic_info

    'marks controls

    Dim summary As New summary
    Dim marks As New marks
    Dim stand As New stand
    Dim sub_marks As New sub_marks

    'marks filters

    Dim marks_distance As New marks_distance
    Dim marks_sports As New marks_sports
    Dim marks_activity As New marks_activity

    'attendance controls

    Dim attendance As New attendance
    Dim attend_total As New attend_total
    Dim attend_monthly As New attend_monthly
    Dim attend_sub As New attend_sub
    Dim attend_sources As New attend_sources

    'attendance filters

    Dim attend_distance As New attend_distance
    Dim attend_sports As New attend_sports
    Dim attend_activity As New attend_activity

    'strength controls

    Dim strengths As New strengths
    Dim strength_achieve As New strength_achieve
    Dim strength_part As New strength_part

    'database control

    Dim database_page As New database_page

    'basic header controls

    Dim head_enroll As New Head_enroll
    Dim head_basic_info As New head_basic_info

    ' marks header controls

    Dim head_summary As New head_summary
    Dim head_stand As New head_stand
    Dim head_sub_marks As New head_sub_marks

    'marks filter header controls

    Dim head_marks_distance As New head_marks_distance
    Dim head_marks_sports As New head_marks_sports
    Dim head_marks_activity As New head_marks_activity

    'attendance header controls

    Dim head_total_attend As New head_total_attend
    Dim head_attend_monthly As New head_attend_monthly
    Dim head_attend_sub As New head_attend_sub
    Dim head_attend_sources As New head_attend_sources

    'attendance filter header controls

    Dim head_attend_distance As New head_attend_distance
    Dim head_attend_sports As New head_attend_sports
    Dim head_attend_activity As New head_attend_activity

    'strength header controls

    Dim head_strength_achieve As New head_strength_achieve
    Dim head_strength_part As New head_strength_part


    Private Sub x_Click(sender As Object, e As EventArgs) Handles x.Click
        Me.Hide()
        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()
    End Sub
    Private Sub teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel7.Controls.Add(head_enroll)
        Panel6.Controls.Add(enrollment_no)
        showresult.IconRightVisible = True
        btnclick = False
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub showresult_Click(sender As Object, e As EventArgs) Handles showresult.Click
        Panel7.Controls.Clear()
        Panel6.Controls.Clear()
        showresult.IconRightVisible = True
        update_db.IconRightVisible = False
        generate_report.IconRightVisible = False
        btnclick = False
        Panel7.Controls.Add(head_enroll)
        Panel6.Controls.Add(enrollment_no)

        enrollment_no.eno.SelectedItem = Nothing
        If (enroll = "") Then

        Else
            enroll = enroll.Remove(0, enroll.Length)
        End If

    End Sub

    Function enrollment_no_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0

                If (btnclick = True) Then

                    database_page.Show()

                Else
                    Panel7.Controls.Clear()
                    Panel6.Controls.Clear()
                    Panel7.Controls.Add(head_basic_info)
                    Panel6.Controls.Add(basic_info)

                End If

        End Select

        Return 0
    End Function

    Function basic_info_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 6
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_summary)
                Panel6.Controls.Add(summary)


            Case 7
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                enroll = enroll.Remove(0, 11)
                Panel7.Controls.Add(head_enroll)
                Panel6.Controls.Add(enrollment_no)

                enrollment_no.eno.SelectedItem = Nothing

        End Select

        Return 0
    End Function

    Function summary_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()

                Panel6.Controls.Add(marks)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_basic_info)
                Panel6.Controls.Add(basic_info)

        End Select

        Return 0
    End Function

    Function stand_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_sub_marks)
                Panel6.Controls.Add(sub_marks)

        End Select

        Return 0
    End Function

    Function sub_marks_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 6
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_marks_distance)
                Panel6.Controls.Add(marks_distance)

            Case 7
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()

                Panel6.Controls.Add(attendance)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_stand)
                Panel6.Controls.Add(stand)

        End Select

        Return 0
    End Function

    Function marks_distance_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_marks_sports)
                Panel6.Controls.Add(marks_sports)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_sub_marks)
                Panel6.Controls.Add(sub_marks)

        End Select

        Return 0
    End Function

    Function marks_sports_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_marks_activity)
                Panel6.Controls.Add(marks_activity)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_marks_distance)
                Panel6.Controls.Add(marks_distance)

        End Select

        Return 0
    End Function

    Function marks_activity_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()

                Panel6.Controls.Add(attendance)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_marks_sports)
                Panel6.Controls.Add(marks_sports)

        End Select

        Return 0
    End Function

    Function attend_total_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_monthly)
                Panel6.Controls.Add(attend_monthly)

        End Select

        Return 0
    End Function

    Function attend_monthly_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                'Panel7.Controls.Add(head_attend_sub)
                'Panel6.Controls.Add(attend_sub)
                Panel7.Controls.Add(head_attend_sources)
                Panel6.Controls.Add(attend_sources)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_total_attend)
                Panel6.Controls.Add(attend_total)

        End Select

        Return 0
    End Function

    Function attend_sub_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_sources)
                Panel6.Controls.Add(attend_sources)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_monthly)
                Panel6.Controls.Add(attend_monthly)

        End Select

        Return 0
    End Function

    Function attend_sources_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 6
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_distance)
                Panel6.Controls.Add(attend_distance)

            Case 7
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()

                Panel6.Controls.Add(strengths)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_sub)
                Panel6.Controls.Add(attend_sub)

        End Select

        Return 0
    End Function

    Function attend_distance_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_sports)
                Panel6.Controls.Add(attend_sports)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_sources)
                Panel6.Controls.Add(attend_sources)

        End Select

        Return 0
    End Function

    Function attend_sports_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_activity)
                Panel6.Controls.Add(attend_activity)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_distance)
                Panel6.Controls.Add(attend_distance)

        End Select

        Return 0
    End Function

    Function attend_activity_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()

                Panel6.Controls.Add(strengths)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_attend_sports)
                Panel6.Controls.Add(attend_sports)

        End Select

        Return 0
    End Function

    Function strength_part_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_strength_achieve)
                Panel6.Controls.Add(strength_achieve)

        End Select

        Return 0
    End Function

    Function strength_achieve_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_enroll)
                Panel6.Controls.Add(enrollment_no)

                enrollment_no.eno.SelectedItem = Nothing
                enroll = enroll.Remove(0, 11)

            Case 1
                Panel7.Controls.Clear()
                Panel6.Controls.Clear()
                Panel7.Controls.Add(head_strength_part)
                Panel6.Controls.Add(strength_part)

        End Select

        Return 0
    End Function

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        If (enroll = "") Then

        Else
            enroll = enroll.Remove(0, 11)
        End If

        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()
    End Sub

    Private Sub update_db_Click(sender As Object, e As EventArgs) Handles update_db.Click
        Panel7.Controls.Clear()
        Panel6.Controls.Clear()
        showresult.IconRightVisible = False
        update_db.IconRightVisible = True
        generate_report.IconRightVisible = False
        Panel7.Controls.Add(head_enroll)
        Panel6.Controls.Add(enrollment_no)

        enrollment_no.eno.SelectedItem = Nothing
        If (enroll = "") Then

        Else
            enroll = enroll.Remove(0, 11)
        End If

        btnclick = True
    End Sub
    
    Private Sub generate_report_Click(sender As Object, e As EventArgs) Handles generate_report.Click
        generate_report.IconRightVisible = True
        showresult.IconRightVisible = False
        update_db.IconRightVisible = False
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class attend_distance
    Private Sub attend_distance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select Final_Attend,Total_Attend From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim ward_attend As Decimal = ((rd("Final_Attend") / rd("Total_Attend")) * 100)
        rd.Close()

        cmd.CommandText = "Select Pin_Address From stu_personal_data where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim pin_low = rd("Pin_Address") - 30
        Dim pin_high = rd("Pin_Address") + 30
        rd.Close()

        cmd.CommandText = "select count(Final_Attend)as max from sem" & smstr & "_attendance where Enrollment_No in(select Enrollment_No from Stu_personal_data where Enrollment_No not like '" & enroll & "' and Pin_Address between " & pin_low & " and " & pin_high & ");"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim i As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select Final_Attend as final,Total_Attend as total from sem" & smstr & "_attendance where Enrollment_No in(select Enrollment_No from Stu_personal_data where Enrollment_No not like '" & enroll & "' and Pin_Address between " & pin_low & " and " & pin_high & ");"
        rd = cmd.ExecuteReader

        Dim attend(i) As String
        Dim others_attend(i) As Decimal

        If rd.HasRows Then

            others_attend(0) = ward_attend
            attend(0) = "Ward"

            For j As Integer = 1 To i

                rd.Read()
                others_attend(j) = (rd("final") / rd("total")) * 100
                attend(j) = "Classmate"

            Next

        End If
        rd.Close()

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Red", "Green"}

            thisPoint = Chart1.Series("Classmates").Points.Add(others_attend(0))
            thisPoint.Color = Color.FromName(colorname(0))

            For p As Integer = 1 To i

                thisPoint = Chart1.Series("Classmates").Points.Add(others_attend(p))
                thisPoint.Color = Color.FromName(colorname(1))

            Next

        Catch ex As Exception

            MsgBox("Connection Problem, Please try later!")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.attend_distance_clicks(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c_sports As Integer = 0
        Dim c_act As Integer = 0
        Dim c_achieve As Integer = 0
        Dim c_part As Integer = 0
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Sports_Attend as sports,Activity_Attend as act from sem" & smstr & "_attend_sources where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        c_act = rd("act")
        c_sports = rd("sports")
        rd.Close()
        cmd.CommandText = "select count(Achievement_Name) as achieve from sem" & smstr & "_stu_achieve where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        c_achieve = rd("achieve")
        rd.Close()

        cmd.CommandText = "select count(Participation_Name) as part from sem" & smstr & "_stu_participate where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        c_part = rd("part")
        con.Close()

        If (c_sports = 0 And c_act = 0) Then
            Teacher.attend_activity_clicks(0)
        ElseIf (c_sports = 0 And c_act > 0) Then
            Teacher.attend_sports_clicks(0)
        ElseIf ((c_act = 0 And c_sports > 0) Or (c_act > 0 And c_sports > 0)) Then
            Teacher.attend_distance_clicks(0)
        End If

    End Sub
    Function strength_check() As Integer
        
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        rd = cmd.ExecuteReader
        rd.Read()
        
        con.Close()
        Return 0
    End Function
End Class

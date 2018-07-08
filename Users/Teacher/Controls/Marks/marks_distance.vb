Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class marks_distance

    Private Sub marks_distance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select Total_Marks_Scored From sem" & smstr & "_marks where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim ward_marks As Integer = rd("Total_Marks_Scored")
        rd.Close()

        cmd.CommandText = "Select Pin_Address From stu_personal_data where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim pin_low = rd("Pin_Address") - 30
        Dim pin_high = rd("Pin_Address") + 30
        rd.Close()

        cmd.CommandText = "select count(Total_Marks_Scored)as max from sem" & smstr & "_marks where Enrollment_No in(select Enrollment_No from Stu_personal_data where Enrollment_No not like '" & enroll & "' and Pin_Address between " & pin_low & " and " & pin_high & ");"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim i As Integer = rd("max")
        rd.Close()
        
        cmd.CommandText = "select Total_Marks_Scored as others from sem" & smstr & "_marks where Enrollment_No in(select Enrollment_No from Stu_personal_data where Enrollment_No not like '" & enroll & "' and Pin_Address between " & pin_low & " and " & pin_high & ");"
        rd = cmd.ExecuteReader

        Dim score(i) As String
        Dim others_marks(i) As Integer
        If rd.HasRows Then

            others_marks(0) = ward_marks
            score(0) = "Ward"

            For j As Integer = 1 To i
                rd.Read()
                others_marks(j) = rd("others")
                score(j) = "Classmate"

            Next

        End If

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Marks"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Red", "Green"}

            thisPoint = Chart1.Series("Classmates").Points.Add(others_marks(0))

            thisPoint.Color = Color.FromName(colorname(0))
            For p As Integer = 1 To i

                thisPoint = Chart1.Series("Classmates").Points.Add(others_marks(p))

                thisPoint.Color = Color.FromName(colorname(1))

            Next


        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.marks_distance_clicks(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As Integer = 0
        Dim c As Integer = 0
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Sports_Attend as sports,Activity_Attend as act from sem" & smstr & "_attend_sources where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        c = rd("act")
        check = rd("sports")
        rd.Close()

        If (check = 0 And c = 0) Then
            Teacher.marks_activity_clicks(0)
        ElseIf (check = 0 And c > 0) Then
            Teacher.marks_sports_clicks(0)
        ElseIf ((c = 0 And check > 0) Or (c > 0 And check > 0)) Then
            Teacher.marks_distance_clicks(0)
        End If

    End Sub

End Class

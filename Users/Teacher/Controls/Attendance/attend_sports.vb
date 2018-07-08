Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class attend_sports

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c_act As Integer = 0
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Activity_Attend as act from sem" & smstr & "_attend_sources where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        c_act = rd("act")
        rd.Close()

        If (c_act = 0) Then
            Teacher.attend_activity_clicks(0)
        Else
            Teacher.attend_sports_clicks(0)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.attend_sports_clicks(1)
    End Sub

    Private Sub attend_sports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        cmd.CommandText = "select count(Final_attend)as max from sem" & smstr & "_attendance where Enrollment_No in(select enrollment_no from sem" & smstr & "_attend_sources where enrollment_no not like '" & enroll & "' and Sports_Attend>0);"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim i As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select Final_Attend as final,Total_Attend as total from sem" & smstr & "_attendance where enrollment_no in(select enrollment_no from sem" & smstr & "_attend_sources where enrollment_no not like '" & enroll & "' and Sports_Attend>0);"
        rd = cmd.ExecuteReader

        Dim attend(i) As String
        Dim others_attend(i) As Integer

        If rd.HasRows Then

            others_attend(0) = ward_attend
            attend(0) = "Ward"

            For j As Integer = 1 To i

                rd.Read()
                others_attend(j) = (rd("final") / rd("total")) * 100
                attend(j) = "Classmates"

            Next

        End If

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Red", "Green"}
            thisPoint = Chart1.Series("Attendance").Points.Add(others_attend(0))

            thisPoint.Color = Color.FromName(colorname(0))
            For p As Integer = 1 To i

                thisPoint = Chart1.Series("Attendance").Points.Add(others_attend(p))

                thisPoint.Color = Color.FromName(colorname(1))

            Next


        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub
End Class

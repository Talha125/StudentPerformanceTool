Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting.DataPoint

Public Class attend_total

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.attend_total_clicks(0)
    End Sub

    Private Sub attend_total_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim temp As Integer
        Dim score() As String = {"Attend"}
        Dim attend(5) As Double
        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select max(Total_Attend) as Total from sem" & smstr & "_attendance;"
        rd = cmd.ExecuteReader
        rd.Read()
        temp = rd("Total")
        rd.Close()

        cmd.CommandText = "Select max(Final_Attend) as Highest From sem" & smstr & "_attendance;"
        rd = cmd.ExecuteReader
        rd.Read()
        attend(0) = (rd("Highest") / temp) * 100
        rd.Close()

        cmd.CommandText = "Select count(Final_Attend) as countabove,avg(Final_Attend) as Above From sem" & smstr & "_attendance where Final_Attend>=(Select Final_Attend From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "');"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count_above As Integer = rd("countabove")
        attend(1) = (rd("Above") / temp) * 100
        rd.Close()

        cmd.CommandText = "Select Final_Attend as ward From sem" & smstr & "_attendance where Enrollment_No=" & enroll & ";"
        rd = cmd.ExecuteReader
        rd.Read()
        attend(2) = (rd("ward") / temp) * 100
        rd.Close()

        cmd.CommandText = "Select count(Final_Attend) as countbelow,avg(Final_Attend) as Below From sem" & smstr & "_attendance where Final_Attend<(Select Final_Attend From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "');"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count_below As Integer = rd("countbelow")
        attend(3) = (rd("Below") / temp) * 100
        rd.Close()

        cmd.CommandText = "Select min(Final_Attend) as Lowest From sem" & smstr & "_attendance;"
        rd = cmd.ExecuteReader
        rd.Read()
        attend(4) = (rd("Lowest") / temp) * 100

        Try
            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Blue", "Green", "Red", "Green", "Blue"}
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100
           
            For p As Integer = 0 To 4

                thisPoint = Chart1.Series("Attendance").Points.Add(attend(p))

                thisPoint.Color = Color.FromName(colorname(p))


            Next

        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class attend_monthly
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.attend_monthly_clicks(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.attend_monthly_clicks(1)
    End Sub

    Private Sub attend_monthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim month() As String = {"Month1", "Month2", "Month3", "Month4"}


        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select Month1_Attend,Month1_Total,Month2_Attend,Month2_Total,Month3_Attend,Month3_Total,Month4_Attend,Month4_Total From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim monthly_attend() As Decimal = {((rd("Month1_Attend") / rd("Month1_Total")) * 100), ((rd("Month2_Attend") / rd("Month2_Total")) * 100), ((rd("Month3_Attend") / rd("Month3_Total")) * 100), ((rd("Month4_Attend") / rd("Month4_Total")) * 100)}

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Months"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100
            Chart1.Series("Your Ward").Points.DataBindXY(month, monthly_attend)


        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub
End Class

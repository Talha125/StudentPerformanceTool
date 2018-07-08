Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Math


Public Class attend_sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.attend_sub_clicks(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.attend_sub_clicks(1)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub attend_sub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sub_name() As String = {"Maths", "TC", "C", "ICIT", "Physics"}
        Dim temp(5) As Integer


        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select Maths_Attend,Maths_Total,TC_Attend,TC_Total,C_Attend,C_Total,ICIT_Attend,ICIT_Total,Physics_Attend,Physics_Total From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim sub_attend() As Decimal = {((rd("Maths_Attend") / rd("Maths_Total")) * 100), ((rd("TC_Attend") / rd("TC_Total")) * 100), ((rd("C_Attend") / rd("C_Total")) * 100), ((rd("ICIT_Attend") / rd("ICIT_Total")) * 100), ((rd("Physics_Attend") / rd("Physics_Total")) * 100)}
        For i As Integer = 0 To sub_attend.Length - 1
            sub_attend(i) = Round(sub_attend(i), 1)
        Next


        temp(0) = rd("Maths_Total")
        temp(1) = rd("TC_Total")
        temp(2) = rd("C_Total")
        temp(3) = rd("ICIT_Total")
        temp(4) = rd("Physics_Total")
        rd.Close()

        cmd.CommandText = "Select max(Maths_Attend) as Maths,max(TC_Attend) as TC,max(C_Attend) as C,max(ICIT_Attend) as ICIT,max(Physics_Attend) as Physics From sem" & smstr & "_attendance;"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim highest() As Double = {((rd("Maths") / temp(0)) * 100), ((rd("TC") / temp(1)) * 100), ((rd("C") / temp(2)) * 100), ((rd("ICIT") / temp(3)) * 100), ((rd("Physics") / temp(5)) * 100)}
        For i As Integer = 0 To sub_attend.Length - 1
            highest(i) = Round(highest(i), 1)
        Next
        rd.Close()

        cmd.CommandText = "Select min(Maths_Attend) as Maths,min(TC_Attend) as TC,min(C_Attend) as C,min(ICIT_Attend) as ICIT,min(Physics_Attend) as Physics From sem" & smstr & "_attendance;"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim lowest() As Double = {((rd("Maths") / temp(0)) * 100), ((rd("TC") / temp(1)) * 100), ((rd("C") / temp(2)) * 100), ((rd("ICIT") / temp(3)) * 100), ((rd("Physics") / temp(5)) * 100)}
        For i As Integer = 0 To sub_attend.Length - 1
            lowest(i) = Round(lowest(i), 1)
        Next
        
        Try

            Chart1.ChartAreas(0).AxisX.Title = "Subjects"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Chart1.Series("Subject").Points.DataBindXY(sub_name, sub_attend)
            Chart1.Series("Highest").Points.DataBindXY(sub_name, highest)
            Chart1.Series("Lowest").Points.DataBindXY(sub_name, lowest)

        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub
End Class

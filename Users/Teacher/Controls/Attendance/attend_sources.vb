Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class attend_sources
    Dim a As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.attend_sources_clicks(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (a = 0) Then
            a = MsgBox(Prompt:="Do you want to apply some filters on your ward's performance ?", Buttons:=vbYesNoCancel, Title:="Confirmation")
            Teacher.attend_sources_clicks(a)
        Else
            Teacher.attend_sources_clicks(a)
        End If
    End Sub

    Private Sub attend_sources_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim source_name() As String = {"Presentation", "Visit", "Guest Lecture", "Seminar", "Sports", "Activity"}


        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select Ppt_Attend,Ppt_Total,Visit_Attend,Visit_Total,Guest_Attend,Guest_Total,Seminar_Attend,Seminar_Total,Sports_Attend,Sports_Total,Activity_Attend,Activity_Total From sem" & smstr & "_attend_sources where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim sources() As Double = {((rd("Ppt_Attend") / rd("Ppt_Total")) * 100), ((rd("Visit_Attend") / rd("Visit_Total")) * 100), ((rd("Guest_Attend") / rd("Guest_Total")) * 100), ((rd("Seminar_Attend") / rd("Seminar_Total")) * 100), ((rd("Sports_Attend") / rd("Sports_Total")) * 100), ((rd("Activity_Attend") / rd("Activity_Total")) * 100)}
        rd.Close()

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Sources"
            Chart1.ChartAreas(0).AxisY.Title = "Attendance"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Chart1.Series("Sources").Points.DataBindXY(source_name, sources)

        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try
    End Sub
End Class

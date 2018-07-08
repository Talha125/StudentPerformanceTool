Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting.DataPoint

Public Class stand

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.stand_clicks(0)
    End Sub

    Private Sub stand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim performance(5) As Double
        Dim stand() As String = {"Highest", "Above", "Your Ward", "Below", "Lowest"}

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "Select max(Total_Marks_Scored) as Highest From sem" & smstr & "_marks;"
        rd = cmd.ExecuteReader
        rd.Read()
        performance(0) = rd("Highest")
        rd.Close()

        cmd.CommandText = "Select count(Total_Marks_Scored) as countabove,avg(Total_Marks_Scored) as Above From sem" & smstr & "_marks where Total_Marks_Scored>=(Select Total_Marks_Scored From sem" & smstr & "_marks where Enrollment_No='" & enroll & "');"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count_above As Integer = rd("countabove")
        performance(1) = rd("Above")
        rd.Close()

        cmd.CommandText = "Select Total_Marks_Scored From sem" & smstr & "_marks where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        performance(2) = rd("Total_Marks_Scored")
        rd.Close()

        cmd.CommandText = "Select count(Total_Marks_Scored) as countbelow,avg(Total_Marks_Scored) as Below From sem" & smstr & "_marks where Total_Marks_Scored<(Select Total_Marks_Scored From sem" & smstr & "_marks where Enrollment_No='" & enroll & "');"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count_below As Integer = rd("countbelow")
        If (IsDBNull(rd("Below"))) Then
            performance(3) = 0
        Else
            performance(3) = rd("Below")
        End If

        rd.Close()

        cmd.CommandText = "Select min(Total_Marks_Scored) as Lowest From sem" & smstr & "_marks;"
        rd = cmd.ExecuteReader
        rd.Read()
        performance(4) = rd("Lowest")
        Try
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Marks"
            Chart1.ChartAreas(0).AxisY.Maximum = 100
            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Blue", "Green", "Red", "Green", "Blue"}
            For p As Integer = 0 To 4

                thisPoint = Chart1.Series("Performance").Points.Add(performance(p))

                thisPoint.Color = Color.FromName(colorname(p))

            Next

        Catch ex As Exception
            MsgBox("Connection Problem. Please Try Later!")
        End Try

    End Sub

End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class marks_sports

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As Integer = 0
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select Activity_Attend as act from sem" & smstr & "_attend_sources where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        check = rd("act")
        rd.Close()

        If (check = 0) Then
            Teacher.marks_activity_clicks(0)
        Else
            Teacher.marks_sports_clicks(0)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.marks_sports_clicks(1)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub marks_sports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        
        cmd.CommandText = "select count(Total_Marks_Scored)as max from sem" & smstr & "_marks where Enrollment_No in(select enrollment_no from sem" & smstr & "_attend_sources where enrollment_no not like '" & enroll & "' and sports_Attend>0);"
        rd = cmd.ExecuteReader
        rd.Read()

        Dim i As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select Total_Marks_Scored as others from sem" & smstr & "_marks where enrollment_no in(select enrollment_no from sem" & smstr & "_attend_sources where enrollment_no not like '" & enroll & "' and sports_Attend>0);"
        rd = cmd.ExecuteReader

        Dim score(i) As String
        Dim others_marks(i) As Integer

        If rd.HasRows Then

            others_marks(0) = ward_marks
            score(0) = "Ward"

            For j As Integer = 1 To i

                rd.Read()
                others_marks(j) = rd("others")
                score(j) = "Classmates"

            Next

        End If

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Students"
            Chart1.ChartAreas(0).AxisY.Title = "Marks"
            Chart1.ChartAreas(0).AxisY.Maximum = 100

            Dim thisPoint As DataVisualization.Charting.DataPoint
            Dim colorname() As String = {"Red", "Green"}
            thisPoint = Chart1.Series("Marks").Points.Add(others_marks(0))

            thisPoint.Color = Color.FromName(colorname(0))
            For p As Integer = 1 To i

                thisPoint = Chart1.Series("Marks").Points.Add(others_marks(p))

                thisPoint.Color = Color.FromName(colorname(1))

            Next


        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try


        
    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class sub_marks

    Dim a As Integer
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (a = 0) Then
            a = MsgBox(Prompt:="Do you want to apply some filters on your ward's performance ?", Buttons:=vbYesNoCancel, Title:="Confirmation")
            Teacher.sub_marks_clicks(a)
        Else
            Teacher.sub_marks_clicks(a)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.sub_marks_clicks(1)
    End Sub

    Private Sub sub_marks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim sub_name() As String = {"Maths", "TC", "C", "ICIT", "Physics"}


        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select Maths_Marks,TC_Marks,C_Marks,ICIT_Marks,Physics_Marks From sem" & smstr & "_marks where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim sub_marks() As Integer = {rd("Maths_Marks"), rd("TC_Marks"), rd("C_Marks"), rd("ICIT_Marks"), rd("Physics_Marks")}
        rd.Close()
        cmd.CommandText = "select max(Maths_Marks) as Maths,max(TC_Marks) as TC,max(C_Marks) as C,max(ICIT_Marks) as ICIT,max(Physics_Marks) as Physics from sem" & smstr & "_marks;"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim high_marks() As Integer = {rd("Maths"), rd("TC"), rd("C"), rd("ICIT"), rd("Physics")}
        rd.Close()
        cmd.CommandText = "select min(Maths_Marks) as Maths,min(TC_Marks) as TC,min(C_Marks) as C,min(ICIT_Marks) as ICIT,min(Physics_Marks) as Physics from sem" & smstr & "_marks;"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim low_marks() As Integer = {rd("Maths"), rd("TC"), rd("C"), rd("ICIT"), rd("Physics")}

        Try
            Chart1.ChartAreas(0).AxisX.Title = "Subjects"
            Chart1.ChartAreas(0).AxisY.Title = "Marks"

            
            Chart1.Series("Subject").Points.DataBindXY(sub_name, sub_marks)
            Chart1.Series("Highest").Points.DataBindXY(sub_name, high_marks)
            Chart1.Series("Lowest").Points.DataBindXY(sub_name, low_marks)

        Catch ex As Exception
            MsgBox("Connection Problem, Please try later!")
        End Try



    End Sub
End Class

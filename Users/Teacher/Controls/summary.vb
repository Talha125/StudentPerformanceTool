Imports System.Data.SqlClient
Imports System.Math

Public Class summary

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.summary_clicks(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.summary_clicks(1)
    End Sub

    Private Sub summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim marks As Decimal
        Dim attend As Decimal

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select Total_Marks_Scored,Total_Marks From sem" & smstr & "_marks where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        marks = (rd("Total_Marks_Scored") / rd("Total_Marks")) * 100
        marks = Round(marks, 2)
        Try

            Label9.Text = marks

        Catch ex As Exception
            MsgBox("Try again later!!!")
        End Try

        rd.Close()
        cmd.CommandText = "Select Final_Attend,Total_Attend From sem" & smstr & "_attendance where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        attend = (rd("Final_Attend") / rd("Total_Attend")) * 100
        attend = Round(attend, 2)
        Try

            Label10.Text = attend

        Catch ex As Exception
            MsgBox("Try again later!!!")
        End Try

        rd.Close()
        cmd.CommandText = "Select count(Achievement_Name) as Achieve From sem" & smstr & "_stu_achieve where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        If (rd("Achieve") >= 1) Then
            Try

                Label12.Text = rd("Achieve")

            Catch ex As Exception
                MsgBox("Try again later!!!")
            End Try
        Else
            Label8.Visible = False
            Label12.Visible = False
        End If

        rd.Close()
        cmd.CommandText = "Select count(Participation_Name) as Part From sem" & smstr & "_stu_participate where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        If (rd("Part") >= 1) Then
            Try

                Label11.Text = rd("Part")

            Catch ex As Exception
                MsgBox("Try again later!!!")
            End Try
        Else
            Label7.Visible = False
            Label11.Visible = False
        End If
    End Sub

End Class

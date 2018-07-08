﻿Imports System.Data.SqlClient

Public Class strength_part

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c_achieve As Integer = 0
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select count(Achievement_Name) as max from sem" & smstr & "_stu_achieve where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        c_achieve = rd("max")
        con.Close()

        If (c_achieve = 0) Then
            Teacher.strength_achieve_clicks(0)
        Else
            Teacher.strength_part_clicks(0)
        End If
    End Sub

    Private Sub strength_part_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select count(Participation_Name) as max from sem" & smstr & "_stu_participate where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Dim count As Integer = rd("max")
        rd.Close()

        cmd.CommandText = "select Participation_Name as strength from sem" & smstr & "_stu_participate where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader

        If rd.HasRows = True Then
            Dim y As Integer = 0
            For i As Integer = 1 To count
                rd.Read()
                Dim lb As New Label
                lb.Name = "Label" + i.ToString
                lb.Text = ("* " + rd("strength"))
                lb.AutoSize = True
                lb.ForeColor = Color.White
                lb.Font = New Font("times new roman", 18, FontStyle.Bold)
                lb.Location = New Point(30, 33 + y)
                Me.Controls.Add(lb)
                y = y + 25
            Next
        End If
    End Sub
End Class

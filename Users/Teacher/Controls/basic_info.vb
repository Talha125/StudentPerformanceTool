Imports System.Data.SqlClient
Imports System.IO

Public Class basic_info

    Private Sub basic_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim img() As Byte
        Dim img1() As Byte
        Dim img2() As Byte

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select Father_Name,Student_Name,Mother_Name From stu_personal_data where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        Try
            Label11.Text = rd("Father_Name").ToString
            Label12.Text = rd("Mother_Name").ToString
            Label9.Text = rd("Student_Name").ToString
            Label10.Text = enroll

        Catch ex As Exception
            MsgBox("Try again later!!!")
        End Try

        rd.Close()

        cmd.CommandText = "Select Student_Photo,Father_Photo,Mother_Photo From photo where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()

        Try
            img = rd("Student_Photo")
            img1 = rd("Father_Photo")
            img2 = rd("Mother_Photo")

            Dim ms As New MemoryStream(img)
            Dim ms1 As New MemoryStream(img1)
            Dim ms2 As New MemoryStream(img2)

            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox4.Image = Image.FromStream(ms)
            PictureBox5.Image = Image.FromStream(ms1)
            PictureBox6.Image = Image.FromStream(ms2)
        Catch ex As Exception
            MsgBox("Try again later!!!")
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a = MsgBox(Prompt:="Are You Sure This Is The Indicated Student ?", Buttons:=vbYesNoCancel, Title:="Confirmation")
        Teacher.basic_info_clicks(a)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Teacher.basic_info_clicks(7)
    End Sub
End Class

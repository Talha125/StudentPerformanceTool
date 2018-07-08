Imports System.Data.SqlClient
Imports System.IO

Public Class database_page


    Private Sub database_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        Dim img() As Byte

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()

        cmd.CommandText = "select student_photo from photo where enrollment_no='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        img = rd("student_photo")
        Dim ms As New MemoryStream(img)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.Image = Image.FromStream(ms)
        rd.Close()

        cmd.CommandText = "Select * From stu_personal_data where Enrollment_No='" & enroll & "';"
        rd = cmd.ExecuteReader
        rd.Read()
        Try
            TextBox1.Text = rd("Enrollment_No")
            TextBox2.Text = rd("Student_Name")
            TextBox3.Text = rd("Father_Name")
            TextBox4.Text = rd("Mother_Name")
            TextBox5.Text = rd("Email_ID")
            TextBox6.Text = rd("Student_Phone")
            TextBox7.Text = rd("Father_Phone")
            TextBox8.Text = rd("Street_Address")
            TextBox9.Text = rd("State_Address")
            TextBox10.Text = rd("Pin_Address")
            TextBox11.Text = rd("DOB")
            TextBox12.Text = rd("Gender")
            TextBox13.Text = rd("Caste")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            Button3_Click(Button3, New EventArgs)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
        TextBox7.ReadOnly = False
        TextBox8.ReadOnly = False
        TextBox9.ReadOnly = False
        TextBox10.ReadOnly = False
        TextBox11.ReadOnly = False
        TextBox12.ReadOnly = False
        TextBox13.ReadOnly = False

        TextBox2.ForeColor = Color.Black
        TextBox3.ForeColor = Color.Black
        TextBox4.ForeColor = Color.Black
        TextBox5.ForeColor = Color.Black
        TextBox6.ForeColor = Color.Black
        TextBox7.ForeColor = Color.Black
        TextBox8.ForeColor = Color.Black
        TextBox9.ForeColor = Color.Black
        TextBox10.ForeColor = Color.Black
        TextBox11.ForeColor = Color.Black
        TextBox12.ForeColor = Color.Black
        TextBox13.ForeColor = Color.Black

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim a As Integer = MsgBox(Prompt:="Your all Unsaved Updations will be lost. Are You Sure ?", Buttons:=vbYesNoCancel, Title:="Confirmation")

        If (a = 6) Then
            Me.Hide()
            Teacher.Show()
            enroll = enroll.Remove(0, 11)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=" & db & "; Integrated Security=True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "update stu_personal_data set Student_Name='" & TextBox2.Text & "',Father_Name='" & TextBox3.Text & "',Mother_Name='" & TextBox4.Text & "',Email_ID='" & TextBox5.Text & "',Student_Phone=" & TextBox6.Text & ",Father_Phone=" & TextBox7.Text & ",Street_Address='" & TextBox8.Text & "',State_Address='" & TextBox9.Text & "',Pin_Address='" & TextBox10.Text & "',DOB='" & TextBox11.Text & "',Gender='" & TextBox12.Text & "',Caste='" & TextBox13.Text & "'  where Enrollment_No='" & enroll & "';"
        cmd.ExecuteNonQuery()
        MsgBox("Database Updated!!")

        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
        TextBox11.ReadOnly = True
        TextBox12.ReadOnly = True
        TextBox13.ReadOnly = True

        TextBox2.ForeColor = Color.Gray
        TextBox3.ForeColor = Color.Gray
        TextBox4.ForeColor = Color.Gray
        TextBox5.ForeColor = Color.Gray
        TextBox6.ForeColor = Color.Gray
        TextBox7.ForeColor = Color.Gray
        TextBox8.ForeColor = Color.Gray
        TextBox9.ForeColor = Color.Gray
        TextBox10.ForeColor = Color.Gray
        TextBox11.ForeColor = Color.Gray
        TextBox12.ForeColor = Color.Gray
        TextBox13.ForeColor = Color.Gray

    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()
        Teacher.Show()
        enroll = enroll.Remove(0, 11)
    End Sub

End Class
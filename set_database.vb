Imports System.Data.SqlClient

Public Class set_database

    Private Sub set_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ds = TextBox2.Text
            My.Computer.FileSystem.WriteAllText("datasource.txt", ds, False)
            PictureBox1_Click(PictureBox1, New EventArgs)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Label3.Visible = True
        TextBox2.Visible = True
        TextBox2.ReadOnly = False
        Try
            If (ds = "") Then

            Else
                con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=master; Integrated Security=True"
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "Create Database SPMS;"

                Dim check As Integer = cmd.ExecuteNonQuery()

                con.Close()

                con.ConnectionString = "Data Source=" & ds & "; Initial Catalog=SPMS; Integrated Security=True"
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "Create Table users(username varchar(20) not null primary key,password varchar(20) not null,type varchar(20) not null);"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('admin','admin','Admin');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant','assistant','Assistant');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher','teacher','Teacher');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bca_m','assistant_bca_m','assistant_bca_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bca_e','assistant_bca_e','assistant_bca_e');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bba_m','assistant_bba_m','assistant_bba_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bba_e','assistant_bba_e','assistant_bba_e');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bjmc_m','assistant_bjmc_m','assistant_bjmc_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('assistant_bjmc_e','assistant_bjmc_e','assistant_bjmc_e');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bca_m','teacher_bca_m','teacher_bca_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bca_e','teacher_bca_e','teacher_bca_e');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bba_m','teacher_bba_m','teacher_bba_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bba_e','teacher_bba_e','teacher_bba_e');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bjmc_m','teacher_bjmc_m','teacher_bjmc_m');"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into users values('teacher_bjmc_e','teacher_bjmc_e','teacher_bjmc_e');"
                cmd.ExecuteNonQuery()
                MsgBox("Database Successfully Created!")
                Welcome.Show()

            End If
            
        Catch ex As Exception
            MsgBox("Data Source not found")
        End Try


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Database Selected!")
        Welcome.Show()
    End Sub

    
End Class
Imports System.Data.SqlClient

Public Module global_variables
    Public usertype As String
    Public userid As String
    Public enroll As String = ""
    Public ds As String = ""
    Public db As String = ""
    Public smstr As String = ""
End Module

Public Class First_Page

    Private Sub First_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader
        Try

            con.ConnectionString = "Data Source=" & My.Computer.FileSystem.ReadAllText("datasource.txt") & "; Integrated Security=True"
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "SELECT count([name]) as max FROM master.dbo.sysdatabases where [name] ='SPMS';"
            rd = cmd.ExecuteReader
            rd.Read()
            If (rd("max") = 1) Then
                ds = My.Computer.FileSystem.ReadAllText("datasource.txt")
                Me.Hide()
                Welcome.Show()
            Else

                Me.Hide()
                set_database.Show()
            End If
        Catch ex As Exception
            Me.Hide()
            set_database.Show()
        End Try
        
    End Sub
End Class
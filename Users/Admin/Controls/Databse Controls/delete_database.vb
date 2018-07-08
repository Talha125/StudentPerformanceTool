Imports System.Data.SqlClient
Public Class delete_database

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim msg As New mbox
        Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=master; Integrated Security=True;")
        Dim myCommand As String
        Dim dbname As String
        Dim check As Integer
        dbname = database_select.SelectedItem
        myCommand = "DROP database " & dbname & ";"
        Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
        Try
            cmd.Connection.Open()
            check = cmd.ExecuteNonQuery()
            If (check) Then
                msg.mes("Database Sucessfully Deleted.")
                database_select.DataSource = GetDatabaseNames()
            End If
            cmd.Connection.Close()
        Catch
            msg.mes(" Database Doesn't Exist")
        End Try
    End Sub

    Public Shared Function GetDatabaseNames() As List(Of String)
        Dim connString As String
        Dim databaseNames As New List(Of String)

        connString = "Data Source=" & ds & ";Integrated Security=True"

        If Not String.IsNullOrWhiteSpace(connString) Then
            Using cn As SqlConnection = New SqlConnection(connString)

                cn.Open()

                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_databases"

                    Using myReader As SqlDataReader = cmd.ExecuteReader()
                        While (myReader.Read())
                            databaseNames.Add(myReader.GetString(0))
                        End While
                    End Using
                End Using
            End Using
        End If

        Return databaseNames
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        database_select.DataSource = GetDatabaseNames()
    End Sub

End Class

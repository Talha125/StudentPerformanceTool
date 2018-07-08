Imports System.Data.SqlClient

Public Class delete_table
    Dim msg As New mbox
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
        Dim myCommand As String
        Dim tablename As String
        Dim check As Integer
        tablename = table_name.SelectedItem
        myCommand = "DROP TABLE " & tablename
        Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
        Try
            cmd.Connection.Open()
            check = cmd.ExecuteNonQuery()
            If (check) Then
                msg.mes("Table Sucessfully Deleted.")
                table_names()
            End If
            cmd.Connection.Close()
        Catch
            msg.mes("Table Doesn't Exist")
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

    Private Sub database_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles database_select.SelectedIndexChanged
        table_names()
    End Sub

    Public Sub table_names()
        Dim sqlConn As New SqlClient.SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
        sqlConn.Open()
        Dim cmd As New SqlClient.SqlCommand("Select * From sys.objects Where type = 'U'  order by name", sqlConn)
        Dim dsColumns As New DataSet
        Dim daAdapter As New SqlClient.SqlDataAdapter(cmd)
        daAdapter.Fill(dsColumns)
        If dsColumns.Tables(0).Rows.Count > 0 Then
            table_name.Enabled = True
            table_name.Items.Clear()
            For i As Integer = 0 To dsColumns.Tables(0).Rows.Count - 1
                table_name.Items.Add(dsColumns.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            table_name.Enabled = False
        End If
    End Sub

    Private Sub table_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles table_name.SelectedIndexChanged

    End Sub
End Class

Imports System.Data.SqlClient
Imports System.Text

Public Class delete_fkey
    Dim msg As New mbox

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
        table_name.SelectedIndex = -1



    End Sub

    Private Sub database_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles database_select.SelectedIndexChanged
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

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (database_select.SelectedIndex = -1 Or table_name.SelectedIndex = -1) Then
            msg.mes("Please Fill All The Fields.")
        Else
            Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
            Dim msg As New mbox
            Dim myCommand As String
            myCommand = "ALTER TABLE " + table_name.SelectedItem + " DROP CONSTRAINT FK_" + table_name.SelectedItem
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                msg.mes("Foreign Key Sucessfully Deleted.")
                cmd.Connection.Close()
            Catch
                msg.mes("Error.")
            End Try
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        table_name.Items.Clear()
        database_select.SelectedIndex = -1
        table_name.SelectedIndex = -1
    End Sub
End Class

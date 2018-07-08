Imports System.Data.SqlClient

Public Class modify_foreign_key
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
        table_name_1.SelectedIndex = -1



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
            table_name_1.Enabled = True
            table_name.Items.Clear()
            table_name_1.Items.Clear()
            column_I.Items.Clear()
            column_II.Items.Clear()
            For i As Integer = 0 To dsColumns.Tables(0).Rows.Count - 1
                table_name.Items.Add(dsColumns.Tables(0).Rows(i)(0).ToString())
                table_name_1.Items.Add(dsColumns.Tables(0).Rows(i)(0).ToString())
            Next
        Else
            table_name.Enabled = False
            table_name_1.Enabled = False
            column_I.Enabled = False
            column_II.Enabled = False
        End If
    End Sub

    Private Sub table_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles table_name.SelectedIndexChanged
        If (table_name_1.SelectedItem = table_name.SelectedItem) Then
            table_name.SelectedIndex = -1
            column_I.Enabled = False
            msg.mes("Tables Cannot Be Same.")
        Else
            column_I.Items.Clear()
            column_I.Enabled = True
            columns_names(table_name.SelectedItem, "table_name")
            
        End If
    End Sub

    Private Sub table_name_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles table_name_1.SelectedIndexChanged
        If (table_name_1.SelectedItem = table_name.SelectedItem) Then
            table_name_1.SelectedIndex = -1
            column_II.Enabled = False
            msg.mes("Tables Cannot Be Same.")
        Else
            column_II.Items.Clear()
            column_II.Enabled = True
            columns_names(table_name_1.SelectedItem, "table_name_1")
        End If
    End Sub

    Public Sub columns_names(ByVal TableName As String, ByVal col As String)
        Dim dsColumnName As New DataSet
        Dim Con As New SqlClient.SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
        Con.Open()
        Dim strSql As String = "SELECT column_name FROM INFORMATION_SCHEMA.Columns where TABLE_NAME = '" & TableName & "'"
        Dim dAdapter As New SqlClient.SqlDataAdapter(strSql, Con)
        dAdapter.Fill(dsColumnName)
        Dim ColumnsName_String As String = ""
        For i As Integer = 0 To dsColumnName.Tables(0).Rows.Count - 1
            If (col = "table_name") Then
                column_I.Items.Add(dsColumnName.Tables(0).Rows(i).Item(0))
            Else
                column_II.Items.Add(dsColumnName.Tables(0).Rows(i).Item(0))
            End If
        Next
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If (database_select.SelectedIndex = -1 Or table_name.SelectedIndex = -1 Or table_name_1.SelectedIndex = -1 Or column_I.SelectedIndex = -1 Or column_II.SelectedIndex = -1) Then
            msg.mes("Please Fill All The Fields.")
        Else
            Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
            Dim msg As New mbox
            Dim myCommand As String
            myCommand = "ALTER TABLE " + table_name.SelectedItem + " ADD CONSTRAINT FK_" + table_name.SelectedItem + " FOREIGN KEY (" + column_I.SelectedItem + ") REFERENCES " + table_name_1.SelectedItem + " (" + column_II.SelectedItem + ")"
            Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString)
            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                msg.mes("Foreign Key Sucessfully Created.")
                cmd.Connection.Close()
            Catch
                msg.mes("Error.")
            End Try
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        table_name.Items.Clear()
        table_name_1.Items.Clear()
        column_I.Items.Clear()
        column_II.Items.Clear()
        database_select.SelectedIndex = -1
        table_name.SelectedIndex = -1
        table_name_1.SelectedIndex = -1
        column_I.SelectedIndex = -1
        column_II.SelectedIndex = -1
    End Sub
End Class

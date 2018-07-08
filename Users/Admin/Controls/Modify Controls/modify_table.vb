Imports System.Data.SqlClient
Imports System.Data

Public Class modify_table
    Dim k As Integer = 0
    Dim p As Integer = 0
    Dim c As Integer = 0
    Dim h As Integer
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles content.Paint
        database_select.DataSource = GetDatabaseNames()
        table_name.Text = ""
        columns_head.Visible = False

    End Sub

    Public Sub column_data(ByVal e As Dictionary(Of String, String), ByVal j As Integer)
        Dim l As Integer = 0
        For Each key As String In e.Keys
            If (l = 2 And key = "key") Then
                multilist(l + 1, j) = e(key)
            Else
                multilist(l, j) = e(key)
                l += 1
            End If
        Next
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim sql As String
        sql = "CREATE TABLE " + table_name.Text + " ("
        For i = 0 To col_selection - 1
            If (i > 0) Then
                sql += ","
            End If
            For j = 0 To 3
                If (j = 2) Then
                    If (multilist(j, i) = "") Then
                        sql += "NOT NULL "
                    Else
                        sql += " (" + multilist(j, i) + ") NOT NULL "
                    End If
                ElseIf (multilist(j, i) = "No Key") Then

                Else
                    sql += multilist(j, i) + " "
                End If
            Next j
        Next i
        sql += ")"
        MsgBox(sql)
        Try
            Dim cn As SqlConnection = New SqlConnection("Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False")
            Dim cmd = New SqlCommand(sql, cn)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            msg.mes("Table Sucessfully Created")
        Catch
            msg.mes("Something Wrong")
        End Try
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
        If (table_name.SelectedIndex = -1) Then
            columns_head.Visible = False
        Else
            columns_head.Visible = True
            Dim cn As New SqlConnection()
            Dim cmd As New SqlCommand()
            Dim schemaTable As DataTable
            Dim myReader As SqlDataReader

            'Open a connection to the SQL Server Northwind database.
            cn.ConnectionString = "Data Source=" & ds & ";Initial Catalog=" + database_select.SelectedItem + ";Integrated Security=True;Pooling=False"
            cn.Open()
            'Retrieve records from the Employees table into a DataReader.
            cmd.Connection = cn
            cmd.CommandText = "SELECT * FROM " + table_name.SelectedItem
            myReader = cmd.ExecuteReader(CommandBehavior.KeyInfo)

            'Retrieve column schema into a DataTable.
            schemaTable = myReader.GetSchemaTable()

            'For each field in the table...
            For Each myField As DataRow In schemaTable.Rows
                'For each property of the field...
                For Each myProperty As DataColumn In schemaTable.Columns
                    'Display the field name and value.
                    msg.mes(myProperty.ColumnName + " = " + myField(myProperty).ToString())
                Next
            Next
            'Always close the DataReader and connection.
            myReader.Close()
            cn.Close()

        End If
    End Sub
End Class

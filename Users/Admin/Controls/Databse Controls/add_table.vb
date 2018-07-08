Imports System.Data.SqlClient
Public Module GlobalVariables
    Public multilist(,) As String
    Public col_selection As Integer
End Module

Public Class add_table
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
        columns_no.SelectedIndex = -1
        columns_head.Visible = False

    End Sub

    Private Sub columns_no_SelectedIndexChanged(sender As Object, e As EventArgs) Handles columns_no.SelectedIndexChanged
        c = 1
        table_name.Text = ""
        If (p = 1 And k = 1) Then
            table_name.Text = "Sem_" + semester.SelectedItem + "_" + table_type.SelectedItem
        End If
        columns_head.Visible = True
        If (col_selection = 0) Then
            col_selection = columns_no.SelectedItem
            add_columns(col_selection)
        Else
            columns_box.Controls.Clear()
            col_selection = columns_no.SelectedItem
            add_columns(col_selection)
        End If
        ReDim multilist(3, col_selection - 1)
    End Sub

    Public Sub add_columns(ByVal e As Integer)
        Dim n As Integer = 0
        Dim p As Integer = 0
        For j = 0 To col_selection - 1
            Dim k As New tablecolumns()
            k.Tag = j
            k.Name += "_" + j.ToString
            columns_box.Controls.Add(k)
            k.Location = New Point(n, p)
            p += 35
        Next j
    End Sub

    Private Sub table_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles table_type.SelectedIndexChanged
        semester.Enabled = True
        k = 1
        table_name.Text = ""
        If (p = 1 And c = 1) Then
            table_name.Text = "Sem_" + semester.SelectedItem + "_" + table_type.SelectedItem
        End If
    End Sub


    Private Sub semester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semester.SelectedIndexChanged
        columns_no.Enabled = True
        p = 1
        table_name.Text = ""
        If (k = 1 And c = 1) Then
            table_name.Text = "Sem_" + semester.SelectedItem + "_" + table_type.SelectedItem
        End If
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
        Dim ck As Integer = 1
        sql = "CREATE TABLE " + table_name.Text + " ("
        For i = 0 To col_selection - 1
            If (i > 0) Then
                sql += ","
            End If
            For j = 0 To 3
                If (j = 2) Then
                    If (multilist(j, i) = "") Then
                        sql += " NOT NULL "
                    ElseIf (multilist(j - 1, i) = "INT") Then
                        sql += " NOT NULL "
                    Else
                        sql += " (" + multilist(j, i) + ") NOT NULL "
                    End If
                ElseIf (multilist(j, i) = "No Key") Then

                ElseIf (multilist(j, i) = "Primary Key") Then
                    If (ck = 1) Then
                        sql += multilist(j, i) + " "
                        ck = 0
                    Else

                    End If
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

    Private Sub table_name_Click(sender As Object, e As EventArgs) Handles table_name.Click

    End Sub

    Private Sub database_select_SelectedIndexChanged(sender As Object, e As EventArgs) Handles database_select.SelectedIndexChanged

    End Sub
End Class

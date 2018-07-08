Public Class Admin
    'Add Button Declarations
    Dim database As New add_records_admin_database

    Dim create_db As New Create_Database
    Dim delete_db As New delete_database
    Dim add_delete_tb As New add_table
    Dim add_user As New add_users
    Dim head_add As New heading_add
    Dim create_head As New create_database_head
    Dim delete_head As New delete_database_head
    Dim add_user_head As New add_users_head
    Dim add_table_head As New add_table_head
    Dim setting As New change_pass
    Dim setting_head As New heading_change_pass

    'Modify Button Declarations
    Dim modify_records As New modify_records_admin
    Dim modify_users As New modify_username_head
    Dim modify_users_content As New modify_username
    Dim modify_fkey As New modify_foreign_key
    Dim modify_fkey_head As New modify_foreign_key_head
    Dim modify_table As New modify_table
    Dim modify_table_head As New modify_table_head


    'Delete Button Declarations
    Dim delete_u As New delete_user
    Dim delete_h As New delete_user_head
    Dim delete_records As New delete_records_admin
    Dim delete_f As New delete_fkey
    Dim delete_f_h As New delete_fkey_head
    Dim delete_table_head As New delete_table_head
    Dim delete_table As New delete_table


    Private Sub assistant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        content.Controls.Add(database)
        heading.Controls.Add(head_add)
    End Sub

    Private Sub close_button_click(sender As Object, e As EventArgs) Handles close_button.Click
        Me.Hide()
        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()

    End Sub



    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        content.Controls.Clear()
        heading.Controls.Clear()
        heading.Controls.Add(head_add)
        add.IconRightVisible = True
        modify.IconRightVisible = False
        delete.IconRightVisible = False
        settings.IconRightVisible = False
        content.Controls.Add(database)

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        Welcome.Show()
        Welcome.id.Text = ""
        Welcome.pass.Text = ""
        Welcome.id.Focus()
    End Sub

    Private Sub settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        content.Controls.Clear()
        add.IconRightVisible = False
        modify.IconRightVisible = False
        delete.IconRightVisible = False
        settings.IconRightVisible = True
        heading.Controls.Clear()
        heading.Controls.Add(setting_head)
        content.Controls.Add(setting)
    End Sub

    Function add_records_assistant_database_clicks(ByVal cases As Integer) As Integer
        Select Case cases
            Case 0
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(create_head)
                content.Controls.Add(create_db)
            Case 1
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(add_table_head)
                content.Controls.Add(add_delete_tb)
            Case 2
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(delete_head)
                content.Controls.Add(delete_db)
            Case 3
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(add_user_head)
                content.Controls.Add(add_user)
        End Select
        Return 0
    End Function

    Public Sub modify_control(ByVal cases As Integer)
        Select Case cases
            Case 0
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(modify_table_head)
                content.Controls.Add(modify_table)
            Case 1
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(modify_users)
                content.Controls.Add(modify_users_content)
            Case 2
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(modify_users)
                content.Controls.Add(modify_users_content)
            Case 3
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(add_user_head)
                content.Controls.Add(add_user)
        End Select
    End Sub

    Public Sub delete_control(ByVal cases As Integer)
        Select Case cases
            Case 0
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(delete_f_h)
                content.Controls.Add(delete_f)
            Case 1
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(delete_table_head)
                content.Controls.Add(delete_table)
            Case 2
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(delete_h)
                content.Controls.Add(delete_u)
            Case 3
                heading.Controls.Clear()
                content.Controls.Clear()
                heading.Controls.Add(delete_h)
                content.Controls.Add(delete_u)
        End Select
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        content.Controls.Clear()
        heading.Controls.Clear()
        heading.Controls.Add(head_add)
        add.IconRightVisible = False
        modify.IconRightVisible = True
        delete.IconRightVisible = False
        settings.IconRightVisible = False
        content.Controls.Add(modify_records)
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        content.Controls.Clear()
        heading.Controls.Clear()
        heading.Controls.Add(head_add)
        add.IconRightVisible = False
        modify.IconRightVisible = False
        delete.IconRightVisible = True
        settings.IconRightVisible = False
        content.Controls.Add(delete_records)
    End Sub


    Private Sub heading_Paint(sender As Object, e As PaintEventArgs) Handles heading.Paint

    End Sub
End Class

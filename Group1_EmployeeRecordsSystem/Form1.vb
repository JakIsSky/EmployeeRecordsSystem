Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=employee_records_system;"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim query As String = "INSERT INTO `employee_records_system`.`employee_tbl` (`name`, `position`, `salary`, `department`) VALUES (@name, @position, @salary, @department);"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@position", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", CInt(TextBoxSalary.Text))
                    cmd.Parameters.AddWithValue("@department", TextBoxDepartment.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim query As String = "SELECT * FROM employee_records_system.employee_tbl WHERE is_deleted = 0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridViewRecord.DataSource = table
                DataGridViewRecord.Columns("id").Visible = False
                DataGridViewRecord.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewRecord_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRecord.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewRecord.Rows(e.RowIndex)
            TextBoxName.Text = selectedRow.Cells("name").Value.ToString()
            TextBoxPosition.Text = selectedRow.Cells("position").Value.ToString()
            TextBoxSalary.Text = selectedRow.Cells("salary").Value.ToString()
            TextBoxDepartment.Text = selectedRow.Cells("department").Value.ToString()

            TextBoxHiddenId.Text = selectedRow.Cells("Id").Value.ToString()

        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim query As String = "UPDATE `employee_records_system`.`employee_tbl` SET `name`=@name, `position`=@position, `salary`=@salary, `position`=@department WHERE `Id`=@Id;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(TextBoxHiddenId.Text))
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text)
                    cmd.Parameters.AddWithValue("@age", TextBoxPosition.Text)
                    cmd.Parameters.AddWithValue("@email", CInt(TextBoxSalary.Text))
                    cmd.Parameters.AddWithValue("@email", TextBoxDepartment.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim query As String = "UPDATE `employee_records_system`.`employee_tbl` SET `is_deleted`=1 WHERE `Id`=@Id;"

        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_records_system;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("Id", CInt(TextBoxHiddenId.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    TextBoxName.Clear()
                    TextBoxPosition.Clear()
                    TextBoxSalary.Clear()
                    TextBoxDepartment.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

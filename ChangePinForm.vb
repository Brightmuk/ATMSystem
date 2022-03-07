Imports MySql.Data.MySqlClient

Public Class ChangePinForm
    Private Sub btnChangePin_Click(sender As Object, e As EventArgs) Handles btnChangePin.Click
        If Not LandingPageForm.conn Is Nothing Then LandingPageForm.conn.Close()

        Try
            LandingPageForm.conn.Open()
            Dim query = "SELECT * FROM users WHERE IdNumber='" & LandingPageForm.IdNumber & "' AND Pin='" & txtCurrentPin.Text & "';"
            Dim cmd = New MySqlCommand(query, LandingPageForm.conn)
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim result As DataSet = New DataSet()
            adapter.Fill(result)

            Dim count As Integer
            count = result.Tables(0).Rows.Count
            If count = 0 Then
                MessageBox.Show("You current pin is incorrect!")
            Else
                Dim query1 = "UPDATE users SET Pin='" & txtNewPin.Text & "' WHERE IdNumber='" & LandingPageForm.IdNumber & "';"
                Dim cmd1 = New MySqlCommand(query1, LandingPageForm.conn)
                cmd1.ExecuteNonQuery()
                MessageBox.Show("Pin changed successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub txtRepeatPin_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRepeatPin.KeyUp
        If txtRepeatPin.Text <> txtNewPin.Text Then
            lblError.Text = "Pins do not match"
        Else
            lblError.Text = ""
        End If
    End Sub
End Class
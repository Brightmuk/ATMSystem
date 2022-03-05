
Imports MySql.Data.MySqlClient

Public Class LandingPageForm
    Dim conn As New MySqlConnection
    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Visible = False
        Dim create As New CreateAccountForm
        create.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=localhost;user id=root;password=beatsbydre;database=atmdb"

        Try
            conn.Open()
            Dim query = "SELECT * FROM users WHERE IdNumber='" & txtId.Text & "' AND Pin='" & txtPin.Text & "';"
            Dim cmd = New MySqlCommand(query, conn)
            Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim result As DataSet = New DataSet()
            adapter.Fill(result)

            Dim count As Integer
            count = result.Tables(0).Rows.Count
            If count = 0 Then
                MessageBox.Show("Wrong Id number or Pin code!")
            Else
                Me.Visible = False
                Dim home As New HomeForm
                home.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class

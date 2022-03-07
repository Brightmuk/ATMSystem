Imports MySql.Data.MySqlClient

Public Class CreateAccountForm

    Public Sub CreateAccount()
        Try
            LandingPageForm.conn.Open()

            Dim query1 = "INSERT INTO users(FirstName, LastName, IdNumber, KraPin, Pin, DateOfBirth) VALUES ('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtIdNumber.Text & "','" & txtKraPin.Text & "','" & txtPin.Text & "','" & datePicker.Text & "');"
            Dim cmd1 = New MySqlCommand(query1, LandingPageForm.conn)
            cmd1.ExecuteNonQuery()

            MessageBox.Show("Account created!")
            Me.Close()
            Dim landing As New LandingPageForm
            landing.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Close()
        Dim land As New LandingPageForm
        land.Visible = True

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        CreateAccount()

    End Sub
End Class
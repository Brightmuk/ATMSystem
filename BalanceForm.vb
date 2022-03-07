
Imports MySql.Data.MySqlClient
Public Class BalanceForm

    Public Sub GetBalance()
        Try
            LandingPageForm.conn.Open()
            Dim query = "SELECT Balance FROM bankAccounts WHERE owner='" & LandingPageForm.IdNumber & "';"
            Dim cmd = New MySqlCommand(query, LandingPageForm.conn)
            Dim balance = Convert.ToString(cmd.ExecuteScalar)

            lblResult.Text = "Your balance is ksh." & balance

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Private Sub Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
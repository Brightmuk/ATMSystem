Imports MySql.Data.MySqlClient

Public Class MiniStatementForm
    Public Sub GetTransactions()
        Try
            LandingPageForm.conn.Open()
            Dim query = "SELECT TransactionId, Type, Amount, Date FROM transactions WHERE owner='" & LandingPageForm.IdNumber & "';"

            Dim Sda As New MySqlDataAdapter
            Dim transactionsData As New DataTable
            Dim bSource As New BindingSource

            Dim cmd = New MySqlCommand(query, LandingPageForm.conn)
            Sda.SelectCommand = cmd

            Sda.Fill(transactionsData)
            bSource.DataSource = transactionsData
            dtGridView.DataSource = bSource
            Sda.Update(transactionsData)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub

    Private Sub MiniStatementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTransactions()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub dtGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGridView.CellContentClick

    End Sub
End Class
Public Class HomeForm
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim landing As New LandingPageForm
        landing.Show()

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim deposit As New DepositForm
        deposit.Show()

    End Sub

    Private Sub btnBalanceEnquiry_Click(sender As Object, e As EventArgs) Handles btnBalanceEnquiry.Click

        Dim balance As New BalanceForm()
        balance.Show()

    End Sub

    Private Sub btnFastCash_Click(sender As Object, e As EventArgs) Handles btnFastCash.Click
        Dim fastCash As New FastCashForm
        fastCash.Show()

    End Sub

    Private Sub btnChangePin_Click(sender As Object, e As EventArgs) Handles btnChangePin.Click
        Dim changePin As New ChangePinForm
        changePin.Show()

    End Sub

    Private Sub btnWithdrawCash_Click(sender As Object, e As EventArgs) Handles btnWithdrawCash.Click
        Dim withdraw As New WithdrawForm
        withdraw.Show()

    End Sub

    Private Sub btnMiniStatement_Click(sender As Object, e As EventArgs) Handles btnMiniStatement.Click
        Dim mini As New MiniStatementForm
        mini.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LandingPageForm.IdNumber = ""
        Me.Close()
        Dim landing As New LandingPageForm
        landing.Show()

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Hello " & LandingPageForm.FirstName & ", at your service!"
    End Sub
End Class
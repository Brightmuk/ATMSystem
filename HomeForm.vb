Public Class HomeForm
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Dim landing As New LandingPageForm
        landing.Show()

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

    End Sub

    Private Sub btnBalanceEnquiry_Click(sender As Object, e As EventArgs) Handles btnBalanceEnquiry.Click
        Dim balance As New BalanceForm
        balance.Show()

    End Sub
End Class
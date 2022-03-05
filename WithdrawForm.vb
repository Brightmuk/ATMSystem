Public Class WithdrawForm
    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblWithdraw.Click

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.TextChanged
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
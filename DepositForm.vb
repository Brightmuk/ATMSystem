Imports MySql.Data.MySqlClient

Public Class DepositForm
    Public Sub Deposit()
        Try
            LandingPageForm.conn.Open()
            Dim query1 = "UPDATE bankAccounts SET Balance=Balance+'" & Convert.ToInt32(txtAmount.Text) & "' WHERE owner='" & LandingPageForm.IdNumber & "';"
            Dim cmd1 = New MySqlCommand(query1, LandingPageForm.conn)
            cmd1.ExecuteNonQuery()

            Dim transcId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query2 = "INSERT INTO transactions(TransactionId, Owner, Type, Amount) VALUES ('" & transcId & "','" & LandingPageForm.IdNumber & "', 'Deposit','" & Convert.ToInt32(txtAmount.Text) & "');"
            Dim cmd2 = New MySqlCommand(query2, LandingPageForm.conn)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Deposit was successful!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Private Sub txtAmount_Click(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Deposit()
    End Sub
End Class
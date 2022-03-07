Imports MySql.Data.MySqlClient
Public Class WithdrawForm
    Dim CurrentBalance As Integer
    Public Sub Withdraw()
        Try
            LandingPageForm.conn.Open()
            Dim query1 = "UPDATE bankAccounts SET Balance=Balance-'" & (Convert.ToInt32(txtAmount.Text) + 20) & "' WHERE owner='" & LandingPageForm.IdNumber & "';"
            Dim cmd1 = New MySqlCommand(query1, LandingPageForm.conn)
            cmd1.ExecuteNonQuery()

            Dim transcId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query2 = "INSERT INTO transactions(TransactionId, Owner, Type, Amount) VALUES ('" & transcId & "','" & LandingPageForm.IdNumber & "', 'Withdraw','" & Convert.ToInt32(txtAmount.Text) & "');"
            Dim cmd2 = New MySqlCommand(query2, LandingPageForm.conn)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Withdrawal was successful! Transaction charge ksh.20")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Public Sub GetBalance()
        Try
            LandingPageForm.conn.Open()
            Dim query = "SELECT Balance FROM bankAccounts WHERE owner='" & LandingPageForm.IdNumber & "';"
            Dim cmd = New MySqlCommand(query, LandingPageForm.conn)
            Dim balance = Convert.ToString(cmd.ExecuteScalar)

            lblBalance.Text = "Your balance is ksh." & balance
            CurrentBalance = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Private Sub lblAmount_Click(sender As Object, e As EventArgs) Handles lblWithdraw.Click

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        If Convert.ToInt32(txtAmount.Text) + 120 > CurrentBalance Then
            MessageBox.Show("Insufficient balance to withdraw ksh." & txtAmount.Text & "! You need a minimum balance of ksh." & Convert.ToInt32(txtAmount.Text) + 120 & " to  withdraw ksh." & txtAmount.Text & "")
        Else
            Withdraw()

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()

    End Sub
End Class
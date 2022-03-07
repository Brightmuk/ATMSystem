Imports MySql.Data.MySqlClient

Public Class FastCashForm
    Dim CurrentBalance As Integer
    Public Sub Withdraw(amount As Int32)
        Try
            LandingPageForm.conn.Open()
            Dim query1 = "UPDATE bankAccounts SET Balance=Balance-'" & (amount + 20) & "' WHERE owner='" & LandingPageForm.IdNumber & "';"
            Dim cmd1 = New MySqlCommand(query1, LandingPageForm.conn)
            cmd1.ExecuteNonQuery()

            Dim transcId = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim query2 = "INSERT INTO transactions(TransactionId, Owner, Type, Amount) VALUES ('" & transcId & "','" & LandingPageForm.IdNumber & "', 'Withdraw','" & amount & "');"
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

            CurrentBalance = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LandingPageForm.conn.Close()

    End Sub
    Private Sub FastCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBalance()

    End Sub

    Private Sub btn5000_Click(sender As Object, e As EventArgs) Handles btn5000.Click
        If 5000 + 120 > CurrentBalance Then
            MessageBox.Show("Insufficient balance to withdraw ksh." & 5000 & "! You need a minimum balance of ksh." & 5000 + 120 & " to  withdraw ksh." & 5000 & "")
        Else
            Withdraw(5000)

        End If

    End Sub

    Private Sub btn10000_Click(sender As Object, e As EventArgs) Handles btn10000.Click

        If 10000 + 120 > CurrentBalance Then
            MessageBox.Show("Insufficient balance to withdraw ksh." & 20000 & "! You need a minimum balance of ksh." & 20000 + 120 & " to  withdraw ksh." & 20000 & "")
        Else
            Withdraw(10000)

        End If
    End Sub

    Private Sub btn20000_Click(sender As Object, e As EventArgs) Handles btn20000.Click
        If 20000 + 120 > CurrentBalance Then
            MessageBox.Show("Insufficient balance to withdraw ksh." & 20000 & "! You need a minimum balance of ksh." & 20000 + 120 & " to  withdraw ksh." & 20000 & "")
        Else
            Withdraw(10000)

        End If
    End Sub

    Private Sub btn30000_Click(sender As Object, e As EventArgs) Handles btn30000.Click
        If 30000 + 120 > CurrentBalance Then
            MessageBox.Show("Insufficient balance to withdraw ksh." & 30000 & "! You need a minimum balance of ksh." & 30000 + 120 & " to  withdraw ksh." & 30000 & "")
        Else
            Withdraw(10000)

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
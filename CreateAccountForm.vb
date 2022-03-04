Public Class CreateAccountForm
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Close()
        Dim land As New LandingPageForm
        land.Visible = True

    End Sub
End Class
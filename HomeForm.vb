Public Class HomeForm
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Dim landing As New LandingPageForm
        landing.Show()

    End Sub
End Class
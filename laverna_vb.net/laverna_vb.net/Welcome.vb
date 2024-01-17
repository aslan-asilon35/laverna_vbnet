Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click



        Dim dashboardForm As New MainMenu()

        dashboardForm.Show()

        Me.Hide()
    End Sub
End Class
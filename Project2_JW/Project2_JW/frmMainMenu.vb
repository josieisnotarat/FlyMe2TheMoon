Public Class frmMainMenu
    Private Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click
        frmEmployeeLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerLogin_Click(sender As Object, e As EventArgs) Handles btnCustomerLogin.Click
        frmCustomerLogin.Show()
        Me.Hide()
    End Sub
End Class
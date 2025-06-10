Public Class frmUserSelect

    ' Opens login screen and hides user select form based on user type chosen. If none are selected, display a message.

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs)
        If cboUserSelect.SelectedItem = "Customer" Then
            Me.Hide()
            frmCustomerLogin.Show() 'opens customer login
        ElseIf cboUserSelect.SelectedItem = "Pilot" Then
            Me.Hide()
            frmPilotLogin.Show() 'opens pilot login
        ElseIf cboUserSelect.SelectedItem = "Attendant" Then
            Me.Hide()
            frmAttendantLogin.Show() ' opens attendant login
        ElseIf cboUserSelect.SelectedItem = "Administrator" Then
            Me.Hide()
            frmAdministratorMainMenu.Show() ' opens admin main menu
        Else
            MessageBox.Show("User type must be selected.")
        End If
    End Sub

    Private Sub frmUserSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class frmCustomerMainMenu
    ' Pilot Main Menu: 
    ' loads forms on button click

    ' WORKS + COMMENTED 


    '----------------------------------------------------------------------------------------------------
    ' when customer main menu closes, show customer login
    '----------------------------------------------------------------------------------------------------
    Private Sub frmCustomerMainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmCustomerLogin.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open form to update customer profile upon button click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        frmUpdateCustomerProfile.Show()

    End Sub

    '----------------------------------------------------------------------------------------------------
    'open form to add flight upon button click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        frmAddCustomerFlight.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open form to see past flights upon button click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        frmShowPastCustomerFlights.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    'open form to see future flights upon button click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        frmShowFutureCustomerFlights.Show()
    End Sub


End Class
Public Class frmPilotMainMenu
    ' Pilot Main Menu: 
    ' loads forms on button click

    ' WORKS + COMMENTED 


    '----------------------------------------------------------------------------------------------------
    ' open login when form closed
    '----------------------------------------------------------------------------------------------------
    Private Sub frmPilotMainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmEmployeeLogin.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open update pilot profile when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        frmUpdatePilotProfile.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open show past pilot flights when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        frmShowPastPilotFlights.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open show future pilot flights when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        frmShowFuturePilotFlights.Show()
    End Sub

End Class
Public Class frmAttendantMainMenu
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
    ' open update attendant profile when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        frmUpdateAttendantProfile.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open show past attendant flights when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        frmShowPastAttendantFlights.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' open show future attendant flights when button pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        frmShowFutureAttendantFlights.Show()
    End Sub

End Class
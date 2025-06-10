Public Class frmAdministratorMainMenu
    ' Administrator Main Menu: 
    ' loads forms on button click

    ' WORKS + COMMENTED 


    '----------------------------------------------------------------------------------------------------
    ' opens statistics on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        frmFlyMe2theMoonStatistics.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens manage pilots on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnManagePilots_Click(sender As Object, e As EventArgs) Handles btnManagePilots.Click
        frmManagePilots.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens manage attendants on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnManageAttendants_Click(sender As Object, e As EventArgs) Handles btnManageAttendants.Click
        frmManageAttendants.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens add flight on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        frmAddFlight.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens employee login when form closed
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAdministratorMainMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmEmployeeLogin.Show()
    End Sub


End Class
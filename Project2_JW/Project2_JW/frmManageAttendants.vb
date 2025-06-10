Public Class frmManageAttendants
    ' Manage Attendants: 
    ' loads forms on button click

    ' WORKS + COMMENTED 


    '----------------------------------------------------------------------------------------------------
    ' opens delete attendants on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnDeleteAttendants_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendants.Click
        frmDeleteAttendants.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens add attendants on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddAttendants_Click(sender As Object, e As EventArgs) Handles btnAddAttendants.Click
        frmAddAttendants.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens add attendant flights on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddAttendantFlights_Click(sender As Object, e As EventArgs) Handles btnAddAttendantFlights.Click
        frmAddAttendantFlights.Show()
    End Sub
End Class
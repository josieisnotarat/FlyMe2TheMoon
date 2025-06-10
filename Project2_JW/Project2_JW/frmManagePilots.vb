Public Class frmManagePilots
    ' Manage Pilots: 
    ' loads forms on button click

    ' WORKS + COMMENTED 


    '----------------------------------------------------------------------------------------------------
    ' opens delete pilots on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnDeletePilots_Click(sender As Object, e As EventArgs) Handles btnDeletePilots.Click
        frmDeletePilots.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens add pilots on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddPilots_Click(sender As Object, e As EventArgs) Handles btnAddPilots.Click
        frmAddPilots.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' opens add pilot flights on click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddPilotFlights_Click(sender As Object, e As EventArgs) Handles btnAddPilotFlights.Click
        frmAddPilotFlights.Show()
    End Sub
End Class
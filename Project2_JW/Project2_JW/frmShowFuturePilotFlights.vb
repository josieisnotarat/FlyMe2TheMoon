Public Class frmShowFuturePilotFlights
    ' Show Future Pilot Flights: 
    ' displays future pilot flights in a list box based on current date

    ' WORKS + COMMENTED + MODULARIZED

    '----------------------------------------------------------------------------------------------------
    ' on form load, display future flights based on current pilot ID
    '----------------------------------------------------------------------------------------------------
    Private Sub frmShowPastAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim objParam As Object
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set will 

            ' open the DB
            OpenDB(Me)

            ' call stored procedure 
            cmdSelect = New OleDb.OleDbCommand("uspGetPilotFutureFlights", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            ' add parameters
            objParam = cmdSelect.Parameters.Add("@intCurrentPilotID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = strCurrentPilotID

            'clear listbox 
            lstResultSet.Items.Clear()

            drSourceTable = cmdSelect.ExecuteReader

            ' display heading
            lstResultSet.Items.Add("Future Flights:")
            lstResultSet.Items.Add("=============================")

            ' loop through results set and list flights
            While drSourceTable.Read()

                lstResultSet.Items.Add("  ")

                lstResultSet.Items.Add("Flight Number: " & vbTab & drSourceTable("strFlightNumber"))
                lstResultSet.Items.Add("Flight Date: " & vbTab & drSourceTable("dtmFlightDate"))
                lstResultSet.Items.Add("Time of Departure: " & vbTab & drSourceTable("dtmTimeofDeparture"))
                lstResultSet.Items.Add("Time of Landing: " & vbTab & drSourceTable("dtmTimeOfLanding"))
                lstResultSet.Items.Add("From Airport: " & vbTab & drSourceTable("intFromAirportID"))
                lstResultSet.Items.Add("To Airport: " & vbTab & drSourceTable("intToAirportID"))
                lstResultSet.Items.Add("Miles Flown: " & vbTab & drSourceTable("intMilesFlown"))
                lstResultSet.Items.Add("Plane Type: " & vbTab & drSourceTable("strPlaneType"))

                lstResultSet.Items.Add("  ")
                lstResultSet.Items.Add("=============================")
            End While

            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------
    ' closes form when okay is clicked
    '----------------------------------------------------------------------------------------------------
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Close()
    End Sub
End Class
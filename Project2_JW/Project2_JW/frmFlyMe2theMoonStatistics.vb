Public Class frmFlyMe2theMoonStatistics
    ' FlyMe2theMoon Statistics: 
    ' - collects statistics on attendant miles flown, pilot miles flown, total customers, total flights taken, and avg miles per flight
    ' - displays statistics on form in labels/list boxes

    ' WORKS + COMMENTED + MODULARIZED


    '----------------------------------------------------------------------------------------------------
    ' collects and displays statistics
    '----------------------------------------------------------------------------------------------------
    Private Sub frmFlyMe2theMoonStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set is stored 

            ' open the DB
            OpenDB(Me)

            ' Build the select statement
            strSelect = "SELECT TA.strFirstName + ' ' + TA.strLastName AS AttendantName, COALESCE(SUM(TF.intMilesFlown), 0) AS TotalMilesFlown
                        FROM TAttendants AS TA
                        LEFT JOIN TAttendantFlights AS TAF
                        ON TA.intAttendantID = TAF.intAttendantID
                        LEFT JOIN TFlights AS TF
                        ON TAF.intFlightID = TF.intFlightID
                        GROUP BY TA.intAttendantID, TA.strFirstName, TA.strLastName"

            'clear listbox 
            lstAttendantMilesFlown.Items.Clear()

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            lstAttendantMilesFlown.Items.Add("Attendant Miles Flown: ")
            lstAttendantMilesFlown.Items.Add("=============================")

            'loop through results set and list flights
            While drSourceTable.Read()
                lstAttendantMilesFlown.Items.Add("  ")
                lstAttendantMilesFlown.Items.Add(drSourceTable("AttendantName"))
                lstAttendantMilesFlown.Items.Add("Miles Flown: " & drSourceTable("TotalMilesFlown"))
                lstAttendantMilesFlown.Items.Add("  ")
                lstAttendantMilesFlown.Items.Add("=============================")
            End While

            ' Build the select statement
            strSelect = "SELECT TP.strFirstName + ' ' + TP.strLastName AS PilotName, COALESCE(SUM(TF.intMilesFlown), 0) AS TotalMilesFlown
                        FROM TPilots AS TP
                        LEFT JOIN TPilotFlights AS TPF
                        ON TP.intPilotID = TPF.intPilotID
                        LEFT JOIN TFlights AS TF
                        ON TPF.intFlightID = TF.intFlightID
                        GROUP BY TP.intPilotID, TP.strFirstName, TP.strLastName"

            'clear listbox 
            lstPilotMilesFlown.Items.Clear()

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            lstPilotMilesFlown.Items.Add("Pilot Miles Flown: ")
            lstPilotMilesFlown.Items.Add("=============================")

            'loop through results set and list flights
            While drSourceTable.Read()
                lstPilotMilesFlown.Items.Add("  ")
                lstPilotMilesFlown.Items.Add(drSourceTable("PilotName"))
                lstPilotMilesFlown.Items.Add("Miles Flown: " & drSourceTable("TotalMilesFlown"))
                lstPilotMilesFlown.Items.Add("  ")
                lstPilotMilesFlown.Items.Add("=============================")
            End While

            ' Build the select statement

            strSelect = "SELECT COUNT(*) AS TotalCustomers
                        FROM TPassengers"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()
            lblTotalCustomers.Text = "Total Customers: " & drSourceTable("TotalCustomers")

            '' Build the select statement
            strSelect = "SELECT SUM(FlightCount) AS TotalFlights
                           FROM (
                                    SELECT COUNT(*) AS FlightCount
                                    FROM TFlightPassengers
                                    GROUP BY intPassengerID
                            ) AS PassengerFlights"

            '' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()
            lblTotalFlightsTaken.Text = "Total Flights Taken: " & drSourceTable("TotalFlights")

            '' Build the select statement
            strSelect = "SELECT AVG(TF.intMilesFlown) AS AverageMilesFlown
                         FROM TFlightPassengers AS TFP
                        JOIN TFlights AS TF 
                         ON TFP.intFlightID = TF.intFlightID"

            '' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()
            lblAvgMilesForAllCustomers.Text = "Average Miles Flown: " & drSourceTable("AverageMilesFlown")

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' closes form on button click
    '----------------------------------------------------------------------------------------------------
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Close()
    End Sub

End Class
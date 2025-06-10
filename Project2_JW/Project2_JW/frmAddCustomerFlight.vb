Public Class frmAddCustomerFlight
    ' Add Customer Flight: 
    ' - gets future flight information and presents it in a combo box
    ' - gather information on flight and passenger to calculate flight price
    ' - inserts info into TFlightPassengers

    ' WORKS + COMMENTED + MODULARIZED

    'class level variables for reserved and assigned cost
    Dim decAssignedCost As Decimal
    Dim decReservedCost As Decimal


    '----------------------------------------------------------------------------------------------------
    ' on load, search for all flights after the current date, format them, and add to the combo box.
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAddCustomerFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""

        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Try
            ' open the DB
            OpenDB(Me)

            ' call stored procedure
            cmdSelect = New OleDb.OleDbCommand("uspGetFutureFlights", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader

            While drSourceTable.Read()
                cboSelectFlight.Items.Add("ID: " & drSourceTable("FlightID") & " From: " & drSourceTable("FromAirport").ToString & " To: " & drSourceTable("ToAirport").ToString & ", " & drSourceTable("FlightDate") & " " & drSourceTable("DepartureTime"))
            End While

            ' Select the first item in the list by default
            If cboSelectFlight.Items.Count > 0 Then cboSelectFlight.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception
            MessageBox.Show(excError.Message)
        End Try
    End Sub



    '----------------------------------------------------------------------------------------------------
    ' show radio buttons after flight is selected, 
    '----------------------------------------------------------------------------------------------------
    Private Sub cboSelectFlight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectFlight.SelectedIndexChanged
        radAssignedSeating.Visible = True
        radReserveSeat.Visible = True

        ' variable for flight ID 
        Dim strFlightID As String

        ' variables to grab from database for price calculation
        Dim intMilesFlown As Integer
        Dim strPlaneType As String
        Dim strAirportCode As String
        Dim intPassengerCount As Integer
        Dim intPassengerAge As Integer
        Dim intPastFlights As Integer


        Dim decTicketCost As Decimal = 250.0



        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

        ' get flight id via string manipulation 
        Dim intColonIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(":")
        Dim intSecondSpaceIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(" ", intColonIndex + 1)
        strFlightID = cboSelectFlight.SelectedItem.Substring(intColonIndex + 2, intSecondSpaceIndex - 1)
        strFlightID = strFlightID.Trim

        OpenDB(Me)
        ' step 1: miles flown, plane type, airport code
        ' gets flight info for price calc
        strSelect = "Select TF.intMilesFlown, TPT.strPlaneType, TA.strAirportCode
                        From TFlights as TF
                        Join TPlanes as TP
                        On TP.intPlaneID = TF.intPlaneID
                        Join TPlaneTypes as TPT
                        On TP.intPlaneTypeID = TPT.intPlaneTypeID
                        Join TAirports as TA
                        On TA.intAirportID = TF.intToAirportID
                        Where intFlightID = " & strFlightID

        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        drSourceTable.Read()

        ' stores necessary data  from TFlights select to variables (will be passed to function later)
        intMilesFlown = drSourceTable("intMilesFlown")
        strPlaneType = drSourceTable("strPlaneType")
        strAirportCode = drSourceTable("strAirportCode")

        ' close sourcetable for reuse
        drSourceTable.Close()

        ' step 2: age
        ' grab customer age from db
        strSelect = "Select intPassengerID, dtmDateOfBirth, FLOOR(DATEDIFF(DAY, dtmDateOfBirth, GetDate()) / 365.25) 
                        AS Age FROM TPassengers WHERE intPassengerID = " & strCurrentCustomerID

        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        drSourceTable.Read()

        ' store age for later use
        intPassengerAge = drSourceTable("Age")

        ' close sourcetable for reuse
        drSourceTable.Close()


        ' step 3: passengers on flight
        ' select count of passengers on flight by ID
        strSelect = "Select count(*) as Count from TFlightPassengers Where intFlightID = " & strFlightID

        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        drSourceTable.Read()

        ' store num of passengers for later use
        intPassengerCount = drSourceTable("Count")

        ' close sourcetable for reuse
        drSourceTable.Close()


        ' step 4: number of past flights
        ' select count of past flights by ID and date
        strSelect = "Select Count(*) as Count from TFlightPassengers as TFP
	                    Join TFlights as TF
	                    on TF.intFlightID = TFP.intFlightID	
	                    Where dtmFlightDate < GetDate() and intPassengerID = " & strCurrentCustomerID

        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader
        drSourceTable.Read()

        intPastFlights = drSourceTable("Count")

        ' close sourcetable for reuse
        drSourceTable.Close()


        ' DEBUG MESSAGE (for manual calculation)
        ' MessageBox.Show(intMilesFlown.ToString & " " & strPlaneType & " " & strAirportCode & " " & intPassengerAge.ToString & " " & intPassengerCount.ToString & " " & intPastFlights.ToString)

        ' pass all variables to be calculated
        CalculateTicketPrice(decTicketCost, intMilesFlown, strPlaneType, strAirportCode, intPassengerAge, intPassengerCount, intPastFlights, decReservedCost, decAssignedCost)

        ' display final ticket prices on radio buttons
        radAssignedSeating.Text = "Assigned Seat at Check-In: " & decAssignedCost.ToString("c")
        radReserveSeat.Text = "Reserved Seat: " & decReservedCost.ToString("c")

    End Sub




    '----------------------------------------------------------------------------------------------------
    ' function to calculate ticket price
    '----------------------------------------------------------------------------------------------------
    Private Sub CalculateTicketPrice(ByRef decTicketCost As Decimal, ByVal intMilesFlown As Integer, ByVal strPlaneType As String, ByVal strAirportCode As String, ByVal intPassengerAge As Integer, ByVal intPassengerCount As Integer, ByVal intPastFlights As Integer, ByRef decReservedCost As Decimal, ByRef decAssignedCost As Decimal)
        ' add $50 if miles greater than 750
        If intMilesFlown > 750 Then
            decTicketCost += 50.0
        Else
        End If

        ' add $100 if more than 8 passengers have reserved a seat
        If intPassengerCount > 8 Then
            decTicketCost += 100.0
            ' deduct $25 if less than 4 passengers have reserved a seat
        ElseIf intPassengerCount < 4 Then
            decTicketCost -= 25.0
        End If

        ' add $35 if airbus a350 
        If strPlaneType = "Airbus A350" Then
            decTicketCost += 35.0
            ' deduct $25 if boeing 787-8
        ElseIf strPlaneType = "Boeing 787-8" Then
            decTicketCost -= 25.0
        Else
        End If

        ' add $15 if landing in miami
        If strAirportCode = "MIA" Then
            decTicketCost += 15.0
        Else
        End If

        ' deduct 20% if older than 65
        If intPassengerAge >= 65 Then
            decTicketCost -= (decTicketCost * 0.2)
            ' deduct 65% if younger than 5
        ElseIf intPassengerAge <= 5 Then
            decTicketCost -= (decTicketCost * 0.65)
        Else
        End If

        If intPastFlights > 10 Then
            decTicketCost -= (decTicketCost * 0.2)
        ElseIf intPastFlights > 5 Then
            decTicketCost -= (decTicketCost * 0.1)
        End If

        ' add 125 for reserved seat
        decReservedCost = decTicketCost + 125.0
        decAssignedCost = decTicketCost

    End Sub




    '----------------------------------------------------------------------------------------------------
    ' validate seat number and insert into TFlightPassengers
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click

        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String
        Dim strFlightID As String
        Dim strSeatNumber As String
        Dim strFlightCost As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Dim blnValidated As Boolean = True

        Try
            ' validate data is entered
            TextBoxStringExistsValidation(txtSeatNumber, strSeatNumber, "Seat Number", blnValidated)

            If radAssignedSeating.Checked Then
                strSeatNumber = "A5"
                blnValidated = True
            ElseIf radReserveSeat.Checked Then
                blnValidated = True
            Else
                MessageBox.Show("Please select a price option.")
            End If

            ' check if all validated & continue
            If blnValidated = True Then
                ' get flight id via string manipulation 
                Dim intColonIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(":")
                Dim intSecondSpaceIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(" ", intColonIndex + 1)
                strFlightID = cboSelectFlight.SelectedItem.Substring(intColonIndex + 2, intSecondSpaceIndex - 1)
                strFlightID = strFlightID.Trim


                ' grab flight cost via string manipulation
                If radAssignedSeating.Checked Then
                    strFlightCost = decAssignedCost
                    btnAddFlight.Enabled = True
                ElseIf radReserveSeat.Checked Then
                    strFlightCost = decReservedCost
                    btnAddFlight.Enabled = True
                Else
                    MessageBox.Show("Error with price calculation.")
                End If


                OpenDB(Me)

                    cmdSelect = New OleDb.OleDbCommand("uspMaxFlightPassengerID", m_conAdministrator)
                    cmdSelect.CommandType = CommandType.StoredProcedure
                    drSourceTable = cmdSelect.ExecuteReader

                    ' Read result( highest ID )
                    drSourceTable.Read()

                    ' Null? (empty table)
                    If drSourceTable.IsDBNull(0) = True Then
                        ' Yes, start numbering at 1
                        intNextPrimaryKey = 1
                    Else
                        ' No, get the next highest ID
                        intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))
                    End If


                ' build insert statement (columns must match DB columns in name and the # of columns)
                strInsert = "INSERT INTO TFlightPassengers ( intFlightPassengerID, intFlightID, intPassengerID, strSeat, decFlightCost)
                    VALUES (" & intNextPrimaryKey & "," & strFlightID & "," & strCurrentCustomerID & ",'" & strSeatNumber & "'," & strFlightCost & ")"

                'MessageBox.Show(strInsert)

                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                    ' execute query to insert data
                    intRowsAffected = cmdInsert.ExecuteNonQuery()

                    ' If not 0 insert successful
                    If intRowsAffected > 0 Then
                        MessageBox.Show("Flight added.")
                        ' let user know success
                    End If

                    ' Clean up
                    CloseDatabaseConnection()
                    Close()
                    drSourceTable.Close()


                End If

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------
    ' show seat number text box entry when reserve seat is checked
    '----------------------------------------------------------------------------------------------------
    Private Sub radReserveSeat_CheckedChanged(sender As Object, e As EventArgs) Handles radReserveSeat.CheckedChanged
        lblSeatNumber.Visible = True
        txtSeatNumber.Visible = True
        txtSeatNumber.Enabled = True
    End Sub


    '----------------------------------------------------------------------------------------------------
    ' hide seat number text box entry when assigned seating rad is checked
    '----------------------------------------------------------------------------------------------------
    Private Sub radAssignedSeating_CheckedChanged(sender As Object, e As EventArgs) Handles radAssignedSeating.CheckedChanged
        lblSeatNumber.Visible = False
        txtSeatNumber.Visible = False
        txtSeatNumber.Enabled = False
    End Sub



    '----------------------------------------------------------------------------------------------------
    ' close form when cancel is pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


End Class
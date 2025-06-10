Public Class frmAddFlight

    ' Add Flight: 
    ' Loads airport and plane options into form 
    ' inserts information in database upon pressing submit

    ' WORKS + COMMENTED + MODULARIZED
    ' FIX UPDATE ROLE

    '----------------------------------------------------------------------------------------------------
    ' on form load, populate planes, airports
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAddPilots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable
            Dim dtt As DataTable = New DataTable
            Dim dtf As DataTable = New DataTable



            ' open the DB
            OpenDB(Me)

            ' build plane select statement
            strSelect = "SELECT TP.intPlaneID, TP.strPlaneNumber + ', ' + TPT.strPlaneType as PlaneDisplay 
                                FROM TPlanes as TP
                                JOIN TPlaneTypes as TPT
                                ON TP.intPlaneTypeID = TPT.intPlaneTypeID"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)

            cboPlanes.ValueMember = "TP.intPlaneID"
            cboPlanes.DisplayMember = "PlaneDisplay"
            cboPlanes.DataSource = dts

            'select first option by default
            cboPlanes.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' build airport select statement
            strSelect = "SELECT intAirportID, strAirportCity + ' (' + strAirportCode + ')' as AirportDisplay FROM TAirports"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtf.Load(drSourceTable)


            cboFromAirport.ValueMember = "intAirportID"
            cboFromAirport.DisplayMember = "AirportDisplay"
            cboFromAirport.DataSource = dtf

            'select first option by default
            cboFromAirport.SelectedIndex = 0

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtt.Load(drSourceTable)

            cboToAirport.ValueMember = "intAirportID"
            cboToAirport.DisplayMember = "AirportDisplay"
            cboToAirport.DataSource = dtt

            'select first option by default
            cboToAirport.SelectedIndex = 0


            ' Clean up
            drSourceTable.Close()



            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    '----------------------------------------------------------------------------------------------------
    ' when submitted, validate inputs and insert accordingly
    '----------------------------------------------------------------------------------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' variables for new player data and select and insert statements

        Dim strSelect As String
        Dim strInsert As String

        Dim strFlightNumber As String
        Dim strMilesFlown As String
        Dim dtmDateOfFlight As DateTime
        Dim dtmTimeOfDeparture As TimeSpan
        Dim dtmTimeOfLanding As TimeSpan
        Dim intPlaneID As Integer
        Dim intFromAirportID As Integer
        Dim intToAirportID As Integer

        Dim intNextPrimaryKey As Integer

        Dim cmdInsert As OleDb.OleDbCommand ' select command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed


        Dim blnValidated As Boolean = True
        Try

            ' flight number validation
            SpecificDigitIntegerValidation(txtFlightNumber, strFlightNumber, 3, "Flight Number", blnValidated)

            ' flight number validation
            NumericValidation(txtMilesFlown, strMilesFlown, "Miles Flown", blnValidated)


            ' found this all just messing with the DateTime format
            If dtmFlightDatePicker.Value > DateTime.Today.AddHours(24) Then
                dtmDateOfFlight = dtmFlightDatePicker.Value.Date
            Else
                MessageBox.Show("Date of flight must be in the future.")
                blnValidated = False
            End If

            If dtmTimeOfDeparturePicker.Value.TimeOfDay < dtmTimeOfLandingPicker.Value.TimeOfDay Then
                dtmTimeOfDeparture = dtmTimeOfDeparturePicker.Value.TimeOfDay
                dtmTimeOfLanding = dtmTimeOfLandingPicker.Value.TimeOfDay
            Else
                MessageBox.Show("Time of Landing must be after time of departure.")
                blnValidated = False
            End If

            intPlaneID = cboPlanes.SelectedValue

            If cboFromAirport.SelectedValue = cboToAirport.SelectedValue Then
                MessageBox.Show("From and To Airport cannot match.")
                blnValidated = False
            Else
                intFromAirportID = cboFromAirport.SelectedValue
                intToAirportID = cboToAirport.SelectedValue
            End If


            ' check if all validated & continue
            If blnValidated = True Then

                'open the database
                OpenDB(Me)

                ' Build the select statement using PK from name selected

                strSelect = "SELECT MAX(intFlightID) + 1 AS intNextPrimaryKey " &
                                                " FROM TFlights"
                ' Execute command
                cmdInsert = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdInsert.ExecuteReader

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

                drSourceTable.Close()

                ' Build the select statement using PK from name selected
                strInsert = "INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber,  dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)
                                VALUES	(" & intNextPrimaryKey & ", '" & dtmDateOfFlight & "', '" & strFlightNumber & "', '" & dtmTimeOfDeparture.ToString() & "', '" & dtmTimeOfLanding.ToString() & "', " & intFromAirportID & ", " & intToAirportID & ", " & strMilesFlown & ", " & intPlaneID & ")"

                'MessageBox.Show(strInsert)

                ' make the connection
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdInsert.ExecuteNonQuery()


                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Insert successful")
                Else
                    MessageBox.Show("Insert failed")
                End If


                ' close the database connection
                CloseDatabaseConnection()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'C
    End Sub



    '----------------------------------------------------------------------------------------------------
    ' close form when cancel is pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmAddFlight_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAdministratorMainMenu.Show()
    End Sub
End Class





Public Class frmAddAttendantFlights
    ' Add Attendant Flights: 
    ' - gets future flight information and attendant names; presents it in a combo box
    ' - inserts info into TAttendantFlights

    ' WORKS + COMMENTED + MODULARIZED


    '----------------------------------------------------------------------------------------------------
    ' on load, search for all flights after the current date and attendant names, format them, and add to the combo box.
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAddAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            ' Build the select statement
            strSelect = "SELECT intAttendantID, strFirstName + ' ' + strLastName as AttendantName FROM TAttendants"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            cboSelectAttendant.ValueMember = "intAttendantID"
            cboSelectAttendant.DisplayMember = "AttendantName"
            cboSelectAttendant.DataSource = dt

            ' Select the first item in the list by default
            If cboSelectAttendant.Items.Count > 0 Then cboSelectAttendant.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception
            MessageBox.Show(excError.Message)
        End Try
    End Sub


    '----------------------------------------------------------------------------------------------------
    ' insert into TAttendantFlights
    '----------------------------------------------------------------------------------------------------
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click

        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String
        Dim strFlightID As String
        Dim strAttendantID As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Try
            ' get flight id via string manipulation 
            Dim intColonIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(":")
            Dim intSecondSpaceIndex As Integer = cboSelectFlight.SelectedItem.IndexOf(" ", intColonIndex + 1)
            strFlightID = cboSelectFlight.SelectedItem.Substring(intColonIndex + 2, intSecondSpaceIndex - 1)
            strFlightID = strFlightID.Trim()

            ' get pilot ID
            If cboSelectAttendant.SelectedIndex > -1 Then
                strAttendantID = cboSelectAttendant.SelectedValue
                Me.Hide()
            Else
                MessageBox.Show("Attendant must be selected.")
            End If

            OpenDB(Me)

            strSelect = "SELECT MAX(intAttendantFlightID) + 1 AS intNextPrimaryKey " &
                                " FROM TAttendantFlights"
            ' Execute command
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
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
            strInsert = "INSERT INTO TAttendantFlights ( intAttendantFlightID, intAttendantID, intFlightID)
                    VALUES (" & intNextPrimaryKey & "," & strAttendantID & "," & strFlightID & ")"

            'MessageBox.Show(strInsert)

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Flight added.")
                ' close new player form
            End If

            CloseDatabaseConnection()
            Close()
            ' Clean up
            drSourceTable.Close()


        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '----------------------------------------------------------------------------------------------------
    ' close form when cancel is pressed
    '----------------------------------------------------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
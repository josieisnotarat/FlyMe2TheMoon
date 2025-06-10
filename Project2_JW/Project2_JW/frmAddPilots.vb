Public Class frmAddPilots

    ' Add Pilots: 
    ' Loads role options into form 
    ' inserts information in database upon pressing submit

    ' WORKS + COMMENTED + MODULARIZED
    ' FIX UPDATE ROLE

    '----------------------------------------------------------------------------------------------------
    ' on form load, populate role 
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAddPilots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable


            ' open the DB
            OpenDB(Me)

            ' build role select statement
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)

            cboRole.ValueMember = "intPilotRoleID"
            cboRole.DisplayMember = "strPilotRole"
            cboRole.DataSource = dts


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

        Dim strFirstName As String
        Dim strLastName As String
        Dim dtmDateOfHire As DateTime
        Dim dtmDateOfTermination As DateTime
        Dim dtmDateOfLicense As DateTime
        Dim intPilotRoleID As Integer
        Dim strEmployeeID As String
        Dim strLoginID As String
        Dim strPassword As String

        Dim intNextPrimaryKey As Integer
        Dim intNextEmployeePrimaryKey As Integer


        Dim cmdInsert As OleDb.OleDbCommand ' select command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed


        Dim blnValidated As Boolean = True
        Try

            ' validate First Name
            TextBoxStringExistsValidation(txtFirstName, strFirstName, "First Name", blnValidated)

            ' validate Last Name
            TextBoxStringExistsValidation(txtLastName, strLastName, "Last Name", blnValidated)

            ' zip validation
            SpecificDigitIntegerValidation(txtEmployeeID, strEmployeeID, 5, "Employee ID", blnValidated)

            ' validate LoginID
            TextBoxStringExistsValidation(txtLoginID, strLoginID, "Login ID", blnValidated)

            ' validate Password
            TextBoxStringExistsValidation(txtPassword, strPassword, "Password", blnValidated)

            dtmDateOfHire = dtmDateOfHirePicker.Value
            dtmDateOfTermination = dtmDateOfTerminationPicker.Value
            dtmDateOfLicense = dtmDateOfLicensePicker.Value

            intPilotRoleID = cboRole.SelectedValue

            ' check if all validated & continue
            If blnValidated = True Then

                'open the database
                OpenDB(Me)

                ' Build the select statement using PK from name selected

                strSelect = "SELECT MAX(intPilotID) + 1 AS intNextPrimaryKey " &
                                                " FROM TPilots"
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
                strInsert = "INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)
                                VALUES	(" & intNextPrimaryKey & ", '" & strFirstName & "', '" & strLastName & "', '" & strEmployeeID & "', '" & dtmDateOfHire & "', '" & dtmDateOfTermination & "', '" & dtmDateOfLicense & "', " & intPilotRoleID & ")"

                'MessageBox.Show(strInsert)

                ' make the connection
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdInsert.ExecuteNonQuery()


                strSelect = "SELECT MAX(intEmployeeID) + 1 AS intNextPrimaryKey " &
                                                " FROM TEmployees"
                ' Execute command
                cmdInsert = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdInsert.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)
                If drSourceTable.IsDBNull(0) = True Then
                    ' Yes, start numbering at 1
                    intNextEmployeePrimaryKey = 1
                Else
                    ' No, get the next highest ID
                    intNextEmployeePrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))
                End If

                drSourceTable.Close()



                ' Build the select statement using PK from name selected
                strInsert = "INSERT INTO TEmployees (intEmployeeID, strEmployeeLoginID, strEmployeePassword, strEmployeeRole, intPilotID, intAttendantID)
                                VALUES	(" & intNextEmployeePrimaryKey & ", '" & strLoginID & "', '" & strPassword & "', 'Pilot', " & intNextPrimaryKey & ", null )"

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

End Class





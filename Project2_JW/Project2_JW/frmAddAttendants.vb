Public Class frmAddAttendants

    ' Add attendants:  
    ' inserts information in database upon pressing submit

    ' WORKS + COMMENTED + MODULARIZED


    '----------------------------------------------------------------------------------------------------
    ' when submitted, validate inputs and update profile accordingly
    '----------------------------------------------------------------------------------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim strSelect As String
        Dim strInsert As String

        Dim strFirstName As String
        Dim strLastName As String
        Dim dtmDateOfHire As DateTime
        Dim dtmDateOfTermination As DateTime
        Dim strEmployeeID As String
        Dim strLoginID As String
        Dim strPassword As String

        Dim intNextPrimaryKey As Integer
        Dim intNextEmployeePrimaryKey As Integer


        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert object
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

            If blnValidated = True Then

                OpenDB(Me)

                strSelect = "SELECT MAX(intAttendantID) + 1 AS intNextPrimaryKey " &
                                    " FROM TAttendants"

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

                drSourceTable.Close()

                ' Build the select statement using PK from name selected
                strInsert = "INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)
                                VALUES	(" & intNextPrimaryKey & ", '" & strFirstName & "', '" & strLastName & "', '" & strEmployeeID & "', '" & dtmDateOfHire & "', '" & dtmDateOfTermination & "')"


                ' uncomment out the following message box line to use as a tool to check your sql statement
                ' remember anything not a numeric value going into SQL Server must have single quotes '
                ' around it, including dates.

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
                                VALUES	(" & intNextEmployeePrimaryKey & ", '" & strLoginID & "', '" & strPassword & "', 'Attendant', null ," & intNextPrimaryKey & ")"

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
            'Close()


        Catch ex As Exception
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



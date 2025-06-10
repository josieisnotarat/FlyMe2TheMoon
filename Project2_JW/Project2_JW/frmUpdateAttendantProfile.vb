Public Class frmUpdateAttendantProfile

    ' Update attendant Profile: 
    ' Loads role options and all existing information for a user into form 
    ' Updates information in database upon pressing submit

    ' WORKS + COMMENTED + MODULARIZED

    '----------------------------------------------------------------------------------------------------
    ' on form load, populate user information
    '----------------------------------------------------------------------------------------------------
    Private Sub frmUpdateAttendantProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable


            ' open the DB
            OpenDB(Me)

            ' Build the select statement using PK from name selected
            strSelect = "SELECT strFirstName, strLastName, dtmDateOfHire, dtmDateOfTermination, strEmployeeID
                        FROM TAttendants                                                             
                        Where intAttendantID = " & strCurrentAttendantID

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            ' populate the text boxes with the data
            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            dtmDateOfHirePicker.Value = drSourceTable("dtmDateOfHire")
            dtmDateOfTerminationPicker.Value = drSourceTable("dtmDateOfTermination")
            txtEmployeeID.Text = drSourceTable("strEmployeeID")

            drSourceTable.Close()

            ' Build the select statement using PK from name selected
            strSelect = "SELECT strEmployeeLoginID, strEmployeePassword
                        FROM TEmployees                                                             
                        Where intAttendantID = " & strCurrentAttendantID

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            txtLoginID.Text = drSourceTable("strEmployeeLoginID")
            txtPassword.Text = drSourceTable("strEmployeePassword")

            CloseDatabaseConnection()

        Catch ex As Exception
            ' Log and display error message
            MessageBox.Show(ex.Message)
        End Try
    End Sub


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

        Dim cmdUpdate As OleDb.OleDbCommand ' select command object
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

            ' check if all validated & continue
            If blnValidated = True Then

                'open the database
                OpenDB(Me)

                ' Build the select statement using PK from name selected
                strSelect = "Update TAttendants Set " &
                                "strFirstName = '" & strFirstName & "', " &
                                "strLastName = '" & strLastName & "', " &
                                "dtmDateOfHire = '" & dtmDateOfHire & "', " &
                                "dtmDateOfTermination = '" & dtmDateOfTermination & "', " &
                                "strEmployeeID = '" & strEmployeeID & "'" &
                                "Where intAttendantID = " & strCurrentAttendantID

                'MessageBox.Show(strSelect)


                ' make the connection
                cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdUpdate.ExecuteNonQuery()

                ' Build the select statement using PK from name selected
                strSelect = "Update TEmployees Set " &
                                "strEmployeeLoginID = '" & strLoginID & "', " &
                                "strEmployeePassword = '" & strPassword & "' " &
                                "Where intAttendantID = " & strCurrentAttendantID

                'MessageBox.Show(strSelect)


                ' make the connection
                cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                ' IUpdate the row with execute the statement
                intRowsAffected = cmdUpdate.ExecuteNonQuery()

                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Update successful")
                Else
                    MessageBox.Show("Update failed")
                End If

                ' close the database connection
                CloseDatabaseConnection()

            End If

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
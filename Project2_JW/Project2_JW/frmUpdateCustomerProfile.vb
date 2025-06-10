Public Class frmUpdateCustomerProfile
    ' Update Customer Profile: 
    ' Loads state options and all existing information for a user into form 
    ' Updates information in database upon pressing submit

    ' WORKS + COMMENTED + MODULARIZED

    '----------------------------------------------------------------------------------------------------
    ' on form load, populate state and user information
    '----------------------------------------------------------------------------------------------------
    Private Sub frmUpdatePassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim objParam As Object
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

            Dim dtc As DataTable = New DataTable ' this is the table we will load from our reader for customer

            ' populate states
            LoadStatesComboBox(Me, cboState)

            ' open the DB
            OpenDB(Me)

            ' call stored procedure for passenger info 
            cmdSelect = New OleDb.OleDbCommand("uspPassengerInfo", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            ' add parameters
            objParam = cmdSelect.Parameters.Add("@intCurrentPassengerID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = strCurrentCustomerID

            ' read table
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            ' populate the text boxes with the data
            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            txtAddress.Text = drSourceTable("strAddress")
            txtCity.Text = drSourceTable("strCity")
            cboState.SelectedValue = drSourceTable("intStateID")
            txtPhoneNumber.Text = drSourceTable("strPhoneNumber")
            txtZipCode.Text = drSourceTable("strZip")
            txtEmail.Text = drSourceTable("strEmail")
            txtLoginID.Text = drSourceTable("strPassengerLoginID")
            txtPassword.Text = drSourceTable("strPassengerPassword")
            dtmDateOfBirthPicker.Value = drSourceTable("dtmDateOfBirth")

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
    ' when submitted, validate inputs and update profile accordingly
    '----------------------------------------------------------------------------------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' initialize variables
        Dim strSelect As String

        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intState As Integer
        Dim strZip As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strLoginID As String
        Dim strPassword As String
        Dim dtmDateOfBirth As DateTime

        Dim cmdUpdate As New OleDb.OleDbCommand ' select command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed


        Dim blnValidated As Boolean = True
        Try

            ' validate First Name
            TextBoxStringExistsValidation(txtFirstName, strFirstName, "First Name", blnValidated)

            ' validate Last Name
            TextBoxStringExistsValidation(txtLastName, strLastName, "Last Name", blnValidated)

            ' city validation
            TextBoxStringExistsValidation(txtCity, strCity, "City", blnValidated)

            ' address validation
            TextBoxStringExistsValidation(txtAddress, strAddress, "Address", blnValidated)

            ' state validation
            StateCboValidation(cboState, intState, blnValidated)

            ' zip validation
            SpecificDigitIntegerValidation(txtZipCode, strZip, 5, "Zip Code", blnValidated)

            ' validate phone
            SpecificDigitIntegerValidation(txtPhoneNumber, strPhoneNumber, 10, "Phone Number", blnValidated)

            ' validate email
            ValidateEmail(txtEmail, strEmail, blnValidated)

            ' validate Login ID
            TextBoxStringExistsValidation(txtLoginID, strLoginID, "Login ID", blnValidated)
            ' check if Login ID already exists (to avoid incorrect login with similar credentials)

            ' validate Password
            TextBoxStringExistsValidation(txtPassword, strPassword, "Password", blnValidated)

            ' validate date of birth
            If dtmDateOfBirthPicker.Value >= DateTime.Today Then
                MessageBox.Show("Date of birth must be in the past.")
                blnValidated = False
            Else
                dtmDateOfBirth = dtmDateOfBirthPicker.Value
            End If

            ' check if all validated & continue
            If blnValidated = True Then

                'open the database
                OpenDB(Me)

                ' text to call stored proc
                cmdUpdate.CommandText = "EXECUTE uspUpdatePassenger " & strCurrentCustomerID & ",'" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "'," & intState & ",'" & strZip & "','" & strPhoneNumber & "','" & strEmail & "','" & strLoginID & "','" & strPassword & "' ,'" & dtmDateOfBirth & "'"
                cmdUpdate.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdUpdate = New OleDb.OleDbCommand(cmdUpdate.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
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
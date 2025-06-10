Public Class frmCustomerCreationMenu

    'Customer Creation Menu:
    ' - Collect all relevant information on a Customer/Passenger
    ' - Validate inputs
    ' - Insert information into database

    ' WORKS + COMMENTED + MODULARIZED


    '----------------------------------------------------------------------------------------------------
    ' on form load, populate state
    '----------------------------------------------------------------------------------------------------
    Private Sub frmCustomerCreationMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStatesComboBox(Me, cboState)
    End Sub

    '----------------------------------------------------------------------------------------------------
    ' on submit, validate inputs, create new customer and save customerID
    '----------------------------------------------------------------------------------------------------

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' initialize variables
        Dim strInsert As String

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

        Dim cmdSelect As New OleDb.OleDbCommand ' select command object
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

                ' open the database
                OpenDB(Me)

                ' text to call stored proc
                cmdSelect.CommandText = "EXECUTE uspAddCustomer " & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "'," & intState & ",'" & strZip & "','" & strPhoneNumber & "','" & strEmail & "','" & strLoginID & "','" & strPassword & "' ,'" & dtmDateOfBirth & "'"
                cmdSelect.CommandType = CommandType.StoredProcedure

                ' save passenger ID
                strCurrentCustomerID = intNextPrimaryKey.ToString

                ' Call stored proc which will insert the record 
                cmdSelect = New OleDb.OleDbCommand(cmdSelect.CommandText, m_conAdministrator)

                ' Update the row with execute the statement
                intRowsAffected = cmdSelect.ExecuteNonQuery()

                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Customer Created.")
                Else
                    MessageBox.Show("Customer Creation Failed.")
                End If

                ' close the database connection
                CloseDatabaseConnection()

                Close()

            Else

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


    '----------------------------------------------------------------------------------------------------
    ' if form closed, open the one below it
    '----------------------------------------------------------------------------------------------------
    Private Sub frmCustomerCreationMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmCustomerLogin.Show()
    End Sub
End Class
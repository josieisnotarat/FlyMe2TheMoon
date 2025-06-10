Module modGlobals
    ' modGlobals: holds all public variables and subs
    ' * student-made ones, at the very least. I would typically put OpenDB in modDatabaseUtilities, but I wanted
    '   to have subs that I made seperate from the premade modDatabaseUtilities module.


    ' public variables to hold the currently logged in customer, pilot, or attendant
    Public strCurrentCustomerID As String
    Public strCurrentPilotID As String
    Public strCurrentAttendantID As String

    ' sub to open the database
    Public Sub OpenDB(Form As Object)
        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Form, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Form.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Form.Close()

        End If
    End Sub

    ' sub to load states from db into combo box
    Public Sub LoadStatesComboBox(Form As Object, cboState As Object)
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to

            Dim dts As DataTable = New DataTable ' this is the table we will load from our reader for State

            ' open the DB
            OpenDB(Form)

            ' Retrieve state records using stored procedure
            cmdSelect = New OleDb.OleDbCommand("uspStates", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)

            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox
            cboState.ValueMember = "intStateID"  ' ValueMember = name of ID attribute, SelectedValue = ID of selected item in combobox
            cboState.DisplayMember = "strState"
            cboState.DataSource = dts

            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    ' Validates text box contents and sets it to a variable, or displays a message telling the user that the contents must exist.
    Public Sub TextBoxStringExistsValidation(ByVal txtBox As Object, ByRef strText As String, ByVal strTextBoxContents As String, ByRef blnValidated As Boolean)
        If txtBox.Text.Length > 0 Then
            strText = txtBox.Text.Trim()
        Else
            MessageBox.Show(strTextBoxContents & " must exist.")
            blnValidated = False
        End If
    End Sub

    ' Validates that the state is selected. If not, shows a message reminding the user to select the state.
    Public Sub StateCboValidation(ByVal cboState As Object, ByRef intState As Integer, ByRef blnValidated As Boolean)
        If cboState.SelectedIndex > -1 Then
            intState = cboState.SelectedValue
        Else
            MessageBox.Show("State must be selected.")
            blnValidated = False
        End If
    End Sub

    ' Validates that the text box is filled with a number of the specified length. If not, it displays a message that the input must be of the specified length.
    Public Sub SpecificDigitIntegerValidation(txtBox As Object, ByRef intInteger As Long, ByVal intNumberLength As Integer, ByVal strTextBoxContents As String, ByRef blnValidated As Boolean)

        If Long.TryParse(txtBox.Text, intInteger) Then
            If txtBox.Text.Length = intNumberLength Then
            Else
                MessageBox.Show(strTextBoxContents & " must be a " & intNumberLength.ToString & "-digit integer.")
                blnValidated = False
            End If
        Else
            MessageBox.Show(strTextBoxContents & " must exist.")
            blnValidated = False
        End If
    End Sub

    ' Validates that the text box is filled with a number. If not, it displays a message that the input must exist and be numeric.
    Public Sub NumericValidation(txtBox As Object, ByRef intNumber As Long, ByVal strTextBoxContents As String, ByRef blnValidated As Boolean)

        If Long.TryParse(txtBox.Text, intNumber) Then
        Else
            MessageBox.Show(strTextBoxContents & " must exist and be numeric.")
            blnValidated = False
        End If
    End Sub


    ' Validates Email Addresses
    Public Sub ValidateEmail(txtEmail As Object, ByRef strEmail As String, ByRef blnValidated As Boolean)
        If txtEmail.Text.Length > 0 Then
            If txtEmail.Text.IndexOf("@") > -1 Then
                strEmail = txtEmail.Text.Trim()
            Else
                MessageBox.Show("Email must contain the '@' symbol.")
                blnValidated = False
            End If
        Else
            MessageBox.Show("Email must exist.")
            blnValidated = False
        End If
    End Sub
End Module

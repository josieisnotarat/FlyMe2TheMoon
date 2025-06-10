Public Class frmAttendantLogin
    ' Attendant Login Page: 
    ' - loads names from database
    ' - log in user, saving attendant ID based on selection

    ' WORKS + COMMENTED + MODULARIZED



    '----------------------------------------------------------------------------------------------------
    ' On form Load, add attendant names to combo box.
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAttendantLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Try

            ' open the DB this is in module
            OpenDB(Me)

            ' Build the select statement
            strSelect = "SELECT intAttendantID, strFirstName + ' ' + strLastName as AttendantName FROM TAttendants"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            cboAttendantName.ValueMember = "intAttendantID"
            cboAttendantName.DisplayMember = "AttendantName"
            cboAttendantName.DataSource = dt

            ' Select the first item in the list by default
            If cboAttendantName.Items.Count > 0 Then cboAttendantName.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception
            ' Log and display error message
            MessageBox.Show(excError.Message)
        End Try
    End Sub


    '----------------------------------------------------------------------------------------------------
    ' If attendant is selected, save ID, open attendant main menu, and hide attendant login form
    '----------------------------------------------------------------------------------------------------
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cboAttendantName.SelectedIndex > -1 Then
            strCurrentAttendantID = cboAttendantName.SelectedValue
            frmAttendantMainMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Attendant must be selected to log in.")
        End If
    End Sub


    '----------------------------------------------------------------------------------------------------
    ' If current form is closed, shows form below it.
    '----------------------------------------------------------------------------------------------------
    Private Sub frmAttendantLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmUserSelect.Show()
    End Sub

End Class
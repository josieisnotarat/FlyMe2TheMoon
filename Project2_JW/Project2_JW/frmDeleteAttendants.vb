Public Class frmDeleteAttendants
    ' Delete Attendants: 
    ' - loads names from database
    ' - prompts if user is sure about deletion
    ' - deletes information from TAttendantFlights and TAttendants with associated AttendantID

    ' WORKS + COMMENTED + MODULARIZED


    '----------------------------------------------------------------------------------------------------
    ' On form Load, add attendant names to combo box.
    '----------------------------------------------------------------------------------------------------
    Private Sub frmDeleteAttendants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    ' on button click, delete from TAttendantFlights and TAttendants based on selection
    '----------------------------------------------------------------------------------------------------
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strDelete As String = ""
        Dim strSelect As String = String.Empty
        Dim strName As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As New OleDb.OleDbCommand ' this will be used for our Delete statement
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim result As DialogResult  ' this is the result of which button the user selects

        Try
            ' open the database this is in module
            OpenDB(Me)

            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Delete Attendant: " & cboAttendantName.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes

                    ' Build the delete statement for employees
                    cmdDelete.CommandText = "EXECUTE uspDeleteAttendantEmployees '" & cboAttendantName.SelectedValue.ToString & "'"
                    cmdDelete.CommandType = CommandType.StoredProcedure

                    ' Call stored proc which will delete the record 
                    cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' Build the delete statement for flights
                    cmdDelete.CommandText = "EXECUTE uspDeleteAttendantFlights '" & cboAttendantName.SelectedValue.ToString & "'"
                    cmdDelete.CommandType = CommandType.StoredProcedure


                    ' Call stored proc which will delete the record 
                    cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' delete statement for attendant profile
                    cmdDelete.CommandText = "EXECUTE uspDeleteAttendants '" & cboAttendantName.SelectedValue.ToString & "'"
                    cmdDelete.CommandType = CommandType.StoredProcedure

                    ' Call stored proc which will delete the record 
                    cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' Did it work?
                    If intRowsAffected > 0 Then
                        ' Yes, success
                        MessageBox.Show("Delete successful")
                    End If

            End Select


            ' close the database connection
            CloseDatabaseConnection()

            ' call the Form Load sub to refresh the combo box data after a delete
            frmDeleteAttendants_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

End Class
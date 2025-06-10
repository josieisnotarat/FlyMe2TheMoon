Public Class frmEmployeeLogin
    ' Employee Login Page:  
    ' - accepts user ID and password
    ' - queries database for matching ID and password
    ' - if rows returned, show main menu based on employee role
    ' - if no rows returned, display error message



    '----------------------------------------------------------------------------------------------------
    ' queries for ID and password; shows main menu (based on ID search) if they match, error message if not
    '----------------------------------------------------------------------------------------------------
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click



        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Try

            ' open the DB this is in module
            OpenDB(Me)

            ' SELECT TO FIND IF PASSWORD/ID COMBO EXISTS
            strSelect = "SELECT * FROM TEmployees WHERE strEmployeeLoginID = '" & txtLoginID.Text.Trim & "' and strEmployeePassword = '" & txtPassword.Text.Trim & "'"

            'MessageBox.Show(strSelect)
            ' get records
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            drSourceTable.Read()

            ' check if it returned anything. If yes, show appropriate main menu and save ID (unless admin)
            If drSourceTable.HasRows Then


                If drSourceTable("strEmployeeRole") = "Admin" Then
                    frmAdministratorMainMenu.Show()
                    Me.Hide()

                ElseIf drSourceTable("strEmployeeRole") = "Pilot" Then
                    frmPilotMainMenu.Show()
                    Me.Hide()
                    strCurrentPilotID = drSourceTable("intPilotID")

                ElseIf drSourceTable("strEmployeeRole") = "Attendant" Then
                    frmAttendantMainMenu.Show()
                    Me.Hide()
                    strCurrentAttendantID = drSourceTable("intAttendantID")

                End If

                txtLoginID.Clear()
                txtPassword.Clear()

                ' if no rows are returned, show error message.
            Else
                MessageBox.Show("Login ID or Password Incorrect. Please try again.")
            End If


            ' Clean up
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch excError As Exception
            ' Log and display error message
            MessageBox.Show(excError.Message)
        End Try


    End Sub

    '----------------------------------------------------------------------------------------------------
    ' when form closed, show main menu again
    '----------------------------------------------------------------------------------------------------
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
        frmMainMenu.Show()
    End Sub

    Private Sub frmEmployeeLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMainMenu.Show()
    End Sub
End Class
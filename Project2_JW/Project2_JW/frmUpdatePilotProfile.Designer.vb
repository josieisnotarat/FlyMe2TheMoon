<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePilotProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.dtmDateOfHirePicker = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateOfLicensePicker = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateOfTerminationPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblDateOfLicense = New System.Windows.Forms.Label()
        Me.lblDateOfTermination = New System.Windows.Forms.Label()
        Me.lblDateOfHire = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLoginID = New System.Windows.Forms.Label()
        Me.txtLoginID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(371, 661)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnCancel.TabIndex = 53
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(87, 661)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(175, 40)
        Me.btnSubmit.TabIndex = 52
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(63, 458)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(129, 25)
        Me.lblEmployeeID.TabIndex = 47
        Me.lblEmployeeID.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(265, 454)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(117, 29)
        Me.txtEmployeeID.TabIndex = 46
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(63, 385)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(57, 25)
        Me.lblRole.TabIndex = 45
        Me.lblRole.Text = "Role:"
        '
        'cboRole
        '
        Me.cboRole.FormattingEnabled = True
        Me.cboRole.Location = New System.Drawing.Point(265, 378)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(175, 32)
        Me.cboRole.TabIndex = 44
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(63, 107)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(112, 25)
        Me.lblLastName.TabIndex = 39
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(265, 103)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 29)
        Me.txtLastName.TabIndex = 38
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(63, 45)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(117, 25)
        Me.lblFirstName.TabIndex = 37
        Me.lblFirstName.Text = "First Name: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(265, 41)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 29)
        Me.txtFirstName.TabIndex = 36
        '
        'dtmDateOfHirePicker
        '
        Me.dtmDateOfHirePicker.Location = New System.Drawing.Point(265, 179)
        Me.dtmDateOfHirePicker.Name = "dtmDateOfHirePicker"
        Me.dtmDateOfHirePicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmDateOfHirePicker.TabIndex = 54
        '
        'dtmDateOfLicensePicker
        '
        Me.dtmDateOfLicensePicker.Location = New System.Drawing.Point(265, 308)
        Me.dtmDateOfLicensePicker.Name = "dtmDateOfLicensePicker"
        Me.dtmDateOfLicensePicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmDateOfLicensePicker.TabIndex = 55
        '
        'dtmDateOfTerminationPicker
        '
        Me.dtmDateOfTerminationPicker.Location = New System.Drawing.Point(265, 241)
        Me.dtmDateOfTerminationPicker.Name = "dtmDateOfTerminationPicker"
        Me.dtmDateOfTerminationPicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmDateOfTerminationPicker.TabIndex = 56
        '
        'lblDateOfLicense
        '
        Me.lblDateOfLicense.AutoSize = True
        Me.lblDateOfLicense.Location = New System.Drawing.Point(63, 312)
        Me.lblDateOfLicense.Name = "lblDateOfLicense"
        Me.lblDateOfLicense.Size = New System.Drawing.Size(153, 25)
        Me.lblDateOfLicense.TabIndex = 57
        Me.lblDateOfLicense.Text = "Date of License:"
        '
        'lblDateOfTermination
        '
        Me.lblDateOfTermination.AutoSize = True
        Me.lblDateOfTermination.Location = New System.Drawing.Point(63, 245)
        Me.lblDateOfTermination.Name = "lblDateOfTermination"
        Me.lblDateOfTermination.Size = New System.Drawing.Size(188, 25)
        Me.lblDateOfTermination.TabIndex = 58
        Me.lblDateOfTermination.Text = "Date of Termination:"
        '
        'lblDateOfHire
        '
        Me.lblDateOfHire.AutoSize = True
        Me.lblDateOfHire.Location = New System.Drawing.Point(63, 179)
        Me.lblDateOfHire.Name = "lblDateOfHire"
        Me.lblDateOfHire.Size = New System.Drawing.Size(120, 25)
        Me.lblDateOfHire.TabIndex = 59
        Me.lblDateOfHire.Text = "Date of Hire:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(63, 586)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(104, 25)
        Me.lblPassword.TabIndex = 63
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(265, 582)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(331, 29)
        Me.txtPassword.TabIndex = 62
        '
        'lblLoginID
        '
        Me.lblLoginID.AutoSize = True
        Me.lblLoginID.Location = New System.Drawing.Point(63, 525)
        Me.lblLoginID.Name = "lblLoginID"
        Me.lblLoginID.Size = New System.Drawing.Size(90, 25)
        Me.lblLoginID.TabIndex = 61
        Me.lblLoginID.Text = "Login ID:"
        '
        'txtLoginID
        '
        Me.txtLoginID.Location = New System.Drawing.Point(265, 521)
        Me.txtLoginID.Name = "txtLoginID"
        Me.txtLoginID.Size = New System.Drawing.Size(331, 29)
        Me.txtLoginID.TabIndex = 60
        '
        'frmUpdatePilotProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 771)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblLoginID)
        Me.Controls.Add(Me.txtLoginID)
        Me.Controls.Add(Me.lblDateOfHire)
        Me.Controls.Add(Me.lblDateOfTermination)
        Me.Controls.Add(Me.lblDateOfLicense)
        Me.Controls.Add(Me.dtmDateOfTerminationPicker)
        Me.Controls.Add(Me.dtmDateOfLicensePicker)
        Me.Controls.Add(Me.dtmDateOfHirePicker)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "frmUpdatePilotProfile"
        Me.Text = "Update Pilot Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents dtmDateOfHirePicker As DateTimePicker
    Friend WithEvents dtmDateOfLicensePicker As DateTimePicker
    Friend WithEvents dtmDateOfTerminationPicker As DateTimePicker
    Friend WithEvents lblDateOfLicense As Label
    Friend WithEvents lblDateOfTermination As Label
    Friend WithEvents lblDateOfHire As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblLoginID As Label
    Friend WithEvents txtLoginID As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAttendants
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
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblLoginID = New System.Windows.Forms.Label()
        Me.txtLoginID = New System.Windows.Forms.TextBox()
        Me.lblDateOfHire = New System.Windows.Forms.Label()
        Me.lblDateOfTermination = New System.Windows.Forms.Label()
        Me.dtmDateOfTerminationPicker = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateOfHirePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(358, 520)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnCancel.TabIndex = 85
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(74, 520)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(175, 40)
        Me.btnSubmit.TabIndex = 84
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(55, 335)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(129, 25)
        Me.lblEmployeeID.TabIndex = 83
        Me.lblEmployeeID.Text = "Employee ID:"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(253, 331)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(117, 29)
        Me.txtEmployeeID.TabIndex = 82
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(57, 134)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(112, 25)
        Me.lblLastName.TabIndex = 79
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(255, 134)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(152, 29)
        Me.txtLastName.TabIndex = 78
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(57, 72)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(117, 25)
        Me.lblFirstName.TabIndex = 77
        Me.lblFirstName.Text = "First Name: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(255, 72)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 29)
        Me.txtFirstName.TabIndex = 76
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(55, 457)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(104, 25)
        Me.lblPassword.TabIndex = 97
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(255, 457)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(331, 29)
        Me.txtPassword.TabIndex = 96
        '
        'lblLoginID
        '
        Me.lblLoginID.AutoSize = True
        Me.lblLoginID.Location = New System.Drawing.Point(55, 396)
        Me.lblLoginID.Name = "lblLoginID"
        Me.lblLoginID.Size = New System.Drawing.Size(90, 25)
        Me.lblLoginID.TabIndex = 95
        Me.lblLoginID.Text = "Login ID:"
        '
        'txtLoginID
        '
        Me.txtLoginID.Location = New System.Drawing.Point(255, 396)
        Me.txtLoginID.Name = "txtLoginID"
        Me.txtLoginID.Size = New System.Drawing.Size(331, 29)
        Me.txtLoginID.TabIndex = 94
        '
        'lblDateOfHire
        '
        Me.lblDateOfHire.AutoSize = True
        Me.lblDateOfHire.Location = New System.Drawing.Point(53, 191)
        Me.lblDateOfHire.Name = "lblDateOfHire"
        Me.lblDateOfHire.Size = New System.Drawing.Size(120, 25)
        Me.lblDateOfHire.TabIndex = 101
        Me.lblDateOfHire.Text = "Date of Hire:"
        '
        'lblDateOfTermination
        '
        Me.lblDateOfTermination.AutoSize = True
        Me.lblDateOfTermination.Location = New System.Drawing.Point(53, 257)
        Me.lblDateOfTermination.Name = "lblDateOfTermination"
        Me.lblDateOfTermination.Size = New System.Drawing.Size(188, 25)
        Me.lblDateOfTermination.TabIndex = 100
        Me.lblDateOfTermination.Text = "Date of Termination:"
        '
        'dtmDateOfTerminationPicker
        '
        Me.dtmDateOfTerminationPicker.Location = New System.Drawing.Point(255, 253)
        Me.dtmDateOfTerminationPicker.Name = "dtmDateOfTerminationPicker"
        Me.dtmDateOfTerminationPicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmDateOfTerminationPicker.TabIndex = 99
        '
        'dtmDateOfHirePicker
        '
        Me.dtmDateOfHirePicker.Location = New System.Drawing.Point(255, 191)
        Me.dtmDateOfHirePicker.Name = "dtmDateOfHirePicker"
        Me.dtmDateOfHirePicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmDateOfHirePicker.TabIndex = 98
        '
        'frmAddAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 624)
        Me.Controls.Add(Me.lblDateOfHire)
        Me.Controls.Add(Me.lblDateOfTermination)
        Me.Controls.Add(Me.dtmDateOfTerminationPicker)
        Me.Controls.Add(Me.dtmDateOfHirePicker)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblLoginID)
        Me.Controls.Add(Me.txtLoginID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "frmAddAttendants"
        Me.Text = "Add Attendants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblLoginID As Label
    Friend WithEvents txtLoginID As TextBox
    Friend WithEvents lblDateOfHire As Label
    Friend WithEvents lblDateOfTermination As Label
    Friend WithEvents dtmDateOfTerminationPicker As DateTimePicker
    Friend WithEvents dtmDateOfHirePicker As DateTimePicker
End Class

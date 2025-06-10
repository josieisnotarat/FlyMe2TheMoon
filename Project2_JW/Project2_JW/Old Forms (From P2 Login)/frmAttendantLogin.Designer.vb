<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantLogin
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
        Me.lblAttendantSelect = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cboAttendantName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAttendantSelect
        '
        Me.lblAttendantSelect.AutoSize = True
        Me.lblAttendantSelect.Location = New System.Drawing.Point(39, 51)
        Me.lblAttendantSelect.Name = "lblAttendantSelect"
        Me.lblAttendantSelect.Size = New System.Drawing.Size(213, 25)
        Me.lblAttendantSelect.TabIndex = 9
        Me.lblAttendantSelect.Text = "Select attendant name:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(39, 135)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(590, 43)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'cboAttendantName
        '
        Me.cboAttendantName.FormattingEnabled = True
        Me.cboAttendantName.Location = New System.Drawing.Point(39, 82)
        Me.cboAttendantName.Name = "cboAttendantName"
        Me.cboAttendantName.Size = New System.Drawing.Size(590, 32)
        Me.cboAttendantName.TabIndex = 7
        '
        'frmAttendantLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 245)
        Me.Controls.Add(Me.lblAttendantSelect)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cboAttendantName)
        Me.Name = "frmAttendantLogin"
        Me.Text = "frmAttendantLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAttendantSelect As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents cboAttendantName As ComboBox
End Class

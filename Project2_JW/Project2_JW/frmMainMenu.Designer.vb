<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnEmployeeLogin = New System.Windows.Forms.Button()
        Me.btnCustomerLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmployeeLogin
        '
        Me.btnEmployeeLogin.Location = New System.Drawing.Point(50, 54)
        Me.btnEmployeeLogin.Name = "btnEmployeeLogin"
        Me.btnEmployeeLogin.Size = New System.Drawing.Size(176, 39)
        Me.btnEmployeeLogin.TabIndex = 5
        Me.btnEmployeeLogin.Text = "Employee Login"
        Me.btnEmployeeLogin.UseVisualStyleBackColor = True
        '
        'btnCustomerLogin
        '
        Me.btnCustomerLogin.Location = New System.Drawing.Point(263, 54)
        Me.btnCustomerLogin.Name = "btnCustomerLogin"
        Me.btnCustomerLogin.Size = New System.Drawing.Size(176, 39)
        Me.btnCustomerLogin.TabIndex = 4
        Me.btnCustomerLogin.Text = "Customer Login"
        Me.btnCustomerLogin.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 145)
        Me.Controls.Add(Me.btnEmployeeLogin)
        Me.Controls.Add(Me.btnCustomerLogin)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmployeeLogin As Button
    Friend WithEvents btnCustomerLogin As Button
End Class

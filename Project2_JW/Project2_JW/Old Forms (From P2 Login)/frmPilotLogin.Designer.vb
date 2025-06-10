<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPilotLogin
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
        Me.lblPilotSelect = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.cboPilotName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblPilotSelect
        '
        Me.lblPilotSelect.AutoSize = True
        Me.lblPilotSelect.Location = New System.Drawing.Point(45, 50)
        Me.lblPilotSelect.Name = "lblPilotSelect"
        Me.lblPilotSelect.Size = New System.Drawing.Size(167, 25)
        Me.lblPilotSelect.TabIndex = 6
        Me.lblPilotSelect.Text = "Select pilot name:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(45, 134)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(590, 43)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'cboPilotName
        '
        Me.cboPilotName.FormattingEnabled = True
        Me.cboPilotName.Location = New System.Drawing.Point(45, 81)
        Me.cboPilotName.Name = "cboPilotName"
        Me.cboPilotName.Size = New System.Drawing.Size(590, 32)
        Me.cboPilotName.TabIndex = 4
        '
        'frmPilotLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 265)
        Me.Controls.Add(Me.lblPilotSelect)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cboPilotName)
        Me.Name = "frmPilotLogin"
        Me.Text = "frmPilotLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPilotSelect As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents cboPilotName As ComboBox
End Class

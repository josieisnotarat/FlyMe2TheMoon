<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserSelect
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboUserSelect = New System.Windows.Forms.ComboBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Employee Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboUserSelect
        '
        Me.cboUserSelect.FormattingEnabled = True
        Me.cboUserSelect.Items.AddRange(New Object() {"Customer", "Pilot", "Attendant", "Administrator"})
        Me.cboUserSelect.Location = New System.Drawing.Point(53, 74)
        Me.cboUserSelect.Name = "cboUserSelect"
        Me.cboUserSelect.Size = New System.Drawing.Size(271, 32)
        Me.cboUserSelect.TabIndex = 4
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Location = New System.Drawing.Point(53, 43)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(169, 25)
        Me.lblUserType.TabIndex = 5
        Me.lblUserType.Text = "Select User Type:"
        '
        'frmUserSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 203)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.cboUserSelect)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmUserSelect"
        Me.Text = "User Select"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents cboUserSelect As ComboBox
    Friend WithEvents lblUserType As Label
End Class

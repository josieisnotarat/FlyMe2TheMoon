<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteAttendants
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
        Me.lblAttendant = New System.Windows.Forms.Label()
        Me.cboAttendantName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(407, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(123, 157)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(175, 40)
        Me.btnSubmit.TabIndex = 48
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblAttendant
        '
        Me.lblAttendant.AutoSize = True
        Me.lblAttendant.Location = New System.Drawing.Point(45, 71)
        Me.lblAttendant.Name = "lblAttendant"
        Me.lblAttendant.Size = New System.Drawing.Size(244, 25)
        Me.lblAttendant.TabIndex = 47
        Me.lblAttendant.Text = "Select Attendant to Delete:"
        '
        'cboAttendantName
        '
        Me.cboAttendantName.FormattingEnabled = True
        Me.cboAttendantName.Location = New System.Drawing.Point(340, 68)
        Me.cboAttendantName.Name = "cboAttendantName"
        Me.cboAttendantName.Size = New System.Drawing.Size(309, 32)
        Me.cboAttendantName.TabIndex = 46
        '
        'frmDeleteAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 278)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAttendant)
        Me.Controls.Add(Me.cboAttendantName)
        Me.Name = "frmDeleteAttendants"
        Me.Text = "Delete Attendants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblAttendant As Label
    Friend WithEvents cboAttendantName As ComboBox
End Class

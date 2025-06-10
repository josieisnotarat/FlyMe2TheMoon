<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAttendantFlights
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
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.lblSelectFlight = New System.Windows.Forms.Label()
        Me.cboSelectFlight = New System.Windows.Forms.ComboBox()
        Me.lblSelectAttendant = New System.Windows.Forms.Label()
        Me.cboSelectAttendant = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(243, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(168, 48)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(35, 189)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(168, 48)
        Me.btnAddFlight.TabIndex = 10
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'lblSelectFlight
        '
        Me.lblSelectFlight.AutoSize = True
        Me.lblSelectFlight.Location = New System.Drawing.Point(30, 53)
        Me.lblSelectFlight.Name = "lblSelectFlight"
        Me.lblSelectFlight.Size = New System.Drawing.Size(130, 25)
        Me.lblSelectFlight.TabIndex = 8
        Me.lblSelectFlight.Text = "Select Flight: "
        '
        'cboSelectFlight
        '
        Me.cboSelectFlight.FormattingEnabled = True
        Me.cboSelectFlight.Location = New System.Drawing.Point(228, 53)
        Me.cboSelectFlight.Name = "cboSelectFlight"
        Me.cboSelectFlight.Size = New System.Drawing.Size(678, 32)
        Me.cboSelectFlight.TabIndex = 6
        '
        'lblSelectAttendant
        '
        Me.lblSelectAttendant.AutoSize = True
        Me.lblSelectAttendant.Location = New System.Drawing.Point(30, 112)
        Me.lblSelectAttendant.Name = "lblSelectAttendant"
        Me.lblSelectAttendant.Size = New System.Drawing.Size(167, 25)
        Me.lblSelectAttendant.TabIndex = 13
        Me.lblSelectAttendant.Text = "Select Attendant: "
        '
        'cboSelectAttendant
        '
        Me.cboSelectAttendant.FormattingEnabled = True
        Me.cboSelectAttendant.Location = New System.Drawing.Point(228, 105)
        Me.cboSelectAttendant.Name = "cboSelectAttendant"
        Me.cboSelectAttendant.Size = New System.Drawing.Size(678, 32)
        Me.cboSelectAttendant.TabIndex = 12
        '
        'frmAddAttendantFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 287)
        Me.Controls.Add(Me.lblSelectAttendant)
        Me.Controls.Add(Me.cboSelectAttendant)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.lblSelectFlight)
        Me.Controls.Add(Me.cboSelectFlight)
        Me.Name = "frmAddAttendantFlights"
        Me.Text = "Add Attendant Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents lblSelectFlight As Label
    Friend WithEvents cboSelectFlight As ComboBox
    Friend WithEvents lblSelectAttendant As Label
    Friend WithEvents cboSelectAttendant As ComboBox
End Class

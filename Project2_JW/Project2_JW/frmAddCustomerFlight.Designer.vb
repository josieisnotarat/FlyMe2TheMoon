<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomerFlight
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
        Me.cboSelectFlight = New System.Windows.Forms.ComboBox()
        Me.lblSelectFlight = New System.Windows.Forms.Label()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.radReserveSeat = New System.Windows.Forms.RadioButton()
        Me.radAssignedSeating = New System.Windows.Forms.RadioButton()
        Me.txtSeatNumber = New System.Windows.Forms.TextBox()
        Me.lblSeatNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboSelectFlight
        '
        Me.cboSelectFlight.FormattingEnabled = True
        Me.cboSelectFlight.Location = New System.Drawing.Point(181, 68)
        Me.cboSelectFlight.Name = "cboSelectFlight"
        Me.cboSelectFlight.Size = New System.Drawing.Size(678, 32)
        Me.cboSelectFlight.TabIndex = 0
        '
        'lblSelectFlight
        '
        Me.lblSelectFlight.AutoSize = True
        Me.lblSelectFlight.Location = New System.Drawing.Point(27, 68)
        Me.lblSelectFlight.Name = "lblSelectFlight"
        Me.lblSelectFlight.Size = New System.Drawing.Size(130, 25)
        Me.lblSelectFlight.TabIndex = 2
        Me.lblSelectFlight.Text = "Select Flight: "
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(29, 271)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(168, 48)
        Me.btnAddFlight.TabIndex = 4
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(237, 271)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(168, 48)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'radReserveSeat
        '
        Me.radReserveSeat.AutoSize = True
        Me.radReserveSeat.Location = New System.Drawing.Point(32, 140)
        Me.radReserveSeat.Name = "radReserveSeat"
        Me.radReserveSeat.Size = New System.Drawing.Size(160, 29)
        Me.radReserveSeat.TabIndex = 6
        Me.radReserveSeat.TabStop = True
        Me.radReserveSeat.Text = "Reserve Seat "
        Me.radReserveSeat.UseVisualStyleBackColor = True
        Me.radReserveSeat.Visible = False
        '
        'radAssignedSeating
        '
        Me.radAssignedSeating.AutoSize = True
        Me.radAssignedSeating.Location = New System.Drawing.Point(361, 140)
        Me.radAssignedSeating.Name = "radAssignedSeating"
        Me.radAssignedSeating.Size = New System.Drawing.Size(249, 29)
        Me.radAssignedSeating.TabIndex = 7
        Me.radAssignedSeating.TabStop = True
        Me.radAssignedSeating.Text = "Assign Seat at Check-In"
        Me.radAssignedSeating.UseVisualStyleBackColor = True
        Me.radAssignedSeating.Visible = False
        '
        'txtSeatNumber
        '
        Me.txtSeatNumber.Location = New System.Drawing.Point(181, 204)
        Me.txtSeatNumber.Name = "txtSeatNumber"
        Me.txtSeatNumber.Size = New System.Drawing.Size(125, 29)
        Me.txtSeatNumber.TabIndex = 10
        Me.txtSeatNumber.Text = "A5"
        Me.txtSeatNumber.Visible = False
        '
        'lblSeatNumber
        '
        Me.lblSeatNumber.AutoSize = True
        Me.lblSeatNumber.Location = New System.Drawing.Point(27, 208)
        Me.lblSeatNumber.Name = "lblSeatNumber"
        Me.lblSeatNumber.Size = New System.Drawing.Size(133, 25)
        Me.lblSeatNumber.TabIndex = 11
        Me.lblSeatNumber.Text = "Seat Number:"
        Me.lblSeatNumber.Visible = False
        '
        'frmAddCustomerFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 370)
        Me.Controls.Add(Me.lblSeatNumber)
        Me.Controls.Add(Me.txtSeatNumber)
        Me.Controls.Add(Me.radAssignedSeating)
        Me.Controls.Add(Me.radReserveSeat)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.lblSelectFlight)
        Me.Controls.Add(Me.cboSelectFlight)
        Me.Name = "frmAddCustomerFlight"
        Me.Text = "Add Customer Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboSelectFlight As ComboBox
    Friend WithEvents lblSelectFlight As Label
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents radReserveSeat As RadioButton
    Friend WithEvents radAssignedSeating As RadioButton
    Friend WithEvents txtSeatNumber As TextBox
    Friend WithEvents lblSeatNumber As Label
End Class

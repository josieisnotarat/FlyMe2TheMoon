<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPilotFlights
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
        Me.lblSelectPilot = New System.Windows.Forms.Label()
        Me.cboSelectPilot = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.lblSelectFlight = New System.Windows.Forms.Label()
        Me.cboSelectFlight = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSelectPilot
        '
        Me.lblSelectPilot.AutoSize = True
        Me.lblSelectPilot.Location = New System.Drawing.Point(42, 109)
        Me.lblSelectPilot.Name = "lblSelectPilot"
        Me.lblSelectPilot.Size = New System.Drawing.Size(120, 25)
        Me.lblSelectPilot.TabIndex = 19
        Me.lblSelectPilot.Text = "Select Pilot: "
        '
        'cboSelectPilot
        '
        Me.cboSelectPilot.FormattingEnabled = True
        Me.cboSelectPilot.Location = New System.Drawing.Point(240, 102)
        Me.cboSelectPilot.Name = "cboSelectPilot"
        Me.cboSelectPilot.Size = New System.Drawing.Size(678, 32)
        Me.cboSelectPilot.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(255, 186)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(168, 48)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(47, 186)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(168, 48)
        Me.btnAddFlight.TabIndex = 16
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'lblSelectFlight
        '
        Me.lblSelectFlight.AutoSize = True
        Me.lblSelectFlight.Location = New System.Drawing.Point(42, 50)
        Me.lblSelectFlight.Name = "lblSelectFlight"
        Me.lblSelectFlight.Size = New System.Drawing.Size(130, 25)
        Me.lblSelectFlight.TabIndex = 15
        Me.lblSelectFlight.Text = "Select Flight: "
        '
        'cboSelectFlight
        '
        Me.cboSelectFlight.FormattingEnabled = True
        Me.cboSelectFlight.Location = New System.Drawing.Point(240, 50)
        Me.cboSelectFlight.Name = "cboSelectFlight"
        Me.cboSelectFlight.Size = New System.Drawing.Size(678, 32)
        Me.cboSelectFlight.TabIndex = 14
        '
        'frmAddPilotFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 301)
        Me.Controls.Add(Me.lblSelectPilot)
        Me.Controls.Add(Me.cboSelectPilot)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.lblSelectFlight)
        Me.Controls.Add(Me.cboSelectFlight)
        Me.Name = "frmAddPilotFlights"
        Me.Text = "Add Pilot Flights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectPilot As Label
    Friend WithEvents cboSelectPilot As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents lblSelectFlight As Label
    Friend WithEvents cboSelectFlight As ComboBox
End Class

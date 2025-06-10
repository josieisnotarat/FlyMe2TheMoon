<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFlight
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
        Me.lblFlightDate = New System.Windows.Forms.Label()
        Me.lblTimeOfDeparture = New System.Windows.Forms.Label()
        Me.lblTimeOfLanding = New System.Windows.Forms.Label()
        Me.dtmTimeOfDeparturePicker = New System.Windows.Forms.DateTimePicker()
        Me.dtmTimeOfLandingPicker = New System.Windows.Forms.DateTimePicker()
        Me.dtmFlightDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblFlightNumber = New System.Windows.Forms.Label()
        Me.txtFlightNumber = New System.Windows.Forms.TextBox()
        Me.lblFromAirport = New System.Windows.Forms.Label()
        Me.cboFromAirport = New System.Windows.Forms.ComboBox()
        Me.lblToAirport = New System.Windows.Forms.Label()
        Me.cboToAirport = New System.Windows.Forms.ComboBox()
        Me.lblPlane = New System.Windows.Forms.Label()
        Me.cboPlanes = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblMilesFlown = New System.Windows.Forms.Label()
        Me.txtMilesFlown = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFlightDate
        '
        Me.lblFlightDate.AutoSize = True
        Me.lblFlightDate.Location = New System.Drawing.Point(65, 71)
        Me.lblFlightDate.Name = "lblFlightDate"
        Me.lblFlightDate.Size = New System.Drawing.Size(111, 25)
        Me.lblFlightDate.TabIndex = 93
        Me.lblFlightDate.Text = "Flight Date:"
        '
        'lblTimeOfDeparture
        '
        Me.lblTimeOfDeparture.AutoSize = True
        Me.lblTimeOfDeparture.Location = New System.Drawing.Point(65, 202)
        Me.lblTimeOfDeparture.Name = "lblTimeOfDeparture"
        Me.lblTimeOfDeparture.Size = New System.Drawing.Size(179, 25)
        Me.lblTimeOfDeparture.TabIndex = 92
        Me.lblTimeOfDeparture.Text = "Time Of Departure:"
        '
        'lblTimeOfLanding
        '
        Me.lblTimeOfLanding.AutoSize = True
        Me.lblTimeOfLanding.Location = New System.Drawing.Point(65, 269)
        Me.lblTimeOfLanding.Name = "lblTimeOfLanding"
        Me.lblTimeOfLanding.Size = New System.Drawing.Size(163, 25)
        Me.lblTimeOfLanding.TabIndex = 91
        Me.lblTimeOfLanding.Text = "Time Of Landing:"
        '
        'dtmTimeOfDeparturePicker
        '
        Me.dtmTimeOfDeparturePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmTimeOfDeparturePicker.Location = New System.Drawing.Point(267, 198)
        Me.dtmTimeOfDeparturePicker.Name = "dtmTimeOfDeparturePicker"
        Me.dtmTimeOfDeparturePicker.Size = New System.Drawing.Size(179, 29)
        Me.dtmTimeOfDeparturePicker.TabIndex = 90
        '
        'dtmTimeOfLandingPicker
        '
        Me.dtmTimeOfLandingPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtmTimeOfLandingPicker.Location = New System.Drawing.Point(267, 265)
        Me.dtmTimeOfLandingPicker.Name = "dtmTimeOfLandingPicker"
        Me.dtmTimeOfLandingPicker.Size = New System.Drawing.Size(179, 29)
        Me.dtmTimeOfLandingPicker.TabIndex = 89
        '
        'dtmFlightDatePicker
        '
        Me.dtmFlightDatePicker.Location = New System.Drawing.Point(267, 71)
        Me.dtmFlightDatePicker.Name = "dtmFlightDatePicker"
        Me.dtmFlightDatePicker.Size = New System.Drawing.Size(331, 29)
        Me.dtmFlightDatePicker.TabIndex = 88
        '
        'lblFlightNumber
        '
        Me.lblFlightNumber.AutoSize = True
        Me.lblFlightNumber.Location = New System.Drawing.Point(65, 136)
        Me.lblFlightNumber.Name = "lblFlightNumber"
        Me.lblFlightNumber.Size = New System.Drawing.Size(139, 25)
        Me.lblFlightNumber.TabIndex = 87
        Me.lblFlightNumber.Text = "Flight Number:"
        '
        'txtFlightNumber
        '
        Me.txtFlightNumber.Location = New System.Drawing.Point(267, 132)
        Me.txtFlightNumber.Name = "txtFlightNumber"
        Me.txtFlightNumber.Size = New System.Drawing.Size(117, 29)
        Me.txtFlightNumber.TabIndex = 86
        '
        'lblFromAirport
        '
        Me.lblFromAirport.AutoSize = True
        Me.lblFromAirport.Location = New System.Drawing.Point(65, 341)
        Me.lblFromAirport.Name = "lblFromAirport"
        Me.lblFromAirport.Size = New System.Drawing.Size(125, 25)
        Me.lblFromAirport.TabIndex = 85
        Me.lblFromAirport.Text = "From Airport:"
        '
        'cboFromAirport
        '
        Me.cboFromAirport.FormattingEnabled = True
        Me.cboFromAirport.Location = New System.Drawing.Point(267, 334)
        Me.cboFromAirport.Name = "cboFromAirport"
        Me.cboFromAirport.Size = New System.Drawing.Size(262, 32)
        Me.cboFromAirport.TabIndex = 84
        '
        'lblToAirport
        '
        Me.lblToAirport.AutoSize = True
        Me.lblToAirport.Location = New System.Drawing.Point(65, 399)
        Me.lblToAirport.Name = "lblToAirport"
        Me.lblToAirport.Size = New System.Drawing.Size(104, 25)
        Me.lblToAirport.TabIndex = 99
        Me.lblToAirport.Text = "To Airport:"
        '
        'cboToAirport
        '
        Me.cboToAirport.FormattingEnabled = True
        Me.cboToAirport.Location = New System.Drawing.Point(267, 392)
        Me.cboToAirport.Name = "cboToAirport"
        Me.cboToAirport.Size = New System.Drawing.Size(262, 32)
        Me.cboToAirport.TabIndex = 98
        '
        'lblPlane
        '
        Me.lblPlane.AutoSize = True
        Me.lblPlane.Location = New System.Drawing.Point(65, 455)
        Me.lblPlane.Name = "lblPlane"
        Me.lblPlane.Size = New System.Drawing.Size(68, 25)
        Me.lblPlane.TabIndex = 101
        Me.lblPlane.Text = "Plane:"
        '
        'cboPlanes
        '
        Me.cboPlanes.FormattingEnabled = True
        Me.cboPlanes.Location = New System.Drawing.Point(267, 448)
        Me.cboPlanes.Name = "cboPlanes"
        Me.cboPlanes.Size = New System.Drawing.Size(262, 32)
        Me.cboPlanes.TabIndex = 100
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(376, 574)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(175, 40)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(92, 574)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(175, 40)
        Me.btnSubmit.TabIndex = 102
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblMilesFlown
        '
        Me.lblMilesFlown.AutoSize = True
        Me.lblMilesFlown.Location = New System.Drawing.Point(65, 512)
        Me.lblMilesFlown.Name = "lblMilesFlown"
        Me.lblMilesFlown.Size = New System.Drawing.Size(110, 25)
        Me.lblMilesFlown.TabIndex = 105
        Me.lblMilesFlown.Text = "MilesFlown"
        '
        'txtMilesFlown
        '
        Me.txtMilesFlown.Location = New System.Drawing.Point(267, 508)
        Me.txtMilesFlown.Name = "txtMilesFlown"
        Me.txtMilesFlown.Size = New System.Drawing.Size(117, 29)
        Me.txtMilesFlown.TabIndex = 104
        '
        'frmAddFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 672)
        Me.Controls.Add(Me.lblMilesFlown)
        Me.Controls.Add(Me.txtMilesFlown)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblPlane)
        Me.Controls.Add(Me.cboPlanes)
        Me.Controls.Add(Me.lblToAirport)
        Me.Controls.Add(Me.cboToAirport)
        Me.Controls.Add(Me.lblFlightDate)
        Me.Controls.Add(Me.lblTimeOfDeparture)
        Me.Controls.Add(Me.lblTimeOfLanding)
        Me.Controls.Add(Me.dtmTimeOfDeparturePicker)
        Me.Controls.Add(Me.dtmTimeOfLandingPicker)
        Me.Controls.Add(Me.dtmFlightDatePicker)
        Me.Controls.Add(Me.lblFlightNumber)
        Me.Controls.Add(Me.txtFlightNumber)
        Me.Controls.Add(Me.lblFromAirport)
        Me.Controls.Add(Me.cboFromAirport)
        Me.Name = "frmAddFlight"
        Me.Text = "Add Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFlightDate As Label
    Friend WithEvents lblTimeOfDeparture As Label
    Friend WithEvents lblTimeOfLanding As Label
    Friend WithEvents dtmTimeOfDeparturePicker As DateTimePicker
    Friend WithEvents dtmTimeOfLandingPicker As DateTimePicker
    Friend WithEvents dtmFlightDatePicker As DateTimePicker
    Friend WithEvents lblFlightNumber As Label
    Friend WithEvents txtFlightNumber As TextBox
    Friend WithEvents lblFromAirport As Label
    Friend WithEvents cboFromAirport As ComboBox
    Friend WithEvents lblToAirport As Label
    Friend WithEvents cboToAirport As ComboBox
    Friend WithEvents lblPlane As Label
    Friend WithEvents cboPlanes As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblMilesFlown As Label
    Friend WithEvents txtMilesFlown As TextBox
End Class

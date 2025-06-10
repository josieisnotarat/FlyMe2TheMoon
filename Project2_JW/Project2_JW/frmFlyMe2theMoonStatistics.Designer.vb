<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlyMe2theMoonStatistics
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
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.lblTotalFlightsTaken = New System.Windows.Forms.Label()
        Me.lstPilotMilesFlown = New System.Windows.Forms.ListBox()
        Me.lstAttendantMilesFlown = New System.Windows.Forms.ListBox()
        Me.lblAvgMilesForAllCustomers = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Location = New System.Drawing.Point(48, 55)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(162, 25)
        Me.lblTotalCustomers.TabIndex = 0
        Me.lblTotalCustomers.Text = "Total Customers:"
        '
        'lblTotalFlightsTaken
        '
        Me.lblTotalFlightsTaken.AutoSize = True
        Me.lblTotalFlightsTaken.Location = New System.Drawing.Point(432, 55)
        Me.lblTotalFlightsTaken.Name = "lblTotalFlightsTaken"
        Me.lblTotalFlightsTaken.Size = New System.Drawing.Size(185, 25)
        Me.lblTotalFlightsTaken.TabIndex = 1
        Me.lblTotalFlightsTaken.Text = "Total Flights Taken:"
        '
        'lstPilotMilesFlown
        '
        Me.lstPilotMilesFlown.FormattingEnabled = True
        Me.lstPilotMilesFlown.ItemHeight = 24
        Me.lstPilotMilesFlown.Location = New System.Drawing.Point(53, 129)
        Me.lstPilotMilesFlown.Name = "lstPilotMilesFlown"
        Me.lstPilotMilesFlown.Size = New System.Drawing.Size(660, 748)
        Me.lstPilotMilesFlown.TabIndex = 2
        '
        'lstAttendantMilesFlown
        '
        Me.lstAttendantMilesFlown.FormattingEnabled = True
        Me.lstAttendantMilesFlown.ItemHeight = 24
        Me.lstAttendantMilesFlown.Location = New System.Drawing.Point(810, 129)
        Me.lstAttendantMilesFlown.Name = "lstAttendantMilesFlown"
        Me.lstAttendantMilesFlown.Size = New System.Drawing.Size(660, 748)
        Me.lstAttendantMilesFlown.TabIndex = 3
        '
        'lblAvgMilesForAllCustomers
        '
        Me.lblAvgMilesForAllCustomers.AutoSize = True
        Me.lblAvgMilesForAllCustomers.Location = New System.Drawing.Point(914, 55)
        Me.lblAvgMilesForAllCustomers.Name = "lblAvgMilesForAllCustomers"
        Me.lblAvgMilesForAllCustomers.Size = New System.Drawing.Size(294, 25)
        Me.lblAvgMilesForAllCustomers.TabIndex = 4
        Me.lblAvgMilesForAllCustomers.Text = "Average Miles for all Customers:"
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(53, 919)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(1417, 50)
        Me.btnOkay.TabIndex = 5
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'frmFlyMe2theMoonStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1544, 994)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.lblAvgMilesForAllCustomers)
        Me.Controls.Add(Me.lstAttendantMilesFlown)
        Me.Controls.Add(Me.lstPilotMilesFlown)
        Me.Controls.Add(Me.lblTotalFlightsTaken)
        Me.Controls.Add(Me.lblTotalCustomers)
        Me.Name = "frmFlyMe2theMoonStatistics"
        Me.Text = "Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents lblTotalFlightsTaken As Label
    Friend WithEvents lstPilotMilesFlown As ListBox
    Friend WithEvents lstAttendantMilesFlown As ListBox
    Friend WithEvents lblAvgMilesForAllCustomers As Label
    Friend WithEvents btnOkay As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePilots
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
        Me.btnAddPilotFlights = New System.Windows.Forms.Button()
        Me.btnAddPilots = New System.Windows.Forms.Button()
        Me.btnDeletePilots = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPilotFlights
        '
        Me.btnAddPilotFlights.Location = New System.Drawing.Point(624, 49)
        Me.btnAddPilotFlights.Name = "btnAddPilotFlights"
        Me.btnAddPilotFlights.Size = New System.Drawing.Size(236, 53)
        Me.btnAddPilotFlights.TabIndex = 10
        Me.btnAddPilotFlights.Text = "Add Pilot Flights"
        Me.btnAddPilotFlights.UseVisualStyleBackColor = True
        '
        'btnAddPilots
        '
        Me.btnAddPilots.Location = New System.Drawing.Point(338, 49)
        Me.btnAddPilots.Name = "btnAddPilots"
        Me.btnAddPilots.Size = New System.Drawing.Size(236, 53)
        Me.btnAddPilots.TabIndex = 9
        Me.btnAddPilots.Text = "Add Pilots"
        Me.btnAddPilots.UseVisualStyleBackColor = True
        '
        'btnDeletePilots
        '
        Me.btnDeletePilots.Location = New System.Drawing.Point(49, 49)
        Me.btnDeletePilots.Name = "btnDeletePilots"
        Me.btnDeletePilots.Size = New System.Drawing.Size(236, 53)
        Me.btnDeletePilots.TabIndex = 8
        Me.btnDeletePilots.Text = "Delete Pilots"
        Me.btnDeletePilots.UseVisualStyleBackColor = True
        '
        'frmManagePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 154)
        Me.Controls.Add(Me.btnAddPilotFlights)
        Me.Controls.Add(Me.btnAddPilots)
        Me.Controls.Add(Me.btnDeletePilots)
        Me.Name = "frmManagePilots"
        Me.Text = "Manage Pilots"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPilotFlights As Button
    Friend WithEvents btnAddPilots As Button
    Friend WithEvents btnDeletePilots As Button
End Class

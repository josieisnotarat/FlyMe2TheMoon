<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAttendants
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
        Me.btnAddAttendantFlights = New System.Windows.Forms.Button()
        Me.btnAddAttendants = New System.Windows.Forms.Button()
        Me.btnDeleteAttendants = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddAttendantFlights
        '
        Me.btnAddAttendantFlights.Location = New System.Drawing.Point(616, 51)
        Me.btnAddAttendantFlights.Name = "btnAddAttendantFlights"
        Me.btnAddAttendantFlights.Size = New System.Drawing.Size(236, 53)
        Me.btnAddAttendantFlights.TabIndex = 13
        Me.btnAddAttendantFlights.Text = "Add Attendant Flights"
        Me.btnAddAttendantFlights.UseVisualStyleBackColor = True
        '
        'btnAddAttendants
        '
        Me.btnAddAttendants.Location = New System.Drawing.Point(330, 51)
        Me.btnAddAttendants.Name = "btnAddAttendants"
        Me.btnAddAttendants.Size = New System.Drawing.Size(236, 53)
        Me.btnAddAttendants.TabIndex = 12
        Me.btnAddAttendants.Text = "Add Attendants"
        Me.btnAddAttendants.UseVisualStyleBackColor = True
        '
        'btnDeleteAttendants
        '
        Me.btnDeleteAttendants.Location = New System.Drawing.Point(41, 51)
        Me.btnDeleteAttendants.Name = "btnDeleteAttendants"
        Me.btnDeleteAttendants.Size = New System.Drawing.Size(236, 53)
        Me.btnDeleteAttendants.TabIndex = 11
        Me.btnDeleteAttendants.Text = "Delete Attendants"
        Me.btnDeleteAttendants.UseVisualStyleBackColor = True
        '
        'frmManageAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 163)
        Me.Controls.Add(Me.btnAddAttendantFlights)
        Me.Controls.Add(Me.btnAddAttendants)
        Me.Controls.Add(Me.btnDeleteAttendants)
        Me.Name = "frmManageAttendants"
        Me.Text = "Manage Attendants"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddAttendantFlights As Button
    Friend WithEvents btnAddAttendants As Button
    Friend WithEvents btnDeleteAttendants As Button
End Class

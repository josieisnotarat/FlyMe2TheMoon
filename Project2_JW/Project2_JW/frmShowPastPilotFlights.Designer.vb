<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPastPilotFlights
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
        Me.lstResultSet = New System.Windows.Forms.ListBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResultSet
        '
        Me.lstResultSet.FormattingEnabled = True
        Me.lstResultSet.ItemHeight = 24
        Me.lstResultSet.Location = New System.Drawing.Point(51, 56)
        Me.lstResultSet.Name = "lstResultSet"
        Me.lstResultSet.Size = New System.Drawing.Size(1332, 628)
        Me.lstResultSet.TabIndex = 5
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(51, 730)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(1333, 51)
        Me.btnOkay.TabIndex = 4
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'frmShowPastPilotFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 855)
        Me.Controls.Add(Me.lstResultSet)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmShowPastPilotFlights"
        Me.Text = "Past Pilot Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstResultSet As ListBox
    Friend WithEvents btnOkay As Button
End Class

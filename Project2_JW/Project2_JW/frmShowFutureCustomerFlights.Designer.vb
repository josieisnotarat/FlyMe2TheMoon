<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowFutureCustomerFlights
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
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.lstResultSet = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(88, 721)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(1333, 51)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'lstResultSet
        '
        Me.lstResultSet.FormattingEnabled = True
        Me.lstResultSet.ItemHeight = 24
        Me.lstResultSet.Location = New System.Drawing.Point(88, 47)
        Me.lstResultSet.Name = "lstResultSet"
        Me.lstResultSet.Size = New System.Drawing.Size(1332, 628)
        Me.lstResultSet.TabIndex = 1
        '
        'frmShowFutureCustomerFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 812)
        Me.Controls.Add(Me.lstResultSet)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmShowFutureCustomerFlights"
        Me.Text = "Future Customer Flights"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOkay As Button
    Friend WithEvents lstResultSet As ListBox
End Class

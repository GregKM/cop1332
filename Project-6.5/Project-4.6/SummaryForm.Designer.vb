<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalWorkersTextBox = New System.Windows.Forms.TextBox()
        Me.TotalWorkersLabel = New System.Windows.Forms.Label()
        Me.AvgPayLabel = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.TotalNumLabel = New System.Windows.Forms.Label()
        Me.AvgPayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPiecesTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.TotalWorkersTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalWorkersLabel)
        Me.SummaryGroupBox.Controls.Add(Me.AvgPayLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPayLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalNumLabel)
        Me.SummaryGroupBox.Controls.Add(Me.AvgPayTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPayTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPiecesTextBox)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(2, 32)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(460, 198)
        Me.SummaryGroupBox.TabIndex = 8
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary"
        '
        'TotalWorkersTextBox
        '
        Me.TotalWorkersTextBox.Location = New System.Drawing.Point(128, 71)
        Me.TotalWorkersTextBox.Name = "TotalWorkersTextBox"
        Me.TotalWorkersTextBox.ReadOnly = True
        Me.TotalWorkersTextBox.Size = New System.Drawing.Size(132, 20)
        Me.TotalWorkersTextBox.TabIndex = 0
        '
        'TotalWorkersLabel
        '
        Me.TotalWorkersLabel.AutoSize = True
        Me.TotalWorkersLabel.Location = New System.Drawing.Point(5, 74)
        Me.TotalWorkersLabel.Name = "TotalWorkersLabel"
        Me.TotalWorkersLabel.Size = New System.Drawing.Size(77, 13)
        Me.TotalWorkersLabel.TabIndex = 6
        Me.TotalWorkersLabel.Text = "Total Workers:"
        '
        'AvgPayLabel
        '
        Me.AvgPayLabel.AutoSize = True
        Me.AvgPayLabel.Location = New System.Drawing.Point(5, 146)
        Me.AvgPayLabel.Name = "AvgPayLabel"
        Me.AvgPayLabel.Size = New System.Drawing.Size(86, 13)
        Me.AvgPayLabel.TabIndex = 5
        Me.AvgPayLabel.Text = "Average Payout:"
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.AutoSize = True
        Me.TotalPayLabel.Location = New System.Drawing.Point(5, 110)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(70, 13)
        Me.TotalPayLabel.TabIndex = 4
        Me.TotalPayLabel.Text = "Total Payout:"
        '
        'TotalNumLabel
        '
        Me.TotalNumLabel.AutoSize = True
        Me.TotalNumLabel.Location = New System.Drawing.Point(5, 38)
        Me.TotalNumLabel.Name = "TotalNumLabel"
        Me.TotalNumLabel.Size = New System.Drawing.Size(116, 13)
        Me.TotalNumLabel.TabIndex = 1
        Me.TotalNumLabel.Text = "Total Pieces Complete:"
        '
        'AvgPayTextBox
        '
        Me.AvgPayTextBox.Location = New System.Drawing.Point(128, 143)
        Me.AvgPayTextBox.Name = "AvgPayTextBox"
        Me.AvgPayTextBox.ReadOnly = True
        Me.AvgPayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.AvgPayTextBox.TabIndex = 2
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.Location = New System.Drawing.Point(128, 107)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TotalPayTextBox.TabIndex = 1
        '
        'TotalPiecesTextBox
        '
        Me.TotalPiecesTextBox.Location = New System.Drawing.Point(127, 35)
        Me.TotalPiecesTextBox.Name = "TotalPiecesTextBox"
        Me.TotalPiecesTextBox.ReadOnly = True
        Me.TotalPiecesTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TotalPiecesTextBox.TabIndex = 0
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 262)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SummaryForm"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TotalWorkersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalWorkersLabel As System.Windows.Forms.Label
    Friend WithEvents AvgPayLabel As System.Windows.Forms.Label
    Friend WithEvents TotalPayLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumLabel As System.Windows.Forms.Label
    Friend WithEvents AvgPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPiecesTextBox As System.Windows.Forms.TextBox
End Class

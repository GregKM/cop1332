<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordingStudioForm
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
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupNameLabel = New System.Windows.Forms.Label()
        Me.MinutesUsedTextBox = New System.Windows.Forms.TextBox()
        Me.MinutesUsedLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GroupChargeLabel = New System.Windows.Forms.Label()
        Me.GroupChargeTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvgGroupChargeTextBox = New System.Windows.Forms.TextBox()
        Me.TotalGroupNumTextBox = New System.Windows.Forms.TextBox()
        Me.TotalGroupChargesTextBox = New System.Windows.Forms.TextBox()
        Me.AvgGroupChargeLabel = New System.Windows.Forms.Label()
        Me.TotalNumGroupsLabel = New System.Windows.Forms.Label()
        Me.TotalGroupChargeLabel = New System.Windows.Forms.Label()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.Location = New System.Drawing.Point(119, 20)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(407, 20)
        Me.GroupNameTextBox.TabIndex = 0
        '
        'GroupNameLabel
        '
        Me.GroupNameLabel.AutoSize = True
        Me.GroupNameLabel.Location = New System.Drawing.Point(26, 23)
        Me.GroupNameLabel.Name = "GroupNameLabel"
        Me.GroupNameLabel.Size = New System.Drawing.Size(70, 13)
        Me.GroupNameLabel.TabIndex = 1
        Me.GroupNameLabel.Text = "Group Name:"
        '
        'MinutesUsedTextBox
        '
        Me.MinutesUsedTextBox.Location = New System.Drawing.Point(119, 47)
        Me.MinutesUsedTextBox.Name = "MinutesUsedTextBox"
        Me.MinutesUsedTextBox.Size = New System.Drawing.Size(241, 20)
        Me.MinutesUsedTextBox.TabIndex = 2
        '
        'MinutesUsedLabel
        '
        Me.MinutesUsedLabel.AutoSize = True
        Me.MinutesUsedLabel.Location = New System.Drawing.Point(26, 50)
        Me.MinutesUsedLabel.Name = "MinutesUsedLabel"
        Me.MinutesUsedLabel.Size = New System.Drawing.Size(75, 13)
        Me.MinutesUsedLabel.TabIndex = 3
        Me.MinutesUsedLabel.Text = "Minutes Used:"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(119, 118)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 4
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(285, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(451, 118)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GroupChargeLabel
        '
        Me.GroupChargeLabel.AutoSize = True
        Me.GroupChargeLabel.Location = New System.Drawing.Point(26, 201)
        Me.GroupChargeLabel.Name = "GroupChargeLabel"
        Me.GroupChargeLabel.Size = New System.Drawing.Size(76, 13)
        Me.GroupChargeLabel.TabIndex = 7
        Me.GroupChargeLabel.Text = "Group Charge:"
        '
        'GroupChargeTextBox
        '
        Me.GroupChargeTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.GroupChargeTextBox.Location = New System.Drawing.Point(119, 198)
        Me.GroupChargeTextBox.Name = "GroupChargeTextBox"
        Me.GroupChargeTextBox.ReadOnly = True
        Me.GroupChargeTextBox.Size = New System.Drawing.Size(241, 20)
        Me.GroupChargeTextBox.TabIndex = 8
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.AvgGroupChargeTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalGroupNumTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalGroupChargesTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.AvgGroupChargeLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalNumGroupsLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalGroupChargeLabel)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(34, 261)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(492, 159)
        Me.SummaryGroupBox.TabIndex = 9
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary Information"
        '
        'AvgGroupChargeTextBox
        '
        Me.AvgGroupChargeTextBox.Location = New System.Drawing.Point(120, 112)
        Me.AvgGroupChargeTextBox.Name = "AvgGroupChargeTextBox"
        Me.AvgGroupChargeTextBox.ReadOnly = True
        Me.AvgGroupChargeTextBox.Size = New System.Drawing.Size(241, 20)
        Me.AvgGroupChargeTextBox.TabIndex = 5
        '
        'TotalGroupNumTextBox
        '
        Me.TotalGroupNumTextBox.Location = New System.Drawing.Point(120, 71)
        Me.TotalGroupNumTextBox.Name = "TotalGroupNumTextBox"
        Me.TotalGroupNumTextBox.ReadOnly = True
        Me.TotalGroupNumTextBox.Size = New System.Drawing.Size(241, 20)
        Me.TotalGroupNumTextBox.TabIndex = 4
        '
        'TotalGroupChargesTextBox
        '
        Me.TotalGroupChargesTextBox.Location = New System.Drawing.Point(120, 31)
        Me.TotalGroupChargesTextBox.Name = "TotalGroupChargesTextBox"
        Me.TotalGroupChargesTextBox.ReadOnly = True
        Me.TotalGroupChargesTextBox.Size = New System.Drawing.Size(241, 20)
        Me.TotalGroupChargesTextBox.TabIndex = 3
        '
        'AvgGroupChargeLabel
        '
        Me.AvgGroupChargeLabel.AutoSize = True
        Me.AvgGroupChargeLabel.Location = New System.Drawing.Point(6, 115)
        Me.AvgGroupChargeLabel.Name = "AvgGroupChargeLabel"
        Me.AvgGroupChargeLabel.Size = New System.Drawing.Size(101, 13)
        Me.AvgGroupChargeLabel.TabIndex = 2
        Me.AvgGroupChargeLabel.Text = "Avg. Group Charge:"
        '
        'TotalNumGroupsLabel
        '
        Me.TotalNumGroupsLabel.AutoSize = True
        Me.TotalNumGroupsLabel.Location = New System.Drawing.Point(6, 74)
        Me.TotalNumGroupsLabel.Name = "TotalNumGroupsLabel"
        Me.TotalNumGroupsLabel.Size = New System.Drawing.Size(99, 13)
        Me.TotalNumGroupsLabel.TabIndex = 1
        Me.TotalNumGroupsLabel.Text = "Total Num. Groups:"
        '
        'TotalGroupChargeLabel
        '
        Me.TotalGroupChargeLabel.AutoSize = True
        Me.TotalGroupChargeLabel.Location = New System.Drawing.Point(6, 34)
        Me.TotalGroupChargeLabel.Name = "TotalGroupChargeLabel"
        Me.TotalGroupChargeLabel.Size = New System.Drawing.Size(108, 13)
        Me.TotalGroupChargeLabel.TabIndex = 0
        Me.TotalGroupChargeLabel.Text = "Total Group Charges:"
        '
        'RecordingStudioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 442)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.GroupChargeTextBox)
        Me.Controls.Add(Me.GroupChargeLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.MinutesUsedLabel)
        Me.Controls.Add(Me.MinutesUsedTextBox)
        Me.Controls.Add(Me.GroupNameLabel)
        Me.Controls.Add(Me.GroupNameTextBox)
        Me.Name = "RecordingStudioForm"
        Me.Text = "Recording Studio Calculator"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupNameLabel As System.Windows.Forms.Label
    Friend WithEvents MinutesUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinutesUsedLabel As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents GroupChargeLabel As System.Windows.Forms.Label
    Friend WithEvents GroupChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AvgGroupChargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalGroupNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalGroupChargesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AvgGroupChargeLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumGroupsLabel As System.Windows.Forms.Label
    Friend WithEvents TotalGroupChargeLabel As System.Windows.Forms.Label

End Class

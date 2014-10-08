<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PiecesTextBox = New System.Windows.Forms.TextBox()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.SumButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.AvgPayLabel = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.TotalNumLabel = New System.Windows.Forms.Label()
        Me.AvgPayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPiecesTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NumCompleteLabel = New System.Windows.Forms.Label()
        Me.EmpPayLabel = New System.Windows.Forms.Label()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(168, 26)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(261, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'PiecesTextBox
        '
        Me.PiecesTextBox.Location = New System.Drawing.Point(168, 59)
        Me.PiecesTextBox.Name = "PiecesTextBox"
        Me.PiecesTextBox.Size = New System.Drawing.Size(133, 20)
        Me.PiecesTextBox.TabIndex = 1
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(40, 118)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "Calc&ulate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'SumButton
        '
        Me.SumButton.Enabled = False
        Me.SumButton.Location = New System.Drawing.Point(168, 118)
        Me.SumButton.Name = "SumButton"
        Me.SumButton.Size = New System.Drawing.Size(75, 23)
        Me.SumButton.TabIndex = 3
        Me.SumButton.Text = "&Summary"
        Me.SumButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(296, 118)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(424, 118)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearAllButton.TabIndex = 5
        Me.ClearAllButton.Text = "Cl&ear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.AvgPayLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPayLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalNumLabel)
        Me.SummaryGroupBox.Controls.Add(Me.AvgPayTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPayTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalPiecesTextBox)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(40, 226)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(460, 150)
        Me.SummaryGroupBox.TabIndex = 7
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary"
        '
        'AvgPayLabel
        '
        Me.AvgPayLabel.AutoSize = True
        Me.AvgPayLabel.Location = New System.Drawing.Point(7, 109)
        Me.AvgPayLabel.Name = "AvgPayLabel"
        Me.AvgPayLabel.Size = New System.Drawing.Size(86, 13)
        Me.AvgPayLabel.TabIndex = 5
        Me.AvgPayLabel.Text = "&Average Payout:"
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.AutoSize = True
        Me.TotalPayLabel.Location = New System.Drawing.Point(7, 72)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(70, 13)
        Me.TotalPayLabel.TabIndex = 4
        Me.TotalPayLabel.Text = "Total &Payout:"
        '
        'TotalNumLabel
        '
        Me.TotalNumLabel.AutoSize = True
        Me.TotalNumLabel.Location = New System.Drawing.Point(7, 35)
        Me.TotalNumLabel.Name = "TotalNumLabel"
        Me.TotalNumLabel.Size = New System.Drawing.Size(116, 13)
        Me.TotalNumLabel.TabIndex = 1
        Me.TotalNumLabel.Text = "&Total Pieces Complete:"
        '
        'AvgPayTextBox
        '
        Me.AvgPayTextBox.Location = New System.Drawing.Point(128, 106)
        Me.AvgPayTextBox.Name = "AvgPayTextBox"
        Me.AvgPayTextBox.ReadOnly = True
        Me.AvgPayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.AvgPayTextBox.TabIndex = 2
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.Location = New System.Drawing.Point(128, 69)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TotalPayTextBox.TabIndex = 1
        '
        'TotalPiecesTextBox
        '
        Me.TotalPiecesTextBox.Location = New System.Drawing.Point(128, 32)
        Me.TotalPiecesTextBox.Name = "TotalPiecesTextBox"
        Me.TotalPiecesTextBox.ReadOnly = True
        Me.TotalPiecesTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TotalPiecesTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(37, 29)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(87, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Employee &Name:"
        '
        'NumCompleteLabel
        '
        Me.NumCompleteLabel.AutoSize = True
        Me.NumCompleteLabel.Location = New System.Drawing.Point(37, 62)
        Me.NumCompleteLabel.Name = "NumCompleteLabel"
        Me.NumCompleteLabel.Size = New System.Drawing.Size(95, 13)
        Me.NumCompleteLabel.TabIndex = 9
        Me.NumCompleteLabel.Text = "Pieces &Completed:"
        '
        'EmpPayLabel
        '
        Me.EmpPayLabel.AutoSize = True
        Me.EmpPayLabel.Location = New System.Drawing.Point(38, 180)
        Me.EmpPayLabel.Name = "EmpPayLabel"
        Me.EmpPayLabel.Size = New System.Drawing.Size(77, 13)
        Me.EmpPayLabel.TabIndex = 10
        Me.EmpPayLabel.Text = "&Employee Pay:"
        '
        'PayTextBox
        '
        Me.PayTextBox.Location = New System.Drawing.Point(169, 177)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.ReadOnly = True
        Me.PayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.PayTextBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 402)
        Me.Controls.Add(Me.PayTextBox)
        Me.Controls.Add(Me.EmpPayLabel)
        Me.Controls.Add(Me.NumCompleteLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SumButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.PiecesTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "MainForm"
        Me.Text = "Piecework Summary"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PiecesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents SumButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents SummaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AvgPayLabel As System.Windows.Forms.Label
    Friend WithEvents TotalPayLabel As System.Windows.Forms.Label
    Friend WithEvents TotalNumLabel As System.Windows.Forms.Label
    Friend WithEvents AvgPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPiecesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NumCompleteLabel As System.Windows.Forms.Label
    Friend WithEvents EmpPayLabel As System.Windows.Forms.Label
    Friend WithEvents PayTextBox As System.Windows.Forms.TextBox

End Class

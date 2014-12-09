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
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalWorkersTextBox = New System.Windows.Forms.TextBox()
        Me.TotalWorkersLabel = New System.Windows.Forms.Label()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatePayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SummaryGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(143, 47)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(261, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'PiecesTextBox
        '
        Me.PiecesTextBox.Location = New System.Drawing.Point(143, 80)
        Me.PiecesTextBox.Name = "PiecesTextBox"
        Me.PiecesTextBox.Size = New System.Drawing.Size(133, 20)
        Me.PiecesTextBox.TabIndex = 1
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
        Me.SummaryGroupBox.Location = New System.Drawing.Point(14, 167)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(460, 198)
        Me.SummaryGroupBox.TabIndex = 7
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
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 50)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(87, 13)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Employee Name:"
        '
        'NumCompleteLabel
        '
        Me.NumCompleteLabel.AutoSize = True
        Me.NumCompleteLabel.Location = New System.Drawing.Point(12, 83)
        Me.NumCompleteLabel.Name = "NumCompleteLabel"
        Me.NumCompleteLabel.Size = New System.Drawing.Size(95, 13)
        Me.NumCompleteLabel.TabIndex = 9
        Me.NumCompleteLabel.Text = "Pieces Completed:"
        '
        'EmpPayLabel
        '
        Me.EmpPayLabel.AutoSize = True
        Me.EmpPayLabel.Location = New System.Drawing.Point(12, 116)
        Me.EmpPayLabel.Name = "EmpPayLabel"
        Me.EmpPayLabel.Size = New System.Drawing.Size(77, 13)
        Me.EmpPayLabel.TabIndex = 10
        Me.EmpPayLabel.Text = "Employee Pay:"
        '
        'PayTextBox
        '
        Me.PayTextBox.Location = New System.Drawing.Point(143, 113)
        Me.PayTextBox.Name = "PayTextBox"
        Me.PayTextBox.ReadOnly = True
        Me.PayTextBox.Size = New System.Drawing.Size(133, 20)
        Me.PayTextBox.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatePayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculatePayToolStripMenuItem
        '
        Me.CalculatePayToolStripMenuItem.Name = "CalculatePayToolStripMenuItem"
        Me.CalculatePayToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CalculatePayToolStripMenuItem.Text = "&Calculate Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ClearAllToolStripMenuItem.Text = "Cl&ear All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.FontToolStripMenuItem.Text = "&Font..."
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ColorToolStripMenuItem.Text = "&Color..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 377)
        Me.Controls.Add(Me.PayTextBox)
        Me.Controls.Add(Me.EmpPayLabel)
        Me.Controls.Add(Me.NumCompleteLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.PiecesTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piecework Summary"
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PiecesTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatePayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents TotalWorkersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalWorkersLabel As System.Windows.Forms.Label

End Class

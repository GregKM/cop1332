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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SoldLabel = New System.Windows.Forms.Label()
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.PricesButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.SoldTextBox = New System.Windows.Forms.TextBox()
        Me.SectionComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'SoldLabel
        '
        Me.SoldLabel.AutoSize = True
        Me.SoldLabel.Location = New System.Drawing.Point(13, 13)
        Me.SoldLabel.Name = "SoldLabel"
        Me.SoldLabel.Size = New System.Drawing.Size(71, 13)
        Me.SoldLabel.TabIndex = 0
        Me.SoldLabel.Text = "Number Sold:"
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(13, 53)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(46, 13)
        Me.SectionLabel.TabIndex = 1
        Me.SectionLabel.Text = "Section:"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(91, 93)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(20, 143)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(34, 13)
        Me.PriceLabel.TabIndex = 3
        Me.PriceLabel.Text = "Price:"
        '
        'PricesButton
        '
        Me.PricesButton.Location = New System.Drawing.Point(251, 51)
        Me.PricesButton.Name = "PricesButton"
        Me.PricesButton.Size = New System.Drawing.Size(75, 23)
        Me.PricesButton.TabIndex = 4
        Me.PricesButton.Text = "Show Prices"
        Me.PricesButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(251, 87)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 35)
        Me.SummaryButton.TabIndex = 5
        Me.SummaryButton.Text = "Print Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'SoldTextBox
        '
        Me.SoldTextBox.Location = New System.Drawing.Point(91, 13)
        Me.SoldTextBox.Name = "SoldTextBox"
        Me.SoldTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SoldTextBox.TabIndex = 6
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.SectionComboBox.Location = New System.Drawing.Point(91, 53)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SectionComboBox.TabIndex = 7
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(91, 140)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 8
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(251, 138)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 177)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.SectionComboBox)
        Me.Controls.Add(Me.SoldTextBox)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.PricesButton)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.SectionLabel)
        Me.Controls.Add(Me.SoldLabel)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Club Ticket Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoldLabel As System.Windows.Forms.Label
    Friend WithEvents SectionLabel As System.Windows.Forms.Label
    Friend WithEvents CalcButton As System.Windows.Forms.Button
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents PricesButton As System.Windows.Forms.Button
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents SoldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class

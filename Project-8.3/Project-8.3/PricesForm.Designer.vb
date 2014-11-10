<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PricesForm
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
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.SectionComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(13, 16)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(46, 13)
        Me.SectionLabel.TabIndex = 0
        Me.SectionLabel.Text = "Section:"
        '
        'SectionComboBox
        '
        Me.SectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionComboBox.FormattingEnabled = True
        Me.SectionComboBox.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.SectionComboBox.Location = New System.Drawing.Point(70, 13)
        Me.SectionComboBox.Name = "SectionComboBox"
        Me.SectionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SectionComboBox.TabIndex = 8
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(16, 67)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(34, 13)
        Me.PriceLabel.TabIndex = 9
        Me.PriceLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(70, 64)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 10
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(237, 61)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'PricesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 102)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.SectionComboBox)
        Me.Controls.Add(Me.SectionLabel)
        Me.Name = "PricesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section Prices Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SectionLabel As System.Windows.Forms.Label
    Friend WithEvents SectionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class

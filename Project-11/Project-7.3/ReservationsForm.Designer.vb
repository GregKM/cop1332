<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationsForm
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
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.PartyLabel = New System.Windows.Forms.Label()
        Me.HoursLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.SizeLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.CommentsLabel = New System.Windows.Forms.Label()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.PartyTextBox = New System.Windows.Forms.TextBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.SizeTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(12, 27)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(33, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "Date:"
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Location = New System.Drawing.Point(12, 71)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(34, 13)
        Me.PartyLabel.TabIndex = 3
        Me.PartyLabel.Text = "Party:"
        '
        'HoursLabel
        '
        Me.HoursLabel.AutoSize = True
        Me.HoursLabel.Location = New System.Drawing.Point(12, 115)
        Me.HoursLabel.Name = "HoursLabel"
        Me.HoursLabel.Size = New System.Drawing.Size(38, 13)
        Me.HoursLabel.TabIndex = 5
        Me.HoursLabel.Text = "Hours:"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(12, 159)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(34, 13)
        Me.TypeLabel.TabIndex = 7
        Me.TypeLabel.Text = "Type:"
        '
        'SizeLabel
        '
        Me.SizeLabel.AutoSize = True
        Me.SizeLabel.Location = New System.Drawing.Point(12, 203)
        Me.SizeLabel.Name = "SizeLabel"
        Me.SizeLabel.Size = New System.Drawing.Size(30, 13)
        Me.SizeLabel.TabIndex = 9
        Me.SizeLabel.Text = "Size:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(12, 247)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(34, 13)
        Me.PriceLabel.TabIndex = 11
        Me.PriceLabel.Text = "Price:"
        '
        'CommentsLabel
        '
        Me.CommentsLabel.AutoSize = True
        Me.CommentsLabel.Location = New System.Drawing.Point(12, 291)
        Me.CommentsLabel.Name = "CommentsLabel"
        Me.CommentsLabel.Size = New System.Drawing.Size(59, 13)
        Me.CommentsLabel.TabIndex = 13
        Me.CommentsLabel.Text = "Comments:"
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.Location = New System.Drawing.Point(77, 288)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.ReadOnly = True
        Me.CommentsTextBox.Size = New System.Drawing.Size(330, 20)
        Me.CommentsTextBox.TabIndex = 14
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(77, 24)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.ReadOnly = True
        Me.DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateTextBox.TabIndex = 16
        '
        'PartyTextBox
        '
        Me.PartyTextBox.Location = New System.Drawing.Point(77, 68)
        Me.PartyTextBox.Name = "PartyTextBox"
        Me.PartyTextBox.ReadOnly = True
        Me.PartyTextBox.Size = New System.Drawing.Size(175, 20)
        Me.PartyTextBox.TabIndex = 18
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(77, 112)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.ReadOnly = True
        Me.HoursTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoursTextBox.TabIndex = 20
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(77, 156)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.ReadOnly = True
        Me.TypeTextBox.Size = New System.Drawing.Size(175, 20)
        Me.TypeTextBox.TabIndex = 22
        '
        'SizeTextBox
        '
        Me.SizeTextBox.Location = New System.Drawing.Point(77, 200)
        Me.SizeTextBox.Name = "SizeTextBox"
        Me.SizeTextBox.ReadOnly = True
        Me.SizeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SizeTextBox.TabIndex = 24
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(77, 244)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 26
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(332, 200)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 27
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(332, 236)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 28
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ReservationsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 332)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.SizeTextBox)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.HoursTextBox)
        Me.Controls.Add(Me.PartyTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.CommentsTextBox)
        Me.Controls.Add(Me.CommentsLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.SizeLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.HoursLabel)
        Me.Controls.Add(Me.PartyLabel)
        Me.Controls.Add(Me.DateLabel)
        Me.Name = "ReservationsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents PartyLabel As System.Windows.Forms.Label
    Friend WithEvents HoursLabel As System.Windows.Forms.Label
    Friend WithEvents TypeLabel As System.Windows.Forms.Label
    Friend WithEvents SizeLabel As System.Windows.Forms.Label
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents CommentsLabel As System.Windows.Forms.Label
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PartyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class

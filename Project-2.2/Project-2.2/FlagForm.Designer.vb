<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlagForm
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgramLabel = New System.Windows.Forms.Label()
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox()
        Me.MXRadioButton = New System.Windows.Forms.RadioButton()
        Me.CARadioButton = New System.Windows.Forms.RadioButton()
        Me.JPRadioButton = New System.Windows.Forms.RadioButton()
        Me.USRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox()
        Me.CountryCheckBox = New System.Windows.Forms.CheckBox()
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CountryGroupBox.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgramLabel
        '
        Me.ProgramLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramLabel.Location = New System.Drawing.Point(170, 9)
        Me.ProgramLabel.Name = "ProgramLabel"
        Me.ProgramLabel.Size = New System.Drawing.Size(285, 63)
        Me.ProgramLabel.TabIndex = 5
        Me.ProgramLabel.Text = "Flag Viewer"
        Me.ProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.ProgramLabel, "Program Title")
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.MXRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.CARadioButton)
        Me.CountryGroupBox.Controls.Add(Me.JPRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.USRadioButton)
        Me.CountryGroupBox.Location = New System.Drawing.Point(21, 97)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Size = New System.Drawing.Size(154, 197)
        Me.CountryGroupBox.TabIndex = 1
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        '
        'MXRadioButton
        '
        Me.MXRadioButton.AutoSize = True
        Me.MXRadioButton.Location = New System.Drawing.Point(6, 145)
        Me.MXRadioButton.Name = "MXRadioButton"
        Me.MXRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.MXRadioButton.TabIndex = 3
        Me.MXRadioButton.TabStop = True
        Me.MXRadioButton.Text = "&Mexico"
        Me.ToolTip1.SetToolTip(Me.MXRadioButton, "Show Mexican Flag")
        Me.MXRadioButton.UseVisualStyleBackColor = True
        '
        'CARadioButton
        '
        Me.CARadioButton.AutoSize = True
        Me.CARadioButton.Location = New System.Drawing.Point(6, 103)
        Me.CARadioButton.Name = "CARadioButton"
        Me.CARadioButton.Size = New System.Drawing.Size(62, 17)
        Me.CARadioButton.TabIndex = 2
        Me.CARadioButton.TabStop = True
        Me.CARadioButton.Text = "&Canada"
        Me.ToolTip1.SetToolTip(Me.CARadioButton, "Show Canadian Flag")
        Me.CARadioButton.UseVisualStyleBackColor = True
        '
        'JPRadioButton
        '
        Me.JPRadioButton.AutoSize = True
        Me.JPRadioButton.Location = New System.Drawing.Point(6, 61)
        Me.JPRadioButton.Name = "JPRadioButton"
        Me.JPRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.JPRadioButton.TabIndex = 1
        Me.JPRadioButton.TabStop = True
        Me.JPRadioButton.Text = "&Japan"
        Me.ToolTip1.SetToolTip(Me.JPRadioButton, "Show Japanese Flag")
        Me.JPRadioButton.UseVisualStyleBackColor = True
        '
        'USRadioButton
        '
        Me.USRadioButton.AutoSize = True
        Me.USRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.USRadioButton.Name = "USRadioButton"
        Me.USRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.USRadioButton.TabIndex = 0
        Me.USRadioButton.TabStop = True
        Me.USRadioButton.Text = "&United States"
        Me.ToolTip1.SetToolTip(Me.USRadioButton, "Show United States Flag")
        Me.USRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.ProgrammerCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.CountryCheckBox)
        Me.DisplayGroupBox.Controls.Add(Me.TitleCheckBox)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(457, 97)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(144, 155)
        Me.DisplayGroupBox.TabIndex = 2
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display"
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Checked = True
        Me.ProgrammerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(6, 102)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.ProgrammerCheckBox.TabIndex = 2
        Me.ProgrammerCheckBox.Text = "&Programmer"
        Me.ToolTip1.SetToolTip(Me.ProgrammerCheckBox, "Show Programmer Label")
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'CountryCheckBox
        '
        Me.CountryCheckBox.AutoSize = True
        Me.CountryCheckBox.Checked = True
        Me.CountryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CountryCheckBox.Location = New System.Drawing.Point(6, 61)
        Me.CountryCheckBox.Name = "CountryCheckBox"
        Me.CountryCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.CountryCheckBox.TabIndex = 1
        Me.CountryCheckBox.Text = "Country &Name"
        Me.ToolTip1.SetToolTip(Me.CountryCheckBox, "Show Country Names")
        Me.CountryCheckBox.UseVisualStyleBackColor = True
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Checked = True
        Me.TitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TitleCheckBox.Location = New System.Drawing.Point(6, 20)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.TitleCheckBox.TabIndex = 0
        Me.TitleCheckBox.Text = "&Title"
        Me.ToolTip1.SetToolTip(Me.TitleCheckBox, "Show Program Title")
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'CountryLabel
        '
        Me.CountryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryLabel.Location = New System.Drawing.Point(181, 292)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(274, 30)
        Me.CountryLabel.TabIndex = 3
        Me.CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProgrammerLabel.Location = New System.Drawing.Point(23, 382)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(152, 30)
        Me.ProgrammerLabel.TabIndex = 4
        Me.ProgrammerLabel.Text = "Programmed by: G. Mathews"
        Me.ProgrammerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.Location = New System.Drawing.Point(228, 132)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(180, 120)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 5
        Me.FlagPictureBox.TabStop = False
        Me.FlagPictureBox.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(526, 389)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "End the Program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FlagForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.CountryLabel)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Controls.Add(Me.ProgramLabel)
        Me.Name = "FlagForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flag Viewer"
        Me.CountryGroupBox.ResumeLayout(False)
        Me.CountryGroupBox.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgramLabel As System.Windows.Forms.Label
    Friend WithEvents CountryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DisplayGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CountryLabel As System.Windows.Forms.Label
    Friend WithEvents MXRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CARadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JPRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents USRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents FlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class

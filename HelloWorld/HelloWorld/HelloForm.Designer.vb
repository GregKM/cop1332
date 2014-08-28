<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloForm
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
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.PushButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SpanishButton = New System.Windows.Forms.Button()
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.ItalianButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(22, 45)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(257, 20)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PushButton
        '
        Me.PushButton.Location = New System.Drawing.Point(22, 136)
        Me.PushButton.Name = "PushButton"
        Me.PushButton.Size = New System.Drawing.Size(75, 23)
        Me.PushButton.TabIndex = 1
        Me.PushButton.Text = "English"
        Me.PushButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(114, 204)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "by Gregory Mathews"
        '
        'SpanishButton
        '
        Me.SpanishButton.Location = New System.Drawing.Point(22, 165)
        Me.SpanishButton.Name = "SpanishButton"
        Me.SpanishButton.Size = New System.Drawing.Size(75, 23)
        Me.SpanishButton.TabIndex = 4
        Me.SpanishButton.Text = "Spanish"
        Me.SpanishButton.UseVisualStyleBackColor = True
        '
        'FrenchButton
        '
        Me.FrenchButton.Location = New System.Drawing.Point(204, 136)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(75, 23)
        Me.FrenchButton.TabIndex = 5
        Me.FrenchButton.Text = "French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'ItalianButton
        '
        Me.ItalianButton.Location = New System.Drawing.Point(204, 165)
        Me.ItalianButton.Name = "ItalianButton"
        Me.ItalianButton.Size = New System.Drawing.Size(75, 23)
        Me.ItalianButton.TabIndex = 6
        Me.ItalianButton.Text = "Italian"
        Me.ItalianButton.UseVisualStyleBackColor = True
        '
        'HelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 257)
        Me.Controls.Add(Me.ItalianButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.SpanishButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PushButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Name = "HelloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World by Gregory Mathews"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PushButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SpanishButton As System.Windows.Forms.Button
    Friend WithEvents FrenchButton As System.Windows.Forms.Button
    Friend WithEvents ItalianButton As System.Windows.Forms.Button

End Class

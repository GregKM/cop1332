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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PiecesTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NumCompleteLabel = New System.Windows.Forms.Label()
        Me.EmpPayLabel = New System.Windows.Forms.Label()
        Me.PayTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatePayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SloganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.SloganLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatePayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.LogoToolStripMenuItem, Me.SloganToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculatePayToolStripMenuItem
        '
        Me.CalculatePayToolStripMenuItem.Name = "CalculatePayToolStripMenuItem"
        Me.CalculatePayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculatePayToolStripMenuItem.Text = "&Calculate Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'LogoToolStripMenuItem
        '
        Me.LogoToolStripMenuItem.Checked = True
        Me.LogoToolStripMenuItem.CheckOnClick = True
        Me.LogoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LogoToolStripMenuItem.Name = "LogoToolStripMenuItem"
        Me.LogoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoToolStripMenuItem.Text = "&Logo"
        '
        'SloganToolStripMenuItem
        '
        Me.SloganToolStripMenuItem.Checked = True
        Me.SloganToolStripMenuItem.CheckOnClick = True
        Me.SloganToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SloganToolStripMenuItem.Name = "SloganToolStripMenuItem"
        Me.SloganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SloganToolStripMenuItem.Text = "&Slogan"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(15, 178)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(261, 174)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 12
        Me.LogoPictureBox.TabStop = False
        '
        'SloganLabel
        '
        Me.SloganLabel.AutoSize = True
        Me.SloganLabel.Location = New System.Drawing.Point(282, 339)
        Me.SloganLabel.Name = "SloganLabel"
        Me.SloganLabel.Size = New System.Drawing.Size(127, 13)
        Me.SloganLabel.TabIndex = 13
        Me.SloganLabel.Text = "We Literally Do Not Exist!"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 377)
        Me.Controls.Add(Me.SloganLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.PayTextBox)
        Me.Controls.Add(Me.EmpPayLabel)
        Me.Controls.Add(Me.NumCompleteLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PiecesTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piecework Summary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PiecesTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents LogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SloganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SloganLabel As System.Windows.Forms.Label

End Class

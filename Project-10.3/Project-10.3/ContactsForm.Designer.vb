<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactsForm
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
        Dim PubIDLabel As System.Windows.Forms.Label
        Dim Company_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim TelephoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsDataSet = New Project_10._3.ContactsDataSet()
        Me.PublishersTableAdapter = New Project_10._3.ContactsDataSetTableAdapters.PublishersTableAdapter()
        Me.TableAdapterManager = New Project_10._3.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.PubIDTextBox = New System.Windows.Forms.TextBox()
        Me.Company_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        PubIDLabel = New System.Windows.Forms.Label()
        Company_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        TelephoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "Publishers"
        Me.PublishersBindingSource.DataSource = Me.ContactsDataSet
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PublishersTableAdapter = Me.PublishersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_10._3.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PubIDLabel
        '
        PubIDLabel.AutoSize = True
        PubIDLabel.Location = New System.Drawing.Point(12, 42)
        PubIDLabel.Name = "PubIDLabel"
        PubIDLabel.Size = New System.Drawing.Size(43, 13)
        PubIDLabel.TabIndex = 0
        PubIDLabel.Text = "Pub ID:"
        '
        'PubIDTextBox
        '
        Me.PubIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "PubID", True))
        Me.PubIDTextBox.Location = New System.Drawing.Point(108, 39)
        Me.PubIDTextBox.Name = "PubIDTextBox"
        Me.PubIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PubIDTextBox.TabIndex = 1
        '
        'Company_NameLabel
        '
        Company_NameLabel.AutoSize = True
        Company_NameLabel.Location = New System.Drawing.Point(12, 110)
        Company_NameLabel.Name = "Company_NameLabel"
        Company_NameLabel.Size = New System.Drawing.Size(85, 13)
        Company_NameLabel.TabIndex = 4
        Company_NameLabel.Text = "Company Name:"
        '
        'Company_NameTextBox
        '
        Me.Company_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Company Name", True))
        Me.Company_NameTextBox.Location = New System.Drawing.Point(108, 107)
        Me.Company_NameTextBox.Name = "Company_NameTextBox"
        Me.Company_NameTextBox.Size = New System.Drawing.Size(350, 20)
        Me.Company_NameTextBox.TabIndex = 5
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 144)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(108, 141)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(350, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 178)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(108, 171)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(350, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(12, 212)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(108, 205)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(350, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(12, 246)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(108, 239)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(350, 20)
        Me.ZipTextBox.TabIndex = 13
        '
        'TelephoneLabel
        '
        TelephoneLabel.AutoSize = True
        TelephoneLabel.Location = New System.Drawing.Point(12, 280)
        TelephoneLabel.Name = "TelephoneLabel"
        TelephoneLabel.Size = New System.Drawing.Size(61, 13)
        TelephoneLabel.TabIndex = 14
        TelephoneLabel.Text = "Telephone:"
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Telephone", True))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(108, 273)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(350, 20)
        Me.TelephoneTextBox.TabIndex = 15
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(12, 314)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 16
        FaxLabel.Text = "Fax:"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(108, 307)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(350, 20)
        Me.FaxTextBox.TabIndex = 17
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(12, 76)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(38, 13)
        NameLabel1.TabIndex = 17
        NameLabel1.Text = "Name:"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "Name", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.NameComboBox.DataSource = Me.PublishersBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(108, 73)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(350, 21)
        Me.NameComboBox.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ContactsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 342)
        Me.Controls.Add(NameLabel1)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(TelephoneLabel)
        Me.Controls.Add(Me.TelephoneTextBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Company_NameLabel)
        Me.Controls.Add(Me.Company_NameTextBox)
        Me.Controls.Add(PubIDLabel)
        Me.Controls.Add(Me.PubIDTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ContactsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactsDataSet As Project_10._3.ContactsDataSet
    Friend WithEvents PublishersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublishersTableAdapter As Project_10._3.ContactsDataSetTableAdapters.PublishersTableAdapter
    Friend WithEvents TableAdapterManager As Project_10._3.ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PubIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Company_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

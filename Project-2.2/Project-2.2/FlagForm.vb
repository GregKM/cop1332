'Project:       2.2
'Programmer:    Gregory Mathews
'Date:          September 2014
'Description:   Allows a user to select a country and display the country flag.

Public Class FlagForm

    Private Sub TitleCheckBox_CheckedChanged(ByVal sender As System.Object, e As System.EventArgs) Handles TitleCheckBox.CheckedChanged

        'If TitleCheckBox.Checked = True Then
        '    ProgramLabel.Visible = True
        'Else
        '    ProgramLabel.Visible = False
        'End If

        ProgramLabel.Visible = TitleCheckBox.Checked

    End Sub

    Private Sub CountryCheckBox_CheckedChanged(ByVal sender As System.Object, e As System.EventArgs) Handles CountryCheckBox.CheckedChanged

        'If CountryCheckBox.Checked = True Then
        '    CountryLabel.Visible = True
        'Else
        '    CountryLabel.Visible = False
        'End If

        CountryLabel.Visible = CountryCheckBox.Checked

    End Sub

    Private Sub ProgrammerCheckBox_CheckedChanged(ByVal sender As System.Object, e As System.EventArgs) Handles ProgrammerCheckBox.CheckedChanged

        'If ProgrammerCheckBox.Checked = True Then
        '    ProgrammerLabel.Visible = True
        'Else
        '    ProgrammerLabel.Visible = False
        'End If

        ProgrammerLabel.Visible = ProgrammerCheckBox.Checked

    End Sub

    Private Sub USRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USRadioButton.CheckedChanged

        CountryLabel.Text = "United States"
        With FlagPictureBox
            .Visible = True
            .Image = My.Resources.USFlag
        End With

    End Sub

    Private Sub JPRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JPRadioButton.CheckedChanged

        CountryLabel.Text = "Japan"
        With FlagPictureBox
            .Visible = True
            .Image = My.Resources.JPFlag
        End With

    End Sub

    Private Sub CARadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARadioButton.CheckedChanged

        CountryLabel.Text = "Canada"
        With FlagPictureBox
            .Visible = True
            .Image = My.Resources.CAFlag
        End With

    End Sub

    Private Sub MXRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MXRadioButton.CheckedChanged

        CountryLabel.Text = "Mexico"
        With FlagPictureBox
            .Visible = True
            .Image = My.Resources.MXFlag
        End With

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

End Class
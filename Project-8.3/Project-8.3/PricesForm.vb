Public Class PricesForm

    Private Sub SectionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectionComboBox.SelectedIndexChanged

        Dim IndexInteger As Integer

        IndexInteger = SectionComboBox.SelectedIndex
        PriceTextBox.Text = (MainForm.PricesDecimal(IndexInteger)).ToString("C")

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub
End Class
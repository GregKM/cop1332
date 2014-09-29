Public Class RecordingStudioForm

    Const RentCost As Decimal = 200
    Dim PricePerMin As Decimal = RentCost / 60
    Dim TotalChargeAll As Decimal
    Dim TotalNumGroups As Integer
    Dim AvgGroupCharge As Decimal

    Dim MinutesUsed As Integer
    Dim GroupCharge As Decimal

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        Try
            MinutesUsed = Integer.Parse(MinutesUsedTextBox.Text)
        Catch ex As FormatException
            MessageBox.Show("Please input a numeric amount for Minutes Used field. Try again.", "Invalid Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        GroupCharge = MinutesUsed * PricePerMin
        GroupChargeTextBox.Text = GroupCharge.ToString("C")

        TotalChargeAll = TotalChargeAll + GroupCharge
        TotalGroupChargesTextBox.Text = TotalChargeAll.ToString("C")

        TotalNumGroups = TotalNumGroups + 1
        TotalGroupNumTextBox.Text = TotalNumGroups.ToString()

        AvgGroupCharge = TotalChargeAll / TotalNumGroups
        AvgGroupChargeTextBox.Text = AvgGroupCharge.ToString("C")

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        MinutesUsedTextBox.Clear()
        GroupChargeTextBox.Clear()
        TotalGroupChargesTextBox.Clear()
        TotalGroupNumTextBox.Clear()
        AvgGroupChargeTextBox.Clear()
        With GroupNameTextBox
            .Clear()
            .Focus()
        End With

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub
End Class

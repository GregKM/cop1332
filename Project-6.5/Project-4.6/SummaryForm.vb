Public Class SummaryForm

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ' Use ToString method to display totals in all summary text boxes
        TotalPiecesTextBox.Text = MainForm.TotalComplete.ToString
        TotalPayTextBox.Text = MainForm.TotalPay.ToString("C")
        TotalWorkersTextBox.Text = MainForm.TotalWorkers.ToString
        AvgPayTextBox.Text = Average.ToString("C")

    End Sub


    Private Function Average() As Decimal
        ' Calculate the average payout

        Average = MainForm.TotalPay / MainForm.TotalWorkers

    End Function
End Class
' Programmer: Gregory Mathews
' Project: Chapter 4, Exercise 6
' Description: Program calculates amount to be paid based on units completed and displays summary totals

Public Class MainForm

    ' Define working variables for storage
    Dim NumCompleted As Integer
    Dim PricePaid As Decimal
    Dim EmpPay As Decimal

    ' Define variables for summary totals
    Dim TotalComplete As Integer
    Dim TotalPay As Decimal
    Dim AvgPay As Decimal
    Dim TotalWorkers As Integer

    ' Define variables for message box strings
    Dim NoData As String = "Data entry error. No data entered."
    Dim InvData As String = "Invalid data entered. Please try again."

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        ' Catch error where no data is entered for name or number of pieces
        If NameTextBox.Text = "" Or PiecesTextBox.Text = "" Then
            MessageBox.Show(NoData, "Data Error", MessageBoxButtons.OK)
            NameTextBox.Focus()
        Else
            ' Enable Summary Button now that we are calculating our first total
            SumButton.Enabled = True

            ' Use Try/Catch to catch invalid data format exception
            Try
                NumCompleted = Integer.Parse(PiecesTextBox.Text)
            Catch ex As FormatException
                MessageBox.Show(InvData, "Invalid Data Format", MessageBoxButtons.OK)
                PiecesTextBox.Focus()
            End Try

            ' Case statement to determine price level paid to employee by units completed
            Select Case NumCompleted
                Case Is >= 600
                    PricePaid = 0.65
                Case 400 To 599
                    PricePaid = 0.6
                Case 200 To 399
                    PricePaid = 0.55
                Case 1 To 199
                    PricePaid = 0.5
                Case Else
                    MessageBox.Show(InvData, "Invalid Data", MessageBoxButtons.OK)
                    PiecesTextBox.Focus()
            End Select

            ' Calculate current and store current employee payout
            EmpPay = NumCompleted * PricePaid

            ' Increment totals for both total pay and total completed units
            TotalPay += EmpPay
            TotalComplete += NumCompleted
            TotalWorkers += 1

            ' Use ToString method to display employee pay in the pay text box as currency
            PayTextBox.Text = EmpPay.ToString("C")

        End If

    End Sub

    Private Sub SumButton_Click(sender As Object, e As EventArgs) Handles SumButton.Click

        ' Calculate and store total average pay for all employees
        AvgPay = TotalPay / TotalWorkers

        ' Use ToString method to display totals in all summary text boxes
        TotalPiecesTextBox.Text = TotalComplete.ToString
        TotalPayTextBox.Text = TotalPay.ToString("C")
        AvgPayTextBox.Text = AvgPay.ToString("C")

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        ' Clear all employee text boxes and move focus back to Name text box
        NameTextBox.Clear()
        PiecesTextBox.Clear()
        PayTextBox.Clear()
        NameTextBox.Focus()

    End Sub

    Private Sub ClearAllButton_Click(sender As Object, e As EventArgs) Handles ClearAllButton.Click

        ' Show message box confirming that user wishes to clear all summary totals
        Dim result As DialogResult = MessageBox.Show("Clear all summary data?", "Confirm Clear", MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then
            MessageBox.Show("Clear action aborted")
        Else
            ' Reset all variable totals to 0
            TotalComplete = 0
            TotalPay = 0
            AvgPay = 0

            ' Clear all summary total text boxes and return focus to Name text box
            TotalPiecesTextBox.Clear()
            TotalPayTextBox.Clear()
            AvgPayTextBox.Clear()
            NameTextBox.Focus()

            ' Disable Summary Button as we reset total variables to 0 and do not want to divide by 0
            SumButton.Enabled = False
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class

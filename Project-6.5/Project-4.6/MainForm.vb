' Programmer: Gregory Mathews
' Project: Chapter 6, Exercise 5
' Description: Program calculates amount to be paid based on units completed and displays summary totals

Public Class MainForm

    ' Define working variables for storage
    Dim NumCompleted As Integer
    Dim PricePaid As Decimal
    Dim EmpPay As Decimal

    ' Define variables for summary totals
    Friend TotalComplete As Integer
    Friend TotalPay As Decimal
    Friend TotalWorkers As Integer

    ' Define variables for message box strings
    Dim NoData As String = "Data entry error. No data entered."
    Dim InvData As String = "Invalid data entered. Please try again."

    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayToolStripMenuItem.Click

        ' Catch error where no data is entered for name or number of pieces
        If NameTextBox.Text = "" Or PiecesTextBox.Text = "" Then
            MessageBox.Show(NoData, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NameTextBox.Focus()
        Else
            ' Enable Summary Menu Item now that we are calculating our first total
            SummaryToolStripMenuItem.Enabled = True

            ' Use Try/Catch to catch invalid data format exception
            Try
                NumCompleted = Integer.Parse(PiecesTextBox.Text)
            Catch ex As FormatException
                MessageBox.Show(InvData, "Invalid Data Format", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    MessageBox.Show(InvData, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PiecesTextBox.Focus()
            End Select

            ' Calculate current and store current employee payout
            EmpPay = NumCompleted * PricePaid

            ' Increment totals for total pay, total completed units, and total workers
            TotalPay += EmpPay
            TotalComplete += NumCompleted
            TotalWorkers = TotalWorkers + 1

            ' Use ToString method to display employee pay in the pay text box as currency
            PayTextBox.Text = EmpPay.ToString("C")

        End If

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click

        SummaryForm.Show()

        ' Use ToString method to display totals in all summary text boxes
        'TotalPiecesTextBox.Text = TotalComplete.ToString
        'TotalPayTextBox.Text = TotalPay.ToString("C")
        'TotalWorkersTextBox.Text = TotalWorkers.ToString
        'AvgPayTextBox.Text = Average.ToString("C")

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

        ' Clear all employee text boxes and move focus back to Name text box
        NameTextBox.Clear()
        PiecesTextBox.Clear()
        PayTextBox.Clear()
        NameTextBox.Focus()

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click

        ' Show message box confirming that user wishes to clear all summary totals
        Dim result As DialogResult = MessageBox.Show("Clear all summary data?", "Confirm Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.Cancel Then
            MessageBox.Show("Clear action aborted!")
        Else
            ' Reset all variable totals to 0
            TotalComplete = 0
            TotalPay = 0

            ' Clear all summary total text boxes and return focus to Name text box
            SummaryForm.TotalPiecesTextBox.Clear()
            SummaryForm.TotalPayTextBox.Clear()
            SummaryForm.AvgPayTextBox.Clear()
            SummaryForm.TotalWorkersTextBox.Clear()
            NameTextBox.Focus()

            ' Disable Summary Button as we reset total variables to 0 and do not want to divide by 0
            SummaryToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ' Allow the user to select a new color for text boxes

        With ColorDialog1
            .Color = NameTextBox.ForeColor
            .ShowDialog()
            NameTextBox.ForeColor = .Color
            PiecesTextBox.ForeColor = .Color
            PayTextBox.ForeColor = .Color
            SummaryForm.TotalPiecesTextBox.ForeColor = .Color
            SummaryForm.TotalPayTextBox.ForeColor = .Color
            SummaryForm.AvgPayTextBox.ForeColor = .Color
            SummaryForm.TotalWorkersLabel.ForeColor = .Color
        End With

    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        ' Allow the user to select a new font for text boxes

        With FontDialog1
            .Font = NameTextBox.Font
            .ShowDialog()
            NameTextBox.Font = .Font
            PiecesTextBox.Font = .Font
            PayTextBox.Font = .Font
            SummaryForm.TotalPiecesTextBox.Font = .Font
            SummaryForm.TotalPayTextBox.Font = .Font
            SummaryForm.AvgPayTextBox.Font = .Font
            SummaryForm.TotalWorkersTextBox.Font = .Font
        End With

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the About message box

        AboutBox1.ShowDialog()

        'Dim MessageString As String

        'MessageString = "Piecework Summary Program" & Environment.NewLine &
        '    Environment.NewLine & "Programmed by Gregory Mathews"
        'MessageBox.Show(MessageString, "About Piecework Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Terminate the program

        Me.Close()

    End Sub

    Private Sub LogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoToolStripMenuItem.Click

        If LogoToolStripMenuItem.Checked = True Then
            LogoPictureBox.Visible = True
        Else
            LogoPictureBox.Visible = False
        End If

    End Sub

    Private Sub SloganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SloganToolStripMenuItem.Click

        If SloganToolStripMenuItem.Checked = True Then
            SloganLabel.Visible = True
        Else
            SloganLabel.Visible = False
        End If

    End Sub
End Class
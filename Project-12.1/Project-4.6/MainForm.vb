' Programmer: Gregory Mathews
' Project: Chapter 5, Exercise 1
' Description: Program calculates amount to be paid based on units completed and displays summary totals

Public Class MainForm

    ' Declare the new object
    Private TheBusinessLogic As BusinessLogic

    ' Define variables for message box strings
    Private NoData As String = "Data entry error. No data entered."
    Private InvData As String = "Invalid data entered. Please try again."

    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayToolStripMenuItem.Click

        Try
            If NameTextBox.Text = "" Or PiecesTextBox.Text = "" Then
                MessageBox.Show(NoData, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                NameTextBox.Focus()
            Else
                ' Instantiate the BusinessLogic object and set the properties
                TheBusinessLogic = New BusinessLogic(Integer.Parse(PiecesTextBox.Text))

                ' Show pay results in text box
                PayTextBox.Text = BusinessLogic.Pay.ToString("C")

                ' Enable Summary Menu Item now that we are calculating our first total
                SummaryToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(InvData, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click

        ' Use ToString method to display totals in all summary text boxes
        TotalPiecesTextBox.Text = BusinessLogic.CompleteSummary.ToString()
        TotalWorkersTextBox.Text = BusinessLogic.WorkersSummary.ToString()
        TotalPayTextBox.Text = BusinessLogic.PaySummary.ToString("C")
        AvgPayTextBox.Text = BusinessLogic.AvgSummary.ToString("C")

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
            ' Reset all variable accumulator totals to 0
            BusinessLogic.WorkersSummary = 0
            BusinessLogic.CompleteSummary = 0

            ' Clear all employee text boxes
            NameTextBox.Clear()
            PiecesTextBox.Clear()
            PayTextBox.Clear()

            ' Clear all summary total text boxes and return focus to Name text box
            TotalPiecesTextBox.Clear()
            TotalPayTextBox.Clear()
            AvgPayTextBox.Clear()
            TotalWorkersTextBox.Clear()
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
            TotalPiecesTextBox.ForeColor = .Color
            TotalPayTextBox.ForeColor = .Color
            AvgPayTextBox.ForeColor = .Color
            TotalWorkersTextBox.ForeColor = .Color
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
            TotalPiecesTextBox.Font = .Font
            TotalPayTextBox.Font = .Font
            AvgPayTextBox.Font = .Font
            TotalWorkersTextBox.Font = .Font
        End With

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the About message box

        Dim MessageString As String

        MessageString = "Piecework Summary Program" & Environment.NewLine &
            Environment.NewLine & "Programmed by Gregory Mathews"
        MessageBox.Show(MessageString, "About Piecework Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Terminate the program

        Me.Close()

    End Sub
End Class
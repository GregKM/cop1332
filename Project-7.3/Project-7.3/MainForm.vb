' Programmer: Gregory Mathews
' Subject: COP-1332
' Project: Chapter 7, Exercise 3
' Description: This program will calculate yacht charter prices using data input by the user and predefined entries in combo boxes

Public Class MainForm

    ' Variables to hold summary totals
    Dim TotalRevenueDecimal As Decimal = 0.0
    Dim TotalChartersInteger As Integer = 0
    Dim TotalHoursInteger As Integer = 0

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        ' Constants for yacht size hourly rates
        Const RATE01 As Decimal = 95.0
        Const RATE02 As Decimal = 137.0
        Const RATE03 As Decimal = 160.0
        Const RATE04 As Decimal = 192.0
        Const RATE05 As Decimal = 250.0
        Const RATE06 As Decimal = 400.0
        Const RATE07 As Decimal = 550.0

        ' Declare and initialize working variables
        Dim RevenueDecimal As Decimal = 0.0
        Dim RateDecimal As Decimal = 0.0

        ' Declare and initialize error strings for message boxes
        Dim InvalidHour As String = "Invalid hour amount. Please enter a number."
        Dim SelectYacht As String = "Please select a yacht size."

        ' Catch no size selection and set rate based on size selection
        With SizeComboBox
            If .SelectedIndex = -1 Then
                Dim DialogResult As DialogResult =
                    MessageBox.Show(SelectYacht, "No Size Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                If DialogResult = DialogResult.OK Then
                    .Focus()
                End If
            End If

            If .SelectedIndex = 0 Then
                RateDecimal = RATE01
            End If

            If .SelectedIndex = 1 Then
                RateDecimal = RATE02
            End If

            If .SelectedIndex = 2 Then
                RateDecimal = RATE03
            End If

            If .SelectedIndex = 3 Then
                RateDecimal = RATE04
            End If

            If .SelectedIndex = 4 Then
                RateDecimal = RATE05
            End If

            If .SelectedIndex = 5 Then
                RateDecimal = RATE06
            End If

            If .SelectedIndex = 6 Then
                RateDecimal = RATE07
            End If
        End With

        ' Perform calculations, display price, and increment summary variables
        Try
            RevenueDecimal = Decimal.Parse(HoursTextBox.Text) * RateDecimal
            TotalRevenueDecimal += RevenueDecimal
            PriceTextBox.Text = RevenueDecimal.ToString("C")

            TotalHoursInteger += Integer.Parse(HoursTextBox.Text)
            TotalChartersInteger += 1

            ' Catch invalid data entered in the hours text box and show error message box
        Catch ex As FormatException
            Dim DialogResult As DialogResult =
                MessageBox.Show(InvalidHour, "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            If DialogResult = DialogResult.OK Then
                With HoursTextBox
                    .Focus()
                    .SelectAll()
                End With
            End If
        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        ' Declare and initialize confirmation message box string
        Dim ConfirmClear As String = "Clear the entered data?"

        ' Show message box and catch result
        Dim DialogResult As DialogResult =
            MessageBox.Show(ConfirmClear, "Confirm Choice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        ' Clear control data on OK click; leave data on Cancel click
        If DialogResult = DialogResult.OK Then
            HoursTextBox.Clear()
            SizeComboBox.SelectedIndex = -1
            TypeComboBox.SelectedIndex = -1
            With PartyTextBox
                .Clear()
                .Focus()
            End With
        ElseIf DialogResult = DialogResult.Cancel Then
            With PartyTextBox
                .Focus()
                .SelectAll()
            End With
        End If

    End Sub

    Private Sub ClearForNextCharterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearForNextCharterToolStripMenuItem.Click

        ' Declare and initialize message box string
        Dim ConfirmClear As String = "Clear the entered data?"

        ' Show message box and catch result
        Dim DialogResult As DialogResult =
            MessageBox.Show(ConfirmClear, "Confirm Choice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        ' Clear control data on OK click; leave data on Cancel click
        If DialogResult = DialogResult.OK Then
            HoursTextBox.Clear()
            SizeComboBox.SelectedIndex = -1
            TypeComboBox.SelectedIndex = -1
            With PartyTextBox
                .Clear()
                .Focus()
            End With
        ElseIf DialogResult = DialogResult.Cancel Then
            With PartyTextBox
                .Focus()
                .SelectAll()
            End With
        End If

    End Sub

    Private Sub AddYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddYachtTypeToolStripMenuItem.Click

        ' Check for blank. If not blank, add typed entry to yacht type list
        If TypeComboBox.Text = "" Then
            Dim DialogResult As DialogResult =
                MessageBox.Show("Cannot add blank yacht type.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DialogResult = DialogResult.OK Then
                TypeComboBox.Focus()
            End If
        Else
            With TypeComboBox
                .Items.Add(.Text)
            End With
        End If
    End Sub

    Private Sub RemoveYachtTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveYachtTypeToolStripMenuItem.Click

        ' Check for no selection. If item selected, show remove confirmation message box and then remove selected yacht type
        If TypeComboBox.SelectedIndex = -1 Then
            Dim DialogResult As DialogResult =
                MessageBox.Show("Please select a type to remove first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DialogResult = DialogResult.OK Then
                TypeComboBox.Focus()
            End If
        Else
            Dim DialogResult As DialogResult =
                MessageBox.Show("Remove selected yacht type?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If DialogResult = DialogResult.OK Then
                TypeComboBox.Items.RemoveAt(TypeComboBox.SelectedIndex)
            Else
                If DialogResult = DialogResult.Cancel Then
                    TypeComboBox.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub DisplayCountOfYachtTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayCountOfYachtTypesToolStripMenuItem.Click

        ' Show total count of yacht types in a message box
        MessageBox.Show(TypeComboBox.Items.Count.ToString(), "Total Yacht Count", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        ' Display the About box for the program
        AboutBox.Show()

    End Sub

    Private Sub PrintSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSummaryToolStripMenuItem.Click

        ' Declare and initialize the message box string for no data error
        Dim NoDataString As String = "Total charters cannot be 0. Enter some information first."

        ' Check to make sure the program will not attempt to divide by zero before moving forward with summary print preview
        If TotalChartersInteger = 0 Then
            Dim DialogResult As DialogResult =
                MessageBox.Show(NoDataString, "No Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If DialogResult = DialogResult.OK Then
                PartyTextBox.Focus()
            End If
        Else
            ' Launch print preview dialog for summary information
            PrintPreviewDialog1.Document = PrintDocumentSummary
            PrintPreviewDialog1.ShowDialog()
        End If

    End Sub

    Private Sub PrintDocumentSummary_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentSummary.PrintPage

        ' Calculate average of all charter hours entered
        Dim AverageHoursDecimal As Decimal = TotalHoursInteger / TotalChartersInteger

        ' Delcare variable for print formatting
        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintlocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        ' Print header information
        PrintLineString = "Gregory Mathews"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)
        PrintLineString = "Summary Report"
        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)

        ' Leave space after header
        VerticalPrintlocationSingle += LineHeightSingle * 2

        ' Print total charter information
        PrintLineString = "Total Charters:"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)
        PrintLineString = TotalChartersInteger.ToString()
        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)

        VerticalPrintlocationSingle += LineHeightSingle * 2

        ' Print total revenue information
        PrintLineString = "Total Revenue:"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)
        PrintLineString = TotalRevenueDecimal.ToString("C")
        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)

        VerticalPrintlocationSingle += LineHeightSingle * 2

        ' Print average charter hours information
        PrintLineString = "Average Hours Chartered:"
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)
        PrintLineString = AverageHoursDecimal.ToString()
        VerticalPrintlocationSingle += LineHeightSingle
        e.Graphics.DrawString(PrintLineString, PrintFont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintlocationSingle)

    End Sub

    Private Sub PrintTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTypeToolStripMenuItem.Click

        ' Launch print preview dialog for yacht types
        PrintPreviewDialog1.Document = PrintDocumentTypes
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocumentTypes_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentTypes.PrintPage

        ' Declare variables for print formatting
        Dim PrintFont As New Font("Arial", 12)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim HorizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim PrintLineString As String

        ' Print headings for yacht types report
        Using Headingfont As New Font("Arial", 14, FontStyle.Bold)
            e.Graphics.DrawString("Gregory Mathews", Headingfont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
            VerticalPrintLocationSingle += LineHeightSingle
            e.Graphics.DrawString("Yacht Type Report", Headingfont, Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        End Using

        ' Leave space after headings
        VerticalPrintLocationSingle += LineHeightSingle * 2

        ' Loop to show all entries in the yacht type combo box
        For ListIndexInteger As Integer = 0 To TypeComboBox.Items.Count - 1
            VerticalPrintLocationSingle += LineHeightSingle

            PrintLineString = TypeComboBox.Items(ListIndexInteger).ToString()
            e.Graphics.DrawString(PrintLineString, PrintFont, _
            Brushes.Black, HorizontalPrintLocationSingle, VerticalPrintLocationSingle)
        Next ListIndexInteger

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

End Class
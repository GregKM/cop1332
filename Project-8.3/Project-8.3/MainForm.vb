Public Class MainForm

    Friend PricesDecimal() As Decimal = {40D, 27.5D, 15D, 10D}
    Friend SectionTotal(3) As Integer


    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click

        Dim SaleInteger As Integer
        Dim IndexInteger As Integer

        Try
            IndexInteger = SectionComboBox.SelectedIndex
            If IndexInteger <> -1 Then
                SaleInteger = Integer.Parse(SoldTextBox.Text)
                PriceTextBox.Text = (SaleInteger * PricesDecimal(IndexInteger)).ToString("C")
                SectionTotal(IndexInteger) += SaleInteger

                SectionComboBox.SelectedIndex = -1
                With SoldTextBox
                    .Text = ""
                    .Focus()
                End With
            Else
                MessageBox.Show("Select a section from the list.",
                                "Data Entry Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Number sold must be numeric.")
            With SoldTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

    End Sub

    Private Sub PricesButton_Click(sender As Object, e As EventArgs) Handles PricesButton.Click

        PricesForm.Show()

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim PrintFont As New Font("Arial", 12)
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim LineHeightSingle As Single = PrintFont.GetHeight + 2
        Dim Column1HorizontalLocationSingle As Single = e.MarginBounds.Left
        Dim VerticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim Column2Horizonta1Locationsingle As Single = 300
        Dim Column3HorizontalLocationSingle As Single = 600
        Dim PrintLineString As String
        Dim FontSizeF As New SizeF

        PrintLineString = "Ticket Sales Summary"
        e.Graphics.DrawString(PrintLineString, HeadingFont,
                              Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        'PrintLineString = "by Gregory Mathews"
        'VerticalPrintLocationSingle += LineHeightSingle
        'e.Graphics.DrawString(PrintLineString, PrintFont,
        '                      Brushes.Black, Column2Horizonta1Locationsingle, VerticalPrintLocationSingle)
        VerticalPrintLocationSingle += LineHeightSingle * 2

        'Section
        e.Graphics.DrawString("Orchestra", PrintFont,
            Brushes.Black, Column1HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        'Total
        e.Graphics.DrawString(SectionTotal(0).ToString, PrintFont,
            Brushes.Black, Column2Horizonta1Locationsingle,
            VerticalPrintLocationSingle)

        'Price
        e.Graphics.DrawString((SectionTotal(0) * PricesDecimal(0)).ToString("C"), PrintFont,
            Brushes.Black, Column3HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        'Section
        e.Graphics.DrawString("Mezzanine", PrintFont,
            Brushes.Black, Column1HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        'Total
        e.Graphics.DrawString(SectionTotal(1).ToString, PrintFont,
            Brushes.Black, Column2Horizonta1Locationsingle,
            VerticalPrintLocationSingle)

        'Price
        e.Graphics.DrawString((SectionTotal(1) * PricesDecimal(1)).ToString("C"), PrintFont,
            Brushes.Black, Column3HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        'Section
        e.Graphics.DrawString("General", PrintFont,
            Brushes.Black, Column1HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        'Total
        e.Graphics.DrawString(SectionTotal(2).ToString, PrintFont,
            Brushes.Black, Column2Horizonta1Locationsingle,
            VerticalPrintLocationSingle)

        'Price
        e.Graphics.DrawString((SectionTotal(2) * PricesDecimal(2)).ToString("C"), PrintFont,
            Brushes.Black, Column3HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

        'Section
        e.Graphics.DrawString("Balcony", PrintFont,
            Brushes.Black, Column1HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        'Total
        e.Graphics.DrawString(SectionTotal(3).ToString, PrintFont,
            Brushes.Black, Column2Horizonta1Locationsingle,
            VerticalPrintLocationSingle)

        'Price
        e.Graphics.DrawString((SectionTotal(3) * PricesDecimal(3)).ToString("C"), PrintFont,
            Brushes.Black, Column3HorizontalLocationSingle,
            VerticalPrintLocationSingle)

        VerticalPrintLocationSingle += LineHeightSingle * 2

    End Sub
End Class

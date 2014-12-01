Imports Microsoft.VisualBasic.FileIO

Public Class ReservationsForm

    Private ReservationsFieldParser As TextFieldParser

    Private Sub Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FileString As String = "Res.txt"

        Try
            ReservationsFieldParser = New TextFieldParser(FileString)
            ReservationsFieldParser.TextFieldType = FieldType.Delimited
            ReservationsFieldParser.SetDelimiters(",")
        Catch ex As Exception
            MessageBox.Show("Unable to read the file: " & FileString, "File Error")
            Me.Close()
        End Try

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        Dim FieldString() As String

        If Not ReservationsFieldParser.EndOfData Then
            FieldString = ReservationsFieldParser.ReadFields()
            DateTextBox.Text = FieldString(0)
            PartyTextBox.Text = FieldString(1)
            HoursTextBox.Text = FieldString(2)
            TypeTextBox.Text = FieldString(3)
            SizeTextBox.Text = FieldString(4)
            PriceTextBox.Text = FieldString(5)
            CommentsTextBox.Text = FieldString(6)
        Else
            MessageBox.Show("No more records to display.", "End of Data")
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        Me.Close()

    End Sub
End Class
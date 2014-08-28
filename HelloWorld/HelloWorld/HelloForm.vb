' Project:      Hello World
' Programmer:   Gregory Mathews
' Date:         08/28/2014
' Description:  This project will display a "Hello World"
'               message in two different languages
'               and print the form.

Public Class HelloForm

    Private Sub PushButton_Click(sender As Object, e As EventArgs) Handles PushButton.Click

        ' Display the Hello World message.

        MessageLabel.Text = "Hello World"

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        ' Exit the project.

        Me.Close()

    End Sub

    Private Sub SpanishButton_Click(sender As Object, e As EventArgs) Handles SpanishButton.Click

        ' Display the Hello World message in Spanish.

        MessageLabel.Text = "Hola Mundo"

    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        ' Print the form on the printer.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class

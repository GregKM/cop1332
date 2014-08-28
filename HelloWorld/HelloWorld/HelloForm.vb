' Project:      Hello World
' Programmer:   Gregory Mathews
' Date:         08/28/2014
' Description:  This project will display a "Hello World"
'               message in four different languages.

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

    Private Sub FrenchButton_Click(sender As Object, e As EventArgs) Handles FrenchButton.Click

        ' Display the Hello World message in French.

        MessageLabel.Text = "Bonjour tout le monde"

    End Sub

    Private Sub ItalianButton_Click(sender As Object, e As EventArgs) Handles ItalianButton.Click

        ' Display the Hello World message in Italian.

        MessageLabel.Text = "Ciao Mondo"

    End Sub
End Class

Class MainWindow
    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub

    Private Sub TextBox_G(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub GreetingTextBox_GotFocus(sender As Object, e As RoutedEventArgs) Handles GreetingTextBox.GotFocus
        If (GreetingTextBox.Text = "Type Your Greeting Here") Then
            GreetingTextBox.Text = ""
        End If
    End Sub

    Private Sub SubmitGreetingButton_Click(sender As Object, e As RoutedEventArgs) Handles SubmitGreetingButon.Click
        Dim Form2 As GreetingWindow = New GreetingWindow()
        Form2.GreetingLabel.Content = GreetingTextBox.Text + "!"
        Form2.Show()
    End Sub
End Class

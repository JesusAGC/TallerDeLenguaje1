Public Class LoginForm
    Dim usr As String = "gs"
    Dim pass As String = "gs"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXBUser.Text.Equals(usr) And TXBPassword.Text.Equals(pass) Then
            Dim FormaTM As Form
            FormaTM = New Ticket_Manager
            If Not IsNothing(FormaTM) Then
                FormaTM.Show()
                FormaTM.BringToFront()
                Me.Close()
            Else
                FormaTM = New Ticket_Manager
                FormaTM.Show()

            End If

        End If
    End Sub
End Class
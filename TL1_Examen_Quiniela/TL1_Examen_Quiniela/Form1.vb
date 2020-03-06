Public Class Form1
    Dim FormQ As Quiniela_Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNEntrar.Click
        FormQ = New Quiniela_Form
        Me.Hide()
        FormQ.Show()
        FormQ.BringToFront()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Application.Exit()
    End Sub
End Class

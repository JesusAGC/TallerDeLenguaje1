Public Class Form1
    Dim FormaLF As Form

    Private Sub Button_Salir_Click(sender As Object, e As EventArgs) Handles Button_Salir.Click
        Application.Exit()
    End Sub

    Private Sub Button_Entrar_Click(sender As Object, e As EventArgs) Handles Button_Entrar.Click
        Me.Hide()
        If Not IsNothing(FormaLF) Then
            FormaLF.Show()
            FormaLF.BringToFront()

        Else
            FormaLF = LoginForm
            FormaLF.Show()

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormaLF = New LoginForm
    End Sub
End Class

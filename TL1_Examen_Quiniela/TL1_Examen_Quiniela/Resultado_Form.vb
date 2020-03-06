Public Class Resultado_Form
    Private Sub Resultado_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBLAciertos.Text = Aciertos
        If Aciertos >= 5 Then
            LBLResultado.Text = Ganador
            picResultado.Image = WinnerIMG
            picResultado.Show()
            LBLTextoPremio.Text = "Premio:"
            If Aciertos = 5 Then
                LBLCantidadPremio.Text = "$5000.00"
            ElseIf Aciertos = 6 Then
                LBLCantidadPremio.Text = "$50,000.00"
            ElseIf Aciertos = 7 Then
                LBLCantidadPremio.Text = "$5,000,000.00"
            End If
        Else
            LBLResultado.Text = Perdedor
            picResultado.Image = LoserIMG
            picResultado.Show()
        End If
    End Sub

    Private Sub BTNSalida_Click(sender As Object, e As EventArgs) Handles BTNSalida.Click
        Application.Exit()
    End Sub

    Private Sub Resultado_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
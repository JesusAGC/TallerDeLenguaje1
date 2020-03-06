Public Class Quiniela_Form
    Dim ac As Integer
    Dim fform As Resultado_Form
    Private Sub Quiniela_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ac = New Integer
        ac = 0
    End Sub

    Private Sub BTNResultado_Click(sender As Object, e As EventArgs) Handles BTNResultado.Click
        If RDBAmerica.Checked = True Then
            ac += 1
        End If
        If RDBCRUZ_AZUL.Checked = True Then
            ac += 1
        End If
        If RDBAtlas.Checked = True Then
            ac += 1
        End If
        If RDBTigres.Checked = True Then
            ac += 1
        End If
        If RDBUdeGuadalajara.Checked = True Then
            ac += 1
        End If
        If RDBPumas.Checked = True Then
            ac += 1
        End If
        If RDBPuebla.Checked = True Then
            ac += 1
        End If
        Aciertos = ac
        Me.Hide()
        fform = New Resultado_Form
        fform.Show()
        fform.BringToFront()
    End Sub
End Class
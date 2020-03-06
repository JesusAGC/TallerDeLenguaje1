Imports TL1_IMC.GV.VariablesGlobales
Public Class Form1
    Dim IMC As Double
    Dim wh As Double
    Dim hh As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBRangoDeEdad.Items.Add("10-20")
        CBRangoDeEdad.Items.Add("20-30")
        CBRangoDeEdad.Items.Add("30-40")
        CBRangoDeEdad.Items.Add("40-50")
        CBRangoDeEdad.Items.Add("50-60")
        RadioButton1.Checked = True

        TXBPeso.Text = 0
        TXBEstatura.Text = 0
        CBRangoDeEdad.SelectedIndex = 0
        LBNacionalidad.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NombreF = TXBNombre.Text
        IMC = New Double
        wh = CDbl(TXBPeso.Text)
        hh = CDbl(TXBEstatura.Text)
        IMC = wh / Math.Pow(hh, 2)
        IMCF = IMC
        EstaturaF = hh
        PesoF = wh
        If RadioButton1.Checked Then
            SexoFin = "Hombre"
        ElseIf radiobutton2.Checked Then
            SexoFin = "Mujer"
        End If
        NacionalidadF = LBNacionalidad.GetItemText(LBNacionalidad.SelectedItem)
        RangoDeEdad = CBRangoDeEdad.SelectedItem.ToString

        If CBXAlcohol.Checked = True Then
            consumoF = consumoF & "Alcohol, "
        End If
        If CBXDrogas.Checked = True Then
            consumoF = consumoF & "Drogas, "
        End If

        If CBXTabaco.Checked = True Then
            consumoF = consumoF & "Tabaco, "
        End If

        If CBXMedicamentosP.Checked = True Then
            consumoF = consumoF & "Medicamentos P."
        End If


        If String.IsNullOrWhiteSpace(consumoF) = False Then
            If consumoF.EndsWith(", ") Then
                consumoF.Trim()
                consumoF = consumoF.Remove(consumoF.Length - 2) & "."

            End If
        End If

        Dim forma As Form
        forma = Form2
        If Not IsNothing(forma) Then
            forma.Show()
            forma.BringToFront()
        Else
            forma = Form2
            forma.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


End Class

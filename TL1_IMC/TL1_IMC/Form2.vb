Imports TL1_IMC.GV.VariablesGlobales
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NombreL.Text = NombreF
        PesoL.Text = PesoF
        EstaturaL.Text = EstaturaF.ToString & " m"
        RangoL.Text = RangoDeEdad
        NacionalidadL.Text = NacionalidadF
        SexoL.Text = SexoFin
        SustanciasL.Text = consumoF
        IMCL.Text = IMCF

        If IMCF <= 18.5 Then
            CondicionL.Text = "Infrapeso: Usted se encuentra por debajo del IMC normal."
        ElseIf IMCF <= 25 Then
            CondicionL.Text = "Normal: Usted se encuentra en el IMC adecuado para usted."
        ElseIf IMCF > 25 Then
            CondicionL.Text = "Sobrepeso: Usted tiene sobre peso"

        End If



    End Sub
End Class
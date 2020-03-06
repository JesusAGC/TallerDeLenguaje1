Imports System.Resources
Public Class Ticket_Manager
    Dim numeroB As Integer
    Dim MunCoah As New List(Of String)
    Dim MunCoahPrices As New List(Of String)
    Dim MunNL As New List(Of String)
    Dim MunNLPrices As New List(Of Double)

    Private Sub Ticket_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MunCoah.Add("Parras")
        MunCoah.Add("Ramos Arizpe")
        MunCoah.Add("Arteaga")

        MunCoahPrices.Add(200.0)
        MunCoahPrices.Add(50.0)
        MunCoahPrices.Add(60.0)


        MunNL.Add("Guadalupe")
        MunNL.Add("Monterrey")
        MunNL.Add("San Nicolas")

        MunNLPrices.Add(120.0)
        MunNLPrices.Add(100.0)
        MunNLPrices.Add(150.0)


        CBXMunicipio.DataSource = MunNL
        CBXEstado.SelectedIndex = 1
        CBXEstado.Show()
        CBXMunicipio.SelectedIndex = 0
        CBXNumeroDeBoletos.SelectedIndex = 0

    End Sub

    Private Sub BTTGenerarBoleto_Click(sender As Object, e As EventArgs) Handles BTTGenerarBoleto.Click
        NombreF = TXBNombre.Text.Trim & " "
        ApellidoPF = TXPApellidoPaterno.Text.Trim & " "
        ApellidoMF = TXBApellidoMaterno.Text
        EdadF = CType(TXBEdad.Text, Integer)
        NoBoletosF = CType(CBXNumeroDeBoletos.SelectedItem, Integer)
        FechaSalidaF = DTPFechaDeSalida.Value.ToString
        If RadioBHombre.Checked = True Then
            SexoF = "Hombre"
        ElseIf RadioBMujer.Checked = True Then
            SexoF = "Mujer"
        End If
        EstadoDF = CBXEstado.SelectedItem
        MunicipioDF = CBXMunicipio.SelectedItem
        If CBXEstado.SelectedItem = "Nuevo León" Then
            PrecioF = MunNLPrices(CBXMunicipio.SelectedIndex)
        ElseIf CBXEstado.SelectedItem = "Coahuila" Then
            PrecioF = MunCoahPrices(CBXMunicipio.SelectedIndex)
        End If

        Me.Hide()
        Dim FormaFin As Form
        FormaFin = New Final_Ticket_Form
        If Not IsNothing(FormaFin) Then
            FormaFin.Show()
            FormaFin.BringToFront()
            Me.Close()
        Else
            FormaFin = New Ticket_Manager
            FormaFin.Show()
        End If


    End Sub

    Private Sub CBXEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXEstado.SelectedIndexChanged
        If CBXEstado.SelectedItem = "Nuevo León" Then
            CBXMunicipio.DataSource = MunNL
            CBXMunicipio.SelectedIndex = 0
        ElseIf CBXEstado.SelectedItem = "Coahuila" Then
            CBXMunicipio.DataSource = MunCoah
            CBXMunicipio.SelectedIndex = 0
        End If

    End Sub

    Private Sub CBXMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXMunicipio.SelectedIndexChanged
        Dim picture1 As Image
        picture1 = My.Resources.Images.gruposenda
        If CBXMunicipio.SelectedItem = "Parras" Then
            picture1 = My.Resources.Images.parras
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        ElseIf CBXMunicipio.SelectedItem = "Ramos Arizpe" Then
            picture1 = My.Resources.Images.ramosarizpe
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        ElseIf CBXMunicipio.SelectedItem = "Arteaga" Then
            picture1 = My.Resources.Images.arteaga
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        ElseIf CBXMunicipio.SelectedItem = "Guadalupe" Then
            picture1 = My.Resources.Images.guadalupe
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        ElseIf CBXMunicipio.SelectedItem = "Monterrey" Then
            picture1 = My.Resources.Images.monterrey
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        ElseIf CBXMunicipio.SelectedItem = "San Nicolas" Then
            picture1 = My.Resources.Images.sannicolas
            PicBoxDestino.Image = picture1
            PicBoxDestino.Show()
        End If
        IMGBoleto = picture1

    End Sub
End Class
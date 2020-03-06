Public Class Final_Ticket_Form
    Private Sub Final_Ticket_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBNombre.Text = NombreF & ApellidoPF & ApellidoMF
        LBSexo.Text = SexoF
        LBEdad.Text = EdadF
        LBNumBoletos.Text = NoBoletosF
        LBFechaDeSalida.Text = FechaSalidaF
        LBDestino.Text = EstadoDF & ", " & MunicipioDF
        LBPrecio.Text = "$" & PrecioF
        LBTotal.Text = "$" & PrecioF * CType(NoBoletosF, Double)
        PBXImagen_Final.Image = IMGBoleto
        PBXImagen_Final.Show()
    End Sub

    Private Sub ExitB_Click(sender As Object, e As EventArgs) Handles ExitB.Click
        Application.Exit()
    End Sub
End Class
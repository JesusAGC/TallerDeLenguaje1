Imports TL1_App1.DTO
Imports System.Data.SQLite
Public Class Form1
    Dim Totales As List(Of MovimientoDTO)
    Dim conexion As SQLiteConnection
    Dim comando As SQLiteCommand
    Dim dtingreso As DataTable
    Dim dtgasto As DataTable
    Dim IngresoTipos As List(Of String)
    Dim GastosTipos As List(Of String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtingreso = New DataTable
        dtgasto = New DataTable
        conexion = New SQLiteConnection
        Dim GCS As New DBinteraction
        conexion.ConnectionString = GCS.GetConnectionString
        conexion.Open()
        comando = New SQLiteCommand
        comando.Connection = conexion
        Totales = New List(Of MovimientoDTO)
        CBTipoMovimiento.Items.Add("Ingreso")
        CBTipoMovimiento.Items.Add("Gasto")
        TXBCantidadDeMovimiento.Text = 0
        CBTipoMovimiento.SelectedIndex = 0

        'comando.CommandType = CommandType.Text
        'comando.CommandText = "select descripcion from DescripcionIngresoDefault"
        'comando.ExecuteNonQuery()

        'Dim ds As New DataSet
        'Dim adapter As New SQLiteDataAdapter
        'adapter.SelectCommand = comando
        'adapter.Fill(ds, "DescripcionIngresoDefault")
        'dtingreso = ds.Tables("DescripcionIngresoDefault")


        'comando.CommandText = "select Descripcion from DescripcionGastosDefault"
        'comando.ExecuteNonQuery()
        'adapter.SelectCommand = comando
        'adapter.Fill(ds, "DescripcionGastosDefault")
        'dtgasto = ds.Tables("DescripcionGastosDefault")
        dtingreso = GCS.GetDT_Descripcion("Ingreso")
        dtgasto = GCS.GetDT_Descripcion("Gasto")
        ConfigIngreso = dtingreso
        ConfigGasto = dtgasto

        CBODescripcion.DataSource = dtingreso
        CBODescripcion.DisplayMember = "Descripcion"
        CBODescripcion.ValueMember = "Descripcion"


    End Sub

    Private Sub IngresarMovimiento()
        Dim DTOM As New MovimientoDTO
        DTOM.Cantidad = CDbl(TXBCantidadDeMovimiento.Text)
        DTOM.Descripcion = CBODescripcion.SelectedValue.ToString
        DTOM.Fecha = Format(DTPGasto.Value, "yyyy-MM-dd").ToString
        DTOM.Tipo = CBTipoMovimiento.SelectedItem.ToString
        DTOM.Detalles = TXBDetallesMovimiento.Text.ToString
        If String.IsNullOrWhiteSpace(DTOM.Detalles) Then
            DTOM.Detalles = "No hay detalles"
        End If
        DTOM.Usuario = GV.UsuarioActivo
        Totales.Add(DTOM)
        If DTOM.Tipo.Equals("Gasto") Then
            DTOM.Cantidad = DTOM.Cantidad * -1
        End If
        comando.CommandText = "Insert into Movimientos(Cantidad,Descripcion,Detalles,Tipo,fecha,Usuario) values(@Cantidad,@Descripcion,@Detalles,@Tipo,@Fecha,@User)"
        comando.Parameters.AddWithValue("@Cantidad", DTOM.Cantidad)
        comando.Parameters.AddWithValue("@Descripcion", DTOM.Descripcion)
        comando.Parameters.AddWithValue("@Tipo", DTOM.Tipo)
        comando.Parameters.AddWithValue("@Fecha", DTOM.Fecha)
        comando.Parameters.AddWithValue("@Detalles", DTOM.Detalles)
        comando.Parameters.AddWithValue("@User", DTOM.Usuario)
        comando.ExecuteNonQuery()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IngresarMovimiento()
        updateDGV()
        GetBalance()
    End Sub
    Private Sub validateDTO(ByVal dto As MovimientoDTO)
        Try
            If dto.Cantidad = 0 Then
                Throw New Exception("El Movimiento tiene valor a 0")
            End If
        Catch ex As Exception
        End Try

        Try
            If String.IsNullOrEmpty(dto.Descripcion) Then
                Throw New Exception("La descripción es vacía")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateDGV()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetBalance()
    End Sub
    Private Sub GetBalance()
        Dim indx As Integer = 0
        Dim limit As Integer = Totales.Count - 1
        Dim balance As Double = 0
        For i As Integer = 0 To limit
            balance = balance + Totales(indx).Cantidad
            indx = indx + 1
        Next
        txbfinal.Text = balance

    End Sub

    Private Sub updateDGV()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Totales
        DataGridView1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim forma As Form
        forma = Form4
        If Not IsNothing(forma) Then
            forma.Show()
            forma.BringToFront()

        Else

            forma = Form4
            forma.Show()

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub CBTipoMovimiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoMovimiento.SelectedIndexChanged
        If CBTipoMovimiento.SelectedIndex = 0 Then
            CBODescripcion.DataSource = dtingreso

        ElseIf CBTipoMovimiento.SelectedIndex = 1 Then
            CBODescripcion.DataSource = dtgasto
            CBODescripcion.DisplayMember = "Descripcion"
            CBODescripcion.ValueMember = "Descripcion"
        End If

    End Sub
End Class

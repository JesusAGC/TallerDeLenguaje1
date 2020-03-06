Imports System.Data.SQLite
Imports TL1_App1.DTO
Public Class Form4
    Dim conexion As SQLiteConnection
    Dim comando As SQLiteCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resetlabels()
        Dim ds As DataSet
        ds = New DataSet
        comando.CommandText = "select IDMovimiento, Cantidad, Descripcion,Tipo, strftime(fecha) as fecha from Movimientos where Usuario = @Usuario"
        comando.Parameters.AddWithValue("@Usuario", GV.UsuarioActivo)
        comando.ExecuteNonQuery()
        Dim adapter As New SQLiteDataAdapter
        adapter.SelectCommand = comando
        adapter.Fill(ds, "Movimientos")
        DataGridView1.DataSource = ds.Tables("Movimientos")
        Dim v As Double = ObtenerBalance(ds.Tables("Movimientos"))
        LBLBalance_Total.Text = "$" & CType(v, String)
        DataGridView1.Show()
    End Sub

    Public Sub LoadDB()
        conexion = New SQLiteConnection
        Dim GCS As New DBinteraction
        conexion.ConnectionString = GCS.GetConnectionString
        conexion.Open()
        comando = New SQLiteCommand
        comando.Connection = conexion
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDB()
        CBODescGastos.DataSource = ConfigGasto
        CBODescGastos.DisplayMember = "Descripcion"
        CBODescGastos.ValueMember = "Descripcion"
        CBODescGastos.SelectedIndex = 0
    End Sub

    Private Sub BTNEspecifico_Click(sender As Object, e As EventArgs) Handles BTNEspecifico.Click
        resetlabels()
        Dim d1str, d2str As String
        d1str = Format(DTPDate1.Value, "yyyy-MM-dd")
        d2str = Format(DTPDate2.Value, "yyyy-MM-dd")
        Dim ds As New DataSet
        comando.CommandText = "select IDMovimiento, Cantidad, Descripcion,Tipo, strftime(fecha) as fecha from Movimientos WHERE Usuario= @Usuario and fecha between @fecha1 and @fecha2"
        comando.Parameters.AddWithValue("@Usuario", GV.UsuarioActivo)
        comando.Parameters.AddWithValue("@fecha1", d1str)
        comando.Parameters.AddWithValue("@fecha2", d2str)
        comando.ExecuteNonQuery()
        Dim adapter As New SQLiteDataAdapter
        adapter.SelectCommand = comando
        adapter.Fill(ds, "Movimientos")
        Dim v As Double = ObtenerBalance(ds.Tables("Movimientos"))
        DataGridView1.DataSource = ds.Tables("Movimientos")
        DataGridView1.Show()
        LBLBalance_Especifico.Text = "$" & CType(v, String)
    End Sub

    Private Function ObtenerBalance(ByVal table As DataTable) As Double
        Dim aux As Integer = 0
        Dim ro As DataRow
        Dim rowss As Integer = table.Rows.Count
        Dim val As Double
        For index As Integer = 0 To rowss - 1
            ro = table.Rows(aux)
            val = val + CDbl(ro("Cantidad"))
            aux = aux + 1
        Next
        Return val
    End Function

    Private Sub resetlabels()
        LBLBalance_Especifico.Text = "$"
        LBLBalance_Total.Text = "$"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DTPDate1.Value = "01/01/" & Date.Now.Year.ToString
        DTPDate2.Value = Date.Now
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DTPDate1.Value = "01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString
        DTPDate2.Value = Date.Now
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DTPDate1.Value = "01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString
        DTPDate2.Value = "15/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim DaysInMonth As Integer = Date.DaysInMonth(Date.Now.Year, Date.Now.Month)
        DTPDate1.Value = "15/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString
        DTPDate2.Value = DaysInMonth.ToString & "/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ds As New DataSet
        comando.CommandText = "select Cantidad, Descripcion,Tipo, strftime(fecha) as fecha from Movimientos where Usuario = @Usuario order by cantidad asc limit 5;"
        comando.Parameters.AddWithValue("@Usuario", GV.UsuarioActivo)
        comando.ExecuteNonQuery()
        Dim adapter As New SQLiteDataAdapter
        adapter.SelectCommand = comando
        adapter.Fill(ds, "Movimientos")
        Dim v As Double = ObtenerBalance(ds.Tables("Movimientos"))
        DataGridView1.DataSource = ds.Tables("Movimientos")
        DataGridView1.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ds As New DataSet
        comando.CommandText = "select Cantidad, Descripcion,Tipo, strftime(fecha) as fecha from Movimientos where Usuario = @Usuario and Descripcion = @Descripcion"
        comando.Parameters.AddWithValue("@Usuario", GV.UsuarioActivo)
        comando.Parameters.AddWithValue("@Descripcion", CBODescGastos.SelectedValue.ToString)
        comando.ExecuteNonQuery()
        Dim adapter As New SQLiteDataAdapter
        adapter.SelectCommand = comando
        adapter.Fill(ds, "Movimientos")
        Dim v As Double = ObtenerBalance(ds.Tables("Movimientos"))
        DataGridView1.DataSource = ds.Tables("Movimientos")
        DataGridView1.Show()
        LBLBalance_Total.Text = "$" & CType(v, String)
    End Sub
End Class
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Cargar.Click
        'TODO: esta línea de código carga datos en la tabla 'VG_DBDataSet.Juegos' Puede moverla o quitarla según sea necesario.
        Me.JuegosTableAdapter.Fill(Me.VG_DBDataSet.Juegos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_Primero.Click
        Me.JuegosBindingSource.MoveFirst()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_Anterior.Click
        Me.JuegosBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTN_Siguiente.Click
        Me.JuegosBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTN_Ultimo.Click
        Me.JuegosBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub
End Class

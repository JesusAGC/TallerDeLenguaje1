Public Class Form1
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTNCargarDatos_Click(sender As Object, e As EventArgs) Handles BTNCargarDatos.Click
        'TODO: esta línea de código carga datos en la tabla 'TL1_RocolaDataSet.Canciones' Puede moverla o quitarla según sea necesario.
        Me.CancionesTableAdapter.Fill(Me.TL1_RocolaDataSet.Canciones)
    End Sub

    Private Sub BtnPrimero_Click(sender As Object, e As EventArgs) Handles BtnPrimero.Click
        Me.CancionesBindingSource.MoveFirst()
    End Sub

    Private Sub BTNAnterior_Click(sender As Object, e As EventArgs) Handles BTNAnterior.Click
        Me.CancionesBindingSource.MovePrevious()
    End Sub

    Private Sub BTNSiguiente_Click(sender As Object, e As EventArgs) Handles BTNSiguiente.Click
        Me.CancionesBindingSource.MoveNext()
    End Sub

    Private Sub BTNUltimo_Click(sender As Object, e As EventArgs) Handles BTNUltimo.Click
        Me.CancionesBindingSource.MoveLast()
    End Sub
End Class

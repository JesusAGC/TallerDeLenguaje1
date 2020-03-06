Public Class Form1
    Private Sub CancionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CancionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CancionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TL1_RocolaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BTNCargarDatos_Click(sender As Object, e As EventArgs) Handles BTNCargarDatos.Click
        'TODO: esta línea de código carga datos en la tabla 'TL1_RocolaDataSet.Canciones' Puede moverla o quitarla según sea necesario.
        Me.CancionesTableAdapter.Fill(Me.TL1_RocolaDataSet.Canciones)
    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        End
    End Sub
End Class

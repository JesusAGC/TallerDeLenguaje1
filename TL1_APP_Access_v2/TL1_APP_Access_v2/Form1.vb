Public Class Form1
    Private Sub JuegosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JuegosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JuegosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VG_DBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BTN_Cargar_Click(sender As Object, e As EventArgs) Handles BTN_Cargar.Click
        'TODO: esta línea de código carga datos en la tabla 'VG_DBDataSet.Juegos' Puede moverla o quitarla según sea necesario.
        Me.JuegosTableAdapter.Fill(Me.VG_DBDataSet.Juegos)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub
End Class

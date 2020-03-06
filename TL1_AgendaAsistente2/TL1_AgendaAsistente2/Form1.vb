Public Class Form1
    Private Sub PersonaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PersonaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgendaDataSet)

    End Sub

    Private Sub PersonaBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PersonaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgendaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'AgendaDataSet.persona' Puede moverla o quitarla según sea necesario.
        Me.PersonaTableAdapter.Fill(Me.AgendaDataSet.persona)
    End Sub
End Class

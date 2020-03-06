Imports System.Data.SQLite
Public Class Form3
    Dim conexion As SQLiteConnection
    Dim comando As SQLiteCommand
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SQLiteConnection
        Dim GCS As New DBinteraction
        conexion.ConnectionString = GCS.GetConnectionString
        conexion.Open()
        comando = New SQLiteCommand
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando.CommandText = "insert into Usuarios(Usuario,Nombre,Email)values(@Usuario,@Nombre,@Email); "
        comando.Parameters.AddWithValue("@Usuario", TXBIdUsuario.Text)
        comando.Parameters.AddWithValue("@Nombre", TXBNombre.Text)
        comando.Parameters.AddWithValue("@Email", TXBEmail.Text)
        comando.ExecuteNonQuery()
        MessageBox.Show("Se ha añadido al sistema el usuario:" & TXBIdUsuario.Text)
    End Sub
End Class
Imports System.Data.OleDb
Public Class FrmAgendaSQL
    Dim strFileName As String
    Private Sub FrmAgendaSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTN_Limpiar_Click(sender As Object, e As EventArgs) Handles BTN_Limpiar.Click
        TxtId.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCalleYNumero.Clear()
        TxtColonia.Clear()
        TxtCiudad.Clear()
        TxtTelCasa.Clear()
        TxtTelCel.Clear()
        TxtEmailPersonal.Clear()
        TxtEmailTrabajo.Clear()
        PicFoto.Image = Nothing
        TxtId.Focus()
    End Sub

    Private Sub BTN_Buscar_Click(sender As Object, e As EventArgs) Handles BTN_Buscar.Click
        Dim BUSCAR = "SELECT * FROM persona WHERE Id=@Id"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, Cnx)
        CmdBuscar.CommandType = CommandType.Text
        CmdBuscar.Parameters.AddWithValue("@Id", TxtID.Text)
        Cnx.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            TxtNombre.Text = Lectura(1)
            TxtApellido.Text = Lectura(2)
            TxtCalleYNumero.Text = Lectura(3)
            TxtColonia.Text = Lectura(4)
            TxtCiudad.Text = Lectura(5)
            TxtTelCasa.Text = Lectura(6)
            TxtTelCel.Text = Lectura(7)
            TxtEmailPersonal.Text = Lectura(8)
            TxtEmailTrabajo.Text = Lectura(9)
            PicFoto.ImageLocation = Lectura(10)
        Else
            MsgBox("Los Datos a Buscar No Estan Registrados", MsgBoxStyle.Information, "Agenda")
            TxtID.Clear()
            TxtID.Focus()
        End If
        Cnx.Close()
    End Sub

    Private Sub BTN_Agregar_Click(sender As Object, e As EventArgs) Handles BTN_Agregar.Click
        Try
            Dim Insertar = "Insert Into persona Values (@Id, @Nombre, @Apellido, @CalleYNumero,
@Colonia, @Ciudad, @TelCasa, @TelCel, @EmailPersonal, @EmailTrabajo, @Fotografia)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", TxtID.Text)
            Cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            Cmd.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            Cmd.Parameters.AddWithValue("@CalleYNumero", TxtCalleYNumero.Text)
            Cmd.Parameters.AddWithValue("@Colonia", TxtColonia.Text)
            Cmd.Parameters.AddWithValue("@Ciudad", TxtCiudad.Text)
            Cmd.Parameters.AddWithValue("@TelCasa", TxtTelCasa.Text)
            Cmd.Parameters.AddWithValue("@TelCel", TxtTelCel.Text)
            Cmd.Parameters.AddWithValue("@EmailPersonal", TxtEmailPersonal.Text)
            Cmd.Parameters.AddWithValue("@EmailTrabajo", TxtEmailTrabajo.Text)
            PicFoto.ImageLocation = strFileName
            Cmd.Parameters.AddWithValue("@Fotografia", PicFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Registrado")
        Catch ex As Exception
            MsgBox("La Clave a Registrar Ya Existe")
        End Try
        TxtID.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCalleYNumero.Clear()
        TxtColonia.Clear()
        TxtCiudad.Clear()
        TxtTelCasa.Clear()
        TxtTelCel.Clear()
        TxtEmailPersonal.Clear()
        TxtEmailTrabajo.Clear()
        PicFoto.Image = Nothing
        TxtID.Focus()
    End Sub

    Private Sub BTN_Modificar_Click(sender As Object, e As EventArgs) Handles BTN_Modificar.Click
        Try
            Dim Actualizar = "UPDATE persona SET Id=@Id, Nombre=@Nombre, Apellido=@Apellido,
CalleYNumero=@CalleYNumero, Colonia=@Colonia, Ciudad=@Ciudad, TelCasa=@TelCasa,
TelCel=@TelCel, EmailPersonal=@EmailPersonal, EmailTrabajo=@EmailTrabajo,
Fotografia=@Fotografia WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Actualizar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", TxtID.Text)
            Cmd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
            Cmd.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
            Cmd.Parameters.AddWithValue("@CalleYNumero", TxtCalleYNumero.Text)
            Cmd.Parameters.AddWithValue("@Colonia", TxtColonia.Text)
            Cmd.Parameters.AddWithValue("@Ciudad", TxtCiudad.Text)
            Cmd.Parameters.AddWithValue("@TelCasa", TxtTelCasa.Text)
            Cmd.Parameters.AddWithValue("@TelCel", TxtTelCel.Text)
            Cmd.Parameters.AddWithValue("@EmailPersonal", TxtEmailPersonal.Text)
            Cmd.Parameters.AddWithValue("@EmailTrabajo", TxtEmailTrabajo.Text)
            Cmd.Parameters.AddWithValue("@Fotografia", PicFoto.ImageLocation)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Los Datos Del Contacto Fueron Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        TxtID.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCalleYNumero.Clear()
        TxtColonia.Clear()
        TxtCiudad.Clear()
        TxtTelCasa.Clear()
        TxtTelCel.Clear()
        TxtEmailPersonal.Clear()
        TxtEmailTrabajo.Clear()
        PicFoto.Image = Nothing
        TxtID.Focus()
    End Sub

    Private Sub BTN_Eliminar_Click(sender As Object, e As EventArgs) Handles BTN_Eliminar.Click
        Try
            Dim Eliminar = "DELETE FROM persona WHERE Id=@Id"
            Dim Cmd As New OleDbCommand(Eliminar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@Id", TxtID.Text)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("El Contacto Fue Eliminado....")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
        TxtID.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtCalleYNumero.Clear()
        TxtColonia.Clear()
        TxtCiudad.Clear()
        TxtTelCasa.Clear()
        TxtTelCel.Clear()
        TxtEmailPersonal.Clear()
        TxtEmailTrabajo.Clear()
        PicFoto.Image = Nothing
        TxtID.Focus()
    End Sub

    Private Sub BTM_CargarFoto_Click(sender As Object, e As EventArgs) Handles BTM_CargarFoto.Click
        With OpenFileDialog1
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                strFileName = OpenFileDialog1.FileName
                PicFoto.Image = Image.FromFile(strFileName)
                OpenFileDialog1.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
End Class

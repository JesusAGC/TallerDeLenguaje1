Imports System.Data.SQLite
Imports TL1_App1.DBinteraction
Public Class IntroForm
    Dim conexion As SQLiteConnection
    Dim comm As SQLiteCommand
    Private Sub IntroForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GV.UsuarioActivo = CBXUsuarios.SelectedValue
        Dim forma As Form1
        Me.Hide()
        forma = Form1
        If Not IsNothing(forma) Then
            forma.Show()
            forma.BringToFront()

        Else

            forma = Form1
            forma.Show()

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim forma As Form
        forma = Form3
        If Not IsNothing(forma) Then
            forma.Show()
            forma.BringToFront()

        Else
            forma = Form3
            forma.Show()

        End If
    End Sub

    Public Sub LoadCB()

        'MessageBox.Show(My.Application.Info.DirectoryPath)
        Dim conexion = New SQLiteConnection
        Dim bool As Boolean = False
        Dim GCS As New DBinteraction
        conexion.ConnectionString = GCS.GetConnectionString
        conexion.Open()
        Dim comm = New SQLiteCommand
        comm.CommandType = CommandType.Text
        comm.Connection = conexion
        comm.CommandText = "Select ID,Usuario from Usuarios;"
        Dim ds As DataSet
        ds = New DataSet

        Dim adapter As New SQLiteDataAdapter

        adapter.SelectCommand = comm
        adapter.Fill(ds, "Usuarios")

        CBXUsuarios.DataSource = ds.Tables("Usuarios")
        CBXUsuarios.DisplayMember = "Usuario"
        CBXUsuarios.ValueMember = "Usuario"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoadCB()

    End Sub


End Class
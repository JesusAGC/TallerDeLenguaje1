Imports System.Data.SQLite
Imports System.Data.SqlClient
Imports System.Resources


Public Class DBinteraction

    Dim SqlL As New SQLiteConnection
    Protected conexion As SQLiteConnection
    Protected comando As SQLiteCommand

    Protected Sub addParameter(ByVal nombre As String, ByVal value As Object)
        Dim par As SQLiteParameter = New SQLiteParameter
        par.ParameterName = nombre
        par.Value = value
        comando.Parameters.Add(par)

    End Sub

    Public Function GetConnectionString() As String
        Dim path As String = My.Application.Info.DirectoryPath
        path = path & "\AppDataBase.db"
        ' Dim bdfile As String = IO.Path.Combine(path, "\AppDataBase.db")
        'Dim path2 As String = ".\TL1_App1\Resources\AppDataBase.db"
        Return "Data Source=" & path & "; Version=3;"
    End Function

    Public Function GetDT_Descripcion(ByVal tipomov As String) As DataTable
        Dim comando As New SQLiteCommand
        Dim conexion As New SQLiteConnection
        conexion.ConnectionString = GetConnectionString()
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        Dim ds As New DataSet
        Dim adapter As New SQLiteDataAdapter
        Dim dtaux As New DataTable
        If tipomov.Equals("Ingreso") Then
            comando.CommandText = "select descripcion from DescripcionIngresoDefault"
            comando.ExecuteNonQuery()
            adapter.SelectCommand = comando
            adapter.Fill(ds, "DescripcionIngresoDefault")
            dtaux = ds.Tables("DescripcionIngresoDefault")
            Return dtaux
        ElseIf tipomov.Equals("Gasto") Then
            comando.CommandText = "select descripcion from DescripcionGastosDefault"
            comando.ExecuteNonQuery()
            adapter.SelectCommand = comando
            adapter.Fill(ds, "DescripcionGastosDefault")
            dtaux = ds.Tables("DescripcionGastosDefault")
            Return dtaux

        End If


    End Function


End Class

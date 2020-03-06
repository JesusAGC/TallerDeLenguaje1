Imports System.Data.SqlClient
Imports WindowsApp1.object1DTO
Imports System.Data.OleDb
Public Class Form2
    Dim ds As New DataSet

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = 1000
        Dim list1 As New List(Of object1DTO)
        Dim ds As New DataSet
        Dim tab1 As New DataTable
        tab1.Columns.Add("ID")
        tab1.Columns.Add("Data")
        tab1.Columns.Add("FK")
        tab1.Columns(0).AutoIncrement = True
        Dim index As Integer = 0
        For i As Integer = 0 To 6
            Dim objeto As New object1DTO
            Dim r As DataRow = tab1.NewRow
            r("ID") = index
            objeto.pk = index
            objeto.data1 = "datatest - " & index.ToString
            r("Data") = objeto.data1
            objeto.fk = CInt(Math.Ceiling(Rnd() * 11)) + 1
            r("FK") = objeto.fk
            list1.Add(objeto)
            tab1.Rows.Add(r)
            index += 1
        Next
        ds.Tables.Add(tab1)
        DataGridView2.DataSource = ds.Tables("Table1")
        DataGridView2.Show()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As Integer = CInt(TextBox1.Text)
        If time > 0 Then
            time = time - 1
            TextBox1.Text = time
        ElseIf time = 0 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = False Then
            Timer1.Start()
        ElseIf timer1.Enabled = True Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        Dim f1 As String
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Using sr As New System.IO.StreamReader(OpenFileDialog1.FileName)
                f1 = sr.ReadLine
            End Using
            MessageBox.Show(f1)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        Dim result As DialogResult = SaveFileDialog1.ShowDialog
        Dim str As String = TextBox2.Text
        If result = Windows.Forms.DialogResult.OK Then
            Dim file As New System.IO.StreamWriter(SaveFileDialog1.FileName)
            file.Write(str)
            file.Close()
            MessageBox.Show("Guardado exitoso")
        End If
    End Sub

    Private Sub ConnectOle()
        'Esto es un ejemplo que no corre sobre como se ejecuta un query de insert con OLEdb, por lo tanto el string de conexion
        'no tiene información real
        Dim connectstr As String = "Provider=Cualquier nombre de un proveedor de datos;OledbKey1=cualquier valor relacionado con el acceso;OledbKey2=Igual que el anterior;"
        Dim myconn As New OleDbConnection(connectstr)
        myconn.Open()

        Dim olecomand As New OleDbCommand("Insert into table table1(pk,data,fk) values(@pk,@data,@fk)")
        olecomand.Parameters.AddWithValue("@pk", 1)
        olecomand.Parameters.AddWithValue("@data2", "Data1")
        olecomand.Parameters.AddWithValue("@fk", 1)

        olecomand.ExecuteNonQuery()
        myconn.Close()

    End Sub
End Class
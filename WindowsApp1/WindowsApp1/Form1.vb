Public Class Form1
    Dim int1 As New Integer
    Dim int2 As New Integer
    Dim int3 As New Integer

    Public Function adder(ByVal int1 As Integer, ByVal int2 As Integer) As Integer
        Return int1 + int2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        int1 = CType(TextBox1.Text.ToString, Integer)
        int2 = CType(TextBox2.Text.ToString, Integer)
        int3 = adder(int1, int2)
        Label1.Text = int3.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As New Form2
        f2.Show()

    End Sub
End Class

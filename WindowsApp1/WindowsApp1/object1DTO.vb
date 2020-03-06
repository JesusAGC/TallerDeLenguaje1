Public Class object1DTO
    Dim _pk As Integer
    Dim _data1 As String
    Dim _fk As Integer

    Public Property pk As Integer
        Get
            Return _pk
        End Get
        Set(value As Integer)
            _pk = value
        End Set
    End Property

    Public Property data1 As String
        Get
            Return _data1
        End Get
        Set(value As String)
            _data1 = value
        End Set
    End Property

    Public Property fk As Integer
        Get
            Return _fk
        End Get
        Set(value As Integer)
            _fk = value
        End Set
    End Property

End Class

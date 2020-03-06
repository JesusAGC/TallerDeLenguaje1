Namespace DTO
    Public Class MovimientoDTO
        Dim DTOCantidad As Double
        Dim DTODescripcion As String
        Dim DTODetalle As String
        Dim DTOfecha As String
        Dim DTOTipo As String
        Dim DTOUsuario As String
        Public Property Cantidad As Double
            Get
                Return DTOCantidad
            End Get
            Set(value As Double)
                DTOCantidad = value
            End Set
        End Property

        Public Property Descripcion As String
            Get
                Return DTODescripcion
            End Get
            Set(value As String)
                DTODescripcion = value
            End Set
        End Property

        Public Property Detalles As String
            Get
                Return DTODetalle
            End Get
            Set(value As String)
                DTODetalle = value
            End Set
        End Property

        Public Property Fecha As String
            Get
                Return DTOfecha
            End Get
            Set(value As String)
                DTOfecha = value
            End Set
        End Property

        Public Property Tipo As String
            Get
                Return DTOTipo
            End Get
            Set(value As String)
                DTOTipo = value
            End Set
        End Property

        Public Property Usuario As String
            Get
                Return DTOUsuario
            End Get
            Set(value As String)
                DTOUsuario = value
            End Set
        End Property


    End Class
End Namespace

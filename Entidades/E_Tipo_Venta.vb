Public Class E_Tipo_Venta
    Private _idtipo_venta As Integer
    Private _descripcion As String

    Public Property Idtipo_venta As Integer
        Get
            Return _idtipo_venta
        End Get
        Set(value As Integer)
            _idtipo_venta = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class

Public Class E_Venta_Detalle
    Private _id_Venta As Integer
    Private _idProducto As Integer
    Private _precio As Double
    Private _cantidad As Double
    Private _cancelado As Integer
    Private _importe As Double
    Private _montoPagado As Double

    Public Property Id_Venta As Integer
        Get
            Return _id_Venta
        End Get
        Set(value As Integer)
            _id_Venta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
        End Set
    End Property

    Public Property Cancelado As Integer
        Get
            Return _cancelado
        End Get
        Set(value As Integer)
            _cancelado = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(value As Double)
            _importe = value
        End Set
    End Property

    Public Property MontoPagado As Double
        Get
            Return _montoPagado
        End Get
        Set(value As Double)
            _montoPagado = value
        End Set
    End Property
End Class

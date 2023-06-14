Public Class E_Compra
    Private _idCompra As Integer

    Public Property idCompra() As String
        Get
            Return _idCompra
        End Get
        Set(ByVal value As String)
            _idCompra = value
        End Set
    End Property

    Private _FechaCompra As String

    Public Property Fecha() As String
        Get
            Return _FechaCompra
        End Get
        Set(ByVal value As String)
            _FechaCompra = value
        End Set
    End Property

    Private _idTipoComprobante As Integer

    Public Property IdTipoComprobante() As Integer
        Get
            Return _idTipoComprobante
        End Get
        Set(ByVal value As Integer)
            _idTipoComprobante = value
        End Set
    End Property

    Private _idFactura As String

    Public Property IdFactura() As String
        Get
            Return _idFactura
        End Get
        Set(ByVal value As String)
            _idFactura = value
        End Set
    End Property

    Private _idProveedor As Integer

    Public Property IdProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(value As Integer)
            _idProveedor = value
        End Set
    End Property

    Private _importeTotal As Double

    Public Property ImporteTotal() As Double
        Get
            Return _importeTotal
        End Get
        Set(value As Double)
            _importeTotal = value
        End Set
    End Property

    Private _retencion As Double

    Public Property retencion() As Double
        Get
            Return _retencion
        End Get
        Set(value As Double)
            _retencion = value
        End Set
    End Property
End Class

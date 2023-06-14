Public Class E_Venta
    Private _idventa As Integer
    Private _idcliente As Integer
    Private _idempleado As Integer
    Private _fecha As String
    Private _idtipoventa As Integer

    Public Property Idventa As Integer
        Get
            Return _idventa
        End Get
        Set(value As Integer)
            _idventa = value
        End Set
    End Property

    Public Property Idcliente As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
        End Set
    End Property

    Public Property Idempleado As Integer
        Get
            Return _idempleado
        End Get
        Set(value As Integer)
            _idempleado = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Idtipoventa As Integer
        Get
            Return _idtipoventa
        End Get
        Set(value As Integer)
            _idtipoventa = value
        End Set
    End Property
End Class

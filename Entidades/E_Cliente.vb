Public Class E_Cliente
    Private _idCliente As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _telefono As String
    Private _nomyap As String

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public ReadOnly Property nomyap() As String
        Get
            Return _nombre & " " & _apellidos
        End Get
    End Property
End Class

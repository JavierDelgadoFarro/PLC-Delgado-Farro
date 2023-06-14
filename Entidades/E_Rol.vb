Public Class E_Rol
    Private _idrol As Integer
    Public Property idrol() As Integer
        Get
            Return _idrol
        End Get
        Set(ByVal value As Integer)
            _idrol = value
        End Set
    End Property

    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class

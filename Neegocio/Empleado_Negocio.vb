
Imports Entidades
Imports Datos

Public Class Empleado_Negocio
    Dim empleado_Dao As New Empleado_Datos()

    Public Function Mostrartodoempleado() As List(Of E_Empleado)
        Dim lista As New List(Of E_Empleado)
        Dim obj As New Empleado_Datos
        lista = obj.Mostrartodoempleado
        Return lista
    End Function

    'Para El login
    Public Function Validar(ByVal registros As E_Empleado) As Boolean
        Dim valor As Boolean
        Dim obj As New Empleado_Datos
        valor = obj.Validar(registros)

        Return valor
    End Function

    'Para obtener el idempleado
    Public Function obtener_idempleado(ByVal usuario As String) As List(Of E_Empleado)
        Dim lista As New List(Of E_Empleado)
        Dim obj As New Empleado_Datos
        lista = obj.obtener_idempleado(usuario)
        Return lista
    End Function


    Public Function empleado(ByVal id As Int32) As List(Of E_Empleado)
        Dim lista_empleado As New List(Of E_Empleado)
        Dim obj As New Empleado_Datos
        lista_empleado = obj.empleado(id)
        Return lista_empleado
    End Function

#Region "Atributos"
    'Atributos'

    Private id
    Private nombre
    Private apellido
    Private contraseña
    Private idRol
    Private usuario
    Public Property Id1 As Object
        Get
            Return id
        End Get
        Set(value As Object)
            id = value
        End Set
    End Property

    Public Property Nombre1 As Object
        Get
            Return nombre
        End Get
        Set(value As Object)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As Object
        Get
            Return apellido
        End Get
        Set(value As Object)
            apellido = value
        End Set
    End Property

    Public Property Contraseña1 As Object
        Get
            Return contraseña
        End Get
        Set(value As Object)
            contraseña = value
        End Set
    End Property

    Public Property IdRol1 As Object
        Get
            Return idRol
        End Get
        Set(value As Object)
            idRol = value
        End Set
    End Property

    Public Property Usuario1 As Object
        Get
            Return usuario
        End Get
        Set(value As Object)
            usuario = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Object, nombre As Object, apellido As Object, contraseña As Object, idRol As Object, usuario As Object)
        Me.Id1 = id
        Me.Nombre1 = nombre
        Me.Apellido1 = apellido
        Me.Contraseña1 = contraseña
        Me.IdRol1 = idRol
        Me.Usuario1 = usuario
    End Sub
#End Region

    Public Sub modificar_perfil(ByVal registros As E_Empleado)
        Try
            Dim Datos As New Empleado_Datos
            Datos.modificar_perfil(registros)
            MessageBox.Show("Perfil actualizado satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show("Error , Usuario ya existente")
        End Try
    End Sub

    'Para Agregar Nuevo Empleado'
    Public Sub Agregar_Empleado(ByVal registros As E_Empleado)
        Dim Datos As New Empleado_Datos
        Datos.Agregar_Empleado(registros)
    End Sub

    'Para modificar un empleado'
    Public Sub modificar_Empleado(ByVal registros As E_Empleado)
        Dim Datos As New Empleado_Datos
        Datos.modificar_perfil(registros)
    End Sub

    'Buscar Todo empleado' 
    Public Function buscartodoempleado(ByVal nombre As String) As List(Of E_Empleado)
        Dim lista As New List(Of E_Empleado)
        Dim obj As New Empleado_Datos
        lista = obj.buscartodoempleado(nombre)
        Return lista
    End Function

    'Eliminar Empleado' 
    Public Sub Eliminar_empleado(ByVal registros As E_Empleado)
        Dim Datos As New Empleado_Datos
        Datos.Eliminar_Empleado(registros)
    End Sub



End Class
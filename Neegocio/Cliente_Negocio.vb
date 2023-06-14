Imports Entidades
Imports Datos

Public Class Cliente_Negocio

    ' para mostrar cliente
    Public Function Mostrartodocliente() As List(Of E_Cliente)
        Dim lista As New List(Of E_Cliente)
        Dim obj As New Cliente_Datos
        lista = obj.Mostrartodocliente
        Return lista
    End Function

    'para buscar cliente
    Public Function buscacliente(ByVal nombre As String) As List(Of E_Cliente)
        Dim lista As New List(Of E_Cliente)
        Dim obj As New Cliente_Datos
        lista = obj.buscacliente(nombre)
        Return lista
    End Function

    'Para agregar un cliente'
    Public Sub Nuevo_cliente(ByVal registros As E_Cliente)
        Dim Datos As New Cliente_Datos
        Datos.Nuevo_cliente(registros)
    End Sub

    'Para modificar un cliente'
    Public Sub modificar_cliente(ByVal registros As E_Cliente)
        Dim Datos As New Cliente_Datos
        Datos.modificar_cliente(registros)
    End Sub

    'Eliminar Cliente' 
    Public Sub Eliminar_cliente(ByVal registros As E_Cliente)
        Dim Datos As New Cliente_Datos
        Datos.Eliminar_Cliente(registros)
    End Sub
End Class

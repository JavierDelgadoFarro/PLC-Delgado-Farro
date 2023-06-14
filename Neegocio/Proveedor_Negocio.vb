Imports Datos
Imports Entidades
Public Class Proveedor_Negocio

    'Mostrar proveedor'
    Public Function Mostrarproveedor() As List(Of E_Proveedor)
        Dim lista_proveedor As New List(Of E_Proveedor)
        Dim obj As New Proveedor_Datos
        lista_proveedor = obj.Mostrar_Proveedor
        Return lista_proveedor
    End Function

    'Agregar Proveedor'
    Public Sub Agregar_Proveedor(ByVal registros As E_Proveedor)
        Dim Datos As New Proveedor_Datos
        Datos.Nuevo_Proveedor(registros)
    End Sub

    'Modificar Proveedor'
    Public Sub Modificar_Proveedor(ByVal registros As E_Proveedor)
        Dim Datos As New Proveedor_Datos
        Datos.Modificar_Proveedor(registros)
    End Sub

    'Eliminar Proveedor' 
    Public Sub Eliminar_proveedor(ByVal registros As E_Proveedor)
        Dim Datos As New Proveedor_Datos
        Datos.Eliminar_Proveedor(registros)
    End Sub

    'Buscar Proveedor'
    Public Function Buscar_Proveedor(ByVal nombre As String) As List(Of E_Proveedor)
        Dim lista_proveedor As New List(Of E_Proveedor)
        Dim obj As New Proveedor_Datos
        lista_proveedor = obj.Buscar_Proveedor(nombre)
        Return lista_proveedor
    End Function

End Class

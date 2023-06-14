Imports Datos
Imports Entidades

Public Class Rol_Negocio

    Public Function Mostrar_rol() As List(Of E_Rol)
        Dim lista_rol As New List(Of E_Rol)
        Dim obj As New Rol_Datos
        lista_rol = obj.Mostrar_rol
        Return lista_rol
    End Function


End Class

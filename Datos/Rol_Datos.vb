Imports Entidades
Imports System.Data.SqlClient

Public Class Rol_Datos

    Inherits Conexion
    'Para listar una categoría'
    Public Function Mostrar_rol() As List(Of E_Rol)
        Dim lista_rol As New List(Of E_Rol)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrarrol", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Rol
                reg.idrol = dr.GetValue(0).ToString()
                reg.descripcion = dr.GetValue(1).ToString()
                lista_rol.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_rol
    End Function

End Class

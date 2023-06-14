Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades
Public Class Proveedor_Datos
    Inherits Conexion

    'Mostrar Proveedor'
    Public Function Mostrar_Proveedor() As List(Of E_Proveedor)
        Dim lista_proveedor As New List(Of E_Proveedor)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("mostrartodoproveedores", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Proveedor
                reg.idproveedor = dr.GetValue(0).ToString
                reg.nombre = dr.GetValue(1).ToString()
                reg.RUC = dr.GetValue(2).ToString()
                reg.representante = dr.GetValue(3).ToString()
                reg.direccion = dr.GetValue(4).ToString()
                reg.telefono = dr.GetValue(5).ToString()
                lista_proveedor.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_proveedor
    End Function

    'Agregar proveedor'
    Public Sub Nuevo_Proveedor(ByVal registros As E_Proveedor)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_nuevoproveedor", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@ruc", registros.RUC)
                .AddWithValue("@representante", registros.representante)
                .AddWithValue("@direccion", registros.direccion)
                .AddWithValue("@telefono", registros.Telefono)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub

    'Modificar proveedor'
    Public Sub Modificar_Proveedor(ByVal registros As E_Proveedor)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_modificarproveedor", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproveedor", registros.idproveedor)
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@ruc", registros.RUC)
                .AddWithValue("@representante", registros.representante)
                .AddWithValue("@direccion", registros.direccion)
                .AddWithValue("@telefono", registros.Telefono)
            End With
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'Eliminar Proveedor'
    Public Sub Eliminar_Proveedor(ByVal registros As E_Proveedor)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_eliminarproveedor", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproveedor", registros.idproveedor)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub

    'Buscar Proveedor'
    Public Function Buscar_Proveedor(ByVal nombre As String) As List(Of E_Proveedor)

        Dim lista_proveedor As New List(Of E_Proveedor)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Try
                Dim cmd As New SqlCommand("p_buscaproveedor", conexion_return)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nombre", nombre)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New E_Proveedor
                    reg.idproveedor = dr.GetValue(0).ToString()
                    reg.nombre = dr.GetValue(1).ToString()
                    reg.RUC = dr.GetValue(2).ToString()
                    reg.representante = dr.GetValue(3).ToString()
                    reg.direccion = dr.GetValue(4).ToString()
                    reg.Telefono = dr.GetValue(5).ToString()
                    lista_proveedor.Add(reg)
                End While
                dr.Close()
            Catch ex As Exception
            End Try
        End Using
        Return lista_proveedor

    End Function
End Class

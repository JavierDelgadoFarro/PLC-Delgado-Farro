Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Cliente_Datos
    Inherits Conexion

    'funcion para mostrar el nombre y apellido del cliente
    Public Function Mostrarcliente() As List(Of E_Cliente)
        Dim lista As New List(Of E_Cliente)

        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_cliente", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Cliente
                reg.idcliente = dr.GetValue(0).ToString()
                reg.nombre = dr.GetValue(1).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function

    'funcion para mostrar el nombre y apellido del cliente
    Public Function Mostrartodocliente() As List(Of E_Cliente)
        Dim lista As New List(Of E_Cliente)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrartodocliente", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Cliente
                reg.idcliente = dr.GetValue(0).ToString()
                reg.nombre = dr.GetValue(1).ToString()
                reg.apellidos = dr.GetValue(2).ToString()
                reg.telefono = dr.GetValue(3).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function


    Public Function buscacliente(ByVal nombre As String) As List(Of E_Cliente)

        Dim lista As New List(Of E_Cliente)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Try
                Dim cmd As New SqlCommand("p_buscacliente", conexion_return)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nombre", nombre)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New E_Cliente
                    reg.idcliente = dr.GetValue(0).ToString()
                    reg.nombre = dr.GetValue(1).ToString()
                    reg.apellidos = dr.GetValue(2).ToString()
                    reg.telefono = dr.GetValue(3).ToString()
                    lista.Add(reg)
                End While
                dr.Close()
            Catch ex As Exception
            End Try
        End Using

        Return lista

    End Function

    'para agregar un nuevo cliente'
    Public Sub Nuevo_cliente(ByVal registros As E_Cliente)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_nuevocliente", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.Nombre)
                .AddWithValue("@apellido", registros.Apellidos)
                .AddWithValue("@telefono", registros.Telefono)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()

        End Using
    End Sub

    'para modificar un cliente'
    Public Sub modificar_cliente(ByVal registros As E_Cliente)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_modificarcliente", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.Nombre)
                .AddWithValue("@apellido", registros.Apellidos)
                .AddWithValue("@telefono", registros.Telefono)
                .AddWithValue("@idcliente", registros.IdCliente)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()

        End Using
    End Sub

    'Eliminar Cliente'
    Public Sub Eliminar_Cliente(ByVal registros As E_Cliente)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_eliminarcliente", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcliente", registros.IdCliente)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub


End Class

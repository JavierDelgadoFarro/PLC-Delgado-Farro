Imports System.Data.SqlClient
Imports System.Configuration
Imports Entidades

Public Class Categoria_Datos
    Inherits Conexion
    'Para listar una categoría'
    Public Function Mostrar_categoria() As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrarcategoria", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Categoria
                reg.idcategoria = dr.GetValue(0).ToString()
                reg.nombre = dr.GetValue(1).ToString()
                reg.descripcion = dr.GetValue(2).ToString()
                lista_categoria.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista_categoria
    End Function

    'Agregar una categoria'
    Public Sub Agregar_Categoria(ByVal registros As E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_nuevacategoria", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@descripcion", registros.descripcion)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub

    'modificar categoria'
    Public Sub Modificar_Categoria(ByVal registros As E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_modificarcategoria", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@descripcion", registros.descripcion)
                .AddWithValue("@idcategoria", registros.idcategoria)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub

    'Eliminar categoria'
    Public Sub Eliminar_Categoria(ByVal registros As E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_eliminarcategoria", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcategoria", registros.idcategoria)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub

    'Buscar categoria'
    Public Function Buscar_Categoria(ByVal nombre As String) As List(Of E_Categoria)

        Dim lista_categoria As New List(Of E_Categoria)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Try
                Dim cmd As New SqlCommand("p_buscacategoria", conexion_return)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nombre", nombre)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New E_Categoria
                    reg.idcategoria = dr.GetValue(0).ToString()
                    reg.nombre = dr.GetValue(1).ToString()
                    reg.descripcion = dr.GetValue(2).ToString()
                    lista_categoria.Add(reg)
                End While
                dr.Close()
            Catch ex As Exception
            End Try
        End Using
        Return lista_categoria

    End Function
End Class

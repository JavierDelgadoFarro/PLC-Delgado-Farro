Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Producto_Datos
    Inherits Conexion
    Public Function Mostrarproducto(ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)

        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_producto", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idcategoria", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.idproducto = dr.GetValue(0).ToString
                reg.nombre = dr.GetValue(1).ToString()
                reg.idcategoria = dr.GetValue(2).ToString()
                reg.precio = dr.GetValue(3).ToString()
                reg.stock = dr.GetValue(4).ToString()
                reg.idproveedor = dr.GetValue(5).ToString()
                reg.foto = dr.GetValue(6).ToString()
                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function

    Public Function preciostock(ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_preciostock", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idproducto", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.precio = dr.GetValue(0).ToString()
                reg.stock = dr.GetValue(1).ToString()
                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function

    'Metodo para Actualizar Stock en las ventas '
    Public Sub Actualiza_Stock(ByVal registros As E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("actualizastock", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@stock", registros.stock)
                .AddWithValue("@idproducto", registros.idproducto)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
    End Sub

    'Metodo que actualiza el stock en las compras'
    Public Sub Actualiza_StockCompras(ByVal registros As E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_actualizasotckcompra", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@stock", registros.stock)
                .AddWithValue("@idproducto", registros.idproducto)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
    End Sub


    'Mostrar todos los productos'

    Public Function Mostrartodosproductos() As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_mostrartodoproductos", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.idproducto = dr.GetValue(0).ToString
                reg.nombre = dr.GetValue(1).ToString()
                reg.idcategoria = dr.GetValue(2).ToString()
                reg.precio = dr.GetValue(3).ToString()
                reg.stock = dr.GetValue(4).ToString()
                reg.idproveedor = dr.GetValue(5).ToString()
                reg.foto = dr.GetValue(6).ToString()
                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function

    'Metodo para mostrar productos que tengan stock menor a 3'

    Public Function productos_pa_comprar() As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("productos_pa_comprar", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.nombre = dr.GetValue(0).ToString()
                reg.stock = IIf(dr.GetValue(1).ToString() = "", 0, dr.GetValue(1).ToString)
                reg.foto = dr.GetValue(2).ToString()
                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function

    'Metodo para buscartodoproducto sin importar la categoria'

    Public Function buscartodoproducto(ByVal nombre As String) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_buscartodoproducto", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.idproducto = dr.GetValue(0).ToString
                reg.nombre = dr.GetValue(1).ToString()
                reg.idcategoria = dr.GetValue(2).ToString()
                reg.precio = dr.GetValue(3).ToString()
                reg.stock = dr.GetValue(4).ToString()
                reg.foto = dr.GetValue(5).ToString()
                reg.idproveedor = dr.GetValue(6).ToString()

                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function


    Public Function buscarnomycat(ByVal nombre As String, ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_buscarnomycat", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@idcategoria", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Producto
                reg.idproducto = dr.GetValue(0).ToString
                reg.nombre = dr.GetValue(1).ToString()
                reg.idcategoria = dr.GetValue(2).ToString()
                reg.precio = dr.GetValue(3).ToString()
                reg.stock = dr.GetValue(4).ToString()
                reg.idproveedor = dr.GetValue(5).ToString()
                reg.foto = dr.GetValue(6).ToString()
                lista.Add(reg)
            End While
            dr.Close()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return lista
    End Function

    'Agregar Nuevo Producto'
    Public Sub Agregar_Producto(ByVal registros As E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_nuevoproducto", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@idcategoria", registros.idcategoria)
                .AddWithValue("@precio", registros.precio)
                .AddWithValue("@stock", registros.stock)
                .AddWithValue("@idproveedor", registros.idproveedor)
                .AddWithValue("@foto", registros.foto)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
    End Sub

    'Para modificar un producto'
    Public Sub modificar_producto(ByVal registros As E_Producto)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_modificarproducto", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("idproducto", registros.idproducto)
                .AddWithValue("@nombre", registros.nombre)
                .AddWithValue("@idcategoria", registros.idcategoria)
                .AddWithValue("@precio", registros.precio)
                .AddWithValue("@stock", registros.stock)
                .AddWithValue("@idproveedor", registros.idproveedor)
                .AddWithValue("@foto", registros.foto)

            End With
            cmd.ExecuteNonQuery()
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
    End Sub


    'Para saber cuantos productos es que hay'

    Public Function contarproductos() As Integer
        Dim logeo As Integer
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("maxproductos", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            cmd.ExecuteNonQuery()
            logeo = CType(cmd.Parameters.Item("@RETURN_VALUE").Value, Integer)
            conexion_return.Dispose()
            conexion_return.Close()
        End Using

        Return logeo

    End Function

    Public Function contarproductosporfiltro(ByVal nombre As String) As Integer
        Dim logeo As Integer
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_contarproductosporfiltro", conexion_return)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            cmd.ExecuteNonQuery()
            logeo = CType(cmd.Parameters.Item("@RETURN_VALUE").Value, Integer)
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return logeo
    End Function


    Public Function contarproductosporcategoria(ByVal id As Integer) As Integer
        Dim logeo As Integer
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_contarproductosporcategoria", conexion_return)
            cmd.Parameters.AddWithValue("@idcategoria", id)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            cmd.ExecuteNonQuery()
            logeo = CType(cmd.Parameters.Item("@RETURN_VALUE").Value, Integer)
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return logeo
    End Function

    'cuenta los productos que hay en cierta categoria segun su nombre'
    Public Function contarproductospornombreycategoria(ByVal nombre As String, ByVal id As Integer) As Integer
        Dim logeo As Integer
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_contarnomycate", conexion_return)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@idcategoria", id)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
            cmd.ExecuteNonQuery()
            logeo = CType(cmd.Parameters.Item("@RETURN_VALUE").Value, Integer)
            conexion_return.Dispose()
            conexion_return.Close()
        End Using
        Return logeo
    End Function

End Class
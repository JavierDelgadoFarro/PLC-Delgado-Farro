Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class Venta_Detalle_Datos
    Inherits Conexion
    Public Sub Nueva_VentaDetalle(ByVal registros As E_Venta_Detalle)

        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_regitrarventadetalle", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproducto", registros.IdProducto)
                .AddWithValue("@precio", registros.Precio)
                .AddWithValue("@cantidad", registros.Cantidad)
                .AddWithValue("@cancelado", registros.Cancelado)
            End With
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    'muestra cuando debe un determinado cliente se utiliza en el formulario pagos'

    Public Function listardeuda(ByVal id As Integer) As List(Of E_Venta_Detalle)
        Dim lista As New List(Of E_Venta_Detalle)

        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_listardeuda1", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idcliente", id)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Venta_Detalle
                reg.Id_Venta = dr.GetValue(0).ToString
                reg.IdProducto = dr.GetValue(1).ToString()
                reg.Importe = dr.GetValue(2).ToString() 'aqui importe representa importe - montopagado'
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function

    Public Sub Actualiza_deudas(ByVal registros As E_Venta_Detalle)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_actualiventadetalle", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idventa", registros.Id_Venta)
                .AddWithValue("@idproducto", registros.IdProducto)
                .AddWithValue("@cancelado", registros.Cancelado)
                .AddWithValue("@montopagado", registros.MontoPagado)
            End With
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class

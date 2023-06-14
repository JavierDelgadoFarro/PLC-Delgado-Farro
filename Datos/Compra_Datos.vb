Imports System.Data.SqlClient
Imports System.Data
Imports Entidades
Public Class Compra_Datos

    Inherits Conexion

    Public Sub NuevaCompra(ByVal registro As E_Compra)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("agregarcompra", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("@idtipocomprobante", registro.IdTipoComprobante)
                .AddWithValue("@idfactura", registro.IdFactura)
                .AddWithValue("@idproveedor", registro.IdProveedor)
                .AddWithValue("@importe_total", registro.ImporteTotal)
                .AddWithValue("@retencion", registro.retencion)
                .AddWithValue("@fecha", registro.Fecha)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()

        End Using
    End Sub

    Public Function pago_rus(ByVal fecha As String) As List(Of E_Compra)
        Dim lista As New List(Of E_Compra)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_calcularus", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@fecha", fecha)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New E_Compra
                reg.ImporteTotal = IIf(dr.GetValue(0).ToString = "", 0, dr.GetValue(0).ToString())
                reg.retencion = IIf(dr.GetValue(1).ToString = "", 0, dr.GetValue(1).ToString())
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function


End Class

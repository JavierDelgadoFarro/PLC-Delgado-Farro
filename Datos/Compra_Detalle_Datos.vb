Imports System.Data.SqlClient
Imports Entidades
Imports System.Data

Public Class Compra_Detalle_Datos
    Inherits Conexion

    Public Sub NuevaCompraDetalle(ByVal registro As E_Compra_Detalle)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_registrarcompradetalle", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idproducto", registro.IdProducto)
                .AddWithValue("@importe", registro.Importe)
                .AddWithValue("@cantidad", registro.Cantidad)


            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub


End Class

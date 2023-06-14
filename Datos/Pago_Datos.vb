Imports System.Data.SqlClient
Imports Entidades
Imports System.Data
Public Class Pago_Datos
    Inherits Conexion
    Public Sub Nuevo_Pagos(ByVal registros As E_Pagos)
        Using conexion_return = GetConexion()
            conexion_return.Open()

            Dim cmd As New SqlCommand("p_insertarpagos", conexion_return)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcliente", registros.idcliente)
                .AddWithValue("@monto", registros.monto)
                .AddWithValue("@fecha", registros.fecha)
            End With
            cmd.ExecuteNonQuery()
            conexion_return.Close()
            conexion_return.Dispose()
        End Using
    End Sub
End Class

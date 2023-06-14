Imports System.Data
Imports System.Data.SqlClient
Imports Entidades
Public Class Venta_Datos
    Inherits Conexion
    Public Sub Nueva_Venta(ByVal registros As E_Venta)
        Using conexion_return = GetConexion()
            conexion_return.Open()
            Dim cmd As New SqlCommand("p_venta", conexion_return)

            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@idcliente", registros.Idcliente)
                .AddWithValue("@idempleado", registros.Idempleado)
                .AddWithValue("@fecha", registros.Fecha)
                .AddWithValue("@idtipoventa", registros.Idtipoventa)
            End With
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class


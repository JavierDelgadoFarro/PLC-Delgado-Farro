Imports Datos
Imports Entidades
Public Class Pagos_Negocio
    Public Sub Nuevo_Pago(ByVal registros As E_Pagos)
        Dim Datos As New Pago_Datos
        Datos.Nuevo_Pagos(registros)
    End Sub
End Class

Imports Datos
Imports Entidades
Public Class Compra_Detalle_Negocio

    Public Sub Nueva_Compra_Detalle(ByVal registros As E_Compra_Detalle)
        Dim Datos As New Compra_Detalle_Datos
        Datos.NuevaCompraDetalle(registros)
    End Sub

End Class

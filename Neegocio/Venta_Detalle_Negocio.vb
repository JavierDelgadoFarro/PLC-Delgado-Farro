Imports Datos
Imports Entidades

Public Class Venta_Detalle_Negocio
    Public Sub Nueva_VentaDetalle(ByVal registros As E_Venta_Detalle)
        Dim Datos As New Venta_Detalle_Datos
        Datos.Nueva_VentaDetalle(registros)
    End Sub

    'para listar lo que debe un cliente determinado
    Public Function listardeuda(ByVal id As Integer) As List(Of E_Venta_Detalle)
        Dim lista As New List(Of E_Venta_Detalle)
        Dim obj As New Venta_Detalle_Datos
        lista = obj.listardeuda(id)
        Return lista
    End Function

    'Para actualizar a los clientes que deben'
    Public Sub Actualiza_deudas(ByVal registros As E_Venta_Detalle)
        Dim Datos As New Venta_Detalle_Datos
        Datos.Actualiza_deudas(registros)
    End Sub
End Class

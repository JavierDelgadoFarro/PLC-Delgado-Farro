Imports Datos
Imports Entidades

Public Class Compra_Negocio
    Public Sub Nueva_Compra(ByVal registro As E_Compra)
        Dim Datos As New Compra_Datos
        Datos.NuevaCompra(registro)
    End Sub

    Public Function pago_rus(ByVal fecha As String) As List(Of E_Compra)
        Dim lista As New List(Of E_Compra)
        Dim obj As New Compra_Datos
        lista = obj.pago_rus(fecha)
        Return lista
    End Function


End Class

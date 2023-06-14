Imports Datos
Imports Entidades

Public Class Venta_Negocio
    Public Sub Nueva_Venta(ByVal registros As E_Venta)
        Dim Datos As New Venta_Datos
        Datos.Nueva_Venta(registros)
    End Sub
End Class

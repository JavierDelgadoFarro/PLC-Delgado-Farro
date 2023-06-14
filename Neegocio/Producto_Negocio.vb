
Imports Datos
Imports Entidades
Public Class Producto_Negocio
    'para mostrar todos los productos por categoria
    Public Function Mostrarproducto(ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.Mostrarproducto(id)
        Return lista
    End Function


    'para obtener  precio stock
    Public Function preciostock(ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.preciostock(id)
        Return lista
    End Function

    'para obtener el id del producto
    'Public Function obtener_idproducto(ByVal nombre As String) As List(Of Entidad_Producto)
    '    Dim lista As New List(Of Entidad_Producto)
    '    Dim obj As New Dato_Producto
    '    lista = obj.obtener_idproducto(nombre)
    '    Return lista
    'End Function

    'Para Actualizar solo el stock de los productos'

    Public Sub Actualiza_Stock(ByVal registros As E_Producto)
        Dim Datos As New Producto_Datos
        Datos.Actualiza_Stock(registros)
    End Sub

    'Metodo para actualizar stock en compras'
    Public Sub Actualiza_Stockcompras(ByVal registros As E_Producto)
        Dim Datos As New Producto_Datos
        Datos.Actualiza_StockCompras(registros)
    End Sub

    'Para Mostrar todos los productos'

    Public Function Mostrartodosproducto() As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.Mostrartodosproductos
        Return lista
    End Function

    Public Function productos_pa_comprar() As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.productos_pa_comprar
        Return lista
    End Function

    'Buscar Todo Producto' 
    Public Function buscartodoproducto(ByVal nombre As String) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.buscartodoproducto(nombre)
        Return lista
    End Function

    'Buscar Todo Producto' 
    Public Function buscarnomcat(ByVal nombre As String, ByVal id As Integer) As List(Of E_Producto)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Datos
        lista = obj.buscarnomycat(nombre, id)
        Return lista
    End Function

    'Para Agregar Nuevo Producto'
    Public Sub Agregar_Producto(ByVal registros As E_Producto)
        Dim Datos As New Producto_Datos
        Datos.Agregar_Producto(registros)
    End Sub

    'Para modificar un producto'
    Public Sub modificar_Producto(ByVal registros As E_Producto)
        Dim Datos As New Producto_Datos
        Datos.modificar_producto(registros)
    End Sub

    'Funcion que cuenta los productos sin importar categoria'
    Public Function contarproductos() As Integer
        Dim valor As Integer
        Dim obj As New Producto_Datos
        valor = obj.contarproductos
        Return valor
    End Function
    'Funcion que cuenta los productos pero filtrando por categoria'
    Public Function contarproductosporfiltro(ByVal nombre As String) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Datos
        valor = obj.contarproductosporfiltro(nombre)
        Return valor
    End Function


    Public Function contarproductosporcategoria(ByVal id As Integer) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Datos
        valor = obj.contarproductosporcategoria(id)
        Return valor
    End Function

    Public Function contarproductospornomycat(ByVal nombre As String, ByVal id As Integer) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Datos
        valor = obj.contarproductospornombreycategoria(nombre, id)
        Return valor
    End Function

End Class

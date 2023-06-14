Imports Datos
Imports Entidades
Public Class Categoria_Negocio
    Public Function Mostrar_categoria() As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Datos
        lista_categoria = obj.Mostrar_categoria
        Return lista_categoria
    End Function

    'Agregar una Categoria'
    Public Sub Agregar_categoria(ByVal registros As E_Categoria)
        Dim Datos As New Categoria_Datos
        Datos.Agregar_Categoria(registros)
    End Sub

    'Modificar categoria'
    Public Sub Modificar_categoria(ByVal registros As E_Categoria)
        Dim Datos As New Categoria_Datos
        Datos.Modificar_Categoria(registros)
    End Sub

    'Eliminar Categoria' 
    Public Sub Eliminar_categoria(ByVal registros As E_Categoria)
        Dim Datos As New Categoria_Datos
        Datos.Eliminar_Categoria(registros)
    End Sub

    'Buscar categorias'
    Public Function Buscar_categoria(ByVal nombre As String) As List(Of E_Categoria)
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Datos
        lista_categoria = obj.Buscar_Categoria(nombre)
        Return lista_categoria
    End Function
End Class

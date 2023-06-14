
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Datos
Imports Entidades
Imports Negocio
Public Class Mantenimiento_Categoria

    'mostrar categoria'
    Private Sub personalizargridview(ByVal grid As DataGridView)
        With grid
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False 'desactivar el estilo visual'
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(214, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .RowHeadersVisible = False
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .AllowUserToResizeRows = False
        End With
    End Sub
    Private Sub Cargar_gridview()
        Dim lista_categoria As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista_categoria = obj.Mostrar_categoria
        DGV_Categoria.DataSource = lista_categoria
    End Sub

    Private Sub Mantenimiento_Categoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        personalizargridview(Me.DGV_Categoria)
        Cargar_gridview()
    End Sub

    'agregar categoria'
    Private Sub limpiar()
        labelidcategoria.Text = ""
        txtnombrecategoria.Text = ""
        txtdescripcioncategoria.Text = ""
    End Sub

    Private Sub Habilitar_deshabilitar(ByVal bol As Boolean)
        DGV_Categoria.Enabled = bol
        btnmodificarcategoria.Enabled = bol
        btneliminarcategoria.Enabled = bol
        txtbuscarcategoria.Enabled = bol
    End Sub
    Private Sub btnnuevacategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevacategoria.Click
        If btnnuevacategoria.Text = "Nuevo" Then
            btnnuevacategoria.Text = "Guardar"
            limpiar()
            Habilitar_deshabilitar(False)
        ElseIf btnnuevacategoria.Text = "Guardar" Then
            Habilitar_deshabilitar(True)
            Agregar_categoria()
            Cargar_gridview()
        End If
    End Sub

    Private Sub Agregar_categoria()
        Dim Entidad As New E_Categoria
        Dim Negocio As New Categoria_Negocio
        With Entidad
            .nombre = txtnombrecategoria.Text
            .descripcion = txtdescripcioncategoria.Text
        End With

        Negocio.Agregar_categoria(Entidad)
    End Sub

    Private Sub DGV_Categoria_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Categoria.SelectionChanged
        Dim fila As Integer
        fila = DGV_Categoria.CurrentCell.RowIndex
        labelidcategoria.Text = Me.DGV_Categoria(0, fila).Value.ToString()
        txtnombrecategoria.Text = Me.DGV_Categoria(1, fila).Value.ToString()
        txtdescripcioncategoria.Text = Me.DGV_Categoria(2, fila).Value.ToString()
    End Sub

    'Modificar categoria'
    Private Sub Modificar_categoria()
        Dim Entidad As New E_Categoria
        Dim Negocio As New Categoria_Negocio
        With Entidad
            .nombre = txtnombrecategoria.Text
            .descripcion = txtdescripcioncategoria.Text
            .idcategoria = labelidcategoria.Text
        End With

        Negocio.Modificar_categoria(Entidad)
    End Sub
    Private Sub btnmodificarcategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarcategoria.Click
        Modificar_categoria()
        Cargar_gridview()
    End Sub

    'Eliminar categoria'
    Private Sub Eliminar_categoria()
        Dim Entidad As New E_Categoria
        Dim Negocio As New Categoria_Negocio
        With Entidad
            .nombre = txtnombrecategoria.Text
            .descripcion = txtdescripcioncategoria.Text
            .idcategoria = labelidcategoria.Text
        End With

        Negocio.Eliminar_categoria(Entidad)
    End Sub
    Private Sub btneliminarcategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcategoria.Click
        Eliminar_categoria()
        Cargar_gridview()
    End Sub

    'Buscar Categoria'

    Private Sub btn_buscarcategoria_Click(sender As Object, e As EventArgs) Handles btn_buscarcategoria.Click
        Dim busca = txtbuscarcategoria.Text
        Dim obj As New Categoria_Negocio
        DGV_Categoria.DataSource = obj.Buscar_categoria(busca)
    End Sub


End Class

Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Datos
Imports Entidades
Imports Negocio
Public Class View_Mantenimiento_Proveedores

    'mostrar proveedor'
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

    Private Sub cargargridview()
        Dim lista_proveedor As New List(Of E_Proveedor)
        Dim obj As New Proveedor_Negocio
        lista_proveedor = obj.Mostrarproveedor
        DGV_Proveedor.DataSource = lista_proveedor
    End Sub

    Private Sub Mantenimiento_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Black
        personalizargridview(Me.DGV_Proveedor)
        DGV_Proveedor.AutoGenerateColumns = False
        cargargridview()

    End Sub

    'Agregar proveedor'
    Private Sub limpiar()
        labelidproveedor.Text = ""
        txtnombreproveedor.Text = ""
        txtrucproveedor.Text = ""
        txtrepresentanteproveedor.Text = ""
        txtdireccionproveedor.Text = ""
        txttelefonoproveedor.Text = ""
    End Sub

    Private Sub Habilitar_deshabilitar(ByVal bol As Boolean)
        DGV_Proveedor.Enabled = bol
        btnmodificarproveedor.Enabled = bol
        btneliminarproveedor.Enabled = bol
        txtbuscarproveedor.Enabled = bol
    End Sub

    Private Sub btnagregarproveedor_Click(sender As Object, e As EventArgs) Handles btnagregarproveedor.Click
        If btnagregarproveedor.Text = "Nuevo" Then
            btnagregarproveedor.Text = "Guardar"
            limpiar()
            Habilitar_deshabilitar(False)
        ElseIf btnagregarproveedor.Text = "Guardar" Then
            Habilitar_deshabilitar(True)
            Agregar_proveedor()
            cargargridview()
        End If
    End Sub

    Private Sub Agregar_proveedor()
        Dim Entidad As New E_Proveedor
        Dim Negocio As New Proveedor_Negocio
        With Entidad
            .nombre = txtnombreproveedor.Text
            .RUC = txtrucproveedor.Text
            .representante = txtrepresentanteproveedor.Text
            .direccion = txtdireccionproveedor.Text
            .Telefono = txttelefonoproveedor.Text
        End With

        Negocio.Agregar_Proveedor(Entidad)
    End Sub

    Private Sub DGV_Proveedor_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Proveedor.SelectionChanged
        Dim fila As Integer
        fila = DGV_Proveedor.CurrentCell.RowIndex
        labelidproveedor.Text = Me.DGV_Proveedor(0, fila).Value.ToString()
        txtnombreproveedor.Text = Me.DGV_Proveedor(1, fila).Value.ToString()
        txtrucproveedor.Text = Me.DGV_Proveedor(2, fila).Value.ToString()
        txtrepresentanteproveedor.Text = Me.DGV_Proveedor(3, fila).Value.ToString()
        txtdireccionproveedor.Text = Me.DGV_Proveedor(4, fila).Value.ToString()
        txttelefonoproveedor.Text = Me.DGV_Proveedor(5, fila).Value.ToString()
    End Sub

    'Modificar proveedor'
    Private Sub Modificar_proveedor()
        Dim Entidad As New E_Proveedor
        Dim Negocio As New Proveedor_Negocio
        With Entidad
            .nombre = txtnombreproveedor.Text
            .RUC = txtrucproveedor.Text
            .representante = txtrepresentanteproveedor.Text
            .direccion = txtdireccionproveedor.Text
            .Telefono = txttelefonoproveedor.Text
            .idproveedor = labelidproveedor.Text
        End With

        Negocio.Modificar_Proveedor(Entidad)
    End Sub
    Private Sub btnmodificarproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarproveedor.Click
        Modificar_proveedor()
        cargargridview()
    End Sub

    'Eliminar proveedor'
    Private Sub Eliminar_proveedor()
        Dim Entidad As New E_Proveedor
        Dim Negocio As New Proveedor_Negocio
        With Entidad
            .nombre = txtnombreproveedor.Text
            .RUC = txtrucproveedor.Text
            .representante = txtrepresentanteproveedor.Text
            .direccion = txtdireccionproveedor.Text
            .Telefono = txttelefonoproveedor.Text
            .idproveedor = labelidproveedor.Text
        End With

        Negocio.Eliminar_proveedor(Entidad)
    End Sub

    Private Sub btneliminarproveedor_Click(sender As Object, e As EventArgs) Handles btneliminarproveedor.Click
        Eliminar_proveedor()
        cargargridview()
    End Sub

    'Buscar proveedor'

    Private Sub btnbuscarproveedor_Click_1(sender As Object, e As EventArgs) Handles btnbuscarproveedor.Click
        Dim busca = txtbuscarproveedor.Text
        Dim obj As New Proveedor_Negocio
        DGV_Proveedor.DataSource = obj.Buscar_Proveedor(busca)
    End Sub

End Class
Imports Entidades
Imports Negocio
Public Class Mantenimiento_Cliente
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
        Dim lista_cliente As New List(Of E_Cliente)
        Dim obj As New Cliente_Negocio
        lista_cliente = obj.Mostrartodocliente
        DGVCliente.DataSource = lista_cliente
    End Sub

    Private Sub Mantenimiento_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Black
        personalizargridview(Me.DGVCliente)
        cargargridview()

    End Sub

    'Agregar Cliente'
    Private Sub limpiar()
        lblidcliente.Text = ""
        txtnombrecliente.Text = ""
        txtapellidocliente.Text = ""
        txttelefonocliente.Text = ""
    End Sub

    Private Sub Habilitar_deshabilitar(ByVal bol As Boolean)
        DGVCliente.Enabled = bol
        btnmodificarcliente.Enabled = bol
        btneliminarcliente.Enabled = bol
        txtbuscarcliente.Enabled = bol
    End Sub

    Private Sub btnagregarcliente_Click(sender As Object, e As EventArgs) Handles btnnuevocliente.Click
        If btnnuevocliente.Text = "Nuevo" Then
            btnnuevocliente.Text = "Guardar"
            limpiar()
            Habilitar_deshabilitar(False)
        ElseIf btnnuevocliente.Text = "Guardar" Then
            Habilitar_deshabilitar(True)
            Agregar_Cliente()
            cargargridview()
        End If
    End Sub

    Private Sub Agregar_Cliente()
        Dim Entidad As New E_Cliente
        Dim Negocio As New Cliente_Negocio
        With Entidad
            .Nombre = txtnombrecliente.Text
            .Apellidos = txtapellidocliente.Text
            .Telefono = txttelefonocliente.Text
        End With

        Negocio.Nuevo_cliente(Entidad)
    End Sub

    Private Sub DGV_Cliente_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVCliente.SelectionChanged
        Dim fila As Integer
        fila = DGVCliente.CurrentCell.RowIndex
        lblidcliente.Text = Me.DGVCliente(0, fila).Value.ToString()
        txtnombrecliente.Text = Me.DGVCliente(1, fila).Value.ToString()
        txtapellidocliente.Text = Me.DGVCliente(2, fila).Value.ToString()
        txttelefonocliente.Text = Me.DGVCliente(3, fila).Value.ToString()
    End Sub

    'Modificar Cliente'
    Private Sub Modificar_cliente()
        Dim Entidad As New E_Cliente
        Dim Negocio As New Cliente_Negocio
        With Entidad
            .Nombre = txtnombrecliente.Text
            .Apellidos = txtapellidocliente.Text
            .Telefono = txttelefonocliente.Text
            .IdCliente = lblidcliente.Text
        End With

        Negocio.modificar_cliente(Entidad)
    End Sub
    Private Sub btnmodificarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarcliente.Click
        Modificar_cliente()
        cargargridview()
    End Sub

    'Eliminar Cliente'
    Private Sub Eliminar_cliente()
        Dim Entidad As New E_Cliente
        Dim Negocio As New Cliente_Negocio
        With Entidad
            .Nombre = txtnombrecliente.Text
            .Apellidos = txtapellidocliente.Text
            .Telefono = txttelefonocliente.Text
            .IdCliente = lblidcliente.Text
        End With

        Negocio.Eliminar_cliente(Entidad)
    End Sub
    Private Sub btneliminarcliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminarcliente.Click
        Eliminar_cliente()
        cargargridview()
    End Sub

    'Buscar proveedor'

    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        Dim busca = txtbuscarcliente.Text
        Dim obj As New Cliente_Negocio
        DGVCliente.DataSource = obj.buscacliente(busca)
    End Sub


End Class
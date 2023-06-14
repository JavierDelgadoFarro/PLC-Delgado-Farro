Imports System.Windows.Documents
Imports Entidades
Imports Negocio

Public Class View_Mantenimiento_Empleado

    'mostrar todos los empleados'
    Private Sub View_Mantenimiento_Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ForeColor = Color.Black
        personalizargridviewEmpleado(Me.DGVEmpleado)
        cargargridviewEmpleado()
        cargarcomboRol()
    End Sub

    Private Sub personalizargridviewEmpleado(ByVal grid As DataGridView)
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

    Private Sub cargargridviewEmpleado()
        Dim lista_empleado As New List(Of E_Empleado)
        Dim obj As New Empleado_Negocio
        lista_empleado = obj.Mostrartodoempleado
        DGVEmpleado.DataSource = lista_empleado
        If DGVEmpleado.RowCount > 0 Then 'cuando no haya nada en la base de datos'
            LabelOpc.Text = CStr(Me.DGVEmpleado(0, DGVEmpleado.RowCount - 1).Value + 1)
        ElseIf DGVEmpleado.RowCount = 0 Then
            LabelOpc.Text = 1
        End If
    End Sub


    Private Sub limpiar()
        labelIdEmpleado.Text = ""
        TextNombreEmpleado.Text = ""
        TextApellidoEmpleado.Text = ""
        TextContraseñaEmpleado.Text = ""
        ComboBoxRol.Text = ""
        TextUsuarioEmpleado.Text = ""

        ComboBoxRol.SelectedIndex = -1
    End Sub

    Private Sub habilitar_deshabitar(ByVal bol As Boolean)
        btnmodificarEmpleado.Enabled = bol
        DGVEmpleado.Enabled = bol
        txtbuscarEmpleado.Enabled = bol

    End Sub

    'Para Cargar Al Combobox Rol'
    Private Sub cargarcomboRol()
        Dim lista As New List(Of E_Rol)
        Dim obj As New Rol_Negocio
        lista = obj.Mostrar_rol
        ComboBoxRol.DataSource = lista
        ComboBoxRol.DisplayMember = "descripcion"
        ComboBoxRol.ValueMember = "idrol"
        ComboBoxRol.SelectedIndex = -1
    End Sub

    Private Sub buscarencombo(ByVal combo As ComboBox, ByVal cad As String)
        Dim i As Integer
        Dim bol = False
        While i <= combo.Items.Count - 1 And bol = False
            combo.SelectedIndex = i
            If combo.SelectedValue.ToString = cad Then
                combo.SelectedIndex = i
                bol = True
            End If
            i += 1
        End While
    End Sub


    Private Sub DGVEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEmpleado.CellContentClick
        Dim fila As Integer
        fila = DGVEmpleado.CurrentCell.RowIndex
        labelIdEmpleado.Text = Me.DGVEmpleado(0, fila).Value.ToString()
        TextNombreEmpleado.Text = Me.DGVEmpleado(1, fila).Value.ToString()
        TextApellidoEmpleado.Text = Me.DGVEmpleado(2, fila).Value.ToString()
        TextContraseñaEmpleado.Text = Me.DGVEmpleado(3, fila).Value.ToString()
        buscarencombo(ComboBoxRol, Me.DGVEmpleado(4, fila).Value.ToString())
        TextUsuarioEmpleado.Text = Me.DGVEmpleado(5, fila).Value.ToString()

    End Sub


    'Metodo para agregar un nuevo producto'
    Private Sub nuevo_empleado()
        'Agregar producto
        Dim Entidad As New E_Empleado
        Dim Negocio As New Empleado_Negocio

        With Entidad
            .nombres = TextNombreEmpleado.Text
            .apellidos = TextApellidoEmpleado.Text
            .contraseña = TextContraseñaEmpleado.Text
            .id_rol = ComboBoxRol.SelectedValue
            .usuario = TextUsuarioEmpleado.Text
        End With
        'llamamos a agregar producto'
        Negocio.Agregar_Empleado(Entidad)
    End Sub

    Private Sub btnnuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnnuevoEmpleado.Click
        If btnnuevoEmpleado.Text = "Nuevo" Then
            btnnuevoEmpleado.Text = "Guardar"
            habilitar_deshabitar(False)
            limpiar()
            labelIdEmpleado.Text = LabelOpc.Text
        ElseIf btnnuevoEmpleado.Text = "Guardar" Then
            btnnuevoEmpleado.Text = "Nuevo"
            If ComboBoxRol.SelectedIndex < 0 Then
                MessageBox.Show("Debe de seleccionar el rol")
                ComboBoxRol.Focus()
                Exit Sub
            End If
            nuevo_empleado()
            habilitar_deshabitar(True)
            cargargridviewEmpleado()
        End If
    End Sub


    'Para modificar un producto'
    Private Sub modificarEmpleado()
        'modificar empleado
        Dim Entidad As New E_Empleado
        Dim Negocio As New Empleado_Negocio

        With Entidad
            .nombres = TextNombreEmpleado.Text
            .apellidos = TextApellidoEmpleado.Text
            .contraseña = TextContraseñaEmpleado.Text
            .id_rol = ComboBoxRol.SelectedValue
            .usuario = TextUsuarioEmpleado.Text
        End With

        With Entidad
            .nombres = TextNombreEmpleado.Text
            .apellidos = TextApellidoEmpleado.Text
            .contraseña = TextContraseñaEmpleado.Text
            .id_rol = ComboBoxRol.SelectedValue
            .usuario = TextUsuarioEmpleado.Text
            .idempleado = labelIdEmpleado.Text
        End With
        'llamamos a modificar_empleado'
        Negocio.modificar_Empleado(Entidad)
    End Sub

    Private Sub btnmodificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnmodificarEmpleado.Click
        modificarEmpleado()
        cargargridviewEmpleado()
    End Sub

    'Para Buscar El empleado'
    Private Sub txtbuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarEmpleado.TextChanged
        Dim lista As New List(Of E_Empleado)
        Dim obj As New Empleado_Negocio
        lista = obj.buscartodoempleado(txtbuscarEmpleado.Text)
        DGVEmpleado.DataSource = lista
    End Sub

    'Eliminar Empleado'
    Private Sub Eliminar_empleado()
        Dim Entidad As New E_Empleado
        Dim Negocio As New Empleado_Negocio
        With Entidad
            .nombres = TextNombreEmpleado.Text
            .apellidos = TextApellidoEmpleado.Text
            .contraseña = TextContraseñaEmpleado.Text
            .id_rol = ComboBoxRol.SelectedValue
            .usuario = TextUsuarioEmpleado.Text
            .idempleado = labelIdEmpleado.Text
        End With

        Negocio.Eliminar_empleado(Entidad)
    End Sub

    Private Sub btneliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btneliminarEmpleado.Click
        Eliminar_empleado()
        cargargridviewEmpleado()
    End Sub
End Class
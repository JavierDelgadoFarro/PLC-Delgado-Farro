﻿Imports Entidades
Imports Negocio
Imports System.IO
Public Class View_Mantenimiento_Productos
    Dim abre As New OpenFileDialog
    Private Sub Mantenimiento_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DGV_Productos.AutoGenerateColumns = False
        personalizargridview(Me.DGV_Productos)
        cargarcombo()
        cargarproveedores()
        cargargridview()
    End Sub

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

    'Para Cargar el Gridview'
    Private Sub cargargridview()
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Negocio
        lista = obj.Mostrartodosproducto
        DGV_Productos.DataSource = lista
        If DGV_Productos.RowCount > 0 Then 'cuando no haya nada en la base de datos'
            Label9.Text = CStr(Me.DGV_Productos(0, DGV_Productos.RowCount - 1).Value + 1)
        ElseIf DGV_Productos.RowCount = 0 Then
            Label9.Text = 1
        End If
    End Sub

    'Para Cargar Al Combobox'
    Private Sub cargarcombo()
        Dim lista As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista = obj.Mostrar_categoria
        cbcategoriaproducto.DataSource = lista
        cbcategoriaproducto.DisplayMember = "nombre"
        cbcategoriaproducto.ValueMember = "idcategoria"
        cbcategoriaproducto.SelectedIndex = -1
    End Sub
    'para cargar proveedores'
    Private Sub cargarproveedores()
        Dim lista As New List(Of E_Proveedor)
        Dim obj As New Proveedor_Negocio
        lista = obj.Mostrarproveedor
        cbproveeproducto.DataSource = lista
        cbproveeproducto.DisplayMember = "nombre"
        cbproveeproducto.ValueMember = "idproveedor"
        cbproveeproducto.SelectedIndex = -1
    End Sub

    'Para Buscar El producto'
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Negocio
        lista = obj.buscartodoproducto(txtbuscarproducto.Text)
        DGV_Productos.DataSource = lista
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_Productos.SelectionChanged
        Dim fila As Integer
        fila = DGV_Productos.CurrentCell.RowIndex
        labelidproducto.Text = Me.DGV_Productos(0, fila).Value.ToString()
        txtnombreproducto.Text = Me.DGV_Productos(1, fila).Value.ToString()
        numprecioproducto.Text = Me.DGV_Productos(3, fila).Value.ToString()
        numstockproducto.Text = Me.DGV_Productos(4, fila).Value.ToString()
        If File.Exists(Application.StartupPath + "\imagenes\productos\" + Me.DGV_Productos(6, fila).Value.ToString()) Then
            PBImagenes.Load(Application.StartupPath + "\imagenes\productos\" + Me.DGV_Productos(6, fila).Value.ToString())
        End If
        buscarencombo(cbproveeproducto, Me.DGV_Productos(5, fila).Value.ToString())
        buscarencombo(cbcategoriaproducto, Me.DGV_Productos(2, fila).Value.ToString())
    End Sub



    'Metodo para agregar un nuevo producto'
    Private Sub nuevo_producto()
        'Agregar producto
        Dim Entidad As New E_Producto
        Dim Negocio As New Producto_Negocio

        With Entidad
            .nombre = txtnombreproducto.Text
            .idcategoria = cbcategoriaproducto.SelectedValue
            .precio = numprecioproducto.Value
            .stock = numstockproducto.Value
            .idproveedor = cbproveeproducto.SelectedValue
            .foto = IIf(abre.FileName = "", "nd.jpg", labelidproducto.Text + ".jpg")
        End With
        'llamamos a agregar producto'
        Negocio.Agregar_Producto(Entidad)
        redimensionarfotoyguardar()
    End Sub

    Private Sub habilitar_deshabitar(ByVal bol As Boolean)
        btnmodificarproducto.Enabled = bol
        DGV_Productos.Enabled = bol
        txtbuscarproducto.Enabled = bol

    End Sub



    Private Sub limpiarcajas()
        labelidproducto.Text = ""
        txtnombreproducto.Text = ""
        cbcategoriaproducto.Text = ""
        numprecioproducto.Value = 0
        numstockproducto.Value = 0
        txtbuscarproducto.Text = ""
        PBImagenes.Image = Nothing
        cbcategoriaproducto.SelectedIndex = -1
        cbproveeproducto.SelectedIndex = -1
    End Sub

    Private Sub abriropen()
        'Si en el diseño no hemos añadido el Openfiledialog pondremos esto sin el apostrofe al principio:

        abre.Title = "Seleccione su Imagen" 'Título de la ventana que se abrirá para seleccionar el archivo.
        abre.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        abre.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        abre.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        abre.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        abre.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito, de la manera contraria en la ventana ya pondria "abre", además que esto nos viene bien para otra cosa que explicaré luego.

        If abre.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            PBImagenes.ImageLocation = abre.FileName 'La ruta de la imagen que contiene el picturebox es el nombre de archivo del OpenFileDialog.
        End If
    End Sub

    'metodo que redimensiona la foto y la guarda en la aplicacion'

    Private Sub redimensionarfotoyguardar()
        Dim imagenOriginal As Bitmap
        Dim imagenRedimensionada As Bitmap
        If abre.FileName <> "" Then
            imagenOriginal = New Bitmap(abre.FileName)

            'creamos una imagen con las dimensiones que se desean 
            'en este caso la creamos de 300x300 pixels 
            imagenRedimensionada = New Bitmap(300, 300)

            'creamos un objeto graphics desde la nueva imagen 
            Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)

                'en la nueva imagen "pintamos" la antigua imagen con las dimensiones de la nueva imagen 
                gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)

            End Using

            'se guarda la nueva imagen 
            imagenRedimensionada.Save(Application.StartupPath + "\imagenes\productos\" + labelidproducto.Text + ".jpg")
            imagenRedimensionada.Dispose()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        abriropen()
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

    'Para modificar un producto'
    Private Sub modificar()
        'modificar producto
        Dim Entidad As New E_Producto
        Dim Negocio As New Producto_Negocio

        With Entidad
            .nombre = txtnombreproducto.Text
            .idcategoria = cbcategoriaproducto.SelectedValue
            .precio = numprecioproducto.Value
            .stock = numstockproducto.Value
            .idproveedor = cbproveeproducto.SelectedValue
            .foto = IIf(devolvercadena() = "nd.jpg", "nd.jpg", labelidproducto.Text + ".jpg")
            .idproducto = labelidproducto.Text
        End With
        'llamamos a agregar producto'
        Negocio.modificar_Producto(Entidad)
        redimensionarfotoyguardar()
    End Sub


    Private Sub btnmodificarproducto_Click(sender As Object, e As EventArgs) Handles btnmodificarproducto.Click
        modificar()
        cargargridview()
    End Sub


    'funcion para devolver cadena'
    Private Function devolvercadena() As String
        Dim entero As Integer = 0
        Dim cadena1 As String = ""
        If File.Exists(PBImagenes.ImageLocation) Then
            entero = InStr(PBImagenes.ImageLocation, "nd.jpg")
            If entero <> 0 Then
                cadena1 = Mid(PBImagenes.ImageLocation, entero, PBImagenes.ImageLocation.Length)
            End If
        End If

        Return cadena1
    End Function

    Private Sub Btn_buscar_Click(sender As Object, e As EventArgs) Handles Btn_buscar.Click
        Dim busca = txtbuscarproducto.Text
        Dim obj As New Producto_Negocio
        DGV_Productos.DataSource = obj.buscartodoproducto(busca)
    End Sub

    Private Sub btnnuevoproducto_Click(sender As Object, e As EventArgs) Handles btnnuevoproducto.Click
        If btnnuevoproducto.Text = "Nuevo" Then
            btnnuevoproducto.Text = "Guardar"
            habilitar_deshabitar(False)
            limpiarcajas()
            labelidproducto.Text = Label9.Text
        ElseIf btnnuevoproducto.Text = "Guardar" Then
            btnnuevoproducto.Text = "Nuevo"
            If cbcategoriaproducto.SelectedIndex < 0 Then
                MessageBox.Show("Debe de seleccionar una categoria")
                cbcategoriaproducto.Focus()
                Exit Sub
            End If

            If cbproveeproducto.SelectedIndex < 0 Then
                cbproveeproducto.Focus()
                MessageBox.Show("debe seleccionar un proveedor")
                Exit Sub
            End If
            nuevo_producto()
            habilitar_deshabitar(True)
            cargargridview()
        End If
    End Sub
End Class
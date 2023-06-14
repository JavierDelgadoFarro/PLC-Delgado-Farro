Imports Entidades
Imports Negocio
Imports System.IO

Public Class View_Compra

    Private txt() As PictureBox
    Private lbl() As Label
    Dim panel As New PanelExtended
    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ForeColor = Color.Black
        'Inicializamos el panel'
        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(480, 85)
        panel.Name = "Panel5"
        panel.Size = New System.Drawing.Size(550, 580)
        panel.ForeColor = Color.Purple

        'Se agrega al formulario'
        Me.Controls.Add(panel)

        Dim num As Integer
        num = contarproducto()
        mostrarproducto(num)

        comboComprobante.Items.Add("Factura")
        comboComprobante.Items.Add("Boleta de Venta")


        With listCompras
            .View = View.Details
            .Columns.Add("id", 30)
            .Columns.Add("Producto", 230)
            .Columns.Add("Cantidad", 70)
            .Columns.Add("Importe", 70)


        End With

        cargarcombo()
        cargarcombocategoria()
    End Sub

    Private Sub cargarcombo()
        Dim lista As New List(Of E_Proveedor)
        Dim obj As New Proveedor_Negocio
        lista = obj.Mostrarproveedor
        cbxNombreProveedor.DataSource = lista
        cbxNombreProveedor.DisplayMember = "nombre"
        cbxNombreProveedor.ValueMember = "idproveedor"
        cbxNombreProveedor.SelectedIndex = -1
    End Sub

    Private Sub cargarcombocategoria()
        Dim lista As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista = obj.Mostrar_categoria
        cbxCategoria.DataSource = lista
        cbxCategoria.DisplayMember = "nombre"
        cbxCategoria.ValueMember = "idcategoria"
        cbxCategoria.SelectedIndex = -1
    End Sub

    Private Sub dibuja(ByVal fin As Integer, ByVal lista As List(Of E_Producto))

        panel.Controls.Clear() 'Eliminamos todos los controles que esten en panel'
        Dim i As Integer
        Dim j As Integer = 0
        Dim contador As Integer = 0
        ReDim txt(fin)
        ReDim lbl(fin)
        Dim constante = 160 'variable que determina el espaciado entre los picturebox'
        Dim constantex = 130

        For i = 1 To fin

            txt(i) = New PictureBox 'instanciamos los picturebox'
            lbl(i) = New Label 'iniciamos el label'

            'Picturebox'
            Me.txt(i).Size = New System.Drawing.Size(130, 130)
            Me.txt(i).Name = lista.Item(i - 1).idproducto
            Me.txt(i).SizeMode = PictureBoxSizeMode.StretchImage
            Me.txt(i).BorderStyle = BorderStyle.FixedSingle
            If File.Exists(My.Application.Info.DirectoryPath + "\imagenes\productos\" + lista.Item(i - 1).foto) Then
                Me.txt(i).Load(My.Application.Info.DirectoryPath + "\imagenes\productos\" + lista.Item(i - 1).foto)
            End If



            contador = contador + 1
            If contador <= 4 Then
                txt(i).Location = New System.Drawing.Point((contador * constantex) - constantex, j * constante) 'para la ubicacion'

            Else
                j = j + 1
                txt(i).Location = New System.Drawing.Point(0, j * constante)
                contador = 1
            End If

            panel.Controls.Add(txt(i))

            lbl(i).Location = New System.Drawing.Point(txt(i).Location.X, txt(i).Location.Y + 130)
            Me.txt(i).Text = lista.Item(i - 1).nombre
            Me.lbl(i).Text = lista.Item(i - 1).nombre
            Me.lbl(i).ForeColor = Color.White
            Me.lbl(i).BackColor = Color.DarkRed
            Me.lbl(i).Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl(i).Size = New System.Drawing.Size(130, 30)
            Me.lbl(i).TextAlign = ContentAlignment.TopCenter
            panel.Controls.Add(lbl(i))

            AddHandler txt(i).Click, AddressOf All_filter_click
        Next

    End Sub

    'Asignar un manejador de evento al control creado'
    Private Sub All_filter_click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim picture As PictureBox
        picture = CType(sender, PictureBox)
        Dim obj As New Producto_Negocio
        Dim listaProductos As New List(Of E_Producto)
        listaProductos = obj.preciostock(picture.Name) 'Se Busca el precio y el stock' 
        If File.Exists(picture.ImageLocation) Then
            PictureBox.Load(picture.ImageLocation) 'copiamos la imagen de un picturebox a otro'
        End If
        PictureBox.Name = picture.Name
        lbl_nombre1.Text = picture.Text
        Panel2.Show() 'Abrimos el formulario detalle producto '
    End Sub

    Private Function contarproducto() As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductos
        Return valor
    End Function

    'Procedimiento para que se muestren todos los productos en Picturebox'
    Private Sub mostrarproducto(ByVal fin As Integer)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Negocio
        lista = obj.Mostrartodosproducto
        dibuja(fin, lista)
    End Sub

    Public Sub verificarcheckboxes()
        Dim igv As Double = 0.18
        If CheckIgv.Checked Then
            lbl_Igv.Text = Str(Math.Round(CDbl(lbl_SubTotal.Text) * igv, 2))
        Else
            lbl_Igv.Text = "0.00"
        End If

        If Check2.Checked Then
            lbl_2_por.Text = Str(Math.Round((CDbl(lbl_SubTotal.Text) + CDbl(lbl_Igv.Text)) * 0.02, 2))
        Else
            lbl_2_por.Text = "0.00"
        End If
        lbl_total.Text = Str(CDbl(lbl_SubTotal.Text) + CDbl(lbl_Igv.Text) + CDbl(lbl_2_por.Text))

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckIgv.CheckedChanged
        verificarcheckboxes()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check2.CheckedChanged
        verificarcheckboxes()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxNombreProveedor.SelectedIndexChanged
        If cbxNombreProveedor.SelectedIndex >= 0 Then
            id_Prov.Text = cbxNombreProveedor.SelectedValue.ToString
        Else
            id_Prov.Text = ""
        End If

    End Sub

    Private Sub Nueva_Compra()
        'Agregar Compra
        Dim Entidad As New E_Compra
        Dim Negocio As New Compra_Negocio


        With Entidad
            .fecha = convertirfecha_ansi(dateFechaCompra)
            .idtipocomprobante = obtenertipocomprobante()
            .idfactura = txtNumeroComprobante.Text
            .idproveedor = id_Prov.Text
            .importetotal = CDbl(lbl_total.Text)
            .retencion = CDbl(lbl_2_por.Text)
        End With
        'Agregamos una nueva compra'
        Negocio.Nueva_Compra(Entidad)

        'Para Agregar compra_Detalle'
        Dim Entidad_detalle As New E_Compra_Detalle
        Dim Negocio_detalle As New Compra_Detalle_Negocio

        For i = 0 To listCompras.Items.Count - 1

            With Entidad_detalle
                .idproducto = listCompras.Items(i).SubItems(0).Text
                .importe = listCompras.Items(i).SubItems(3).Text
                .cantidad = listCompras.Items(i).SubItems(2).Text
            End With

            'Agregamos la Compra Detalle'
            Negocio_detalle.Nueva_Compra_Detalle(Entidad_detalle)


            'Para Actualizar el Stock'
            Dim Entidad_productos As New E_Producto
            Dim Negocio_productos As New Producto_Negocio



            With Entidad_productos
                .stock = listCompras.Items(i).SubItems(2).Text
                .idproducto = listCompras.Items(i).SubItems(0).Text
            End With

            Negocio_productos.Actualiza_Stockcompras(Entidad_productos)

        Next
        MessageBox.Show("Compra Exitosa")


    End Sub

    Private Function convertirfecha_ansi(ByVal picker As DateTimePicker) As String
        Dim cadena As String = ""
        cadena = CStr(picker.Value.Year)
        If (picker.Value.Month) < 10 Then
            cadena = cadena + "0" + CStr(picker.Value.Month)
        Else
            cadena = cadena + CStr(picker.Value.Month)
        End If

        If picker.Value.Day < 10 Then
            cadena = cadena + "0" + CStr(picker.Value.Day)
        Else
            cadena = cadena + CStr(picker.Value.Day)
        End If
        Return cadena
    End Function

    Private Function obtenertipocomprobante()
        Return comboComprobante.SelectedIndex
    End Function

    Private Sub btnvender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_comprar.Click
        If cbxNombreProveedor.SelectedIndex < 0 Then
            MessageBox.Show("Seleccione un proveedor")
            cbxNombreProveedor.Focus()
            Exit Sub
        End If

        If comboComprobante.SelectedIndex < 0 Then
            MessageBox.Show("Debe seleccionar un tipo de comprobante")
            comboComprobante.Focus()
            Exit Sub
        End If

        If txtNumeroComprobante.Text = "" Then
            MessageBox.Show("Ingrese el n° de factura o boleta")
            txtNumeroComprobante.BackColor = Color.Yellow
            txtNumeroComprobante.Focus()
            Exit Sub
        End If

        If listCompras.Items.Count <= 0 Then
            MessageBox.Show("Debe seleccionar por lo menos un producto")
            Exit Sub
        End If

        Nueva_Compra()
        limpiar()
    End Sub



    'Devuelve la cantidad de productos segun el nombre '
    Private Function contarproductoporfiltro(ByVal nombre As String) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductosporfiltro(nombre)
        Return valor
    End Function

    Private Sub verifica(ByVal combo As ComboBox)
        If checkFiltro.Checked And combo.SelectedIndex >= 0 Then
            If IsNumeric(combo.SelectedValue) Then
                Dim cuenta As Integer
                Dim obj As New Producto_Negocio
                Dim listaProductos As New List(Of E_Producto)
                listaProductos = obj.Mostrarproducto(combo.SelectedValue)
                cuenta = contarproductoporcategoria(combo.SelectedValue)
                dibuja(cuenta, listaProductos)
            End If
        End If
    End Sub

    'Devuelve la cantidad de productos segun su categoria '
    Private Function contarproductoporcategoria(ByVal id As Integer) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductosporcategoria(id)
        Return valor
    End Function

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategoria.SelectedIndexChanged
        verifica(cbxCategoria)
    End Sub


    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFiltro.CheckedChanged
        If checkFiltro.Checked Then
            verifica(cbxCategoria)
        Else
            Dim num As Integer
            num = contarproducto()
            mostrarproducto(num)
        End If

    End Sub

    Private Sub limpiar()
        id_Prov.Text = ""
        cbxNombreProveedor.SelectedIndex = -1
        comboComprobante.SelectedIndex = -1
        txtNumeroComprobante.Text = ""
        txtNumeroComprobante.BackColor = Color.White
        dateFechaCompra.Value = Now
        listCompras.Items.Clear()
        Check2.Checked = False
        CheckIgv.Checked = False
        lbl_SubTotal.Text = "0.00"
        lbl_Igv.Text = "0.00"
        lbl_2_por.Text = "0.00"
        lbl_total.Text = "0.00"
        checkFiltro.Checked = False
        cbxCategoria.SelectedIndex = -1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboComprobante.SelectedIndexChanged
        If comboComprobante.SelectedIndex = 1 Then
            Check2.Enabled = False
            Check2.Checked = False
        Else
            Check2.Enabled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub btnAceptarDetalle_Click(sender As Object, e As EventArgs) Handles btnAceptarDetalle.Click

        If txtCantidad.Text = "" Then
            MessageBox.Show("Debe de ingresar una cantidad")
            Exit Sub
        End If
        If txtCantidad.Text = "0" Then
            MessageBox.Show("Deberia ingresar una cantidad mayor a 0")
            Exit Sub
        End If
        If Not IsNumeric(txtCantidad.Text) Then
            MessageBox.Show("La Cantidad no es Valida")
            Exit Sub
        End If

        Dim oreg As New ListViewItem(PictureBox.Name) 'codigo del producto'

        With oreg
            .SubItems.Add(lbl_nombre1.Text) 'nombre'
            .SubItems.Add(txtCantidad.Text)  'Cantidad'
            .SubItems.Add(importeDetalle.Value) 'importe'
            listCompras.Items.Add(oreg) 'Agregamos todo esto al listview'
        End With
        lbl_SubTotal.Text = CStr(CDbl(lbl_SubTotal.Text) + CDbl(importeDetalle.Value))
        verificarcheckboxes()
    End Sub

    Private Sub btnCancelarDetalle_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalle.Click
        Me.Dispose()
        Me.Close()
    End Sub


End Class
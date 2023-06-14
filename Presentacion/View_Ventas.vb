Imports Entidades
Imports Negocio
Imports System.IO


Public Class View_Ventas

    Private txt() As PictureBox
    Private lbl() As Label
    Dim panel As New PanelExtended

    Private Sub Btn_Actualizar1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Actualizar.Click
        cargarcombo(Cmb_cliente)
    End Sub
    Private Sub Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        panel.AutoScroll = True
        panel.Location = New System.Drawing.Point(510, 215)
        panel.Name = "Panel1"
        panel.Size = New System.Drawing.Size(540, 580)
        'Se agrega al formulario'
        Me.Controls.Add(panel)

        Dim num As Integer
        num = contarproducto()
        mostrarproducto(num)

        With Lsv_det
            .View = View.Details
            .Columns.Add("Producto", 230)
            .Columns.Add("Precio", 70)
            .Columns.Add("Cantidad", 70)
            .Columns.Add("Productid", 70)
        End With
        cargarcombo(Cmb_cliente)
        cargarcombocategoria()
    End Sub

#Region "Mostrar Cliente"
    Private Sub cargarcombo(ByVal combo As ComboBox)
        Dim lista As New List(Of E_Cliente)
        Dim obj As New Cliente_Negocio
        lista = obj.Mostrartodocliente
        combo.DataSource = lista
        combo.DisplayMember = "nombre"
        combo.ValueMember = "idcliente"
        combo.SelectedIndex = -1

    End Sub
#End Region

#Region "Mostrar Categoria"
    Private Sub cargarcombocategoria()
        Dim lista As New List(Of E_Categoria)
        Dim obj As New Categoria_Negocio
        lista = obj.Mostrar_categoria
        Cmb_categoria.DataSource = lista
        Cmb_categoria.DisplayMember = "nombre"
        Cmb_categoria.ValueMember = "idcategoria"
        Cmb_categoria.SelectedIndex = -1
    End Sub
#End Region


    Private Sub btnvender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub



    Private Function convertirfecha_ansi(ByVal picker As DateTimePicker, ByVal picker2 As DateTimePicker) As String
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

        If picker2.Value.Hour < 10 Then
            cadena = cadena + " 0" + CStr(picker2.Value.Hour) + ":"
        Else
            cadena = cadena + " " + CStr(picker2.Value.Hour) + ":"
        End If

        If picker2.Value.Minute < 10 Then
            cadena = cadena + "0" + CStr(picker2.Value.Minute) + ":"
        Else
            cadena = cadena + CStr(picker2.Value.Minute) + ":"
        End If

        If picker2.Value.Second < 10 Then
            cadena = cadena + "0" + CStr(picker2.Value.Second)
        Else
            cadena = cadena + CStr(picker2.Value.Second)
        End If
        Return cadena
    End Function



    'Procedimiento para que se muestren todos los productos en Picturebox'
    Private Sub mostrarproducto(ByVal fin As Integer)
        Dim lista As New List(Of E_Producto)
        Dim obj As New Producto_Negocio
        lista = obj.Mostrartodosproducto
        dibuja(fin, lista)
    End Sub

    'metodo para dibujar picturebox en tiempo de ejecucion'
    Private Sub dibuja(ByVal fin As Integer, ByVal lista As List(Of E_Producto))

        panel.Controls.Clear() 'Eliminamos todos los controles que esten en panel'
        Dim i As Integer
        Dim j As Integer = 0
        Dim contador As Integer = 0
        ReDim txt(fin)
        ReDim lbl(fin)
        Dim constante As Integer = 160 'variable que determina el espaciado entre los picturebox'
        Dim constantex As Integer = 130

        For i = 1 To fin

            txt(i) = New PictureBox 'instanciamos los picturebox'
            lbl(i) = New Label 'iniciamos el label'

            'Picturebox'
            Me.txt(i).Size = New System.Drawing.Size(130, 130)
            Me.txt(i).Name = lista.Item(i - 1).idproducto
            Me.txt(i).SizeMode = PictureBoxSizeMode.StretchImage
            Me.txt(i).BorderStyle = BorderStyle.FixedSingle
            If File.Exists(My.Application.Info.DirectoryPath + "\imagenes\productos\" + lista.Item(i - 1).foto) Then 'Comprobamos que el archivo existe'
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
            Me.lbl(i).BackColor = Color.SteelBlue
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

        lbl_stock.Text = listaProductos.Item(0).stock
        lbl_precio.Text = listaProductos.Item(0).precio
        If File.Exists(picture.ImageLocation) Then
            pic_Producto.Load(picture.ImageLocation) 'copiamos la imagen de un picturebox a otro'
        End If
        pic_Producto.Name = picture.Name
        lbl_nombre.Text = picture.Text
        panel_detalle.Show() 'Abrimos el formulario detalle producto '
        pnl_ini.Visible = False

    End Sub

    'Funcion que cuenta la cantidad  de productos'
    Private Function contarproducto() As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductos
        Return valor
    End Function

    'Devuelve la cantidad de productos segun el nombre '
    Private Function contarproductoporfiltro(ByVal nombre As String) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductosporfiltro(nombre)
        Return valor
    End Function

    'Devuelve la cantidad de productos segun su categoria '
    Private Function contarproductoporcategoria(ByVal id As Integer) As Integer
        Dim valor As Integer
        Dim obj As New Producto_Negocio
        valor = obj.contarproductosporcategoria(id)
        Return valor
    End Function


    'funcion para colorear el listview'
    Public Sub colorearListView(ByRef list As ListView)
        Dim i As Integer

        For i = 0 To list.Items.Count - 1

            If i = Int(i / 2) * 2 Then

                list.Items.Item(i).BackColor = Color.Red

            Else

                list.Items.Item(i).BackColor = Color.Yellow
            End If

        Next

        list.FullRowSelect = True
    End Sub


    Private Sub Cmb_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Cmb_cliente.SelectedIndex >= 0 Then
            lbl_idcliente.Text = Cmb_cliente.SelectedValue.ToString
        Else
            lbl_idcliente.Text = ""
        End If
    End Sub

    'verificar'
    Private Sub Cmb_categoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        verifica(Cmb_categoria)
    End Sub

    Private Sub verifica(ByVal combo As ComboBox)
        If Cb_filtro.Checked And combo.SelectedIndex >= 0 Then
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

    'actualizar'
    Private Sub Cb_filtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_filtro.CheckedChanged
        If Cb_filtro.Checked Then
            verifica(Cmb_categoria)
        Else
            Dim num As Integer
            num = contarproducto()
            mostrarproducto(num)
        End If

    End Sub

    Private Sub limpiar()
        Cmb_cliente.SelectedIndex = -1
        Cmb_cliente.Text = ""
        Rbtn_Contado.Checked = True
        Me.Lsv_det.Items.Clear()
        lbl_TotalVenta.Text = "0.00"
        lbl_idcliente.Text = ""
        Cmb_categoria.SelectedIndex = -1
        Cb_filtro.Checked = False
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Date.Now.ToLocalTime
        pnl_ini.Visible = True
    End Sub

    Private Sub btn_cobrar_Click(sender As Object, e As EventArgs) Handles btn_Total_pagar.Click
        If lbl_idcliente.Text = " " Then
            MessageBox.Show("Debe seleccionar un cliente")
            Cmb_cliente.Focus()
            Exit Sub
        End If

        If Lsv_det.Items.Count <= 0 Then
            MessageBox.Show("Debe seleccionar por lo menos un producto")
            Exit Sub
        End If

        'para recuperar el id del empleado
        Dim lista2 As New List(Of E_Empleado)
        Dim obj2 As New Empleado_Negocio
        lista2 = obj2.obtener_idempleado(Mid(view_Principal.Text, 11, view_Principal.Text.Length))
        'para saber el tipodeventa'
        Dim tipoventa As Integer
        Dim cancelado As Integer
        If Rbtn_Contado.Checked Then
            tipoventa = 1
            cancelado = 1
        End If

        If Rbtn_Credito.Checked Then
            tipoventa = 2
            cancelado = 0
        End If


        'Agregar Venta
        Dim Entidad As New E_Venta
        Dim Negocio As New Venta_Negocio




        With Entidad
            .Idcliente = Cmb_cliente.SelectedValue 'Agregamos idcliente'
            .Idempleado = lista2.Item(0).idempleado 'Agregamos idempleado'
            .Idtipoventa = tipoventa
            .Fecha = Me.convertirfecha_ansi(Me.DateTimePicker1, Me.DateTimePicker2)
        End With
        'llamamos a agregar venta'
        Negocio.Nueva_Venta(Entidad)


        'Para Agregar Venta_Detalle'
        Dim Entidad_detalle As New E_Venta_Detalle
        Dim Negocio_detalle As New Venta_Detalle_Negocio

        For i = 0 To Lsv_det.Items.Count - 1
            'Para Obtener el id del producto
            'Dim lista3 As New List(Of Entidad_Producto)
            'Dim obj3 As New Negocio_Producto
            'lista3 = obj3.obtener_idproducto(ListView1.Items(i).SubItems(0).Text)


            With Entidad_detalle
                .IdProducto = Lsv_det.Items(i).SubItems(3).Text
                .Precio = Lsv_det.Items(i).SubItems(1).Text
                .Cantidad = Lsv_det.Items(i).SubItems(2).Text
                .Cancelado = cancelado
            End With
            'Agregamos la venta Detalle'
            Negocio_detalle.Nueva_VentaDetalle(Entidad_detalle)



            'Para Actualizar el Stock'
            Dim Entidad_productos As New E_Producto
            Dim Negocio_productos As New Producto_Negocio

            Dim listaProductos As New List(Of E_Producto)
            'Buscamos el precio y el stock'
            listaProductos = Negocio_productos.preciostock(Lsv_det.Items(i).SubItems(3).Text)

            With Entidad_productos
                .stock = CType(listaProductos.Item(0).stock, Integer) - CType(Lsv_det.Items(i).SubItems(2).Text, Integer)
                .idproducto = Lsv_det.Items(i).SubItems(3).Text
            End With

            Negocio_productos.Actualiza_Stock(Entidad_productos)

        Next
        MessageBox.Show("Venta Exitosa")
        limpiar()
    End Sub







    Private Sub btnCancelarDetalleProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarDetalleProducto.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnAceptarDetalleProducto_Click(sender As Object, e As EventArgs) Handles btnAceptarDetalleProducto.Click
        If txtCantidadProducto.Text = "" Then
            MessageBox.Show("Debe de ingresar una cantidad")
            Exit Sub
        End If
        If txtCantidadProducto.Text = "0" Then
            MessageBox.Show("Deberia ingresar una cantidad mayor a 0")
            Exit Sub
        End If
        If Not IsNumeric(txtCantidadProducto.Text) Then
            MessageBox.Show("La Cantidad no es Valida")
            Exit Sub
        End If
        Dim posicion As Integer 'variable que contendra la posicion en la que se repite el listview'
        Dim stock As Integer
        posicion = recorrerlistview(Lsv_det)

        If posicion = -1 Then
            stock = CType(Me.lbl_stock.Text, Integer)
            If stock >= CType(Me.txtCantidadProducto.Text, Integer) Then 'Comparamos el stock con la cantidad' 
                Dim oreg As New ListViewItem(lbl_nombre.Text) 'nombre  del producto'

                With oreg
                    .SubItems.Add(lbl_precio.Text) 'Precio'
                    .SubItems.Add(txtCantidadProducto.Text)  'Cantidad'
                    .SubItems.Add(pic_Producto.Name) 'Codigo del producto'
                    Lsv_det.Items.Add(oreg) 'Agregamos todo esto al listview'
                End With
                'Sumamos el total'
                lbl_TotalVenta.Text = CType(CType(lbl_TotalVenta.Text, Double) + (CType(lbl_precio.Text, Double) * CType(txtCantidadProducto.Text, Double)), String) 'Multiplicamos el precio por la cantidad'

            Else
                MessageBox.Show("No tienes stock suficiente")
            End If

        Else
            stock = CType(Me.lbl_stock.Text, Integer)
            If stock >= (CType(Me.txtCantidadProducto.Text, Integer) + CType(Lsv_det.Items(posicion).SubItems(2).Text, Integer)) Then
                Lsv_det.Items(posicion).SubItems(2).Text = CType(CType(Lsv_det.Items(posicion).SubItems(2).Text, Double) + CType(txtCantidadProducto.Text, Double), String)
                lbl_TotalVenta.Text = CType(CType(lbl_TotalVenta.Text, Double) + (CType(lbl_precio.Text, Double) * CType(txtCantidadProducto.Text, Double)), String)

            Else
                MessageBox.Show("No tienes stock suficiente")
            End If
        End If
    End Sub

    'Funcion que recorre el listview para ver si es que se repite algun producto y retorna la posicion en la que se encuentra'
    Private Function recorrerlistview(ByVal listview1 As ListView) As Integer

        Dim nombre As String
        Dim posicion As Integer = -1

        'Recorrermos el listview para saber si ahi un producto que se repite'
        For i = 0 To listview1.Items.Count - 1
            nombre = listview1.Items(i).SubItems(0).Text
            If posicion = -1 Then
                If lbl_nombre.Text = nombre Then
                    posicion = i
                Else
                    posicion = -1
                End If
            End If
        Next
        Return posicion
    End Function

End Class
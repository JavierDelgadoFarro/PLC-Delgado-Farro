<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cb_filtro = New System.Windows.Forms.CheckBox()
        Me.Cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.lbl_idcliente = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.pnl_ini = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_TotalVenta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Rbtn_Contado = New System.Windows.Forms.RadioButton()
        Me.btn_Total_pagar = New System.Windows.Forms.Button()
        Me.Rbtn_Credito = New System.Windows.Forms.RadioButton()
        Me.panel_detalle = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pic_Producto = New System.Windows.Forms.PictureBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btnAceptarDetalleProducto = New System.Windows.Forms.Button()
        Me.btnCancelarDetalleProducto = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadProducto = New System.Windows.Forms.TextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lsv_det = New System.Windows.Forms.ListView()
        Me.Labellinea = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnl_ini.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_detalle.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pic_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_filtro)
        Me.GroupBox1.Controls.Add(Me.Cmb_categoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(505, 104)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(615, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Producto"
        '
        'Cb_filtro
        '
        Me.Cb_filtro.AutoSize = True
        Me.Cb_filtro.Location = New System.Drawing.Point(28, 47)
        Me.Cb_filtro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_filtro.Name = "Cb_filtro"
        Me.Cb_filtro.Size = New System.Drawing.Size(70, 21)
        Me.Cb_filtro.TabIndex = 16
        Me.Cb_filtro.Text = "Filtrar"
        Me.Cb_filtro.UseVisualStyleBackColor = True
        '
        'Cmb_categoria
        '
        Me.Cmb_categoria.FormattingEnabled = True
        Me.Cmb_categoria.Location = New System.Drawing.Point(104, 43)
        Me.Cmb_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_categoria.Name = "Cmb_categoria"
        Me.Cmb_categoria.Size = New System.Drawing.Size(485, 25)
        Me.Cmb_categoria.TabIndex = 15
        '
        'lbl_idcliente
        '
        Me.lbl_idcliente.AutoSize = True
        Me.lbl_idcliente.Location = New System.Drawing.Point(358, 441)
        Me.lbl_idcliente.Name = "lbl_idcliente"
        Me.lbl_idcliente.Size = New System.Drawing.Size(54, 15)
        Me.lbl_idcliente.TabIndex = 30
        Me.lbl_idcliente.Text = "idCliente"
        Me.lbl_idcliente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Btn_Actualizar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Cmb_cliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 462)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(452, 125)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(249, 79)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 23)
        Me.DateTimePicker2.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(58, 79)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(144, 23)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.White
        Me.Btn_Actualizar.Location = New System.Drawing.Point(322, 30)
        Me.Btn_Actualizar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(109, 29)
        Me.Btn_Actualizar.TabIndex = 8
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre"
        '
        'Cmb_cliente
        '
        Me.Cmb_cliente.FormattingEnabled = True
        Me.Cmb_cliente.Location = New System.Drawing.Point(92, 34)
        Me.Cmb_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmb_cliente.Name = "Cmb_cliente"
        Me.Cmb_cliente.Size = New System.Drawing.Size(213, 25)
        Me.Cmb_cliente.TabIndex = 12
        '
        'pnl_ini
        '
        Me.pnl_ini.BackColor = System.Drawing.Color.Gray
        Me.pnl_ini.Controls.Add(Me.Label10)
        Me.pnl_ini.Controls.Add(Me.PictureBox1)
        Me.pnl_ini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pnl_ini.ForeColor = System.Drawing.Color.Cornsilk
        Me.pnl_ini.Location = New System.Drawing.Point(48, 104)
        Me.pnl_ini.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_ini.Name = "pnl_ini"
        Me.pnl_ini.Size = New System.Drawing.Size(421, 314)
        Me.pnl_ini.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(51, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(321, 30)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "El carrito de ventas está vacío"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.iconoprincipal4
        Me.PictureBox1.Location = New System.Drawing.Point(37, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(361, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 32)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "S/."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(47, 442)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tipo de Venta"
        '
        'lbl_TotalVenta
        '
        Me.lbl_TotalVenta.AutoSize = True
        Me.lbl_TotalVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.lbl_TotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_TotalVenta.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_TotalVenta.ForeColor = System.Drawing.Color.White
        Me.lbl_TotalVenta.Location = New System.Drawing.Point(406, 389)
        Me.lbl_TotalVenta.Name = "lbl_TotalVenta"
        Me.lbl_TotalVenta.Size = New System.Drawing.Size(63, 32)
        Me.lbl_TotalVenta.TabIndex = 27
        Me.lbl_TotalVenta.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(157, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 15)
        Me.Label8.TabIndex = 11
        '
        'Rbtn_Contado
        '
        Me.Rbtn_Contado.AutoSize = True
        Me.Rbtn_Contado.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Contado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Rbtn_Contado.Location = New System.Drawing.Point(166, 437)
        Me.Rbtn_Contado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rbtn_Contado.Name = "Rbtn_Contado"
        Me.Rbtn_Contado.Size = New System.Drawing.Size(84, 24)
        Me.Rbtn_Contado.TabIndex = 16
        Me.Rbtn_Contado.TabStop = True
        Me.Rbtn_Contado.Text = "Contado"
        Me.Rbtn_Contado.UseVisualStyleBackColor = True
        '
        'btn_Total_pagar
        '
        Me.btn_Total_pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btn_Total_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_Total_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Total_pagar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Total_pagar.ForeColor = System.Drawing.Color.White
        Me.btn_Total_pagar.Location = New System.Drawing.Point(49, 389)
        Me.btn_Total_pagar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Total_pagar.Name = "btn_Total_pagar"
        Me.btn_Total_pagar.Size = New System.Drawing.Size(313, 33)
        Me.btn_Total_pagar.TabIndex = 19
        Me.btn_Total_pagar.Text = "PAGAR EL CARRITO"
        Me.btn_Total_pagar.UseVisualStyleBackColor = False
        '
        'Rbtn_Credito
        '
        Me.Rbtn_Credito.AutoSize = True
        Me.Rbtn_Credito.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Rbtn_Credito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Rbtn_Credito.Location = New System.Drawing.Point(256, 437)
        Me.Rbtn_Credito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rbtn_Credito.Name = "Rbtn_Credito"
        Me.Rbtn_Credito.Size = New System.Drawing.Size(76, 24)
        Me.Rbtn_Credito.TabIndex = 17
        Me.Rbtn_Credito.TabStop = True
        Me.Rbtn_Credito.Text = "Crédito"
        Me.Rbtn_Credito.UseVisualStyleBackColor = True
        '
        'panel_detalle
        '
        Me.panel_detalle.BackColor = System.Drawing.Color.White
        Me.panel_detalle.Controls.Add(Me.GroupBox4)
        Me.panel_detalle.Controls.Add(Me.btnAceptarDetalleProducto)
        Me.panel_detalle.Controls.Add(Me.btnCancelarDetalleProducto)
        Me.panel_detalle.Controls.Add(Me.GroupBox3)
        Me.panel_detalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.panel_detalle.Location = New System.Drawing.Point(554, 387)
        Me.panel_detalle.Name = "panel_detalle"
        Me.panel_detalle.Size = New System.Drawing.Size(514, 275)
        Me.panel_detalle.TabIndex = 515
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pic_Producto)
        Me.GroupBox4.Controls.Add(Me.lbl_nombre)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 246)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LISTA DE DETALLE DE PRODUCTOS"
        '
        'pic_Producto
        '
        Me.pic_Producto.Location = New System.Drawing.Point(49, 40)
        Me.pic_Producto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_Producto.Name = "pic_Producto"
        Me.pic_Producto.Size = New System.Drawing.Size(164, 188)
        Me.pic_Producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Producto.TabIndex = 7
        Me.pic_Producto.TabStop = False
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nombre.Location = New System.Drawing.Point(99, 20)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(40, 16)
        Me.lbl_nombre.TabIndex = 6
        Me.lbl_nombre.Text = "texto"
        '
        'btnAceptarDetalleProducto
        '
        Me.btnAceptarDetalleProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAceptarDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarDetalleProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAceptarDetalleProducto.ForeColor = System.Drawing.Color.White
        Me.btnAceptarDetalleProducto.Location = New System.Drawing.Point(297, 148)
        Me.btnAceptarDetalleProducto.Name = "btnAceptarDetalleProducto"
        Me.btnAceptarDetalleProducto.Size = New System.Drawing.Size(87, 33)
        Me.btnAceptarDetalleProducto.TabIndex = 20
        Me.btnAceptarDetalleProducto.Text = "Aceptar"
        Me.btnAceptarDetalleProducto.UseVisualStyleBackColor = False
        '
        'btnCancelarDetalleProducto
        '
        Me.btnCancelarDetalleProducto.BackColor = System.Drawing.Color.Red
        Me.btnCancelarDetalleProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarDetalleProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelarDetalleProducto.ForeColor = System.Drawing.Color.White
        Me.btnCancelarDetalleProducto.Location = New System.Drawing.Point(420, 148)
        Me.btnCancelarDetalleProducto.Name = "btnCancelarDetalleProducto"
        Me.btnCancelarDetalleProducto.Size = New System.Drawing.Size(87, 33)
        Me.btnCancelarDetalleProducto.TabIndex = 11
        Me.btnCancelarDetalleProducto.Text = "Cancelar"
        Me.btnCancelarDetalleProducto.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_precio)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtCantidadProducto)
        Me.GroupBox3.Controls.Add(Me.lbl_stock)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(290, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 110)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_precio.Location = New System.Drawing.Point(130, 52)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(15, 16)
        Me.lbl_precio.TabIndex = 5
        Me.lbl_precio.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'txtCantidadProducto
        '
        Me.txtCantidadProducto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCantidadProducto.Location = New System.Drawing.Point(109, 75)
        Me.txtCantidadProducto.Name = "txtCantidadProducto"
        Me.txtCantidadProducto.Size = New System.Drawing.Size(90, 20)
        Me.txtCantidadProducto.TabIndex = 6
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_stock.Location = New System.Drawing.Point(130, 30)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(15, 16)
        Me.lbl_stock.TabIndex = 4
        Me.lbl_stock.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(21, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(21, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock"
        '
        'Lsv_det
        '
        Me.Lsv_det.Location = New System.Drawing.Point(49, 142)
        Me.Lsv_det.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lsv_det.Name = "Lsv_det"
        Me.Lsv_det.Size = New System.Drawing.Size(420, 244)
        Me.Lsv_det.TabIndex = 516
        Me.Lsv_det.UseCompatibleStateImageBehavior = False
        '
        'Labellinea
        '
        Me.Labellinea.AutoSize = True
        Me.Labellinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labellinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Labellinea.Location = New System.Drawing.Point(-7, 39)
        Me.Labellinea.Name = "Labellinea"
        Me.Labellinea.Size = New System.Drawing.Size(1700, 16)
        Me.Labellinea.TabIndex = 519
        Me.Labellinea.Text = resources.GetString("Labellinea.Text")
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.StoreAlt
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 30
        Me.IconPictureBox1.Location = New System.Drawing.Point(16, 9)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 518
        Me.IconPictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(61, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 517
        Me.Label7.Text = "VENTAS"
        '
        'View_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1213, 566)
        Me.Controls.Add(Me.Labellinea)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnl_ini)
        Me.Controls.Add(Me.Lsv_det)
        Me.Controls.Add(Me.panel_detalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_idcliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Rbtn_Credito)
        Me.Controls.Add(Me.btn_Total_pagar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Rbtn_Contado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_TotalVenta)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "View_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VENTAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnl_ini.ResumeLayout(False)
        Me.pnl_ini.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_detalle.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pic_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cmb_categoria As ComboBox
    Friend WithEvents Cb_filtro As CheckBox
    Friend WithEvents lbl_idcliente As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Actualizar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmb_cliente As ComboBox
    Friend WithEvents pnl_ini As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Rbtn_Contado As RadioButton
    Friend WithEvents btn_Total_pagar As Button
    Friend WithEvents Rbtn_Credito As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Public WithEvents lbl_TotalVenta As Label
    Friend WithEvents panel_detalle As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pic_Producto As PictureBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAceptarDetalleProducto As Button
    Friend WithEvents btnCancelarDetalleProducto As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_precio As Label
    Friend WithEvents txtCantidadProducto As TextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lsv_det As ListView
    Friend WithEvents Labellinea As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label7 As Label
End Class

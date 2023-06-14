<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class view_Principal
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
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.Btn_Cerrar_Sesion = New FontAwesome.Sharp.IconButton()
        Me.Btn_Reporte = New FontAwesome.Sharp.IconButton()
        Me.btn_empleado = New FontAwesome.Sharp.IconButton()
        Me.btn_cliente = New FontAwesome.Sharp.IconButton()
        Me.btn_categoria = New FontAwesome.Sharp.IconButton()
        Me.Btn_Proveedor = New FontAwesome.Sharp.IconButton()
        Me.Btn_Producto = New FontAwesome.Sharp.IconButton()
        Me.Btn_Pagos = New FontAwesome.Sharp.IconButton()
        Me.Btn_Compras = New FontAwesome.Sharp.IconButton()
        Me.Btn_Ventas = New FontAwesome.Sharp.IconButton()
        Me.Panel_Logo = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Barra_Titulo = New System.Windows.Forms.Panel()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_link_editar = New System.Windows.Forms.LinkLabel()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Pic_Perfil = New System.Windows.Forms.PictureBox()
        Me.Btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.Btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Btn_Maximizar = New System.Windows.Forms.PictureBox()
        Me.Title_Actual = New System.Windows.Forms.Label()
        Me.Icon_Form_Actual = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel_Secundario = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel_Menu.SuspendLayout()
        Me.Panel_Logo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra_Titulo.SuspendLayout()
        CType(Me.Pic_Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_Form_Actual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Secundario.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Menu
        '
        Me.Panel_Menu.AutoScroll = True
        Me.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel_Menu.Controls.Add(Me.Btn_Cerrar_Sesion)
        Me.Panel_Menu.Controls.Add(Me.Btn_Reporte)
        Me.Panel_Menu.Controls.Add(Me.btn_empleado)
        Me.Panel_Menu.Controls.Add(Me.btn_cliente)
        Me.Panel_Menu.Controls.Add(Me.btn_categoria)
        Me.Panel_Menu.Controls.Add(Me.Btn_Proveedor)
        Me.Panel_Menu.Controls.Add(Me.Btn_Producto)
        Me.Panel_Menu.Controls.Add(Me.Btn_Pagos)
        Me.Panel_Menu.Controls.Add(Me.Btn_Compras)
        Me.Panel_Menu.Controls.Add(Me.Btn_Ventas)
        Me.Panel_Menu.Controls.Add(Me.Panel_Logo)
        Me.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(237, 559)
        Me.Panel_Menu.TabIndex = 0
        '
        'Btn_Cerrar_Sesion
        '
        Me.Btn_Cerrar_Sesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Cerrar_Sesion.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar_Sesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Cerrar_Sesion.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Cerrar_Sesion.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.Btn_Cerrar_Sesion.IconColor = System.Drawing.Color.White
        Me.Btn_Cerrar_Sesion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Cerrar_Sesion.IconSize = 35
        Me.Btn_Cerrar_Sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar_Sesion.Location = New System.Drawing.Point(-5, 644)
        Me.Btn_Cerrar_Sesion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Cerrar_Sesion.Name = "Btn_Cerrar_Sesion"
        Me.Btn_Cerrar_Sesion.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Cerrar_Sesion.Size = New System.Drawing.Size(237, 34)
        Me.Btn_Cerrar_Sesion.TabIndex = 7
        Me.Btn_Cerrar_Sesion.Text = "Cerrar Sesión"
        Me.Btn_Cerrar_Sesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Cerrar_Sesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar_Sesion.UseVisualStyleBackColor = False
        '
        'Btn_Reporte
        '
        Me.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Reporte.FlatAppearance.BorderSize = 0
        Me.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Reporte.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Reporte.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Reporte.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench
        Me.Btn_Reporte.IconColor = System.Drawing.Color.White
        Me.Btn_Reporte.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Reporte.IconSize = 35
        Me.Btn_Reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Reporte.Location = New System.Drawing.Point(0, 602)
        Me.Btn_Reporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Reporte.Name = "Btn_Reporte"
        Me.Btn_Reporte.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Reporte.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Reporte.TabIndex = 6
        Me.Btn_Reporte.Text = "Reportes"
        Me.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Reporte.UseVisualStyleBackColor = False
        '
        'btn_empleado
        '
        Me.btn_empleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btn_empleado.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_empleado.FlatAppearance.BorderSize = 0
        Me.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_empleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_empleado.ForeColor = System.Drawing.Color.Silver
        Me.btn_empleado.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.btn_empleado.IconColor = System.Drawing.Color.White
        Me.btn_empleado.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_empleado.IconSize = 35
        Me.btn_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empleado.Location = New System.Drawing.Point(0, 562)
        Me.btn_empleado.Name = "btn_empleado"
        Me.btn_empleado.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_empleado.Size = New System.Drawing.Size(237, 45)
        Me.btn_empleado.TabIndex = 8
        Me.btn_empleado.Text = "Empleados"
        Me.btn_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_empleado.UseVisualStyleBackColor = False
        '
        'btn_cliente
        '
        Me.btn_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btn_cliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cliente.FlatAppearance.BorderSize = 0
        Me.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_cliente.ForeColor = System.Drawing.Color.Silver
        Me.btn_cliente.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.btn_cliente.IconColor = System.Drawing.Color.White
        Me.btn_cliente.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cliente.IconSize = 35
        Me.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cliente.Location = New System.Drawing.Point(0, 517)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_cliente.Size = New System.Drawing.Size(237, 45)
        Me.btn_cliente.TabIndex = 7
        Me.btn_cliente.Text = "Clientes"
        Me.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cliente.UseVisualStyleBackColor = False
        '
        'btn_categoria
        '
        Me.btn_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.btn_categoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_categoria.FlatAppearance.BorderSize = 0
        Me.btn_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categoria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_categoria.ForeColor = System.Drawing.Color.Silver
        Me.btn_categoria.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal
        Me.btn_categoria.IconColor = System.Drawing.Color.White
        Me.btn_categoria.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_categoria.IconSize = 35
        Me.btn_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categoria.Location = New System.Drawing.Point(0, 472)
        Me.btn_categoria.Name = "btn_categoria"
        Me.btn_categoria.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_categoria.Size = New System.Drawing.Size(237, 45)
        Me.btn_categoria.TabIndex = 6
        Me.btn_categoria.Text = "Categorias"
        Me.btn_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_categoria.UseVisualStyleBackColor = False
        '
        'Btn_Proveedor
        '
        Me.Btn_Proveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Proveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Proveedor.FlatAppearance.BorderSize = 0
        Me.Btn_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Proveedor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Proveedor.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Proveedor.IconChar = FontAwesome.Sharp.IconChar.Supple
        Me.Btn_Proveedor.IconColor = System.Drawing.Color.White
        Me.Btn_Proveedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Proveedor.IconSize = 35
        Me.Btn_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Proveedor.Location = New System.Drawing.Point(0, 427)
        Me.Btn_Proveedor.Name = "Btn_Proveedor"
        Me.Btn_Proveedor.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Proveedor.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Proveedor.TabIndex = 5
        Me.Btn_Proveedor.Text = "Proveedores"
        Me.Btn_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Proveedor.UseVisualStyleBackColor = False
        '
        'Btn_Producto
        '
        Me.Btn_Producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Producto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Producto.FlatAppearance.BorderSize = 0
        Me.Btn_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Producto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Producto.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Producto.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.Btn_Producto.IconColor = System.Drawing.Color.White
        Me.Btn_Producto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Producto.IconSize = 35
        Me.Btn_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Producto.Location = New System.Drawing.Point(0, 382)
        Me.Btn_Producto.Name = "Btn_Producto"
        Me.Btn_Producto.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Producto.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Producto.TabIndex = 4
        Me.Btn_Producto.Text = "Productos"
        Me.Btn_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Producto.UseVisualStyleBackColor = False
        '
        'Btn_Pagos
        '
        Me.Btn_Pagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Pagos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Pagos.FlatAppearance.BorderSize = 0
        Me.Btn_Pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Pagos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Pagos.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Pagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        Me.Btn_Pagos.IconColor = System.Drawing.Color.White
        Me.Btn_Pagos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Pagos.IconSize = 35
        Me.Btn_Pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.Location = New System.Drawing.Point(0, 337)
        Me.Btn_Pagos.Name = "Btn_Pagos"
        Me.Btn_Pagos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Pagos.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Pagos.TabIndex = 3
        Me.Btn_Pagos.Text = "Pagos"
        Me.Btn_Pagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Pagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Pagos.UseVisualStyleBackColor = False
        '
        'Btn_Compras
        '
        Me.Btn_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Compras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Compras.FlatAppearance.BorderSize = 0
        Me.Btn_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Compras.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Compras.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Compras.IconChar = FontAwesome.Sharp.IconChar.TruckFast
        Me.Btn_Compras.IconColor = System.Drawing.Color.White
        Me.Btn_Compras.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Compras.IconSize = 35
        Me.Btn_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Compras.Location = New System.Drawing.Point(0, 292)
        Me.Btn_Compras.Name = "Btn_Compras"
        Me.Btn_Compras.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Compras.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Compras.TabIndex = 2
        Me.Btn_Compras.Text = "Compras"
        Me.Btn_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Compras.UseVisualStyleBackColor = False
        '
        'Btn_Ventas
        '
        Me.Btn_Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_Ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Ventas.FlatAppearance.BorderSize = 0
        Me.Btn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ventas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Ventas.ForeColor = System.Drawing.Color.Silver
        Me.Btn_Ventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.Btn_Ventas.IconColor = System.Drawing.Color.White
        Me.Btn_Ventas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Btn_Ventas.IconSize = 35
        Me.Btn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ventas.Location = New System.Drawing.Point(0, 247)
        Me.Btn_Ventas.Name = "Btn_Ventas"
        Me.Btn_Ventas.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.Btn_Ventas.Size = New System.Drawing.Size(237, 45)
        Me.Btn_Ventas.TabIndex = 1
        Me.Btn_Ventas.Text = "Ventas"
        Me.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Ventas.UseVisualStyleBackColor = False
        '
        'Panel_Logo
        '
        Me.Panel_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel_Logo.Controls.Add(Me.PictureBox3)
        Me.Panel_Logo.Controls.Add(Me.lbl_apellidos)
        Me.Panel_Logo.Controls.Add(Me.Label1)
        Me.Panel_Logo.Controls.Add(Me.lbl_Nombre)
        Me.Panel_Logo.Controls.Add(Me.PictureBox1)
        Me.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Logo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Logo.Name = "Panel_Logo"
        Me.Panel_Logo.Size = New System.Drawing.Size(237, 247)
        Me.Panel_Logo.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.Presentacion.My.Resources.Resources.usuario2
        Me.PictureBox3.Location = New System.Drawing.Point(52, 175)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_apellidos.AutoSize = True
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_apellidos.ForeColor = System.Drawing.Color.White
        Me.lbl_apellidos.Location = New System.Drawing.Point(141, 182)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(49, 19)
        Me.lbl_apellidos.TabIndex = 10
        Me.lbl_apellidos.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MENÚ FERRETERIA"
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Nombre.ForeColor = System.Drawing.Color.White
        Me.lbl_Nombre.Location = New System.Drawing.Point(82, 182)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(49, 19)
        Me.lbl_Nombre.TabIndex = 6
        Me.lbl_Nombre.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Barra_Titulo
        '
        Me.Barra_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Barra_Titulo.Controls.Add(Me.lbl_id)
        Me.Barra_Titulo.Controls.Add(Me.lbl_link_editar)
        Me.Barra_Titulo.Controls.Add(Me.lbl_usuario)
        Me.Barra_Titulo.Controls.Add(Me.Pic_Perfil)
        Me.Barra_Titulo.Controls.Add(Me.Btn_minimizar)
        Me.Barra_Titulo.Controls.Add(Me.Btn_Cerrar)
        Me.Barra_Titulo.Controls.Add(Me.Btn_Maximizar)
        Me.Barra_Titulo.Controls.Add(Me.Title_Actual)
        Me.Barra_Titulo.Controls.Add(Me.Icon_Form_Actual)
        Me.Barra_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Titulo.Location = New System.Drawing.Point(237, 0)
        Me.Barra_Titulo.Name = "Barra_Titulo"
        Me.Barra_Titulo.Size = New System.Drawing.Size(693, 57)
        Me.Barra_Titulo.TabIndex = 1
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(710, 55)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(35, 15)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "lbl_id"
        Me.lbl_id.Visible = False
        '
        'lbl_link_editar
        '
        Me.lbl_link_editar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_link_editar.AutoSize = True
        Me.lbl_link_editar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_link_editar.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_link_editar.Location = New System.Drawing.Point(524, 34)
        Me.lbl_link_editar.Name = "lbl_link_editar"
        Me.lbl_link_editar.Size = New System.Drawing.Size(67, 15)
        Me.lbl_link_editar.TabIndex = 9
        Me.lbl_link_editar.TabStop = True
        Me.lbl_link_editar.Text = "Editar Perfil"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_usuario.ForeColor = System.Drawing.Color.White
        Me.lbl_usuario.Location = New System.Drawing.Point(550, 7)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(49, 19)
        Me.lbl_usuario.TabIndex = 8
        Me.lbl_usuario.Text = "Label2"
        '
        'Pic_Perfil
        '
        Me.Pic_Perfil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Perfil.Image = Global.Presentacion.My.Resources.Resources.usuario2
        Me.Pic_Perfil.Location = New System.Drawing.Point(519, 8)
        Me.Pic_Perfil.Name = "Pic_Perfil"
        Me.Pic_Perfil.Size = New System.Drawing.Size(28, 19)
        Me.Pic_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Perfil.TabIndex = 5
        Me.Pic_Perfil.TabStop = False
        '
        'Btn_minimizar
        '
        Me.Btn_minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_minimizar.Image = Global.Presentacion.My.Resources.Resources.login_minimizar
        Me.Btn_minimizar.Location = New System.Drawing.Point(623, 7)
        Me.Btn_minimizar.Name = "Btn_minimizar"
        Me.Btn_minimizar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_minimizar.TabIndex = 4
        Me.Btn_minimizar.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Presentacion.My.Resources.Resources.login_cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(668, 7)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.TabStop = False
        '
        'Btn_Maximizar
        '
        Me.Btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximizar.Image = Global.Presentacion.My.Resources.Resources.compartir
        Me.Btn_Maximizar.Location = New System.Drawing.Point(645, 7)
        Me.Btn_Maximizar.Name = "Btn_Maximizar"
        Me.Btn_Maximizar.Size = New System.Drawing.Size(16, 16)
        Me.Btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Btn_Maximizar.TabIndex = 2
        Me.Btn_Maximizar.TabStop = False
        '
        'Title_Actual
        '
        Me.Title_Actual.AutoSize = True
        Me.Title_Actual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title_Actual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Title_Actual.Location = New System.Drawing.Point(84, 22)
        Me.Title_Actual.Name = "Title_Actual"
        Me.Title_Actual.Size = New System.Drawing.Size(60, 21)
        Me.Title_Actual.TabIndex = 1
        Me.Title_Actual.Text = "INICIO"
        Me.Title_Actual.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Icon_Form_Actual
        '
        Me.Icon_Form_Actual.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Icon_Form_Actual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.Icon_Form_Actual.IconColor = System.Drawing.Color.White
        Me.Icon_Form_Actual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Icon_Form_Actual.IconSize = 36
        Me.Icon_Form_Actual.Location = New System.Drawing.Point(35, 14)
        Me.Icon_Form_Actual.Name = "Icon_Form_Actual"
        Me.Icon_Form_Actual.Size = New System.Drawing.Size(40, 36)
        Me.Icon_Form_Actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Icon_Form_Actual.TabIndex = 0
        Me.Icon_Form_Actual.TabStop = False
        '
        'Panel_Secundario
        '
        Me.Panel_Secundario.AutoSize = True
        Me.Panel_Secundario.BackColor = System.Drawing.Color.White
        Me.Panel_Secundario.Controls.Add(Me.PictureBox2)
        Me.Panel_Secundario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Secundario.Location = New System.Drawing.Point(237, 57)
        Me.Panel_Secundario.Name = "Panel_Secundario"
        Me.Panel_Secundario.Size = New System.Drawing.Size(693, 502)
        Me.Panel_Secundario.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Presentacion.My.Resources.Resources.PANEL
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(693, 502)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'view_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(930, 559)
        Me.Controls.Add(Me.Panel_Secundario)
        Me.Controls.Add(Me.Barra_Titulo)
        Me.Controls.Add(Me.Panel_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "view_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferretería JHAYLI"
        Me.Panel_Menu.ResumeLayout(False)
        Me.Panel_Logo.ResumeLayout(False)
        Me.Panel_Logo.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra_Titulo.ResumeLayout(False)
        Me.Barra_Titulo.PerformLayout()
        CType(Me.Pic_Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_Form_Actual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Secundario.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Menu As Panel
    Friend WithEvents Btn_Ventas As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel_Logo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Producto As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Pagos As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Compras As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn_Reporte As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Barra_Titulo As Panel
    Friend WithEvents Icon_Form_Actual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Title_Actual As Label
    Friend WithEvents Btn_minimizar As PictureBox
    Friend WithEvents Btn_Cerrar As PictureBox
    Friend WithEvents Btn_Maximizar As PictureBox
    Friend WithEvents Panel_Secundario As Panel
    Friend WithEvents Btn_Cerrar_Sesion As FontAwesome.Sharp.IconButton
    Friend WithEvents Pic_Perfil As PictureBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_Nombre As Label
    Friend WithEvents lbl_link_editar As LinkLabel
    Friend WithEvents lbl_apellidos As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents btnEmpleados As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_Proveedor As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_empleado As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cliente As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_categoria As FontAwesome.Sharp.IconButton
End Class

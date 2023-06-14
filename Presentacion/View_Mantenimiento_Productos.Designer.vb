<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Mantenimiento_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Mantenimiento_Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_buscar = New System.Windows.Forms.Button()
        Me.Labellinea = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtbuscarproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subirfotoproducto = New System.Windows.Forms.Button()
        Me.PBImagenes = New System.Windows.Forms.PictureBox()
        Me.btnmodificarproducto = New System.Windows.Forms.Button()
        Me.btnnuevoproducto = New System.Windows.Forms.Button()
        Me.cbproveeproducto = New System.Windows.Forms.ComboBox()
        Me.numstockproducto = New System.Windows.Forms.NumericUpDown()
        Me.numprecioproducto = New System.Windows.Forms.NumericUpDown()
        Me.cbcategoriaproducto = New System.Windows.Forms.ComboBox()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.labelidproducto = New System.Windows.Forms.Label()
        Me.labelproveedor = New System.Windows.Forms.Label()
        Me.labelstock = New System.Windows.Forms.Label()
        Me.labelprecio = New System.Windows.Forms.Label()
        Me.ñabelcategoria = New System.Windows.Forms.Label()
        Me.Labelnombre = New System.Windows.Forms.Label()
        Me.Labelid = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numstockproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numprecioproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_buscar)
        Me.Panel1.Controls.Add(Me.Labellinea)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtbuscarproducto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.subirfotoproducto)
        Me.Panel1.Controls.Add(Me.PBImagenes)
        Me.Panel1.Controls.Add(Me.btnmodificarproducto)
        Me.Panel1.Controls.Add(Me.btnnuevoproducto)
        Me.Panel1.Controls.Add(Me.cbproveeproducto)
        Me.Panel1.Controls.Add(Me.numstockproducto)
        Me.Panel1.Controls.Add(Me.numprecioproducto)
        Me.Panel1.Controls.Add(Me.cbcategoriaproducto)
        Me.Panel1.Controls.Add(Me.txtnombreproducto)
        Me.Panel1.Controls.Add(Me.labelidproducto)
        Me.Panel1.Controls.Add(Me.labelproveedor)
        Me.Panel1.Controls.Add(Me.labelstock)
        Me.Panel1.Controls.Add(Me.labelprecio)
        Me.Panel1.Controls.Add(Me.ñabelcategoria)
        Me.Panel1.Controls.Add(Me.Labelnombre)
        Me.Panel1.Controls.Add(Me.Labelid)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 638)
        Me.Panel1.TabIndex = 0
        '
        'Btn_buscar
        '
        Me.Btn_buscar.BackColor = System.Drawing.Color.ForestGreen
        Me.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Btn_buscar.ForeColor = System.Drawing.Color.White
        Me.Btn_buscar.Location = New System.Drawing.Point(1030, 25)
        Me.Btn_buscar.Name = "Btn_buscar"
        Me.Btn_buscar.Size = New System.Drawing.Size(71, 27)
        Me.Btn_buscar.TabIndex = 52
        Me.Btn_buscar.Text = "Buscar"
        Me.Btn_buscar.UseVisualStyleBackColor = False
        '
        'Labellinea
        '
        Me.Labellinea.AutoSize = True
        Me.Labellinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labellinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Labellinea.Location = New System.Drawing.Point(-213, 56)
        Me.Labellinea.Name = "Labellinea"
        Me.Labellinea.Size = New System.Drawing.Size(1700, 16)
        Me.Labellinea.TabIndex = 51
        Me.Labellinea.Text = resources.GetString("Labellinea.Text")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(548, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 35)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DGV_Productos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(70, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 314)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE PRODUCTOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(510, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "00"
        Me.Label9.Visible = False
        '
        'DGV_Productos
        '
        Me.DGV_Productos.AllowUserToAddRows = False
        Me.DGV_Productos.AllowUserToDeleteRows = False
        Me.DGV_Productos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGV_Productos.GridColor = System.Drawing.Color.White
        Me.DGV_Productos.Location = New System.Drawing.Point(27, 28)
        Me.DGV_Productos.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV_Productos.Name = "DGV_Productos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Productos.RowHeadersVisible = False
        Me.DGV_Productos.RowHeadersWidth = 51
        Me.DGV_Productos.RowTemplate.Height = 25
        Me.DGV_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Productos.Size = New System.Drawing.Size(924, 261)
        Me.DGV_Productos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idproducto"
        Me.Column1.HeaderText = "idproducto"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombre"
        Me.Column2.HeaderText = "nombre"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "idcategoria"
        Me.Column3.HeaderText = "idcategoria"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "precio"
        Me.Column4.HeaderText = "precio"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "stock"
        Me.Column5.HeaderText = "stock"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "idproveedor"
        Me.Column6.HeaderText = "idproveedor "
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "foto"
        Me.Column7.HeaderText = "foto"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'txtbuscarproducto
        '
        Me.txtbuscarproducto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtbuscarproducto.Location = New System.Drawing.Point(661, 26)
        Me.txtbuscarproducto.Name = "txtbuscarproducto"
        Me.txtbuscarproducto.Size = New System.Drawing.Size(360, 25)
        Me.txtbuscarproducto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(600, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'subirfotoproducto
        '
        Me.subirfotoproducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.subirfotoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subirfotoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.subirfotoproducto.ForeColor = System.Drawing.Color.White
        Me.subirfotoproducto.Location = New System.Drawing.Point(867, 241)
        Me.subirfotoproducto.Name = "subirfotoproducto"
        Me.subirfotoproducto.Size = New System.Drawing.Size(99, 35)
        Me.subirfotoproducto.TabIndex = 48
        Me.subirfotoproducto.Text = "Subir Foto"
        Me.subirfotoproducto.UseVisualStyleBackColor = False
        '
        'PBImagenes
        '
        Me.PBImagenes.BackColor = System.Drawing.Color.White
        Me.PBImagenes.Location = New System.Drawing.Point(850, 88)
        Me.PBImagenes.Name = "PBImagenes"
        Me.PBImagenes.Size = New System.Drawing.Size(136, 138)
        Me.PBImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenes.TabIndex = 47
        Me.PBImagenes.TabStop = False
        '
        'btnmodificarproducto
        '
        Me.btnmodificarproducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnmodificarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmodificarproducto.ForeColor = System.Drawing.Color.White
        Me.btnmodificarproducto.Location = New System.Drawing.Point(398, 200)
        Me.btnmodificarproducto.Name = "btnmodificarproducto"
        Me.btnmodificarproducto.Size = New System.Drawing.Size(99, 35)
        Me.btnmodificarproducto.TabIndex = 46
        Me.btnmodificarproducto.Text = "Modificar"
        Me.btnmodificarproducto.UseVisualStyleBackColor = False
        '
        'btnnuevoproducto
        '
        Me.btnnuevoproducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnnuevoproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevoproducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnnuevoproducto.ForeColor = System.Drawing.Color.White
        Me.btnnuevoproducto.Location = New System.Drawing.Point(248, 200)
        Me.btnnuevoproducto.Name = "btnnuevoproducto"
        Me.btnnuevoproducto.Size = New System.Drawing.Size(99, 35)
        Me.btnnuevoproducto.TabIndex = 45
        Me.btnnuevoproducto.Text = "Nuevo"
        Me.btnnuevoproducto.UseVisualStyleBackColor = False
        '
        'cbproveeproducto
        '
        Me.cbproveeproducto.FormattingEnabled = True
        Me.cbproveeproducto.Location = New System.Drawing.Point(673, 131)
        Me.cbproveeproducto.Name = "cbproveeproducto"
        Me.cbproveeproducto.Size = New System.Drawing.Size(152, 25)
        Me.cbproveeproducto.TabIndex = 44
        '
        'numstockproducto
        '
        Me.numstockproducto.Location = New System.Drawing.Point(398, 132)
        Me.numstockproducto.Name = "numstockproducto"
        Me.numstockproducto.Size = New System.Drawing.Size(152, 25)
        Me.numstockproducto.TabIndex = 43
        '
        'numprecioproducto
        '
        Me.numprecioproducto.Location = New System.Drawing.Point(156, 132)
        Me.numprecioproducto.Name = "numprecioproducto"
        Me.numprecioproducto.Size = New System.Drawing.Size(152, 25)
        Me.numprecioproducto.TabIndex = 42
        '
        'cbcategoriaproducto
        '
        Me.cbcategoriaproducto.FormattingEnabled = True
        Me.cbcategoriaproducto.Location = New System.Drawing.Point(639, 88)
        Me.cbcategoriaproducto.Name = "cbcategoriaproducto"
        Me.cbcategoriaproducto.Size = New System.Drawing.Size(152, 25)
        Me.cbcategoriaproducto.TabIndex = 41
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtnombreproducto.Location = New System.Drawing.Point(306, 88)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(207, 25)
        Me.txtnombreproducto.TabIndex = 40
        '
        'labelidproducto
        '
        Me.labelidproducto.AutoSize = True
        Me.labelidproducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.labelidproducto.Location = New System.Drawing.Point(153, 94)
        Me.labelidproducto.Name = "labelidproducto"
        Me.labelidproducto.Size = New System.Drawing.Size(24, 17)
        Me.labelidproducto.TabIndex = 39
        Me.labelidproducto.Text = "00"
        '
        'labelproveedor
        '
        Me.labelproveedor.AutoSize = True
        Me.labelproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelproveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.labelproveedor.Location = New System.Drawing.Point(576, 135)
        Me.labelproveedor.Name = "labelproveedor"
        Me.labelproveedor.Size = New System.Drawing.Size(80, 16)
        Me.labelproveedor.TabIndex = 38
        Me.labelproveedor.Text = "Proveedor"
        '
        'labelstock
        '
        Me.labelstock.AutoSize = True
        Me.labelstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.labelstock.Location = New System.Drawing.Point(346, 137)
        Me.labelstock.Name = "labelstock"
        Me.labelstock.Size = New System.Drawing.Size(46, 16)
        Me.labelstock.TabIndex = 37
        Me.labelstock.Text = "Stock"
        '
        'labelprecio
        '
        Me.labelprecio.AutoSize = True
        Me.labelprecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelprecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.labelprecio.Location = New System.Drawing.Point(98, 137)
        Me.labelprecio.Name = "labelprecio"
        Me.labelprecio.Size = New System.Drawing.Size(52, 16)
        Me.labelprecio.TabIndex = 36
        Me.labelprecio.Text = "Precio"
        '
        'ñabelcategoria
        '
        Me.ñabelcategoria.AutoSize = True
        Me.ñabelcategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ñabelcategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ñabelcategoria.Location = New System.Drawing.Point(548, 91)
        Me.ñabelcategoria.Name = "ñabelcategoria"
        Me.ñabelcategoria.Size = New System.Drawing.Size(75, 16)
        Me.ñabelcategoria.TabIndex = 35
        Me.ñabelcategoria.Text = "Categoría"
        '
        'Labelnombre
        '
        Me.Labelnombre.AutoSize = True
        Me.Labelnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labelnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Labelnombre.Location = New System.Drawing.Point(238, 93)
        Me.Labelnombre.Name = "Labelnombre"
        Me.Labelnombre.Size = New System.Drawing.Size(62, 16)
        Me.Labelnombre.TabIndex = 34
        Me.Labelnombre.Text = "Nombre"
        '
        'Labelid
        '
        Me.Labelid.AutoSize = True
        Me.Labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labelid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Labelid.Location = New System.Drawing.Point(97, 94)
        Me.Labelid.Name = "Labelid"
        Me.Labelid.Size = New System.Drawing.Size(22, 16)
        Me.Labelid.TabIndex = 33
        Me.Labelid.Text = "ID"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PaintRoller
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(31, 17)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 36)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 32
        Me.IconPictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(70, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 18)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "MANTENIMIENTO DE PRODUCTOS"
        '
        'View_Mantenimiento_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 638)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Mantenimiento_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View_Mantenimiento_Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numstockproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numprecioproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents txtbuscarproducto As TextBox
    Friend WithEvents subirfotoproducto As Button
    Friend WithEvents PBImagenes As PictureBox
    Friend WithEvents btnmodificarproducto As Button
    Friend WithEvents btnnuevoproducto As Button
    Friend WithEvents cbproveeproducto As ComboBox
    Friend WithEvents numstockproducto As NumericUpDown
    Friend WithEvents numprecioproducto As NumericUpDown
    Friend WithEvents cbcategoriaproducto As ComboBox
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents labelidproducto As Label
    Friend WithEvents labelproveedor As Label
    Friend WithEvents labelstock As Label
    Friend WithEvents labelprecio As Label
    Friend WithEvents ñabelcategoria As Label
    Friend WithEvents Labelnombre As Label
    Friend WithEvents Labelid As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Labellinea As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_buscar As Button
End Class

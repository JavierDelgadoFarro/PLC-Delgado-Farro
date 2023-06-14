<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Compra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Compra))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lbl_nombre1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnCancelarDetalle = New System.Windows.Forms.Button()
        Me.btnAceptarDetalle = New System.Windows.Forms.Button()
        Me.importeDetalle = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.listCompras = New System.Windows.Forms.ListView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_2_por = New System.Windows.Forms.Label()
        Me.Btn_comprar = New System.Windows.Forms.Button()
        Me.CheckPorcentaje = New System.Windows.Forms.CheckBox()
        Me.CheckIgv = New System.Windows.Forms.CheckBox()
        Me.LabelImporteTotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelPorcentaje = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_Igv = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.id_Prov = New System.Windows.Forms.Label()
        Me.dateFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboComprobante = New System.Windows.Forms.ComboBox()
        Me.cbxNombreProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.checkFiltro = New System.Windows.Forms.CheckBox()
        Me.Labellinea = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.importeDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Location = New System.Drawing.Point(611, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(368, 414)
        Me.Panel2.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox)
        Me.GroupBox4.Controls.Add(Me.lbl_nombre1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(18, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 242)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "LISTA DE DETALLE DE COMPRAS"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(71, 64)
        Me.PictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(186, 156)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 9
        Me.PictureBox.TabStop = False
        '
        'lbl_nombre1
        '
        Me.lbl_nombre1.AutoSize = True
        Me.lbl_nombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nombre1.Location = New System.Drawing.Point(124, 31)
        Me.lbl_nombre1.Name = "lbl_nombre1"
        Me.lbl_nombre1.Size = New System.Drawing.Size(40, 16)
        Me.lbl_nombre1.TabIndex = 8
        Me.lbl_nombre1.Text = "texto"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtCantidad)
        Me.GroupBox5.Controls.Add(Me.btnCancelarDetalle)
        Me.GroupBox5.Controls.Add(Me.btnAceptarDetalle)
        Me.GroupBox5.Controls.Add(Me.importeDetalle)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(18, 27)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(324, 104)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCantidad.Location = New System.Drawing.Point(106, 27)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidad.TabIndex = 21
        '
        'btnCancelarDetalle
        '
        Me.btnCancelarDetalle.BackColor = System.Drawing.Color.Red
        Me.btnCancelarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelarDetalle.ForeColor = System.Drawing.Color.White
        Me.btnCancelarDetalle.Location = New System.Drawing.Point(225, 66)
        Me.btnCancelarDetalle.Name = "btnCancelarDetalle"
        Me.btnCancelarDetalle.Size = New System.Drawing.Size(87, 26)
        Me.btnCancelarDetalle.TabIndex = 11
        Me.btnCancelarDetalle.Text = "Cancelar"
        Me.btnCancelarDetalle.UseVisualStyleBackColor = False
        '
        'btnAceptarDetalle
        '
        Me.btnAceptarDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnAceptarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAceptarDetalle.ForeColor = System.Drawing.Color.White
        Me.btnAceptarDetalle.Location = New System.Drawing.Point(225, 26)
        Me.btnAceptarDetalle.Name = "btnAceptarDetalle"
        Me.btnAceptarDetalle.Size = New System.Drawing.Size(87, 24)
        Me.btnAceptarDetalle.TabIndex = 20
        Me.btnAceptarDetalle.Text = "Aceptar"
        Me.btnAceptarDetalle.UseVisualStyleBackColor = False
        '
        'importeDetalle
        '
        Me.importeDetalle.Location = New System.Drawing.Point(106, 71)
        Me.importeDetalle.Name = "importeDetalle"
        Me.importeDetalle.Size = New System.Drawing.Size(92, 20)
        Me.importeDetalle.TabIndex = 4
        Me.importeDetalle.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(18, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Importe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(15, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Check2)
        Me.GroupBox1.Controls.Add(Me.listCompras)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_total)
        Me.GroupBox1.Controls.Add(Me.lbl_2_por)
        Me.GroupBox1.Controls.Add(Me.Btn_comprar)
        Me.GroupBox1.Controls.Add(Me.CheckPorcentaje)
        Me.GroupBox1.Controls.Add(Me.CheckIgv)
        Me.GroupBox1.Controls.Add(Me.LabelImporteTotal)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LabelPorcentaje)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_Igv)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_SubTotal)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE COMPRAS"
        '
        'Check2
        '
        Me.Check2.AutoSize = True
        Me.Check2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Check2.Location = New System.Drawing.Point(103, 188)
        Me.Check2.Name = "Check2"
        Me.Check2.Size = New System.Drawing.Size(42, 17)
        Me.Check2.TabIndex = 35
        Me.Check2.Text = "2%"
        Me.Check2.UseVisualStyleBackColor = True
        '
        'listCompras
        '
        Me.listCompras.Location = New System.Drawing.Point(18, 17)
        Me.listCompras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listCompras.Name = "listCompras"
        Me.listCompras.Size = New System.Drawing.Size(388, 153)
        Me.listCompras.TabIndex = 34
        Me.listCompras.UseCompatibleStateImageBehavior = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(200, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "IMPORTE TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "2 %"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(339, 260)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(32, 13)
        Me.lbl_total.TabIndex = 31
        Me.lbl_total.Text = "0.00"
        '
        'lbl_2_por
        '
        Me.lbl_2_por.AutoSize = True
        Me.lbl_2_por.Location = New System.Drawing.Point(340, 230)
        Me.lbl_2_por.Name = "lbl_2_por"
        Me.lbl_2_por.Size = New System.Drawing.Size(32, 13)
        Me.lbl_2_por.TabIndex = 30
        Me.lbl_2_por.Text = "0.00"
        '
        'Btn_comprar
        '
        Me.Btn_comprar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Btn_comprar.ForeColor = System.Drawing.Color.Black
        Me.Btn_comprar.Location = New System.Drawing.Point(33, 221)
        Me.Btn_comprar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_comprar.Name = "Btn_comprar"
        Me.Btn_comprar.Size = New System.Drawing.Size(129, 33)
        Me.Btn_comprar.TabIndex = 29
        Me.Btn_comprar.Text = "Comprar"
        Me.Btn_comprar.UseVisualStyleBackColor = False
        '
        'CheckPorcentaje
        '
        Me.CheckPorcentaje.AutoSize = True
        Me.CheckPorcentaje.Location = New System.Drawing.Point(43, 384)
        Me.CheckPorcentaje.Name = "CheckPorcentaje"
        Me.CheckPorcentaje.Size = New System.Drawing.Size(42, 17)
        Me.CheckPorcentaje.TabIndex = 26
        Me.CheckPorcentaje.Text = "2%"
        Me.CheckPorcentaje.UseVisualStyleBackColor = True
        '
        'CheckIgv
        '
        Me.CheckIgv.AutoSize = True
        Me.CheckIgv.Location = New System.Drawing.Point(33, 186)
        Me.CheckIgv.Name = "CheckIgv"
        Me.CheckIgv.Size = New System.Drawing.Size(47, 17)
        Me.CheckIgv.TabIndex = 25
        Me.CheckIgv.Text = "IGV"
        Me.CheckIgv.UseVisualStyleBackColor = True
        '
        'LabelImporteTotal
        '
        Me.LabelImporteTotal.AutoSize = True
        Me.LabelImporteTotal.Location = New System.Drawing.Point(281, 414)
        Me.LabelImporteTotal.Name = "LabelImporteTotal"
        Me.LabelImporteTotal.Size = New System.Drawing.Size(32, 13)
        Me.LabelImporteTotal.TabIndex = 24
        Me.LabelImporteTotal.Text = "0.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(152, 414)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Importe Total"
        '
        'LabelPorcentaje
        '
        Me.LabelPorcentaje.AutoSize = True
        Me.LabelPorcentaje.Location = New System.Drawing.Point(281, 385)
        Me.LabelPorcentaje.Name = "LabelPorcentaje"
        Me.LabelPorcentaje.Size = New System.Drawing.Size(32, 13)
        Me.LabelPorcentaje.TabIndex = 22
        Me.LabelPorcentaje.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(152, 385)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "2%"
        '
        'lbl_Igv
        '
        Me.lbl_Igv.AutoSize = True
        Me.lbl_Igv.Location = New System.Drawing.Point(341, 209)
        Me.lbl_Igv.Name = "lbl_Igv"
        Me.lbl_Igv.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Igv.TabIndex = 20
        Me.lbl_Igv.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(202, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "IGV 18%"
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.AutoSize = True
        Me.lbl_SubTotal.Location = New System.Drawing.Point(340, 188)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(32, 13)
        Me.lbl_SubTotal.TabIndex = 18
        Me.lbl_SubTotal.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(202, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SubTotal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.id_Prov)
        Me.GroupBox3.Controls.Add(Me.dateFechaCompra)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.comboComprobante)
        Me.GroupBox3.Controls.Add(Me.cbxNombreProveedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNumeroComprobante)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 136)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 164)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PROVEEDOR"
        '
        'id_Prov
        '
        Me.id_Prov.AutoSize = True
        Me.id_Prov.Location = New System.Drawing.Point(140, 17)
        Me.id_Prov.Name = "id_Prov"
        Me.id_Prov.Size = New System.Drawing.Size(45, 13)
        Me.id_Prov.TabIndex = 25
        Me.id_Prov.Text = "Label9"
        '
        'dateFechaCompra
        '
        Me.dateFechaCompra.Location = New System.Drawing.Point(140, 124)
        Me.dateFechaCompra.Name = "dateFechaCompra"
        Me.dateFechaCompra.Size = New System.Drawing.Size(274, 20)
        Me.dateFechaCompra.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(21, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Fecha"
        '
        'comboComprobante
        '
        Me.comboComprobante.FormattingEnabled = True
        Me.comboComprobante.Location = New System.Drawing.Point(140, 69)
        Me.comboComprobante.Name = "comboComprobante"
        Me.comboComprobante.Size = New System.Drawing.Size(274, 21)
        Me.comboComprobante.TabIndex = 17
        '
        'cbxNombreProveedor
        '
        Me.cbxNombreProveedor.FormattingEnabled = True
        Me.cbxNombreProveedor.Location = New System.Drawing.Point(140, 42)
        Me.cbxNombreProveedor.Name = "cbxNombreProveedor"
        Me.cbxNombreProveedor.Size = New System.Drawing.Size(274, 21)
        Me.cbxNombreProveedor.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(22, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "N°"
        '
        'txtNumeroComprobante
        '
        Me.txtNumeroComprobante.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNumeroComprobante.Location = New System.Drawing.Point(140, 97)
        Me.txtNumeroComprobante.Name = "txtNumeroComprobante"
        Me.txtNumeroComprobante.Size = New System.Drawing.Size(274, 20)
        Me.txtNumeroComprobante.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(22, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Comprobante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(21, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "idproveedor"
        Me.Label2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxCategoria)
        Me.GroupBox2.Controls.Add(Me.checkFiltro)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 59)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR PRODUCTO"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(120, 21)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(274, 21)
        Me.cbxCategoria.TabIndex = 16
        '
        'checkFiltro
        '
        Me.checkFiltro.AutoSize = True
        Me.checkFiltro.Location = New System.Drawing.Point(37, 21)
        Me.checkFiltro.Name = "checkFiltro"
        Me.checkFiltro.Size = New System.Drawing.Size(58, 17)
        Me.checkFiltro.TabIndex = 16
        Me.checkFiltro.Text = "Filtrar"
        Me.checkFiltro.UseVisualStyleBackColor = True
        '
        'Labellinea
        '
        Me.Labellinea.AutoSize = True
        Me.Labellinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labellinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Labellinea.Location = New System.Drawing.Point(-2, 48)
        Me.Labellinea.Name = "Labellinea"
        Me.Labellinea.Size = New System.Drawing.Size(1700, 16)
        Me.Labellinea.TabIndex = 23
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(21, 18)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(37, 30)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 22
        Me.IconPictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(66, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "COMPRAS"
        '
        'View_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1213, 591)
        Me.Controls.Add(Me.Labellinea)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Compra"
        Me.Text = "COMPRA"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.importeDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents checkFiltro As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dateFechaCompra As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents comboComprobante As ComboBox
    Friend WithEvents cbxNombreProveedor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroComprobante As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_Igv As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckPorcentaje As CheckBox
    Friend WithEvents CheckIgv As CheckBox
    Friend WithEvents LabelImporteTotal As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelPorcentaje As Label
    Friend WithEvents id_Prov As Label
    Friend WithEvents Btn_comprar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_2_por As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lbl_nombre1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnCancelarDetalle As Button
    Friend WithEvents btnAceptarDetalle As Button
    Friend WithEvents importeDetalle As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents listCompras As ListView
    Friend WithEvents Check2 As CheckBox
    Friend WithEvents Labellinea As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label7 As Label
End Class

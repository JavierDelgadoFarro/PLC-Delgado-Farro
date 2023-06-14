<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mantenimiento_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_Cliente))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Labellinea = New System.Windows.Forms.Label()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbuscarcliente = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.lblidcliente = New System.Windows.Forms.Label()
        Me.btnmodificarcliente = New System.Windows.Forms.Button()
        Me.txtapellidocliente = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnnuevocliente = New System.Windows.Forms.Button()
        Me.txttelefonocliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btneliminarcliente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Labellinea)
        Me.Panel1.Controls.Add(Me.btnbuscarcliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtbuscarcliente)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.lblidcliente)
        Me.Panel1.Controls.Add(Me.btnmodificarcliente)
        Me.Panel1.Controls.Add(Me.txtapellidocliente)
        Me.Panel1.Controls.Add(Me.txtnombrecliente)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnnuevocliente)
        Me.Panel1.Controls.Add(Me.txttelefonocliente)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btneliminarcliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1117, 671)
        Me.Panel1.TabIndex = 0
        '
        'Labellinea
        '
        Me.Labellinea.AutoSize = True
        Me.Labellinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Labellinea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Labellinea.Location = New System.Drawing.Point(-24, 62)
        Me.Labellinea.Name = "Labellinea"
        Me.Labellinea.Size = New System.Drawing.Size(1700, 16)
        Me.Labellinea.TabIndex = 25
        Me.Labellinea.Text = resources.GetString("Labellinea.Text")
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnbuscarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnbuscarcliente.ForeColor = System.Drawing.Color.White
        Me.btnbuscarcliente.Location = New System.Drawing.Point(1002, 23)
        Me.btnbuscarcliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(72, 27)
        Me.btnbuscarcliente.TabIndex = 24
        Me.btnbuscarcliente.Text = "Buscar"
        Me.btnbuscarcliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(78, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MANTENIMIENTO DE CLIENTES"
        '
        'txtbuscarcliente
        '
        Me.txtbuscarcliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtbuscarcliente.Location = New System.Drawing.Point(717, 27)
        Me.txtbuscarcliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtbuscarcliente.Name = "txtbuscarcliente"
        Me.txtbuscarcliente.Size = New System.Drawing.Size(270, 23)
        Me.txtbuscarcliente.TabIndex = 1
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Person
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 35
        Me.IconPictureBox1.Location = New System.Drawing.Point(32, 23)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'lblidcliente
        '
        Me.lblidcliente.AutoSize = True
        Me.lblidcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblidcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.lblidcliente.Location = New System.Drawing.Point(105, 103)
        Me.lblidcliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblidcliente.Name = "lblidcliente"
        Me.lblidcliente.Size = New System.Drawing.Size(24, 17)
        Me.lblidcliente.TabIndex = 23
        Me.lblidcliente.Text = "00"
        '
        'btnmodificarcliente
        '
        Me.btnmodificarcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnmodificarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmodificarcliente.ForeColor = System.Drawing.Color.White
        Me.btnmodificarcliente.Location = New System.Drawing.Point(528, 149)
        Me.btnmodificarcliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnmodificarcliente.Name = "btnmodificarcliente"
        Me.btnmodificarcliente.Size = New System.Drawing.Size(115, 40)
        Me.btnmodificarcliente.TabIndex = 22
        Me.btnmodificarcliente.Text = "Modificar"
        Me.btnmodificarcliente.UseVisualStyleBackColor = False
        '
        'txtapellidocliente
        '
        Me.txtapellidocliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtapellidocliente.Location = New System.Drawing.Point(572, 104)
        Me.txtapellidocliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtapellidocliente.Name = "txtapellidocliente"
        Me.txtapellidocliente.Size = New System.Drawing.Size(178, 23)
        Me.txtapellidocliente.TabIndex = 19
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtnombrecliente.Location = New System.Drawing.Point(258, 101)
        Me.txtnombrecliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(177, 23)
        Me.txtnombrecliente.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(803, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Teléfono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(479, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(165, 104)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(56, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ID"
        '
        'btnnuevocliente
        '
        Me.btnnuevocliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnnuevocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnuevocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnnuevocliente.ForeColor = System.Drawing.Color.White
        Me.btnnuevocliente.Location = New System.Drawing.Point(359, 149)
        Me.btnnuevocliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnnuevocliente.Name = "btnnuevocliente"
        Me.btnnuevocliente.Size = New System.Drawing.Size(115, 40)
        Me.btnnuevocliente.TabIndex = 21
        Me.btnnuevocliente.Text = "Nuevo"
        Me.btnnuevocliente.UseVisualStyleBackColor = False
        '
        'txttelefonocliente
        '
        Me.txttelefonocliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txttelefonocliente.Location = New System.Drawing.Point(896, 103)
        Me.txttelefonocliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txttelefonocliente.Name = "txttelefonocliente"
        Me.txttelefonocliente.Size = New System.Drawing.Size(178, 23)
        Me.txttelefonocliente.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(189, 209)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(740, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTA DE CLIENTES"
        '
        'DGVCliente
        '
        Me.DGVCliente.AllowUserToAddRows = False
        Me.DGVCliente.AllowUserToDeleteRows = False
        Me.DGVCliente.BackgroundColor = System.Drawing.Color.White
        Me.DGVCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCliente.Location = New System.Drawing.Point(21, 30)
        Me.DGVCliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.ReadOnly = True
        Me.DGVCliente.RowHeadersVisible = False
        Me.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCliente.Size = New System.Drawing.Size(699, 383)
        Me.DGVCliente.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idcliente"
        Me.Column1.HeaderText = "idcliente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 160
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nombre"
        Me.Column2.HeaderText = "nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "apellidos"
        Me.Column3.HeaderText = "apellidos"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "telefono"
        Me.Column4.HeaderText = "telefono"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 170
        '
        'btneliminarcliente
        '
        Me.btneliminarcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btneliminarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btneliminarcliente.ForeColor = System.Drawing.Color.White
        Me.btneliminarcliente.Location = New System.Drawing.Point(704, 149)
        Me.btneliminarcliente.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btneliminarcliente.Name = "btneliminarcliente"
        Me.btneliminarcliente.Size = New System.Drawing.Size(115, 40)
        Me.btneliminarcliente.TabIndex = 9
        Me.btneliminarcliente.Text = "Eliminar"
        Me.btneliminarcliente.UseVisualStyleBackColor = False
        '
        'Mantenimiento_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1117, 671)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Mantenimiento_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento_Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btneliminarcliente As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblidcliente As Label
    Friend WithEvents btnmodificarcliente As Button
    Friend WithEvents txtapellidocliente As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents btnnuevocliente As Button
    Friend WithEvents txttelefonocliente As TextBox
    Friend WithEvents btnbuscarcliente As Button
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents txtbuscarcliente As TextBox
    Friend WithEvents Labellinea As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

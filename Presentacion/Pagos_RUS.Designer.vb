<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos_RUS
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
        Me.GroupBox_Pagos_Rus = New System.Windows.Forms.GroupBox()
        Me.txt_Ingresos_Mes = New System.Windows.Forms.TextBox()
        Me.txt_Categoria = New System.Windows.Forms.TextBox()
        Me.txt_monto_compensar = New System.Windows.Forms.TextBox()
        Me.txt_importe_pagar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Calcular = New System.Windows.Forms.Button()
        Me.GroupBox_Pagos_Rus.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Pagos_Rus
        '
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Btn_Calcular)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Label5)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Label4)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Label3)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.fecha_pago)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Label2)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.Label1)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.txt_importe_pagar)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.txt_monto_compensar)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.txt_Categoria)
        Me.GroupBox_Pagos_Rus.Controls.Add(Me.txt_Ingresos_Mes)
        Me.GroupBox_Pagos_Rus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox_Pagos_Rus.ForeColor = System.Drawing.Color.White
        Me.GroupBox_Pagos_Rus.Location = New System.Drawing.Point(22, 16)
        Me.GroupBox_Pagos_Rus.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox_Pagos_Rus.Name = "GroupBox_Pagos_Rus"
        Me.GroupBox_Pagos_Rus.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox_Pagos_Rus.Size = New System.Drawing.Size(527, 332)
        Me.GroupBox_Pagos_Rus.TabIndex = 2
        Me.GroupBox_Pagos_Rus.TabStop = False
        Me.GroupBox_Pagos_Rus.Text = "Pagos"
        '
        'txt_Ingresos_Mes
        '
        Me.txt_Ingresos_Mes.Location = New System.Drawing.Point(255, 100)
        Me.txt_Ingresos_Mes.Name = "txt_Ingresos_Mes"
        Me.txt_Ingresos_Mes.Size = New System.Drawing.Size(242, 27)
        Me.txt_Ingresos_Mes.TabIndex = 0
        '
        'txt_Categoria
        '
        Me.txt_Categoria.Location = New System.Drawing.Point(255, 155)
        Me.txt_Categoria.Name = "txt_Categoria"
        Me.txt_Categoria.Size = New System.Drawing.Size(242, 27)
        Me.txt_Categoria.TabIndex = 1
        '
        'txt_monto_compensar
        '
        Me.txt_monto_compensar.Location = New System.Drawing.Point(255, 207)
        Me.txt_monto_compensar.Name = "txt_monto_compensar"
        Me.txt_monto_compensar.Size = New System.Drawing.Size(242, 27)
        Me.txt_monto_compensar.TabIndex = 2
        '
        'txt_importe_pagar
        '
        Me.txt_importe_pagar.Location = New System.Drawing.Point(255, 264)
        Me.txt_importe_pagar.Name = "txt_importe_pagar"
        Me.txt_importe_pagar.Size = New System.Drawing.Size(242, 27)
        Me.txt_importe_pagar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingresos brutos del Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha"
        '
        'fecha_pago
        '
        Me.fecha_pago.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fecha_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fecha_pago.Location = New System.Drawing.Point(108, 51)
        Me.fecha_pago.Name = "fecha_pago"
        Me.fecha_pago.Size = New System.Drawing.Size(231, 22)
        Me.fecha_pago.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Monto a compensar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Importe a pagar"
        '
        'Btn_Calcular
        '
        Me.Btn_Calcular.BackColor = System.Drawing.Color.Blue
        Me.Btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Calcular.ForeColor = System.Drawing.Color.White
        Me.Btn_Calcular.Location = New System.Drawing.Point(370, 47)
        Me.Btn_Calcular.Name = "Btn_Calcular"
        Me.Btn_Calcular.Size = New System.Drawing.Size(117, 32)
        Me.Btn_Calcular.TabIndex = 9
        Me.Btn_Calcular.Text = "Calcular"
        Me.Btn_Calcular.UseVisualStyleBackColor = False
        '
        'Pagos_RUS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(602, 391)
        Me.Controls.Add(Me.GroupBox_Pagos_Rus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pagos_RUS"
        Me.Text = "Pagos_RUS"
        Me.GroupBox_Pagos_Rus.ResumeLayout(False)
        Me.GroupBox_Pagos_Rus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Pagos_Rus As GroupBox
    Friend WithEvents txt_Ingresos_Mes As TextBox
    Friend WithEvents txt_importe_pagar As TextBox
    Friend WithEvents txt_monto_compensar As TextBox
    Friend WithEvents txt_Categoria As TextBox
    Friend WithEvents fecha_pago As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Calcular As Button
End Class

Imports Entidades
Imports Negocio
Imports System.IO

Public Class View_Pagos
    Private Sub Pagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombo(Cb_nombre_cliente)
        DataGridView1.AutoGenerateColumns = False
    End Sub

    Private Sub cargarcombo(ByVal combo As ComboBox)
        Dim lista As New List(Of E_Cliente)
        Dim obj As New Cliente_Negocio
        lista = obj.Mostrartodocliente
        combo.DataSource = lista
        combo.DisplayMember = "nombre"
        combo.ValueMember = "idcliente"
        combo.SelectedIndex = -1

    End Sub

    'Para Cargar el Gridview'
    Public Sub cargargridview(ByVal id As Integer)
        Dim lista As New List(Of E_Venta_Detalle)
        Dim obj As New Venta_Detalle_Negocio
        lista = obj.listardeuda(id)
        DataGridView1.DataSource = lista
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_nombre_cliente.SelectedIndexChanged

        If Cb_nombre_cliente.SelectedIndex >= 0 Then
            Label2.Text = Cb_nombre_cliente.SelectedValue.ToString

            If IsNumeric(Cb_nombre_cliente.SelectedValue.ToString) Then
                cargargridview(CInt(Cb_nombre_cliente.SelectedValue.ToString))
                lbl_monto_total.Text = CStr(sumarimporte(DataGridView1))
                NumericUpDown1.Maximum = CDbl(lbl_monto_total.Text)
            End If

        Else
            Label2.Text = ""
        End If

    End Sub


    Private Function sumarimporte(ByVal grid As DataGridView)
        Dim importe As Double
        For i = 0 To grid.RowCount - 1
            importe = importe + CDbl(grid(2, i).Value.ToString())
        Next
        Return importe
    End Function


    Private Sub Btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pagar.Click
        Dim importetotal As Double
        Dim importe As Double = 0
        Dim cancelado As Integer = 0
        Dim i As Integer = 0

        importetotal = CDbl(NumericUpDown1.Value)
        If importetotal <= 0 Then
            MessageBox.Show("Debe de ingresar un valor mayor a 0")
            Exit Sub
        End If

        Dim Entidad_detalle As New E_Venta_Detalle
        Dim Negocio_detalle As New Venta_Detalle_Negocio

        Dim Entidad_Pago As New E_Pagos
        Dim Negocio_Pago As New Pagos_Negocio

        With Entidad_Pago
            .idcliente = Label2.Text
            .monto = importetotal
            .fecha = Me.fecha_formatoansi
        End With

        Negocio_Pago.Nuevo_Pago(Entidad_Pago)

        While importetotal > 0
            importe = CDbl(Me.DataGridView1(2, i).Value)
            importetotal = importetotal - importe
            If importetotal >= 0 Then
                cancelado = 1
            Else
                importe = importetotal + importe
                cancelado = 0
            End If

            With Entidad_detalle
                .Id_Venta = Me.DataGridView1(0, i).Value
                .idproducto = Me.DataGridView1(1, i).Value
                .montopagado = importe
                .cancelado = cancelado
            End With
            'Actualizamos la lista de los deudores'
            Negocio_detalle.Actualiza_deudas(Entidad_detalle)
            i += 1
        End While



        MessageBox.Show("Pago registrado correctamente")
        Cb_nombre_cliente.SelectedIndex = -1
        limpiar()
    End Sub

    Private Sub limpiar()
        NumericUpDown1.Value = 0.0
        lbl_monto_total.Text = ""
        Label2.Text = ""
        cargargridview(-1)
    End Sub

    Private Function fecha_formatoansi() As String
        Dim cadena As String = ""
        cadena = Now.Year
        If (Now.Month) < 10 Then
            cadena = cadena + "0" + CStr(Now.Month)
        Else
            cadena = cadena + CStr(Now.Month)
        End If

        If Now.Day < 10 Then
            cadena = cadena + "0" + CStr(Now.Day)
        Else
            cadena = cadena + CStr(Now.Day)
        End If
        Return cadena

    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        View_Buscar_Cliente.Show()
        View_Buscar_Cliente.Text = "Pagos"
    End Sub
End Class
Imports System.Windows.Documents
Imports Entidades
Imports Negocio
Imports Presentacion
Public Class View_Editar_Perfil
    Dim lista3 As New List(Of E_Empleado)
    Dim obj2 As New Empleado_Negocio
    Private Sub View_Editar_Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editar_Data_Perfil()
        txt_Vigente_pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Editar_Data_Perfil()
        lista3 = obj2.empleado(view_Principal.lbl_id.Text)

        view_Principal.lbl_usuario.Text = lista3.Item(0).usuario
        view_Principal.lbl_apellidos.Text = lista3.Item(0).apellidos
        view_Principal.lbl_Nombre.Text = lista3.Item(0).nombres

        lbl_usuario.Text = ""
        lbl_nombre.Text = ""
        lbl_apellido.Text = ""
        lbl_id.Text = ""


        'Vista'
        lbl_usuario.Text = lista3.Item(0).usuario
        lbl_nombre.Text = lista3.Item(0).nombres
        lbl_apellido.Text = lista3.Item(0).apellidos
        lbl_id.Text = lista3.Item(0).idempleado
        'Edición'

        txt_usuario.Text = lista3.Item(0).usuario
        txt_nombre.Text = lista3.Item(0).nombres
        txt_apellido.Text = lista3.Item(0).apellidos
        txt_Vigente_pass.Text = ""
        lbl_contraseña.Text = lista3.Item(0).contraseña
    End Sub

    Private Sub reiniciar()
        Editar_Data_Perfil()
    End Sub


    Private Sub Btn_Editar_Perfil_Click(sender As Object, e As EventArgs) Handles Btn_Editar_Perfil.Click
        Panel_Editar_Perfil.Visible = True
        Editar_Data_Perfil()
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Panel_Editar_Perfil.Visible = False
        reiniciar()
    End Sub

    Private Sub Panel_Perfil_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Perfil.Paint

    End Sub

    Private Sub Btn_actualizar_Click(sender As Object, e As EventArgs) Handles Btn_actualizar.Click
        modificar()
        View_Editar_Perfil_Load(sender, e)
    End Sub

    Private Sub modificar()
        'modificar producto
        Dim Entidad As New E_Empleado
        Dim Negocio As New Empleado_Negocio

        With Entidad
            .contraseña = lbl_contraseña.Text
            If txt_Vigente_pass.Text = .contraseña Then
                .idempleado = lbl_id.Text
                .nombres = txt_nombre.Text
                .apellidos = txt_apellido.Text
                .contraseña = txt_Vigente_pass.Text
                .id_rol = Nothing
                .usuario = txt_usuario.Text
                reiniciar()
                Panel_Editar_Perfil.Visible = False
            Else
                MessageBox.Show("Ingrese Contraseña vigente para guardar cambios")
            End If
        End With
        Negocio.modificar_perfil(Entidad)
    End Sub
End Class
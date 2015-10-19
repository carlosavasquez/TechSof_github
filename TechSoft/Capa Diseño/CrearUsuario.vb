Public Class CrearUsuario 
    Dim objlogin As New Clase_Login
    Dim convert As Integer
    Private Sub Coversion()
        If txt_rol.Text = "Administrador" Then
            convert = 1
        ElseIf txt_rol.Text = "Operador" Then
            convert = 2
        ElseIf txt_rol.Text = "Tecnico" Then
            convert = 3
        Else
        End If
    End Sub
    Private Sub txt_nueva_EditValueChanged(sender As Object, e As EventArgs) Handles txt_nueva.EditValueChanged
        If DirectCast(sender, DevExpress.XtraEditors.TextEdit).Text.Length > 0 Then
            erroricono.SetError(sender, "")
        Else
            erroricono.SetError(sender, "El Campo Clave Nueva es obligatorio")
        End If
    End Sub
    Private Sub txt_renueva_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_renueva.Validating
        If DirectCast(sender, DevExpress.XtraEditors.TextEdit).Text.Length > 0 Then
            erroricono.SetError(sender, "")
        Else
            erroricono.SetError(sender, "El Campo Repetir Clave Nueva es obligatorio")
        End If
        If txt_nueva.Text = txt_renueva.Text Then
            PictureBox1.Visible = True
            btn_guardar.Enabled = True
        Else
            PictureBox1.Visible = False
            btn_guardar.Enabled = True
        End If
    End Sub
    Private Sub txt_nombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        If DirectCast(sender, DevExpress.XtraEditors.TextEdit).Text.Length > 0 Then
            erroricono.SetError(sender, "")
        Else
            erroricono.SetError(sender, "El Campo Nombre Completo es obligatorio")
        End If
    End Sub
    Private Sub txt_nick_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nick.Validating
        If DirectCast(sender, DevExpress.XtraEditors.TextEdit).Text.Length > 0 Then
            erroricono.SetError(sender, "")
        Else
            erroricono.SetError(sender, "El Campo Nick Usuario es obligatorio")
        End If
    End Sub
    Private Sub txt_rol_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_rol.Validating
        If DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).Text.Length > 0 Then
            erroricono.SetError(sender, "")
        Else
            erroricono.SetError(sender, "El Campo Rol Usuario es obligatorio")
        End If
    End Sub
    Private Sub btn_guardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_guardar.ItemClick
        Coversion()
        If txt_nombre.Text.Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Campo Nombre Completo esta vacio", "Notificación Campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txt_nick.Text.Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Campo Nick Usuario esta vacio", "Notificación Campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txt_nueva.Text.Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Campo Clave esta vacio", "Notificación Campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txt_renueva.Text.Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Campo Repetir Clave esta vacio", "Notificación Campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txt_rol.Text.Length = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Campo Rol Usuario esta vacio", "Notificación Campo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            objlogin.CrearUsuario(txt_nombre.Text, txt_nick.Text, convert, txt_nueva.Text, 1)
        End If
    End Sub
End Class
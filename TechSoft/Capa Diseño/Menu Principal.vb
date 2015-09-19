Public Class Menu_Principal
    Dim objusuario As New Clase_Usuario
    Private Sub btn_nuevocaso_Click(sender As Object, e As EventArgs) Handles btn_nuevocaso.Click
        Dim ver As New Crear_Caso
        ver.Show()
    End Sub
    Private Sub CambiarClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarClaveToolStripMenuItem.Click
        Dim ver As New frmMSGctrl
        ver.Show()
    End Sub
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(n_usuario, MsgBoxStyle.Information, "Información")
        status_nombre.Text = objusuario._nombre_usuario
    End Sub
End Class
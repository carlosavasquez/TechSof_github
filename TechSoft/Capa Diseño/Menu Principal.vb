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
        status_nombre.Text = nombre_usuario
        If rol_usuario = 1 Then
            status2.Text = "ADMINISTRADOR"
        ElseIf rol_usuario = 2 Then
            status2.Text = "OPERADOR"
        ElseIf rol_usuario = 3 Then
            status2.Text = "REPORTERO"
        Else
            status2.Text = "SIN ROL"
        End If
    End Sub
    Private Sub NuevoDiagnosticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoDiagnosticoToolStripMenuItem.Click
        Dim ver As New Crear_Diagnostico
        ver.Show()
    End Sub
    Private Sub NuevaCotizacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaCotizacionToolStripMenuItem.Click
        Dim ver As New Cotizacion_Nueva
        ver.Show()
    End Sub
End Class
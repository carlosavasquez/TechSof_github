Public Class Menu_Principal

    Private Sub btn_nuevocaso_Click(sender As Object, e As EventArgs) Handles btn_nuevocaso.Click
        Dim ver As New Crear_Caso
        ver.Show()
    End Sub
    Private Sub NuevoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CambiarClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarClaveToolStripMenuItem.Click
        Dim ver As New frmMSGctrl
        ver.Show()
    End Sub
End Class
Public Class Menu_Principal

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_nuevocaso_Click(sender As Object, e As EventArgs) Handles btn_nuevocaso.Click
        Dim ver As New frmMSGctrl
        ver.Show()
    End Sub

    Private Sub CambiarClaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarClaveToolStripMenuItem.Click
        'Call Menudesp.activar("mensaje", 2, 3, True, "link", "error")
    End Sub
End Class
Public Class Menu_Principal

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_nuevocaso_Click(sender As Object, e As EventArgs) Handles btn_nuevocaso.Click
        Dim ver As New Crear_Caso
        ver.MdiParent = Me
        ver.Show()

    End Sub
End Class
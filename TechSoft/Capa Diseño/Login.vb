Public Class Login
    Dim objcon As New Clase_Conexion

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcon.conectar()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

    End Sub
End Class
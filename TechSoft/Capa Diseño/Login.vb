Public Class Login
    Dim objcon As New Clase_Conexion

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcon.conectar()

    End Sub
End Class
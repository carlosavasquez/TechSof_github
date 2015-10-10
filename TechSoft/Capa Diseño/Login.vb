Public Class Login
    Dim objcon As New Clase_Conexion
    Dim objlogin As New Clase_Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcon.conectarse()
    End Sub

    Private Sub btn_entrar_Click_1(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If objlogin.Valores(txt_usuario.Text, txt_clave.Text) = True Then
            Dim ver As New Menu_Alterno
            ver.Show()
            Me.Close()
        Else
            MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical, "TECHSOFT")
        End If
    End Sub
End Class
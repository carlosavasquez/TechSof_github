Module Variables_Globales
    Public id_usuario, id_tip, id_mar, cont_ini, cont As Integer
    Public rol_usuario, nombre_usuario, nom_rol, fecha_actual, id_case As String
    Public marc, tip, prob, obse, nom_cli, clave_usu As String
    Public diag, piez As String
    Public Sub SoloTexto(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub SoloNumeros(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Module

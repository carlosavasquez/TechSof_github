Public Class Clase_Login
    Inherits Clase_Usuario
    Public Function Valores(ByVal usuario As String, ByVal pass As String)
        Dim dt As New DataTable
        Dim ds As New DataSet
        _estado_usuario = "1"
        ds.Tables.Add(dt)
        Dim da As New Odbc.OdbcDataAdapter("select nick_usuario,clave_usuario,estado_usuario,nombre_usuario,rol_usuario,id_usuario from usuarios", conn)
        da.Fill(dt)
        For Each datarow In dt.Rows
            If usuario = datarow.item(0) And pass = datarow(1) And _estado_usuario = datarow(2) Then
                nombre_usuario = datarow(3).ToString.ToUpper
                rol_usuario = datarow(4).ToString.ToUpper
                id_usuario = Val(datarow(5))
                clave_usu = datarow(1)
                'MsgBox(_nombre_usuario.ToUpper)
                conn.Close()
                Return True
            End If
        Next
        conn.Close()
        Return False
    End Function
    Sub EditarClave(ByVal id As String, ByVal clave As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "UPDATE usuarios SET clave_usuario='" & clave & "' WHERE id_usuario='" & id & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al cambiar contraseña usuario" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Public Function CrearUsuario(ByVal nombre As String, ByVal nick As String, ByVal rol As Integer, ByVal clav As String, ByVal esta As Integer)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO usuarios(Nombre_usuario,nick_usuario,rol_usuario,clave_usuario,estado_usuario) VALUES ('" & nombre & "','" & nick & "','" & rol & "','" & clav & "','" & esta & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            desconectarse()
            If resultado <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CREAR USUARIO" + ex.ToString)
            Return False
        End Try
    End Function

End Class

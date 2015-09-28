Public Class Diagnostico
    Inherits Clase_Diagnostico
    Function ObtenerUltimoDiagnostico() As Integer
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT id_diagnostico FROM diagnosticos ORDER BY id_diagnostico DESC LIMIT 1"
            _id_diagnostico = cmd.ExecuteScalar()
            conn.Close()
            Return _id_diagnostico
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return _id_diagnostico = Nothing
        End Try
    End Function
    Function Crear_Diagnostico(id_usu As Integer, nota As String, pieza As String, tiempo As String, fecha As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO diagnosticos(usuario_id_usuario,nota_diagnostico,piezas_diagnostico,tiempo_diagnostico,fecha_diagnostico) VALUES ('" & id_usu & "','" & nota & "','" & pieza & "','" & tiempo & "','" & fecha & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            desconectarse()
            If resultado <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CREAR DIAGNOSTICO" + ex.ToString)
            Return False
        End Try
    End Function
End Class

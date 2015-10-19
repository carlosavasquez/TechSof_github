Public Class Equipos
    Inherits Clase_Equipos
    Dim objtipo As New Tipo_Equipos
    Function CrearEquipo(idtipo As Integer, ByVal idmarca As Integer, ByVal ref As String, ByVal idclie As Integer, ByVal proble As String, ByVal obser As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO equipos(tipo_id_tipo_equipo,marca_id_marca_equipo,referencia_equipo,cliente_id_cliente,problema_equipo,observacion_equipo)"
            cmd.CommandText += " VALUES ('" & idtipo & "','" & idmarca & "','" & ref & "','" & idclie & "','" & proble & "','" & obser & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            desconectarse()
            If resultado <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            desconectarse()
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    Function ObtenerUltimoEquipo() As Integer
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT id_equipo FROM equipos ORDER BY id_equipo DESC LIMIT 1"
            _id_equipo = cmd.ExecuteScalar()
            conn.Close()
            Return _id_equipo
        Catch ex As Exception
            desconectarse()
            MsgBox(ex.ToString)
            Return _id_equipo = Nothing
        End Try
    End Function
    Sub ObtenerDatosConId()
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT tipo_id_tipo_equipo,marca_id_marca_equipo,referencia_equipo,problema_equipo,observacion_equipo FROM equipos WHERE id_equipo = '" & _id_equipo & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    id_tip = lector(0)
                    id_mar = lector(1)
                    _referencia = lector(2)
                    _problema = lector(3)
                    _observacion = lector(4)
                End While
            Else
                'MsgBox("ha Ocurrido un error al elegir el proveedor. Profavor Vueva a Seleccionarlo", MsgBoxStyle.Information, "Inventario")
                lector.Close()
                desconectarse()
            End If
            lector.Close()
            desconectarse()
        Catch ex As Exception
            lector.Close()
            desconectarse()
            MsgBox("Ha acurrido un error al tarer los datos del Equipo" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
End Class

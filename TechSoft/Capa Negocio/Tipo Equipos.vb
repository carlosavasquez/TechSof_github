Public Class Tipo_Equipos
    Inherits Clase_Tipo_Equipo

    Function ObtenerTiposEquipos() As ArrayList
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT nombre_tipo FROM tipos ORDER BY nombre_tipo ASC"
        lector = cmd.ExecuteReader()
        Dim lista As New ArrayList
        While lector.Read
            lista.Add(lector(0))
        End While
        conn.Close()
        Return lista
    End Function
    Function ObtenerMarcas() As ArrayList
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        cmd.CommandText = "SELECT nombre_marca FROM marcas ORDER BY nombre_marca ASC"
        lector = cmd.ExecuteReader()
        Dim lista As New ArrayList
        While lector.Read
            lista.Add(lector(0))
        End While
        conn.Close()
        Return lista
    End Function
    Function ObtenerIdTipo(nom As String) As Integer
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT id_tipo FROM tipos WHERE nombre_tipo='" & nom & "'"
            _id_tipo_equipo = cmd.ExecuteScalar()
            conn.Close()
            Return _id_tipo_equipo
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectarse()
            Return _id_tipo_equipo = Nothing
        End Try
    End Function
    Function ObtenerIdMarca(nom As String) As Integer
        conn.Open()
        Dim idmarca As Integer
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT id_marca FROM marcas WHERE nombre_marca='" & nom & "'"
            idmarca = cmd.ExecuteScalar()
            conn.Close()
            Return idmarca
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectarse()
            Return idmarca = Nothing
        End Try
    End Function
    Sub ObtenerDatosTipoConId()
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT nombre_tipo FROM tipos WHERE id_tipo = '" & id_tip & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    _nombre_tipo_equipo = lector(0)
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
            MsgBox("Ha acurrido un error al tarer los datos del Tipo" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub ObtenerDatosMarcaConId()
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT nombre_marca FROM marcas WHERE id_marca = '" & id_mar & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    _nombre_marca = lector(0)
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
            MsgBox("Ha acurrido un error al tarer los datos de la Marca" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
End Class

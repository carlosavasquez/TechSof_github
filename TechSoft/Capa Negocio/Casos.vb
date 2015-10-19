Public Class Casos
    Inherits Clase_Casos
    Dim objclien As New Clientes
    Function crear_caso(ByVal num_caso As String, ByVal clien_id As Integer, ByVal equi_id As Integer, ByVal usu_id As String, ByVal fecha_entrada As String, ByVal estado_caso As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Ingresado"
        Try
            cmd.CommandText = "INSERT INTO casos(numero_caso,cliente_id_cliente,equipo_id_equipo,usuario_id_usuario,fecha_entrada_caso,estado_caso) VALUES ('" & num_caso & "','" & clien_id & "','" & equi_id & "','" & usu_id & "','" & fecha_entrada & "','" & _estado_caso & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
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
    Function Casos_Diagnostico() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca WHERE casos.estado_caso=1", conn)
            da.Fill(Datos)
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Function Casos_Cotizacion() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca WHERE casos.estado_caso=2", conn)
            da.Fill(Datos)
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Function ObtenerNumCaso() As Integer
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = 1
        Try
            cmd.CommandText = "SELECT numero_caso FROM casos ORDER BY numero_caso DESC LIMIT 1"
            _numero_caso = cmd.ExecuteScalar()
            conn.Close()
            _numero_caso += 1
            Return _numero_caso
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return _numero_caso = Nothing
        End Try
    End Function
    Sub AgregarEntrega(id_entrega As Integer, id_caso As Integer, f_entrega As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Entregado"
        Try
            cmd.CommandText = "UPDATE casos SET id_entrega='" & id_entrega & "',estado_caso='" & _estado_caso & "',fecha_salida_caso='" & f_entrega & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar Entrega al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub AgregarArreglo(id_arreglo As Integer, id_caso As Integer)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Reparado"
        Try
            cmd.CommandText = "UPDATE casos SET id_arreglo='" & id_arreglo & "',estado_caso='" & _estado_caso & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar arreglo al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub AgregarRevision(id_revision As Integer, id_caso As Integer)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Revisado"
        Try
            cmd.CommandText = "UPDATE casos SET id_revision='" & id_revision & "',estado_caso='" & _estado_caso & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar revision al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub AgregarRespuesta(id_respuesta As Integer, id_caso As Integer, respuesta As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "UPDATE casos SET id_respuesta='" & id_respuesta & "',estado_caso='" & respuesta & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar respuesta al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub AgregarDiagnostico(id_diagno As Integer, id_caso As Integer)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Diagnosticado"
        Try
            cmd.CommandText = "UPDATE casos SET diagnostico_id_diagnostico='" & id_diagno & "',estado_caso='" & _estado_caso & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar diagnostico al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub AgregarCotizacion(id_coti As Integer, id_caso As Integer)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = "Cotizado"
        Try
            cmd.CommandText = "UPDATE casos SET cotizacion_id_cotizacion='" & id_coti & "',estado_caso='" & _estado_caso & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar cotizacion al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Function ListadoCasosAdmin() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca,casos.estado_caso FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca", conn)
            da.Fill(Datos)
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Sub ContadorAdmin()
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT COUNT(*) FROM casos"
            cont = cmd.ExecuteScalar()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectarse()
        End Try
    End Sub
    Function ListadoCasosTecnico() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca,casos.estado_caso FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca WHERE casos.estado_caso='Aceptado' OR casos.estado_caso='Ingresado'", conn)
            da.Fill(Datos)
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Sub ContadorTecnico()
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT COUNT(*) FROM casos WHERE casos.estado_caso='Ingresado' OR casos.estado_caso='Ingresaso'"
            cont = cmd.ExecuteScalar()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectarse()
        End Try
    End Sub
    Function ListadoCasosOperador() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca,casos.estado_caso FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca WHERE casos.estado_caso='Diagnosticado' OR 'Cotizado' OR casos.estado_caso='Rechazado' OR casos.estado_caso='Revisado' OR casos.estado_caso='Terminado'", conn)
            da.Fill(Datos)
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox(ex.Message)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Sub ContadorOperador()
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT COUNT(*) FROM casos WHERE casos.estado_caso='Diagnosticado' OR casos.estado_caso='Cotizado' OR casos.estado_caso='Rechazado' OR casos.estado_caso='Revisado' OR casos.estado_caso='Terminado'"
            cont = cmd.ExecuteScalar()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            desconectarse()
        End Try
    End Sub
    Sub ObtenerDatosIngresadoCasoConId(ByVal id As String)
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT casos.numero_caso,casos.fecha_entrada_caso,clientes.nombre_cliente,marcas.nombre_marca,tipos.nombre_tipo,equipos.problema_equipo,equipos.observacion_equipo FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca INNER JOIN tipos ON tipos.id_tipo=equipos.tipo_id_tipo_equipo WHERE casos.id_caso='" & id & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    _numero_caso = lector(0)
                    _f_entrada_caso = lector(1)
                    nom_cli = lector(2)
                    marc = lector(3)
                    tip = lector(4)
                    prob = lector(5)
                    obse = lector(6)
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
            MsgBox("Ha acurrido un error al traer los datos del caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Sub ObtenerDatosDiagnosticadoCasoConId(ByVal id As String)
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT casos.numero_caso,casos.fecha_entrada_caso,clientes.nombre_cliente,marcas.nombre_marca,tipos.nombre_tipo,equipos.problema_equipo,diagnosticos.nota_diagnostico,diagnosticos.piezas_diagnostico FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca INNER JOIN tipos ON tipos.id_tipo=equipos.tipo_id_tipo_equipo INNER JOIN diagnosticos ON casos.diagnostico_id_diagnostico=diagnosticos.id_diagnostico WHERE casos.id_caso='" & id & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    _numero_caso = lector(0)
                    _f_entrada_caso = lector(1)
                    nom_cli = lector(2)
                    marc = lector(3)
                    tip = lector(4)
                    prob = lector(5)
                    diag = lector(6)
                    piez = lector(7)
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
            MsgBox("Ha acurrido un error al traer los datos del caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
End Class

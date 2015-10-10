Public Class Casos
    Inherits Clase_Casos
    Function crear_caso(ByVal num_caso As String, ByVal clien_id As Integer, ByVal equi_id As Integer, ByVal usu_id As String, ByVal fecha_entrada As String, ByVal estado_caso As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = 1
        Try
            cmd.CommandText = "INSERT INTO casos(numero_caso,cliente_id_cliente,equipo_id_equipo,usuario_id_usuario,fecha_entrada_caso,estado_caso) VALUES ('" & num_caso & "','" & clien_id & "','" & equi_id & "','" & usu_id & "','" & fecha_entrada & "','" & estado_caso & "')"
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
        conn.Open()
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
    Sub AgregarDiagnostico(id_diagno As Integer, id_caso As Integer)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        _estado_caso = 2
        Try
            cmd.CommandText = "UPDATE casos SET diagnostico_id_diagnostico='" & id_diagno & "',estado_caso='" & _estado_caso & "' WHERE id_caso='" & id_caso & "'"
            Dim resultado As String = cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            desconectarse()
            MsgBox("Error al agregar diagnostico al caso" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
    Function ListadoCasos() As DataTable
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            Dim da As New Odbc.OdbcDataAdapter("SELECT casos.id_caso,casos.numero_caso,casos.cliente_id_cliente,casos.equipo_id_equipo,casos.fecha_entrada_caso,clientes.nombre_cliente,equipos.referencia_equipo,marcas.nombre_marca,casos.estado_caso FROM casos INNER JOIN clientes ON clientes.id_cliente=casos.cliente_id_cliente INNER JOIN equipos ON equipos.id_equipo=casos.equipo_id_equipo INNER JOIN marcas ON equipos.marca_id_marca_equipo=marcas.id_marca WHERE casos.estado_caso='Diagnosticado' OR 'Ingresaso'", conn)
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
End Class

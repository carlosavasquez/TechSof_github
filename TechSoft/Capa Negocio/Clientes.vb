Public Class Clientes
    Inherits Clase_Cliente
    Function MostrarClientes(texto As String) As DataTable   
        Dim Datos As New DataTable
        Dim ds As New DataSet
        Try
            ds.Tables.Add(Datos)
            If texto = String.Empty Then
                Dim da As New Odbc.OdbcDataAdapter("select * from clientes", conn)
                da.Fill(Datos)
            Else
                Dim da As New Odbc.OdbcDataAdapter("select * from clientes WHERE nombre_cliente LIKE '%" & texto & "%'", conn)
                da.Fill(Datos)
            End If
            desconectarse()
            Return Datos
        Catch ex As Exception
            MsgBox("ERROR TRAYENDO LOS DATOS" + ex.Message, MsgBoxStyle.Information)
            desconectarse()
            Return Datos
        End Try
        desconectarse()
    End Function
    Function CrearCliente(nombre As String, tel1 As String, tel2 As String, ciu As String)
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "INSERT INTO clientes(nombre_cliente,telefono_cliente,telefono_2,ciudad) VALUES ('" & nombre & "','" & tel1 & "','" & tel2 & "','" & ciu & "')"
            Dim resultado As String = cmd.ExecuteNonQuery()
            desconectarse()
            If resultado <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERROR AL CREAR CLIENTE" + ex.ToString)
            Return False
        End Try
    End Function
    Sub EditarCliente(id As Integer, nombre As String, tel1 As String, tel2 As String, ciu As String)
        conectarse()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "UPDATE clientes SET nombre_cliente='" & nombre & "',telefono_cliente='" & tel1 & "',telefono_2='" & tel2 & "',ciudad='" & ciu & "' WHERE id_cliente='" & id & "'"
            cmd.ExecuteNonQuery()
            desconectarse()
        Catch ex As Exception
            MsgBox("ERROR AL EDITAR CLIENTE" + ex.ToString)
        End Try
    End Sub
    Function ObtenerUltimoCliente() As Integer
        conn.Open()
        cmd.CommandType = CommandType.Text
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT id_cliente FROM clientes ORDER BY id_cliente DESC LIMIT 1"
            _idcliente = cmd.ExecuteScalar()
            conn.Close()
            Return _idcliente
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return _idcliente = Nothing
        End Try
    End Function
    Sub ObtenerDatosConId()
        conectarse()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "SELECT nombre_cliente,telefono_cliente,telefono_2,ciudad FROM clientes WHERE id_cliente = '" & _idcliente & "'"
            lector = cmd.ExecuteReader()
            If lector.HasRows Then
                While lector.Read
                    _nombre_cliente = lector(0)
                    _tel1 = lector(1)
                    _tel2 = lector(2)
                    _ciudad = lector(3)
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
            MsgBox("Ha acurrido un error al tarer los datos del cliente" + ex.ToString, MsgBoxStyle.Information, "TECHSOFT")
        End Try
    End Sub
End Class

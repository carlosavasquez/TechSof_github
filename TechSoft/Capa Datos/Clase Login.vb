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
                'MsgBox(_nombre_usuario.ToUpper)
                conn.Close()
                Return True
            End If
        Next
        conn.Close()
        Return False
    End Function

End Class

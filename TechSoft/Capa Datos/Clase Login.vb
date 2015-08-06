Public Class Clase_Login
    Inherits Clase_Conexion
    Dim id_usuario As Integer
    Dim usuario As String
    Dim clave As String
    Dim nombre_usuario As String
    Dim rol As Integer
    Dim estado_usuario As String
    Public Property _id_usuario As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            Me.id_usuario = value
        End Set
    End Property
    Public Property _usuario() As String
        Get
            Return usuario
        End Get
        Set(value As String)
            Me.usuario = value
        End Set
    End Property
    Public Property _clave() As String
        Get
            Return clave
        End Get
        Set(value As String)
            Me.clave = value
        End Set
    End Property
    Public Property _nombre_usuario() As String
        Get
            Return nombre_usuario
        End Get
        Set(value As String)
            Me.nombre_usuario = value
        End Set
    End Property
    Public Property _rol() As Integer
        Get
            Return rol
        End Get
        Set(value As Integer)
            Me.rol = value
        End Set
    End Property
    Public Property _estado_usuario() As String
        Get
            Return estado_usuario
        End Get
        Set(value As String)
            Me.estado_usuario = value
        End Set
    End Property
    Public Function Valores(ByVal usuario As String, ByVal pass As String)
        Dim dt As New DataTable
        Dim ds As New DataSet
        _estado_usuario = "1"
        ds.Tables.Add(dt)
        Dim da As New Odbc.OdbcDataAdapter("select nick_usuario,clave_usuario,estado_usuario,nombre_usuario,rol_usuario from usuarios", conn)
        da.Fill(dt)
        For Each datarow In dt.Rows
            If usuario = datarow.item(0) And pass = datarow(1) And _estado_usuario = datarow(2) Then
                _nombre_usuario = datarow(3)
                _rol = datarow(4)
                conn.Close()
                Return True
            End If
            'End If
        Next
        conn.Close()
        Return False
    End Function
End Class

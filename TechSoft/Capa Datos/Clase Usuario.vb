Public Class Clase_Usuario
    Inherits Clase_Conexion
    Dim id_usuario As Integer
    Dim usuario As String
    Dim clave As String
    Dim nombre_usuario As String
    Dim rol As Integer
    Dim estado_usuario As String
#Region "PROPIEDADES"
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
    Public Property _id_usuario As Integer
        Get
            Return id_usuario
        End Get
        Set(value As Integer)
            Me.id_usuario = value
        End Set
    End Property
#End Region

End Class

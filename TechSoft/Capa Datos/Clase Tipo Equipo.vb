Public Class Clase_Tipo_Equipo
    Inherits Clase_Conexion
    Dim id_tipo_equipo, id_marca As Integer
    Dim nombre_tipo_equipo, nombre_marca As String
    Public Property _id_tipo_equipo As Integer
        Get
            Return id_tipo_equipo
        End Get
        Set(value As Integer)
            Me.id_tipo_equipo = value
        End Set
    End Property
    Public Property _id_marca As Integer
        Get
            Return id_marca
        End Get
        Set(value As Integer)
            Me.id_marca = value
        End Set
    End Property
    Public Property _nombre_tipo_equipo As String
        Get
            Return nombre_tipo_equipo
        End Get
        Set(value As String)
            Me.nombre_tipo_equipo = value
        End Set
    End Property
    Public Property _nombre_marca As String
        Get
            Return nombre_marca
        End Get
        Set(value As String)
            Me.nombre_marca = value
        End Set
    End Property
End Class

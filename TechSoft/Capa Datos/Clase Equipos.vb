Public Class Clase_Equipos
    Inherits Clase_Conexion
    Dim id_equipo As Integer
    Dim referencia As String
    Dim problema As String
    Dim observacion As String
    Public Property _id_equipo As Integer
        Get
            Return id_equipo
        End Get
        Set(value As Integer)
            Me.id_equipo = value
        End Set
    End Property
    Public Property _referencia As String
        Get
            Return referencia
        End Get
        Set(value As String)
            Me.referencia = value
        End Set
    End Property
    Public Property _problema As String
        Get
            Return problema
        End Get
        Set(value As String)
            Me.problema = value
        End Set
    End Property
    Public Property _observacion As String
        Get
            Return observacion
        End Get
        Set(value As String)
            Me.observacion = value
        End Set
    End Property

End Class

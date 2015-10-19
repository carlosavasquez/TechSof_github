Public Class Clase_Respuesta
    Inherits Clase_Conexion
    Dim id_respuesta As Integer
    Dim estado_respuesta, detalle_respuesta As String
    Public Property _id_respuesta As Integer
        Get
            Return id_respuesta
        End Get
        Set(value As Integer)
            Me.id_respuesta = value
        End Set
    End Property
    Public Property _estado_respuesta As String
        Get
            Return estado_respuesta
        End Get
        Set(value As String)
            Me.estado_respuesta = value
        End Set
    End Property
    Public Property _detalle_respuesta As String
        Get
            Return detalle_respuesta
        End Get
        Set(value As String)
            Me.detalle_respuesta = value
        End Set
    End Property
End Class

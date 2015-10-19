Public Class Clase_Cotizacion
    Inherits Clase_Conexion
    Dim id_cotizacion As Integer
    Dim valor_mano, valor_materiales, valor_procedimiento, fecha_entrega As String
    Public Property _id_cotizacion As Integer
        Get
            Return id_cotizacion
        End Get
        Set(value As Integer)
            Me.id_cotizacion = value
        End Set
    End Property
    Public Property _valor_mano As String
        Get
            Return valor_mano
        End Get
        Set(value As String)
            Me.valor_mano = value
        End Set
    End Property
    Public Property _valor_materiales As String
        Get
            Return valor_materiales
        End Get
        Set(value As String)
            Me.valor_materiales = value
        End Set
    End Property
    Public Property _valor_procedimiento As String
        Get
            Return valor_procedimiento
        End Get
        Set(value As String)
            Me.valor_procedimiento = value
        End Set
    End Property
    Public Property _fecha_entrega As String
        Get
            Return fecha_entrega
        End Get
        Set(value As String)
            Me.fecha_entrega = value
        End Set
    End Property
End Class

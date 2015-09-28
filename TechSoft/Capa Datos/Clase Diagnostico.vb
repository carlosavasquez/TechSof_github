Public Class Clase_Diagnostico
    Inherits Clase_Conexion
    Dim id_diagnostico As Integer
    Dim nota_diagnostico, piezas_diagnostico, tiempo_diagnostico, fecha_diagnostico As String
    Public Property _id_diagnostico As Integer
        Get
            Return id_diagnostico
        End Get
        Set(value As Integer)
            Me.id_diagnostico = value
        End Set
    End Property
    Public Property _nota_diagnostico As String
        Get
            Return nota_diagnostico
        End Get
        Set(value As String)
            Me.nota_diagnostico = value
        End Set
    End Property
    Public Property _piezas_diagnostico As String
        Get
            Return piezas_diagnostico
        End Get
        Set(value As String)
            Me.piezas_diagnostico = value
        End Set
    End Property
    Public Property _tiempo_diagnostico As String
        Get
            Return tiempo_diagnostico
        End Get
        Set(value As String)
            Me.tiempo_diagnostico = value
        End Set
    End Property
    Public Property _fecha_diagnostico As String
        Get
            Return fecha_diagnostico
        End Get
        Set(value As String)
            Me.fecha_diagnostico = value
        End Set
    End Property
End Class

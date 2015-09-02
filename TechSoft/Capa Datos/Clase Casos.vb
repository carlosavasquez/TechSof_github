Public Class Clase_Casos
    Inherits Clase_Conexion
    Dim id_caso As Integer
    Dim f_entrada_caso As String
    Dim f_salida_caso As String
    Dim numero_caso As Integer
    Public Property _id_caso As Integer
        Get
            Return id_caso
        End Get
        Set(value As Integer)
            Me.id_caso = value
        End Set
    End Property
    Public Property _f_entrada_caso As Integer
        Get
            Return f_entrada_caso
        End Get
        Set(value As Integer)
            Me.f_entrada_caso = value
        End Set
    End Property
    Public Property _f_salida_caso As Integer
        Get
            Return f_salida_caso
        End Get
        Set(value As Integer)
            Me.f_salida_caso = value
        End Set
    End Property
    Public Property _numero_caso As Integer
        Get
            Return numero_caso
        End Get
        Set(value As Integer)
            Me.numero_caso = value
        End Set
    End Property
End Class

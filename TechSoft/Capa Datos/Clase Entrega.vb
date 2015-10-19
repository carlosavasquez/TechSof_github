Public Class Clase_Entrega
    Inherits Clase_Conexion
    Dim id_entrega As Integer
    Dim nota_entrega, fecha_entrega As String
    Public Property _id_entrega As Integer
        Get
            Return id_entrega
        End Get
        Set(value As Integer)
            Me.id_entrega = value
        End Set
    End Property
    Public Property _nota_entrega As String
        Get
            Return nota_entrega
        End Get
        Set(value As String)
            Me.nota_entrega = value
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

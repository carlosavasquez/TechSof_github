Public Class Clase_Arreglos
    Inherits Clase_Conexion
    Dim id_arreglo As Integer
    Dim nota_arreglo, fecha_arreglo As String
    Public Property _id_arreglo As Integer
        Get
            Return id_arreglo
        End Get
        Set(value As Integer)
            Me.id_arreglo = value
        End Set
    End Property
    Public Property _nota_arreglo As String
        Get
            Return nota_arreglo
        End Get
        Set(value As String)
            Me.nota_arreglo = value
        End Set
    End Property
    Public Property _fecha_arreglo As String
        Get
            Return fecha_arreglo
        End Get
        Set(value As String)
            Me.fecha_arreglo = value
        End Set
    End Property
End Class

Public Class Clase_Revision
    Inherits Clase_Conexion
    Dim id_revision As Integer
    Dim nota_revision, fecha_revision As String
    Public Property _id_revision As Integer
        Get
            Return id_revision
        End Get
        Set(value As Integer)
            Me.id_revision = value
        End Set
    End Property
    Public Property _nota_revision As String
        Get
            Return nota_revision
        End Get
        Set(value As String)
            Me.nota_revision = value
        End Set
    End Property
    Public Property _fecha_revision As String
        Get
            Return fecha_revision
        End Get
        Set(value As String)
            Me.fecha_revision = value
        End Set
    End Property
End Class

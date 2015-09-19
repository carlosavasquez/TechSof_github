Public Class Clase_Cliente
    Inherits Clase_Conexion
    Dim id_cliente As Integer

    Public Property _idcliente As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            Me.id_cliente = value
        End Set
    End Property
End Class

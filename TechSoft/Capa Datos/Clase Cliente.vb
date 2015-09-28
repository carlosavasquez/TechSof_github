Public Class Clase_Cliente
    Inherits Clase_Conexion
    Dim id_cliente As Integer
    Dim nombre_cliente, apellido_cliente, tel1, tel2, ciudad As String
    Public Property _idcliente As Integer
        Get
            Return id_cliente
        End Get
        Set(value As Integer)
            Me.id_cliente = value
        End Set
    End Property
    Public Property _nombre_cliente As String
        Get
            Return nombre_cliente
        End Get
        Set(value As String)
            Me.nombre_cliente = value
        End Set
    End Property
    Public Property _apellido_cliente As String
        Get
            Return apellido_cliente
        End Get
        Set(value As String)
            Me.apellido_cliente = value
        End Set
    End Property
    Public Property _tel1 As String
        Get
            Return tel1
        End Get
        Set(value As String)
            Me.tel1 = value
        End Set
    End Property
    Public Property _tel2 As String
        Get
            Return tel2
        End Get
        Set(value As String)
            Me.tel2 = value
        End Set
    End Property
    Public Property _ciudad As String
        Get
            Return ciudad
        End Get
        Set(value As String)
            Me.ciudad = value
        End Set
    End Property

End Class

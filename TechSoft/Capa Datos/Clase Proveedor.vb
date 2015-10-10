Public Class Clase_Proveedor
    Inherits Clase_Conexion
    Dim id_proveedor As Integer
    Dim nombre_o_razon, cc_nit, ciudad_proveedor, observacion As String
    Public Property _id_proveedor As Integer
        Get
            Return id_proveedor
        End Get
        Set(value As Integer)
            Me.id_proveedor = value
        End Set
    End Property
    Public Property _nombre_o_razon As String
        Get
            Return nombre_o_razon
        End Get
        Set(value As String)
            Me.nombre_o_razon = value
        End Set
    End Property
    Public Property _cc_nit As String
        Get
            Return cc_nit
        End Get
        Set(value As String)
            Me.cc_nit = value
        End Set
    End Property
    Public Property _ciudad_proveedor As String
        Get
            Return ciudad_proveedor
        End Get
        Set(value As String)
            Me.ciudad_proveedor = value
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

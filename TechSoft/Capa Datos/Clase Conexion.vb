Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class Clase_Conexion
    Public conn As New MySqlConnection("server=localhost;" & "user id=root;")

    Public Sub conectar()
        Try
            conn.Open()
            MsgBox("conexion correcta")
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try


    End Sub
End Class


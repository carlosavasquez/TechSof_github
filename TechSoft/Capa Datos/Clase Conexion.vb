'librerias utilizadas para el trabajo con ODBC
Imports System.Data
Imports System.Data.Odbc
Imports System
Imports System.IO

Public Class Clase_Conexion
    'Variables globales utilizadas en todo el programas
    Public conn As New OdbcConnection("dsn=techsoft")
    Public cmd As New OdbcCommand
    Public lector As Odbc.OdbcDataReader
    Public trans As OdbcTransaction
    'procedimiento que abre un OdbcConnection
    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("Conexion Correcta")
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show("NO SE PUDO CONECTAR AL SERVIDOR", "Error en el servidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End Try
    End Sub
    'procedimiento que Cierra un OdbcConnection
    Public Sub desconectarse()
        Try
            conn.Close()
            'MsgBox("DesConexion Correcta")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Information)
        End Try
    End Sub
End Class



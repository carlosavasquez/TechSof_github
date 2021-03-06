﻿Public Class Cotizacion_Nueva
    Dim objcasos As New Casos
    Dim objcliente As New Clientes
    Dim objequipo As New Equipos
    Dim objtipo As New Tipo_Equipos
    Dim objprove As New Proveedor
    Dim criterio As String
    Public Sub LlenarCotizaciones()
        dgv_ListadoCasos.DataSource = objcasos.Casos_Cotizacion
        dgv_ListadoCasos.Columns(0).Visible = False
        dgv_ListadoCasos.Columns(1).Visible = False
        dgv_ListadoCasos.Columns(2).Visible = False
        dgv_ListadoCasos.Columns(3).Visible = False
        dgv_ListadoCasos.Columns(4).HeaderText = "Fecha Entrada"
        dgv_ListadoCasos.Columns(4).Width = 200
        dgv_ListadoCasos.Columns(5).Width = 250
        dgv_ListadoCasos.Columns(5).HeaderText = "Nombre Cliente"
        dgv_ListadoCasos.Columns(6).Width = 200
        dgv_ListadoCasos.Columns(6).HeaderText = "Referencia Equipo"
        dgv_ListadoCasos.Columns(7).Width = 200
        dgv_ListadoCasos.Columns(7).HeaderText = "Marca"
    End Sub
    Public Sub LlenarProveedores()
        dgv_proveedores.DataSource = objprove.MostrarProveedor()
        dgv_proveedores.Columns(0).Visible = False
        dgv_proveedores.Columns(1).HeaderText = "Razon Social"
        dgv_proveedores.Columns(1).Width = 250
        dgv_proveedores.Columns(2).HeaderText = "CC o NIT"
        dgv_proveedores.Columns(2).Width = 200
        dgv_proveedores.Columns(3).HeaderText = "Ciudad"
        dgv_proveedores.Columns(3).Width = 150
        dgv_proveedores.Columns(4).HeaderText = "Observaciones"
        dgv_proveedores.Columns(4).Width = 150
    End Sub
    Private Sub Cotizacion_Nueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCotizaciones()
        TabControl1.TabPages(1).Enabled = False
        TabControl1.TabPages(2).Enabled = False
        TabControl1.TabPages(3).Enabled = False
        chk_Razon.Checked = True
    End Sub
    Private Sub dgv_ListadoCasos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_ListadoCasos.CellMouseDoubleClick
        Dim seleccionada As Integer
        seleccionada = CType(sender, DataGridView).CurrentRow.Index
        objcasos._id_caso = dgv_ListadoCasos.Rows(seleccionada).Cells(0).Value()
        objcasos._numero_caso = dgv_ListadoCasos.Rows(seleccionada).Cells(1).Value()
        objcliente._idcliente = dgv_ListadoCasos.Rows(seleccionada).Cells(2).Value()
        objequipo._id_equipo = dgv_ListadoCasos.Rows(seleccionada).Cells(3).Value()
        objcasos._f_entrada_caso = dgv_ListadoCasos.Rows(seleccionada).Cells(4).Value()
        txt_fecha_entrada.Text = objcasos._f_entrada_caso
        objcliente.ObtenerDatosConId()
        txt_num_caso.Text = objcasos._numero_caso
        txt_nom_cliente.Text = objcliente._nombre_cliente
        objequipo.ObtenerDatosConId()
        txt_problemas.Text = objequipo._problema
        txt_observaciones.Text = objequipo._observacion
        objtipo.ObtenerDatosTipoConId()
        objtipo.ObtenerDatosMarcaConId()
        txt_tipo.Text = objtipo._nombre_tipo_equipo
        txt_marca.Text = objtipo._nombre_marca
        TabControl1.SelectedIndex = 1
        TabControl1.TabPages(1).Enabled = True
        TabControl1.TabPages(2).Enabled = True
    End Sub
    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        If chk_Razon.Checked = True Then
            criterio = "nombre_o_razonsocial"
            LlenarProveedores()
        Else
            criterio = "cconit_proveedor"
            LlenarProveedores()
        End If
    End Sub
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If chk_Razon.Checked = True Then
            criterio = "nombre_o_razonsocial"
            LlenarProveedores()
        Else
            criterio = "cconit_proveedor"
            LlenarProveedores()
        End If
    End Sub
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If chk_Razon.Checked = True Then
            criterio = "nombre_o_razonsocial"
            LlenarProveedores()
        Else
            criterio = "cconit_proveedor"
            LlenarProveedores()
        End If
    End Sub

End Class
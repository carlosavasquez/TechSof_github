Public Class Crear_Diagnostico
    Dim objcasos As New Casos
    Dim objcliente As New Clientes
    Dim objusuario As New Clase_Usuario
    Dim objequipo As New Equipos
    Dim objtipo As New Tipo_Equipos
    Dim objdiagnostico As New Diagnostico
    Private Sub LlenarCasos()
        dgv_ListadoCasos.DataSource = objcasos.Casos_Diagnostico
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
    Private Sub LimpiarCampos()
        txt_num_caso.Text = String.Empty
        txt_fecha_entrada.Text = String.Empty
        txt_nom_cliente.Text = String.Empty
        txt_marca.Text = String.Empty
        txt_tipo.Text = String.Empty
        txt_problemas.Text = String.Empty
        txt_observaciones.Text = String.Empty
        txt_nota.Text = String.Empty
        txt_piezas.Text = String.Empty
        txt_tiempo.Text = String.Empty
    End Sub
    Private Sub Crear_Diagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCasos()
        txt_fecha.Format = DateTimePickerFormat.Custom
        txt_fecha.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Timer1.Start()
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
    End Sub

    Private Sub btn_guardar_todo_Click(sender As Object, e As EventArgs) Handles btn_guardar_todo.Click
        If txt_num_caso.Text.Length = 0 Then
            MsgBox("No se ha elegido un Caso", MsgBoxStyle.Information, "TECHSOFT")
        ElseIf txt_nota.Text.Length = 0 Then
            MsgBox("El campo Diagnostico es Obligatorio", MsgBoxStyle.Information, "TECHSOFT")
        ElseIf txt_piezas.Text.Length = 0 Then
            MsgBox("El campo Piezas necesarias es Obligatorio", MsgBoxStyle.Information, "TECHSOFT")
        ElseIf txt_tiempo.Text.Length = 0 Then
            MsgBox("El campo Tiempo reparacion es Obligatorio", MsgBoxStyle.Information, "TECHSOFT")
        Else
            If objdiagnostico.Crear_Diagnostico(id_usuario, txt_nota.Text, txt_piezas.Text, txt_tiempo.Text, txt_fecha.Text) = True Then
                objdiagnostico.ObtenerUltimoDiagnostico()
                objcasos.AgregarDiagnostico(objdiagnostico._id_diagnostico, objcasos._id_caso)
                If MsgBox("Se Agrego el Diagnostico exitosamente. ¿Desea Diagnosticar mas casos?", MsgBoxStyle.YesNo, "TECHSOFTE") = MsgBoxResult.Yes Then
                    LimpiarCampos()
                    TabControl1.SelectedIndex = 0
                Else
                    Me.Close()
                End If
            Else
                MsgBox("Nose Pudo Agregar el Diagnostico, Intentelo de nuevo", MsgBoxStyle.Information, "TECHSOFT")
            End If
        End If
       
    End Sub

    Private Sub TabPage1_Enter(sender As Object, e As EventArgs) Handles TabPage1.Enter
        LlenarCasos()
    End Sub

    Private Sub txt_nota_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nota.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "El Campo Diagnostico es obligatorio")
        End If
    End Sub

    Private Sub txt_piezas_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_piezas.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "El Campo Piezas Necesarias es obligatorio")
        End If
    End Sub

    Private Sub txt_tiempo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_tiempo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            ErrorIcono.SetError(sender, "")
        Else
            ErrorIcono.SetError(sender, "El Campo Tiempo Reparacion es obligatorio")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_fecha.Text = Date.Now
    End Sub
End Class
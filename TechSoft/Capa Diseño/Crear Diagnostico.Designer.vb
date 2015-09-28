<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Diagnostico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_ListadoCasos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_fecha_entrada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_problemas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nom_cliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_num_caso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nota = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tiempo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_piezas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.l_cancel = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.l_save = New System.Windows.Forms.Label()
        Me.btn_guardar_todo = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TT_mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(23, 27)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(677, 417)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.dgv_ListadoCasos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(655, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Casos a Diagnosticar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_ListadoCasos
        '
        Me.dgv_ListadoCasos.AllowUserToAddRows = False
        Me.dgv_ListadoCasos.AllowUserToDeleteRows = False
        Me.dgv_ListadoCasos.AllowUserToOrderColumns = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListadoCasos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_ListadoCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ListadoCasos.Location = New System.Drawing.Point(6, 51)
        Me.dgv_ListadoCasos.Name = "dgv_ListadoCasos"
        Me.dgv_ListadoCasos.ReadOnly = True
        Me.dgv_ListadoCasos.RowHeadersVisible = False
        Me.dgv_ListadoCasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListadoCasos.Size = New System.Drawing.Size(643, 234)
        Me.dgv_ListadoCasos.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.txt_fecha_entrada)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_observaciones)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_problemas)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_tipo)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_marca)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_nom_cliente)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_num_caso)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(655, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle Caso"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_fecha_entrada
        '
        Me.txt_fecha_entrada.Enabled = False
        Me.txt_fecha_entrada.Location = New System.Drawing.Point(188, 91)
        Me.txt_fecha_entrada.Name = "txt_fecha_entrada"
        Me.txt_fecha_entrada.Size = New System.Drawing.Size(190, 29)
        Me.txt_fecha_entrada.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Entrada:"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Enabled = False
        Me.txt_observaciones.Location = New System.Drawing.Point(188, 282)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(415, 80)
        Me.txt_observaciones.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Observaciones:"
        '
        'txt_problemas
        '
        Me.txt_problemas.Enabled = False
        Me.txt_problemas.Location = New System.Drawing.Point(188, 196)
        Me.txt_problemas.Multiline = True
        Me.txt_problemas.Name = "txt_problemas"
        Me.txt_problemas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_problemas.Size = New System.Drawing.Size(415, 80)
        Me.txt_problemas.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Problemas:"
        '
        'txt_tipo
        '
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Location = New System.Drawing.Point(188, 161)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(190, 29)
        Me.txt_tipo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo:"
        '
        'txt_marca
        '
        Me.txt_marca.Enabled = False
        Me.txt_marca.Location = New System.Drawing.Point(188, 126)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(190, 29)
        Me.txt_marca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca:"
        '
        'txt_nom_cliente
        '
        Me.txt_nom_cliente.Enabled = False
        Me.txt_nom_cliente.Location = New System.Drawing.Point(188, 56)
        Me.txt_nom_cliente.Name = "txt_nom_cliente"
        Me.txt_nom_cliente.Size = New System.Drawing.Size(415, 29)
        Me.txt_nom_cliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Cliente:"
        '
        'txt_num_caso
        '
        Me.txt_num_caso.Enabled = False
        Me.txt_num_caso.Location = New System.Drawing.Point(188, 21)
        Me.txt_num_caso.Name = "txt_num_caso"
        Me.txt_num_caso.Size = New System.Drawing.Size(125, 29)
        Me.txt_num_caso.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Caso:"
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.l_cancel)
        Me.TabPage3.Controls.Add(Me.btn_cancel)
        Me.TabPage3.Controls.Add(Me.l_save)
        Me.TabPage3.Controls.Add(Me.btn_guardar_todo)
        Me.TabPage3.Controls.Add(Me.txt_nota)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txt_tiempo)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txt_piezas)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txt_fecha)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(669, 383)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Diagnostico"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Location = New System.Drawing.Point(106, 28)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(206, 29)
        Me.txt_fecha.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fecha:"
        '
        'txt_nota
        '
        Me.txt_nota.Location = New System.Drawing.Point(106, 63)
        Me.txt_nota.Multiline = True
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_nota.Size = New System.Drawing.Size(528, 80)
        Me.txt_nota.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Diagnostico:"
        '
        'txt_tiempo
        '
        Me.txt_tiempo.Location = New System.Drawing.Point(106, 235)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(206, 29)
        Me.txt_tiempo.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 42)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Tiempo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reparacion:"
        '
        'txt_piezas
        '
        Me.txt_piezas.Location = New System.Drawing.Point(106, 149)
        Me.txt_piezas.Multiline = True
        Me.txt_piezas.Name = "txt_piezas"
        Me.txt_piezas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_piezas.Size = New System.Drawing.Size(528, 80)
        Me.txt_piezas.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 42)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Piezas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Necesarias:"
        '
        'l_cancel
        '
        Me.l_cancel.AutoSize = True
        Me.l_cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cancel.Location = New System.Drawing.Point(328, 331)
        Me.l_cancel.Name = "l_cancel"
        Me.l_cancel.Size = New System.Drawing.Size(74, 21)
        Me.l_cancel.TabIndex = 22
        Me.l_cancel.Text = "Cancelar"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.BackgroundImage = Global.TechSoft.My.Resources.Resources.Closed
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(341, 278)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(50, 50)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'l_save
        '
        Me.l_save.AutoSize = True
        Me.l_save.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_save.Location = New System.Drawing.Point(252, 331)
        Me.l_save.Name = "l_save"
        Me.l_save.Size = New System.Drawing.Size(70, 21)
        Me.l_save.TabIndex = 20
        Me.l_save.Text = "Guardar"
        '
        'btn_guardar_todo
        '
        Me.btn_guardar_todo.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_guardar_todo.BackgroundImage = Global.TechSoft.My.Resources.Resources.Floppy
        Me.btn_guardar_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar_todo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_todo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_todo.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar_todo.Location = New System.Drawing.Point(261, 278)
        Me.btn_guardar_todo.Name = "btn_guardar_todo"
        Me.btn_guardar_todo.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar_todo.TabIndex = 19
        Me.btn_guardar_todo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar_todo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_guardar_todo.UseVisualStyleBackColor = False
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TT_mensaje
        '
        Me.TT_mensaje.IsBalloon = True
        '
        'Crear_Diagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Crear_Diagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Diagnostico"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_ListadoCasos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_problemas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_num_caso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_fecha_entrada As System.Windows.Forms.TextBox
    Friend WithEvents txt_nota As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_tiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_piezas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents l_cancel As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents l_save As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_todo As System.Windows.Forms.Button
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents TT_mensaje As System.Windows.Forms.ToolTip
End Class

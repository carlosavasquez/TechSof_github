<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Caso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_numcaso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Buscar = New System.Windows.Forms.PictureBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_ListadoCasos = New System.Windows.Forms.DataGridView()
        Me.txt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.l_guardar = New System.Windows.Forms.Label()
        Me.l_continuar = New System.Windows.Forms.Label()
        Me.l_cancelar = New System.Windows.Forms.Label()
        Me.l_editar = New System.Windows.Forms.Label()
        Me.l_nuevo = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.PictureBox()
        Me.txt_ciudad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_tel2 = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.PictureBox()
        Me.btn_actualizar = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_referencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.ComboBox()
        Me.txt_tipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_problemas = New System.Windows.Forms.TextBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TT_mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_guardar_todo = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.l_save = New System.Windows.Forms.Label()
        Me.l_cancel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.btn_siguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(193, 65)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(379, 29)
        Me.txt_nombre.TabIndex = 1
        Me.TT_mensaje.SetToolTip(Me.txt_nombre, "Nombre Cliente")
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(193, 100)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(251, 29)
        Me.txt_telefono.TabIndex = 2
        Me.TT_mensaje.SetToolTip(Me.txt_telefono, "Telefono Principal")
        '
        'txt_numcaso
        '
        Me.txt_numcaso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numcaso.Location = New System.Drawing.Point(193, 30)
        Me.txt_numcaso.Name = "txt_numcaso"
        Me.txt_numcaso.Size = New System.Drawing.Size(74, 29)
        Me.txt_numcaso.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "No. Caso:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(634, 384)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btn_Buscar)
        Me.TabPage1.Controls.Add(Me.txt_buscar)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dgv_ListadoCasos)
        Me.TabPage1.Controls.Add(Me.txt_fecha)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(626, 350)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Teal
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Image = Global.TechSoft.My.Resources.Resources.Search
        Me.btn_Buscar.Location = New System.Drawing.Point(577, 40)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(30, 30)
        Me.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Buscar.TabIndex = 17
        Me.btn_Buscar.TabStop = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Location = New System.Drawing.Point(141, 41)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(430, 29)
        Me.txt_buscar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 21)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nombre Cliente:"
        '
        'dgv_ListadoCasos
        '
        Me.dgv_ListadoCasos.AllowUserToAddRows = False
        Me.dgv_ListadoCasos.AllowUserToDeleteRows = False
        Me.dgv_ListadoCasos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ListadoCasos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ListadoCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ListadoCasos.Location = New System.Drawing.Point(9, 75)
        Me.dgv_ListadoCasos.Name = "dgv_ListadoCasos"
        Me.dgv_ListadoCasos.ReadOnly = True
        Me.dgv_ListadoCasos.RowHeadersVisible = False
        Me.dgv_ListadoCasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListadoCasos.Size = New System.Drawing.Size(610, 234)
        Me.dgv_ListadoCasos.TabIndex = 0
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(269, 97)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(200, 29)
        Me.txt_fecha.TabIndex = 18
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.l_guardar)
        Me.TabPage2.Controls.Add(Me.l_continuar)
        Me.TabPage2.Controls.Add(Me.l_cancelar)
        Me.TabPage2.Controls.Add(Me.l_editar)
        Me.TabPage2.Controls.Add(Me.l_nuevo)
        Me.TabPage2.Controls.Add(Me.btn_siguiente)
        Me.TabPage2.Controls.Add(Me.txt_ciudad)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txt_tel2)
        Me.TabPage2.Controls.Add(Me.btn_cancelar)
        Me.TabPage2.Controls.Add(Me.btn_actualizar)
        Me.TabPage2.Controls.Add(Me.btn_guardar)
        Me.TabPage2.Controls.Add(Me.btn_nuevo)
        Me.TabPage2.Controls.Add(Me.txt_numcaso)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_telefono)
        Me.TabPage2.Controls.Add(Me.txt_nombre)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(626, 350)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Cliente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'l_guardar
        '
        Me.l_guardar.AutoSize = True
        Me.l_guardar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_guardar.Location = New System.Drawing.Point(267, 305)
        Me.l_guardar.Name = "l_guardar"
        Me.l_guardar.Size = New System.Drawing.Size(47, 13)
        Me.l_guardar.TabIndex = 31
        Me.l_guardar.Text = "&Guardar"
        '
        'l_continuar
        '
        Me.l_continuar.AutoSize = True
        Me.l_continuar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_continuar.Location = New System.Drawing.Point(404, 305)
        Me.l_continuar.Name = "l_continuar"
        Me.l_continuar.Size = New System.Drawing.Size(55, 13)
        Me.l_continuar.TabIndex = 30
        Me.l_continuar.Text = "Continuar"
        Me.l_continuar.Visible = False
        '
        'l_cancelar
        '
        Me.l_cancelar.AutoSize = True
        Me.l_cancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cancelar.Location = New System.Drawing.Point(358, 305)
        Me.l_cancelar.Name = "l_cancelar"
        Me.l_cancelar.Size = New System.Drawing.Size(50, 13)
        Me.l_cancelar.TabIndex = 29
        Me.l_cancelar.Text = "Cancelar"
        Me.l_cancelar.Visible = False
        '
        'l_editar
        '
        Me.l_editar.AutoSize = True
        Me.l_editar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_editar.Location = New System.Drawing.Point(317, 305)
        Me.l_editar.Name = "l_editar"
        Me.l_editar.Size = New System.Drawing.Size(36, 13)
        Me.l_editar.TabIndex = 28
        Me.l_editar.Text = "&Editar"
        '
        'l_nuevo
        '
        Me.l_nuevo.AutoSize = True
        Me.l_nuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_nuevo.Location = New System.Drawing.Point(221, 305)
        Me.l_nuevo.Name = "l_nuevo"
        Me.l_nuevo.Size = New System.Drawing.Size(40, 13)
        Me.l_nuevo.TabIndex = 27
        Me.l_nuevo.Text = "&Nuevo"
        '
        'btn_siguiente
        '
        Me.btn_siguiente.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_siguiente.Image = Global.TechSoft.My.Resources.Resources.Arrow
        Me.btn_siguiente.Location = New System.Drawing.Point(407, 262)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(40, 40)
        Me.btn_siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_siguiente.TabIndex = 26
        Me.btn_siguiente.TabStop = False
        Me.TT_mensaje.SetToolTip(Me.btn_siguiente, "Continuar")
        Me.btn_siguiente.Visible = False
        '
        'txt_ciudad
        '
        Me.txt_ciudad.FormattingEnabled = True
        Me.txt_ciudad.Location = New System.Drawing.Point(193, 170)
        Me.txt_ciudad.Name = "txt_ciudad"
        Me.txt_ciudad.Size = New System.Drawing.Size(251, 29)
        Me.txt_ciudad.TabIndex = 4
        Me.TT_mensaje.SetToolTip(Me.txt_ciudad, "Ciudad")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 21)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Telefono Alterno:"
        '
        'txt_tel2
        '
        Me.txt_tel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel2.Location = New System.Drawing.Point(193, 135)
        Me.txt_tel2.Name = "txt_tel2"
        Me.txt_tel2.Size = New System.Drawing.Size(251, 29)
        Me.txt_tel2.TabIndex = 3
        Me.TT_mensaje.SetToolTip(Me.txt_tel2, "Telefono Alterno")
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.Red
        Me.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar.Image = Global.TechSoft.My.Resources.Resources.Closed
        Me.btn_cancelar.Location = New System.Drawing.Point(361, 262)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(40, 40)
        Me.btn_cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cancelar.TabIndex = 21
        Me.btn_cancelar.TabStop = False
        Me.TT_mensaje.SetToolTip(Me.btn_cancelar, "Cancelar")
        Me.btn_cancelar.Visible = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.Blue
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.Image = Global.TechSoft.My.Resources.Resources.Recycle
        Me.btn_actualizar.Location = New System.Drawing.Point(315, 262)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_actualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_actualizar.TabIndex = 20
        Me.btn_actualizar.TabStop = False
        Me.TT_mensaje.SetToolTip(Me.btn_actualizar, "Editar")
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Green
        Me.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar.Image = Global.TechSoft.My.Resources.Resources.Floppy
        Me.btn_guardar.Location = New System.Drawing.Point(267, 262)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(40, 40)
        Me.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_guardar.TabIndex = 19
        Me.btn_guardar.TabStop = False
        Me.TT_mensaje.SetToolTip(Me.btn_guardar, "Guardar")
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo.Image = Global.TechSoft.My.Resources.Resources.File
        Me.btn_nuevo.Location = New System.Drawing.Point(221, 262)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(40, 40)
        Me.btn_nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_nuevo.TabIndex = 18
        Me.btn_nuevo.TabStop = False
        Me.TT_mensaje.SetToolTip(Me.btn_nuevo, "Nuevo")
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txt_observaciones)
        Me.TabPage3.Controls.Add(Me.txt_referencia)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txt_marca)
        Me.TabPage3.Controls.Add(Me.txt_tipo)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.txt_problemas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(626, 350)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos Equipo"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 21)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Observaciones:"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.Location = New System.Drawing.Point(195, 230)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(379, 102)
        Me.txt_observaciones.TabIndex = 4
        '
        'txt_referencia
        '
        Me.txt_referencia.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_referencia.Location = New System.Drawing.Point(195, 87)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(227, 29)
        Me.txt_referencia.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Referencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 21)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Marca Equipo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tipo Equipo"
        '
        'txt_marca
        '
        Me.txt_marca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_marca.FormattingEnabled = True
        Me.txt_marca.Location = New System.Drawing.Point(195, 52)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(227, 29)
        Me.txt_marca.TabIndex = 1
        '
        'txt_tipo
        '
        Me.txt_tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txt_tipo.FormattingEnabled = True
        Me.txt_tipo.Location = New System.Drawing.Point(195, 17)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(227, 29)
        Me.txt_tipo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Problemas"
        '
        'txt_problemas
        '
        Me.txt_problemas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_problemas.Location = New System.Drawing.Point(195, 122)
        Me.txt_problemas.Multiline = True
        Me.txt_problemas.Name = "txt_problemas"
        Me.txt_problemas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_problemas.Size = New System.Drawing.Size(379, 102)
        Me.txt_problemas.TabIndex = 3
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'TT_mensaje
        '
        Me.TT_mensaje.IsBalloon = True
        '
        'btn_guardar_todo
        '
        Me.btn_guardar_todo.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_guardar_todo.BackgroundImage = Global.TechSoft.My.Resources.Resources.Floppy
        Me.btn_guardar_todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar_todo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_todo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_todo.ForeColor = System.Drawing.Color.Black
        Me.btn_guardar_todo.Location = New System.Drawing.Point(203, 397)
        Me.btn_guardar_todo.Name = "btn_guardar_todo"
        Me.btn_guardar_todo.Size = New System.Drawing.Size(79, 75)
        Me.btn_guardar_todo.TabIndex = 1
        Me.btn_guardar_todo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar_todo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.TT_mensaje.SetToolTip(Me.btn_guardar_todo, "Guardar Caso")
        Me.btn_guardar_todo.UseVisualStyleBackColor = False
        Me.btn_guardar_todo.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.BackgroundImage = Global.TechSoft.My.Resources.Resources.Closed
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(373, 397)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(79, 75)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.TT_mensaje.SetToolTip(Me.btn_cancel, "Guardar Caso")
        Me.btn_cancel.UseVisualStyleBackColor = False
        Me.btn_cancel.Visible = False
        '
        'l_save
        '
        Me.l_save.AutoSize = True
        Me.l_save.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_save.Location = New System.Drawing.Point(184, 475)
        Me.l_save.Name = "l_save"
        Me.l_save.Size = New System.Drawing.Size(132, 25)
        Me.l_save.TabIndex = 16
        Me.l_save.Text = "Guardar Caso"
        Me.l_save.Visible = False
        '
        'l_cancel
        '
        Me.l_cancel.AutoSize = True
        Me.l_cancel.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_cancel.Location = New System.Drawing.Point(344, 475)
        Me.l_cancel.Name = "l_cancel"
        Me.l_cancel.Size = New System.Drawing.Size(137, 25)
        Me.l_cancel.TabIndex = 18
        Me.l_cancel.Text = "Cancelar Caso"
        Me.l_cancel.Visible = False
        '
        'Crear_Caso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(664, 516)
        Me.Controls.Add(Me.l_cancel)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.l_save)
        Me.Controls.Add(Me.btn_guardar_todo)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Crear_Caso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Caso"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.btn_siguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_actualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_nuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_numcaso As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgv_ListadoCasos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_Buscar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_actualizar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_guardar As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorIcono As System.Windows.Forms.ErrorProvider
    Friend WithEvents TT_mensaje As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_tel2 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_problemas As System.Windows.Forms.TextBox
    Friend WithEvents txt_referencia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_marca As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_siguiente As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.PictureBox
    Friend WithEvents l_guardar As System.Windows.Forms.Label
    Friend WithEvents l_continuar As System.Windows.Forms.Label
    Friend WithEvents l_cancelar As System.Windows.Forms.Label
    Friend WithEvents l_editar As System.Windows.Forms.Label
    Friend WithEvents l_nuevo As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_todo As System.Windows.Forms.Button
    Friend WithEvents l_save As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents l_cancel As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
End Class

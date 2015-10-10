<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cotizacion_Nueva
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_ListadoCasos = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_Buscar = New System.Windows.Forms.PictureBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_proveedores = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chk_CCoNIT = New System.Windows.Forms.RadioButton()
        Me.chk_Razon = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(18, 20)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(677, 417)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_ListadoCasos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(669, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Casos a Cotizar"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.dgv_ListadoCasos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_ListadoCasos.Location = New System.Drawing.Point(3, 3)
        Me.dgv_ListadoCasos.Name = "dgv_ListadoCasos"
        Me.dgv_ListadoCasos.ReadOnly = True
        Me.dgv_ListadoCasos.RowHeadersVisible = False
        Me.dgv_ListadoCasos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ListadoCasos.Size = New System.Drawing.Size(663, 377)
        Me.dgv_ListadoCasos.TabIndex = 20
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txt_fecha_entrada)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.txt_observaciones)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.txt_problemas)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.txt_tipo)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.txt_marca)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.txt_nom_cliente)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.txt_num_caso)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(669, 383)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Detalle Caso"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txt_fecha_entrada
        '
        Me.txt_fecha_entrada.Enabled = False
        Me.txt_fecha_entrada.Location = New System.Drawing.Point(204, 79)
        Me.txt_fecha_entrada.Name = "txt_fecha_entrada"
        Me.txt_fecha_entrada.Size = New System.Drawing.Size(190, 29)
        Me.txt_fecha_entrada.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Fecha Entrada:"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Enabled = False
        Me.txt_observaciones.Location = New System.Drawing.Point(204, 270)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(415, 80)
        Me.txt_observaciones.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Observaciones:"
        '
        'txt_problemas
        '
        Me.txt_problemas.Enabled = False
        Me.txt_problemas.Location = New System.Drawing.Point(204, 184)
        Me.txt_problemas.Multiline = True
        Me.txt_problemas.Name = "txt_problemas"
        Me.txt_problemas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_problemas.Size = New System.Drawing.Size(415, 80)
        Me.txt_problemas.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Problemas:"
        '
        'txt_tipo
        '
        Me.txt_tipo.Enabled = False
        Me.txt_tipo.Location = New System.Drawing.Point(204, 149)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(190, 29)
        Me.txt_tipo.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tipo:"
        '
        'txt_marca
        '
        Me.txt_marca.Enabled = False
        Me.txt_marca.Location = New System.Drawing.Point(204, 114)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(190, 29)
        Me.txt_marca.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Marca:"
        '
        'txt_nom_cliente
        '
        Me.txt_nom_cliente.Enabled = False
        Me.txt_nom_cliente.Location = New System.Drawing.Point(204, 44)
        Me.txt_nom_cliente.Name = "txt_nom_cliente"
        Me.txt_nom_cliente.Size = New System.Drawing.Size(415, 29)
        Me.txt_nom_cliente.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre Cliente:"
        '
        'txt_num_caso
        '
        Me.txt_num_caso.Enabled = False
        Me.txt_num_caso.Location = New System.Drawing.Point(204, 9)
        Me.txt_num_caso.Name = "txt_num_caso"
        Me.txt_num_caso.Size = New System.Drawing.Size(125, 29)
        Me.txt_num_caso.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Numero Caso:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chk_Razon)
        Me.TabPage2.Controls.Add(Me.chk_CCoNIT)
        Me.TabPage2.Controls.Add(Me.btn_Buscar)
        Me.TabPage2.Controls.Add(Me.txt_buscar)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dgv_proveedores)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(669, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Seleccionar Proveedor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Teal
        Me.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Buscar.Image = Global.TechSoft.My.Resources.Resources.Search
        Me.btn_Buscar.Location = New System.Drawing.Point(611, 57)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(30, 30)
        Me.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Buscar.TabIndex = 22
        Me.btn_Buscar.TabStop = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_buscar.Location = New System.Drawing.Point(163, 58)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(442, 29)
        Me.txt_buscar.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nombre Proveedor:"
        '
        'dgv_proveedores
        '
        Me.dgv_proveedores.AllowUserToAddRows = False
        Me.dgv_proveedores.AllowUserToDeleteRows = False
        Me.dgv_proveedores.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_proveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedores.Location = New System.Drawing.Point(10, 93)
        Me.dgv_proveedores.Name = "dgv_proveedores"
        Me.dgv_proveedores.ReadOnly = True
        Me.dgv_proveedores.RowHeadersVisible = False
        Me.dgv_proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_proveedores.Size = New System.Drawing.Size(631, 234)
        Me.dgv_proveedores.TabIndex = 20
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(669, 383)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cotizacion"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chk_CCoNIT
        '
        Me.chk_CCoNIT.AutoSize = True
        Me.chk_CCoNIT.Location = New System.Drawing.Point(142, 17)
        Me.chk_CCoNIT.Name = "chk_CCoNIT"
        Me.chk_CCoNIT.Size = New System.Drawing.Size(92, 25)
        Me.chk_CCoNIT.TabIndex = 25
        Me.chk_CCoNIT.TabStop = True
        Me.chk_CCoNIT.Text = "CC o NIT"
        Me.chk_CCoNIT.UseVisualStyleBackColor = True
        '
        'chk_Razon
        '
        Me.chk_Razon.AutoSize = True
        Me.chk_Razon.Location = New System.Drawing.Point(10, 17)
        Me.chk_Razon.Name = "chk_Razon"
        Me.chk_Razon.Size = New System.Drawing.Size(119, 25)
        Me.chk_Razon.TabIndex = 26
        Me.chk_Razon.TabStop = True
        Me.chk_Razon.Text = "Razon Social"
        Me.chk_Razon.UseVisualStyleBackColor = True
        '
        'Cotizacion_Nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 456)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Cotizacion_Nueva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion Nueva"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_ListadoCasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_ListadoCasos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txt_fecha_entrada As System.Windows.Forms.TextBox
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
    Friend WithEvents btn_Buscar As System.Windows.Forms.PictureBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv_proveedores As System.Windows.Forms.DataGridView
    Friend WithEvents chk_Razon As System.Windows.Forms.RadioButton
    Friend WithEvents chk_CCoNIT As System.Windows.Forms.RadioButton
End Class

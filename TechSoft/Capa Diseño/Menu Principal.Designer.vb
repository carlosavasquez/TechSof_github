<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_casos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_nuevocaso = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_editarcaso = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_casospendientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.btn_casos, Me.HerramientasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.CambiarClaveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.EditarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.EditarClienteToolStripMenuItem.Text = "Editar Cliente"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEquipoToolStripMenuItem, Me.EditarEquipoToolStripMenuItem})
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'NuevoEquipoToolStripMenuItem
        '
        Me.NuevoEquipoToolStripMenuItem.Name = "NuevoEquipoToolStripMenuItem"
        Me.NuevoEquipoToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.NuevoEquipoToolStripMenuItem.Text = "Nuevo Equipo"
        '
        'EditarEquipoToolStripMenuItem
        '
        Me.EditarEquipoToolStripMenuItem.Name = "EditarEquipoToolStripMenuItem"
        Me.EditarEquipoToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.EditarEquipoToolStripMenuItem.Text = "Editar Equipo"
        '
        'btn_casos
        '
        Me.btn_casos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevocaso, Me.btn_editarcaso, Me.btn_casospendientes})
        Me.btn_casos.Name = "btn_casos"
        Me.btn_casos.Size = New System.Drawing.Size(64, 25)
        Me.btn_casos.Text = "Casos"
        '
        'btn_nuevocaso
        '
        Me.btn_nuevocaso.Name = "btn_nuevocaso"
        Me.btn_nuevocaso.Size = New System.Drawing.Size(234, 26)
        Me.btn_nuevocaso.Text = "Nuevo Caso"
        '
        'btn_editarcaso
        '
        Me.btn_editarcaso.Name = "btn_editarcaso"
        Me.btn_editarcaso.Size = New System.Drawing.Size(234, 26)
        Me.btn_editarcaso.Text = "Editar Caso"
        '
        'btn_casospendientes
        '
        Me.btn_casospendientes.Name = "btn_casospendientes"
        Me.btn_casospendientes.Size = New System.Drawing.Size(234, 26)
        Me.btn_casospendientes.Text = "Ver Casos Pendientes"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(120, 25)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'CambiarClaveToolStripMenuItem
        '
        Me.CambiarClaveToolStripMenuItem.Name = "CambiarClaveToolStripMenuItem"
        Me.CambiarClaveToolStripMenuItem.Size = New System.Drawing.Size(125, 25)
        Me.CambiarClaveToolStripMenuItem.Text = "Cambiar Clave"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(762, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 424)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_casos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_nuevocaso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_editarcaso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_casospendientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
End Class

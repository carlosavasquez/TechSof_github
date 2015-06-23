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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoCasoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCasosPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCasoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEquipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.CasosToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.CambiarClaveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.EditarClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CasosToolStripMenuItem
        '
        Me.CasosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoCasoToolStripMenuItem, Me.EditarCasoToolStripMenuItem, Me.VerCasosPendientesToolStripMenuItem})
        Me.CasosToolStripMenuItem.Name = "CasosToolStripMenuItem"
        Me.CasosToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CasosToolStripMenuItem.Text = "Casos"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CambiarClaveToolStripMenuItem
        '
        Me.CambiarClaveToolStripMenuItem.Name = "CambiarClaveToolStripMenuItem"
        Me.CambiarClaveToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.CambiarClaveToolStripMenuItem.Text = "Cambiar Clave"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(762, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoEquipoToolStripMenuItem, Me.EditarEquipoToolStripMenuItem})
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'NuevoCasoToolStripMenuItem
        '
        Me.NuevoCasoToolStripMenuItem.Name = "NuevoCasoToolStripMenuItem"
        Me.NuevoCasoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NuevoCasoToolStripMenuItem.Text = "Nuevo Caso"
        '
        'VerCasosPendientesToolStripMenuItem
        '
        Me.VerCasosPendientesToolStripMenuItem.Name = "VerCasosPendientesToolStripMenuItem"
        Me.VerCasosPendientesToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.VerCasosPendientesToolStripMenuItem.Text = "Ver Casos Pendientes"
        '
        'EditarCasoToolStripMenuItem
        '
        Me.EditarCasoToolStripMenuItem.Name = "EditarCasoToolStripMenuItem"
        Me.EditarCasoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EditarCasoToolStripMenuItem.Text = "Editar Caso"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarClienteToolStripMenuItem.Text = "Editar Cliente"
        '
        'NuevoEquipoToolStripMenuItem
        '
        Me.NuevoEquipoToolStripMenuItem.Name = "NuevoEquipoToolStripMenuItem"
        Me.NuevoEquipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoEquipoToolStripMenuItem.Text = "Nuevo Equipo"
        '
        'EditarEquipoToolStripMenuItem
        '
        Me.EditarEquipoToolStripMenuItem.Name = "EditarEquipoToolStripMenuItem"
        Me.EditarEquipoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarEquipoToolStripMenuItem.Text = "Editar Equipo"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 424)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarEquipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoCasoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarCasoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerCasosPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

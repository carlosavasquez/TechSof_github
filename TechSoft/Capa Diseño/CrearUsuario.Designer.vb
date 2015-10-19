<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuario
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearUsuario))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_guardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_cerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_renueva = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nueva = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_rol = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nick = New DevExpress.XtraEditors.TextEdit()
        Me.erroricono = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_renueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_rol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_guardar, Me.btn_cerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl.Size = New System.Drawing.Size(442, 130)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btn_guardar
        '
        Me.btn_guardar.Caption = "&Guardar"
        Me.btn_guardar.Glyph = Global.TechSoft.My.Resources.Resources.icon_save_16
        Me.btn_guardar.Id = 1
        Me.btn_guardar.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardar.Name = "btn_guardar"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Caption = "Cerrar"
        Me.btn_cerrar.Glyph = Global.TechSoft.My.Resources.Resources.icon_close_16
        Me.btn_cerrar.Id = 2
        Me.btn_cerrar.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_cerrar.Name = "btn_cerrar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menu Opciones"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_guardar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Guardar"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_cerrar)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Cerrar"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 360)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TechSoft.My.Resources.Resources.Icon_check
        Me.PictureBox1.Location = New System.Drawing.Point(405, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 301)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 21)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Repetir Clave:"
        '
        'txt_renueva
        '
        Me.txt_renueva.Location = New System.Drawing.Point(170, 294)
        Me.txt_renueva.MenuManager = Me.RibbonControl
        Me.txt_renueva.Name = "txt_renueva"
        Me.txt_renueva.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_renueva.Properties.Appearance.Options.UseFont = True
        Me.txt_renueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_renueva.Properties.UseSystemPasswordChar = True
        Me.txt_renueva.Size = New System.Drawing.Size(229, 28)
        Me.txt_renueva.TabIndex = 4
        Me.txt_renueva.ToolTip = "Repetir Clave Nueva"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(14, 267)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Nueva Clave:"
        '
        'txt_nueva
        '
        Me.txt_nueva.Location = New System.Drawing.Point(170, 260)
        Me.txt_nueva.MenuManager = Me.RibbonControl
        Me.txt_nueva.Name = "txt_nueva"
        Me.txt_nueva.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueva.Properties.Appearance.Options.UseFont = True
        Me.txt_nueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nueva.Properties.UseSystemPasswordChar = True
        Me.txt_nueva.Size = New System.Drawing.Size(229, 28)
        Me.txt_nueva.TabIndex = 3
        Me.txt_nueva.ToolTip = "Clave Nueva"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 233)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 21)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Rol Usuario:"
        '
        'txt_rol
        '
        Me.txt_rol.Location = New System.Drawing.Point(170, 226)
        Me.txt_rol.MenuManager = Me.RibbonControl
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rol.Properties.Appearance.Options.UseFont = True
        Me.txt_rol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_rol.Properties.Items.AddRange(New Object() {"Administrador", "Operador", "Tecnico"})
        Me.txt_rol.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_rol.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_rol.Properties.UseSystemPasswordChar = True
        Me.txt_rol.Size = New System.Drawing.Size(229, 28)
        Me.txt_rol.TabIndex = 2
        Me.txt_rol.ToolTip = "Clave Actual"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(14, 165)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(136, 21)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "Nombre Completo:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(170, 158)
        Me.txt_nombre.MenuManager = Me.RibbonControl
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Properties.Appearance.Options.UseFont = True
        Me.txt_nombre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nombre.Properties.UseSystemPasswordChar = True
        Me.txt_nombre.Size = New System.Drawing.Size(229, 28)
        Me.txt_nombre.TabIndex = 0
        Me.txt_nombre.ToolTip = "Clave Nueva"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(14, 199)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(92, 21)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Nick Usuario"
        '
        'txt_nick
        '
        Me.txt_nick.Location = New System.Drawing.Point(170, 192)
        Me.txt_nick.MenuManager = Me.RibbonControl
        Me.txt_nick.Name = "txt_nick"
        Me.txt_nick.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nick.Properties.Appearance.Options.UseFont = True
        Me.txt_nick.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nick.Properties.UseSystemPasswordChar = True
        Me.txt_nick.Size = New System.Drawing.Size(229, 28)
        Me.txt_nick.TabIndex = 1
        Me.txt_nick.ToolTip = "Clave Nueva"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'CrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 391)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_nick)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_renueva)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_nueva)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.txt_rol)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrearUsuario"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Crear Usuario"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_renueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_rol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btn_guardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_cerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_renueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_rol As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nick As DevExpress.XtraEditors.TextEdit
    Friend WithEvents erroricono As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider


End Class

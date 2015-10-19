<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarClave))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_guardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_salir = New DevExpress.XtraBars.BarButtonItem()
        Me.Opciones = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_actual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nueva = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_renueva = New DevExpress.XtraEditors.TextEdit()
        Me.erroricono = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_actual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_renueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_guardar, Me.btn_salir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.Opciones})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl.Size = New System.Drawing.Size(451, 130)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btn_guardar
        '
        Me.btn_guardar.Caption = "Guardar"
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Glyph = Global.TechSoft.My.Resources.Resources.icon_save_16
        Me.btn_guardar.Id = 1
        Me.btn_guardar.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardar.Name = "btn_guardar"
        '
        'btn_salir
        '
        Me.btn_salir.Caption = "Cerrar"
        Me.btn_salir.Glyph = Global.TechSoft.My.Resources.Resources.icon_close_16
        Me.btn_salir.Id = 2
        Me.btn_salir.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_salir.Name = "btn_salir"
        '
        'Opciones
        '
        Me.Opciones.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Text = "Opciones"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_guardar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Guardar"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_salir)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Salir"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 267)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(451, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 150)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 21)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Clave Actual:"
        '
        'txt_actual
        '
        Me.txt_actual.Location = New System.Drawing.Point(168, 143)
        Me.txt_actual.MenuManager = Me.RibbonControl
        Me.txt_actual.Name = "txt_actual"
        Me.txt_actual.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_actual.Properties.Appearance.Options.UseFont = True
        Me.txt_actual.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_actual.Properties.UseSystemPasswordChar = True
        Me.txt_actual.Size = New System.Drawing.Size(229, 28)
        Me.txt_actual.TabIndex = 6
        Me.txt_actual.ToolTip = "Clave Actual"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 184)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 21)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Nueva Clave:"
        '
        'txt_nueva
        '
        Me.txt_nueva.Location = New System.Drawing.Point(168, 177)
        Me.txt_nueva.MenuManager = Me.RibbonControl
        Me.txt_nueva.Name = "txt_nueva"
        Me.txt_nueva.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nueva.Properties.Appearance.Options.UseFont = True
        Me.txt_nueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nueva.Properties.UseSystemPasswordChar = True
        Me.txt_nueva.Size = New System.Drawing.Size(229, 28)
        Me.txt_nueva.TabIndex = 8
        Me.txt_nueva.ToolTip = "Clave Nueva"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 218)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(150, 21)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Repetir Nueva Clave:"
        '
        'txt_renueva
        '
        Me.txt_renueva.Location = New System.Drawing.Point(168, 211)
        Me.txt_renueva.MenuManager = Me.RibbonControl
        Me.txt_renueva.Name = "txt_renueva"
        Me.txt_renueva.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_renueva.Properties.Appearance.Options.UseFont = True
        Me.txt_renueva.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_renueva.Properties.UseSystemPasswordChar = True
        Me.txt_renueva.Size = New System.Drawing.Size(229, 28)
        Me.txt_renueva.TabIndex = 10
        Me.txt_renueva.ToolTip = "Repetir Clave Nueva"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TechSoft.My.Resources.Resources.Icon_check
        Me.PictureBox1.Location = New System.Drawing.Point(403, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'CambiarClave
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 298)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_renueva)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_nueva)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_actual)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambiarClave"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CambiarClave"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_actual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_renueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents Opciones As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btn_guardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_salir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_actual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_renueva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents erroricono As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox


End Class

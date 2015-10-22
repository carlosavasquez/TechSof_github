<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_Casos
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listado_Casos))
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.dgv_listado = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_nuevocaso = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_salir = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_seguimiento = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel_respuesta = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.r_rechazado = New System.Windows.Forms.RadioButton()
        Me.r_confir = New System.Windows.Forms.RadioButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_guardarrespuesta = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nota = New DevExpress.XtraEditors.MemoEdit()
        Me.panel_arreglo = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar_arreglo = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_guardar_arreglo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nota_arreglo = New DevExpress.XtraEditors.MemoEdit()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panel_revision = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar_revision = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_guardar_revision = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nota_revision = New DevExpress.XtraEditors.MemoEdit()
        Me.panel_entrega = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancelar_entregado = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_guardar_entregado = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nota_entregado = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_respuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_respuesta.SuspendLayout()
        CType(Me.txt_nota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_arreglo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_arreglo.SuspendLayout()
        CType(Me.txt_nota_arreglo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_revision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_revision.SuspendLayout()
        CType(Me.txt_nota_revision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_entrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_entrega.SuspendLayout()
        CType(Me.txt_nota_entregado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Grid = Nothing
        Me.GridSplitContainer1.Location = New System.Drawing.Point(12, 95)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        Me.GridSplitContainer1.Size = New System.Drawing.Size(832, 359)
        Me.GridSplitContainer1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 130)
        Me.GridControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.dgv_listado
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(917, 449)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dgv_listado})
        '
        'dgv_listado
        '
        Me.dgv_listado.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.dgv_listado.GridControl = Me.GridControl1
        Me.dgv_listado.Name = "dgv_listado"
        Me.dgv_listado.OptionsFind.FindNullPrompt = "Ingresa Texto a Buscar...."
        Me.dgv_listado.OptionsView.ShowFooter = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.White
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btn_nuevocaso, Me.btn_salir, Me.btn_seguimiento})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl1.Size = New System.Drawing.Size(917, 130)
        '
        'btn_nuevocaso
        '
        Me.btn_nuevocaso.Caption = "Nuevo Caso"
        Me.btn_nuevocaso.Glyph = Global.TechSoft.My.Resources.Resources.NewTask_16x16
        Me.btn_nuevocaso.Id = 1
        Me.btn_nuevocaso.LargeGlyph = Global.TechSoft.My.Resources.Resources.NewTask_32x32
        Me.btn_nuevocaso.Name = "btn_nuevocaso"
        '
        'btn_salir
        '
        Me.btn_salir.Caption = "Salir"
        Me.btn_salir.Glyph = Global.TechSoft.My.Resources.Resources.icon_close_16
        Me.btn_salir.Id = 2
        Me.btn_salir.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_salir.Name = "btn_salir"
        '
        'btn_seguimiento
        '
        Me.btn_seguimiento.Caption = "Seguimiento"
        Me.btn_seguimiento.Glyph = Global.TechSoft.My.Resources.Resources.icon_panel_bottom_16
        Me.btn_seguimiento.Id = 3
        Me.btn_seguimiento.LargeGlyph = Global.TechSoft.My.Resources.Resources.icon_panel_bottom_32
        Me.btn_seguimiento.Name = "btn_seguimiento"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "MENU PRINCIPAL"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_nuevocaso, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_seguimiento)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Eventos"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_salir)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Salir"
        '
        'Panel_respuesta
        '
        Me.Panel_respuesta.Controls.Add(Me.LabelControl2)
        Me.Panel_respuesta.Controls.Add(Me.r_rechazado)
        Me.Panel_respuesta.Controls.Add(Me.r_confir)
        Me.Panel_respuesta.Controls.Add(Me.SimpleButton2)
        Me.Panel_respuesta.Controls.Add(Me.btn_guardarrespuesta)
        Me.Panel_respuesta.Controls.Add(Me.LabelControl1)
        Me.Panel_respuesta.Controls.Add(Me.txt_nota)
        Me.Panel_respuesta.Location = New System.Drawing.Point(309, 134)
        Me.Panel_respuesta.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.Panel_respuesta.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Panel_respuesta.Name = "Panel_respuesta"
        Me.Panel_respuesta.Size = New System.Drawing.Size(299, 311)
        Me.Panel_respuesta.TabIndex = 2
        Me.Panel_respuesta.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl2.Location = New System.Drawing.Point(33, 129)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 21)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Nota:"
        '
        'r_rechazado
        '
        Me.r_rechazado.AutoSize = True
        Me.r_rechazado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_rechazado.Location = New System.Drawing.Point(160, 89)
        Me.r_rechazado.Name = "r_rechazado"
        Me.r_rechazado.Size = New System.Drawing.Size(106, 25)
        Me.r_rechazado.TabIndex = 5
        Me.r_rechazado.TabStop = True
        Me.r_rechazado.Text = "Rechazado"
        Me.r_rechazado.UseVisualStyleBackColor = True
        '
        'r_confir
        '
        Me.r_confir.AutoSize = True
        Me.r_confir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_confir.Location = New System.Drawing.Point(33, 89)
        Me.r_confir.Name = "r_confir"
        Me.r_confir.Size = New System.Drawing.Size(113, 25)
        Me.r_confir.TabIndex = 4
        Me.r_confir.TabStop = True
        Me.r_confir.Text = "Confirmado"
        Me.r_confir.UseVisualStyleBackColor = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(89, 236)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(50, 50)
        Me.SimpleButton2.TabIndex = 3
        '
        'btn_guardarrespuesta
        '
        Me.btn_guardarrespuesta.Image = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardarrespuesta.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_guardarrespuesta.Location = New System.Drawing.Point(33, 236)
        Me.btn_guardarrespuesta.Name = "btn_guardarrespuesta"
        Me.btn_guardarrespuesta.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardarrespuesta.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(44, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(210, 40)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Respuesta Caso"
        '
        'txt_nota
        '
        Me.txt_nota.Location = New System.Drawing.Point(33, 156)
        Me.txt_nota.MenuManager = Me.RibbonControl1
        Me.txt_nota.Name = "txt_nota"
        Me.txt_nota.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota.Properties.Appearance.Options.UseFont = True
        Me.txt_nota.Size = New System.Drawing.Size(233, 74)
        Me.txt_nota.TabIndex = 6
        '
        'panel_arreglo
        '
        Me.panel_arreglo.Controls.Add(Me.LabelControl3)
        Me.panel_arreglo.Controls.Add(Me.btn_cancelar_arreglo)
        Me.panel_arreglo.Controls.Add(Me.btn_guardar_arreglo)
        Me.panel_arreglo.Controls.Add(Me.LabelControl4)
        Me.panel_arreglo.Controls.Add(Me.txt_nota_arreglo)
        Me.panel_arreglo.Location = New System.Drawing.Point(248, 136)
        Me.panel_arreglo.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.panel_arreglo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_arreglo.Name = "panel_arreglo"
        Me.panel_arreglo.Size = New System.Drawing.Size(420, 307)
        Me.panel_arreglo.TabIndex = 8
        Me.panel_arreglo.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl3.Location = New System.Drawing.Point(28, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(98, 21)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Nota Arreglo:"
        '
        'btn_cancelar_arreglo
        '
        Me.btn_cancelar_arreglo.Image = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_cancelar_arreglo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_cancelar_arreglo.Location = New System.Drawing.Point(84, 234)
        Me.btn_cancelar_arreglo.Name = "btn_cancelar_arreglo"
        Me.btn_cancelar_arreglo.Size = New System.Drawing.Size(50, 50)
        Me.btn_cancelar_arreglo.TabIndex = 3
        Me.btn_cancelar_arreglo.ToolTip = "Cancelar"
        '
        'btn_guardar_arreglo
        '
        Me.btn_guardar_arreglo.Image = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardar_arreglo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_guardar_arreglo.Location = New System.Drawing.Point(28, 234)
        Me.btn_guardar_arreglo.Name = "btn_guardar_arreglo"
        Me.btn_guardar_arreglo.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar_arreglo.TabIndex = 2
        Me.btn_guardar_arreglo.ToolTip = "Guardar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(123, 8)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(175, 40)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Arreglo Caso"
        '
        'txt_nota_arreglo
        '
        Me.txt_nota_arreglo.Location = New System.Drawing.Point(28, 91)
        Me.txt_nota_arreglo.MenuManager = Me.RibbonControl1
        Me.txt_nota_arreglo.Name = "txt_nota_arreglo"
        Me.txt_nota_arreglo.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_arreglo.Properties.Appearance.Options.UseFont = True
        Me.txt_nota_arreglo.Size = New System.Drawing.Size(373, 137)
        Me.txt_nota_arreglo.TabIndex = 6
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'panel_revision
        '
        Me.panel_revision.Controls.Add(Me.LabelControl5)
        Me.panel_revision.Controls.Add(Me.btn_cancelar_revision)
        Me.panel_revision.Controls.Add(Me.btn_guardar_revision)
        Me.panel_revision.Controls.Add(Me.LabelControl6)
        Me.panel_revision.Controls.Add(Me.txt_nota_revision)
        Me.panel_revision.Location = New System.Drawing.Point(248, 136)
        Me.panel_revision.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.panel_revision.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_revision.Name = "panel_revision"
        Me.panel_revision.Size = New System.Drawing.Size(420, 307)
        Me.panel_revision.TabIndex = 9
        Me.panel_revision.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl5.Location = New System.Drawing.Point(28, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 21)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Nota Revisión:"
        '
        'btn_cancelar_revision
        '
        Me.btn_cancelar_revision.Image = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_cancelar_revision.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_cancelar_revision.Location = New System.Drawing.Point(84, 234)
        Me.btn_cancelar_revision.Name = "btn_cancelar_revision"
        Me.btn_cancelar_revision.Size = New System.Drawing.Size(50, 50)
        Me.btn_cancelar_revision.TabIndex = 3
        Me.btn_cancelar_revision.ToolTip = "Cancelar"
        '
        'btn_guardar_revision
        '
        Me.btn_guardar_revision.Image = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardar_revision.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_guardar_revision.Location = New System.Drawing.Point(28, 234)
        Me.btn_guardar_revision.Name = "btn_guardar_revision"
        Me.btn_guardar_revision.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar_revision.TabIndex = 2
        Me.btn_guardar_revision.ToolTip = "Guardar"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(117, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(187, 40)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Revisión Caso"
        '
        'txt_nota_revision
        '
        Me.txt_nota_revision.Location = New System.Drawing.Point(28, 91)
        Me.txt_nota_revision.MenuManager = Me.RibbonControl1
        Me.txt_nota_revision.Name = "txt_nota_revision"
        Me.txt_nota_revision.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_revision.Properties.Appearance.Options.UseFont = True
        Me.txt_nota_revision.Size = New System.Drawing.Size(373, 137)
        Me.txt_nota_revision.TabIndex = 6
        '
        'panel_entrega
        '
        Me.panel_entrega.Controls.Add(Me.LabelControl7)
        Me.panel_entrega.Controls.Add(Me.btn_cancelar_entregado)
        Me.panel_entrega.Controls.Add(Me.btn_guardar_entregado)
        Me.panel_entrega.Controls.Add(Me.LabelControl8)
        Me.panel_entrega.Controls.Add(Me.txt_nota_entregado)
        Me.panel_entrega.Location = New System.Drawing.Point(248, 136)
        Me.panel_entrega.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.panel_entrega.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_entrega.Name = "panel_entrega"
        Me.panel_entrega.Size = New System.Drawing.Size(420, 307)
        Me.panel_entrega.TabIndex = 10
        Me.panel_entrega.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelControl7.Location = New System.Drawing.Point(28, 64)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(99, 21)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "Nota Entrega:"
        '
        'btn_cancelar_entregado
        '
        Me.btn_cancelar_entregado.Image = Global.TechSoft.My.Resources.Resources.icon_close_32
        Me.btn_cancelar_entregado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_cancelar_entregado.Location = New System.Drawing.Point(84, 234)
        Me.btn_cancelar_entregado.Name = "btn_cancelar_entregado"
        Me.btn_cancelar_entregado.Size = New System.Drawing.Size(50, 50)
        Me.btn_cancelar_entregado.TabIndex = 3
        Me.btn_cancelar_entregado.ToolTip = "Cancelar"
        '
        'btn_guardar_entregado
        '
        Me.btn_guardar_entregado.Image = Global.TechSoft.My.Resources.Resources.icon_save_32
        Me.btn_guardar_entregado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_guardar_entregado.Location = New System.Drawing.Point(28, 234)
        Me.btn_guardar_entregado.Name = "btn_guardar_entregado"
        Me.btn_guardar_entregado.Size = New System.Drawing.Size(50, 50)
        Me.btn_guardar_entregado.TabIndex = 2
        Me.btn_guardar_entregado.ToolTip = "Guardar"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(122, 8)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(177, 40)
        Me.LabelControl8.TabIndex = 1
        Me.LabelControl8.Text = "Entrega Caso"
        '
        'txt_nota_entregado
        '
        Me.txt_nota_entregado.Location = New System.Drawing.Point(28, 91)
        Me.txt_nota_entregado.MenuManager = Me.RibbonControl1
        Me.txt_nota_entregado.Name = "txt_nota_entregado"
        Me.txt_nota_entregado.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nota_entregado.Properties.Appearance.Options.UseFont = True
        Me.txt_nota_entregado.Size = New System.Drawing.Size(373, 137)
        Me.txt_nota_entregado.TabIndex = 6
        '
        'Listado_Casos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 579)
        Me.Controls.Add(Me.panel_entrega)
        Me.Controls.Add(Me.panel_revision)
        Me.Controls.Add(Me.panel_arreglo)
        Me.Controls.Add(Me.Panel_respuesta)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Listado_Casos"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Casos"
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_listado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_respuesta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_respuesta.ResumeLayout(False)
        Me.Panel_respuesta.PerformLayout()
        CType(Me.txt_nota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_arreglo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_arreglo.ResumeLayout(False)
        Me.panel_arreglo.PerformLayout()
        CType(Me.txt_nota_arreglo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_revision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_revision.ResumeLayout(False)
        Me.panel_revision.PerformLayout()
        CType(Me.txt_nota_revision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_entrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_entrega.ResumeLayout(False)
        Me.panel_entrega.PerformLayout()
        CType(Me.txt_nota_entregado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents dgv_listado As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_nuevocaso As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_salir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel_respuesta As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_guardarrespuesta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents r_rechazado As System.Windows.Forms.RadioButton
    Friend WithEvents r_confir As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel_arreglo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar_arreglo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_guardar_arreglo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nota_arreglo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents panel_revision As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar_revision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_guardar_revision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nota_revision As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents panel_entrega As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancelar_entregado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_guardar_entregado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nota_entregado As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_seguimiento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class

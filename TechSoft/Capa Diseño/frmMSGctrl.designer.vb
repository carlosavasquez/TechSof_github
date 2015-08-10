<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMSGctrl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSGctrl))
        Me.main_pan_colour = New System.Windows.Forms.Panel()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.left_pan_colour = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Open_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Close_timer = New System.Windows.Forms.Timer(Me.components)
        Me.proxy_timer = New System.Windows.Forms.Timer(Me.components)
        Me.main_pan_colour.SuspendLayout()
        Me.left_pan_colour.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_pan_colour
        '
        Me.main_pan_colour.BackColor = System.Drawing.Color.SkyBlue
        Me.main_pan_colour.BackgroundImage = CType(resources.GetObject("main_pan_colour.BackgroundImage"), System.Drawing.Image)
        Me.main_pan_colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.main_pan_colour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.main_pan_colour.Controls.Add(Me.lbl_text)
        Me.main_pan_colour.Controls.Add(Me.left_pan_colour)
        Me.main_pan_colour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_pan_colour.Location = New System.Drawing.Point(0, 0)
        Me.main_pan_colour.Name = "main_pan_colour"
        Me.main_pan_colour.Size = New System.Drawing.Size(361, 149)
        Me.main_pan_colour.TabIndex = 0
        '
        'lbl_text
        '
        Me.lbl_text.BackColor = System.Drawing.Color.SkyBlue
        Me.lbl_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_text.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_text.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.Location = New System.Drawing.Point(-1, 38)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(361, 109)
        Me.lbl_text.TabIndex = 2
        Me.lbl_text.Text = "Mensaje Notificacion"
        Me.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'left_pan_colour
        '
        Me.left_pan_colour.BackColor = System.Drawing.Color.White
        Me.left_pan_colour.BackgroundImage = CType(resources.GetObject("left_pan_colour.BackgroundImage"), System.Drawing.Image)
        Me.left_pan_colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.left_pan_colour.Controls.Add(Me.lbl_title)
        Me.left_pan_colour.Dock = System.Windows.Forms.DockStyle.Fill
        Me.left_pan_colour.Location = New System.Drawing.Point(0, 0)
        Me.left_pan_colour.Name = "left_pan_colour"
        Me.left_pan_colour.Size = New System.Drawing.Size(359, 147)
        Me.left_pan_colour.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(360, 38)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Titulo Mensaje"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Open_timer
        '
        Me.Open_timer.Interval = 8
        '
        'Close_timer
        '
        Me.Close_timer.Interval = 5
        '
        'proxy_timer
        '
        Me.proxy_timer.Interval = 3000
        '
        'frmMSGctrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(361, 149)
        Me.Controls.Add(Me.main_pan_colour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMSGctrl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Messasge Alert"
        Me.TopMost = True
        Me.main_pan_colour.ResumeLayout(False)
        Me.left_pan_colour.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_pan_colour As System.Windows.Forms.Panel
    Friend WithEvents left_pan_colour As System.Windows.Forms.Panel
    Friend WithEvents lbl_text As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents Open_timer As System.Windows.Forms.Timer
    Friend WithEvents Close_timer As System.Windows.Forms.Timer
    Friend WithEvents proxy_timer As System.Windows.Forms.Timer

End Class

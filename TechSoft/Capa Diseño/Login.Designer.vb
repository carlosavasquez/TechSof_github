<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.btn_entrar = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave"
        '
        'txt_usuario
        '
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_usuario.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(140, 36)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(189, 29)
        Me.txt_usuario.TabIndex = 3
        Me.txt_usuario.Text = "carlos"
        '
        'txt_clave
        '
        Me.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clave.Location = New System.Drawing.Point(140, 75)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(189, 29)
        Me.txt_clave.TabIndex = 4
        Me.txt_clave.Text = "1"
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'btn_entrar
        '
        Me.btn_entrar.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.Appearance.Options.UseFont = True
        Me.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_entrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_entrar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft
        Me.btn_entrar.Location = New System.Drawing.Point(229, 110)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(100, 50)
        Me.btn_entrar.TabIndex = 5
        Me.btn_entrar.Text = "Entrar"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(373, 184)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents btn_entrar As DevExpress.XtraEditors.SimpleButton
End Class

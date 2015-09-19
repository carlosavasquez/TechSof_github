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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_numcaso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observaciones:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(179, 65)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(228, 29)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_apellido
        '
        Me.txt_apellido.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido.Location = New System.Drawing.Point(179, 100)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(228, 29)
        Me.txt_apellido.TabIndex = 7
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.Location = New System.Drawing.Point(179, 170)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_observaciones.Size = New System.Drawing.Size(228, 102)
        Me.txt_observaciones.TabIndex = 8
        '
        'txt_telefono
        '
        Me.txt_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono.Location = New System.Drawing.Point(179, 135)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(228, 29)
        Me.txt_telefono.TabIndex = 9
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(303, 278)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(104, 43)
        Me.btn_guardar.TabIndex = 12
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'txt_numcaso
        '
        Me.txt_numcaso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numcaso.Location = New System.Drawing.Point(179, 30)
        Me.txt_numcaso.Name = "txt_numcaso"
        Me.txt_numcaso.Size = New System.Drawing.Size(74, 29)
        Me.txt_numcaso.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "No. Caso:"
        '
        'Crear_Caso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(466, 389)
        Me.Controls.Add(Me.txt_numcaso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Crear_Caso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Caso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_numcaso As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

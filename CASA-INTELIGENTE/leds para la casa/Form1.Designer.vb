<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLuz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMovimiento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 92)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "LED1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 90)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "LED 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(300, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 90)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "LED 3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(412, 11)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 88)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "LED4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(520, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 89)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "LED5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(76, 109)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 90)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "LED6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(188, 109)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 90)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "LED7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(300, 109)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(106, 90)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "LED8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(76, 269)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(158, 77)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "ENCENDER TODOS"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(273, 269)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(158, 77)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "APAGAR TODOS"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(459, 269)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(163, 77)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "SALIR"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemperatura.Location = New System.Drawing.Point(412, 137)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(100, 29)
        Me.txtTemperatura.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Humedad"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Luz"
        '
        'txtLuz
        '
        Me.txtLuz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuz.Location = New System.Drawing.Point(412, 202)
        Me.txtLuz.Name = "txtLuz"
        Me.txtLuz.Size = New System.Drawing.Size(100, 29)
        Me.txtLuz.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Movimiento"
        '
        'txtMovimiento
        '
        Me.txtMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovimiento.Location = New System.Drawing.Point(535, 170)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.Size = New System.Drawing.Size(100, 29)
        Me.txtMovimiento.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 346)
        Me.Controls.Add(Me.txtMovimiento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLuz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTemperatura)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENCENDIDO DE LED´S"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLuz As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMovimiento As TextBox
End Class

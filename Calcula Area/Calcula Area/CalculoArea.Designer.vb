<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoArea
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_triangulo = New System.Windows.Forms.RadioButton()
        Me.tb_altura = New System.Windows.Forms.TextBox()
        Me.tb_base = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_retangulo = New System.Windows.Forms.RadioButton()
        Me.tb_ladover = New System.Windows.Forms.TextBox()
        Me.tb_ladohor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_circulo = New System.Windows.Forms.RadioButton()
        Me.tb_pi = New System.Windows.Forms.TextBox()
        Me.tb_raio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_resultado = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_triangulo)
        Me.GroupBox1.Controls.Add(Me.tb_altura)
        Me.GroupBox1.Controls.Add(Me.tb_base)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Área Triângulo"
        '
        'rb_triangulo
        '
        Me.rb_triangulo.AutoSize = True
        Me.rb_triangulo.Location = New System.Drawing.Point(14, 19)
        Me.rb_triangulo.Name = "rb_triangulo"
        Me.rb_triangulo.Size = New System.Drawing.Size(69, 17)
        Me.rb_triangulo.TabIndex = 8
        Me.rb_triangulo.TabStop = True
        Me.rb_triangulo.Text = "Triângulo"
        Me.rb_triangulo.UseVisualStyleBackColor = True
        '
        'tb_altura
        '
        Me.tb_altura.Location = New System.Drawing.Point(51, 67)
        Me.tb_altura.Name = "tb_altura"
        Me.tb_altura.Size = New System.Drawing.Size(49, 20)
        Me.tb_altura.TabIndex = 7
        '
        'tb_base
        '
        Me.tb_base.Location = New System.Drawing.Point(51, 42)
        Me.tb_base.Name = "tb_base"
        Me.tb_base.Size = New System.Drawing.Size(49, 20)
        Me.tb_base.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Altura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Base:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_retangulo)
        Me.GroupBox2.Controls.Add(Me.tb_ladover)
        Me.GroupBox2.Controls.Add(Me.tb_ladohor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 100)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Área Retângulo"
        '
        'rb_retangulo
        '
        Me.rb_retangulo.AutoSize = True
        Me.rb_retangulo.Location = New System.Drawing.Point(8, 19)
        Me.rb_retangulo.Name = "rb_retangulo"
        Me.rb_retangulo.Size = New System.Drawing.Size(74, 17)
        Me.rb_retangulo.TabIndex = 9
        Me.rb_retangulo.TabStop = True
        Me.rb_retangulo.Text = "Retângulo"
        Me.rb_retangulo.UseVisualStyleBackColor = True
        '
        'tb_ladover
        '
        Me.tb_ladover.Location = New System.Drawing.Point(89, 67)
        Me.tb_ladover.Name = "tb_ladover"
        Me.tb_ladover.Size = New System.Drawing.Size(49, 20)
        Me.tb_ladover.TabIndex = 7
        '
        'tb_ladohor
        '
        Me.tb_ladohor.Location = New System.Drawing.Point(89, 42)
        Me.tb_ladohor.Name = "tb_ladohor"
        Me.tb_ladohor.Size = New System.Drawing.Size(49, 20)
        Me.tb_ladohor.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lado Vertical:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lado Horizontal:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_circulo)
        Me.GroupBox3.Controls.Add(Me.tb_pi)
        Me.GroupBox3.Controls.Add(Me.tb_raio)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(342, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 100)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Área Círculo"
        '
        'rb_circulo
        '
        Me.rb_circulo.AutoSize = True
        Me.rb_circulo.Location = New System.Drawing.Point(11, 19)
        Me.rb_circulo.Name = "rb_circulo"
        Me.rb_circulo.Size = New System.Drawing.Size(59, 17)
        Me.rb_circulo.TabIndex = 9
        Me.rb_circulo.TabStop = True
        Me.rb_circulo.Text = "Círculo"
        Me.rb_circulo.UseVisualStyleBackColor = True
        '
        'tb_pi
        '
        Me.tb_pi.Location = New System.Drawing.Point(57, 67)
        Me.tb_pi.Name = "tb_pi"
        Me.tb_pi.Size = New System.Drawing.Size(49, 20)
        Me.tb_pi.TabIndex = 7
        '
        'tb_raio
        '
        Me.tb_raio.Location = New System.Drawing.Point(57, 42)
        Me.tb_raio.Name = "tb_raio"
        Me.tb_raio.Size = New System.Drawing.Size(49, 20)
        Me.tb_raio.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pi  (π)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Raio"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(180, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Calcular Área"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Limpar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(181, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Resultado:"
        '
        'tb_resultado
        '
        Me.tb_resultado.Location = New System.Drawing.Point(245, 174)
        Me.tb_resultado.Name = "tb_resultado"
        Me.tb_resultado.Size = New System.Drawing.Size(100, 20)
        Me.tb_resultado.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(399, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Voltar ao Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CalculoArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 206)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tb_resultado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CalculoArea"
        Me.Text = "Calcular Área"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_altura As System.Windows.Forms.TextBox
    Friend WithEvents tb_base As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_ladover As System.Windows.Forms.TextBox
    Friend WithEvents tb_ladohor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_pi As System.Windows.Forms.TextBox
    Friend WithEvents tb_raio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_resultado As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rb_triangulo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_retangulo As System.Windows.Forms.RadioButton
    Friend WithEvents rb_circulo As System.Windows.Forms.RadioButton
End Class

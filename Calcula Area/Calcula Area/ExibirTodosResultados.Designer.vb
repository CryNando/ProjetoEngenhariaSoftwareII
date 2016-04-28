<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExibirTodosResultados
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lb_Resultados = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Voltar ao Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lb_Resultados
        '
        Me.lb_Resultados.FormattingEnabled = True
        Me.lb_Resultados.Location = New System.Drawing.Point(12, 12)
        Me.lb_Resultados.Name = "lb_Resultados"
        Me.lb_Resultados.Size = New System.Drawing.Size(556, 264)
        Me.lb_Resultados.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(288, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Copiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExibirTodosResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 320)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lb_Resultados)
        Me.Name = "ExibirTodosResultados"
        Me.Text = "Calcula Área"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lb_Resultados As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

Imports System.IO

Public Class CalculoArea

    Public Sub gravarnoArquivo(ByVal resultado As Double, ByVal figura As String, ByVal medidas As String)
        If Not File.Exists("C:\CalculadoArea\log.txt") Then
            Using arquivo As StreamWriter = File.AppendText("C:\CalculaArea\log.txt")
                arquivo.WriteLine("Resultado: " & resultado & " Figura: " & figura & " Medidas: " & medidas)
                arquivo.Close()
            End Using
        End If
    End Sub

    Function calculaAreaTriangulo(ByVal base As Double, ByVal altura As Double) As Double
        Dim area As Double = (base * altura) / 2
        Return area
    End Function

    Function calculaAreaRetangulo(ByVal lado1 As Double, ByVal lado2 As Double) As Double
        Dim area As Double = lado1 * lado2
        Return area
    End Function

    Function calculaAreaCirculo(ByVal pi As Double, ByVal raio As Double) As Double
        Dim area As Double = pi * (raio * raio)
        Return area
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CalculoArea_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (rb_triangulo.Checked) Then
            If (tb_altura.Text = "" Or tb_base.Text = "") Then
                MsgBox("Preencha os campos obrigatórios", MsgBoxStyle.Critical, "Calcula Área")
            Else
                tb_resultado.Text = calculaAreaTriangulo(tb_base.Text, tb_altura.Text)
                gravarnoArquivo(CDbl(tb_resultado.Text), "Triângulo", "Base = " & tb_base.Text & " Altura = " & tb_altura.Text)
            End If
        ElseIf (rb_retangulo.Checked) Then
            If (tb_ladohor.Text = "" Or tb_ladover.Text = "") Then
                MsgBox("Preencha os campos obrigatórios", MsgBoxStyle.Critical, "Calcula Área")
            Else
                tb_resultado.Text = calculaAreaRetangulo(tb_ladohor.Text, tb_ladover.Text)
                gravarnoArquivo(CDbl(tb_resultado.Text), "Retângulo", "Lado Horizontal = " & tb_ladohor.Text & " Lado Vertical = " & tb_ladover.Text)
            End If
        ElseIf (rb_circulo.Checked) Then
            If (tb_raio.Text = "") Then
                MsgBox("Preencha o campo Raio", MsgBoxStyle.Critical, "Calcula Área")
            ElseIf (tb_pi.Text = "") Then
                MsgBox("O Campo de Pi está em branco, o será considerado o valor 3,14")
                tb_resultado.Text = calculaAreaCirculo(3.14, tb_raio.Text)
                gravarnoArquivo(CDbl(tb_resultado.Text), "Círculo", "Pi = 3,14 Raio = " & tb_raio.Text)
            Else
                tb_resultado.Text = calculaAreaCirculo(tb_pi.Text, tb_raio.Text)
                gravarnoArquivo(CDbl(tb_resultado.Text), "Círculo", "Pi = 3,14 Raio = " & tb_raio.Text)
            End If
        Else
            MsgBox("Selecione alguma das opções", MsgBoxStyle.Critical, "Calcula Área")
        End If
    End Sub

    Private Sub rb_triangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_triangulo.CheckedChanged
        If (rb_triangulo.Checked) Then
            rb_circulo.Checked = False
            rb_retangulo.Checked = False
        End If
    End Sub

    Private Sub rb_retangulo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_retangulo.CheckedChanged
        If (rb_retangulo.Checked) Then
            rb_circulo.Checked = False
            rb_triangulo.Checked = False
        End If

    End Sub

    Private Sub rb_circulo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_circulo.CheckedChanged
        If (rb_circulo.Checked) Then
            rb_retangulo.Checked = False
            rb_triangulo.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tb_altura.Clear()
        tb_base.Clear()
        tb_ladohor.Clear()
        tb_ladover.Clear()
        tb_pi.Clear()
        tb_raio.Clear()
        tb_resultado.Clear()
        rb_circulo.Checked = False
        rb_retangulo.Checked = False
        rb_triangulo.Checked = False

    End Sub
End Class
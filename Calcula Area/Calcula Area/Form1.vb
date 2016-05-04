Imports word = Microsoft.Office.Interop.Word
Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CalculoArea.ShowDialog()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ExibirTodosResultados.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Este programa foi desenvolvido para Calcula Área de figuras geométricas, sendo elas - Triângulo, Retângulo e Círculo. Possui outras funções como: poder ver todos os resultados já gerados. Projetado com uma intaface simples, ele é rapido e eficiente.", MsgBoxStyle.Information, "Calcula Área")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Programa desenvolido por: Luis Fernando" & vbCrLf & "E-mail: crynando@outlook.com" & vbCrLf & "Celular (Use somente em caso de emergência) - (66)6666-6666", MsgBoxStyle.Information, "Calcula Área")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim wordApp As New word.Application
            Dim wordDoc As word.Document = wordApp.Documents.Open("C:\CalculaArea\ManualdoUsuario.docx")
            wordApp.Visible = True
        Catch
            MsgBox("O Manual do Usuário não está na pasta do programa CALCULA ÁREA, entre em contato com o responsável", MsgBoxStyle.Critical, "Calcula Área")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (Directory.Exists("c:\CalculaArea")) Then
            Directory.CreateDirectory("c:\CalculaArea") 'Criar o diretório na primeira inicialização do programa.
        End If
    End Sub
End Class

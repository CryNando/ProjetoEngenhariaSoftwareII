﻿Imports System.IO

Public Class ExibirTodosResultados

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lb_Resultados.Items.Clear()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ExibirTodosResultados_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        lb_Resultados.Items.Clear()
        Form1.Show()

    End Sub

    Private Sub ExibirTodosResultados_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not (File.Exists("c:\CalculaArea\log.txt")) Then
            MsgBox("Você ainda não fez nenhuma operação", MsgBoxStyle.Critical, "Calcula Área")
            Exit Sub
        End If
        Dim arquivo As New StreamReader("c:\CalculaArea\log.txt")
        Dim linhas As String = arquivo.ReadLine

        While linhas <> Nothing
            lb_Resultados.Items.Add(linhas & vbCrLf)
            linhas = arquivo.ReadLine
        End While
        arquivo.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(lb_Resultados.SelectedItem)
    End Sub
End Class
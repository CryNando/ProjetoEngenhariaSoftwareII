Public Class ExibirTodosResultados

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ExibirTodosResultados_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form1.Show()

    End Sub
End Class
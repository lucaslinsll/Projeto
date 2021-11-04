Public Class F_principal
    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Cadastro_moradores.Show()
    End Sub

    Private Sub F_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadClientes.Click
        Cadastro_moradores.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCadFerramentas.Click
        Cadastro_Ferramentas.Show()
    End Sub
End Class
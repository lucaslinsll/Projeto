Public Class F_principal
    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub btnLocacao_Click(sender As Object, e As EventArgs) Handles btnLocacao.Click
        frmLocacao.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cadastro_unidades.Show()
    End Sub

    Private Sub BtnCadBloco_Click(sender As Object, e As EventArgs) Handles BtnCadBloco.Click
        Cadastro_bloco.Show()
    End Sub

    Private Sub BtnCondominio_Click(sender As Object, e As EventArgs) Handles BtnCondominio.Click
        Cadastro_condominios.Show()
    End Sub

    Private Sub btnEstoque_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        Cadastro_estoque.Show()
    End Sub
End Class
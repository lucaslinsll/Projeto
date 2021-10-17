Imports MySql.Data.MySqlClient

Public Class Cadastro_Ferramentas
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub Buscar()
        Try
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastros_ferramentas  where ferramenta LIKE '" & txtBuscar.Text & "%' order by id_ferramenta desc "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao listar os dados!" + ex.Message)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.Enabled = True
        txtDescricao.Enabled = True
        txtDescricao.Text = ""

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text <> "" Then

            Dim cadastros As String
            cadastros = txtDescricao.Text

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO cadastros_ferramentas (ferramenta) VALUES ('" & txtDescricao.Text & "') "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso!")
            Catch ex As Exception
                MsgBox("Erro ao salvar!" + ex.Message)
            End Try
            btnSalvar.Enabled = False
            Listar()




        Else
            MsgBox("Preencha o campo ferramenta !")
        End If
    End Sub

    Private Sub Cadastro_Ferramentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()
        Try
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastros_ferramentas order by id_ferramenta desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao listar os dados!" + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDG()

        dg.Columns(0).HeaderText = "Id da ferramenta"
        dg.Columns(1).HeaderText = "Ferramenta"
        dg.Columns(0).Width = 170
        dg.Columns(1).Width = 170

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        txtDescricao.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtDescricao.Text = dg.CurrentRow.Cells(1).Value
    End Sub

    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtDescricao.Text <> "" Then

            Dim cadastros As String
            cadastros = txtDescricao.Text

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE cadastros_ferramentas SET ferramenta = '" & txtDescricao.Text & "' where id_ferramenta = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados editados com sucesso!")
            Catch ex As Exception
                MsgBox("Erro ao editar!" + ex.Message)
            End Try

            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            txtDescricao.Text = ""
            Listar()

        Else
            MsgBox("Preencha o campo descrição !")
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtCodigo.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Confirmar exclusão ?", "Excluir registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM cadastros_ferramentas where id_ferramenta = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados excluido com sucesso!")
                Catch ex As Exception
                    MsgBox("Erro ao excluir !" + ex.Message)
                End Try
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                txtDescricao.Text = ""
                Listar()
            End If
        Else
            MsgBox("Selecione um registro para excluir !")
        End If
    End Sub

    Private Sub linkVoltar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkVoltar.LinkClicked
        Me.Hide()


    End Sub
End Class
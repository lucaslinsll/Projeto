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
            sql = "select * from cadastro_ferramenta  where desc_ferramenta LIKE '" & txtBuscar.Text & "%' order by cod_ferramenta desc "

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
        txtMarca.Enabled = True
        txtMarca.Text = ""
        cbmTipo.Enabled = True
        cbmTipo.Text = ""
        cbmEstado.Enabled = True
        cbmEstado.Text = ""
        cbmDisp.Enabled = True
        cbmDisp.Text = ""
        txtCod_morador.Enabled = True
        txtCod_morador.Text= ""
        txtCod_estoque.Enabled = True
        txtCod_estoque.Text = ""
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text <> "" Then

            Dim cadastros As String
            cadastros = txtDescricao.Text

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO cadastro_ferramenta (desc_ferramenta, marca_ferramenta, tipo_ferramenta, estado_ferramenta, disponibilidade, cod_local, cod_morador) VALUES ('" & txtDescricao.Text & "','" & txtMarca.Text & "','" & cbmTipo.Text & "','" & cbmEstado.Text & "','" & cbmDisp.Text & "','" & txtCod_estoque.Text & "', '" & txtCod_morador.Text & "') "
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
        cbmTipo.Enabled = False
        cbmTipo.Text = ""
        cbmEstado.Enabled = False
        cbmEstado.Text = ""
        cbmDisp.Enabled = False
        cbmDisp.Text = ""
        txtCod_morador.Enabled = False
        txtCod_morador.Text = ""
        txtCod_estoque.Enabled = False
        txtCod_estoque.Text = ""
        Listar()
    End Sub

    Private Sub Listar()
        Try
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_ferramenta order by cod_ferramenta desc"

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
        dg.Columns(2).HeaderText = "Marca"
        dg.Columns(3).HeaderText = "Tipo"
        dg.Columns(4).HeaderText = "Estado"
        dg.Columns(5).HeaderText = "Disponibilidade"
        dg.Columns(6).HeaderText = "Código do Estoque"
        dg.Columns(7).HeaderText = "Código do proprietário"
        dg.Columns(0).Width = 150
        dg.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(1).Width = 150
        dg.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(2).Width = 150
        dg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(3).Width = 150
        dg.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(4).Width = 150
        dg.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(5).Width = 150
        dg.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(6).Width = 150
        dg.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg.Columns(7).Width = 150
        dg.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        txtDescricao.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtDescricao.Text = dg.CurrentRow.Cells(1).Value
        txtMarca.Text = dg.CurrentRow.Cells(2).Value
        cbmTipo.Text = dg.CurrentRow.Cells(3).Value
        cbmEstado.Text = dg.CurrentRow.Cells(4).Value
        cbmDisp.Text = dg.CurrentRow.Cells(5).Value
        txtCod_estoque.Text = dg.CurrentRow.Cells(6).Value
        txtCod_morador.Text = dg.CurrentRow.Cells(7).Value



    End Sub

    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub

   
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtDescricao.Text <> "" Then

            Dim cadastros As String
            cadastros = txtDescricao.Text

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE cadastro_ferramenta SET desc_ferramenta = '" & txtDescricao.Text & "', marca_ferramenta = '" & txtMarca.Text & "', tipo_ferramenta = '" & cbmTipo.Text & "', estado_ferramenta = '" & cbmEstado.Text & "', disponibilidade = '" & cbmDisp.Text & "', cod_local = '" & txtCod_estoque.Text & "', cod_morador = '" & txtCod_morador.Text & "'  where cod_ferramenta = '" & txtCodigo.Text & "' "


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
                    sql = "DELETE FROM cadastro_ferramenta where cod_ferramenta = '" & txtCodigo.Text & "' "
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


End Class
Imports MySql.Data.MySqlClient
Public Class Cadastro_moradores


    Private Sub Cadastro_moradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

    End Sub

    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "SELECT * FROM cadastro_morador ORDER BY cod_morador desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgg.DataSource = dt

            Formatardgg()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao lista !" + ex.Message)
        End Try
    End Sub

    Private Sub Formatardgg()
        dgg.Columns(0).HeaderText = "Código do morador"
        dgg.Columns(1).HeaderText = "Nome do morador"
        dgg.Columns(2).HeaderText = "CPF do morador"
        dgg.Columns(3).HeaderText = "Data de nascimento"
        dgg.Columns(4).HeaderText = "Bloco"
        dgg.Columns(5).HeaderText = "Apartamento"
        dgg.Columns(6).HeaderText = "Telefone"

        dgg.Columns(0).Width = 150
        dgg.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(1).Width = 150
        dgg.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(2).Width = 150
        dgg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(3).Width = 150
        dgg.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(4).Width = 150
        dgg.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(5).Width = 150
        dgg.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(6).Width = 150
        dgg.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub btnNovoo_Click(sender As Object, e As EventArgs) Handles btnNovoo.Click
        ' limpando campos
        btnSalvarr.Enabled = True
        txtNascimento.Enabled = True
        txtNascimento.Text = ""
        txtNome.Enabled = True
        txtNome.Text = ""
        txtTel.Enabled = True
        txtTel.Text = ""
        txtCpf.Enabled = True
        txtCpf.Text = ""
        txtBusca.Enabled = True
        txtBusca.Text = ""
        txtBloco.Enabled = True
        txtBloco.Text = ""
        txtAp.Enabled = True
        txtAp.Text = ""
        txtCod.Text = ""




    End Sub

    Private Sub btnSalvarr_Click(sender As Object, e As EventArgs) Handles btnSalvarr.Click
        'verificando campos, todos devem estar preenchidos
        If txtNome.Text <> "" And txtAp.Text <> "" And txtBloco.Text <> "" And txtTel.Text <> "" And txtCpf.Text <> "" And txtNascimento.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                'inserindo campos na tabela cadastro_morador
                sql = "INSERT INTO cadastro_morador(nome_morador, cpf_morador, data_nasc_morador, cod_bloco, cod_ap, tel_morador) VALUES ('" & txtNome.Text & "', '" & txtCpf.Text & "', '" & txtNascimento.Text & "', '" & txtBloco.Text & "', '" & txtAp.Text & "', '" & txtTel.Text & "' )"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso !")
                Me.txtNome.Select()
            Catch ex As Exception
                MsgBox("Erro ao salvar !" + ex.Message)
            End Try
            btnEditarr.Enabled = False
            btnExcluirr.Enabled = False
            txtNascimento.Text = ""
            txtNome.Text = ""
            txtTel.Text = ""
            txtCpf.Text = ""
            txtBusca.Text = ""
            txtBloco.Text = ""
            txtAp.Text = ""
            txtCod.Text = ""
            Me.txtNome.Select()
            btnSalvarr.Enabled = False
            Listar()

        Else
            MsgBox("Preencha todos os campos, para o cadastro do morador !")
        End If
    End Sub

    Private Sub dgg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgg.CellContentClick

        btnEditarr.Enabled = True
        btnExcluirr.Enabled = True

        txtCod.Text = dgg.CurrentRow.Cells(0).Value
        txtNome.Text = dgg.CurrentRow.Cells(1).Value
        txtCpf.Text = dgg.CurrentRow.Cells(2).Value
        txtNascimento.Text = dgg.CurrentRow.Cells(3).Value
        txtBloco.Text = dgg.CurrentRow.Cells(4).Value
        txtAp.Text = dgg.CurrentRow.Cells(5).Value
        txtTel.Text = dgg.CurrentRow.Cells(6).Value
    End Sub

    Sub ContarLinhas()
        Dim total As Integer = dgg.Rows.Count
        lblRegistros.Text = total

    End Sub

    Private Sub btnEditarr_Click(sender As Object, e As EventArgs) Handles btnEditarr.Click
        If txtNome.Text <> "" And txtAp.Text <> "" And txtBloco.Text <> "" And txtTel.Text <> "" And txtCpf.Text <> "" And txtNascimento.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                'atualizando campos na tabela cadastro_morador
                sql = "UPDATE cadastro_morador SET nome_morador = '" & txtNome.Text & "', cpf_morador = '" & txtCpf.Text & "', data_nasc_morador = '" & txtNascimento.Text & "', cod_bloco = '" & txtBloco.Text & "', cod_ap = '" & txtAp.Text & "', tel_morador = '" & txtTel.Text & "' where cod_morador = '" & txtCod.Text & "' "

                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Dados salvos com sucesso !")
            Catch ex As Exception
                MsgBox("Erro ao salvar !" + ex.Message)
            End Try
            btnEditarr.Enabled = False
            btnExcluirr.Enabled = False
            txtNascimento.Text = ""
            txtNome.Text = ""
            txtTel.Text = ""
            txtCpf.Text = ""
            txtBusca.Text = ""
            txtBloco.Text = ""
            txtAp.Text = ""
            txtCod.Text = ""
            Me.txtNome.Select()
            btnSalvarr.Enabled = False
            Listar()

        Else
            MsgBox("Preencha todos os campos, para o cadastro do morador !")
        End If
    End Sub

    Private Sub btnExcluirr_Click(sender As Object, e As EventArgs) Handles btnExcluirr.Click
        If txtNome.Text <> "" And txtAp.Text <> "" And txtBloco.Text <> "" And txtTel.Text <> "" And txtCpf.Text <> "" And txtNascimento.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar exclusão ?", "Excluir registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM cadastro_morador where cod_morador = '" & txtCod.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro excluido com sucesso!")
                Catch ex As Exception
                    MsgBox("Erro ao excluir registro !" + ex.Message)
                End Try
                btnEditarr.Enabled = False
                btnExcluirr.Enabled = False
                txtNascimento.Text = ""
                txtNome.Text = ""
                txtTel.Text = ""
                txtCpf.Text = ""
                txtBusca.Text = ""
                txtBloco.Text = ""
                txtAp.Text = ""
                txtCod.Text = ""
                Me.txtNome.Select()
                Listar()
            End If
        Else
            MsgBox("Selecione um registro para excluir !")
        End If
    End Sub
End Class
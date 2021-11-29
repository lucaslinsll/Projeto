Imports MySql.Data.MySqlClient
Public Class Cadastro_bloco
    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "SELECT * FROM cadastro_bloco ORDER BY cod_bloco desc"

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
        dgg.Columns(0).HeaderText = "Código do bloco"
        dgg.Columns(1).HeaderText = "Nome do bloco"
        dgg.Columns(2).HeaderText = "Código do condomínio"

        dgg.Columns(0).Width = 150
        dgg.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(1).Width = 150
        dgg.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgg.Columns(2).Width = 150
        dgg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub btnNovoo_Click(sender As Object, e As EventArgs) Handles btnNovoo.Click
        ' limpando campos
        btnSalvarr.Enabled = True
        txtCodCond.Enabled = True
        txtCodCond.Text = ""
        txtNomeBloco.Enabled = True
        txtNomeBloco.Text = ""
        txtCod.Text = ""

    End Sub

    Private Sub btnSalvarr_Click(sender As Object, e As EventArgs) Handles btnSalvarr.Click
        'verificando campos, todos devem estar preenchidos
        If txtNomeBloco.Text <> "" And txtCodCond.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                'inserindo campos na tabela cadastro_bloco
                sql = "INSERT INTO cadastro_bloco(nome_bloco, cod_condominio) VALUES ('" & txtNomeBloco.Text & "',  '" & txtCodCond.Text & "' )"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso !")
                Me.txtNomeBloco.Select()
            Catch ex As Exception
                MsgBox("Erro ao salvar !" + ex.Message)
            End Try
            btnEditarr.Enabled = False
            btnExcluirr.Enabled = False
            txtCodCond.Text = ""
            txtNomeBloco.Text = ""
            txtCod.Text = ""
            Me.txtNomeBloco.Select()
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
        txtNomeBloco.Text = dgg.CurrentRow.Cells(1).Value
        txtCodCond.Text = dgg.CurrentRow.Cells(2).Value

    End Sub

    Sub ContarLinhas()
        Dim total As Integer = dgg.Rows.Count
        lblRegistros.Text = total

    End Sub

    Private Sub btnEditarr_Click(sender As Object, e As EventArgs) Handles btnEditarr.Click
        If txtNomeBloco.Text <> "" And txtCodCond.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                'atualizando campos na tabela cadastro_bloco
                sql = "UPDATE cadastro_bloco SET nome_bloco = '" & txtNomeBloco.Text & "',  cod_condominio = '" & txtCodCond.Text & "' where cod_bloco = '" & txtCod.Text & "' "

                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Dados salvos com sucesso !")
            Catch ex As Exception
                MsgBox("Erro ao salvar !" + ex.Message)
            End Try
            btnEditarr.Enabled = False
            btnExcluirr.Enabled = False
            txtCodCond.Text = ""
            txtNomeBloco.Text = ""
            txtCod.Text = ""
            Me.txtNomeBloco.Select()
            btnSalvarr.Enabled = False
            Listar()

        Else
            MsgBox("Preencha todos os campos, para o cadastro do morador !")
        End If
    End Sub

    Private Sub btnExcluirr_Click(sender As Object, e As EventArgs) Handles btnExcluirr.Click
        If txtNomeBloco.Text <> "" And txtCodCond.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar exclusão ?", "Excluir registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM cadastro_bloco where cod_bloco = '" & txtCod.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registro excluido com sucesso!")
                Catch ex As Exception
                    MsgBox("Erro ao excluir registro !" + ex.Message)
                End Try
                btnEditarr.Enabled = False
                btnExcluirr.Enabled = False
                txtCodCond.Text = ""
                txtNomeBloco.Text = ""
                txtCod.Text = ""
                Me.txtNomeBloco.Select()
                Listar()
            End If
        Else
            MsgBox("Selecione um registro para excluir !")
        End If
    End Sub

    Private Sub Cadastro_bloco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class frmLocacao
    Private Sub frmLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCategorias()
        Listar()
        FormatarDG()
    End Sub
    Private Sub CarregarCategorias()
        fechar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_ferramenta order by cod_ferramenta desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then


                cbCategoria.ValueMember = "cod_ferramenta"
                cbCategoria.DisplayMember = "desc_ferramenta"
                cbCategoria.DataSource = dt

            Else
                MsgBox("É preciso cadastrar antes as categorias!")
            End If



        Catch ex As Exception
            MsgBox("Erro ao Listar!")
        End Try

    End Sub

    Private Sub Listar()
        fechar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_ferramenta order by cod_ferramenta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao Listar! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDG()



        dg.Columns(0).HeaderText = "Id da Ferramenta"
        dg.Columns(1).HeaderText = "Categoria "
        dg.Columns(2).HeaderText = "Marca"
        dg.Columns(3).HeaderText = "Tipo"
        dg.Columns(4).HeaderText = "Estado "
        dg.Columns(5).HeaderText = "Disponibilidade"
        dg.Columns(6).HeaderText = "Local Armazenado"
        dg.Columns(7).HeaderText = "Código do Dono"
    End Sub
    Sub Limpar()
        cbCategoria.Text = ""
        txtCodigo.Text = ""

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        cbCategoria.Text = dg.CurrentRow.Cells(1).Value
        txtDisp.Text = dg.CurrentRow.Cells(5).Value
        txtDono.Text = dg.CurrentRow.Cells(7).Value
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAlocar.Click
        Dim ValorInt As Integer
        ValorInt = CInt(txtDias.Text)
        ValorInt *= 2
        Dim data As String
        data = Now.ToString("yyyy-MM-dd")

        If txtCodigo.Text <> "" And txtDisp.Text <> "Indisponível" Then
            fechar()
            Dim result As DialogResult = MessageBox.Show("Você está realizando uma locação de R$" & ValorInt & ".00 . Deseja continuar? ", "Locação", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim dt As New DataTable
                    Dim da As MySqlDataAdapter
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "INSERT INTO locacao(id_ferramenta, id_morador_prop, id_morador_loc, dias, valor, data_locacao) VALUES ('" & txtCodigo.Text & "', '" & txtDono.Text & "', '" & txtLocador.Text & "', '" & txtDias.Text & "', '" & ValorInt & "', '" & data & "' )"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    da = New MySqlDataAdapter(sql, con)
                    da.Fill(dt)

                    sql = "UPDATE cadastro_ferramenta SET disponibilidade = '" & "Indisponível" & "'  where cod_ferramenta = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    da = New MySqlDataAdapter(sql, con)
                    da.Fill(dt)


                    MsgBox("Ferramenta Locada com sucesso!")
                    Limpar()

                Catch ex As Exception
                    MsgBox("Erro ao Locar! " + ex.Message)
                End Try

            Else
                MsgBox("Locação Cancelada")
            End If
        Else
            MsgBox("Produto já Locado!")



        End If
        Limpar()
        Listar()
    End Sub
    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_ferramenta where desc_ferramenta LIKE '" & cbCategoria.Text & "%' "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt
            FormatarDG()


        Catch ex As Exception
            MsgBox("Erro ao Buscar!!" + ex.Message)
        End Try
    End Sub
    Private Sub cbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cbCategoria.TextChanged
        Buscar()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtDisp.Text = dg.CurrentRow.Cells(5).Value
        txtDono.Text = dg.CurrentRow.Cells(7).Value
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        Buscar()

        cbCategoria.Text = dg.CurrentRow.Cells(1).Value
        txtDisp.Text = dg.CurrentRow.Cells(5).Value
        txtDono.Text = dg.CurrentRow.Cells(7).Value
    End Sub


    Private Sub txtCodigo_Click(sender As Object, e As EventArgs) Handles txtCodigo.Click
        Listar()
    End Sub

    Private Sub txtDias_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged
        Dim ValorInt As String
        If txtDias.Text >= "0" And txtDias.Text <= "999999999" Then
            ValorInt = CInt(txtDias.Text)
            ValorInt *= 2
            txtValor.Text = "R$" & ValorInt & ".00"

        End If
    End Sub

    Private Sub txtDias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDias.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLocador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocador.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class


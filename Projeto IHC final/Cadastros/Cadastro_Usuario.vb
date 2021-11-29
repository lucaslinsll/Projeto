Imports MySql.Data.MySqlClient

Public Class Cadastro_Usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCadUser.Click
        Dim login As String
        login = txtCadLogin.Text
        Dim senha As String
        senha = txtCadSenha.Text

        If txtCadLogin.Text <> "" And txtCadSenha.Text <> "" Then
            Try

                ' Verificação
                abrir()
                Dim cmdUser As MySqlCommand
                Dim reader As MySqlDataReader

                Dim sql2 As String
                sql2 = "select * from usuarios where login_usuario = '" & txtCadLogin.Text & "' "
                cmdUser = New MySqlCommand(sql2, con)
                reader = cmdUser.ExecuteReader



                If reader.Read = True Then
                    MsgBox("Este usuário já existe no banco!")
                    fechar()

                Else
                    fechar()
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "INSERT INTO usuarios (login_usuario, senha) VALUES ('" & login & "', '" & senha & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados salvos com sucesso!")
                    Me.Hide()

                End If



            Catch ex As Exception
                MsgBox("Erro ao salvar " + ex.Message)
            End Try
        Else
            MsgBox("Preencha os campos")


        End If

    End Sub
End Class
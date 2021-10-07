Imports MySql.Data.MySqlClient

Public Class F_login
    Private Sub BTN_login_Click(sender As Object, e As EventArgs) Handles BTN_login.Click
        Try
            abrir()
            Dim cmdUser As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            sql2 = "select * from usuarios where login_usuario = '" & txtLogin.Text & "' and
                   senha = '" & txtSenha.Text & "'"
            cmdUser = New MySqlCommand(sql2, con)
            reader = cmdUser.ExecuteReader

            If reader.Read = True Then
                MsgBox("Bem vindo, " + txtLogin.Text)

                Me.Hide()
                F_principal.Show()


            Else
                MsgBox("Usuário ou senha incorretos! ")

            End If
        Catch ex As Exception
            MsgBox("Erro ao logar" + ex.Message)
        End Try



    End Sub

    Private Sub F_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

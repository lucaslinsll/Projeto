Imports MySql.Data.MySqlClient

Module Conexao
    Public con As New MySqlConnection("server=localhost;userid=root;password=Pa$$w0rd;database=sistema_ferramentas;SslMode=none")
    Sub abrir()
        If con.State = 0 Then
            con.Open()

        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()

        End If
    End Sub
End Module

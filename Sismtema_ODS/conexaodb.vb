Imports MySqlConnector

Module conexaodb
    'configuração do banco de dados 
    Public conexao As New MySqlConnection("server=localhost;userid=root;passord=;database=sistema_erp;")

    Public usuario As String
    Public nomeUsuario As String
    Public CargoUsuario As String

    'mensagem de abrir / fechar para testar conexao
    Sub abrir()
        If conexao.State = 0 Then
            conexao.Open()
        End If

    End Sub
    Sub fechar()
        If conexao.State = 1 Then
            conexao.Close()
        End If
    End Sub

    'prossimos comandos do banco de conexao se tiver

End Module

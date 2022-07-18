Imports MySqlConnector

Public Class Login
    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click

        Try
            'VERIFICAR SE O USUARIO JÁ EXISTE
            abrir()
            Dim cmdUser As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            sql2 = "select * from cadastro_funcionario where Login = '" & TxtNome.Text & "' and Senha = '" & TxtSenha.Text & "'"
            cmdUser = New MySqlCommand(sql2, conexao)
            reader = cmdUser.ExecuteReader

            If reader.Read = True Then

                'RECUPERAÇÃO DO CARGO E NOME DO FUNCIONÁRIO

                Dim Cargo As String
                Cargo = reader(16)

                Dim Nome As String
                Nome = reader(1)

                Dim form = New Form1

                usuario = TxtNome.Text
                CargoUsuario = Cargo
                nomeUsuario = Nome
                MsgBox("Seja bem-vindo " + nomeUsuario)
                reader.Close()
                Me.Hide()
                form.ShowDialog()


            Else
                MsgBox("Usuário ou senha incorretos! ")
                fechar()
            End If


        Catch ex As Exception
            MsgBox("Erro ao Logar" + ex.Message)
        End Try

    End Sub

    Private Sub TxtMsenha_Click(sender As Object, e As EventArgs) Handles TxtMsenha.Click

        If TxtMsenha.Text = "(o)" Then
            TxtSenha.PasswordChar = ""
            TxtMsenha.Text = "(x)"
        Else
            TxtMsenha.Text = "(o)"
            TxtSenha.PasswordChar = "*"
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Imports MySqlConnector

Public Class FrmCadColab
    Private Sub FrmCadColab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Listar()
        Cargos()

    End Sub

    Private Sub Cargos()

        abrir()
        Dim dt As New DataTable
        Dim da As MySqlConnector.MySqlDataAdapter
        Dim sql As String
        sql = "select * from cargo order by Cargo_ID desc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt)

        Dim v = dt.Rows.Count > 0

        CbCargo.DisplayMember = "Cargo_ID"
        CbCargo.DataSource = dt


    End Sub

    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_funcionario order by Nome desc"

            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()
            Dim total As Integer = dg2.Rows.Count
            lblRegistros.Text = total

        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub

    Private Sub dg2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellClick

        BtEditar.Enabled = True
        BtExcluir.Enabled = True

        txtId.Text = dg2.CurrentRow.Cells(0).Value
        Txtidcolaborador.Text = dg2.CurrentRow.Cells(0).Value
        TxtNome.Text = dg2.CurrentRow.Cells(1).Value
        TxtGenero.Text = dg2.CurrentRow.Cells(11).Value
        TxtCpf.Text = dg2.CurrentRow.Cells(6).Value
        TxtTelefone.Text = dg2.CurrentRow.Cells(13).Value
        TxtNascimento.Text = dg2.CurrentRow.Cells(7).Value
        TxtRua.Text = dg2.CurrentRow.Cells(9).Value
        TxtnRua.Text = dg2.CurrentRow.Cells(12).Value
        TxtCep.Text = dg2.CurrentRow.Cells(3).Value
        TxtComp.Text = dg2.CurrentRow.Cells(5).Value
        TxtCidade.Text = dg2.CurrentRow.Cells(4).Value
        TxtBairro.Text = dg2.CurrentRow.Cells(2).Value
        TxtEstado.Text = dg2.CurrentRow.Cells(10).Value
        TxtData.Text = dg2.CurrentRow.Cells(8).Value
        TxtLogin.Text = dg2.CurrentRow.Cells(14).Value
        TxtSenha.Text = dg2.CurrentRow.Cells(15).Value
        CbCargo.Text = dg2.CurrentRow.Cells(16).Value



    End Sub

    ' Fim das configuracao

    ' Variavel botoes e DG

    Private Sub FormatarDG()

        dg2.Columns(1).HeaderText = "Nome"
        dg2.Columns(11).HeaderText = "Genero"
        dg2.Columns(6).HeaderText = "CPF"
        dg2.Columns(12).HeaderText = "Número"

        dg2.Columns(0).Visible = False
        dg2.Columns(2).Visible = False
        dg2.Columns(3).Visible = False
        dg2.Columns(4).Visible = False
        dg2.Columns(5).Visible = False
        dg2.Columns(7).Visible = False
        dg2.Columns(8).Visible = False
        dg2.Columns(10).Visible = False
        dg2.Columns(12).Visible = False
        dg2.Columns(13).Visible = False
        dg2.Columns(9).Visible = False

        dg2.Columns(1).Width = 170
        dg2.Columns(2).Width = 170
        dg2.Columns(6).Width = 170
        dg2.Columns(7).Width = 55


    End Sub

    Private Sub Novo()

        btLimpar.Enabled = True
        Panel1.Enabled = True
        TxtNome.Text = ""
        TxtGenero.Text = ""
        TxtCpf.Text = ""
        TxtTelefone.Text = ""
        TxtRua.Text = ""
        TxtnRua.Text = ""
        TxtCep.Text = ""
        TxtComp.Text = ""
        TxtCidade.Text = ""
        TxtBairro.Text = ""
        TxtEstado.Text = ""
        TxtData.Text = ""
        Txtidcolaborador.Text = ""
        TxtNascimento.Text = ""
        TxtLogin.Text = ""
        TxtSenha.Text = ""
        CbCargo.Text = ""


    End Sub
    Private Sub Limpar()

        btLimpar.Enabled = False
        BtEditar.Enabled = False
        Panel1.Enabled = False
        txtId.Text = ""
        TxtNome.Text = ""
        TxtGenero.Text = ""
        TxtCpf.Text = ""
        TxtTelefone.Text = ""
        TxtRua.Text = ""
        TxtnRua.Text = ""
        TxtCep.Text = ""
        TxtComp.Text = ""
        TxtCidade.Text = ""
        TxtBairro.Text = ""
        TxtEstado.Text = ""
        TxtData.Text = ""
        Txtidcolaborador.Text = ""
        TxtNascimento.Text = ""
        TxtLogin.Text = ""
        TxtSenha.Text = ""
        CbCargo.Text = ""

    End Sub

    ' FIM DAS VARIAVEIS


    ' CONFIGURAÇÃO DE BOTÃO


    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click

        Dim cliente As String
        cliente = TxtNome.Text

        If TxtNascimento.Text <> "" And TxtEstado.Text <> "" And TxtBairro.Text <> "" And TxtCidade.Text <> "" And TxtCep.Text <> "" And TxtnRua.Text <> "" And TxtRua.Text <> "" And TxtTelefone.Text <> "" And TxtCpf.Text <> "" And TxtGenero.Text <> "" And TxtNome.Text <> "" Then

            ' FORMATAÇÃO DA DATA PARA PADRÃO DO MYSQL
            Dim data As String
            data = Now.ToString("yyy-MM-dd")


            Try
                abrir()
                Dim cmdUser As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql2 As String
                sql2 = "select * from cadastro_funcionario where Login = '" & TxtLogin.Text & "' "
                cmdUser = New MySqlCommand(sql2, conexao)
                reader = cmdUser.ExecuteReader


                If reader.Read = True Then
                    MsgBox("'Login' de usuario já cadastrado!")
                    fechar()
                Else
                    reader.Close()
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "INSERT INTO cadastro_funcionario (Nome, Genero, Cpf, Telefone, DataNascimento, Endereco, EnderecoNumero, Cep, Complemento, Cidade, Bairro, Estado, Data_cadastro, Login, Senha, Funcao) VALUES ('" & TxtNome.Text & "', '" & TxtGenero.Text & "', '" & TxtCpf.Text & "', '" & TxtTelefone.Text & "', '" & TxtNascimento.Text & "', '" & TxtRua.Text & "', '" & TxtnRua.Text & "', '" & TxtCep.Text & "', '" & TxtComp.Text & "', '" & TxtCidade.Text & "', '" & TxtBairro.Text & "', '" & TxtEstado.Text & "', '" & data & "', '" & TxtLogin.Text & "','" & TxtSenha.Text & "','" & CbCargo.Text & "' ) "
                    cmd = New MySqlCommand(sql, conexao)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Salvos!")
                    Limpar()
                    Listar()
                End If

            Catch ex As Exception
                MsgBox("Erro ao salvar! " + ex.Message)
            End Try

        Else

            MsgBox("Preencha os campos!")

        End If


    End Sub


    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        Novo()
        Cargos()
        BtSalvar2.Enabled = False
        BtSalvar2.Visible = False
        BtSalvar.Enabled = True
        BtSalvar.Visible = True

    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click


        Dim result As DialogResult = MessageBox.Show("Todos os dados prenchidos serão apagados, deseja continuar? ", "Cancelar", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Try
                Limpar()

            Catch ex As Exception

            End Try


        End If

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click

        btLimpar.Enabled = True
        BtSalvar2.Enabled = True
        BtSalvar2.Visible = True
        BtSalvar.Enabled = False
        BtSalvar.Visible = False
        Panel1.Enabled = True



    End Sub

    Friend WithEvents BtSalvar2 As Button


    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If Txtidcolaborador.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM cadastro_funcionario where Id_Funcionario = '" & Txtidcolaborador.Text & "' "
                    cmd = New MySqlCommand(sql, conexao)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Excluido!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir! " + ex.Message)
                End Try

                Limpar()
                Listar()

            End If

        Else
            MsgBox("Preencha o campo ID!")
            txtId.Enabled = True
            btLimpar.Enabled = True

        End If

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscar()

    End Sub

    Private Sub buscar()



        If IsNumeric(TxtBuscar.Text) = True Then
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * FROM cadastro_funcionario where Cpf LIKE '%" & TxtBuscar.Text & "%' order by Cpf desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()
        Else
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * FROM cadastro_funcionario where Nome LIKE '" & TxtBuscar.Text & "%' order by Nome asc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()

        End If


    End Sub

    Private Sub lblRegistros_Click(sender As Object, e As EventArgs) Handles lblRegistros.Click

    End Sub

    Private Sub BtSalvar2_Click_1(sender As Object, e As EventArgs) Handles BtSalvar2.Click
        If TxtNascimento.Text <> "" And TxtEstado.Text <> "" And TxtBairro.Text <> "" And TxtCidade.Text <> "" And TxtCep.Text <> "" And TxtnRua.Text <> "" And TxtNascimento.Text <> "" And TxtTelefone.Text <> "" And TxtCpf.Text <> "" And TxtGenero.Text <> "" And TxtNome.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE cadastro_funcionario SET Nome = '" & TxtNome.Text & "', Genero = '" & TxtGenero.Text & "', Cpf = '" & TxtCpf.Text & "', Telefone = '" & TxtTelefone.Text & "', Genero = '" & TxtGenero.Text & "', DataNascimento = '" & TxtNascimento.Text & "', Endereco = '" & TxtRua.Text & "', EnderecoNumero = '" & TxtnRua.Text & "', Cep = '" & TxtCep.Text & "', Complemento = '" & TxtComp.Text & "', Cidade = '" & TxtCidade.Text & "', Bairro = '" & TxtBairro.Text & "', Estado = '" & TxtEstado.Text & "', Login = '" & TxtLogin.Text & "', Senha = '" & TxtSenha.Text & "', Funcao = '" & CbCargo.Text & "' where Id_Funcionario = '" & Txtidcolaborador.Text & "' "
                cmd = New MySqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Editados!")
                Listar()


            Catch ex As Exception

                MsgBox("Erro ao Editar! " + ex.Message)

            End Try

            BtSalvar.Enabled = True
            BtSalvar.Visible = True
            BtSalvar2.Enabled = False
            BtSalvar2.Visible = False
            BtEditar.Enabled = False
            BtExcluir.Enabled = False
            Listar()
            Limpar()

        Else

            MsgBox("Preencha todos os campos!")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtSenha.Click
        TxtSenha.PasswordChar = ""
        BtSenha2.Visible = True
        BtSenha2.Enabled = True


    End Sub

    Private Sub BtSenha2_Click(sender As Object, e As EventArgs) Handles BtSenha2.Click
        TxtSenha.PasswordChar = "*"
        BtSenha.Visible = True
        BtSenha.Visible = True
        BtSenha2.Visible = False
        BtSenha2.Enabled = False

    End Sub


    ' FIM DA CONFIGURAÇÃO DE BOTAO

End Class







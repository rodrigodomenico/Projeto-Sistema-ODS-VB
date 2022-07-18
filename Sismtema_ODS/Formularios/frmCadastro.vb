Imports MySqlConnector

Public Class frmCadastro


    Private Sub Cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()


    End Sub
    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_cliente order by Nome desc"

            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()
            Dim total As Integer = dg2.Rows.Count


        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub

    Private Sub dg2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg2.CellClick

        BtEditar.Enabled = True
        BtExcluir.Enabled = True

        txtId.Text = dg2.CurrentRow.Cells(0).Value
        Txtidcliente.Text = dg2.CurrentRow.Cells(0).Value
        TxtNome.Text = dg2.CurrentRow.Cells(1).Value
        TxtGenero.Text = dg2.CurrentRow.Cells(2).Value
        TxtCpf.Text = dg2.CurrentRow.Cells(3).Value
        TxtTelefone.Text = dg2.CurrentRow.Cells(4).Value
        TxtNascimento.Text = dg2.CurrentRow.Cells(5).Value
        TxtRua.Text = dg2.CurrentRow.Cells(6).Value
        TxtnRua.Text = dg2.CurrentRow.Cells(7).Value
        TxtCep.Text = dg2.CurrentRow.Cells(8).Value
        TxtComp.Text = dg2.CurrentRow.Cells(9).Value
        TxtCidade.Text = dg2.CurrentRow.Cells(10).Value
        TxtBairro.Text = dg2.CurrentRow.Cells(11).Value
        TxtEstado.Text = dg2.CurrentRow.Cells(12).Value
        TxtData.Text = dg2.CurrentRow.Cells(13).Value



    End Sub

    ' Fim das configuracao

    ' Variavel botoes e DG

    Private Sub FormatarDG()

        dg2.Columns(1).HeaderText = "Nome"
        dg2.Columns(3).HeaderText = "Genero"
        dg2.Columns(3).HeaderText = "CPF"
        dg2.Columns(6).HeaderText = "Endereço"
        dg2.Columns(7).HeaderText = "Número"

        dg2.Columns(0).Visible = True
        dg2.Columns(12).Visible = False
        dg2.Columns(11).Visible = False
        dg2.Columns(10).Visible = False
        dg2.Columns(9).Visible = False
        dg2.Columns(8).Visible = False
        dg2.Columns(4).Visible = False
        dg2.Columns(2).Visible = False
        dg2.Columns(8).Visible = False
        dg2.Columns(0).Visible = False
        dg2.Columns(5).Visible = False


        dg2.Columns(1).Width = 300
        dg2.Columns(2).Width = 150
        dg2.Columns(6).Width = 270
        dg2.Columns(7).Width = 55

    End Sub

    Private Sub Novo()

        btLimpar.Enabled = True
        BtSalvar.Enabled = True
        TxtNome.Enabled = True

        TxtGenero.Enabled = True
        TxtCpf.Enabled = True
        TxtTelefone.Enabled = True
        TxtRua.Enabled = True
        TxtnRua.Enabled = True
        TxtCep.Enabled = True
        TxtComp.Enabled = True
        TxtCidade.Enabled = True
        TxtBairro.Enabled = True
        TxtEstado.Enabled = True
        TxtData.Enabled = False
        Txtidcliente.Enabled = False
        TxtNascimento.Enabled = True

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
        Txtidcliente.Text = ""
        TxtNascimento.Text = ""

    End Sub
    Private Sub Limpar()

        btLimpar.Enabled = False
        BtSalvar.Enabled = False
        BtSalvar.Visible = True
        BtSalvar2.Enabled = False
        BtSalvar2.Visible = False
        TxtNome.Enabled = False
        BtExcluir.Enabled = False
        TxtGenero.Enabled = False
        TxtCpf.Enabled = False
        TxtTelefone.Enabled = False
        TxtRua.Enabled = False
        TxtnRua.Enabled = False
        TxtCep.Enabled = False
        TxtComp.Enabled = False
        TxtCidade.Enabled = False
        TxtBairro.Enabled = False
        TxtEstado.Enabled = False
        TxtData.Enabled = False
        Txtidcliente.Enabled = False
        TxtNascimento.Enabled = False

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
        Txtidcliente.Text = ""
        TxtNascimento.Text = ""

    End Sub

    Private Sub HabilitarCampos()

        btLimpar.Enabled = True
        BtSalvar.Enabled = True
        TxtNome.Enabled = True
        TxtGenero.Enabled = True
        TxtCpf.Enabled = True
        TxtTelefone.Enabled = True
        TxtRua.Enabled = True
        TxtnRua.Enabled = True
        TxtCep.Enabled = True
        TxtComp.Enabled = True
        TxtCidade.Enabled = True
        TxtBairro.Enabled = True
        TxtEstado.Enabled = True
        TxtData.Enabled = False
        Txtidcliente.Enabled = False
        TxtNascimento.Enabled = True

    End Sub

    Private Sub habilitarcamposbt()

        btLimpar.Enabled = True
        BtSalvar.Visible = False
        BtSalvar.Enabled = False
        BtSalvar2.Enabled = True
        BtSalvar2.Visible = True
        TxtNome.Enabled = True
        TxtGenero.Enabled = True
        TxtCpf.Enabled = True
        TxtTelefone.Enabled = True
        TxtRua.Enabled = True
        TxtnRua.Enabled = True
        TxtCep.Enabled = True
        TxtComp.Enabled = True
        TxtCidade.Enabled = True
        TxtBairro.Enabled = True
        TxtEstado.Enabled = True
        TxtData.Enabled = False
        Txtidcliente.Enabled = False
        TxtNascimento.Enabled = True

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
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO cadastro_cliente (Nome, Genero, Cpf, Telefone, DataNascimento, Endereco, EnderecoNumero, Cep, Complemento, Cidade, Bairro, Estado, Data_Cadastro) VALUES ('" & TxtNome.Text & "', '" & TxtGenero.Text & "', '" & TxtCpf.Text & "', '" & TxtTelefone.Text & "', '" & TxtNascimento.Text & "', '" & TxtRua.Text & "', '" & TxtnRua.Text & "', '" & TxtCep.Text & "', '" & TxtComp.Text & "', '" & TxtCidade.Text & "', '" & TxtBairro.Text & "', '" & TxtEstado.Text & "', '" & data & "' ) "
                cmd = New MySqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos!")
            Catch ex As Exception
                MsgBox("Erro ao salvar! " + ex.Message)
            End Try
            Limpar()
            Listar()

        Else

            MsgBox("Preencha os campos!")

        End If


    End Sub


    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
        Novo()
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

        BtSalvar2.Enabled = True
        BtSalvar2.Visible = True
        BtSalvar.Enabled = False
        BtSalvar.Visible = False
        habilitarcamposbt()


    End Sub

    Friend WithEvents BtSalvar2 As Button

    Private Sub BtSalvar2_Click(sender As Object, e As EventArgs) Handles BtSalvar2.Click

        If TxtNascimento.Text <> "" And TxtEstado.Text <> "" And TxtBairro.Text <> "" And TxtCidade.Text <> "" And TxtCep.Text <> "" And TxtnRua.Text <> "" And TxtNascimento.Text <> "" And TxtTelefone.Text <> "" And TxtCpf.Text <> "" And TxtGenero.Text <> "" And TxtNome.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE cadastro_cliente SET Nome = '" & TxtNome.Text & "', Genero = '" & TxtGenero.Text & "', Cpf = '" & TxtCpf.Text & "', Telefone = '" & TxtTelefone.Text & "', Genero = '" & TxtGenero.Text & "', DataNascimento = '" & TxtNascimento.Text & "', Endereco = '" & TxtRua.Text & "', EnderecoNumero = '" & TxtnRua.Text & "', Cep = '" & TxtCep.Text & "', Complemento = '" & TxtComp.Text & "', Cidade = '" & TxtCidade.Text & "', Bairro = '" & TxtBairro.Text & "', Estado = '" & TxtEstado.Text & "' where Id_cliente = '" & Txtidcliente.Text & "' "
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



    Private Sub BtExcluir_Click(sender As Object, e As EventArgs) Handles BtExcluir.Click
        If Txtidcliente.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM cadastro_cliente where Id_cliente = '" & Txtidcliente.Text & "' "
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
            sql = "select * FROM cadastro_cliente where Cpf LIKE '%" & TxtBuscar.Text & "%' order by Cpf desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()
        Else
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * FROM cadastro_cliente where Nome LIKE '" & TxtBuscar.Text & "%' order by Nome asc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg2.DataSource = dt
            FormatarDG()

        End If


    End Sub

    Private Sub lblRegistros_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtData_TextChanged(sender As Object, e As EventArgs) Handles TxtData.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ' FIM DA CONFIGURAÇÃO DE BOTAO

End Class




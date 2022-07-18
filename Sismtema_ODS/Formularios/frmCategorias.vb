Imports MySqlConnector


'Configuração de cada botão e suas funçoes

Public Class frmcategorias

    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from chamado order by DataEntrada desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            DgSolicitacao.DataSource = dt
            'Dim total As Integer = dgPedidos.Rows.Count
            'lblRegistros.Text = total

        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub

    Private Sub frmcategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        FormatarDG()

    End Sub

    Private Sub Status()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlConnector.MySqlDataAdapter
            Dim sql As String
            sql = "select * from status_solicitacao order by Solicitacao desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                CbStatus.ValueMember = "Solicitacao_id"
                CbStatus.DisplayMember = "Solicitacao"
                CbStatus.DataSource = dt

            Else
                Dim result As DialogResult = MessageBox.Show("Não existe ¨técnicos¨ cadastrado no sistema, para poder continuar precisa realizar o cadastro. Desejá efetuar esse cadastro agora?", "Atenção!", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim form = New frmCadastro
                        form.ShowDialog()
                        Cancelar()
                    Catch ex As Exception
                    End Try
                End If
                Cancelar()
            End If
        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try


    End Sub

    Private Sub CarregarTecnicos()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlConnector.MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_funcionario order by Nome desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                CbTecnico.ValueMember = "Id_Funcionario"
                CbTecnico.DisplayMember = "Nome"
                CbTecnico.DataSource = dt

            Else
                Dim result As DialogResult = MessageBox.Show("Não existe ¨técnicos¨ cadastrado no sistema, para poder continuar precisa realizar o cadastro. Desejá efetuar esse cadastro agora?", "Atenção!", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim form = New frmCadastro
                        form.ShowDialog()
                        Cancelar()
                    Catch ex As Exception
                    End Try
                End If
                Cancelar()
            End If
        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try
    End Sub

    Private Sub CarregarClientes()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlConnector.MySqlDataAdapter
            Dim sql As String
            sql = "select * from cadastro_cliente order by Nome desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                CbClientes.ValueMember = "Id_Cliente"
                CbClientes.DisplayMember = "Nome"
                CbClientes.DataSource = dt
            Else
                Dim result As DialogResult = MessageBox.Show("Não existe ¨clientes¨ cadastrado no sistema, para poder continuar precisa realizar o cadastro. Desejá efetuar esse cadastro agora?", "Atenção!", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim form = New frmCadastro
                        form.ShowDialog()
                        Cancelar()
                    Catch ex As Exception
                    End Try

                End If
                Cancelar()
            End If
        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try
    End Sub

    Private Sub Cancelar()

        btsalvar2.Enabled = False
        btEditar.Enabled = False
        btExcluir.Enabled = False
        btLimpar.Enabled = False
        btNovo.Enabled = True
        btSalvar.Enabled = False
        PaiSolcitacao.Enabled = False
        CbClientes.Text = ""
        CbTecnico.Text = ""
        TxtDescricao.Text = ""
        TxtEntrada.Text = ""
        TxtProduto.Text = ""
        TxtSaida.Text = ""
        TxtSerie.Text = ""
        TxtParecer.Text = ""
        TxtValor.Text = ""
        CbStatus.Text = ""
    End Sub

    Private Sub buscar()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where Id_cliente LIKE '" & txtBuscar.Text & "%' order by Id_cliente asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        DgSolicitacao.DataSource = dt2


    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles btSalvar.Click
        If TxtDescricao.Text <> "" And TxtProduto.Text <> "" And CbClientes.ValueMember <> "" And CbTecnico.ValueMember <> "" Then

            ' data completa

            Dim data As String
            data = Now.ToString("yyy-MM-dd")

            'data somente ano

            Dim ano As String
            ano = Now.ToString("yyy")


            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO chamado ( Id_cliente, Produto, NumeroSerie, DataEntrada, DataSaida, Descricao, Id_Tecnico, Ano) VALUES ('" & CbClientes.Text & "', '" & TxtProduto.Text & "','" & TxtSerie.Text & "', '" & data & "', '" & TxtSaida.Text & "', '" & TxtDescricao.Text & "', '" & CbTecnico.Text & "', '" & ano & "')"
                cmd = New MySqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos!")
            Catch ex As Exception
                MsgBox("Erro ao salvar! " + ex.Message)
            End Try
            btEditar.Enabled = False
            btExcluir.Enabled = False
            Listar()
            Cancelar()
            Cancelar()
            Listar()
        Else
            MsgBox("Prencha os campos: Cliente, Técnico, Descrição e Produto.!", vbYes, "Atenção!")

        End If
    End Sub

    Private Sub btsalvar2_Click(sender As Object, e As EventArgs) Handles btsalvar2.Click

        If TxtDescricao.Text <> "" And TxtProduto.Text <> "" And CbClientes.ValueMember <> "" And CbTecnico.ValueMember <> "" Then

            Try

                Dim mes As String
                mes = Now.ToString("MM")


                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE chamado SET Id_cliente = '" & CbClientes.Text & "', Produto = '" & TxtProduto.Text & "',  NumeroSerie = '" & TxtSerie.Text & "',  DataSaida = '" & TxtSaida.Text & "', Descricao = '" & TxtDescricao.Text & "', Id_Tecnico = '" & CbTecnico.Text & "',Id_Tecnico = '" & CbTecnico.Text & "',Status = '" & CbStatus.Text & "', ParecerTecnico = '" & TxtParecer.Text & "', Valor = '" & TxtValor.Text & "', mes = '" & mes & "' where Id_produto = '" & txtId.Text & "'"
                cmd = New MySqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Editados!")
                Listar()


            Catch ex As Exception

                MsgBox("Erro ao salvar! " + ex.Message)

            End Try

            btSalvar.Enabled = True
            btSalvar.Visible = True
            btsalvar2.Enabled = False
            btsalvar2.Visible = False
            btEditar.Enabled = False
            btExcluir.Enabled = False
            Listar()
            Cancelar()

        Else

            MsgBox("Prencha os campos: Cliente, Técnico, Descrição e Produto.!", vbYes, "Atenção!")

        End If



    End Sub

    Private Sub FormatarDG()
        txtId.Text = DgSolicitacao.CurrentRow.Cells(0).Value
        CbClientes.Text = DgSolicitacao.CurrentRow.Cells(1).Value
        TxtProduto.Text = DgSolicitacao.CurrentRow.Cells(2).Value
        TxtSerie.Text = DgSolicitacao.CurrentRow.Cells(3).Value
        TxtEntrada.Text = DgSolicitacao.CurrentRow.Cells(4).Value
        TxtSaida.Text = DgSolicitacao.CurrentRow.Cells(5).Value
        TxtDescricao.Text = DgSolicitacao.CurrentRow.Cells(6).Value
        CbTecnico.Text = DgSolicitacao.CurrentRow.Cells(7).Value
        TxtParecer.Text = DgSolicitacao.CurrentRow.Cells(8).Value
        TxtValor.Text = DgSolicitacao.CurrentRow.Cells(9).Value
        CbStatus.Text = DgSolicitacao.CurrentRow.Cells(10).Value

        DgSolicitacao.Columns(0).Visible = False
        DgSolicitacao.Columns(1).HeaderText = "Nome"
        DgSolicitacao.Columns(3).HeaderText = "Número de Serie"
        DgSolicitacao.Columns(4).HeaderText = "Data de entrada"
        DgSolicitacao.Columns(5).HeaderText = "Data de saida"
        DgSolicitacao.Columns(6).Visible = False
        DgSolicitacao.Columns(7).Visible = False
        DgSolicitacao.Columns(8).Visible = False
        DgSolicitacao.Columns(9).Visible = False
        DgSolicitacao.Columns(10).Visible = False
        DgSolicitacao.Columns(11).Visible = False
        DgSolicitacao.Columns(12).Visible = False

        DgSolicitacao.Columns(1).Width = 180
        DgSolicitacao.Columns(3).Width = 200
        DgSolicitacao.Columns(4).Width = 118
        DgSolicitacao.Columns(5).Width = 118
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        PaiSolcitacao.Enabled = True


    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        If txtId.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Solicitação?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM chamado where Id_produto = '" & txtId.Text & "' "
                    cmd = New MySqlCommand(sql, conexao)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Excluido!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir! " + ex.Message)
                End Try
                Listar()
                Cancelar()
                btsalvar2.Enabled = False
                btsalvar2.Visible = False
                btSalvar.Visible = True
                btSalvar.Enabled = False
                btEditar.Enabled = False
                btExcluir.Enabled = False
            End If

        Else

        End If
        Cancelar()
        btsalvar2.Enabled = False
        btsalvar2.Visible = False
        btSalvar.Visible = True
        btSalvar.Enabled = False
        btEditar.Enabled = False
        btExcluir.Enabled = False
        btLimpar.Enabled = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub DgSolicitacao_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSolicitacao.CellClick

        CarregarClientes()
        CarregarTecnicos()
        Status()

        btEditar.Enabled = True
        btExcluir.Enabled = True
        btLimpar.Enabled = True
        btsalvar2.Enabled = True
        btsalvar2.Visible = True
        btSalvar.Visible = False
        btSalvar.Visible = False
        FormatarDG()
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        Cancelar()

    End Sub

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        Dim form = New frmprodutos
        form.ShowDialog()
    End Sub
End Class


'Configuracao de botao




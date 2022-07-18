Imports MySqlConnector


' Carregando as informaçao
Public Class frmprodutos


    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from chamado order by Produto desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dgPedidos.DataSource = dt
            'Dim total As Integer = dgPedidos.Rows.Count
            'lblRegistros.Text = total

        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub

    Private Sub frmprodutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarClientes()
        CarregarTecnicos()
        Listar()
        FormatarDG()

    End Sub
    Private Sub Cancelar()

        btNovo.Enabled = True
        BtSalvar.Enabled = False
        PaiSolcitacao.Enabled = False
        CbClientes.Text = ""
        CbTecnico.Text = ""
        TxtDescricao.Text = ""
        TxtEntrada.Text = ""
        TxtProduto.Text = ""
        TxtSaida.Text = ""
        TxtSerie.Text = ""

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

    Private Sub buscar()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where Id_cliente LIKE '" & txtBuscar.Text & "%' order by Id_cliente asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        dgPedidos.DataSource = dt2


    End Sub



    ' ##############

    ' Configuracao dos botao

    Private Sub btNovo_Click(sender As Object, e As EventArgs) Handles btNovo.Click
        PaiSolcitacao.Enabled = True
        BtSalvar.Enabled = True
        btCancelar.Enabled = True
        btNovo.Enabled = False
        CarregarClientes()
        CarregarTecnicos()
        CbClientes.Text = ""
        CbTecnico.Text = ""
        TxtDescricao.Text = ""
        TxtEntrada.Text = ""
        TxtProduto.Text = ""
        TxtSaida.Text = ""
        TxtSerie.Text = ""


    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Cancelar()
        btsalvar2.Enabled = False
        btsalvar2.Visible = False
        BtSalvar.Visible = True
        BtSalvar.Enabled = False
        btEditar.Enabled = False
        btExcluir.Enabled = False

    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click
        If TxtDescricao.Text <> "" And TxtProduto.Text <> "" And CbClientes.ValueMember <> "" And CbTecnico.ValueMember <> "" Then

            'data completa
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
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE chamado SET Id_cliente = '" & CbClientes.Text & "', Produto = '" & TxtProduto.Text & "',  NumeroSerie = '" & TxtSerie.Text & "',  DataSaida = '" & TxtSaida.Text & "', Descricao = '" & TxtDescricao.Text & "', Id_Tecnico = '" & CbTecnico.Text & "' where Id_produto = '" & txtId.Text & "'"
                cmd = New MySqlCommand(sql, conexao)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Editados!")
                Listar()


            Catch ex As Exception

                MsgBox("Erro ao salvar! " + ex.Message)

            End Try

            BtSalvar.Enabled = True
            BtSalvar.Visible = True
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

    Private Sub dgPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPedidos.CellClick
        btEditar.Enabled = True
        btExcluir.Enabled = True
        btCancelar.Enabled = True
        btsalvar2.Enabled = True
        btsalvar2.Visible = True
        BtSalvar.Visible = False
        BtSalvar.Visible = False
        FormatarDG()

    End Sub


    Private Sub FormatarDG()
        txtId.Text = dgPedidos.CurrentRow.Cells(0).Value
        CbClientes.Text = dgPedidos.CurrentRow.Cells(1).Value
        TxtProduto.Text = dgPedidos.CurrentRow.Cells(2).Value
        TxtSerie.Text = dgPedidos.CurrentRow.Cells(3).Value
        TxtEntrada.Text = dgPedidos.CurrentRow.Cells(4).Value
        TxtSaida.Text = dgPedidos.CurrentRow.Cells(5).Value
        TxtDescricao.Text = dgPedidos.CurrentRow.Cells(6).Value
        CbTecnico.Text = dgPedidos.CurrentRow.Cells(7).Value

        dgPedidos.Columns(0).Visible = False
        dgPedidos.Columns(1).HeaderText = "Nome"
        dgPedidos.Columns(3).HeaderText = "Número de Serie"
        dgPedidos.Columns(4).HeaderText = "Data de entrada"
        dgPedidos.Columns(5).HeaderText = "Data de saida"
        dgPedidos.Columns(6).Visible = False
        dgPedidos.Columns(7).Visible = False
        dgPedidos.Columns(8).Visible = False
        dgPedidos.Columns(9).Visible = False
        dgPedidos.Columns(10).Visible = False
        dgPedidos.Columns(11).Visible = False
        dgPedidos.Columns(12).Visible = False

        dgPedidos.Columns(1).Width = 180
        dgPedidos.Columns(3).Width = 130
        dgPedidos.Columns(4).Width = 130
        dgPedidos.Columns(5).Width = 130



    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        PaiSolcitacao.Enabled = True

    End Sub

    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles btExcluir.Click
        If txtId.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro?", MessageBoxButtons.YesNo)
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
                BtSalvar.Visible = True
                BtSalvar.Enabled = False
                btEditar.Enabled = False
                btExcluir.Enabled = False
            End If

        Else

        End If
        Cancelar()
        btsalvar2.Enabled = False
        btsalvar2.Visible = False
        BtSalvar.Visible = True
        BtSalvar.Enabled = False
        btEditar.Enabled = False
        btExcluir.Enabled = False
        btCancelar.Enabled = False
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

End Class
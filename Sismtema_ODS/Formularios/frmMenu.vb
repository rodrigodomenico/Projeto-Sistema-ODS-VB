Imports MySqlConnector

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCargo.Text = CargoUsuario
        TxtNome2.Text = nomeUsuario
        Listar()
        FormatarDG()
        Status()

        'apreseta o erro caso não efetue a conexao

        Try
            abrir()
        Catch ex As Exception
            MsgBox("Erro ao se conectar! " + ex.Message)
        End Try

        If TxtCargo.Text = "Administrador" Then

        Else
            BtCadastro.Enabled = False
            BtCadAdm.Enabled = False
            BtCaixa.Enabled = False
        End If

    End Sub




    Private Sub btEntrar_Click(sender As Object, e As EventArgs) Handles BtClientes.Click
        Dim form = New frmcategorias
        form.ShowDialog()
    End Sub

    Private Sub BtSolicitacao_Click(sender As Object, e As EventArgs) Handles BtSolicitacao.Click
        Dim form = New frmprodutos
        form.ShowDialog()
    End Sub

    Private Sub BtCadastro_Click(sender As Object, e As EventArgs) Handles BtCadastro.Click
        Dim form = New frmCadastro
        form.ShowDialog()
    End Sub


    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from chamado order by Produto desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg.DataSource = dt
            Dim total As Integer = dg.Rows.Count
            lbltext.Text = total

        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarDG()

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(4).HeaderText = "Entrada"
        dg.Columns(5).HeaderText = "Saída"
        dg.Columns(10).HeaderText = "Status"

        dg.Columns(0).Visible = False
        dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(11).Visible = False
        dg.Columns(12).Visible = False



        dg.Columns(1).Width = 322
        dg.Columns(2).Width = 322
        dg.Columns(4).Width = 322
        dg.Columns(5).Width = 200
        dg.Columns(10).Width = 202

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
                    Catch ex As Exception
                    End Try
                End If

            End If
        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try


    End Sub


    Private Sub buscarDg()
        If CbStatus.Text = "" Then
            Listar()
        Else
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * FROM chamado where Status LIKE '" & CbStatus.Text & "%' order by Status asc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            dg.DataSource = dt
            FormatarDG()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        buscarDg()
        Dim total As Integer = dg.Rows.Count
        lbltext.Text = total
        txtlbl.Text = CbStatus.Text
        If CbStatus.Text = "" Then
            txtlbl.Text = "Solicitações"
        End If
    End Sub

    Private Sub buscar()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where Id_cliente LIKE '" & txtBuscar.Text & "%' order by Id_cliente asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        dg.DataSource = dt2


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub BtCaixa_Click(sender As Object, e As EventArgs) Handles BtCadAdm.Click
        Dim form = New FrmCadColab
        form.ShowDialog()
    End Sub


    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Administrador()

    End Sub

    Private Sub Tecnico()

    End Sub

    Private Sub Caixa_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Caixa_Click_1(sender As Object, e As EventArgs) Handles BtCaixa.Click
        Dim form = New frmcaixa
        form.ShowDialog()
    End Sub

    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStatus.SelectedIndexChanged

    End Sub
End Class

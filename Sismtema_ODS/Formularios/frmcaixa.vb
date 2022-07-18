Imports MySqlConnector

Public Class frmcaixa
    Private Sub DgSolicitacao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSol.CellContentClick

    End Sub

    Private Sub Listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from chamado order by DataEntrada desc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            DgSol.DataSource = dt
            'Dim total As Integer = dgPedidos.Rows.Count
            'lblRegistros.Text = total

        Catch ex As Exception
            MsgBox("Erro ao listar! " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarDG()
        DgSol.Columns(0).Visible = False
        DgSol.Columns(1).HeaderText = "Nome"
        DgSol.Columns(3).HeaderText = "Número de Serie"
        DgSol.Columns(5).HeaderText = "Data de saida"
        DgSol.Columns(6).Visible = False
        DgSol.Columns(7).Visible = False
        DgSol.Columns(8).Visible = False
        DgSol.Columns(9).Visible = True
        DgSol.Columns(10).Visible = False
        DgSol.Columns(4).Visible = False
        DgSol.Columns(11).Visible = False
        DgSol.Columns(12).Visible = False

        DgSol.Columns(1).Width = 190
        DgSol.Columns(3).Width = 210
        DgSol.Columns(5).Width = 120
    End Sub


    Private Sub buscar()

        Dim status As String
        status = "Finalizada"

        If status = "" Then
            Listar()
        Else
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * FROM chamado where Status LIKE '" & status & "%' order by Status asc"
            da = New MySqlDataAdapter(sql, conexao)
            da.Fill(dt)
            DgSol.DataSource = dt
            FormatarDG()

        End If

    End Sub

    Public Sub SomarValor()
        Dim linha As DataGridViewRow
        Dim valor As Double

        For Each linha In DgSol.Rows
            valor = valor + linha.Cells(9).Value

        Next

        TxtTotal.Text = valor

    End Sub

    ' CARREGAR DADOS
    Private Sub frmcaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        buscar()
        SomarValor()
        TxtData.Enabled = True
    End Sub

    Private Sub btLimpar_Click(sender As Object, e As EventArgs) Handles btLimpar.Click
        FormatarDG()
    End Sub


    Private Sub buscar4()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where Ano LIKE '%" & TxtAno.Text & "%' order by Ano asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        DgSol.DataSource = dt2
        SomarValor()
    End Sub
    Private Sub buscar3()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where Mes LIKE '%" & TxtMes.Text & "%' order by Mes asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        DgSol.DataSource = dt2
        SomarValor()
    End Sub

    Private Sub buscar2()

        abrir()
        Dim dt2 As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * FROM chamado where DataSaida LIKE '" & TxtData.Text & "%' order by DataSaida asc"
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(dt2)
        DgSol.DataSource = dt2
        SomarValor()
    End Sub


    ' CONFIGURACAO DE BOTAO

    Private Sub TxtData_TextChanged(sender As Object, e As EventArgs) Handles TxtData.TextChanged
        buscar2()
    End Sub

    Private Sub TxtMes_TextChanged(sender As Object, e As EventArgs) Handles TxtMes.TextChanged
        buscar3()
    End Sub

    Private Sub TxtAno_TextChanged(sender As Object, e As EventArgs) Handles TxtAno.TextChanged
        buscar4()
    End Sub
End Class

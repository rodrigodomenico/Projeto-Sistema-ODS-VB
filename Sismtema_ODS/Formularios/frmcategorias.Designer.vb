<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcategorias
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DgSolicitacao = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.btsalvar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PaiSolcitacao = New System.Windows.Forms.Panel()
        Me.TxtParecer = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.CbTecnico = New System.Windows.Forms.ComboBox()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.CbClientes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEntrada = New System.Windows.Forms.TextBox()
        Me.TxtSaida = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        CType(Me.DgSolicitacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaiSolcitacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgSolicitacao
        '
        Me.DgSolicitacao.AllowUserToAddRows = False
        Me.DgSolicitacao.AllowUserToDeleteRows = False
        Me.DgSolicitacao.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DgSolicitacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgSolicitacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSolicitacao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgSolicitacao.Location = New System.Drawing.Point(12, 446)
        Me.DgSolicitacao.Name = "DgSolicitacao"
        Me.DgSolicitacao.ReadOnly = True
        Me.DgSolicitacao.RowTemplate.Height = 25
        Me.DgSolicitacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgSolicitacao.Size = New System.Drawing.Size(749, 154)
        Me.DgSolicitacao.TabIndex = 2
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(661, 11)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.txtBuscar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(619, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(698, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(63, 23)
        Me.txtId.TabIndex = 1
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.SystemColors.Window
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNovo.Location = New System.Drawing.Point(12, 606)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 23)
        Me.btNovo.TabIndex = 4
        Me.btNovo.Text = "Novo"
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.SystemColors.Window
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.Enabled = False
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSalvar.Location = New System.Drawing.Point(104, 606)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btSalvar.TabIndex = 5
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.SystemColors.Window
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.Enabled = False
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEditar.Location = New System.Drawing.Point(605, 606)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 23)
        Me.btEditar.TabIndex = 6
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.SystemColors.Window
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btExcluir.Location = New System.Drawing.Point(686, 606)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btExcluir.TabIndex = 7
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Enabled = False
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLimpar.Location = New System.Drawing.Point(686, 70)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpar.TabIndex = 8
        Me.btLimpar.Text = "Cancelar"
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'btsalvar2
        '
        Me.btsalvar2.BackColor = System.Drawing.SystemColors.Window
        Me.btsalvar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsalvar2.Enabled = False
        Me.btsalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btsalvar2.Location = New System.Drawing.Point(104, 606)
        Me.btsalvar2.Name = "btsalvar2"
        Me.btsalvar2.Size = New System.Drawing.Size(75, 23)
        Me.btsalvar2.TabIndex = 11
        Me.btsalvar2.Text = "Salvar"
        Me.btsalvar2.UseVisualStyleBackColor = False
        Me.btsalvar2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(677, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'PaiSolcitacao
        '
        Me.PaiSolcitacao.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaiSolcitacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaiSolcitacao.Controls.Add(Me.TxtParecer)
        Me.PaiSolcitacao.Controls.Add(Me.TxtDescricao)
        Me.PaiSolcitacao.Controls.Add(Me.CbTecnico)
        Me.PaiSolcitacao.Controls.Add(Me.CbStatus)
        Me.PaiSolcitacao.Controls.Add(Me.CbClientes)
        Me.PaiSolcitacao.Controls.Add(Me.Label12)
        Me.PaiSolcitacao.Controls.Add(Me.Label11)
        Me.PaiSolcitacao.Controls.Add(Me.Label3)
        Me.PaiSolcitacao.Controls.Add(Me.Label4)
        Me.PaiSolcitacao.Controls.Add(Me.Label6)
        Me.PaiSolcitacao.Controls.Add(Me.Label5)
        Me.PaiSolcitacao.Controls.Add(Me.Label7)
        Me.PaiSolcitacao.Controls.Add(Me.Label10)
        Me.PaiSolcitacao.Controls.Add(Me.Label8)
        Me.PaiSolcitacao.Controls.Add(Me.Label9)
        Me.PaiSolcitacao.Controls.Add(Me.TxtEntrada)
        Me.PaiSolcitacao.Controls.Add(Me.TxtSaida)
        Me.PaiSolcitacao.Controls.Add(Me.TxtValor)
        Me.PaiSolcitacao.Controls.Add(Me.TxtSerie)
        Me.PaiSolcitacao.Controls.Add(Me.TxtProduto)
        Me.PaiSolcitacao.Enabled = False
        Me.PaiSolcitacao.Location = New System.Drawing.Point(12, 99)
        Me.PaiSolcitacao.Name = "PaiSolcitacao"
        Me.PaiSolcitacao.Size = New System.Drawing.Size(749, 341)
        Me.PaiSolcitacao.TabIndex = 38
        '
        'TxtParecer
        '
        Me.TxtParecer.Location = New System.Drawing.Point(18, 225)
        Me.TxtParecer.Multiline = True
        Me.TxtParecer.Name = "TxtParecer"
        Me.TxtParecer.Size = New System.Drawing.Size(708, 109)
        Me.TxtParecer.TabIndex = 6
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Enabled = False
        Me.TxtDescricao.Location = New System.Drawing.Point(21, 113)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(708, 91)
        Me.TxtDescricao.TabIndex = 6
        '
        'CbTecnico
        '
        Me.CbTecnico.Enabled = False
        Me.CbTecnico.FormattingEnabled = True
        Me.CbTecnico.Location = New System.Drawing.Point(579, 53)
        Me.CbTecnico.MaxDropDownItems = 5
        Me.CbTecnico.Name = "CbTecnico"
        Me.CbTecnico.Size = New System.Drawing.Size(163, 23)
        Me.CbTecnico.TabIndex = 18
        '
        'CbStatus
        '
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Location = New System.Drawing.Point(300, 82)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(176, 23)
        Me.CbStatus.TabIndex = 1
        '
        'CbClientes
        '
        Me.CbClientes.Enabled = False
        Me.CbClientes.FormattingEnabled = True
        Me.CbClientes.Location = New System.Drawing.Point(69, 21)
        Me.CbClientes.Name = "CbClientes"
        Me.CbClientes.Size = New System.Drawing.Size(176, 23)
        Me.CbClientes.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(252, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Parecer Técnico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Descrição:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Entrada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Saida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Técnico:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(542, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Valor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(481, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Número de série:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Produto:"
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Enabled = False
        Me.TxtEntrada.Location = New System.Drawing.Point(69, 54)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(176, 23)
        Me.TxtEntrada.TabIndex = 2
        '
        'TxtSaida
        '
        Me.TxtSaida.Location = New System.Drawing.Point(300, 53)
        Me.TxtSaida.Name = "TxtSaida"
        Me.TxtSaida.Size = New System.Drawing.Size(176, 23)
        Me.TxtSaida.TabIndex = 7
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(579, 82)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(163, 23)
        Me.TxtValor.TabIndex = 4
        '
        'TxtSerie
        '
        Me.TxtSerie.Enabled = False
        Me.TxtSerie.Location = New System.Drawing.Point(579, 24)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(163, 23)
        Me.TxtSerie.TabIndex = 4
        '
        'TxtProduto
        '
        Me.TxtProduto.Enabled = False
        Me.TxtProduto.Location = New System.Drawing.Point(300, 21)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(176, 23)
        Me.TxtProduto.TabIndex = 3
        '
        'frmcategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(776, 645)
        Me.Controls.Add(Me.PaiSolcitacao)
        Me.Controls.Add(Me.btsalvar2)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btSalvar)
        Me.Controls.Add(Me.btNovo)
        Me.Controls.Add(Me.DgSolicitacao)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmcategorias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DgSolicitacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaiSolcitacao.ResumeLayout(False)
        Me.PaiSolcitacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btNovo As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btLimpar As Button
    Friend WithEvents btsalvar2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DgSolicitacao As DataGridView
    Friend WithEvents PaiSolcitacao As Panel
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents CbTecnico As ComboBox
    Friend WithEvents CbClientes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtEntrada As TextBox
    Friend WithEvents TxtSaida As TextBox
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents TxtParecer As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents Label12 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmprodutos
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
        Me.dgPedidos = New System.Windows.Forms.DataGridView()
        Me.btsalvar2 = New System.Windows.Forms.Button()
        Me.btExcluir = New System.Windows.Forms.Button()
        Me.btEditar = New System.Windows.Forms.Button()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.PaiSolcitacao = New System.Windows.Forms.Panel()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.CbTecnico = New System.Windows.Forms.ComboBox()
        Me.CbClientes = New System.Windows.Forms.ComboBox()
        Me.txt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEntrada = New System.Windows.Forms.TextBox()
        Me.TxtSaida = New System.Windows.Forms.TextBox()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtSalvar = New System.Windows.Forms.Button()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaiSolcitacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgPedidos
        '
        Me.dgPedidos.AllowUserToAddRows = False
        Me.dgPedidos.AllowUserToDeleteRows = False
        Me.dgPedidos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPedidos.GridColor = System.Drawing.Color.Black
        Me.dgPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgPedidos.Location = New System.Drawing.Point(36, 387)
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.ReadOnly = True
        Me.dgPedidos.RowTemplate.Height = 25
        Me.dgPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPedidos.Size = New System.Drawing.Size(735, 168)
        Me.dgPedidos.TabIndex = 31
        '
        'btsalvar2
        '
        Me.btsalvar2.BackColor = System.Drawing.SystemColors.Window
        Me.btsalvar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btsalvar2.Enabled = False
        Me.btsalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btsalvar2.Location = New System.Drawing.Point(117, 566)
        Me.btsalvar2.Name = "btsalvar2"
        Me.btsalvar2.Size = New System.Drawing.Size(75, 23)
        Me.btsalvar2.TabIndex = 30
        Me.btsalvar2.Text = "Salvar"
        Me.btsalvar2.UseVisualStyleBackColor = False
        Me.btsalvar2.Visible = False
        '
        'btExcluir
        '
        Me.btExcluir.BackColor = System.Drawing.SystemColors.Window
        Me.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btExcluir.Enabled = False
        Me.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btExcluir.Location = New System.Drawing.Point(696, 566)
        Me.btExcluir.Name = "btExcluir"
        Me.btExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btExcluir.TabIndex = 29
        Me.btExcluir.Text = "Excluir"
        Me.btExcluir.UseVisualStyleBackColor = False
        '
        'btEditar
        '
        Me.btEditar.BackColor = System.Drawing.SystemColors.Window
        Me.btEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btEditar.Enabled = False
        Me.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btEditar.Location = New System.Drawing.Point(615, 566)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 23)
        Me.btEditar.TabIndex = 28
        Me.btEditar.Text = "Editar"
        Me.btEditar.UseVisualStyleBackColor = False
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.SystemColors.Window
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btNovo.Location = New System.Drawing.Point(36, 566)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(75, 23)
        Me.btNovo.TabIndex = 27
        Me.btNovo.Text = "Novo"
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(669, 37)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.txtBuscar.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(627, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Buscar:"
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.SystemColors.Window
        Me.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCancelar.Enabled = False
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelar.Location = New System.Drawing.Point(694, 92)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(75, 21)
        Me.btCancelar.TabIndex = 32
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'PaiSolcitacao
        '
        Me.PaiSolcitacao.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaiSolcitacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaiSolcitacao.Controls.Add(Me.TxtDescricao)
        Me.PaiSolcitacao.Controls.Add(Me.CbTecnico)
        Me.PaiSolcitacao.Controls.Add(Me.CbClientes)
        Me.PaiSolcitacao.Controls.Add(Me.txt)
        Me.PaiSolcitacao.Controls.Add(Me.Label1)
        Me.PaiSolcitacao.Controls.Add(Me.Label6)
        Me.PaiSolcitacao.Controls.Add(Me.Label5)
        Me.PaiSolcitacao.Controls.Add(Me.Label7)
        Me.PaiSolcitacao.Controls.Add(Me.Label2)
        Me.PaiSolcitacao.Controls.Add(Me.Label4)
        Me.PaiSolcitacao.Controls.Add(Me.TxtEntrada)
        Me.PaiSolcitacao.Controls.Add(Me.TxtSaida)
        Me.PaiSolcitacao.Controls.Add(Me.TxtSerie)
        Me.PaiSolcitacao.Controls.Add(Me.TxtProduto)
        Me.PaiSolcitacao.Enabled = False
        Me.PaiSolcitacao.Location = New System.Drawing.Point(36, 119)
        Me.PaiSolcitacao.Name = "PaiSolcitacao"
        Me.PaiSolcitacao.Size = New System.Drawing.Size(735, 262)
        Me.PaiSolcitacao.TabIndex = 37
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(21, 113)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(694, 142)
        Me.TxtDescricao.TabIndex = 6
        '
        'CbTecnico
        '
        Me.CbTecnico.FormattingEnabled = True
        Me.CbTecnico.Location = New System.Drawing.Point(566, 53)
        Me.CbTecnico.MaxDropDownItems = 5
        Me.CbTecnico.Name = "CbTecnico"
        Me.CbTecnico.Size = New System.Drawing.Size(149, 23)
        Me.CbTecnico.TabIndex = 18
        '
        'CbClientes
        '
        Me.CbClientes.FormattingEnabled = True
        Me.CbClientes.Location = New System.Drawing.Point(69, 21)
        Me.CbClientes.Name = "CbClientes"
        Me.CbClientes.Size = New System.Drawing.Size(162, 23)
        Me.CbClientes.TabIndex = 1
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(21, 24)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(47, 15)
        Me.txt.TabIndex = 14
        Me.txt.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Descrição:"
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
        Me.Label7.Location = New System.Drawing.Point(515, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Técnico:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Número de série:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Produto:"
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Enabled = False
        Me.TxtEntrada.Location = New System.Drawing.Point(69, 54)
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(162, 23)
        Me.TxtEntrada.TabIndex = 2
        '
        'TxtSaida
        '
        Me.TxtSaida.Enabled = False
        Me.TxtSaida.Location = New System.Drawing.Point(300, 53)
        Me.TxtSaida.Name = "TxtSaida"
        Me.TxtSaida.Size = New System.Drawing.Size(162, 23)
        Me.TxtSaida.TabIndex = 7
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(566, 24)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(149, 23)
        Me.TxtSerie.TabIndex = 4
        '
        'TxtProduto
        '
        Me.TxtProduto.Location = New System.Drawing.Point(300, 21)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(162, 23)
        Me.TxtProduto.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(669, 63)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(648, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ID:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(207, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(381, 60)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "ENTRADA E SAÍDA DE EQUIPAMENTOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtSalvar
        '
        Me.BtSalvar.BackColor = System.Drawing.SystemColors.Window
        Me.BtSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSalvar.Enabled = False
        Me.BtSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSalvar.Location = New System.Drawing.Point(117, 566)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtSalvar.TabIndex = 30
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.UseVisualStyleBackColor = False
        '
        'frmprodutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 611)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PaiSolcitacao)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.dgPedidos)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.btsalvar2)
        Me.Controls.Add(Me.btExcluir)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.btNovo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmprodutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entra e saída de equipamentos"
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaiSolcitacao.ResumeLayout(False)
        Me.PaiSolcitacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgPedidos As DataGridView
    Friend WithEvents btsalvar2 As Button
    Friend WithEvents btExcluir As Button
    Friend WithEvents btEditar As Button
    Friend WithEvents btNovo As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btCancelar As Button
    Friend WithEvents PaiSolcitacao As Panel
    Friend WithEvents CbClientes As ComboBox
    Friend WithEvents txt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEntrada As TextBox
    Friend WithEvents TxtSaida As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CbTecnico As ComboBox
    Friend WithEvents BtSalvar As Button
End Class

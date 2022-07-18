<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastro

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtComp = New System.Windows.Forms.TextBox()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.TxtNascimento = New System.Windows.Forms.TextBox()
        Me.TxtCpf = New System.Windows.Forms.TextBox()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtnRua = New System.Windows.Forms.TextBox()
        Me.Txtidcliente = New System.Windows.Forms.TextBox()
        Me.TxtRua = New System.Windows.Forms.TextBox()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.TxtCep = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.BtSalvar = New System.Windows.Forms.Button()
        Me.BtExcluir = New System.Windows.Forms.Button()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.BtNovo = New System.Windows.Forms.Button()
        Me.BtSalvar2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(285, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(232, 30)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "CADASTO DE CLIENTES"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(669, 45)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(648, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtComp)
        Me.Panel1.Controls.Add(Me.TxtTelefone)
        Me.Panel1.Controls.Add(Me.TxtNascimento)
        Me.Panel1.Controls.Add(Me.TxtCpf)
        Me.Panel1.Controls.Add(Me.TxtGenero)
        Me.Panel1.Controls.Add(Me.TxtNome)
        Me.Panel1.Controls.Add(Me.TxtnRua)
        Me.Panel1.Controls.Add(Me.Txtidcliente)
        Me.Panel1.Controls.Add(Me.TxtRua)
        Me.Panel1.Controls.Add(Me.TxtData)
        Me.Panel1.Controls.Add(Me.TxtEstado)
        Me.Panel1.Controls.Add(Me.TxtBairro)
        Me.Panel1.Controls.Add(Me.TxtCidade)
        Me.Panel1.Controls.Add(Me.TxtCep)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(36, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 216)
        Me.Panel1.TabIndex = 51
        '
        'TxtComp
        '
        Me.TxtComp.Enabled = False
        Me.TxtComp.Location = New System.Drawing.Point(582, 52)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(125, 23)
        Me.TxtComp.TabIndex = 10
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Enabled = False
        Me.TxtTelefone.Location = New System.Drawing.Point(97, 139)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(133, 23)
        Me.TxtTelefone.TabIndex = 6
        '
        'TxtNascimento
        '
        Me.TxtNascimento.Enabled = False
        Me.TxtNascimento.Location = New System.Drawing.Point(97, 110)
        Me.TxtNascimento.Name = "TxtNascimento"
        Me.TxtNascimento.Size = New System.Drawing.Size(133, 23)
        Me.TxtNascimento.TabIndex = 5
        '
        'TxtCpf
        '
        Me.TxtCpf.AccessibleDescription = ""
        Me.TxtCpf.Enabled = False
        Me.TxtCpf.Location = New System.Drawing.Point(96, 81)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(134, 23)
        Me.TxtCpf.TabIndex = 4
        '
        'TxtGenero
        '
        Me.TxtGenero.Enabled = False
        Me.TxtGenero.Location = New System.Drawing.Point(98, 52)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(63, 23)
        Me.TxtGenero.TabIndex = 3
        '
        'TxtNome
        '
        Me.TxtNome.Enabled = False
        Me.TxtNome.Location = New System.Drawing.Point(97, 24)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(228, 23)
        Me.TxtNome.TabIndex = 1
        '
        'TxtnRua
        '
        Me.TxtnRua.Enabled = False
        Me.TxtnRua.Location = New System.Drawing.Point(652, 24)
        Me.TxtnRua.Name = "TxtnRua"
        Me.TxtnRua.Size = New System.Drawing.Size(54, 23)
        Me.TxtnRua.TabIndex = 8
        '
        'Txtidcliente
        '
        Me.Txtidcliente.Enabled = False
        Me.Txtidcliente.Location = New System.Drawing.Point(388, 168)
        Me.Txtidcliente.Name = "Txtidcliente"
        Me.Txtidcliente.Size = New System.Drawing.Size(54, 23)
        Me.Txtidcliente.TabIndex = 17
        '
        'TxtRua
        '
        Me.TxtRua.Enabled = False
        Me.TxtRua.Location = New System.Drawing.Point(388, 24)
        Me.TxtRua.Name = "TxtRua"
        Me.TxtRua.Size = New System.Drawing.Size(228, 23)
        Me.TxtRua.TabIndex = 7
        '
        'TxtData
        '
        Me.TxtData.Enabled = False
        Me.TxtData.Location = New System.Drawing.Point(98, 168)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(132, 23)
        Me.TxtData.TabIndex = 17
        '
        'TxtEstado
        '
        Me.TxtEstado.Enabled = False
        Me.TxtEstado.Location = New System.Drawing.Point(388, 139)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(319, 23)
        Me.TxtEstado.TabIndex = 13
        '
        'TxtBairro
        '
        Me.TxtBairro.Enabled = False
        Me.TxtBairro.Location = New System.Drawing.Point(388, 110)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(319, 23)
        Me.TxtBairro.TabIndex = 12
        '
        'TxtCidade
        '
        Me.TxtCidade.Enabled = False
        Me.TxtCidade.Location = New System.Drawing.Point(388, 81)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(319, 23)
        Me.TxtCidade.TabIndex = 11
        '
        'TxtCep
        '
        Me.TxtCep.Enabled = False
        Me.TxtCep.Location = New System.Drawing.Point(388, 52)
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(103, 23)
        Me.TxtCep.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(65, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CPF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nascimento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(43, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Telefone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Gênero:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nome Completo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(365, 171)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 15)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "ID:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(2, 171)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Data de cadastro:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(345, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Bairro:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(498, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 15)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Complemento:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(628, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Nº:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(342, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Estado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(340, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Cidade:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(357, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Cep:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rua:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(669, 19)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.TxtBuscar.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(627, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Buscar:"
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Enabled = False
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLimpar.Location = New System.Drawing.Point(694, 74)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(75, 21)
        Me.btLimpar.TabIndex = 46
        Me.btLimpar.Text = "Cancelar"
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'dg2
        '
        Me.dg2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        Me.dg2.AllowUserToResizeColumns = False
        Me.dg2.AllowUserToResizeRows = False
        Me.dg2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg2.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dg2.GridColor = System.Drawing.Color.Black
        Me.dg2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dg2.Location = New System.Drawing.Point(34, 318)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg2.RowHeadersVisible = False
        Me.dg2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dg2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dg2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dg2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Azure
        Me.dg2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dg2.RowTemplate.Height = 25
        Me.dg2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg2.ShowRowErrors = False
        Me.dg2.Size = New System.Drawing.Size(735, 215)
        Me.dg2.TabIndex = 45
        '
        'BtSalvar
        '
        Me.BtSalvar.BackColor = System.Drawing.SystemColors.Window
        Me.BtSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSalvar.Enabled = False
        Me.BtSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSalvar.Location = New System.Drawing.Point(117, 539)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtSalvar.TabIndex = 14
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.UseVisualStyleBackColor = False
        '
        'BtExcluir
        '
        Me.BtExcluir.BackColor = System.Drawing.SystemColors.Window
        Me.BtExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtExcluir.Enabled = False
        Me.BtExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtExcluir.Location = New System.Drawing.Point(696, 539)
        Me.BtExcluir.Name = "BtExcluir"
        Me.BtExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtExcluir.TabIndex = 17
        Me.BtExcluir.Text = "Excluir"
        Me.BtExcluir.UseVisualStyleBackColor = False
        '
        'BtEditar
        '
        Me.BtEditar.BackColor = System.Drawing.SystemColors.Window
        Me.BtEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEditar.Enabled = False
        Me.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEditar.Location = New System.Drawing.Point(615, 539)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtEditar.TabIndex = 16
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = False
        '
        'BtNovo
        '
        Me.BtNovo.BackColor = System.Drawing.SystemColors.Window
        Me.BtNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtNovo.Location = New System.Drawing.Point(36, 539)
        Me.BtNovo.Name = "BtNovo"
        Me.BtNovo.Size = New System.Drawing.Size(75, 23)
        Me.BtNovo.TabIndex = 15
        Me.BtNovo.Text = "Novo"
        Me.BtNovo.UseVisualStyleBackColor = False
        '
        'BtSalvar2
        '
        Me.BtSalvar2.BackColor = System.Drawing.SystemColors.Window
        Me.BtSalvar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSalvar2.Enabled = False
        Me.BtSalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSalvar2.Location = New System.Drawing.Point(117, 539)
        Me.BtSalvar2.Name = "BtSalvar2"
        Me.BtSalvar2.Size = New System.Drawing.Size(75, 23)
        Me.BtSalvar2.TabIndex = 14
        Me.BtSalvar2.Text = "Salvar"
        Me.BtSalvar2.UseVisualStyleBackColor = False
        Me.BtSalvar2.Visible = False
        '
        'frmCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(816, 600)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.BtSalvar2)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.BtExcluir)
        Me.Controls.Add(Me.BtEditar)
        Me.Controls.Add(Me.BtNovo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtComp As TextBox
    Friend WithEvents TxtnRua As TextBox
    Friend WithEvents TxtRua As TextBox
    Friend WithEvents TxtCep As TextBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btLimpar As Button
    Friend WithEvents dg2 As DataGridView
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents TxtNascimento As TextBox
    Friend WithEvents TxtCpf As TextBox
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtidcliente As TextBox
    Friend WithEvents TxtData As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents TxtCidade As TextBox

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadColab
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbCargo = New System.Windows.Forms.ComboBox()
        Me.BtSenha2 = New System.Windows.Forms.Button()
        Me.BtSenha = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Txtlavel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.TxtNascimento = New System.Windows.Forms.TextBox()
        Me.TxtCpf = New System.Windows.Forms.TextBox()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtComp = New System.Windows.Forms.TextBox()
        Me.TxtnRua = New System.Windows.Forms.TextBox()
        Me.Txtidcolaborador = New System.Windows.Forms.TextBox()
        Me.TxtRua = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.TxtCep = New System.Windows.Forms.TextBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.txtlbl = New System.Windows.Forms.Label()
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
        Me.Label16.Location = New System.Drawing.Point(203, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(317, 30)
        Me.Label16.TabIndex = 69
        Me.Label16.Text = "CADASTO DE COLABORADORES"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(646, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(625, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CbCargo)
        Me.Panel1.Controls.Add(Me.BtSenha2)
        Me.Panel1.Controls.Add(Me.BtSenha)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Txtlavel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtTelefone)
        Me.Panel1.Controls.Add(Me.TxtNascimento)
        Me.Panel1.Controls.Add(Me.TxtCpf)
        Me.Panel1.Controls.Add(Me.TxtGenero)
        Me.Panel1.Controls.Add(Me.TxtNome)
        Me.Panel1.Controls.Add(Me.TxtComp)
        Me.Panel1.Controls.Add(Me.TxtnRua)
        Me.Panel1.Controls.Add(Me.Txtidcolaborador)
        Me.Panel1.Controls.Add(Me.TxtRua)
        Me.Panel1.Controls.Add(Me.TxtSenha)
        Me.Panel1.Controls.Add(Me.TxtLogin)
        Me.Panel1.Controls.Add(Me.TxtData)
        Me.Panel1.Controls.Add(Me.TxtEstado)
        Me.Panel1.Controls.Add(Me.TxtBairro)
        Me.Panel1.Controls.Add(Me.TxtCidade)
        Me.Panel1.Controls.Add(Me.TxtCep)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(13, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 258)
        Me.Panel1.TabIndex = 66
        '
        'CbCargo
        '
        Me.CbCargo.FormattingEnabled = True
        Me.CbCargo.Location = New System.Drawing.Point(390, 217)
        Me.CbCargo.Name = "CbCargo"
        Me.CbCargo.Size = New System.Drawing.Size(320, 23)
        Me.CbCargo.TabIndex = 73
        '
        'BtSenha2
        '
        Me.BtSenha2.BackColor = System.Drawing.SystemColors.Window
        Me.BtSenha2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSenha2.Enabled = False
        Me.BtSenha2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSenha2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtSenha2.Location = New System.Drawing.Point(677, 187)
        Me.BtSenha2.Name = "BtSenha2"
        Me.BtSenha2.Size = New System.Drawing.Size(31, 24)
        Me.BtSenha2.TabIndex = 72
        Me.BtSenha2.Text = "(o)"
        Me.BtSenha2.UseVisualStyleBackColor = False
        Me.BtSenha2.Visible = False
        '
        'BtSenha
        '
        Me.BtSenha.BackColor = System.Drawing.SystemColors.Window
        Me.BtSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSenha.Location = New System.Drawing.Point(677, 188)
        Me.BtSenha.Name = "BtSenha"
        Me.BtSenha.Size = New System.Drawing.Size(32, 23)
        Me.BtSenha.TabIndex = 71
        Me.BtSenha.Text = "(x)"
        Me.BtSenha.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CPF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Nascimento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Telefone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Gênero:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nome Completo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(164, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 15)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "ID:"
        '
        'Txtlavel
        '
        Me.Txtlavel.AutoSize = True
        Me.Txtlavel.Location = New System.Drawing.Point(345, 220)
        Me.Txtlavel.Name = "Txtlavel"
        Me.Txtlavel.Size = New System.Drawing.Size(42, 15)
        Me.Txtlavel.TabIndex = 14
        Me.Txtlavel.Text = "Cargo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Login:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(496, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Senha:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(2, 197)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Data de cadastro:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(345, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 15)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Bairro:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(496, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 15)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Complemento:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(625, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 15)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Nº:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(340, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Estado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(341, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Cidade:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(355, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Cep:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rua:"
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Location = New System.Drawing.Point(100, 154)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(133, 23)
        Me.TxtTelefone.TabIndex = 6
        '
        'TxtNascimento
        '
        Me.TxtNascimento.Location = New System.Drawing.Point(100, 116)
        Me.TxtNascimento.Name = "TxtNascimento"
        Me.TxtNascimento.Size = New System.Drawing.Size(133, 23)
        Me.TxtNascimento.TabIndex = 5
        '
        'TxtCpf
        '
        Me.TxtCpf.Location = New System.Drawing.Point(100, 75)
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(133, 23)
        Me.TxtCpf.TabIndex = 4
        '
        'TxtGenero
        '
        Me.TxtGenero.Location = New System.Drawing.Point(100, 39)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(63, 23)
        Me.TxtGenero.TabIndex = 3
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(100, 11)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(228, 23)
        Me.TxtNome.TabIndex = 1
        '
        'TxtComp
        '
        Me.TxtComp.Location = New System.Drawing.Point(584, 45)
        Me.TxtComp.Name = "TxtComp"
        Me.TxtComp.Size = New System.Drawing.Size(125, 23)
        Me.TxtComp.TabIndex = 10
        '
        'TxtnRua
        '
        Me.TxtnRua.Location = New System.Drawing.Point(655, 11)
        Me.TxtnRua.Name = "TxtnRua"
        Me.TxtnRua.Size = New System.Drawing.Size(54, 23)
        Me.TxtnRua.TabIndex = 8
        '
        'Txtidcolaborador
        '
        Me.Txtidcolaborador.Enabled = False
        Me.Txtidcolaborador.Location = New System.Drawing.Point(191, 191)
        Me.Txtidcolaborador.Name = "Txtidcolaborador"
        Me.Txtidcolaborador.Size = New System.Drawing.Size(42, 23)
        Me.Txtidcolaborador.TabIndex = 17
        '
        'TxtRua
        '
        Me.TxtRua.Location = New System.Drawing.Point(391, 11)
        Me.TxtRua.Name = "TxtRua"
        Me.TxtRua.Size = New System.Drawing.Size(228, 23)
        Me.TxtRua.TabIndex = 7
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(544, 188)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(131, 23)
        Me.TxtSenha.TabIndex = 17
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(390, 188)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(103, 23)
        Me.TxtLogin.TabIndex = 17
        '
        'TxtData
        '
        Me.TxtData.Enabled = False
        Me.TxtData.Location = New System.Drawing.Point(100, 192)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(63, 23)
        Me.TxtData.TabIndex = 17
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(391, 156)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(319, 23)
        Me.TxtEstado.TabIndex = 13
        '
        'TxtBairro
        '
        Me.TxtBairro.Location = New System.Drawing.Point(390, 115)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(319, 23)
        Me.TxtBairro.TabIndex = 12
        '
        'TxtCidade
        '
        Me.TxtCidade.Location = New System.Drawing.Point(391, 79)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(319, 23)
        Me.TxtCidade.TabIndex = 11
        '
        'TxtCep
        '
        Me.TxtCep.Location = New System.Drawing.Point(390, 45)
        Me.TxtCep.Name = "TxtCep"
        Me.TxtCep.Size = New System.Drawing.Size(103, 23)
        Me.TxtCep.TabIndex = 9
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(71, 77)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(12, 15)
        Me.lblRegistros.TabIndex = 65
        Me.lblRegistros.Text = "-"
        '
        'txtlbl
        '
        Me.txtlbl.AutoSize = True
        Me.txtlbl.Location = New System.Drawing.Point(13, 77)
        Me.txtlbl.Name = "txtlbl"
        Me.txtlbl.Size = New System.Drawing.Size(58, 15)
        Me.txtlbl.TabIndex = 64
        Me.txtlbl.Text = "Registros:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(646, 15)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(100, 23)
        Me.TxtBuscar.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(604, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Buscar:"
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.Enabled = False
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLimpar.Location = New System.Drawing.Point(671, 74)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(75, 21)
        Me.btLimpar.TabIndex = 62
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
        Me.dg2.Location = New System.Drawing.Point(13, 361)
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
        Me.dg2.Size = New System.Drawing.Size(735, 168)
        Me.dg2.TabIndex = 61
        '
        'BtSalvar
        '
        Me.BtSalvar.BackColor = System.Drawing.SystemColors.Window
        Me.BtSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSalvar.Enabled = False
        Me.BtSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSalvar.Location = New System.Drawing.Point(94, 535)
        Me.BtSalvar.Name = "BtSalvar"
        Me.BtSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtSalvar.TabIndex = 56
        Me.BtSalvar.Text = "Salvar"
        Me.BtSalvar.UseVisualStyleBackColor = False
        '
        'BtExcluir
        '
        Me.BtExcluir.BackColor = System.Drawing.SystemColors.Window
        Me.BtExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtExcluir.Enabled = False
        Me.BtExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtExcluir.Location = New System.Drawing.Point(673, 535)
        Me.BtExcluir.Name = "BtExcluir"
        Me.BtExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtExcluir.TabIndex = 59
        Me.BtExcluir.Text = "Excluir"
        Me.BtExcluir.UseVisualStyleBackColor = False
        '
        'BtEditar
        '
        Me.BtEditar.BackColor = System.Drawing.SystemColors.Window
        Me.BtEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtEditar.Enabled = False
        Me.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtEditar.Location = New System.Drawing.Point(592, 535)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtEditar.TabIndex = 58
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = False
        '
        'BtNovo
        '
        Me.BtNovo.BackColor = System.Drawing.SystemColors.Window
        Me.BtNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtNovo.Location = New System.Drawing.Point(13, 535)
        Me.BtNovo.Name = "BtNovo"
        Me.BtNovo.Size = New System.Drawing.Size(75, 23)
        Me.BtNovo.TabIndex = 57
        Me.BtNovo.Text = "Novo"
        Me.BtNovo.UseVisualStyleBackColor = False
        '
        'BtSalvar2
        '
        Me.BtSalvar2.BackColor = System.Drawing.SystemColors.Window
        Me.BtSalvar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSalvar2.Enabled = False
        Me.BtSalvar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSalvar2.Location = New System.Drawing.Point(94, 535)
        Me.BtSalvar2.Name = "BtSalvar2"
        Me.BtSalvar2.Size = New System.Drawing.Size(75, 23)
        Me.BtSalvar2.TabIndex = 70
        Me.BtSalvar2.Text = "Salvar"
        Me.BtSalvar2.UseVisualStyleBackColor = False
        Me.BtSalvar2.Visible = False
        '
        'FrmCadColab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(761, 572)
        Me.Controls.Add(Me.BtSalvar2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.txtlbl)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.BtSalvar)
        Me.Controls.Add(Me.BtExcluir)
        Me.Controls.Add(Me.BtEditar)
        Me.Controls.Add(Me.BtNovo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmCadColab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Castro Colaborador"
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents TxtNascimento As TextBox
    Friend WithEvents TxtCpf As TextBox
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtComp As TextBox
    Friend WithEvents TxtnRua As TextBox
    Friend WithEvents Txtidcolaborador As TextBox
    Friend WithEvents TxtRua As TextBox
    Friend WithEvents TxtData As TextBox
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents TxtCep As TextBox
    Friend WithEvents lblRegistros As Label
    Friend WithEvents txtlbl As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btLimpar As Button
    Friend WithEvents dg2 As DataGridView
    Friend WithEvents BtSalvar As Button
    Friend WithEvents BtExcluir As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtNovo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents BtSenha As Button
    Friend WithEvents BtSenha2 As Button
    Friend WithEvents CbCargo As ComboBox
    Friend WithEvents Txtlavel As Label
End Class

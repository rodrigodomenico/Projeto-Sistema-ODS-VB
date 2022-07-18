<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtClientes = New System.Windows.Forms.Button()
        Me.BtSolicitacao = New System.Windows.Forms.Button()
        Me.BtCadAdm = New System.Windows.Forms.Button()
        Me.BtCadastro = New System.Windows.Forms.Button()
        Me.txtlbl = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.lbltext = New System.Windows.Forms.TextBox()
        Me.TxtNome2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtCaixa = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtClientes
        '
        Me.BtClientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtClientes.BackColor = System.Drawing.SystemColors.Window
        Me.BtClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtClientes.Location = New System.Drawing.Point(344, 753)
        Me.BtClientes.Name = "BtClientes"
        Me.BtClientes.Size = New System.Drawing.Size(141, 67)
        Me.BtClientes.TabIndex = 0
        Me.BtClientes.Text = "Solicitações"
        Me.BtClientes.UseVisualStyleBackColor = False
        '
        'BtSolicitacao
        '
        Me.BtSolicitacao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtSolicitacao.BackColor = System.Drawing.SystemColors.Window
        Me.BtSolicitacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtSolicitacao.Location = New System.Drawing.Point(491, 753)
        Me.BtSolicitacao.Name = "BtSolicitacao"
        Me.BtSolicitacao.Size = New System.Drawing.Size(141, 67)
        Me.BtSolicitacao.TabIndex = 0
        Me.BtSolicitacao.Text = "Nova Solicitacação"
        Me.BtSolicitacao.UseVisualStyleBackColor = False
        '
        'BtCadAdm
        '
        Me.BtCadAdm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtCadAdm.BackColor = System.Drawing.SystemColors.Window
        Me.BtCadAdm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCadAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtCadAdm.Location = New System.Drawing.Point(785, 753)
        Me.BtCadAdm.Name = "BtCadAdm"
        Me.BtCadAdm.Size = New System.Drawing.Size(141, 67)
        Me.BtCadAdm.TabIndex = 0
        Me.BtCadAdm.Text = "Cadastro de Colaboradores"
        Me.BtCadAdm.UseVisualStyleBackColor = False
        '
        'BtCadastro
        '
        Me.BtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtCadastro.BackColor = System.Drawing.SystemColors.Window
        Me.BtCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtCadastro.Location = New System.Drawing.Point(638, 753)
        Me.BtCadastro.Name = "BtCadastro"
        Me.BtCadastro.Size = New System.Drawing.Size(141, 67)
        Me.BtCadastro.TabIndex = 0
        Me.BtCadastro.Text = "Cadastro de Clientes"
        Me.BtCadastro.UseVisualStyleBackColor = False
        '
        'txtlbl
        '
        Me.txtlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlbl.AutoSize = True
        Me.txtlbl.Location = New System.Drawing.Point(49, 18)
        Me.txtlbl.Name = "txtlbl"
        Me.txtlbl.Size = New System.Drawing.Size(72, 15)
        Me.txtlbl.TabIndex = 2
        Me.txtlbl.Text = "Solicitações:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.GridColor = System.Drawing.Color.Black
        Me.dg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dg.Location = New System.Drawing.Point(50, 57)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(1413, 690)
        Me.dg.TabIndex = 32
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscar.Location = New System.Drawing.Point(1210, 32)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(181, 23)
        Me.txtBuscar.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1168, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 15)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Buscar:"
        '
        'CbStatus
        '
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Location = New System.Drawing.Point(978, 33)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(176, 23)
        Me.CbStatus.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(875, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Buscar pelo status:"
        '
        'BtBuscar
        '
        Me.BtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtBuscar.BackColor = System.Drawing.SystemColors.Window
        Me.BtBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtBuscar.Location = New System.Drawing.Point(1396, 32)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(66, 23)
        Me.BtBuscar.TabIndex = 0
        Me.BtBuscar.Text = "Atualizar"
        Me.BtBuscar.UseVisualStyleBackColor = False
        '
        'lbltext
        '
        Me.lbltext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltext.Enabled = False
        Me.lbltext.Location = New System.Drawing.Point(50, 33)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(72, 23)
        Me.lbltext.TabIndex = 36
        Me.lbltext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNome2
        '
        Me.TxtNome2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNome2.Enabled = False
        Me.TxtNome2.Location = New System.Drawing.Point(128, 33)
        Me.TxtNome2.Name = "TxtNome2"
        Me.TxtNome2.Size = New System.Drawing.Size(126, 23)
        Me.TxtNome2.TabIndex = 36
        Me.TxtNome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Você está logado com:"
        '
        'TxtCargo
        '
        Me.TxtCargo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCargo.Enabled = False
        Me.TxtCargo.Location = New System.Drawing.Point(260, 33)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(96, 23)
        Me.TxtCargo.TabIndex = 36
        Me.TxtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Função:"
        '
        'BtCaixa
        '
        Me.BtCaixa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtCaixa.BackColor = System.Drawing.SystemColors.Window
        Me.BtCaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtCaixa.Location = New System.Drawing.Point(932, 753)
        Me.BtCaixa.Name = "BtCaixa"
        Me.BtCaixa.Size = New System.Drawing.Size(141, 67)
        Me.BtCaixa.TabIndex = 40
        Me.BtCaixa.Text = "Caixa"
        Me.BtCaixa.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1522, 871)
        Me.Controls.Add(Me.BtCaixa)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.TxtNome2)
        Me.Controls.Add(Me.CbStatus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.BtCadAdm)
        Me.Controls.Add(Me.BtCadastro)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.BtSolicitacao)
        Me.Controls.Add(Me.BtClientes)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtlbl)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtClientes As Button
    Friend WithEvents BtSolicitacao As Button
    Friend WithEvents BtCadAdm As Button
    Friend WithEvents txtlbl As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BtCadastro As Button
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtBuscar As Button
    Friend WithEvents lbltext As TextBox
    Friend WithEvents TxtNome2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtCaixa As Button
End Class

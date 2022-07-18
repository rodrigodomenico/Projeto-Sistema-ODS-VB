<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcaixa
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
        Me.DgSol = New System.Windows.Forms.DataGridView()
        Me.btLimpar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.txtlbl = New System.Windows.Forms.Label()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.TxtMes = New System.Windows.Forms.TextBox()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        CType(Me.DgSol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgSol
        '
        Me.DgSol.AllowUserToAddRows = False
        Me.DgSol.AllowUserToDeleteRows = False
        Me.DgSol.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DgSol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgSol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgSol.Location = New System.Drawing.Point(12, 103)
        Me.DgSol.Name = "DgSol"
        Me.DgSol.ReadOnly = True
        Me.DgSol.RowTemplate.Height = 25
        Me.DgSol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgSol.Size = New System.Drawing.Size(766, 278)
        Me.DgSol.TabIndex = 3
        '
        'btLimpar
        '
        Me.btLimpar.BackColor = System.Drawing.SystemColors.Window
        Me.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btLimpar.Location = New System.Drawing.Point(703, 387)
        Me.btLimpar.Name = "btLimpar"
        Me.btLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btLimpar.TabIndex = 9
        Me.btLimpar.Text = "Atualizar"
        Me.btLimpar.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(12, 74)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(72, 23)
        Me.TxtTotal.TabIndex = 38
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtlbl
        '
        Me.txtlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlbl.AutoSize = True
        Me.txtlbl.Location = New System.Drawing.Point(11, 59)
        Me.txtlbl.Name = "txtlbl"
        Me.txtlbl.Size = New System.Drawing.Size(50, 15)
        Me.txtlbl.TabIndex = 37
        Me.txtlbl.Text = "Entrada:"
        '
        'TxtData
        '
        Me.TxtData.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtData.Location = New System.Drawing.Point(90, 74)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.PlaceholderText = "Busca por dia"
        Me.TxtData.Size = New System.Drawing.Size(87, 23)
        Me.TxtData.TabIndex = 38
        Me.TxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMes
        '
        Me.TxtMes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMes.Location = New System.Drawing.Point(183, 74)
        Me.TxtMes.Name = "TxtMes"
        Me.TxtMes.PlaceholderText = "Buscar por mês "
        Me.TxtMes.Size = New System.Drawing.Size(98, 23)
        Me.TxtMes.TabIndex = 38
        Me.TxtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAno
        '
        Me.TxtAno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtAno.Location = New System.Drawing.Point(287, 74)
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.PlaceholderText = "Busca por ano"
        Me.TxtAno.Size = New System.Drawing.Size(87, 23)
        Me.TxtAno.TabIndex = 39
        Me.TxtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmcaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtAno)
        Me.Controls.Add(Me.TxtMes)
        Me.Controls.Add(Me.TxtData)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.txtlbl)
        Me.Controls.Add(Me.btLimpar)
        Me.Controls.Add(Me.DgSol)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmcaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caixa"
        CType(Me.DgSol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgSol As DataGridView
    Friend WithEvents btLimpar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents txtlbl As Label
    Friend WithEvents TxtData As TextBox
    Friend WithEvents TxtMes As TextBox
    Friend WithEvents TxtAno As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Historico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Historico))
        Me.FINANÇASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeraçãoDeCobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.dgv_historico = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_financeiro = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipohisto = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FINANÇASToolStripMenuItem
        '
        Me.FINANÇASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoricoFinanceiroToolStripMenuItem, Me.GeraçãoDeCobrançaToolStripMenuItem, Me.HistóricoFinanceiroToolStripMenuItem})
        Me.FINANÇASToolStripMenuItem.Image = CType(resources.GetObject("FINANÇASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FINANÇASToolStripMenuItem.Name = "FINANÇASToolStripMenuItem"
        Me.FINANÇASToolStripMenuItem.Size = New System.Drawing.Size(178, 68)
        Me.FINANÇASToolStripMenuItem.Text = "FINANCEIRO"
        '
        'HistoricoFinanceiroToolStripMenuItem
        '
        Me.HistoricoFinanceiroToolStripMenuItem.Name = "HistoricoFinanceiroToolStripMenuItem"
        Me.HistoricoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.HistoricoFinanceiroToolStripMenuItem.Text = "Relatório de Mensalidades"
        '
        'GeraçãoDeCobrançaToolStripMenuItem
        '
        Me.GeraçãoDeCobrançaToolStripMenuItem.Name = "GeraçãoDeCobrançaToolStripMenuItem"
        Me.GeraçãoDeCobrançaToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.GeraçãoDeCobrançaToolStripMenuItem.Text = "Geração de Cobrança"
        '
        'HistóricoFinanceiroToolStripMenuItem
        '
        Me.HistóricoFinanceiroToolStripMenuItem.Name = "HistóricoFinanceiroToolStripMenuItem"
        Me.HistóricoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(276, 26)
        Me.HistóricoFinanceiroToolStripMenuItem.Text = "Histórico Financeiro"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FINANÇASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(185, 72)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(24, 18)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(267, 72)
        Me.MenuStrip3.TabIndex = 25
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(260, 68)
        Me.CADASTROToolStripMenuItem.Text = "HISTORICO FINANCEIRO"
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip5.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip5.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip5.Size = New System.Drawing.Size(965, 114)
        Me.MenuStrip5.TabIndex = 26
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'dgv_historico
        '
        Me.dgv_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv_historico.Location = New System.Drawing.Point(96, 147)
        Me.dgv_historico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_historico.Name = "dgv_historico"
        Me.dgv_historico.RowHeadersWidth = 51
        Me.dgv_historico.RowTemplate.Height = 24
        Me.dgv_historico.Size = New System.Drawing.Size(822, 374)
        Me.dgv_historico.TabIndex = 37
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Orange
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_financeiro, Me.ToolStripLabel2, Me.cmb_tipohisto, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 114)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(965, 31)
        Me.ToolStrip2.TabIndex = 38
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(190, 28)
        Me.ToolStripLabel1.Text = "DIGITE O CPF DO ALUNO:"
        '
        'txt_financeiro
        '
        Me.txt_financeiro.BackColor = System.Drawing.SystemColors.Window
        Me.txt_financeiro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_financeiro.Name = "txt_financeiro"
        Me.txt_financeiro.Size = New System.Drawing.Size(89, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(86, 28)
        Me.ToolStripLabel2.Text = "SELECIONE"
        '
        'cmb_tipohisto
        '
        Me.cmb_tipohisto.Name = "cmb_tipohisto"
        Me.cmb_tipohisto.Size = New System.Drawing.Size(108, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Column5
        '
        Me.Column5.HeaderText = "CPF"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "NOME"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "VALOR"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATA DE RECEBIMENTO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "VENCIMENTO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'frm_Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(965, 532)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.dgv_historico)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.MenuStrip5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_Historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORICO FINANCEIRO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.dgv_historico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FINANÇASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoFinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeraçãoDeCobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoFinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents dgv_historico As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_financeiro As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipohisto As ToolStripComboBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

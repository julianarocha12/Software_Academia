<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cobranca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Cobranca))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FINANÇASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeraçãoDeCobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CODIGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VALORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_status = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.txt_contam = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_ger_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_cob_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cob_voltar = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FINANÇASToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(-327, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(159, 72)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FINANÇASToolStripMenuItem
        '
        Me.FINANÇASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoricoFinanceiroToolStripMenuItem, Me.GeraçãoDeCobrançaToolStripMenuItem, Me.HistóricoFinanceiroToolStripMenuItem})
        Me.FINANÇASToolStripMenuItem.Image = CType(resources.GetObject("FINANÇASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FINANÇASToolStripMenuItem.Name = "FINANÇASToolStripMenuItem"
        Me.FINANÇASToolStripMenuItem.Size = New System.Drawing.Size(153, 68)
        Me.FINANÇASToolStripMenuItem.Text = "FINANCEIRO"
        '
        'HistoricoFinanceiroToolStripMenuItem
        '
        Me.HistoricoFinanceiroToolStripMenuItem.Name = "HistoricoFinanceiroToolStripMenuItem"
        Me.HistoricoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.HistoricoFinanceiroToolStripMenuItem.Text = "Relatório de Mensalidades"
        '
        'GeraçãoDeCobrançaToolStripMenuItem
        '
        Me.GeraçãoDeCobrançaToolStripMenuItem.Name = "GeraçãoDeCobrançaToolStripMenuItem"
        Me.GeraçãoDeCobrançaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.GeraçãoDeCobrançaToolStripMenuItem.Text = "Geração de Cobrança"
        '
        'HistóricoFinanceiroToolStripMenuItem
        '
        Me.HistóricoFinanceiroToolStripMenuItem.Name = "HistóricoFinanceiroToolStripMenuItem"
        Me.HistóricoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.HistóricoFinanceiroToolStripMenuItem.Text = "Histórico Financeiro"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MenuStrip2.BackColor = System.Drawing.Color.Black
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CODIGOToolStripMenuItem, Me.NOMEToolStripMenuItem, Me.VALORToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(-330, 380)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip2.Size = New System.Drawing.Size(183, 24)
        Me.MenuStrip2.TabIndex = 20
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CODIGOToolStripMenuItem
        '
        Me.CODIGOToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CODIGOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CODIGOToolStripMenuItem.Name = "CODIGOToolStripMenuItem"
        Me.CODIGOToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CODIGOToolStripMenuItem.Text = "CODIGO"
        '
        'NOMEToolStripMenuItem
        '
        Me.NOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NOMEToolStripMenuItem.Name = "NOMEToolStripMenuItem"
        Me.NOMEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NOMEToolStripMenuItem.Text = "NOME"
        '
        'VALORToolStripMenuItem
        '
        Me.VALORToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VALORToolStripMenuItem.Name = "VALORToolStripMenuItem"
        Me.VALORToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VALORToolStripMenuItem.Text = "VALOR"
        '
        'txt_status
        '
        Me.txt_status.AutoSize = True
        Me.txt_status.Location = New System.Drawing.Point(433, 345)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(137, 13)
        Me.txt_status.TabIndex = 49
        Me.txt_status.Text = "STATUS:                            "
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txt_contam})
        Me.ToolStrip4.Location = New System.Drawing.Point(461, 253)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(40, 31)
        Me.ToolStrip4.TabIndex = 48
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'txt_contam
        '
        Me.txt_contam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.txt_contam.Image = CType(resources.GetObject("txt_contam.Image"), System.Drawing.Image)
        Me.txt_contam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.txt_contam.Name = "txt_contam"
        Me.txt_contam.Size = New System.Drawing.Size(28, 28)
        Me.txt_contam.Text = "ToolStripButton1"
        Me.txt_contam.ToolTipText = "VISUALIZAR"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 363)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(610, 143)
        Me.DataGridView1.TabIndex = 35
        '
        'txt_ger_cpf
        '
        Me.txt_ger_cpf.Location = New System.Drawing.Point(66, 253)
        Me.txt_ger_cpf.Mask = "999.000.999-09"
        Me.txt_ger_cpf.Name = "txt_ger_cpf"
        Me.txt_ger_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_ger_cpf.TabIndex = 46
        Me.txt_ger_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(-1, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(640, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(7, 339)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 14)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "MENSALIDADES GERADAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(-1, 312)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(640, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(10, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 14)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "DADOS DA MENSALIDADE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(5, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "GERAÇÃO DE COBRANÇA E MENSALIDADE"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(10, 9)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(333, 72)
        Me.MenuStrip3.TabIndex = 42
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(327, 68)
        Me.CADASTROToolStripMenuItem.Text = "GERAÇÃO DE COBRANÇA DE MENSALIDADE"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip4.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip4.Size = New System.Drawing.Size(638, 93)
        Me.MenuStrip4.TabIndex = 41
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(189, 253)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(40, 31)
        Me.ToolStrip2.TabIndex = 38
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "VISUALIZAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(20, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "CPF"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_cob_cancelar, Me.btn_cob_voltar})
        Me.ToolStrip1.Location = New System.Drawing.Point(10, 165)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(68, 31)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_cob_cancelar
        '
        Me.btn_cob_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cob_cancelar.Image = CType(resources.GetObject("btn_cob_cancelar.Image"), System.Drawing.Image)
        Me.btn_cob_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cob_cancelar.Name = "btn_cob_cancelar"
        Me.btn_cob_cancelar.Size = New System.Drawing.Size(28, 28)
        Me.btn_cob_cancelar.Text = "CANCELAR"
        Me.btn_cob_cancelar.ToolTipText = "CANCELAR"
        '
        'btn_cob_voltar
        '
        Me.btn_cob_voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cob_voltar.Image = CType(resources.GetObject("btn_cob_voltar.Image"), System.Drawing.Image)
        Me.btn_cob_voltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cob_voltar.Name = "btn_cob_voltar"
        Me.btn_cob_voltar.Size = New System.Drawing.Size(28, 28)
        Me.btn_cob_voltar.Text = "VOLTAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.MenuText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(370, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "ADD CONTA"
        '
        'Column1
        '
        Me.Column1.HeaderText = "N"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "cpf"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 47
        '
        'Column3
        '
        Me.Column3.HeaderText = "Data inclusão"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 97
        '
        'Column4
        '
        Me.Column4.HeaderText = "Produto"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.HeaderText = "Valor"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 56
        '
        'Column6
        '
        Me.Column6.HeaderText = "Data vencimento"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 104
        '
        'Column7
        '
        Me.Column7.HeaderText = "Quitação"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 56
        '
        'frm_Cobranca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(638, 530)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.ToolStrip4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_ger_cpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.MenuStrip4)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frm_Cobranca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GERAÇÃO DE COBRANÇA DE MENSALIDADE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FINANÇASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoricoFinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeraçãoDeCobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoFinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CODIGOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VALORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_status As Label
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents txt_contam As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_ger_cpf As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_cob_cancelar As ToolStripButton
    Friend WithEvents btn_cob_voltar As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewCheckBoxColumn
End Class

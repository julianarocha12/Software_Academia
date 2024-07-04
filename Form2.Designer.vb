<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_data_cobranca = New System.Windows.Forms.ComboBox()
        Me.txt_data_receb = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_data_nascimentoA = New System.Windows.Forms.DateTimePicker()
        Me.txt_nomeAluno = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gra = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btn_sa = New System.Windows.Forms.ToolStripButton()
        Me.txt_vlr_plano = New System.Windows.Forms.MaskedTextBox()
        Me.txt_celularA = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfAluno = New System.Windows.Forms.MaskedTextBox()
        Me.img_fotoAluno = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_emailA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.GroupBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscaAluno = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipoAluno = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_dadosAluno = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.txt_status = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_fotoAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dadosAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(29, 134)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(872, 421)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.txt_data_cobranca)
        Me.TabPage1.Controls.Add(Me.txt_status)
        Me.TabPage1.Controls.Add(Me.txt_data_receb)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txt_data_nascimentoA)
        Me.TabPage1.Controls.Add(Me.txt_nomeAluno)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.txt_vlr_plano)
        Me.TabPage1.Controls.Add(Me.txt_celularA)
        Me.TabPage1.Controls.Add(Me.txt_cpfAluno)
        Me.TabPage1.Controls.Add(Me.img_fotoAluno)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_emailA)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.img_foto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(864, 392)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DADOS PESSOAIS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_data_cobranca
        '
        Me.txt_data_cobranca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_data_cobranca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_data_cobranca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_data_cobranca.FormattingEnabled = True
        Me.txt_data_cobranca.Items.AddRange(New Object() {"5", "10", "15", "20", "30"})
        Me.txt_data_cobranca.Location = New System.Drawing.Point(308, 148)
        Me.txt_data_cobranca.Name = "txt_data_cobranca"
        Me.txt_data_cobranca.Size = New System.Drawing.Size(120, 24)
        Me.txt_data_cobranca.TabIndex = 9
        '
        'txt_data_receb
        '
        Me.txt_data_receb.Location = New System.Drawing.Point(308, 213)
        Me.txt_data_receb.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_data_receb.Mask = "99/99/9999"
        Me.txt_data_receb.Name = "txt_data_receb"
        Me.txt_data_receb.Size = New System.Drawing.Size(107, 22)
        Me.txt_data_receb.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(306, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "DATA DE RECEBIMENTO"
        '
        'txt_data_nascimentoA
        '
        Me.txt_data_nascimentoA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_nascimentoA.Location = New System.Drawing.Point(24, 146)
        Me.txt_data_nascimentoA.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_data_nascimentoA.Name = "txt_data_nascimentoA"
        Me.txt_data_nascimentoA.Size = New System.Drawing.Size(132, 22)
        Me.txt_data_nascimentoA.TabIndex = 2
        '
        'txt_nomeAluno
        '
        Me.txt_nomeAluno.Location = New System.Drawing.Point(19, 94)
        Me.txt_nomeAluno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomeAluno.Name = "txt_nomeAluno"
        Me.txt_nomeAluno.Size = New System.Drawing.Size(241, 22)
        Me.txt_nomeAluno.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gra, Me.ToolStripButton2, Me.btn_sa})
        Me.ToolStrip1.Location = New System.Drawing.Point(44, 313)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(100, 31)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gra
        '
        Me.btn_gra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gra.Image = CType(resources.GetObject("btn_gra.Image"), System.Drawing.Image)
        Me.btn_gra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gra.Name = "btn_gra"
        Me.btn_gra.Size = New System.Drawing.Size(29, 28)
        Me.btn_gra.Text = "ToolStripButton1"
        Me.btn_gra.ToolTipText = "GRAVAR"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "QRCODE"
        '
        'btn_sa
        '
        Me.btn_sa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_sa.Image = CType(resources.GetObject("btn_sa.Image"), System.Drawing.Image)
        Me.btn_sa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_sa.Name = "btn_sa"
        Me.btn_sa.Size = New System.Drawing.Size(29, 28)
        Me.btn_sa.Text = "ToolStripButton1"
        Me.btn_sa.ToolTipText = "CANCELAR/SAIR"
        '
        'txt_vlr_plano
        '
        Me.txt_vlr_plano.Location = New System.Drawing.Point(309, 94)
        Me.txt_vlr_plano.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_vlr_plano.Mask = "$ 999,99"
        Me.txt_vlr_plano.Name = "txt_vlr_plano"
        Me.txt_vlr_plano.Size = New System.Drawing.Size(137, 22)
        Me.txt_vlr_plano.TabIndex = 8
        '
        'txt_celularA
        '
        Me.txt_celularA.BackColor = System.Drawing.Color.White
        Me.txt_celularA.Location = New System.Drawing.Point(20, 249)
        Me.txt_celularA.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_celularA.Mask = "(99)99999-9999"
        Me.txt_celularA.Name = "txt_celularA"
        Me.txt_celularA.Size = New System.Drawing.Size(139, 22)
        Me.txt_celularA.TabIndex = 4
        '
        'txt_cpfAluno
        '
        Me.txt_cpfAluno.Location = New System.Drawing.Point(23, 42)
        Me.txt_cpfAluno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpfAluno.Mask = "999,999,999-99"
        Me.txt_cpfAluno.Name = "txt_cpfAluno"
        Me.txt_cpfAluno.Size = New System.Drawing.Size(139, 22)
        Me.txt_cpfAluno.TabIndex = 0
        '
        'img_fotoAluno
        '
        Me.img_fotoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_fotoAluno.Image = CType(resources.GetObject("img_fotoAluno.Image"), System.Drawing.Image)
        Me.img_fotoAluno.Location = New System.Drawing.Point(625, 47)
        Me.img_fotoAluno.Margin = New System.Windows.Forms.Padding(4)
        Me.img_fotoAluno.Name = "img_fotoAluno"
        Me.img_fotoAluno.Size = New System.Drawing.Size(179, 177)
        Me.img_fotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fotoAluno.TabIndex = 18
        Me.img_fotoAluno.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DIA DE COBRANÇA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "VALOR DO PLANO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CELULAR"
        '
        'txt_emailA
        '
        Me.txt_emailA.BackColor = System.Drawing.Color.White
        Me.txt_emailA.Location = New System.Drawing.Point(21, 193)
        Me.txt_emailA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_emailA.Name = "txt_emailA"
        Me.txt_emailA.Size = New System.Drawing.Size(221, 22)
        Me.txt_emailA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DATA DE NASCIMENTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.Black
        Me.img_foto.Location = New System.Drawing.Point(605, 22)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(4)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Padding = New System.Windows.Forms.Padding(4)
        Me.img_foto.Size = New System.Drawing.Size(225, 277)
        Me.img_foto.TabIndex = 9
        Me.img_foto.TabStop = False
        Me.img_foto.Text = "GroupBox1"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.dgv_dadosAluno)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(864, 392)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM GERAL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Orange
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_buscaAluno, Me.ToolStripLabel2, Me.cmb_tipoAluno, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(858, 31)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(263, 28)
        Me.ToolStripLabel1.Text = "DIGITE UM PARÂMETRO DE BUSCA:"
        '
        'txt_buscaAluno
        '
        Me.txt_buscaAluno.BackColor = System.Drawing.SystemColors.Window
        Me.txt_buscaAluno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscaAluno.Name = "txt_buscaAluno"
        Me.txt_buscaAluno.Size = New System.Drawing.Size(89, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(86, 28)
        Me.ToolStripLabel2.Text = "SELECIONE"
        '
        'cmb_tipoAluno
        '
        Me.cmb_tipoAluno.Name = "cmb_tipoAluno"
        Me.cmb_tipoAluno.Size = New System.Drawing.Size(108, 31)
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
        'dgv_dadosAluno
        '
        Me.dgv_dadosAluno.AllowUserToAddRows = False
        Me.dgv_dadosAluno.AllowUserToDeleteRows = False
        Me.dgv_dadosAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dadosAluno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dadosAluno.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_dadosAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dadosAluno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dadosAluno.Location = New System.Drawing.Point(48, 59)
        Me.dgv_dadosAluno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dadosAluno.Name = "dgv_dadosAluno"
        Me.dgv_dadosAluno.ReadOnly = True
        Me.dgv_dadosAluno.RowHeadersWidth = 62
        Me.dgv_dadosAluno.RowTemplate.Height = 28
        Me.dgv_dadosAluno.Size = New System.Drawing.Size(663, 299)
        Me.dgv_dadosAluno.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nº"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 51
        '
        'Column2
        '
        Me.Column2.HeaderText = "CPF DO ALUNO"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 123
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME DO ALUNO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 136
        '
        'Column4
        '
        Me.Column4.HeaderText = "EXCLUIR"
        Me.Column4.Image = CType(resources.GetObject("Column4.Image"), System.Drawing.Image)
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 69
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 63
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(12, 11)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(257, 72)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(250, 68)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO DO ALUNO"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(1027, 114)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'txt_status
        '
        Me.txt_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_status.FormattingEnabled = True
        Me.txt_status.Items.AddRange(New Object() {"LIBERADO", "BLOQUEADO"})
        Me.txt_status.Location = New System.Drawing.Point(308, 275)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(120, 24)
        Me.txt_status.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1027, 569)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO DE ALUNO"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_fotoAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dadosAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_emailA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gra As ToolStripButton
    Friend WithEvents btn_sa As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents img_fotoAluno As PictureBox
    Friend WithEvents img_foto As GroupBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents txt_celularA As MaskedTextBox
    Friend WithEvents txt_cpfAluno As MaskedTextBox
    Friend WithEvents txt_vlr_plano As MaskedTextBox
    Friend WithEvents dgv_dadosAluno As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_buscaAluno As ToolStripTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents txt_nomeAluno As MaskedTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipoAluno As ToolStripComboBox
    Friend WithEvents txt_data_nascimentoA As DateTimePicker
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_data_receb As MaskedTextBox
    Friend WithEvents txt_data_cobranca As ComboBox
    Friend WithEvents txt_status As ComboBox
End Class

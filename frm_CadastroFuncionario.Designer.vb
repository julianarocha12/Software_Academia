<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CadastroFuncionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CadastroFuncionario))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravarF = New System.Windows.Forms.ToolStripButton()
        Me.btn_sairF = New System.Windows.Forms.ToolStripButton()
        Me.txt_data_nascimentoFunc = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_senhaFunc = New System.Windows.Forms.TextBox()
        Me.txt_usuarioFunc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.img_fotoFunc = New System.Windows.Forms.PictureBox()
        Me.txt_celularFunc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfFunc = New System.Windows.Forms.MaskedTextBox()
        Me.img_foto1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_emailFunc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nomeFunc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_buscaFunc = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipoFunc = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.dgv_dadosFunc = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.img_fotoFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dadosFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Location = New System.Drawing.Point(24, 142)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(917, 411)
        Me.TabControl2.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.txt_data_nascimentoFunc)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txt_senhaFunc)
        Me.TabPage1.Controls.Add(Me.txt_usuarioFunc)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.img_fotoFunc)
        Me.TabPage1.Controls.Add(Me.txt_celularFunc)
        Me.TabPage1.Controls.Add(Me.txt_cpfFunc)
        Me.TabPage1.Controls.Add(Me.img_foto1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_emailFunc)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_nomeFunc)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(909, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DADOS PESSOAIS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravarF, Me.btn_sairF})
        Me.ToolStrip1.Location = New System.Drawing.Point(40, 322)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(71, 31)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravarF
        '
        Me.btn_gravarF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravarF.Image = CType(resources.GetObject("btn_gravarF.Image"), System.Drawing.Image)
        Me.btn_gravarF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravarF.Name = "btn_gravarF"
        Me.btn_gravarF.Size = New System.Drawing.Size(29, 28)
        Me.btn_gravarF.Text = "GRAVAR"
        Me.btn_gravarF.ToolTipText = "GRAVAR"
        '
        'btn_sairF
        '
        Me.btn_sairF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_sairF.Image = CType(resources.GetObject("btn_sairF.Image"), System.Drawing.Image)
        Me.btn_sairF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_sairF.Name = "btn_sairF"
        Me.btn_sairF.Size = New System.Drawing.Size(29, 28)
        Me.btn_sairF.Text = "CANCELAR/SAIR"
        Me.btn_sairF.ToolTipText = "CANCELAR/SAIR"
        '
        'txt_data_nascimentoFunc
        '
        Me.txt_data_nascimentoFunc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_data_nascimentoFunc.Location = New System.Drawing.Point(32, 142)
        Me.txt_data_nascimentoFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_data_nascimentoFunc.Name = "txt_data_nascimentoFunc"
        Me.txt_data_nascimentoFunc.Size = New System.Drawing.Size(139, 22)
        Me.txt_data_nascimentoFunc.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "SENHA:"
        '
        'txt_senhaFunc
        '
        Me.txt_senhaFunc.BackColor = System.Drawing.Color.White
        Me.txt_senhaFunc.Location = New System.Drawing.Point(397, 137)
        Me.txt_senhaFunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_senhaFunc.Name = "txt_senhaFunc"
        Me.txt_senhaFunc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senhaFunc.Size = New System.Drawing.Size(177, 22)
        Me.txt_senhaFunc.TabIndex = 6
        '
        'txt_usuarioFunc
        '
        Me.txt_usuarioFunc.BackColor = System.Drawing.Color.White
        Me.txt_usuarioFunc.Location = New System.Drawing.Point(397, 80)
        Me.txt_usuarioFunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_usuarioFunc.Name = "txt_usuarioFunc"
        Me.txt_usuarioFunc.Size = New System.Drawing.Size(177, 22)
        Me.txt_usuarioFunc.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "USUÁRIO"
        '
        'img_fotoFunc
        '
        Me.img_fotoFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_fotoFunc.Image = CType(resources.GetObject("img_fotoFunc.Image"), System.Drawing.Image)
        Me.img_fotoFunc.Location = New System.Drawing.Point(661, 59)
        Me.img_fotoFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.img_fotoFunc.Name = "img_fotoFunc"
        Me.img_fotoFunc.Size = New System.Drawing.Size(179, 177)
        Me.img_fotoFunc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_fotoFunc.TabIndex = 20
        Me.img_fotoFunc.TabStop = False
        '
        'txt_celularFunc
        '
        Me.txt_celularFunc.BackColor = System.Drawing.Color.White
        Me.txt_celularFunc.Location = New System.Drawing.Point(32, 262)
        Me.txt_celularFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_celularFunc.Mask = "(99)99999-9999"
        Me.txt_celularFunc.Name = "txt_celularFunc"
        Me.txt_celularFunc.Size = New System.Drawing.Size(139, 22)
        Me.txt_celularFunc.TabIndex = 4
        '
        'txt_cpfFunc
        '
        Me.txt_cpfFunc.Location = New System.Drawing.Point(28, 30)
        Me.txt_cpfFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpfFunc.Mask = "999,999,999-99"
        Me.txt_cpfFunc.Name = "txt_cpfFunc"
        Me.txt_cpfFunc.Size = New System.Drawing.Size(139, 22)
        Me.txt_cpfFunc.TabIndex = 0
        '
        'img_foto1
        '
        Me.img_foto1.BackColor = System.Drawing.Color.Black
        Me.img_foto1.Location = New System.Drawing.Point(644, 22)
        Me.img_foto1.Margin = New System.Windows.Forms.Padding(4)
        Me.img_foto1.Name = "img_foto1"
        Me.img_foto1.Padding = New System.Windows.Forms.Padding(4)
        Me.img_foto1.Size = New System.Drawing.Size(225, 277)
        Me.img_foto1.TabIndex = 21
        Me.img_foto1.TabStop = False
        Me.img_foto1.Text = "GroupBox1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CELULAR"
        '
        'txt_emailFunc
        '
        Me.txt_emailFunc.BackColor = System.Drawing.Color.White
        Me.txt_emailFunc.Location = New System.Drawing.Point(28, 202)
        Me.txt_emailFunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_emailFunc.Name = "txt_emailFunc"
        Me.txt_emailFunc.Size = New System.Drawing.Size(312, 22)
        Me.txt_emailFunc.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EMAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DATA DE NASCIMENTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
        '
        'txt_nomeFunc
        '
        Me.txt_nomeFunc.BackColor = System.Drawing.Color.White
        Me.txt_nomeFunc.Location = New System.Drawing.Point(27, 80)
        Me.txt_nomeFunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nomeFunc.Name = "txt_nomeFunc"
        Me.txt_nomeFunc.Size = New System.Drawing.Size(313, 22)
        Me.txt_nomeFunc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOME"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.dgv_dadosFunc)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(909, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LISTAGEM GERAL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Orange
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_buscaFunc, Me.ToolStripLabel2, Me.cmb_tipoFunc, Me.ToolStripButton1})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(903, 31)
        Me.ToolStrip2.TabIndex = 13
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(263, 28)
        Me.ToolStripLabel1.Text = "DIGITE UM PARÂMETRO DE BUSCA:"
        '
        'txt_buscaFunc
        '
        Me.txt_buscaFunc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_buscaFunc.Name = "txt_buscaFunc"
        Me.txt_buscaFunc.Size = New System.Drawing.Size(89, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(86, 28)
        Me.ToolStripLabel2.Text = "SELECIONE"
        '
        'cmb_tipoFunc
        '
        Me.cmb_tipoFunc.Name = "cmb_tipoFunc"
        Me.cmb_tipoFunc.Size = New System.Drawing.Size(108, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "CANCELAR/SAIR"
        Me.ToolStripButton1.ToolTipText = "CANCELAR/SAIR"
        '
        'dgv_dadosFunc
        '
        Me.dgv_dadosFunc.AllowUserToAddRows = False
        Me.dgv_dadosFunc.AllowUserToDeleteRows = False
        Me.dgv_dadosFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_dadosFunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_dadosFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dadosFunc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dadosFunc.Location = New System.Drawing.Point(39, 55)
        Me.dgv_dadosFunc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_dadosFunc.Name = "dgv_dadosFunc"
        Me.dgv_dadosFunc.ReadOnly = True
        Me.dgv_dadosFunc.RowHeadersWidth = 62
        Me.dgv_dadosFunc.RowTemplate.Height = 28
        Me.dgv_dadosFunc.Size = New System.Drawing.Size(741, 299)
        Me.dgv_dadosFunc.TabIndex = 1
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
        Me.Column2.HeaderText = "CPF DO FUNCIONARIO"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 164
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME DO FUNCIONARIO"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 177
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
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(302, 68)
        Me.CADASTROToolStripMenuItem.Text = "CADASTRO DO FUNCIONARIO"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(68, 11)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(309, 72)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(956, 114)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'frm_CadastroFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(956, 577)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frm_CadastroFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO FUNCIONARIOS"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.img_fotoFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dadosFunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_emailFunc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomeFunc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravarF As ToolStripButton
    Friend WithEvents btn_sairF As ToolStripButton
    Friend WithEvents img_fotoFunc As PictureBox
    Friend WithEvents img_foto1 As GroupBox
    Friend WithEvents txt_cpfFunc As MaskedTextBox
    Friend WithEvents txt_celularFunc As MaskedTextBox
    Friend WithEvents dgv_dadosFunc As DataGridView
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_buscaFunc As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipoFunc As ToolStripComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents txt_senhaFunc As TextBox
    Friend WithEvents txt_usuarioFunc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_data_nascimentoFunc As DateTimePicker
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class

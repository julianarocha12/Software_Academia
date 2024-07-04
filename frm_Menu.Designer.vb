<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CADASTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRICULAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModalidadesDeExercíciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANÇASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeraçãoDeCobrançaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoFinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlunoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.QRCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRARQRCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CADASTROToolStripMenuItem, Me.MATRICULAToolStripMenuItem, Me.FINANÇASToolStripMenuItem, Me.QRCODEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(247, 45)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 72)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CADASTROToolStripMenuItem
        '
        Me.CADASTROToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlunoToolStripMenuItem1, Me.FuncionarioToolStripMenuItem})
        Me.CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        Me.CADASTROToolStripMenuItem.Size = New System.Drawing.Size(146, 68)
        Me.CADASTROToolStripMenuItem.Text = "&CADASTRO"
        '
        'AlunoToolStripMenuItem1
        '
        Me.AlunoToolStripMenuItem1.Name = "AlunoToolStripMenuItem1"
        Me.AlunoToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.AlunoToolStripMenuItem1.Text = "Aluno"
        '
        'FuncionarioToolStripMenuItem
        '
        Me.FuncionarioToolStripMenuItem.Name = "FuncionarioToolStripMenuItem"
        Me.FuncionarioToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FuncionarioToolStripMenuItem.Text = "Funcionario"
        '
        'MATRICULAToolStripMenuItem
        '
        Me.MATRICULAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModalidadesDeExercíciosToolStripMenuItem})
        Me.MATRICULAToolStripMenuItem.Image = CType(resources.GetObject("MATRICULAToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MATRICULAToolStripMenuItem.Name = "MATRICULAToolStripMenuItem"
        Me.MATRICULAToolStripMenuItem.Size = New System.Drawing.Size(166, 68)
        Me.MATRICULAToolStripMenuItem.Text = "&MENSALIDADE"
        '
        'ModalidadesDeExercíciosToolStripMenuItem
        '
        Me.ModalidadesDeExercíciosToolStripMenuItem.Name = "ModalidadesDeExercíciosToolStripMenuItem"
        Me.ModalidadesDeExercíciosToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ModalidadesDeExercíciosToolStripMenuItem.Text = "Relátorio de Mensalidade"
        '
        'FINANÇASToolStripMenuItem
        '
        Me.FINANÇASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeraçãoDeCobrançaToolStripMenuItem, Me.HistóricoFinanceiroToolStripMenuItem})
        Me.FINANÇASToolStripMenuItem.Image = CType(resources.GetObject("FINANÇASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FINANÇASToolStripMenuItem.Name = "FINANÇASToolStripMenuItem"
        Me.FINANÇASToolStripMenuItem.Size = New System.Drawing.Size(153, 68)
        Me.FINANÇASToolStripMenuItem.Text = "&FINANCEIRO"
        '
        'GeraçãoDeCobrançaToolStripMenuItem
        '
        Me.GeraçãoDeCobrançaToolStripMenuItem.Name = "GeraçãoDeCobrançaToolStripMenuItem"
        Me.GeraçãoDeCobrançaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GeraçãoDeCobrançaToolStripMenuItem.Text = "Geração de Cobrança"
        '
        'HistóricoFinanceiroToolStripMenuItem
        '
        Me.HistóricoFinanceiroToolStripMenuItem.Name = "HistóricoFinanceiroToolStripMenuItem"
        Me.HistóricoFinanceiroToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.HistóricoFinanceiroToolStripMenuItem.Text = "Histórico Financeiro"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.FuncionárioToolStripMenuItem.Text = "Funcionário"
        '
        'AlunoToolStripMenuItem
        '
        Me.AlunoToolStripMenuItem.Name = "AlunoToolStripMenuItem"
        Me.AlunoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AlunoToolStripMenuItem.Text = "Aluno"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.MenuStrip2.Location = New System.Drawing.Point(80, 9)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(856, 148)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'QRCODEToolStripMenuItem
        '
        Me.QRCODEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINISTRARQRCODEToolStripMenuItem})
        Me.QRCODEToolStripMenuItem.Image = CType(resources.GetObject("QRCODEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QRCODEToolStripMenuItem.Name = "QRCODEToolStripMenuItem"
        Me.QRCODEToolStripMenuItem.Size = New System.Drawing.Size(134, 68)
        Me.QRCODEToolStripMenuItem.Text = "QR CODE"
        '
        'ADMINISTRARQRCODEToolStripMenuItem
        '
        Me.ADMINISTRARQRCODEToolStripMenuItem.Name = "ADMINISTRARQRCODEToolStripMenuItem"
        Me.ADMINISTRARQRCODEToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ADMINISTRARQRCODEToolStripMenuItem.Text = "ADMINISTRAR QR CODE"
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 514)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MATRICULAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINANÇASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlunoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlunoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FuncionarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModalidadesDeExercíciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeraçãoDeCobrançaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoFinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents QRCODEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINISTRARQRCODEToolStripMenuItem As ToolStripMenuItem
End Class

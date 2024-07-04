<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_addconta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_addconta))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tiposerv = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_ok = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_vencimento = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "TIPO DE SERVIÇO"
        '
        'tiposerv
        '
        Me.tiposerv.BackColor = System.Drawing.Color.White
        Me.tiposerv.Location = New System.Drawing.Point(72, 152)
        Me.tiposerv.Margin = New System.Windows.Forms.Padding(2)
        Me.tiposerv.Name = "tiposerv"
        Me.tiposerv.Size = New System.Drawing.Size(64, 20)
        Me.tiposerv.TabIndex = 26
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_ok})
        Me.ToolStrip1.Location = New System.Drawing.Point(225, 181)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(40, 31)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_ok
        '
        Me.btn_ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ok.Image = CType(resources.GetObject("btn_ok.Image"), System.Drawing.Image)
        Me.btn_ok.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(28, 28)
        Me.btn_ok.Text = "VOLTAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "VALOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DATA VENCIMENTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CPF"
        '
        'txt_valor
        '
        Me.txt_valor.BackColor = System.Drawing.Color.White
        Me.txt_valor.Location = New System.Drawing.Point(72, 115)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(64, 20)
        Me.txt_valor.TabIndex = 20
        '
        'txt_vencimento
        '
        Me.txt_vencimento.BackColor = System.Drawing.Color.White
        Me.txt_vencimento.Location = New System.Drawing.Point(72, 79)
        Me.txt_vencimento.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_vencimento.Name = "txt_vencimento"
        Me.txt_vencimento.Size = New System.Drawing.Size(64, 20)
        Me.txt_vencimento.TabIndex = 19
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(72, 43)
        Me.txtcpf.Mask = "999.000.999-09"
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(100, 20)
        Me.txtcpf.TabIndex = 47
        Me.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Frm_addconta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 249)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tiposerv)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.txt_vencimento)
        Me.Name = "Frm_addconta"
        Me.Text = "Frm_addconta"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents tiposerv As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_ok As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_vencimento As TextBox
    Friend WithEvents txtcpf As MaskedTextBox
End Class

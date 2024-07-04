<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_qrcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_qrcode))
        Me.picimagem = New System.Windows.Forms.PictureBox()
        Me.btn_gerarqrcode = New System.Windows.Forms.Button()
        Me.btn_salvarqrcode = New System.Windows.Forms.Button()
        Me.btn_carregarqrcode = New System.Windows.Forms.Button()
        Me.btn_lerqrcode = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_texto2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_texto = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_qr_cancelar = New System.Windows.Forms.ToolStripButton()
        CType(Me.picimagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picimagem
        '
        Me.picimagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picimagem.Location = New System.Drawing.Point(21, 27)
        Me.picimagem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picimagem.Name = "picimagem"
        Me.picimagem.Size = New System.Drawing.Size(205, 267)
        Me.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picimagem.TabIndex = 0
        Me.picimagem.TabStop = False
        '
        'btn_gerarqrcode
        '
        Me.btn_gerarqrcode.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_gerarqrcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gerarqrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerarqrcode.Location = New System.Drawing.Point(268, 124)
        Me.btn_gerarqrcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_gerarqrcode.Name = "btn_gerarqrcode"
        Me.btn_gerarqrcode.Size = New System.Drawing.Size(239, 39)
        Me.btn_gerarqrcode.TabIndex = 2
        Me.btn_gerarqrcode.Text = "GERAR QRCODE"
        Me.btn_gerarqrcode.UseVisualStyleBackColor = False
        '
        'btn_salvarqrcode
        '
        Me.btn_salvarqrcode.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_salvarqrcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvarqrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvarqrcode.Location = New System.Drawing.Point(268, 167)
        Me.btn_salvarqrcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_salvarqrcode.Name = "btn_salvarqrcode"
        Me.btn_salvarqrcode.Size = New System.Drawing.Size(239, 39)
        Me.btn_salvarqrcode.TabIndex = 3
        Me.btn_salvarqrcode.Text = "SALVAR QRCODE"
        Me.btn_salvarqrcode.UseVisualStyleBackColor = False
        '
        'btn_carregarqrcode
        '
        Me.btn_carregarqrcode.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_carregarqrcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_carregarqrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_carregarqrcode.Location = New System.Drawing.Point(268, 211)
        Me.btn_carregarqrcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_carregarqrcode.Name = "btn_carregarqrcode"
        Me.btn_carregarqrcode.Size = New System.Drawing.Size(239, 39)
        Me.btn_carregarqrcode.TabIndex = 4
        Me.btn_carregarqrcode.Text = "CARREGAR QRCODE"
        Me.btn_carregarqrcode.UseVisualStyleBackColor = False
        '
        'btn_lerqrcode
        '
        Me.btn_lerqrcode.BackColor = System.Drawing.Color.DarkOrange
        Me.btn_lerqrcode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lerqrcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lerqrcode.Location = New System.Drawing.Point(268, 255)
        Me.btn_lerqrcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_lerqrcode.Name = "btn_lerqrcode"
        Me.btn_lerqrcode.Size = New System.Drawing.Size(239, 39)
        Me.btn_lerqrcode.TabIndex = 5
        Me.btn_lerqrcode.Text = "LER QRCODE"
        Me.btn_lerqrcode.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(270, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DIGITE O NOME DO ALUNO:"
        '
        'txt_texto2
        '
        Me.txt_texto2.Location = New System.Drawing.Point(268, 92)
        Me.txt_texto2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_texto2.Name = "txt_texto2"
        Me.txt_texto2.Size = New System.Drawing.Size(241, 20)
        Me.txt_texto2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DIGITE O  DO CPF ALUNO:"
        '
        'txt_texto
        '
        Me.txt_texto.Location = New System.Drawing.Point(268, 43)
        Me.txt_texto.Mask = "999,999,999-99"
        Me.txt_texto.Name = "txt_texto"
        Me.txt_texto.Size = New System.Drawing.Size(105, 20)
        Me.txt_texto.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_qr_cancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(21, 316)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(40, 31)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_qr_cancelar
        '
        Me.btn_qr_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_qr_cancelar.Image = CType(resources.GetObject("btn_qr_cancelar.Image"), System.Drawing.Image)
        Me.btn_qr_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_qr_cancelar.Name = "btn_qr_cancelar"
        Me.btn_qr_cancelar.Size = New System.Drawing.Size(28, 28)
        Me.btn_qr_cancelar.Text = "CANCELAR"
        Me.btn_qr_cancelar.ToolTipText = "CANCELAR"
        '
        'frm_qrcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(574, 388)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_texto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_texto2)
        Me.Controls.Add(Me.btn_lerqrcode)
        Me.Controls.Add(Me.btn_carregarqrcode)
        Me.Controls.Add(Me.btn_salvarqrcode)
        Me.Controls.Add(Me.btn_gerarqrcode)
        Me.Controls.Add(Me.picimagem)
        Me.Name = "frm_qrcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QR CODE"
        CType(Me.picimagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picimagem As PictureBox
    Friend WithEvents btn_gerarqrcode As Button
    Friend WithEvents btn_salvarqrcode As Button
    Friend WithEvents btn_carregarqrcode As Button
    Friend WithEvents btn_lerqrcode As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_texto2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_texto As MaskedTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_qr_cancelar As ToolStripButton
End Class

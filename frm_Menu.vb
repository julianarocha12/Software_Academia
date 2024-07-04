Public Class frm_Menu
    Private Sub AlunoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlunoToolStripMenuItem1.Click
        Try
            Form2.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical)

        End Try
    End Sub


    Private Sub FuncionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionarioToolStripMenuItem.Click
        Try
            frm_CadastroFuncionario.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub ModalidadesDeExercíciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadesDeExercíciosToolStripMenuItem.Click
        Try
            frm_Relatorio.ShowDialog()


        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub GeraçãoDeCobrançaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeraçãoDeCobrançaToolStripMenuItem.Click
        Try
            frm_Cobranca.ShowDialog()


        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub HistóricoFinanceiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoFinanceiroToolStripMenuItem.Click
        Try
            frm_Historico.ShowDialog()

        Catch ex As Exception
            MsgBox("Erro ao chamar formulário", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ALTERARCADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()

    End Sub

    Private Sub ADMINISTRARQRCODEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADMINISTRARQRCODEToolStripMenuItem.Click
        frm_qrcode.ShowDialog()
    End Sub
End Class

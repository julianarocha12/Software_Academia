Public Class frm_Historico
    Private Sub frm_Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
        carregar_tipoHistorico()
        carregar_historico()
    End Sub

    Private Sub btn_finan_cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub





    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub



    Private Sub txt_financeiro_TextChanged(sender As Object, e As EventArgs) Handles txt_financeiro.TextChanged
        sql = "select * from tb_aluno where  " & cmb_tipohisto.Text & "  like '" & txt_financeiro.Text & "%'"
        rs = db.Execute(sql)
        With dgv_historico
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(8).Value, rs.Fields(6).Value, rs.Fields(9).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class

Public Class Frm_addconta
    Private Sub txtcpf_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Frm_addconta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
    End Sub
    Dim contador As Integer

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        contador = 0
        'Dim Data_hoje As DateTime = DateTime.Now
        Dim Data_hoje As Date = Date.Now
        sql = "select * from tb_contas"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            contador = contador + 1
            rs.MoveNext()
        Loop

        sql = "insert into tb_contas values ('" & txtcpf.Text & "', '" & contador & "', '" & FormatDateTime(Data_hoje, DateFormat.ShortDate) & "', " &
                                                " '" & tiposerv.Text & "', '" & txt_valor.Text & "', " &
                                                " '" & txt_vencimento.Text & "', NULL, FALSE)"

        ' contador = contador + 1
        rs = db.Execute(UCase(sql))
        MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

    End Sub


End Class
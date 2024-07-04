Public Class frm_Relatorio


    Private Sub frm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()
    End Sub

    Private Sub btn_canc_Click(sender As Object, e As EventArgs) Handles btn_canc.Click
        Me.Close()

    End Sub
End Class
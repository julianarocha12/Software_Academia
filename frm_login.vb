
Imports System.Data.OleDb
Public Class frm_login

    Dim con As New OleDbConnection
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        conectar_banco_access()

        If txt_usuario.Text = "admin" And txt_senha.Text = "admin" Then
            frm_CadastroFuncionario.ShowDialog()
        Else
            sql = "select * from tb_funcionario where usuario= '" & txt_usuario.Text & "'"
            sql = "select * from tb_funcionario where senha= '" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                frm_Menu.ShowDialog()
            Else
                MsgBox("Usuário ou senha inválidos!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_senha.Clear()
                txt_usuario.Clear()
                txt_usuario.Focus()
            End If
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frm_CadastroFuncionario.ShowDialog()
        Close()
    End Sub


    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub
End Class
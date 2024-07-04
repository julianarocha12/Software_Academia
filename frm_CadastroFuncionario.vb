Public Class frm_CadastroFuncionario

    Private Sub frm_CadastroFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conectar_banco_access()
        carregar_dadosFuncionario()
        carregar_tipoFunc()
    End Sub

    Private Sub btn_gravarF_Click(sender As Object, e As EventArgs) Handles btn_gravarF.Click
        Try
            sql = "select * from tb_funcionario where cpf = '" & txt_cpfFunc.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_funcionario values ('" & txt_cpfFunc.Text & "', '" & txt_nomeFunc.Text & "', " &
                                                   "'" & txt_data_nascimentoFunc.Text & "', '" & txt_emailFunc.Text & "', " &
                                                   "'" & txt_celularFunc.Text & "', '" & txt_usuarioFunc.Text & "', " &
                                                   "'" & txt_senhaFunc.Text & "','" & diretorio1 & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastroFuncionario()
                carregar_dadosFuncionario()
            Else
                sql = "update tb_funcionario set nome='" & txt_nomeFunc.Text & "', " &
                                           "data_nascimento='" & txt_data_nascimentoFunc.Text & "', " &
                                           "email='" & txt_emailFunc.Text & "', " &
                                           "celular='" & txt_celularFunc.Text & "', " &
                                           "usuario='" & txt_usuarioFunc.Text & "', " &
                                           "senha='" & txt_senhaFunc.Text & "', " &
                                           "foto='" & diretorio1 & "' " &
                                           "where cpf='" & txt_cpfFunc.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastroFuncionario()
                carregar_dadosFuncionario()
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar GravarFunc", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub





    Private Sub txt_buscaFunc_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaFunc.TextChanged
        sql = "select * from tb_funcionario where " & cmb_tipoFunc.Text & " like '" & txt_buscaFunc.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dadosFunc
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub dgv_dadosFunc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dadosFunc.CellContentClick
        Try
            With dgv_dadosFunc
                If .CurrentRow.Cells(3).Selected = True Then 'Se coluna 3 explorada
                    aux_cpfFunc = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "O CPF: " & aux_cpfFunc & "?", MsgBoxStyle.Question + vbYesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_funcionario where CPF='" & aux_cpfFunc & "'"
                        rs = db.Execute(sql)
                        carregar_dadosFuncionario()

                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpfFunc = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_funcionario where CPF='" & aux_cpfFunc & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl2.SelectTab(0) 'Explorar aba dados pessoais
                        txt_cpfFunc.Text = rs.Fields(0).Value
                        txt_nomeFunc.Text = rs.Fields(1).Value
                        txt_data_nascimentoFunc.Text = rs.Fields(2).Value
                        txt_emailFunc.Text = rs.Fields(3).Value
                        txt_celularFunc.Text = rs.Fields(4).Value
                        txt_usuarioFunc.Text = rs.Fields(5).Value
                        txt_senhaFunc.Text = rs.Fields(6).Value
                        img_fotoFunc.Load(rs.Fields(7).Value)

                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            'MsgBox("Erro de Processamento2", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÂO")
        End Try
    End Sub

    Private Sub img_fotoFunc_Click(sender As Object, e As EventArgs) Handles img_fotoFunc.Click
        Try
            With OpenFileDialog2
                .InitialDirectory = Application.StartupPath & "\fotos_perfil\"
                .Title = "SELECIONE UMA FOTO"
                .ShowDialog()
                diretorio1 = .FileName
                img_fotoFunc.Load(diretorio1)
            End With
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txt_cpfFunc_LostFocus(sender As Object, e As EventArgs) Handles txt_cpfFunc.LostFocus
        Try
            sql = "select * from tb_funcionario where cpf='" & txt_cpfFunc.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nomeFunc.Focus()
            Else
                txt_nomeFunc.Text = rs.Fields(1).Value
                txt_data_nascimentoFunc.Text = rs.Fields(2).Value
                txt_emailFunc.Text = rs.Fields(3).Value
                txt_celularFunc.Text = rs.Fields(4).Value
                txt_usuarioFunc.Text = rs.Fields(5).Value
                txt_senhaFunc.Text = rs.Fields(6).Value
                img_fotoFunc.Load(rs.Fields(7).Value)
            End If
        Catch ex As Exception
            ' MsgBox("Erro ao gravar2", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_sairF_Click(sender As Object, e As EventArgs) Handles btn_sairF.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub



    Private Sub txt_cpfFunc_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpfFunc.DoubleClick
        limpar_cadastroFuncionario()
    End Sub


End Class
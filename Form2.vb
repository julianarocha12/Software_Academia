Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conectar_banco_access()
        carregar_dadosAluno()
        carregar_tipoAluno()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles img_fotoAluno.Click
        Try
            With OpenFileDialog1
                .InitialDirectory = Application.StartupPath & "\fotos_perfil\"
                .Title = "SELECIONE UMA FOTO"
                .ShowDialog()
                diretorio = .FileName
                img_fotoAluno.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txt_cpfAluno_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpfAluno.DoubleClick
        limpar_cadastroAluno()
    End Sub

    Private Sub txt_buscaAluno_TextChanged(sender As Object, e As EventArgs) Handles txt_buscaAluno.TextChanged
        sql = "select * from tb_aluno where  " & cmb_tipoAluno.Text & "  like '" & txt_buscaAluno.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dadosAluno
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub


    Private Sub dgv_dadosAluno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dadosAluno.CellContentClick
        Try
            With dgv_dadosAluno
                If .CurrentRow.Cells(3).Selected = True Then 'Se coluna 3 explorada
                    aux_cpfAluno = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                "O CPF: " & aux_cpfAluno & "?", MsgBoxStyle.Question + vbYesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_aluno where cpf='" & aux_cpfAluno & "'"
                        rs = db.Execute(sql)
                        carregar_dadosAluno()
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpfAluno = .CurrentRow.Cells(1).Value
                    sql = "select * from tb_aluno where cpf='" & aux_cpfAluno & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0) 'Explorar aba dados pessoais
                        txt_cpfAluno.Text = rs.Fields(0).Value
                        txt_nomeAluno.Text = rs.Fields(1).Value
                        txt_data_nascimentoA.Text = rs.Fields(2).Value
                        txt_emailA.Text = rs.Fields(3).Value
                        txt_celularA.Text = rs.Fields(4).Value
                        txt_vlr_plano.Text = rs.Fields(5).Value
                        txt_data_cobranca.Text = rs.Fields(6).Value
                        img_fotoAluno.Load(rs.Fields(7).Value)
                        txt_data_receb.Text = rs.Fields(8).Value
                        txt_status.Text = rs.Fields(9).Value
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub



    Private Sub btn_gra_Click(sender As Object, e As EventArgs) Handles btn_gra.Click
        Try
            sql = "select * from tb_aluno where cpf = '" & txt_cpfAluno.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "insert into tb_aluno values ('" & txt_cpfAluno.Text & "', '" & txt_nomeAluno.Text & "', " &
                                                   "'" & txt_data_nascimentoA.Text & "', '" & txt_emailA.Text & "', " &
                                                   "'" & txt_celularA.Text & "', '" & txt_vlr_plano.Text & "', " &
                                                   " '" & txt_data_cobranca.Text & "','" & diretorio & "', " &
                                                   "'" & txt_data_receb.Text & "','" & txt_status.Text & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastroAluno()
                carregar_dadosAluno()
                frm_qrcode.ShowDialog()


            Else
                sql = "update tb_aluno set nome='" & txt_nomeAluno.Text & "', " &
                                           "data_nascimento='" & txt_data_nascimentoA.Text & "', " &
                                           "email='" & txt_emailA.Text & "', " &
                                           "celular='" & txt_celularA.Text & "', " &
                                           "valordoplano='" & txt_vlr_plano.Text & "', " &
                                           "datadaproxcobranca='" & txt_data_cobranca.Text & "', " &
                                           "dataderecebimento='" & txt_data_receb.Text & "', " &
                                           "status='" & txt_status.Text & "', " &
                                           "foto='" & diretorio & "' " &
                                           "where cpf='" & txt_cpfAluno.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastroAluno()
                carregar_dadosAluno()
            End If

        Catch ex As Exception
            MsgBox("Erro ao gravar1", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpfAluno_LostFocus(sender As Object, e As EventArgs) Handles txt_cpfAluno.LostFocus
        Try
            sql = "select * from tb_aluno where cpf='" & txt_cpfAluno.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_nomeAluno.Focus()
            Else
                txt_nomeAluno.Text = rs.Fields(1).Value
                txt_data_nascimentoA.Text = rs.Fields(2).Value
                txt_emailA.Text = rs.Fields(3).Value
                txt_celularA.Text = rs.Fields(4).Value
                txt_vlr_plano.Text = rs.Fields(5).Value
                txt_data_cobranca.Text = rs.Fields(6).Value
                img_fotoAluno.Load(rs.Fields(7).Value)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btn_sa_Click(sender As Object, e As EventArgs) Handles btn_sa.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frm_qrcode.ShowDialog()
    End Sub

    Private Sub txt_buscaAluno_Click(sender As Object, e As EventArgs) Handles txt_buscaAluno.Click

    End Sub


End Class


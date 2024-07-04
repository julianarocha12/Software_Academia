Imports System.Data.OleDb
Module Module_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, diretorio1, sql, aux_cpfFunc, aux_cpfAluno, resp As String
    Public banco = Application.StartupPath & "\banco_dados\banco_dados.mdb"
    Public bancoqr = Application.StartupPath & "\banco_dados\banco_dados.mdb"
    Public cont As Integer

    Public Function GetConnection() As OleDbConnection
        Dim conexao As String = ("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & bancoqr)
        Return New OleDbConnection(conexao)
    End Function
    Sub conectar_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & banco)
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastroAluno()
        Try
            With Form2
                .txt_nomeAluno.Clear()
                .txt_cpfAluno.Clear()
                '.txt_data_nascimentoA.Clear()
                .txt_emailA.Clear()
                .txt_celularA.Clear()
                .txt_vlr_plano.Clear()
                .txt_data_cobranca.Items.Clear()
                .img_fotoAluno.Load(Application.StartupPath & "\fotos\foto_nova.png")
                .txt_data_receb.Clear()
                .txt_status.Items.Clear()
                .txt_cpfAluno.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dadosAluno()
        sql = "select * from tb_aluno order by nome asc"
        rs = db.Execute(sql)
        With Form2.dgv_dadosAluno
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_historico()
        sql = "select * from tb_aluno order by nome asc"
        rs = db.Execute(sql)
        With frm_Historico.dgv_historico
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(5).Value, rs.Fields(8).Value, rs.Fields(6).Value, rs.Fields(9).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop
        End With


    End Sub

    Sub limpar_cadastroFuncionario()
        Try
            With frm_CadastroFuncionario
                .txt_nomeFunc.Clear()
                .txt_cpfFunc.Clear()
                'txt_data_nascimentoFunc.Clear()
                .txt_emailFunc.Clear()
                .txt_celularFunc.Clear()
                .txt_usuarioFunc.Clear()
                .txt_senhaFunc.Clear()
                .img_fotoFunc.Load(Application.StartupPath & "\fotos\foto_nova.png")
                .txt_cpfFunc.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dadosFuncionario()
        Try
            sql = "select * from tb_funcionario order by NOME asc"
            rs = db.Execute(sql)
            With frm_CadastroFuncionario.dgv_dadosFunc
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro de Processamento2", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipoAluno()
        Try
            With Form2.cmb_tipoAluno.Items
                .Add("CPF")
                .Add("Nome")
            End With
            Form2.cmb_tipoAluno.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar carregar_tipoAluno", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipoFunc()
        Try
            With frm_CadastroFuncionario.cmb_tipoFunc.Items
                .Add("CPF")
                .Add("Nome")
            End With
            frm_CadastroFuncionario.cmb_tipoFunc.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipoHistorico()
        Try
            With frm_Historico.cmb_tipohisto.Items
                .Add("CPF")
            End With
            frm_Historico.cmb_tipohisto.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_qrCode()
        Try
            With frm_qrcode
                .txt_texto.Clear()
                .txt_texto2.Clear()
                .picimagem.Load(Application.StartupPath & "\QrCode\teste.png")
                .txt_texto.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

End Module

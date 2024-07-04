Public Class frm_Cobranca

    Private Sub frm_Cobranca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco_access()

    End Sub

    Sub carregar_contas()
        sql = "select * from tb_contas where cpf='" & txt_ger_cpf.Text & "'"
        rs = db.Execute(sql)
        With DataGridView1
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(7).Value)
                cont = cont + 1
                rs.MoveNext()
            Loop


            Dim hoje As String = Now.Date
            Dim dia As String = hoje.Substring(0, 3)
            Dim mes As String = hoje.Substring(3, 3)
            Dim ano As String = hoje.Substring(6, 4)

            hoje = mes & dia & ano

            ' Dim datap As Date
            sql = "Select * from tb_contas where cpf ='" & txt_ger_cpf.Text & "' and data_vencimento <= #" & hoje & "#" 'And "where quitacao= False "
            sql += "AND quitacao= FALSE"
            ' sql += "AND data_vencimento <= #" & hoje & "#"
            '   DateTime.Compare(DataGridView1.Column, Data_hoje)

            rs = db.Execute(sql)
            If rs.EOF = True Then
                txt_status.Text = "Status: LIBERADO"

            Else
                '   If DateTime.Now.Date >= data_vencimento Then
                txt_status.Text = "Status: BLOQUEADO"
            End If

        End With
    End Sub


    Private Sub btn_cob_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cob_cancelar.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        carregar_contas()
    End Sub

    Private Sub txt_contam_Click(sender As Object, e As EventArgs) Handles txt_contam.Click
        Frm_addconta.txtcpf.Text = txt_ger_cpf.Text
        Frm_addconta.Show()

    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            With DataGridView1
                If .CurrentRow.Cells(6).Selected = True Then

                    sql = "select * from tb_contas where cpf='" & txt_ger_cpf.Text & "' and quitacao= FALSE"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = "update tb_contas set quitacao= True where cpf='" & txt_ger_cpf.Text & "'"
                        rs = db.Execute(sql)
                        carregar_contas()
                    ElseIf rs.EOF = True Then
                        sql = "update tb_contas set quitacao= False where cpf='" & txt_ger_cpf.Text & "'"
                        rs = db.Execute(sql)

                        carregar_contas()
                    End If


                End If
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
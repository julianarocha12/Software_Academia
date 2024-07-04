Imports QRCoder
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data


Public Class frm_qrcode
    Dim stringnome As String
    Private Sub btn_gerarqrcode_Click(sender As Object, e As EventArgs) Handles btn_gerarqrcode.Click
        gerarqrcode()
    End Sub

    Private Sub gerarqrcode()
        Try
            Dim qrencod As New QRCodeEncoder
            Dim qrcode As Bitmap = qrencod.Encode(txt_texto2.Text)
            picimagem.Image = TryCast(qrcode, Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btn_carregarqrcode_Click(sender As Object, e As EventArgs) Handles btn_carregarqrcode.Click
        Try
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = "projeto_inter\Projeto_inter\bin\Debug\QrCode"
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picimagem.ImageLocation = ofd.FileName
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_salvarqrcode_Click(sender As Object, e As EventArgs) Handles btn_salvarqrcode.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.InitialDirectory = "projeto_inter\Projeto_inter\bin\Debug\QrCode"
            sfd.Filter = "PNG | *.png| JPEG| *.jpg| BMP| *.bmp"
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picimagem.Image.Save(sfd.FileName)
                stringnome = sfd.FileName
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()

                If stringnome <> "" Then
                    Dim fs As FileStream
                    fs = New FileStream(stringnome, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))

                    Dim sql As String = "INSERT INTO tb_qrcode (cpf,nome,[QRCode]) values (?,?,?)"

                    Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                    cmd.Parameters.Add(New OleDb.OleDbParameter("@cpf", txt_texto.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@nome", txt_texto2.Text))
                    cmd.Parameters.Add(New OleDb.OleDbParameter("@QRCode", OleDbType.Binary, picByte.Length)).Value = picByte

                    cmd.ExecuteNonQuery()
                    MsgBox("Imagem gravada com sucesso!", MsgBoxStyle.Information, "Sucesso")

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


        End Using

    End Sub




    Private Sub btn_lerqrcode_Click(sender As Object, e As EventArgs) Handles btn_lerqrcode.Click
        Try
            Dim decor As New QRCodeDecoder()
            MessageBox.Show(decor.Decode(New QRCodeBitmapImage(TryCast(picimagem.Image, Bitmap))))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txt_texto_DoubleClick(sender As Object, e As EventArgs) Handles txt_texto.DoubleClick
        limpar_qrCode()
    End Sub

    Private Sub btn_cob_cancelar_Click(sender As Object, e As EventArgs) Handles btn_qr_cancelar.Click
        Me.Close()
    End Sub
End Class

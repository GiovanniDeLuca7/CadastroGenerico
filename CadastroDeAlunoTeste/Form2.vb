Imports System.Net.Mail

Public Class Form2
    Public Sub New(ByVal valorForm1 As String)
        InitializeComponent()
        txt_info.Text = valorForm1
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmd_enviar_Click(sender As Object, e As EventArgs) Handles cmd_enviar.Click
        Dim Attachment As System.Net.Mail.Attachment
        Dim Smtp_Server As New SmtpClient
        Dim Mailmsg As New MailMessage()
        Try
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("isoplandevelop@gmail.com", "z%6p5mb5")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            Mailmsg = New MailMessage()
            Mailmsg.From = New MailAddress(txt_de.Text)
            Mailmsg.To.Add(txt_para.Text)
            Mailmsg.Subject = txt_assunto.Text
            Mailmsg.IsBodyHtml = False
            Mailmsg.Body = txt_mensagem.Text & vbCrLf & txt_info.Text
            For i = 0 To lstAnexos.Items.Count - 1
                Mailmsg.Attachments.Add(New Attachment(lstAnexos.Items(i)))
            Next
            Smtp_Server.Send(Mailmsg)
            MsgBox("E-mail enviado, obrigado :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim DataHoraAtual As DateTime = Now
        lbl_data.Text = "Data: " & DataHoraAtual.ToShortDateString & ", Hora: " & DataHoraAtual.ToShortTimeString
    End Sub

    Private Sub cmd_incluir_Click(sender As System.Object, ByVal e As System.EventArgs) Handles cmd_incluir.Click
        Dim conta As Integer 
        OFD.CheckFileExists = True
        OFD.Title = "Selecione um arquivo para anexar"
        OFD.ShowDialog

        For conta = 0 To UBound(OFD.FileNames)
            lstAnexos.Items.Add(OFD.FileNames(Conta))
        Next
    End Sub

    Private Sub cmd_excluir_Click(sender As Object, e As EventArgs) Handles cmd_excluir.Click
        If lstAnexos.SelectedIndex > -1 Then
            lstAnexos.Items.RemoveAt(lstAnexos.SelectedIndex)
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myArgbColor As New Color()
        myArgbColor = Color.FromArgb(255, 0, 97, 86)

        If Form1.BackColor = Color.Black
            Dim dark As New Color()
            dark = Color.FromArgb(255, 48, 47, 48)
            Me.BackColor = dark
            cmd_enviar.BackColor = Color.DimGray
            cmd_incluir.BackColor = Color.DimGray
            cmd_excluir.BackColor = Color.DimGray
            MenuStrip1.BackColor = Color.DimGray
            MandarEmailToolStripMenuItem.ForeColor = Color.White
            PrincipalToolStripMenuItem.ForeColor = Color.White
             lbl_data.ForeColor = Color.White
            cmd_enviar.ForeColor = Color.White
            cmd_incluir.ForeColor = Color.White
            cmd_excluir.ForeColor = Color.White

        Else If Form1.BackColor = myArgbColor
            Me.BackColor = Color.Teal
            cmd_enviar.BackColor = Color.PaleGreen
            cmd_incluir.BackColor = Color.PaleGreen
            cmd_excluir.BackColor = Color.PaleGreen
            MenuStrip1.BackColor = Color.PaleGreen
            MandarEmailToolStripMenuItem.ForeColor = Color.Black
            PrincipalToolStripMenuItem.ForeColor = Color.Black
             lbl_data.ForeColor = Color.Black
            cmd_enviar.ForeColor = Color.Black
            cmd_incluir.ForeColor = Color.Black
            cmd_excluir.ForeColor = Color.Black
        
        Else If Form1.BackColor = Color.DodgerBlue
            Me.BackColor = Color.MediumBlue
            cmd_enviar.BackColor = Color.Silver
            cmd_incluir.BackColor = Color.Silver
            cmd_excluir.BackColor = Color.Silver
            MenuStrip1.BackColor = Color.Silver
            MandarEmailToolStripMenuItem.ForeColor = Color.Black
            PrincipalToolStripMenuItem.ForeColor = Color.Black
             lbl_data.ForeColor = Color.Black
            cmd_enviar.ForeColor = Color.Black
            cmd_incluir.ForeColor = Color.Black
            cmd_excluir.ForeColor = Color.Black
        End If
    End Sub

End Class


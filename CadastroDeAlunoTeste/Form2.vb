Imports System.Net.Mail

Public Class Form2
    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmd_enviar_Click(sender As Object, e As EventArgs) Handles cmd_enviar.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim Mailmsg As New MailMessage()
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
            Mailmsg.Body = txt_mensagem.Text & " uau"
            Smtp_Server.Send(Mailmsg)
            MsgBox("E-mail enviado, obrigado :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub
End Class
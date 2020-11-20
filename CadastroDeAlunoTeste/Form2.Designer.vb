<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MandarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_de = New System.Windows.Forms.TextBox()
        Me.txt_para = New System.Windows.Forms.TextBox()
        Me.txt_assunto = New System.Windows.Forms.TextBox()
        Me.txt_mensagem = New System.Windows.Forms.RichTextBox()
        Me.cmd_enviar = New System.Windows.Forms.Button()
        Me.txt_info = New System.Windows.Forms.RichTextBox()
        Me.lstAnexos = New System.Windows.Forms.ListBox()
        Me.cmd_incluir = New System.Windows.Forms.Button()
        Me.cmd_excluir = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.MandarEmailToolStripMenuItem, Me.lbl_data})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'MandarEmailToolStripMenuItem
        '
        Me.MandarEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MandarEmailToolStripMenuItem.Name = "MandarEmailToolStripMenuItem"
        Me.MandarEmailToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.MandarEmailToolStripMenuItem.Text = "Mandar e-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "De:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Para:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Assunto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mensagem:"
        '
        'txt_de
        '
        Me.txt_de.Location = New System.Drawing.Point(39, 46)
        Me.txt_de.Name = "txt_de"
        Me.txt_de.Size = New System.Drawing.Size(199, 20)
        Me.txt_de.TabIndex = 7
        '
        'txt_para
        '
        Me.txt_para.Location = New System.Drawing.Point(47, 75)
        Me.txt_para.Name = "txt_para"
        Me.txt_para.Size = New System.Drawing.Size(199, 20)
        Me.txt_para.TabIndex = 8
        '
        'txt_assunto
        '
        Me.txt_assunto.Location = New System.Drawing.Point(63, 105)
        Me.txt_assunto.Name = "txt_assunto"
        Me.txt_assunto.Size = New System.Drawing.Size(199, 20)
        Me.txt_assunto.TabIndex = 9
        '
        'txt_mensagem
        '
        Me.txt_mensagem.Location = New System.Drawing.Point(77, 137)
        Me.txt_mensagem.Name = "txt_mensagem"
        Me.txt_mensagem.Size = New System.Drawing.Size(256, 96)
        Me.txt_mensagem.TabIndex = 11
        Me.txt_mensagem.Text = ""
        '
        'cmd_enviar
        '
        Me.cmd_enviar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_enviar.ForeColor = System.Drawing.Color.White
        Me.cmd_enviar.Location = New System.Drawing.Point(39, 256)
        Me.cmd_enviar.Name = "cmd_enviar"
        Me.cmd_enviar.Size = New System.Drawing.Size(75, 49)
        Me.cmd_enviar.TabIndex = 12
        Me.cmd_enviar.Text = "Enviar e-mail"
        Me.cmd_enviar.UseVisualStyleBackColor = false
        '
        'txt_info
        '
        Me.txt_info.Enabled = false
        Me.txt_info.Location = New System.Drawing.Point(354, 46)
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(156, 124)
        Me.txt_info.TabIndex = 14
        Me.txt_info.Text = ""
        '
        'lstAnexos
        '
        Me.lstAnexos.FormattingEnabled = true
        Me.lstAnexos.Location = New System.Drawing.Point(159, 243)
        Me.lstAnexos.Name = "lstAnexos"
        Me.lstAnexos.Size = New System.Drawing.Size(213, 69)
        Me.lstAnexos.TabIndex = 15
        '
        'cmd_incluir
        '
        Me.cmd_incluir.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_incluir.ForeColor = System.Drawing.Color.White
        Me.cmd_incluir.Location = New System.Drawing.Point(403, 243)
        Me.cmd_incluir.Name = "cmd_incluir"
        Me.cmd_incluir.Size = New System.Drawing.Size(91, 23)
        Me.cmd_incluir.TabIndex = 16
        Me.cmd_incluir.Text = "Inclui Anexo"
        Me.cmd_incluir.UseVisualStyleBackColor = false
        '
        'cmd_excluir
        '
        Me.cmd_excluir.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_excluir.ForeColor = System.Drawing.Color.White
        Me.cmd_excluir.Location = New System.Drawing.Point(403, 282)
        Me.cmd_excluir.Name = "cmd_excluir"
        Me.cmd_excluir.Size = New System.Drawing.Size(91, 23)
        Me.cmd_excluir.TabIndex = 17
        Me.cmd_excluir.Text = "Exclui Anexo"
        Me.cmd_excluir.UseVisualStyleBackColor = false
        '
        'lbl_data
        '
        Me.lbl_data.Enabled = false
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(48, 20)
        Me.lbl_data.Text = "horas"
        '
        'Timer1
        '
        Me.Timer1.Enabled = true
        Me.Timer1.Interval = 1000
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(528, 317)
        Me.Controls.Add(Me.cmd_excluir)
        Me.Controls.Add(Me.cmd_incluir)
        Me.Controls.Add(Me.lstAnexos)
        Me.Controls.Add(Me.txt_info)
        Me.Controls.Add(Me.cmd_enviar)
        Me.Controls.Add(Me.txt_mensagem)
        Me.Controls.Add(Me.txt_assunto)
        Me.Controls.Add(Me.txt_para)
        Me.Controls.Add(Me.txt_de)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MandarEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_de As TextBox
    Friend WithEvents txt_para As TextBox
    Friend WithEvents txt_assunto As TextBox
    Friend WithEvents txt_mensagem As RichTextBox
    Friend WithEvents cmd_enviar As Button
    Friend WithEvents txt_info As RichTextBox
    Friend WithEvents lstAnexos As ListBox
    Friend WithEvents cmd_incluir As Button
    Friend WithEvents cmd_excluir As Button
    Friend WithEvents lbl_data As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OFD As OpenFileDialog
End Class

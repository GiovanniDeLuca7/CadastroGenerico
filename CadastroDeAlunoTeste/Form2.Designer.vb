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
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.MandarEmailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'MandarEmailToolStripMenuItem
        '
        Me.MandarEmailToolStripMenuItem.Name = "MandarEmailToolStripMenuItem"
        Me.MandarEmailToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.MandarEmailToolStripMenuItem.Text = "Mandar e-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "De"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Para"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Assunto"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mensagem"
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
        Me.cmd_enviar.Location = New System.Drawing.Point(29, 248)
        Me.cmd_enviar.Name = "cmd_enviar"
        Me.cmd_enviar.Size = New System.Drawing.Size(75, 49)
        Me.cmd_enviar.TabIndex = 12
        Me.cmd_enviar.Text = "Enviar e-mail"
        Me.cmd_enviar.UseVisualStyleBackColor = true
        '
        'txt_info
        '
        Me.txt_info.Enabled = false
        Me.txt_info.Location = New System.Drawing.Point(354, 46)
        Me.txt_info.Name = "txt_info"
        Me.txt_info.Size = New System.Drawing.Size(156, 115)
        Me.txt_info.TabIndex = 14
        Me.txt_info.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(528, 317)
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
End Class

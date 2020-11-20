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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MandarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_data = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.MandarEmailToolStripMenuItem, Me.lbl_data})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        resources.ApplyResources(Me.PrincipalToolStripMenuItem, "PrincipalToolStripMenuItem")
        '
        'MandarEmailToolStripMenuItem
        '
        Me.MandarEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MandarEmailToolStripMenuItem.Name = "MandarEmailToolStripMenuItem"
        resources.ApplyResources(Me.MandarEmailToolStripMenuItem, "MandarEmailToolStripMenuItem")
        '
        'lbl_data
        '
        resources.ApplyResources(Me.lbl_data, "lbl_data")
        Me.lbl_data.ForeColor = System.Drawing.Color.White
        Me.lbl_data.Name = "lbl_data"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'txt_de
        '
        resources.ApplyResources(Me.txt_de, "txt_de")
        Me.txt_de.Name = "txt_de"
        '
        'txt_para
        '
        resources.ApplyResources(Me.txt_para, "txt_para")
        Me.txt_para.Name = "txt_para"
        '
        'txt_assunto
        '
        resources.ApplyResources(Me.txt_assunto, "txt_assunto")
        Me.txt_assunto.Name = "txt_assunto"
        '
        'txt_mensagem
        '
        resources.ApplyResources(Me.txt_mensagem, "txt_mensagem")
        Me.txt_mensagem.Name = "txt_mensagem"
        '
        'cmd_enviar
        '
        Me.cmd_enviar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_enviar.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.cmd_enviar, "cmd_enviar")
        Me.cmd_enviar.Name = "cmd_enviar"
        Me.cmd_enviar.UseVisualStyleBackColor = false
        '
        'txt_info
        '
        Me.txt_info.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.txt_info, "txt_info")
        Me.txt_info.Name = "txt_info"
        '
        'lstAnexos
        '
        Me.lstAnexos.FormattingEnabled = true
        resources.ApplyResources(Me.lstAnexos, "lstAnexos")
        Me.lstAnexos.Name = "lstAnexos"
        '
        'cmd_incluir
        '
        Me.cmd_incluir.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_incluir.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.cmd_incluir, "cmd_incluir")
        Me.cmd_incluir.Name = "cmd_incluir"
        Me.cmd_incluir.UseVisualStyleBackColor = false
        '
        'cmd_excluir
        '
        Me.cmd_excluir.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_excluir.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.cmd_excluir, "cmd_excluir")
        Me.cmd_excluir.Name = "cmd_excluir"
        Me.cmd_excluir.UseVisualStyleBackColor = false
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
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idioma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Idioma))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_brasil = New System.Windows.Forms.Button()
        Me.btn_eua = New System.Windows.Forms.Button()
        Me.radio_br = New System.Windows.Forms.RadioButton()
        Me.radio_eua = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MandarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_data = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'btn_brasil
        '
        resources.ApplyResources(Me.btn_brasil, "btn_brasil")
        Me.btn_brasil.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.brasil
        Me.btn_brasil.Name = "btn_brasil"
        Me.btn_brasil.UseVisualStyleBackColor = true
        '
        'btn_eua
        '
        resources.ApplyResources(Me.btn_eua, "btn_eua")
        Me.btn_eua.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.eua
        Me.btn_eua.Name = "btn_eua"
        Me.btn_eua.UseVisualStyleBackColor = true
        '
        'radio_br
        '
        resources.ApplyResources(Me.radio_br, "radio_br")
        Me.radio_br.ForeColor = System.Drawing.Color.White
        Me.radio_br.Name = "radio_br"
        Me.radio_br.TabStop = true
        Me.radio_br.UseVisualStyleBackColor = true
        '
        'radio_eua
        '
        resources.ApplyResources(Me.radio_eua, "radio_eua")
        Me.radio_eua.ForeColor = System.Drawing.Color.White
        Me.radio_eua.Name = "radio_eua"
        Me.radio_eua.TabStop = true
        Me.radio_eua.UseVisualStyleBackColor = true
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.MandarEmailToolStripMenuItem, Me.IdiomaToolStripMenuItem, Me.lbl_data})
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
        Me.lbl_data.Name = "lbl_data"
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue
        Me.IdiomaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        resources.ApplyResources(Me.IdiomaToolStripMenuItem, "IdiomaToolStripMenuItem")
        '
        'Idioma
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.radio_eua)
        Me.Controls.Add(Me.radio_br)
        Me.Controls.Add(Me.btn_eua)
        Me.Controls.Add(Me.btn_brasil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Idioma"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_brasil As Button
    Friend WithEvents btn_eua As Button
    Friend WithEvents radio_br As RadioButton
    Friend WithEvents radio_eua As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MandarEmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_data As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
End Class

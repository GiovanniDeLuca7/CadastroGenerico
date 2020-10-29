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
        Me.cmd_continuar = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecione o idioma / Select the language"
        '
        'btn_brasil
        '
        Me.btn_brasil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_brasil.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.brasil
        Me.btn_brasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_brasil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_brasil.Location = New System.Drawing.Point(39, 48)
        Me.btn_brasil.Name = "btn_brasil"
        Me.btn_brasil.Size = New System.Drawing.Size(133, 96)
        Me.btn_brasil.TabIndex = 41
        Me.btn_brasil.UseVisualStyleBackColor = true
        '
        'btn_eua
        '
        Me.btn_eua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_eua.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.eua
        Me.btn_eua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eua.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_eua.Location = New System.Drawing.Point(214, 48)
        Me.btn_eua.Name = "btn_eua"
        Me.btn_eua.Size = New System.Drawing.Size(133, 96)
        Me.btn_eua.TabIndex = 42
        Me.btn_eua.UseVisualStyleBackColor = true
        '
        'radio_br
        '
        Me.radio_br.AutoSize = true
        Me.radio_br.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.radio_br.Location = New System.Drawing.Point(23, 152)
        Me.radio_br.Name = "radio_br"
        Me.radio_br.Size = New System.Drawing.Size(169, 24)
        Me.radio_br.TabIndex = 46
        Me.radio_br.TabStop = true
        Me.radio_br.Text = "Português Brasileiro"
        Me.radio_br.UseVisualStyleBackColor = true
        '
        'radio_eua
        '
        Me.radio_eua.AutoSize = true
        Me.radio_eua.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.radio_eua.Location = New System.Drawing.Point(237, 152)
        Me.radio_eua.Name = "radio_eua"
        Me.radio_eua.Size = New System.Drawing.Size(79, 24)
        Me.radio_eua.TabIndex = 47
        Me.radio_eua.TabStop = true
        Me.radio_eua.Text = "English"
        Me.radio_eua.UseVisualStyleBackColor = true
        '
        'cmd_continuar
        '
        Me.cmd_continuar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_continuar.ForeColor = System.Drawing.SystemColors.Control
        Me.cmd_continuar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_continuar.Location = New System.Drawing.Point(143, 182)
        Me.cmd_continuar.Name = "cmd_continuar"
        Me.cmd_continuar.Size = New System.Drawing.Size(104, 29)
        Me.cmd_continuar.TabIndex = 48
        Me.cmd_continuar.Text = "Proximo / Next"
        Me.cmd_continuar.UseVisualStyleBackColor = false
        '
        'Idioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(401, 223)
        Me.Controls.Add(Me.cmd_continuar)
        Me.Controls.Add(Me.radio_eua)
        Me.Controls.Add(Me.radio_br)
        Me.Controls.Add(Me.btn_eua)
        Me.Controls.Add(Me.btn_brasil)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Idioma"
        Me.Text = "Idioma"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_brasil As Button
    Friend WithEvents btn_eua As Button
    Friend WithEvents radio_br As RadioButton
    Friend WithEvents radio_eua As RadioButton
    Friend WithEvents cmd_continuar As Button
End Class

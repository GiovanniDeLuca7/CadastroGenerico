<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmd_cadastro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num_idade = New System.Windows.Forms.NumericUpDown()
        Me.txt_animal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radio_masc = New System.Windows.Forms.RadioButton()
        Me.radio_fem = New System.Windows.Forms.RadioButton()
        Me.radio_outro = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_estacao = New System.Windows.Forms.ComboBox()
        Me.lbl_teste = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_aguardando = New System.Windows.Forms.Label()
        Me.cmd_calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.num_2 = New System.Windows.Forms.NumericUpDown()
        Me.num_1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_cadastro = New System.Windows.Forms.Label()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.cmd_novo = New System.Windows.Forms.Button()
        Me.cmd_deletar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_id = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radio_oledb = New System.Windows.Forms.RadioButton()
        Me.radio_sql = New System.Windows.Forms.RadioButton()
        Me.cmd_conectar = New System.Windows.Forms.Button()
        Me.txt_gambiarra = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radio_oracle = New System.Windows.Forms.RadioButton()
        Me.cmd_editar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProjetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NovobancoDataSet = New CadastroDeAlunoTeste.novobancoDataSet()
        Me.ProjetoTableAdapter = New CadastroDeAlunoTeste.novobancoDataSetTableAdapters.ProjetoTableAdapter()
        Me.cmd_limpar = New System.Windows.Forms.Button()
        Me.lbl_aviso = New System.Windows.Forms.RichTextBox()
        Me.SkinManager1 = New Syncfusion.Windows.Forms.SkinManager(Me.components)
        CType(Me.num_idade,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.num_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.num_1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgv_dados,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.num_id,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox2.SuspendLayout
        CType(Me.ProjetoBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NovobancoDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cmd_cadastro
        '
        Me.cmd_cadastro.BackColor = System.Drawing.Color.Maroon
        Me.cmd_cadastro.ForeColor = System.Drawing.SystemColors.Control
        Me.cmd_cadastro.Location = New System.Drawing.Point(211, 27)
        Me.cmd_cadastro.Name = "cmd_cadastro"
        Me.cmd_cadastro.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cadastro.TabIndex = 0
        Me.cmd_cadastro.Text = "Cadastrar"
        Me.cmd_cadastro.UseVisualStyleBackColor = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite seu nome:"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.OrangeRed
        Me.txt_nome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_nome.Location = New System.Drawing.Point(104, 6)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Digite sua idade:"
        '
        'num_idade
        '
        Me.num_idade.BackColor = System.Drawing.Color.OrangeRed
        Me.num_idade.Location = New System.Drawing.Point(104, 38)
        Me.num_idade.Name = "num_idade"
        Me.num_idade.Size = New System.Drawing.Size(45, 20)
        Me.num_idade.TabIndex = 4
        '
        'txt_animal
        '
        Me.txt_animal.BackColor = System.Drawing.Color.OrangeRed
        Me.txt_animal.Location = New System.Drawing.Point(158, 69)
        Me.txt_animal.Name = "txt_animal"
        Me.txt_animal.Size = New System.Drawing.Size(100, 20)
        Me.txt_animal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Digite o nome de um animal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Seu gênero:"
        '
        'radio_masc
        '
        Me.radio_masc.AutoSize = true
        Me.radio_masc.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radio_masc.Location = New System.Drawing.Point(83, 101)
        Me.radio_masc.Name = "radio_masc"
        Me.radio_masc.Size = New System.Drawing.Size(73, 17)
        Me.radio_masc.TabIndex = 8
        Me.radio_masc.TabStop = true
        Me.radio_masc.Text = "Masculino"
        Me.radio_masc.UseVisualStyleBackColor = true
        '
        'radio_fem
        '
        Me.radio_fem.AutoSize = true
        Me.radio_fem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radio_fem.Location = New System.Drawing.Point(162, 101)
        Me.radio_fem.Name = "radio_fem"
        Me.radio_fem.Size = New System.Drawing.Size(67, 17)
        Me.radio_fem.TabIndex = 9
        Me.radio_fem.TabStop = true
        Me.radio_fem.Text = "Feminino"
        Me.radio_fem.UseVisualStyleBackColor = true
        '
        'radio_outro
        '
        Me.radio_outro.AutoSize = true
        Me.radio_outro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.radio_outro.Location = New System.Drawing.Point(235, 101)
        Me.radio_outro.Name = "radio_outro"
        Me.radio_outro.Size = New System.Drawing.Size(51, 17)
        Me.radio_outro.TabIndex = 10
        Me.radio_outro.TabStop = true
        Me.radio_outro.Text = "Outro"
        Me.radio_outro.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Escolha uma estação do ano:"
        '
        'cb_estacao
        '
        Me.cb_estacao.BackColor = System.Drawing.Color.OrangeRed
        Me.cb_estacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estacao.FormattingEnabled = true
        Me.cb_estacao.Items.AddRange(New Object() {"Primavera", "Verão", "Outono", "Inverno"})
        Me.cb_estacao.Location = New System.Drawing.Point(162, 131)
        Me.cb_estacao.Name = "cb_estacao"
        Me.cb_estacao.Size = New System.Drawing.Size(121, 21)
        Me.cb_estacao.TabIndex = 12
        '
        'lbl_teste
        '
        Me.lbl_teste.AutoSize = true
        Me.lbl_teste.Location = New System.Drawing.Point(229, 260)
        Me.lbl_teste.Name = "lbl_teste"
        Me.lbl_teste.Size = New System.Drawing.Size(0, 13)
        Me.lbl_teste.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_aguardando)
        Me.GroupBox1.Controls.Add(Me.cmd_calcular)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.num_2)
        Me.GroupBox1.Controls.Add(Me.num_1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 120)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Calculadora"
        '
        'lbl_aguardando
        '
        Me.lbl_aguardando.AutoSize = true
        Me.lbl_aguardando.Location = New System.Drawing.Point(3, 101)
        Me.lbl_aguardando.Name = "lbl_aguardando"
        Me.lbl_aguardando.Size = New System.Drawing.Size(16, 13)
        Me.lbl_aguardando.TabIndex = 18
        Me.lbl_aguardando.Text = "..."
        Me.lbl_aguardando.Visible = false
        '
        'cmd_calcular
        '
        Me.cmd_calcular.BackColor = System.Drawing.Color.Maroon
        Me.cmd_calcular.Location = New System.Drawing.Point(92, 73)
        Me.cmd_calcular.Name = "cmd_calcular"
        Me.cmd_calcular.Size = New System.Drawing.Size(75, 23)
        Me.cmd_calcular.TabIndex = 17
        Me.cmd_calcular.Text = "Calcular"
        Me.cmd_calcular.UseVisualStyleBackColor = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Insira dois valores:"
        '
        'num_2
        '
        Me.num_2.BackColor = System.Drawing.Color.OrangeRed
        Me.num_2.Location = New System.Drawing.Point(132, 40)
        Me.num_2.Name = "num_2"
        Me.num_2.Size = New System.Drawing.Size(120, 20)
        Me.num_2.TabIndex = 15
        '
        'num_1
        '
        Me.num_1.BackColor = System.Drawing.Color.OrangeRed
        Me.num_1.Location = New System.Drawing.Point(6, 40)
        Me.num_1.Name = "num_1"
        Me.num_1.Size = New System.Drawing.Size(120, 20)
        Me.num_1.TabIndex = 0
        '
        'lbl_cadastro
        '
        Me.lbl_cadastro.AutoSize = true
        Me.lbl_cadastro.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_cadastro.Location = New System.Drawing.Point(213, 4)
        Me.lbl_cadastro.Name = "lbl_cadastro"
        Me.lbl_cadastro.Size = New System.Drawing.Size(16, 13)
        Me.lbl_cadastro.TabIndex = 15
        Me.lbl_cadastro.Text = "..."
        Me.lbl_cadastro.Visible = false
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.GridColor = System.Drawing.Color.LightSalmon
        Me.dgv_dados.Location = New System.Drawing.Point(12, 188)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(848, 150)
        Me.dgv_dados.TabIndex = 18
        '
        'cmd_novo
        '
        Me.cmd_novo.BackColor = System.Drawing.Color.Maroon
        Me.cmd_novo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmd_novo.Location = New System.Drawing.Point(661, 27)
        Me.cmd_novo.Name = "cmd_novo"
        Me.cmd_novo.Size = New System.Drawing.Size(132, 23)
        Me.cmd_novo.TabIndex = 20
        Me.cmd_novo.Text = "Novo"
        Me.cmd_novo.UseVisualStyleBackColor = false
        '
        'cmd_deletar
        '
        Me.cmd_deletar.BackColor = System.Drawing.Color.Maroon
        Me.cmd_deletar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmd_deletar.Location = New System.Drawing.Point(661, 72)
        Me.cmd_deletar.Name = "cmd_deletar"
        Me.cmd_deletar.Size = New System.Drawing.Size(132, 23)
        Me.cmd_deletar.TabIndex = 21
        Me.cmd_deletar.Text = "Deletar"
        Me.cmd_deletar.UseVisualStyleBackColor = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(15, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Id:"
        '
        'num_id
        '
        Me.num_id.BackColor = System.Drawing.Color.OrangeRed
        Me.num_id.Location = New System.Drawing.Point(40, 160)
        Me.num_id.Name = "num_id"
        Me.num_id.Size = New System.Drawing.Size(120, 20)
        Me.num_id.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(628, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Insira o Id que deseja apagar"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(628, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Preencha os campos antes de cadastrar"
        '
        'radio_oledb
        '
        Me.radio_oledb.AutoSize = true
        Me.radio_oledb.Location = New System.Drawing.Point(6, 17)
        Me.radio_oledb.Name = "radio_oledb"
        Me.radio_oledb.Size = New System.Drawing.Size(97, 17)
        Me.radio_oledb.TabIndex = 27
        Me.radio_oledb.TabStop = true
        Me.radio_oledb.Text = "OleDb Provider"
        Me.radio_oledb.UseVisualStyleBackColor = true
        '
        'radio_sql
        '
        Me.radio_sql.AutoSize = true
        Me.radio_sql.Location = New System.Drawing.Point(107, 17)
        Me.radio_sql.Name = "radio_sql"
        Me.radio_sql.Size = New System.Drawing.Size(94, 17)
        Me.radio_sql.TabIndex = 28
        Me.radio_sql.TabStop = true
        Me.radio_sql.Text = "MySQL Server"
        Me.radio_sql.UseVisualStyleBackColor = true
        '
        'cmd_conectar
        '
        Me.cmd_conectar.BackColor = System.Drawing.Color.Maroon
        Me.cmd_conectar.ForeColor = System.Drawing.SystemColors.Control
        Me.cmd_conectar.Location = New System.Drawing.Point(619, 151)
        Me.cmd_conectar.Name = "cmd_conectar"
        Me.cmd_conectar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_conectar.TabIndex = 29
        Me.cmd_conectar.Text = "Conectar"
        Me.cmd_conectar.UseVisualStyleBackColor = false
        '
        'txt_gambiarra
        '
        Me.txt_gambiarra.Location = New System.Drawing.Point(12, 334)
        Me.txt_gambiarra.Name = "txt_gambiarra"
        Me.txt_gambiarra.Size = New System.Drawing.Size(100, 20)
        Me.txt_gambiarra.TabIndex = 30
        Me.txt_gambiarra.Text = "N/A"
        Me.txt_gambiarra.Visible = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radio_oracle)
        Me.GroupBox2.Controls.Add(Me.radio_sql)
        Me.GroupBox2.Controls.Add(Me.radio_oledb)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(304, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 42)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Acesso"
        '
        'radio_oracle
        '
        Me.radio_oracle.AutoSize = true
        Me.radio_oracle.Location = New System.Drawing.Point(207, 18)
        Me.radio_oracle.Name = "radio_oracle"
        Me.radio_oracle.Size = New System.Drawing.Size(90, 17)
        Me.radio_oracle.TabIndex = 35
        Me.radio_oracle.TabStop = true
        Me.radio_oracle.Text = "Oracle Server"
        Me.radio_oracle.UseVisualStyleBackColor = true
        '
        'cmd_editar
        '
        Me.cmd_editar.BackColor = System.Drawing.Color.Maroon
        Me.cmd_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmd_editar.Location = New System.Drawing.Point(661, 116)
        Me.cmd_editar.Name = "cmd_editar"
        Me.cmd_editar.Size = New System.Drawing.Size(132, 23)
        Me.cmd_editar.TabIndex = 33
        Me.cmd_editar.Text = "Editar"
        Me.cmd_editar.UseVisualStyleBackColor = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(628, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Insira o Id que deseja editar"
        '
        'ProjetoBindingSource
        '
        Me.ProjetoBindingSource.DataMember = "Projeto"
        Me.ProjetoBindingSource.DataSource = Me.NovobancoDataSet
        '
        'NovobancoDataSet
        '
        Me.NovobancoDataSet.DataSetName = "novobancoDataSet"
        Me.NovobancoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjetoTableAdapter
        '
        Me.ProjetoTableAdapter.ClearBeforeFill = true
        '
        'cmd_limpar
        '
        Me.cmd_limpar.BackColor = System.Drawing.Color.White
        Me.cmd_limpar.ForeColor = System.Drawing.Color.Black
        Me.cmd_limpar.Location = New System.Drawing.Point(166, 158)
        Me.cmd_limpar.Name = "cmd_limpar"
        Me.cmd_limpar.Size = New System.Drawing.Size(132, 22)
        Me.cmd_limpar.TabIndex = 35
        Me.cmd_limpar.Text = "Limpar Campos"
        Me.cmd_limpar.UseVisualStyleBackColor = false
        '
        'lbl_aviso
        '
        Me.lbl_aviso.Location = New System.Drawing.Point(710, 142)
        Me.lbl_aviso.Name = "lbl_aviso"
        Me.lbl_aviso.Size = New System.Drawing.Size(148, 42)
        Me.lbl_aviso.TabIndex = 36
        Me.lbl_aviso.Text = ""
        Me.lbl_aviso.Visible = false
        '
        'SkinManager1
        '
        Me.SkinManager1.Controls = Nothing
        Me.SkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(871, 347)
        Me.Controls.Add(Me.lbl_aviso)
        Me.Controls.Add(Me.cmd_limpar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmd_editar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_cadastro)
        Me.Controls.Add(Me.txt_gambiarra)
        Me.Controls.Add(Me.cmd_conectar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.num_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmd_deletar)
        Me.Controls.Add(Me.cmd_novo)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_teste)
        Me.Controls.Add(Me.cb_estacao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.radio_outro)
        Me.Controls.Add(Me.radio_fem)
        Me.Controls.Add(Me.radio_masc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_animal)
        Me.Controls.Add(Me.num_idade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_cadastro)
        Me.Name = "Form1"
        Me.Text = "Preferências"
        CType(Me.num_idade,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.num_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.num_1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgv_dados,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.num_id,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.ProjetoBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NovobancoDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents cmd_cadastro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents num_idade As NumericUpDown
    Friend WithEvents txt_animal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radio_masc As RadioButton
    Friend WithEvents radio_fem As RadioButton
    Friend WithEvents radio_outro As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_estacao As ComboBox
    Friend WithEvents lbl_teste As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_aguardando As Label
    Friend WithEvents cmd_calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents num_2 As NumericUpDown
    Friend WithEvents num_1 As NumericUpDown
    Friend WithEvents lbl_cadastro As Label
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents NovobancoDataSet As novobancoDataSet
    Friend WithEvents ProjetoBindingSource As BindingSource
    Friend WithEvents ProjetoTableAdapter As novobancoDataSetTableAdapters.ProjetoTableAdapter
    Friend WithEvents cmd_novo As Button
    Friend WithEvents cmd_deletar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents num_id As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents radio_oledb As RadioButton
    Friend WithEvents radio_sql As RadioButton
    Friend WithEvents cmd_conectar As Button
    Friend WithEvents txt_gambiarra As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_editar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents radio_oracle As RadioButton
    Friend WithEvents cmd_limpar As Button
    Friend WithEvents lbl_aviso As RichTextBox
    Friend WithEvents SkinManager1 As Syncfusion.Windows.Forms.SkinManager
End Class

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmd_cadastro = New System.Windows.Forms.Button()
        Me.lbl_frm_nome = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.lbl_idade = New System.Windows.Forms.Label()
        Me.num_idade = New System.Windows.Forms.NumericUpDown()
        Me.txt_animal = New System.Windows.Forms.TextBox()
        Me.lbl_animal = New System.Windows.Forms.Label()
        Me.lbl_genero = New System.Windows.Forms.Label()
        Me.radio_masc = New System.Windows.Forms.RadioButton()
        Me.radio_fem = New System.Windows.Forms.RadioButton()
        Me.radio_outro = New System.Windows.Forms.RadioButton()
        Me.lbl_estacao = New System.Windows.Forms.Label()
        Me.cb_estacao = New System.Windows.Forms.ComboBox()
        Me.lbl_teste = New System.Windows.Forms.Label()
        Me.gp_calculadora = New System.Windows.Forms.GroupBox()
        Me.lbl_aguardando = New System.Windows.Forms.Label()
        Me.cmd_calcular = New System.Windows.Forms.Button()
        Me.lbl_textocalc = New System.Windows.Forms.Label()
        Me.num_2 = New System.Windows.Forms.NumericUpDown()
        Me.num_1 = New System.Windows.Forms.NumericUpDown()
        Me.lbl_cadastro = New System.Windows.Forms.Label()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.cmd_novo = New System.Windows.Forms.Button()
        Me.cmd_deletar = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.num_id = New System.Windows.Forms.NumericUpDown()
        Me.lbl_deletar = New System.Windows.Forms.Label()
        Me.lbl_novo = New System.Windows.Forms.Label()
        Me.radio_oledb = New System.Windows.Forms.RadioButton()
        Me.radio_sql = New System.Windows.Forms.RadioButton()
        Me.cmd_conectar = New System.Windows.Forms.Button()
        Me.txt_gambiarra = New System.Windows.Forms.TextBox()
        Me.gp_access = New System.Windows.Forms.GroupBox()
        Me.radio_oracle = New System.Windows.Forms.RadioButton()
        Me.cmd_editar = New System.Windows.Forms.Button()
        Me.lbl_editar = New System.Windows.Forms.Label()
        Me.cmd_limpar = New System.Windows.Forms.Button()
        Me.lbl_aviso = New System.Windows.Forms.RichTextBox()
        Me.SkinManager1 = New Syncfusion.Windows.Forms.SkinManager(Me.components)
        Me.ProjetoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NovobancoDataSet = New CadastroDeAlunoTeste.novobancoDataSet()
        Me.ProjetoTableAdapter = New CadastroDeAlunoTeste.novobancoDataSetTableAdapters.ProjetoTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_eua = New System.Windows.Forms.Button()
        Me.btn_brasil = New System.Windows.Forms.Button()
        Me.lbl_nome = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReportF1 = New CadastroDeAlunoTeste.CrystalReportF()
        CType(Me.num_idade,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gp_calculadora.SuspendLayout
        CType(Me.num_2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.num_1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgv_dados,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.num_id,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gp_access.SuspendLayout
        CType(Me.ProjetoBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NovobancoDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cmd_cadastro
        '
        Me.cmd_cadastro.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_cadastro.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.cmd_cadastro, "cmd_cadastro")
        Me.cmd_cadastro.Name = "cmd_cadastro"
        Me.cmd_cadastro.UseVisualStyleBackColor = false
        '
        'lbl_frm_nome
        '
        resources.ApplyResources(Me.lbl_frm_nome, "lbl_frm_nome")
        Me.lbl_frm_nome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_frm_nome.Name = "lbl_frm_nome"
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.Lavender
        Me.txt_nome.ForeColor = System.Drawing.SystemColors.WindowText
        resources.ApplyResources(Me.txt_nome, "txt_nome")
        Me.txt_nome.Name = "txt_nome"
        '
        'lbl_idade
        '
        resources.ApplyResources(Me.lbl_idade, "lbl_idade")
        Me.lbl_idade.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_idade.Name = "lbl_idade"
        '
        'num_idade
        '
        Me.num_idade.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me.num_idade, "num_idade")
        Me.num_idade.Name = "num_idade"
        '
        'txt_animal
        '
        Me.txt_animal.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me.txt_animal, "txt_animal")
        Me.txt_animal.Name = "txt_animal"
        '
        'lbl_animal
        '
        resources.ApplyResources(Me.lbl_animal, "lbl_animal")
        Me.lbl_animal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_animal.Name = "lbl_animal"
        '
        'lbl_genero
        '
        resources.ApplyResources(Me.lbl_genero, "lbl_genero")
        Me.lbl_genero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_genero.Name = "lbl_genero"
        '
        'radio_masc
        '
        resources.ApplyResources(Me.radio_masc, "radio_masc")
        Me.radio_masc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.radio_masc.Name = "radio_masc"
        Me.radio_masc.TabStop = true
        Me.radio_masc.UseVisualStyleBackColor = true
        '
        'radio_fem
        '
        resources.ApplyResources(Me.radio_fem, "radio_fem")
        Me.radio_fem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.radio_fem.Name = "radio_fem"
        Me.radio_fem.TabStop = true
        Me.radio_fem.UseVisualStyleBackColor = true
        '
        'radio_outro
        '
        resources.ApplyResources(Me.radio_outro, "radio_outro")
        Me.radio_outro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.radio_outro.Name = "radio_outro"
        Me.radio_outro.TabStop = true
        Me.radio_outro.UseVisualStyleBackColor = true
        '
        'lbl_estacao
        '
        resources.ApplyResources(Me.lbl_estacao, "lbl_estacao")
        Me.lbl_estacao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_estacao.Name = "lbl_estacao"
        '
        'cb_estacao
        '
        Me.cb_estacao.BackColor = System.Drawing.Color.Lavender
        Me.cb_estacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estacao.FormattingEnabled = true
        Me.cb_estacao.Items.AddRange(New Object() {resources.GetString("cb_estacao.Items"), resources.GetString("cb_estacao.Items1"), resources.GetString("cb_estacao.Items2"), resources.GetString("cb_estacao.Items3")})
        resources.ApplyResources(Me.cb_estacao, "cb_estacao")
        Me.cb_estacao.Name = "cb_estacao"
        '
        'lbl_teste
        '
        resources.ApplyResources(Me.lbl_teste, "lbl_teste")
        Me.lbl_teste.Name = "lbl_teste"
        '
        'gp_calculadora
        '
        Me.gp_calculadora.Controls.Add(Me.lbl_aguardando)
        Me.gp_calculadora.Controls.Add(Me.cmd_calcular)
        Me.gp_calculadora.Controls.Add(Me.lbl_textocalc)
        Me.gp_calculadora.Controls.Add(Me.num_2)
        Me.gp_calculadora.Controls.Add(Me.num_1)
        Me.gp_calculadora.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.gp_calculadora, "gp_calculadora")
        Me.gp_calculadora.Name = "gp_calculadora"
        Me.gp_calculadora.TabStop = false
        '
        'lbl_aguardando
        '
        resources.ApplyResources(Me.lbl_aguardando, "lbl_aguardando")
        Me.lbl_aguardando.Name = "lbl_aguardando"
        '
        'cmd_calcular
        '
        Me.cmd_calcular.BackColor = System.Drawing.Color.MidnightBlue
        resources.ApplyResources(Me.cmd_calcular, "cmd_calcular")
        Me.cmd_calcular.Name = "cmd_calcular"
        Me.cmd_calcular.UseVisualStyleBackColor = false
        '
        'lbl_textocalc
        '
        resources.ApplyResources(Me.lbl_textocalc, "lbl_textocalc")
        Me.lbl_textocalc.Name = "lbl_textocalc"
        '
        'num_2
        '
        Me.num_2.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me.num_2, "num_2")
        Me.num_2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.num_2.Name = "num_2"
        '
        'num_1
        '
        Me.num_1.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me.num_1, "num_1")
        Me.num_1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.num_1.Name = "num_1"
        '
        'lbl_cadastro
        '
        resources.ApplyResources(Me.lbl_cadastro, "lbl_cadastro")
        Me.lbl_cadastro.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_cadastro.Name = "lbl_cadastro"
        '
        'dgv_dados
        '
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.GridColor = System.Drawing.Color.LightSalmon
        resources.ApplyResources(Me.dgv_dados, "dgv_dados")
        Me.dgv_dados.Name = "dgv_dados"
        '
        'cmd_novo
        '
        Me.cmd_novo.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_novo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.cmd_novo, "cmd_novo")
        Me.cmd_novo.Name = "cmd_novo"
        Me.cmd_novo.UseVisualStyleBackColor = false
        '
        'cmd_deletar
        '
        Me.cmd_deletar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_deletar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.cmd_deletar, "cmd_deletar")
        Me.cmd_deletar.Name = "cmd_deletar"
        Me.cmd_deletar.UseVisualStyleBackColor = false
        '
        'lbl_id
        '
        resources.ApplyResources(Me.lbl_id, "lbl_id")
        Me.lbl_id.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_id.Name = "lbl_id"
        '
        'num_id
        '
        Me.num_id.BackColor = System.Drawing.Color.Lavender
        resources.ApplyResources(Me.num_id, "num_id")
        Me.num_id.Name = "num_id"
        '
        'lbl_deletar
        '
        resources.ApplyResources(Me.lbl_deletar, "lbl_deletar")
        Me.lbl_deletar.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_deletar.Name = "lbl_deletar"
        '
        'lbl_novo
        '
        resources.ApplyResources(Me.lbl_novo, "lbl_novo")
        Me.lbl_novo.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_novo.Name = "lbl_novo"
        '
        'radio_oledb
        '
        resources.ApplyResources(Me.radio_oledb, "radio_oledb")
        Me.radio_oledb.Name = "radio_oledb"
        Me.radio_oledb.TabStop = true
        Me.radio_oledb.UseVisualStyleBackColor = true
        '
        'radio_sql
        '
        resources.ApplyResources(Me.radio_sql, "radio_sql")
        Me.radio_sql.Name = "radio_sql"
        Me.radio_sql.TabStop = true
        Me.radio_sql.UseVisualStyleBackColor = true
        '
        'cmd_conectar
        '
        Me.cmd_conectar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_conectar.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.cmd_conectar, "cmd_conectar")
        Me.cmd_conectar.Name = "cmd_conectar"
        Me.cmd_conectar.UseVisualStyleBackColor = false
        '
        'txt_gambiarra
        '
        resources.ApplyResources(Me.txt_gambiarra, "txt_gambiarra")
        Me.txt_gambiarra.Name = "txt_gambiarra"
        '
        'gp_access
        '
        Me.gp_access.Controls.Add(Me.radio_oracle)
        Me.gp_access.Controls.Add(Me.radio_sql)
        Me.gp_access.Controls.Add(Me.radio_oledb)
        Me.gp_access.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.gp_access, "gp_access")
        Me.gp_access.Name = "gp_access"
        Me.gp_access.TabStop = false
        '
        'radio_oracle
        '
        resources.ApplyResources(Me.radio_oracle, "radio_oracle")
        Me.radio_oracle.Name = "radio_oracle"
        Me.radio_oracle.TabStop = true
        Me.radio_oracle.UseVisualStyleBackColor = true
        '
        'cmd_editar
        '
        Me.cmd_editar.BackColor = System.Drawing.Color.MidnightBlue
        Me.cmd_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.cmd_editar, "cmd_editar")
        Me.cmd_editar.Name = "cmd_editar"
        Me.cmd_editar.UseVisualStyleBackColor = false
        '
        'lbl_editar
        '
        resources.ApplyResources(Me.lbl_editar, "lbl_editar")
        Me.lbl_editar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_editar.Name = "lbl_editar"
        '
        'cmd_limpar
        '
        Me.cmd_limpar.BackColor = System.Drawing.Color.White
        Me.cmd_limpar.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.cmd_limpar, "cmd_limpar")
        Me.cmd_limpar.Name = "cmd_limpar"
        Me.cmd_limpar.UseVisualStyleBackColor = false
        '
        'lbl_aviso
        '
        resources.ApplyResources(Me.lbl_aviso, "lbl_aviso")
        Me.lbl_aviso.Name = "lbl_aviso"
        '
        'SkinManager1
        '
        Me.SkinManager1.Controls = Nothing
        Me.SkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Managed
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = false
        '
        'btn_eua
        '
        resources.ApplyResources(Me.btn_eua, "btn_eua")
        Me.btn_eua.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.eua
        Me.btn_eua.Name = "btn_eua"
        Me.btn_eua.UseVisualStyleBackColor = true
        '
        'btn_brasil
        '
        resources.ApplyResources(Me.btn_brasil, "btn_brasil")
        Me.btn_brasil.BackgroundImage = Global.CadastroDeAlunoTeste.My.Resources.Resources.brasil
        Me.btn_brasil.Name = "btn_brasil"
        Me.btn_brasil.UseVisualStyleBackColor = true
        '
        'lbl_nome
        '
        Me.lbl_nome.ActiveViewIndex = 0
        Me.lbl_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_nome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.lbl_nome, "lbl_nome")
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.ReportSource = Me.CrystalReportF1
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.Controls.Add(Me.btn_eua)
        Me.Controls.Add(Me.btn_brasil)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.lbl_aviso)
        Me.Controls.Add(Me.cmd_limpar)
        Me.Controls.Add(Me.lbl_editar)
        Me.Controls.Add(Me.cmd_editar)
        Me.Controls.Add(Me.gp_access)
        Me.Controls.Add(Me.lbl_cadastro)
        Me.Controls.Add(Me.txt_gambiarra)
        Me.Controls.Add(Me.cmd_conectar)
        Me.Controls.Add(Me.lbl_novo)
        Me.Controls.Add(Me.lbl_deletar)
        Me.Controls.Add(Me.num_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.cmd_deletar)
        Me.Controls.Add(Me.cmd_novo)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.gp_calculadora)
        Me.Controls.Add(Me.lbl_teste)
        Me.Controls.Add(Me.cb_estacao)
        Me.Controls.Add(Me.lbl_estacao)
        Me.Controls.Add(Me.radio_outro)
        Me.Controls.Add(Me.radio_fem)
        Me.Controls.Add(Me.radio_masc)
        Me.Controls.Add(Me.lbl_genero)
        Me.Controls.Add(Me.lbl_animal)
        Me.Controls.Add(Me.txt_animal)
        Me.Controls.Add(Me.num_idade)
        Me.Controls.Add(Me.lbl_idade)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lbl_frm_nome)
        Me.Controls.Add(Me.cmd_cadastro)
        Me.Name = "Form1"
        CType(Me.num_idade,System.ComponentModel.ISupportInitialize).EndInit
        Me.gp_calculadora.ResumeLayout(false)
        Me.gp_calculadora.PerformLayout
        CType(Me.num_2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.num_1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgv_dados,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.num_id,System.ComponentModel.ISupportInitialize).EndInit
        Me.gp_access.ResumeLayout(false)
        Me.gp_access.PerformLayout
        CType(Me.ProjetoBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NovobancoDataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents cmd_cadastro As Button
    Friend WithEvents lbl_frm_nome As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_idade As Label
    Friend WithEvents num_idade As NumericUpDown
    Friend WithEvents txt_animal As TextBox
    Friend WithEvents lbl_animal As Label
    Friend WithEvents lbl_genero As Label
    Friend WithEvents radio_masc As RadioButton
    Friend WithEvents radio_fem As RadioButton
    Friend WithEvents radio_outro As RadioButton
    Friend WithEvents lbl_estacao As Label
    Friend WithEvents cb_estacao As ComboBox
    Friend WithEvents lbl_teste As Label
    Friend WithEvents gp_calculadora As GroupBox
    Friend WithEvents lbl_aguardando As Label
    Friend WithEvents cmd_calcular As Button
    Friend WithEvents lbl_textocalc As Label
    Friend WithEvents num_2 As NumericUpDown
    Friend WithEvents num_1 As NumericUpDown
    Friend WithEvents lbl_cadastro As Label
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents NovobancoDataSet As novobancoDataSet
    Friend WithEvents ProjetoBindingSource As BindingSource
    Friend WithEvents ProjetoTableAdapter As novobancoDataSetTableAdapters.ProjetoTableAdapter
    Friend WithEvents cmd_novo As Button
    Friend WithEvents cmd_deletar As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents num_id As NumericUpDown
    Friend WithEvents lbl_deletar As Label
    Friend WithEvents lbl_novo As Label
    Friend WithEvents radio_oledb As RadioButton
    Friend WithEvents radio_sql As RadioButton
    Friend WithEvents cmd_conectar As Button
    Friend WithEvents txt_gambiarra As TextBox
    Friend WithEvents gp_access As GroupBox
    Friend WithEvents cmd_editar As Button
    Friend WithEvents lbl_editar As Label
    Friend WithEvents radio_oracle As RadioButton
    Friend WithEvents cmd_limpar As Button
    Friend WithEvents lbl_aviso As RichTextBox
    Friend WithEvents SkinManager1 As Syncfusion.Windows.Forms.SkinManager
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_nome As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportF1 As CrystalReportF
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_brasil As Button
    Friend WithEvents btn_eua As Button
End Class

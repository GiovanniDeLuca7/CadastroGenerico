Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ApplicationBlocks.Data
'fazer um design diferente no Crystal Reports
'usar linha do codigo para fazer uma formula
'ordenar as linhas po 


Public Class Form1
    Private connString As String
    Private conn As IDbConnection = Nothing
    Private adapter As IDbDataAdapter = Nothing
    Private m_dbHelper As IDBHelper
    Private m_dbConn As IDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NovobancoDataSet.Projeto' table. You can move, or remove it, as needed.
        Me.ProjetoTableAdapter.Fill(Me.NovobancoDataSet.Projeto)
        num_1.Text = ""
        num_2.Text = ""
        num_idade.Text = ""

        Dim t As CadastroDeAlunoTeste.DataSetProjetoF
    End Sub

    Public Function GetDatasetProject() As DataSet
        Dim sql As String = "SELECT * FROM Projeto"

        If radio_oledb.Checked Then
            Dim oleDbHelper As New OleDBDbHelper
            Dim conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=T:\CadastroDeAlunoRef\CadastroDeAlunoTeste\bin\x86\Debug\novobanco.mdb"
            m_dbHelper = oleDbHelper
            m_dbConn = oleDbHelper.NewConnection(conString)
            m_dbConn.Open()

        ElseIf radio_sql.Checked Then
            Dim sqlDbHelper As New SqlDbHelper
            Dim conString = "Data Source=DB2012\SQLEXPRESS2008R2;Initial Catalog=novobanco;User ID=sa;Password=admin"
            m_dbHelper = sqlDbHelper
            m_dbConn = sqlDbHelper.NewConnection(conString)
            m_dbConn.Open()

        ElseIf radio_oracle.Checked Then
            Dim oracleDbHelper As New MSOracleDbHelper
            oracleDbHelper.QuotePrefix = """"
            oracleDbHelper.QuoteSuffix = """"
            Dim conString = "Data Source=(DESCRIPTION=(ADDRESS_LIST =(ADDRESS=(PROTOCOL=TCP) (HOST=DB2012) (PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=XE))); User Id=isoplan; Password=admin;"
            oracleDbHelper.SetOracleDllDirectory("P:\vnetprojects2008\libs\instantclient_11_2")
            m_dbHelper = oracleDbHelper
            m_dbConn = oracleDbHelper.NewConnection(conString)
            m_dbConn.Open()
        Else
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Nenhuma conexão realizada :("
        End If

        Dim ds = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql)
        Return ds
    End Function

    Private Sub cmd_conectar_Click(sender As Object, e As EventArgs) Handles cmd_conectar.Click
        Try
            Dim ds As DataSet = GetDatasetProject()
            dgv_dados.DataSource = ds.Tables(0).DefaultView

            Dim m_rptDoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            m_rptDoc.Load("T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\CrystalReportF.rpt", CrystalDecisions.[Shared].OpenReportMethod.OpenReportByDefault)

            ds.Tables(0).TableName = "Projeto"
            m_rptDoc.Database.Tables(0).SetDataSource(ds)
            Crystal_1.ReportSource = m_rptDoc
         
            lbl_aviso.Text = ""
            Crystal_1.Visible = true
        Catch
            Console.WriteLine("Ocorreu um erro fatal... ")
        End Try
    End Sub

    Public Sub Relatorio()
        Dim dsProj = New DataSetProjetoF
        Dim dt = dsProj.Projeto
        Dim dsdb As DataSet = GetDatasetProject()
        For Each drdb In dsdb.Tables(0).Rows
            Dim drNew = dt.NewProjetoRow
            drNew.Id = drdb("Id")
            drNew.Nome = drdb("Nome")
            drNew.Idade = drdb("Idade")
            drNew.Genero = drdb("Genero")
            drNew.Animal = drdb("Animal")
            drNew.Estacao = drdb("Estacao")
            drNew.Numero1 = drdb("Numero1")
            drNew.Numero2 = drdb("Numero2")
            dt.Rows.Add(drNew)
        Next
    End Sub

    Private Sub cmd_novo_Click(sender As Object, e As EventArgs) Handles cmd_novo.Click

        Try
            If num_1.Text = "" Then
                num_1.Text = "0"
            End If
            If num_2.Text = "" Then
                num_2.Text = "0"
            End If
            If num_idade.Text = "" Then
                num_idade.Text = "0"
            End If

            Dim dsLido As DataSet
            Dim sql = "SELECT * FROM Projeto"
            dsLido = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql)
            Dim drLido = dsLido.Tables(0).NewRow()
            drLido("Nome") = txt_nome.Text
            drLido("Idade") = num_idade.Text
            drLido("Animal") = txt_animal.Text
            drLido("Estacao") = cb_estacao.Text
            drLido("Numero1") = num_1.Text
            drLido("Numero2") = num_2.Text
            drLido("Genero") = txt_gambiarra.Text
            drLido("Id") = num_id.Text

            If radio_oledb.Checked Then
                Dim oleDbHelper As New OleDBDbHelper
                m_dbHelper = oleDbHelper

            ElseIf radio_sql.Checked Then
                Dim sqlDbHelper As New SqlDbHelper
                m_dbHelper = sqlDbHelper

            ElseIf radio_oracle.Checked Then
                Dim OracleDbHelper As New MSOracleDbHelper
                m_dbHelper = OracleDbHelper
            End If

            Dim param1 = m_dbHelper.NewParameter("@Nome", drLido("Nome"))
            Dim param2 = m_dbHelper.NewParameter("@Idade", drLido("Idade"))
            Dim param3 = m_dbHelper.NewParameter("@Animal", drLido("Animal"))
            Dim param4 = m_dbHelper.NewParameter("@Estacao", drLido("Estacao"))
            Dim param5 = m_dbHelper.NewParameter("@Num1", drLido("Numero1"))
            Dim param6 = m_dbHelper.NewParameter("@Num2", drLido("Numero2"))
            If radio_masc.Checked Then
                txt_gambiarra.Text = "Masculino"
            ElseIf radio_fem.Checked Then
                txt_gambiarra.Text = "Feminino"
            ElseIf radio_outro.Checked Then
                txt_gambiarra.Text = "Outro"
            End If
            Dim param7 = m_dbHelper.NewParameter("@Genero", drLido("Genero"))
            Dim param8 = m_dbHelper.NewParameter("@Id", drLido("Id"))
            Dim params = New IDataParameter() {param1, param2, param3, param4, param5, param6, param7, param8}
            sql = "INSERT INTO Projeto (Nome, Idade, Animal, Estacao, Numero1, Numero2, Genero, Id) VALUES (@Nome, @Idade, @Animal, @Estacao, @Num1, @Num2, @Genero, @Id)"
            Dim affected = m_dbHelper.ExecuteNonQuery(m_dbConn, CommandType.Text, sql, params)
            cmd_conectar.PerformClick()
            lbl_aviso.Text = ""
            lbl_aviso.Visible = False
        Catch
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Erro! O Id inserido já está sendo usado ou é inválido"
        End Try
    End Sub

    Private Sub cmd_deletar_Click(sender As Object, e As EventArgs) Handles cmd_deletar.Click
        Try
            Dim dsLido As DataSet
            Dim sql = "SELECT * FROM Projeto"
            dsLido = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql)


            If radio_oledb.Checked Then
                Dim oleDbHelper As New OleDBDbHelper
                m_dbHelper = oleDbHelper

            ElseIf radio_sql.Checked Then
                Dim sqlDbHelper As New SqlDbHelper
                m_dbHelper = sqlDbHelper

            ElseIf radio_oracle.Checked Then
                Dim OracleDbHelper As New MSOracleDbHelper
                m_dbHelper = OracleDbHelper

            End If
            sql = "DELETE FROM Projeto WHERE Id = @Id"
            Dim param7 = m_dbHelper.NewParameter("@Id", num_id.Text)
            Dim affected = m_dbHelper.ExecuteNonQuery(m_dbConn, CommandType.Text, sql, param7)
            cmd_conectar.PerformClick()

        Catch
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Erro! ID não existente, selecione uma linha já criada!"
        End Try
    End Sub

    Private Sub cmd_editar_Click(sender As Object, e As EventArgs) Handles cmd_editar.Click
        Try
            Dim dsLido As DataSet

            Dim sql = "SELECT * FROM Projeto WHERE Id = @Id"
            Dim paramId = m_dbHelper.NewParameter("@Id", num_id.Text)

            dsLido = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql, paramId)

            'dgv_dados.Rows(0).Selected

            Dim drLido = dsLido.Tables(0).Rows(0)

            If txt_nome.Text <> "" Then
                drLido("Nome") = txt_nome.Text
            End If

            If num_idade.Text <> "" Or "0" Then
                drLido("Idade") = num_idade.Text
            End If

            If txt_animal.Text <> "" Then
                drLido("Animal") = txt_animal.Text
            End If

            If cb_estacao.Text <> "" Then
                drLido("Estacao") = cb_estacao.Text
            End If

            If num_1.Text <> "" Or "0" Then
                drLido("Numero1") = num_1.Text
            End If

            If num_2.Text <> "" Or "0" Then
                drLido("Numero2") = num_2.Text
            End If

            If txt_gambiarra.Text <> "" Then
                drLido("Genero") = txt_gambiarra.Text
            End If


            If radio_oledb.Checked Then
                Dim oleDbHelper As New OleDBDbHelper
                m_dbHelper = oleDbHelper

            ElseIf radio_sql.Checked Then
                Dim sqlDbHelper As New SqlDbHelper
                m_dbHelper = sqlDbHelper

            ElseIf radio_oracle.Checked Then
                Dim OracleDbHelper As New MSOracleDbHelper
                m_dbHelper = OracleDbHelper

            End If

            Dim param1 = m_dbHelper.NewParameter("@Nome", drLido("Nome"))
            Dim param2 = m_dbHelper.NewParameter("@Idade", drLido("Idade"))
            Dim param3 = m_dbHelper.NewParameter("@Animal", drLido("Animal"))
            Dim param4 = m_dbHelper.NewParameter("@Estacao", drLido("Estacao"))
            Dim param5 = m_dbHelper.NewParameter("@Num1", drLido("Numero1"))
            Dim param6 = m_dbHelper.NewParameter("@Num2", drLido("Numero2"))
            If radio_masc.Checked Then
                txt_gambiarra.Text = "Masculino"
            ElseIf radio_fem.Checked Then
                txt_gambiarra.Text = "Feminino"
            ElseIf radio_outro.Checked Then
                txt_gambiarra.Text = "Outro"
            End If
            Dim param7 = m_dbHelper.NewParameter("@Genero", drLido("Genero"))
            Dim param8 = m_dbHelper.NewParameter("@Id", num_id.Text)
            sql = "UPDATE Projeto SET Nome = @Nome, Idade = @Idade, Animal = @Animal, Estacao = @Estacao, Numero1 = @Num1, Numero2 = @Num2, Genero = @Genero WHERE Id = @Id"
            Dim params = New IDataParameter() {param1, param2, param3, param4, param5, param6, param7, param8}
            Dim affected = m_dbHelper.ExecuteNonQuery(m_dbConn, CommandType.Text, sql, params)
            cmd_conectar.PerformClick()
            lbl_aviso.Visible = False
            lbl_aviso.Text = ""
        Catch
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Erro! ID não existente, selecione uma linha já criada!"
        End Try
    End Sub

    Private Sub cmd_cadastro_Click(sender As Object, e As EventArgs) Handles cmd_cadastro.Click
        lbl_cadastro.Visible = True
        lbl_cadastro.Text = "Salvo com Sucesso"
        Dim texto As String = txt_nome.Text
        Dim idade As String = num_idade.Text
        Dim animal As String = txt_animal.Text
        Dim estacao As String = cb_estacao.Text
        Dim id As String = num_id.Text
        Dim genero As String = txt_gambiarra.Text
        ClassSalvar.Salvar(texto, genero, idade, animal, estacao, id)
        Shell("NotePad.Exe ""T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\Debugsalvo.txt""", 1)
    End Sub

    Private Sub cmd_calcular_Click(sender As Object, e As EventArgs) Handles cmd_calcular.Click
        Try
            lbl_aguardando.Visible = True
            lbl_aguardando.Text = "Pronto!"
            Dim numero1 As Integer = num_1.Text
            Dim numero2 As Integer = num_2.Text
            ClassSalvar.Calculadora(numero1, numero2)
            Shell("NotePad.Exe ""T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\Debugcalc.txt""", 1)
        Catch
            lbl_aguardando.Visible = True
            lbl_aguardando.Text = "Insira os numeros antes!"
        End Try
    End Sub

    Private Sub cmd_limpar_Click(sender As Object, e As EventArgs) Handles cmd_limpar.Click
        txt_nome.Text = ""
        num_idade.Text = ""
        txt_animal.Text = ""
        radio_masc.Checked = False
        radio_fem.Checked = False
        radio_outro.Checked = False
        cb_estacao.SelectedIndex = -1
        num_id.Text = 0
        num_1.Text = ""
        num_2.Text = ""
        radio_oledb.Checked = False
        radio_sql.Checked = False
        radio_oracle.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sql = "SELECT * FROM Projeto"
            Dim ds = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql)
            Dim result = From Projeto In ds.Tables(0).AsEnumerable() Where (Projeto.Field(Of String)("Genero") = "Feminino") Select New With {.Nome = Projeto.Field(Of String)("Nome"), .Animal = Projeto.Field(Of String)("Animal"), .Genero = Projeto.Field(Of String)("Genero"), .Idade = Projeto.Field(Of Integer)("Idade"), .Numero1 = Projeto.Field(Of Integer)("Numero1"), .Numero2 = Projeto.Field(Of Integer)("Numero2")}
            Dim orders As DataTable = ds.Tables(0)
            Dim query =
            From dr In orders.AsEnumerable()
            Where dr.Field(Of String)("Nome").Contains("l")
            Order By dr("Genero").ToString()
            Select dr
            dgv_dados.DataSource = ds.Tables(0).DefaultView
            lbl_aviso.Visible = False
            dgv_dados.DataSource = query.AsDataView()
        Catch
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Erro! Conecte-se ao banco de dados!"
        End Try
    End Sub
End Class

'trocar sDBstr por conexao
'cn por conexao
'sSQL por selectSQL
'oCn por OleDbConexao
'oDA por OleDbDataAdaptador
'oDs por OleDbDataSetagem

'...
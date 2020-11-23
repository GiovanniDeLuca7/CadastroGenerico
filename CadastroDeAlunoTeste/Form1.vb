﻿Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports ApplicationBlocks.Data
Imports System.Threading.Tasks
Imports System.Threading.Thread
Imports System.Globalization
Imports CadastroDeAlunoTeste.My.Resources
Imports System.Threading
Imports Syncfusion.XlsIO
Imports System.Reflection

'Module Program1

Public Class Form1
    Public Property StringPass As String
    Private connString As String
    Private conn As IDbConnection = Nothing
    Private adapter As IDbDataAdapter = Nothing
    Private m_dbHelper As IDBHelper
    Private m_dbConn As IDbConnection

    Public Sub New()
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
        Me.Controls.Clear()
        InitializeComponent()
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProjetoTableAdapter.Fill(Me.NovobancoDataSet.Projeto)
        num_1.Text = ""
        num_2.Text = ""
        num_idade.Text = ""
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
            lbl_aviso.Text = Res.Aviso
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
            Dim rptObjects = m_rptDoc.ReportDefinition.ReportObjects
            Dim Formula = m_rptDoc.DataDefinition.FormulaFields.Item("teste")
            Formula.Text = "{Projeto.Numero1}+{Projeto.Numero2}"
            Dim errorText As String = ""
            Dim checked = Formula.Check(errorText)

            If Not checked Then
                Throw New InvalidOperationException($"Erro formula {Formula.Name} {errorText}")
            End If
            ds.Tables(0).TableName = "Projeto"
            m_rptDoc.Database.Tables(0).SetDataSource(ds)
            lbl_nome.ReportSource = m_rptDoc
            lbl_aviso.Text = ""
            lbl_nome.Visible = True
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro fatal... Erro: " & ex.ToString())
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
            Throw New System.Exception("An exception has occurred.")
            lbl_aviso.Visible = True
            lbl_aviso.Text = "Erro! ID não existente, selecione uma linha já criada!"
        End Try
    End Sub

    Private Sub cmd_cadastro_Click(sender As Object, e As EventArgs) Handles cmd_cadastro.Click
        lbl_cadastro.Visible = True
        lbl_cadastro.Text = Res.Sucesso
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
            lbl_aguardando.Text = Res.Pronto
            Dim numero1 As Integer = num_1.Text
            Dim numero2 As Integer = num_2.Text
            ClassSalvar.Calculadora(numero1, numero2)
            Shell("NotePad.Exe ""T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\Debugcalc.txt""", 1)
            Dim ratio As Double = num_1.Text
            Dim result As String =
            String.Format("String = {0:0%}", ratio)
            lbl_aviso.Visible = True
            lbl_aviso.Text = result
        Catch
            lbl_aguardando.Visible = True
            lbl_aguardando.Text = Res.InsiraOsNumeros
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
            Dim EscolherCampo As String
            EscolherCampo = InputBox("Coloque o número relativo ao campo que deseja pesquisar: 1 - Nome / 2 - Idade / 3 - Id / 4 - Animal")
            Dim InputUser As String
            If EscolherCampo = "1"
                EscolherCampo = "Nome"
                InputUser = InputBox("Escreva uma nome ou letra que deseja pesquisar: ")
            Else If EscolherCampo = "2"
                EscolherCampo = "Idade"
                InputUser = InputBox("Escreva uma idade que deseja pesquisar: ")
            Else If EscolherCampo = "3"
                EscolherCampo = "Id"
                InputUser = InputBox("Escreva um Id que deseja pesquisar: ")
            Else If EscolherCampo = "4"
                EscolherCampo = "Animal"
                InputUser = InputBox("Escreva um animal ou letra que deseja pesquisar: ")
            Else
                MsgBox("O número digitado não condiz com nenhum campo, tente novamente")
            End If
            Dim sql = "SELECT * FROM Projeto"
            Dim ds = m_dbHelper.ExecuteDataset(m_dbConn, CommandType.Text, sql)
            Dim result = From Projeto In ds.Tables(0).AsEnumerable() Where (Projeto.Field(Of String)("Genero") = "Feminino") Select New With {.Nome = Projeto.Field(Of String)("Nome"), .Animal = Projeto.Field(Of String)("Animal"), .Genero = Projeto.Field(Of String)("Genero"), .Idade = Projeto.Field(Of Integer)("Idade"), .Numero1 = Projeto.Field(Of Integer)("Numero1"), .Numero2 = Projeto.Field(Of Integer)("Numero2")}
            Dim orders As DataTable = ds.Tables(0)
            Dim query =
            From dr In orders.AsEnumerable()
            Where dr.Field(Of String)(EscolherCampo).Contains(InputUser)
            Order By dr("Nome").ToString()
            Select dr
            dgv_dados.DataSource = ds.Tables(0).DefaultView
            lbl_aviso.Visible = False
            dgv_dados.DataSource = query.AsDataView()
        Catch
            lbl_aviso.Visible = True
            lbl_aviso.Text = Res.LinqErro
        End Try
    End Sub

    Private Sub btn_brasil_Click(sender As Object, e As EventArgs) Handles btn_brasil.Click
      Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
       Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
       Me.Controls.Clear()
       InitializeComponent()
    End Sub

    Private Sub btn_eua_Click(sender As Object, e As EventArgs) Handles btn_eua.Click
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Me.Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub btn_frc_Click(sender As Object, e As EventArgs) Handles btn_frc.Click
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("fr")
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("fr")
        Me.Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim DataHoraAtual As DateTime = Now
        lbl_data.Text = Res.Data & DataHoraAtual.ToShortDateString & Res.Hora & DataHoraAtual.ToShortTimeString
    End Sub

    Private Sub radio_masc_CheckedChanged(sender As Object, e As EventArgs) Handles radio_masc.CheckedChanged
        txt_gambiarra.Text = "Masculino"
    End Sub

    Private Sub radio_fem_CheckedChanged(sender As Object, e As EventArgs) Handles radio_fem.CheckedChanged
        txt_gambiarra.Text = "Feminino"
    End Sub

    Private Sub radio_outro_CheckedChanged(sender As Object, e As EventArgs) Handles radio_outro.CheckedChanged
        txt_gambiarra.Text = "Outro"
    End Sub

    Private Sub MandarEmailToolStripMenuItem_Click(sender As System.Object, ByVal e As System.EventArgs) Handles MandarEmailToolStripMenuItem.Click
        Me.Hide()
        Dim frmtemp As Form2 = New Form2("Nome: " & txt_nome.Text & vbCrLf & "Idade: " & num_idade.Text & vbCrLf & "Animal: " & txt_animal.Text & vbCrLf & "Genero: " & txt_gambiarra.Text  & vbCrLf & "Estação: " & cb_estacao.Text & vbCrLf & "Id: " & num_id.Text & vbCrLf & "Numero1: " & num_1.Text & vbCrLf & "Numero2: " & num_2.Text & vbCrLf & lbl_data.Text)
        frmtemp.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Idioma.Show()
    End Sub

    Private Sub cmd_anterior_Click(sender As Object, e As EventArgs) Handles cmd_anterior.Click
        Try
            Dim i As Integer = dgv_dados.CurrentRow.Index - 1
            txt_nome.Text = dgv_dados.Item(1, i).Value
            txt_animal.Text = dgv_dados.Item(2,i).Value
            num_idade.Text = dgv_dados.Item(3, i).Value
            txt_gambiarra.Text = dgv_dados.Item(4, i).Value
            If txt_gambiarra.Text = "Feminino"
                radio_fem.Checked = True
            Else If txt_gambiarra.Text = "Masculino"
                radio_masc.Checked = True
            Else If txt_gambiarra.Text = "Outro"
                radio_outro.Checked = True
            Else
                radio_fem.Checked = False
                radio_masc.Checked = False
                radio_outro.Checked = False
            End If
            cb_estacao.Text = dgv_dados.Item(5, i).Value
            num_1.Text = dgv_dados.Item(6, i).Value
            num_2.Text = dgv_dados.Item(7, i).Value
            num_id.Text = dgv_dados.Item(8, i).Value
            Me.dgv_dados.CurrentCell = Me.dgv_dados.Rows(i).Cells(0)
            Me.dgv_dados.Rows(i).Selected = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
         
    End Sub

    Private Sub cmd_proximo_Click(sender As Object, e As EventArgs) Handles cmd_proximo.Click
        Try
            Dim i As Integer = dgv_dados.CurrentRow.Index + 1
            txt_nome.Text = dgv_dados.Item(1, i).Value
            txt_animal.Text = dgv_dados.Item(2,i).Value
            num_idade.Text = dgv_dados.Item(3, i).Value
            txt_gambiarra.Text = dgv_dados.Item(4, i).Value
            If txt_gambiarra.Text = "Feminino"
                radio_fem.Checked = True
            Else If txt_gambiarra.Text = "Masculino"
                radio_masc.Checked = True
            Else If txt_gambiarra.Text = "Outro"
                radio_outro.Checked = True
            Else
                radio_fem.Checked = False
                radio_masc.Checked = False
                radio_outro.Checked = False
            End If
            cb_estacao.Text = dgv_dados.Item(5, i).Value
            num_1.Text = dgv_dados.Item(6, i).Value
            num_2.Text = dgv_dados.Item(7, i).Value
            num_id.Text = dgv_dados.Item(8, i).Value
            Me.dgv_dados.CurrentCell = Me.dgv_dados.Rows(i).Cells(0)
            Me.dgv_dados.Rows(i).Selected = True 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

        Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        Try
            Using excelEngine As ExcelEngine = New ExcelEngine()
            Dim application As IApplication = excelEngine.Excel
            application.DefaultVersion = ExcelVersion.Excel2010
            Dim workbook As IWorkbook = application.Workbooks.Create(1)
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            worksheet.Range("A1").Text = "Nome:"
            worksheet.Range("B1").Text = txt_nome.Text
            worksheet.Range("A2").Text = "Idade:"
            worksheet.Range("B2").Number = num_idade.Text
            worksheet.Range("A3").Text = "Animal:"
            worksheet.Range("B3").Text = txt_animal.Text
            worksheet.Range("A4").Text = "Genero:"
            worksheet.Range("B4").Text = txt_gambiarra.Text
            worksheet.Range("A5").Text = "Estação:"
            worksheet.Range("B5").Text = cb_estacao.Text
            worksheet.Range("A6").Text = "Id:"
            worksheet.Range("B6").Number = num_id.Text
            worksheet.Range("A7").Text = "Numero 1:"
            worksheet.Range("B7").Number = num_1.Text
            worksheet.Range("A8").Text = "Numero 2:"
            worksheet.Range("B8").Number = num_2.Text
            worksheet.Range("A9").Text = "Soma:"
            worksheet.Range("B9").Formula = "SUM(B7:B8)"
            worksheet.Range("A10").Text = "Subtração:"
            worksheet.Range("B10").Formula = "B7-B8"
            worksheet.Pictures.AddPicture(12, 2, "T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\obj\Presysp.png")
            workbook.SaveAs("T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\ExcelExportado.xlsx")
        End Using
            MsgBox("O arquivo foi salvo")
            Shell("C:\Program Files (x86)\Microsoft Office\Office14\EXCEL.EXE ""T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\ExcelExportado.xlsx""", 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ImportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarToolStripMenuItem.Click
          Try
            Using excelEngine As ExcelEngine = New ExcelEngine()
            Dim app As IApplication = excelEngine.Excel
            app.DefaultVersion = ExcelVersion.Excel2010 
            OFD.Title = "Selecione um arquivo para importar"
            OFD.ShowDialog
            Dim inputFileName As String = OFD.FileName
            Dim workbook As IWorkbook = app.Workbooks.Open(inputFileName, ExcelOpenType.Automatic)
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            Dim nome As String = worksheet("B1").Text
            Dim idade As Integer = CInt(worksheet("B2").Number)
            Dim animal As String = worksheet("B3").Text
            Dim genero As String = worksheet("B4").Text
            Dim estacao As String = worksheet("B5").Text
            Dim id As Integer = CInt(worksheet("B6").Number)
            Dim num1 As Integer = CInt(worksheet("B7").Number)
            Dim num2 As Integer = CInt(worksheet("B8").Number)
            worksheet.EnableSheetCalculations()
            Dim SomaForm As String = worksheet("B9").CalculatedValue
            Dim SubForm As String = worksheet("B10").CalculatedValue
            workbook.SaveAs("T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\ExcelCopiaImportado.xlsx")
            txt_nome.Text = nome
            num_idade.Text = idade
            txt_animal.Text = animal
            If genero = "Masculino"
                    txt_gambiarra.Text = genero
                    radio_masc.Checked = true
            Else If genero = "Feminino"
                    txt_gambiarra.Text = genero
                    radio_fem.Checked =  true
           Else If  genero = "Outro"
                    txt_gambiarra.Text = genero
                    radio_outro.Checked = true
           Else
                    txt_gambiarra.Text = "N/A"
                    radio_masc.Checked = False
                    radio_fem.Checked = False
                    radio_outro.Checked = False
            End If
            cb_estacao.Text = estacao
            num_id.Text = id
            num_1.Text = num1
            num_2.Text = num2
            lbl_aguardando.Visible = True
            lbl_aguardando.Text = "Soma: " & SomaForm & ", Subtração: " & SubForm
            MsgBox("Os dados foram copiados para os campos com sucesso!")

        End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ObterModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObterModeloToolStripMenuItem.Click
        Try
            Using excelEngine As ExcelEngine = New ExcelEngine()
            Dim application As IApplication = excelEngine.Excel
            application.DefaultVersion = ExcelVersion.Excel2010
            Dim workbook As IWorkbook = application.Workbooks.Create(1)
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            worksheet.Range("A1").Text = "Nome:"
            worksheet.Range("C1").Text = "← Insira o nome aqui!"
            worksheet.Range("A2").Text = "Idade:"
            worksheet.Range("C2").Text = "← Insira a idade aqui!"
            worksheet.Range("A3").Text = "Animal:"
            worksheet.Range("C3").Text = "← Insira o animal aqui!"
            worksheet.Range("A4").Text = "Genero:"
            worksheet.Range("C4").Text = "← Insira o genero aqui! (Masculino, Feminino, Outro)"
            worksheet.Range("A5").Text = "Estação:"
            worksheet.Range("C5").Text = "← Insira a estação aqui! (Verão, Primavera, Outono, Inverno)"
            worksheet.Range("A6").Text = "Id:"
            worksheet.Range("C6").Text = "← Insira o Id aqui!"
            worksheet.Range("A7").Text = "Numero 1:"
            worksheet.Range("C7").Text = "← Insira o primeiro número aqui!"
            worksheet.Range("A8").Text = "Numero 2:"
            worksheet.Range("C8").Text = "← Insira o segundo número aqui!"
            worksheet.Range("A9").Text = "Soma:"
            worksheet.Range("B9").Formula = "SUM(B7:B8)"
            worksheet.Range("A10").Text = "Subtração:"
            worksheet.Range("B10").Formula = "B7-B8"
            worksheet.Pictures.AddPicture(12, 2, "T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\obj\Presysp.png")
            workbook.SaveAs("T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\Modelo.xlsx")
        End Using
            MsgBox("O arquivo modelo foi salvo com sucesso!")
            Shell("C:\Program Files (x86)\Microsoft Office\Office14\EXCEL.EXE ""T:\CadastroAlunoGitHub\CadastroDeAlunoTeste\bin\x86\Modelo.xlsx""", 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MusgoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusgoToolStripMenuItem.Click
        Dim myArgbColor As New Color()
        myArgbColor = Color.FromArgb(255, 0, 97, 86)
        Me.BackColor = myArgbColor

        MenuStrip1.BackColor = Color.PaleGreen
        TroqueACorToolStripMenuItem.BackColor = Color.PaleGreen
        MandarEmailToolStripMenuItem.ForeColor = Color.Black
        TroqueACorToolStripMenuItem.ForeColor = Color.Black
        PrincipalToolStripMenuItem.ForeColor = Color.Black

        cmd_cadastro.BackColor = Color.PaleGreen
        cmd_limpar.BackColor = Color.PaleGreen
        cmd_calcular.BackColor = Color.PaleGreen
        cmd_anterior.BackColor = Color.PaleGreen
        cmd_proximo.BackColor = Color.PaleGreen
        cmd_novo.BackColor = Color.PaleGreen
        cmd_deletar.BackColor = Color.PaleGreen
        cmd_editar.BackColor = Color.PaleGreen
        cmd_conectar.BackColor = Color.PaleGreen
        Button2.BackColor = Color.PaleGreen

        cmd_cadastro.ForeColor = Color.Black
        cmd_limpar.ForeColor = Color.Black
        cmd_calcular.ForeColor = Color.Black
        cmd_anterior.ForeColor = Color.Black
        cmd_proximo.ForeColor = Color.Black
        cmd_novo.ForeColor = Color.Black
        cmd_deletar.ForeColor = Color.Black
        cmd_editar.ForeColor = Color.Black
        cmd_conectar.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub RoxoPadrãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoxoPadrãoToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.MidnightBlue
        TroqueACorToolStripMenuItem.BackColor = Color.MidnightBlue 
        MandarEmailToolStripMenuItem.ForeColor = Color.White
        TroqueACorToolStripMenuItem.ForeColor = Color.White
        PrincipalToolStripMenuItem.ForeColor = Color.White

        Me.BackColor = Color.BlueViolet
        cmd_cadastro.BackColor = Color.MidnightBlue
        cmd_limpar.BackColor = Color.MidnightBlue
        cmd_calcular.BackColor = Color.MidnightBlue
        cmd_anterior.BackColor = Color.MidnightBlue
        cmd_proximo.BackColor = Color.MidnightBlue
        cmd_novo.BackColor = Color.MidnightBlue
        cmd_deletar.BackColor = Color.MidnightBlue
        cmd_editar.BackColor = Color.MidnightBlue
        cmd_conectar.BackColor = Color.MidnightBlue
        Button2.BackColor = Color.MidnightBlue

        cmd_cadastro.ForeColor = Color.White
        cmd_limpar.ForeColor = Color.White
        cmd_calcular.ForeColor = Color.White
        cmd_anterior.ForeColor = Color.White
        cmd_proximo.ForeColor = Color.White
        cmd_novo.ForeColor = Color.White
        cmd_deletar.ForeColor = Color.White
        cmd_editar.ForeColor = Color.White
        cmd_conectar.ForeColor = Color.White
        Button2.ForeColor = Color.White
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DimGray
        TroqueACorToolStripMenuItem.BackColor = Color.DimGray
        MandarEmailToolStripMenuItem.ForeColor = Color.White
        TroqueACorToolStripMenuItem.ForeColor = Color.White
        PrincipalToolStripMenuItem.ForeColor = Color.White

        Me.BackColor = Color.Black
        cmd_cadastro.BackColor = Color.DimGray
        cmd_limpar.BackColor = Color.DimGray
        cmd_calcular.BackColor = Color.DimGray
        cmd_anterior.BackColor = Color.DimGray
        cmd_proximo.BackColor = Color.DimGray
        cmd_novo.BackColor = Color.DimGray
        cmd_deletar.BackColor = Color.DimGray
        cmd_editar.BackColor = Color.DimGray
        cmd_conectar.BackColor = Color.DimGray
        Button2.BackColor = Color.DimGray

        cmd_cadastro.ForeColor = Color.White
        cmd_limpar.ForeColor = Color.White
        cmd_calcular.ForeColor = Color.White
        cmd_anterior.ForeColor = Color.White
        cmd_proximo.ForeColor = Color.White
        cmd_novo.ForeColor = Color.White
        cmd_deletar.ForeColor = Color.White
        cmd_editar.ForeColor = Color.White
        cmd_conectar.ForeColor = Color.White
        Button2.ForeColor = Color.White
    End Sub

    Private Sub ClássicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClássicoToolStripMenuItem.Click
        Me.BackColor = Color.DodgerBlue

        MenuStrip1.BackColor = Color.Silver
        TroqueACorToolStripMenuItem.BackColor = Color.Silver
        MandarEmailToolStripMenuItem.ForeColor = Color.Black
        TroqueACorToolStripMenuItem.ForeColor = Color.Black
        PrincipalToolStripMenuItem.ForeColor = Color.Black

        cmd_cadastro.BackColor = Color.Silver
        cmd_limpar.BackColor = Color.Silver
        cmd_calcular.BackColor = Color.Silver
        cmd_anterior.BackColor = Color.Silver
        cmd_proximo.BackColor = Color.Silver
        cmd_novo.BackColor = Color.Silver
        cmd_deletar.BackColor = Color.Silver
        cmd_editar.BackColor = Color.Silver
        cmd_conectar.BackColor = Color.Silver
        Button2.BackColor = Color.Silver

        cmd_cadastro.ForeColor = Color.Black
        cmd_limpar.ForeColor = Color.Black
        cmd_calcular.ForeColor = Color.Black
        cmd_anterior.ForeColor = Color.Black
        cmd_proximo.ForeColor = Color.Black
        cmd_novo.ForeColor = Color.Black
        cmd_deletar.ForeColor = Color.Black
        cmd_editar.ForeColor = Color.Black
        cmd_conectar.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
    End Sub

    
End Class
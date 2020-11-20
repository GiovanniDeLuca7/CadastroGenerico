Imports System
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

Public Class Idioma
    Public Sub New()
        InitializeComponent()
        Me.Controls.Clear()
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
    End Sub

    Private Sub btn_brasil_Click(sender As Object, e As EventArgs) Handles btn_brasil.Click, radio_br.Click
       'radio_br.Checked = true
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
       Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
       InitializeComponent()
    End Sub

    Private Sub btn_eua_Click(sender As Object, e As EventArgs) Handles btn_eua.Click, radio_eua.Click
       radio_eua.Checked = true
       Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("en-US")
       Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US") 
       InitializeComponent()
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Idioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


'System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
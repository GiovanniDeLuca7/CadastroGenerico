Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class ClassSalvar
     Public Shared Sub Salvar(ByVal texto As String, ByVal genero As String, ByVal idade As String, ByVal animal As String, ByVal estacao As String, ByVal id As String)
        Using esc_texto As New StreamWriter(Application.StartupPath & "salvo.txt")
        esc_texto.Write("O nome cadastrado foi: " & texto)
        esc_texto.Write(", de gênero " & genero)
        esc_texto.Write(", idade de " & idade)
        esc_texto.Write(" anos, animal favorito: " & animal)
        esc_texto.Write(", estação do ano predileta: " & estacao)
        esc_texto.Write(", ID= " & id)
        End Using 
     End Sub

    Public Shared Sub Calculadora(ByVal numero1 As Integer, ByVal numero2 As Integer)
        Using esc_calc As New StreamWriter(Application.StartupPath & "calc.txt")
        esc_calc.Write(numero1 & " + " & numero2 & " = " & numero1+numero2 & vbCrLf)
        esc_calc.Write(numero1 & " - " & numero2 & " = " & numero1-numero2 & vbCrLf)
        esc_calc.Write(numero1 & " * " & numero2 & " = " & numero1*numero2 & vbCrLf)
        esc_calc.Write(numero1 & " / " & numero2 & " = " & numero1/numero2 & vbCrLf)
        End Using
    End Sub
End Class
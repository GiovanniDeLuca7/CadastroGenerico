Public Class Idioma
    Private Sub btn_brasil_Click(sender As Object, e As EventArgs) Handles btn_brasil.Click
        radio_br.Checked = true
    End Sub

    Private Sub btn_eua_Click(sender As Object, e As EventArgs) Handles btn_eua.Click
       radio_eua.Checked = true
    End Sub

    Private Sub cmd_continuar_Click(sender As Object, e As EventArgs) Handles cmd_continuar.Click
        
        Me.Hide()
        Form1.Show()
    End Sub
End Class


'System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("")
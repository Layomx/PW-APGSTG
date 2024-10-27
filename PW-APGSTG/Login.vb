Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultando los group box de cada tipo de cuenta
        GBEstudiante.Hide()
    End Sub

    Private Sub AccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountType.SelectedIndexChanged
        ' Mostrar el group box correspondiente segun la eleccion
        Select Case AccountType.SelectedItem.ToString
            Case "Estudiante"
                GBEstudiante.Show()
        End Select
    End Sub
End Class

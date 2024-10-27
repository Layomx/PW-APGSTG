Public Class Login
    ' Funciones
    ' Funcion para validar correos electronicos
    Private Function IsValidEmail(ByVal Email As String) As Boolean
        Try
            ' Si el texto esta vacio se retorna verdadero para no causar falsos positivos
            If String.IsNullOrWhiteSpace(Email) Then Return True

            ' Formato basico de un email
            Dim EmailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            Return System.Text.RegularExpressions.Regex.IsMatch(Email, EmailPattern)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultando los group box de cada tipo de cuenta
        GBEstudiante.Hide()
        GBCoordinador.Hide()
    End Sub

    Private Sub AccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountType.SelectedIndexChanged
        ' Mostrando el group box correspondiente segun la eleccion
        Select Case AccountType.SelectedItem.ToString
            Case "Estudiante"
                GBCoordinador.Hide()
                GBEstudiante.Show()
            Case "Coordinador"
                GBEstudiante.Hide()
                GBCoordinador.Show()
        End Select
    End Sub

    ' Permitiendo solo letras, espacios y teclas de control en los nombres de los usuarios 
    Private Sub StudentName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentName.KeyPress
        ' Permitiendo solo letras, espacios y teclas de control
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            ' Cancelando la tecla pulsada
            e.Handled = True
        End If
    End Sub

    Private Sub CoordinatorName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CoordinatorName.KeyPress
        ' Permitiendo solo letras, espacios y teclas de control
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            ' Cancelando la tecla pulsada
            e.Handled = True
        End If
    End Sub

    ' Permitiendo solo letras, espacios y teclas de control en el apellido del usuario
    Private Sub StudentLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentLastName.KeyPress
        ' Permitiendo solo letras, espacios y teclas de control
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            ' Cancelando la tecla pulsada
            e.Handled = True
        End If
    End Sub

    Private Sub CoordinatorLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CoordinatorName.KeyPress
        ' Permitiendo solo letras, espacios y teclas de control
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            ' Cancelando la tecla pulsada
            e.Handled = True
        End If
    End Sub

    ' Validando el email en el correo de los usuarios
    Private Sub StudentEmail_TextChanged(sender As Object, e As EventArgs) Handles StudentEmail.TextChanged
        ' El color del fondo del textbox cambiara en base si el email es valido o no
        If IsValidEmail(StudentEmail.Text) Then
            StudentEmail.BackColor = Color.White
        Else
            StudentEmail.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub CoordinatorEmail_TextChanged(sender As Object, e As EventArgs) Handles CoordinatorEmail.TextChanged
        ' El color del fondo del textbox cambiara en base si el email es valido o no
        If IsValidEmail(CoordinatorEmail.Text) Then
            CoordinatorEmail.BackColor = Color.White
        Else
            CoordinatorEmail.BackColor = Color.LightPink
        End If
    End Sub

    ' Mensaje de alerta cuando se "pierde el foco" en el textbox de email
    Private Sub StudentEmail_Leave(sender As Object, e As EventArgs) Handles StudentEmail.Leave
        ' Si se selecciona otro elemento del formulario sin haber llenado el email
        If Not String.IsNullOrWhiteSpace(StudentEmail.Text) AndAlso Not IsValidEmail(StudentEmail.Text) Then
            MessageBox.Show("Por favor ingrese un correo electronico valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            StudentEmail.Focus()
        End If
    End Sub

    Private Sub CoordinatorEmail_Leave(sender As Object, e As EventArgs) Handles CoordinatorEmail.Leave
        ' Si se selecciona otro elemento del formulario sin haber llenado el email
        If Not String.IsNullOrWhiteSpace(CoordinatorEmail.Text) AndAlso Not IsValidEmail(CoordinatorEmail.Text) Then
            MessageBox.Show("Por favor ingrese un correo electronico valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CoordinatorEmail.Focus()
        End If
    End Sub
End Class

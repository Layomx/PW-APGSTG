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

    ' Funcion para desactivar la navegacion por tabulador
    Private Sub DisableTabStop(ByVal controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            ctrl.TabStop = False
            ' Desactivando subcontroles llamando la funcion de forma recursiva
            If ctrl.HasChildren Then
                DisableTabStop(ctrl.Controls)
            End If
        Next
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Desactivando la navegacion por tabulador (personalmente es molesto)
        DisableTabStop(Me.Controls)

        ' Ocultando los group box de cada tipo de cuenta
        GBEstudiante.Hide()
        GBCoordinator.Hide()
        GBEmpresa.Hide()

        Register.BringToFront()

        ' Ocultando las contraseñas
        PasswordSign.UseSystemPasswordChar = True
        StudentPassword.UseSystemPasswordChar = True
        CompanyPassword.UseSystemPasswordChar = True
        CoordinatorPassword.UseSystemPasswordChar = True

    End Sub

    ' Mostrando u ocultando contraseñas de los usuarios
    Private Sub HideShowPasswordSign_Click(sender As Object, e As EventArgs) Handles HideShowPasswordSign.Click
        If PasswordSign.UseSystemPasswordChar = True Then
            PasswordSign.UseSystemPasswordChar = False
            HideShowPasswordSign.Image = My.Resources.ContraseñaOculta
        Else
            PasswordSign.UseSystemPasswordChar = True
            HideShowPasswordSign.Image = My.Resources.Contraseña
        End If
    End Sub


    ' Mostrando los groupbox dependiendo de lo seleccionado
    Private Sub AccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountType.SelectedIndexChanged
        Select Case AccountType.SelectedItem.ToString()
            Case "Estudiante"
                GBEmpresa.Hide()
                GBCoordinator.Hide()
                GBEstudiante.Show()
            Case "Coordinador"
                GBEmpresa.Hide()
                GBEstudiante.Hide()
                GBCoordinator.Show()
            Case "Empresa"
                GBEstudiante.Hide()
                GBCoordinator.Hide()
                GBEmpresa.Show()
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
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CompanyName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    ' Permitiendo solo letras, espacios y teclas de control en el apellido del usuario
    Private Sub StudentLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CoordinatorLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CoordinatorName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) Then
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
        If IsValidEmail(CoordinatorEmail.Text) Then
            CoordinatorEmail.BackColor = Color.White
        Else
            CoordinatorEmail.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub CompanyEmail_TextChanged(sender As Object, e As EventArgs) Handles CompanyEmail.TextChanged
        If IsValidEmail(CompanyEmail.Text) Then
            CompanyEmail.BackColor = Color.White
        Else
            CompanyEmail.BackColor = Color.LightPink
        End If
    End Sub

    ' Validando el numero telefonico del coordinador
    Private Sub CoordinatorTelephoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CoordinatorTelephoneNumber.KeyPress
        ' Aceptando unicamente numeros como guiones y espacios
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "-" AndAlso Not e.KeyChar = " " AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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
        If Not String.IsNullOrWhiteSpace(CoordinatorEmail.Text) AndAlso Not IsValidEmail(CoordinatorEmail.Text) Then
            MessageBox.Show("Por favor ingrese un correo electronico valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CoordinatorEmail.Focus()
        End If
    End Sub

    Private Sub CompanyEmail_Leave(sender As Object, e As EventArgs) Handles CompanyEmail.Leave
        If Not String.IsNullOrWhiteSpace(CompanyEmail.Text) AndAlso Not IsValidEmail(CompanyEmail.Text) Then
            MessageBox.Show("Por favor ingrese un correo electronico valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CoordinatorEmail.Focus()
        End If
    End Sub
End Class

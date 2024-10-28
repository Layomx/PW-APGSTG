Imports System.Collections.Specialized
Imports System.Configuration
Imports System.Data.SqlClient

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
    Private Sub HideShowPasswordStudent_Click(sender As Object, e As EventArgs) Handles HideShowPasswordStudent.Click
        If StudentPassword.UseSystemPasswordChar = True Then
            StudentPassword.UseSystemPasswordChar = False
            HideShowPasswordStudent.Image = My.Resources.ContraseñaOculta
        Else
            StudentPassword.UseSystemPasswordChar = True
            HideShowPasswordStudent.Image = My.Resources.Contraseña
        End If
    End Sub
    Private Sub HideShowPasswordCoordinator_Click(sender As Object, e As EventArgs) Handles HideShowPasswordCoordinator.Click
        If CoordinatorPassword.UseSystemPasswordChar = True Then
            CoordinatorPassword.UseSystemPasswordChar = False
            HideShowPasswordCoordinator.Image = My.Resources.ContraseñaOculta
        Else
            CoordinatorPassword.UseSystemPasswordChar = True
            HideShowPasswordCoordinator.Image = My.Resources.Contraseña
        End If
    End Sub
    Private Sub HideShowPasswordCompany_Click(sender As Object, e As EventArgs) Handles HideShowPasswordCompany.Click
        If CompanyPassword.UseSystemPasswordChar = True Then
            CompanyPassword.UseSystemPasswordChar = False
            HideShowPasswordCompany.Image = My.Resources.ContraseñaOculta
        Else
            CompanyPassword.UseSystemPasswordChar = True
            HideShowPasswordCompany.Image = My.Resources.Contraseña
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

    ' Creando un usuario de tipo estudiante
    Private Sub BtnCreateAccStudent_Click(sender As Object, e As EventArgs) Handles BtnCreateAccStudent.Click
        ' Validando que los textbox no estan vacios
        If StudentName.Text = "" Or StudentLastName.Text = "" Or StudentEmail.Text = "" Or StudentAddress.Text = "" Then
            MessageBox.Show("Por favor, completa todos los campos correctmente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Datos introducidos del estudiante
        Dim ValStudentName As String = StudentName.Text
        Dim ValStudentLastName As String = StudentLastName.Text
        Dim ValStudentEmail As String = StudentEmail.Text
        Dim ValStudentPassword As String = StudentPassword.Text
        Dim ValStudentAddress As String = StudentAddress.Text
        Dim IDFacultad As Integer

        ' Facultad del estudiante
        Select Case FacultyStudent.SelectedItem.ToString
            Case "Ingenieria en Sistemas Computacionales"
                IDFacultad = 1
            Case "Ingenieria Mecanica"
                IDFacultad = 2
            Case "Ciencias y Tecnologia"
                IDFacultad = 3
        End Select

        ' Conectando con la base de datos
        Using conn As New SqlConnection(connString)
            Try
                ' Abriendo la conexion
                conn.Open()

                ' Verificando si el correo ya existe
                Dim queryCheck As String = "SELECT COUNT(*) FRROM Usuario_Estudiante WHERE EmailEstudiante = @ValStudentEmail"
                Using commandCheck As New SqlCommand(queryCheck, conn)
                    commandCheck.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim newQuery As String = "INSERTO INTO Usuario_Estudiante(NombreEstudiante, ApellidoEstudiante, Contraseña_Est, DireccionEstudiante, EmailEstudiante, ID_Facultad)" & "VALUES (@ValStudentName, @ValStudentLastName, @ValStudentPassword, @ValStudentAddress, @ValStudentEmail, @IDFacultad)"
                Using commandInsert As New SqlCommand(newQuery, conn)
                    commandInsert.Parameters.AddWithValue("@ValStudentName", ValStudentName)
                    commandInsert.Parameters.AddWithValue("@ValStudentLastName", ValStudentLastName)
                    commandInsert.Parameters.AddWithValue("@ValStudentPassword", ValStudentPassword)
                    commandInsert.Parameters.AddWithValue("@ValStudentAddress", ValStudentAddress)
                    commandInsert.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    commandInsert.Parameters.AddWithValue("@IDFacultad", IDFacultad)

                    Dim affectedRows As Integer = commandInsert.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Datos guardados correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Else
                        MessageBox.Show("No se pudieron guardar los datos", "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub
End Class

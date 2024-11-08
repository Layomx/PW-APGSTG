Imports System.Collections.Specialized
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web

Public Class Login
    ' Variables de clase publica
    Public Property UserEmail As String

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

    ' Carga del formulario de login y register
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

        Me.ActiveControl = Nothing
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

    ' Mostrando los groupbox dependiendo del tipo de cuenta seleccionada
    Private Sub AccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountType.SelectedIndexChanged
        If AccountType.SelectedItem IsNot Nothing Then
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
        Else
            AccountType.Text = "Tipo de cuenta"
            GBEstudiante.Hide()
            GBCoordinator.Hide()
            GBEmpresa.Hide()
        End If
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

    ' En el usuario empresa se permiten puntos para casos como "S.A"
    Private Sub CompanyName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Space) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = "." Then
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

    ' Validando el numero telefonico de la empresa
    Private Sub CompanyTelephoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyTelephoneNumber.KeyPress
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
            CompanyEmail.Focus()
        End If
    End Sub

    ' Creando un usuario de tipo Estudiante
    Private Sub BtnCreateAccStudent_Click(sender As Object, e As EventArgs) Handles BtnCreateAccStudent.Click
        ' Validando que los textbox no estan vacios
        If StudentName.Text = "" Or StudentLastName.Text = "" Or StudentEmail.Text = "" Or StudentAddress.Text = "" Or FacultyStudent.SelectedIndex = -1 Then
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

                ' Verificando si el correo ya existe en la tabla de estudiantes
                Dim queryCheck As String = "SELECT COUNT(*) FROM Usuario_Estudiante WHERE EmailEstudiante = @ValStudentEmail"
                Using commandCheck As New SqlCommand(queryCheck, conn)
                    commandCheck.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de coordinadores
                Dim queryCheckCoordinator As String = "SELECT COUNT(*) FROM Usuario_Coordinador WHERE EmailCoordinador = @ValStudentEmail"
                Using commandCheck As New SqlCommand(queryCheckCoordinator, conn)
                    commandCheck.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de empresas
                Dim queryCheckCompany As String = "SELECT COUNT(*) FROM Usuario_Empresa WHERE EmailEmpresa = @ValStudentEmail"
                Using commandCheck As New SqlCommand(queryCheckCompany, conn)
                    commandCheck.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Insertando los datos a traves de un query
                Dim newQuery As String = "INSERT INTO Usuario_Estudiante(NombreEstudiante, ApellidoEstudiante, Contraseña_Est, DireccionEstudiante, EmailEstudiante, ID_Facultad)" & "VALUES (@ValStudentName, @ValStudentLastName, @ValStudentPassword, @ValStudentAddress, @ValStudentEmail, @IDFacultad)"
                Using commandInsert As New SqlCommand(newQuery, conn)
                    ' Definimos las variables sql
                    commandInsert.Parameters.AddWithValue("@ValStudentName", ValStudentName)
                    commandInsert.Parameters.AddWithValue("@ValStudentLastName", ValStudentLastName)
                    commandInsert.Parameters.AddWithValue("@ValStudentPassword", ValStudentPassword)
                    commandInsert.Parameters.AddWithValue("@ValStudentAddress", ValStudentAddress)
                    commandInsert.Parameters.AddWithValue("@ValStudentEmail", ValStudentEmail)
                    commandInsert.Parameters.AddWithValue("@IDFacultad", IDFacultad)

                    ' La cantidad de filas afectadas seran guardadas en una variable
                    Dim affectedRows As Integer = commandInsert.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Cuenta creada correctamente.", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Else
                        MessageBox.Show("No se pudo crear la cuenta", "Error al crear cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al crear la cuenta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Creando un usuario de tipo Empresa
    Private Sub BtnCreateAccCompany_Click(sender As Object, e As EventArgs) Handles BtnCreateAccCompany.Click
        ' Validando que los textbox no esten vacios
        If CompanyName.Text = "" Or CompanyAddress.Text = "" Or CompanyEmail.Text = "" Or CompanyTelephoneNumber.Text = "" Or CompanyPassword.Text = "" Then
            MessageBox.Show("Por favor, completa todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Datos introducidos de la empresa
        Dim ValCompanyName As String = CompanyName.Text
        Dim ValCompanyAddress As String = CompanyAddress.Text
        Dim ValCompanyEmail As String = CompanyEmail.Text
        Dim ValCompanyTelephone As String = CompanyTelephoneNumber.Text
        Dim ValCompanyPassword As String = CompanyPassword.Text

        ' Conectando con la base de datos 
        Using conn As New SqlConnection(connString)
            Try
                ' Abriendo la conexion
                conn.Open()

                ' Verificando si el correo ya existe en la tabla de empresas
                Dim queryCheck As String = "SELECT COUNT(*) FROM Usuario_Empresa WHERE EmailEmpresa = @ValCompanyEmail"
                Using commandCheck As New SqlCommand(queryCheck, conn)
                    commandCheck.Parameters.AddWithValue("@ValCompanyEmail", ValCompanyEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de estudiantes
                Dim queryCheckStudent As String = "SELECT COUNT(*) FROM Usuario_Estudiante WHERE EmailEstudiante = @ValCompanyEmail"
                Using commandCheck As New SqlCommand(queryCheckStudent, conn)
                    commandCheck.Parameters.AddWithValue("@ValCompanyEmail", ValCompanyEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de coordinadores
                Dim queryCheckCoordinator As String = "SELECT COUNT(*) FROM Usuario_Coordinador WHERE EmailCoordinador = @ValCompanyEmail"
                Using commandCheck As New SqlCommand(queryCheckCoordinator, conn)
                    commandCheck.Parameters.AddWithValue("@ValCompanyEmail", ValCompanyEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim newQuery As String = "INSERT INTO Usuario_Empresa(NombreEmpresa, Contraseña_Emp, Direccion, Telefono, EmailEmpresa)" & "VALUES (@ValCompanyName, @ValCompanyPassword, @ValCompanyAddress, @ValCompanyTelephone, @ValCompanyEmail)"
                Using commandInsert As New SqlCommand(newQuery, conn)
                    ' Definimos variables sql
                    commandInsert.Parameters.AddWithValue("@ValCompanyName", ValCompanyName)
                    commandInsert.Parameters.AddWithValue("@ValCompanyPassword", ValCompanyPassword)
                    commandInsert.Parameters.AddWithValue("@ValCompanyAddress", ValCompanyAddress)
                    commandInsert.Parameters.AddWithValue("@ValCompanyTelephone", ValCompanyTelephone)
                    commandInsert.Parameters.AddWithValue("@ValCompanyEmail", ValCompanyEmail)

                    ' La cantidad de filas afectadas seran guardadas en una variable
                    Dim affectedRows As Integer = commandInsert.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Cuenta creada correctamente.", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Else
                        MessageBox.Show("No se pudo crear la cuenta.", "Error al crear cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al crear la cuenta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Creando un usuario del tipo Coordinador
    Private Sub BtnCreateAccCoordinator_Click(sender As Object, e As EventArgs) Handles BtnCreateAccCoordinator.Click
        ' Validando que los textbox no esten vacios
        If CoordinatorName.Text = "" Or CoordinatorLastName.Text = "" Or CoordinatorEmail.Text = "" Or CoordinatorTelephoneNumber.Text = "" Or CoordinatorPassword.Text = "" Or FacultyCoordinator.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, completa todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Datos introducidos del coordinador
        Dim ValCoordinatorName As String = CoordinatorName.Text
        Dim ValCoordinatorLastName As String = CoordinatorLastName.Text
        Dim ValCoordinatorEmail As String = CoordinatorEmail.Text
        Dim ValCoordinatorTelephone As String = CoordinatorTelephoneNumber.Text
        Dim ValCoordinatorPassword As String = CoordinatorPassword.Text
        Dim IDFacultad As Integer

        ' Facultad del coordinador
        Select Case FacultyCoordinator.SelectedItem.ToString
            Case "Ingenieria en Sistemas Computacionales"
                IDFacultad = 1
            Case "Ingenieria Mecanica"
                IDFacultad = 2
            Case "Ciencias y Tecnologia"
                IDFacultad = 3
        End Select

        Using conn As New SqlConnection(connString)
            Try
                ' Abriendo la conexion 
                conn.Open()

                ' Verificando si el correo ya existe en la tabla de coordinadores
                Dim queryCheckCoordinator As String = "SELECT COUNT(*) FROM Usuario_Coordinador WHERE EmailCoordinador = @ValCoordinatorEmail"
                Using commandCheck As New SqlCommand(queryCheckCoordinator, conn)
                    commandCheck.Parameters.AddWithValue("@ValCoordinatorEmail", ValCoordinatorEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de estudiantes
                Dim queryCheckStudents As String = "SELECT COUNT(*) FROM Usuario_Estudiante WHERE EmailEstudiante = @ValCoordinatorEmail"
                Using commandCheck As New SqlCommand(queryCheckStudents, conn)
                    commandCheck.Parameters.AddWithValue("@ValCoordinatorEmail", ValCoordinatorEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                ' Verificando si el correo ya existe en la tabla de empresas
                Dim queryCheckCompany As String = "SELECT COUNT(*) FROM Usuario_Empresa WHERE EmailEmpresa = @ValCoordinatorEmail"
                Using commandCheck As New SqlCommand(queryCheckCompany, conn)
                    commandCheck.Parameters.AddWithValue("@ValCoordinatorEmail", ValCoordinatorEmail)
                    Dim existingEmail As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If existingEmail > 0 Then
                        MessageBox.Show("El correo ya esta en uso. Introduzca un correo distinto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using

                Dim newQuery As String = "INSERT INTO Usuario_Coordinador(Nombre_Coordinador, Contraseña_C, Apellido_Coordinador, Telefono_contacto, EmailCoordinador, ID_Facultad)" & "VALUES (@ValCoordinatorName, @CoordinatorPassword, @ValCoordinatorLastName, @ValCoordinatorTelephone, @ValCoordinatorEmail, @IDFacultad)"
                Using commandInsert As New SqlCommand(newQuery, conn)
                    commandInsert.Parameters.AddWithValue("@ValCoordinatorName", ValCoordinatorName)
                    commandInsert.Parameters.AddWithValue("@CoordinatorPassword", ValCoordinatorPassword)
                    commandInsert.Parameters.AddWithValue("@ValCoordinatorLastName", ValCoordinatorLastName)
                    commandInsert.Parameters.AddWithValue("@ValCoordinatorTelephone", ValCoordinatorTelephone)
                    commandInsert.Parameters.AddWithValue("@ValCoordinatorEmail", ValCoordinatorEmail)
                    commandInsert.Parameters.AddWithValue("@IDFacultad", IDFacultad)

                    Dim affectedRows As Integer = commandInsert.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Cuenta creada correctamente.", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Else
                        MessageBox.Show("No se pudo crear la cuenta.", "Error al crear cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al crear la cuenta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub FacultyStudent_Leave(sender As Object, e As EventArgs) Handles FacultyStudent.Leave
        If FacultyStudent.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una facultad.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FacultyStudent.Focus()
        End If
    End Sub

    Private Sub FacultyCoordinator_Leave(sender As Object, e As EventArgs) Handles FacultyCoordinator.Leave
        If FacultyCoordinator.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una facultad.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FacultyCoordinator.Focus()
        End If
    End Sub

    Private Sub BtnSignIn_Click(sender As Object, e As EventArgs) Handles BtnSignIn.Click
        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Datos introducidos del usuario que desea ingresar
        Dim ValUserEmail As String = EmailSign.Text
        Dim ValUserPassword As String = PasswordSign.Text

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                ' Variables para almacenar el tipo de cuenta
                Dim isStudent As Boolean = False
                Dim isCompany As Boolean = False
                Dim isCoordinator As Boolean = False
                Dim validEmail As Boolean = False

                ' Verificando la existencia de los correos en la base de datos
                If validEmail = False Then
                    Dim checkStudents As String = "SELECT COUNT(*) FROM Usuario_Estudiante WHERE EmailEstudiante = @ValUserEmail"
                    Using commandCheckStudent As New SqlCommand(checkStudents, conn)
                        commandCheckStudent.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                        validEmail = Convert.ToInt32(commandCheckStudent.ExecuteScalar()) > 0
                    End Using

                End If

                If validEmail = False Then
                    Dim checkCompany As String = "SELECT COUNT(*) FROM Usuario_Empresa WHERE EmailEmpresa = @ValUserEmail"
                    Using commandCheckCompany As New SqlCommand(checkCompany, conn)
                        commandCheckCompany.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                        validEmail = Convert.ToInt32(commandCheckCompany.ExecuteScalar()) > 0
                    End Using

                End If

                If validEmail = False Then
                    Dim checkCoordinator As String = "SELECT COUNT(*) FROM Usuario_Coordinador WHERE EmailCoordinador = @ValUserEmail"
                    Using commandCheckCoordinator As New SqlCommand(checkCoordinator, conn)
                        commandCheckCoordinator.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                        validEmail = Convert.ToInt32(commandCheckCoordinator.ExecuteScalar()) > 0
                    End Using
                End If

                ' Si el correo no existe se detiene la ejecucion
                If Not validEmail Then
                    MessageBox.Show("El correo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Verificando la tabla de Estudiantes
                Dim queryStudents As String = "SELECT COUNT(*) FROM Usuario_Estudiante WHERE EmailEstudiante = @ValUserEmail AND Contraseña_Est = @ValUserPassword"
                Using commandStudent As New SqlCommand(queryStudents, conn)
                    commandStudent.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                    commandStudent.Parameters.AddWithValue("@ValUserPassword", ValUserPassword)
                    isStudent = Convert.ToInt32(commandStudent.ExecuteScalar()) > 0
                End Using

                ' Verificando la tabla de Empresas
                Dim queryCompany As String = "SELECT COUNT(*) FROM Usuario_Empresa WHERE EmailEmpresa = @ValUserEmail AND Contraseña_Emp = @ValUserPassword"
                Using commandCompany As New SqlCommand(queryCompany, conn)
                    commandCompany.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                    commandCompany.Parameters.AddWithValue("@ValUserPassword", ValUserPassword)
                    isCompany = Convert.ToInt32(commandCompany.ExecuteScalar()) > 0
                End Using

                ' Verificando la tabla de Coordinadores
                Dim queryCoordinator As String = "SELECT COUNT(*) FROM Usuario_Coordinador WHERE EmailCoordinador = @ValUserEmail AND Contraseña_C = @ValUserPassword"
                Using commandCoordinator As New SqlCommand(queryCoordinator, conn)
                    commandCoordinator.Parameters.AddWithValue("@ValUserEmail", ValUserEmail)
                    commandCoordinator.Parameters.AddWithValue("@ValUserPassword", ValUserPassword)
                    isCoordinator = Convert.ToInt32(commandCoordinator.ExecuteScalar() > 0)
                End Using

                ' Redirigir segun el tipo de cuenta
                If isStudent Then
                    MessageBox.Show("Inicio de sesion exitoso como Estudiante.", "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.None)
                    UserEmail = EmailSign.Text
                    Me.Hide()
                ElseIf isCompany Then
                    MessageBox.Show("Inicio de sesion exitoso como Empresa.", "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.Hide()
                    UserEmail = EmailSign.Text
                    CompanyForms.Show()
                ElseIf isCoordinator Then
                    MessageBox.Show("Inicio de sesion exitoso como Coordinador.", "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.Hide()
                    UserEmail = EmailSign.Text
                    CoordinatorForms.Show()
                Else
                    MessageBox.Show("Correo electronico o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al ingresar a la la cuenta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using

    End Sub

    Private Sub AccountType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AccountType.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class

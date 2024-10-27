<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Register = New System.Windows.Forms.GroupBox()
        Me.GBEstudiante = New System.Windows.Forms.GroupBox()
        Me.BtnCreateAccStudent = New System.Windows.Forms.Button()
        Me.StudentAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StudentEmail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StudentLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StudentName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccountType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GPCoordinador = New System.Windows.Forms.GroupBox()
        Me.BtnCreateAccCoordinator = New System.Windows.Forms.Button()
        Me.CoordinatorTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CoordinatorEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CoordinatorLastName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CoordinatorName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SignIn = New System.Windows.Forms.GroupBox()
        Me.BtnSignIn = New System.Windows.Forms.Button()
        Me.PasswordSign = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmailSign = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Register.SuspendLayout()
        Me.GBEstudiante.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPCoordinador.SuspendLayout()
        Me.SignIn.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.Color.White
        Me.Register.Controls.Add(Me.GPCoordinador)
        Me.Register.Controls.Add(Me.GBEstudiante)
        Me.Register.Controls.Add(Me.AccountType)
        Me.Register.Controls.Add(Me.Label1)
        Me.Register.Controls.Add(Me.PictureBox1)
        Me.Register.Location = New System.Drawing.Point(471, 37)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(426, 480)
        Me.Register.TabIndex = 0
        Me.Register.TabStop = False
        '
        'GBEstudiante
        '
        Me.GBEstudiante.Controls.Add(Me.BtnCreateAccStudent)
        Me.GBEstudiante.Controls.Add(Me.StudentAddress)
        Me.GBEstudiante.Controls.Add(Me.Label9)
        Me.GBEstudiante.Controls.Add(Me.StudentEmail)
        Me.GBEstudiante.Controls.Add(Me.Label8)
        Me.GBEstudiante.Controls.Add(Me.StudentLastName)
        Me.GBEstudiante.Controls.Add(Me.Label7)
        Me.GBEstudiante.Controls.Add(Me.StudentName)
        Me.GBEstudiante.Controls.Add(Me.Label6)
        Me.GBEstudiante.Location = New System.Drawing.Point(28, 135)
        Me.GBEstudiante.Name = "GBEstudiante"
        Me.GBEstudiante.Size = New System.Drawing.Size(378, 318)
        Me.GBEstudiante.TabIndex = 3
        Me.GBEstudiante.TabStop = False
        Me.GBEstudiante.Text = "Estudiante"
        '
        'BtnCreateAccStudent
        '
        Me.BtnCreateAccStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateAccStudent.Location = New System.Drawing.Point(138, 280)
        Me.BtnCreateAccStudent.Name = "BtnCreateAccStudent"
        Me.BtnCreateAccStudent.Size = New System.Drawing.Size(111, 23)
        Me.BtnCreateAccStudent.TabIndex = 8
        Me.BtnCreateAccStudent.Text = "Crear cuenta"
        Me.BtnCreateAccStudent.UseVisualStyleBackColor = True
        '
        'StudentAddress
        '
        Me.StudentAddress.Location = New System.Drawing.Point(20, 242)
        Me.StudentAddress.Name = "StudentAddress"
        Me.StudentAddress.Size = New System.Drawing.Size(337, 22)
        Me.StudentAddress.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(17, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Direccion"
        '
        'StudentEmail
        '
        Me.StudentEmail.Location = New System.Drawing.Point(20, 178)
        Me.StudentEmail.Name = "StudentEmail"
        Me.StudentEmail.Size = New System.Drawing.Size(337, 22)
        Me.StudentEmail.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(17, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Correo"
        '
        'StudentLastName
        '
        Me.StudentLastName.Location = New System.Drawing.Point(20, 117)
        Me.StudentLastName.Name = "StudentLastName"
        Me.StudentLastName.Size = New System.Drawing.Size(337, 22)
        Me.StudentLastName.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(17, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Apellido"
        '
        'StudentName
        '
        Me.StudentName.Location = New System.Drawing.Point(20, 57)
        Me.StudentName.Name = "StudentName"
        Me.StudentName.Size = New System.Drawing.Size(337, 22)
        Me.StudentName.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(17, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nombre"
        '
        'AccountType
        '
        Me.AccountType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.AccountType.FormattingEnabled = True
        Me.AccountType.Items.AddRange(New Object() {"Estudiante", "Coordinador", "Empresa"})
        Me.AccountType.Location = New System.Drawing.Point(160, 106)
        Me.AccountType.Name = "AccountType"
        Me.AccountType.Size = New System.Drawing.Size(121, 23)
        Me.AccountType.TabIndex = 2
        Me.AccountType.Text = "Tipo de cuenta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Crea una cuenta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PW_APGSTG.My.Resources.Resources.UsuarioRegistro
        Me.PictureBox1.Location = New System.Drawing.Point(184, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GPCoordinador
        '
        Me.GPCoordinador.Controls.Add(Me.BtnCreateAccCoordinator)
        Me.GPCoordinador.Controls.Add(Me.CoordinatorTelephoneNumber)
        Me.GPCoordinador.Controls.Add(Me.Label10)
        Me.GPCoordinador.Controls.Add(Me.CoordinatorEmail)
        Me.GPCoordinador.Controls.Add(Me.Label11)
        Me.GPCoordinador.Controls.Add(Me.CoordinatorLastName)
        Me.GPCoordinador.Controls.Add(Me.Label12)
        Me.GPCoordinador.Controls.Add(Me.CoordinatorName)
        Me.GPCoordinador.Controls.Add(Me.Label13)
        Me.GPCoordinador.Location = New System.Drawing.Point(28, 135)
        Me.GPCoordinador.Name = "GPCoordinador"
        Me.GPCoordinador.Size = New System.Drawing.Size(378, 318)
        Me.GPCoordinador.TabIndex = 13
        Me.GPCoordinador.TabStop = False
        Me.GPCoordinador.Text = "Coordinador"
        '
        'BtnCreateAccCoordinator
        '
        Me.BtnCreateAccCoordinator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateAccCoordinator.Location = New System.Drawing.Point(138, 280)
        Me.BtnCreateAccCoordinator.Name = "BtnCreateAccCoordinator"
        Me.BtnCreateAccCoordinator.Size = New System.Drawing.Size(111, 23)
        Me.BtnCreateAccCoordinator.TabIndex = 8
        Me.BtnCreateAccCoordinator.Text = "Crear cuenta"
        Me.BtnCreateAccCoordinator.UseVisualStyleBackColor = True
        '
        'CoordinatorTelephoneNumber
        '
        Me.CoordinatorTelephoneNumber.Location = New System.Drawing.Point(20, 242)
        Me.CoordinatorTelephoneNumber.Name = "CoordinatorTelephoneNumber"
        Me.CoordinatorTelephoneNumber.Size = New System.Drawing.Size(337, 22)
        Me.CoordinatorTelephoneNumber.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(17, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Telefono"
        '
        'CoordinatorEmail
        '
        Me.CoordinatorEmail.Location = New System.Drawing.Point(20, 178)
        Me.CoordinatorEmail.Name = "CoordinatorEmail"
        Me.CoordinatorEmail.Size = New System.Drawing.Size(337, 22)
        Me.CoordinatorEmail.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(17, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Correo"
        '
        'CoordinatorLastName
        '
        Me.CoordinatorLastName.Location = New System.Drawing.Point(20, 117)
        Me.CoordinatorLastName.Name = "CoordinatorLastName"
        Me.CoordinatorLastName.Size = New System.Drawing.Size(337, 22)
        Me.CoordinatorLastName.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(17, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Apellido"
        '
        'CoordinatorName
        '
        Me.CoordinatorName.Location = New System.Drawing.Point(20, 57)
        Me.CoordinatorName.Name = "CoordinatorName"
        Me.CoordinatorName.Size = New System.Drawing.Size(337, 22)
        Me.CoordinatorName.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(17, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nombre"
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.White
        Me.SignIn.Controls.Add(Me.BtnSignIn)
        Me.SignIn.Controls.Add(Me.PasswordSign)
        Me.SignIn.Controls.Add(Me.Label5)
        Me.SignIn.Controls.Add(Me.EmailSign)
        Me.SignIn.Controls.Add(Me.Label4)
        Me.SignIn.Controls.Add(Me.Label3)
        Me.SignIn.Controls.Add(Me.Label2)
        Me.SignIn.Controls.Add(Me.PictureBox2)
        Me.SignIn.Location = New System.Drawing.Point(53, 88)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(352, 377)
        Me.SignIn.TabIndex = 1
        Me.SignIn.TabStop = False
        '
        'BtnSignIn
        '
        Me.BtnSignIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnSignIn.Location = New System.Drawing.Point(120, 300)
        Me.BtnSignIn.Name = "BtnSignIn"
        Me.BtnSignIn.Size = New System.Drawing.Size(111, 23)
        Me.BtnSignIn.TabIndex = 7
        Me.BtnSignIn.Text = "Iniciar sesion"
        Me.BtnSignIn.UseVisualStyleBackColor = True
        '
        'PasswordSign
        '
        Me.PasswordSign.Location = New System.Drawing.Point(31, 238)
        Me.PasswordSign.Name = "PasswordSign"
        Me.PasswordSign.Size = New System.Drawing.Size(287, 22)
        Me.PasswordSign.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(28, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contraseña"
        '
        'EmailSign
        '
        Me.EmailSign.Location = New System.Drawing.Point(31, 176)
        Me.EmailSign.Name = "EmailSign"
        Me.EmailSign.Size = New System.Drawing.Size(287, 22)
        Me.EmailSign.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(28, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(95, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inicia sesion en tu cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bienvenido"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.PW_APGSTG.My.Resources.Resources.UsuarioInicio
        Me.PictureBox2.Location = New System.Drawing.Point(147, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(946, 550)
        Me.Controls.Add(Me.SignIn)
        Me.Controls.Add(Me.Register)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Register.ResumeLayout(False)
        Me.Register.PerformLayout()
        Me.GBEstudiante.ResumeLayout(False)
        Me.GBEstudiante.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPCoordinador.ResumeLayout(False)
        Me.GPCoordinador.PerformLayout()
        Me.SignIn.ResumeLayout(False)
        Me.SignIn.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Register As GroupBox
    Friend WithEvents SignIn As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordSign As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EmailSign As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSignIn As Button
    Friend WithEvents AccountType As ComboBox
    Friend WithEvents GBEstudiante As GroupBox
    Friend WithEvents BtnCreateAccStudent As Button
    Friend WithEvents StudentAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StudentEmail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StudentLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StudentName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GPCoordinador As GroupBox
    Friend WithEvents BtnCreateAccCoordinator As Button
    Friend WithEvents CoordinatorTelephoneNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CoordinatorEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CoordinatorLastName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CoordinatorName As TextBox
    Friend WithEvents Label13 As Label
End Class

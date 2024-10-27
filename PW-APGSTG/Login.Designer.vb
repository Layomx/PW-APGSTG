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
        Me.BtnCreateAcc = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AccountType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.SignIn.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Register
        '
        Me.Register.BackColor = System.Drawing.Color.White
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
        Me.GBEstudiante.Controls.Add(Me.BtnCreateAcc)
        Me.GBEstudiante.Controls.Add(Me.TextBox6)
        Me.GBEstudiante.Controls.Add(Me.Label9)
        Me.GBEstudiante.Controls.Add(Me.TextBox5)
        Me.GBEstudiante.Controls.Add(Me.Label8)
        Me.GBEstudiante.Controls.Add(Me.TextBox4)
        Me.GBEstudiante.Controls.Add(Me.Label7)
        Me.GBEstudiante.Controls.Add(Me.TextBox3)
        Me.GBEstudiante.Controls.Add(Me.Label6)
        Me.GBEstudiante.Location = New System.Drawing.Point(28, 135)
        Me.GBEstudiante.Name = "GBEstudiante"
        Me.GBEstudiante.Size = New System.Drawing.Size(378, 318)
        Me.GBEstudiante.TabIndex = 3
        Me.GBEstudiante.TabStop = False
        Me.GBEstudiante.Text = "Estudiante"
        '
        'BtnCreateAcc
        '
        Me.BtnCreateAcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateAcc.Location = New System.Drawing.Point(138, 280)
        Me.BtnCreateAcc.Name = "BtnCreateAcc"
        Me.BtnCreateAcc.Size = New System.Drawing.Size(111, 23)
        Me.BtnCreateAcc.TabIndex = 8
        Me.BtnCreateAcc.Text = "Crear cuenta"
        Me.BtnCreateAcc.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(20, 242)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(337, 22)
        Me.TextBox6.TabIndex = 12
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
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(20, 178)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(337, 22)
        Me.TextBox5.TabIndex = 9
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(20, 117)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(337, 22)
        Me.TextBox4.TabIndex = 10
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(20, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(337, 22)
        Me.TextBox3.TabIndex = 8
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
    Friend WithEvents BtnCreateAcc As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
End Class

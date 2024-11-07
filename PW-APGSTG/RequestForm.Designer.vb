<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBRequestForm = New System.Windows.Forms.GroupBox()
        Me.CancelRequest = New System.Windows.Forms.Button()
        Me.SendRequest = New System.Windows.Forms.Button()
        Me.Faculty = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RequestRequirements = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RequestDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RequestTitle = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.RequestDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GBRequestForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(629, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMULARIO DE SOLICITUD DE ESTUDIANTE"
        '
        'GBRequestForm
        '
        Me.GBRequestForm.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GBRequestForm.Controls.Add(Me.CancelRequest)
        Me.GBRequestForm.Controls.Add(Me.SendRequest)
        Me.GBRequestForm.Controls.Add(Me.Faculty)
        Me.GBRequestForm.Controls.Add(Me.Label8)
        Me.GBRequestForm.Controls.Add(Me.EndDate)
        Me.GBRequestForm.Controls.Add(Me.Label7)
        Me.GBRequestForm.Controls.Add(Me.StartDate)
        Me.GBRequestForm.Controls.Add(Me.Label6)
        Me.GBRequestForm.Controls.Add(Me.RequestRequirements)
        Me.GBRequestForm.Controls.Add(Me.Label5)
        Me.GBRequestForm.Controls.Add(Me.RequestDescription)
        Me.GBRequestForm.Controls.Add(Me.Label4)
        Me.GBRequestForm.Controls.Add(Me.RequestTitle)
        Me.GBRequestForm.Controls.Add(Me.Titulo)
        Me.GBRequestForm.Controls.Add(Me.RequestDate)
        Me.GBRequestForm.Controls.Add(Me.Label2)
        Me.GBRequestForm.Controls.Add(Me.Label3)
        Me.GBRequestForm.Location = New System.Drawing.Point(38, 95)
        Me.GBRequestForm.Name = "GBRequestForm"
        Me.GBRequestForm.Size = New System.Drawing.Size(724, 566)
        Me.GBRequestForm.TabIndex = 1
        Me.GBRequestForm.TabStop = False
        '
        'CancelRequest
        '
        Me.CancelRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelRequest.Location = New System.Drawing.Point(378, 509)
        Me.CancelRequest.Name = "CancelRequest"
        Me.CancelRequest.Size = New System.Drawing.Size(137, 42)
        Me.CancelRequest.TabIndex = 17
        Me.CancelRequest.Text = "Cancelar solicitud"
        Me.CancelRequest.UseVisualStyleBackColor = True
        '
        'SendRequest
        '
        Me.SendRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SendRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendRequest.Location = New System.Drawing.Point(241, 509)
        Me.SendRequest.Name = "SendRequest"
        Me.SendRequest.Size = New System.Drawing.Size(121, 42)
        Me.SendRequest.TabIndex = 16
        Me.SendRequest.Text = "Enviar solicitud"
        Me.SendRequest.UseVisualStyleBackColor = True
        '
        'Faculty
        '
        Me.Faculty.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty.FormattingEnabled = True
        Me.Faculty.Items.AddRange(New Object() {"Ingenieria en Sistemas Computacionales", "Ingenieria Mecanica", "Ciencias y Tecnologia"})
        Me.Faculty.Location = New System.Drawing.Point(162, 478)
        Me.Faculty.Name = "Faculty"
        Me.Faculty.Size = New System.Drawing.Size(200, 25)
        Me.Faculty.TabIndex = 15
        Me.Faculty.Text = "Facultad destino"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 478)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 22)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Facultad destino"
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(476, 435)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(200, 22)
        Me.EndDate.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(391, 435)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha final"
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(162, 434)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(200, 22)
        Me.StartDate.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha de inicio"
        '
        'RequestRequirements
        '
        Me.RequestRequirements.Location = New System.Drawing.Point(140, 327)
        Me.RequestRequirements.Multiline = True
        Me.RequestRequirements.Name = "RequestRequirements"
        Me.RequestRequirements.Size = New System.Drawing.Size(549, 101)
        Me.RequestRequirements.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Requisitos"
        '
        'RequestDescription
        '
        Me.RequestDescription.Location = New System.Drawing.Point(140, 166)
        Me.RequestDescription.Multiline = True
        Me.RequestDescription.Name = "RequestDescription"
        Me.RequestDescription.Size = New System.Drawing.Size(549, 148)
        Me.RequestDescription.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripcion"
        '
        'RequestTitle
        '
        Me.RequestTitle.Location = New System.Drawing.Point(101, 118)
        Me.RequestTitle.Name = "RequestTitle"
        Me.RequestTitle.Size = New System.Drawing.Size(588, 22)
        Me.RequestTitle.TabIndex = 5
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(50, 117)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(44, 22)
        Me.Titulo.TabIndex = 4
        Me.Titulo.Text = "Titulo"
        '
        'RequestDate
        '
        Me.RequestDate.Location = New System.Drawing.Point(349, 45)
        Me.RequestDate.Name = "RequestDate"
        Me.RequestDate.Size = New System.Drawing.Size(200, 22)
        Me.RequestDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de solicitud"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Solicitud de estudiante"
        '
        'RequestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 701)
        Me.Controls.Add(Me.GBRequestForm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RequestForm"
        Me.Text = "RequestForm"
        Me.GBRequestForm.ResumeLayout(False)
        Me.GBRequestForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GBRequestForm As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RequestDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents RequestTitle As TextBox
    Friend WithEvents Titulo As Label
    Friend WithEvents RequestDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RequestRequirements As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Faculty As ComboBox
    Friend WithEvents CancelRequest As Button
    Friend WithEvents SendRequest As Button
End Class

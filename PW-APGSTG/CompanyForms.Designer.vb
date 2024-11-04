<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyForms
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
        Me.GBCompanyInfoN1 = New System.Windows.Forms.GroupBox()
        Me.SignOut = New System.Windows.Forms.Button()
        Me.Offers = New System.Windows.Forms.Button()
        Me.RequestStudents = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLCompanyTelephone = New System.Windows.Forms.Label()
        Me.LBLCompanyAddress = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLCompanyName = New System.Windows.Forms.Label()
        Me.GBCompanyInfoN2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GBCompanyInfoN1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBCompanyInfoN1
        '
        Me.GBCompanyInfoN1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GBCompanyInfoN1.Controls.Add(Me.SignOut)
        Me.GBCompanyInfoN1.Controls.Add(Me.Offers)
        Me.GBCompanyInfoN1.Controls.Add(Me.RequestStudents)
        Me.GBCompanyInfoN1.Controls.Add(Me.Label1)
        Me.GBCompanyInfoN1.Controls.Add(Me.LBLCompanyTelephone)
        Me.GBCompanyInfoN1.Controls.Add(Me.LBLCompanyAddress)
        Me.GBCompanyInfoN1.Controls.Add(Me.PictureBox1)
        Me.GBCompanyInfoN1.Controls.Add(Me.LBLCompanyName)
        Me.GBCompanyInfoN1.Location = New System.Drawing.Point(12, 12)
        Me.GBCompanyInfoN1.Name = "GBCompanyInfoN1"
        Me.GBCompanyInfoN1.Size = New System.Drawing.Size(324, 553)
        Me.GBCompanyInfoN1.TabIndex = 0
        Me.GBCompanyInfoN1.TabStop = False
        '
        'SignOut
        '
        Me.SignOut.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut.Location = New System.Drawing.Point(6, 501)
        Me.SignOut.Name = "SignOut"
        Me.SignOut.Size = New System.Drawing.Size(312, 46)
        Me.SignOut.TabIndex = 7
        Me.SignOut.Text = "Cerrar sesion"
        Me.SignOut.UseVisualStyleBackColor = True
        '
        'Offers
        '
        Me.Offers.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Offers.Location = New System.Drawing.Point(6, 435)
        Me.Offers.Name = "Offers"
        Me.Offers.Size = New System.Drawing.Size(312, 46)
        Me.Offers.TabIndex = 6
        Me.Offers.Text = "Ofertas"
        Me.Offers.UseVisualStyleBackColor = True
        '
        'RequestStudents
        '
        Me.RequestStudents.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestStudents.Location = New System.Drawing.Point(6, 366)
        Me.RequestStudents.Name = "RequestStudents"
        Me.RequestStudents.Size = New System.Drawing.Size(312, 46)
        Me.RequestStudents.TabIndex = 5
        Me.RequestStudents.Text = "Solicitar estudiantes"
        Me.RequestStudents.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(11, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Informacion:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLCompanyTelephone
        '
        Me.LBLCompanyTelephone.AutoSize = True
        Me.LBLCompanyTelephone.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCompanyTelephone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLCompanyTelephone.Location = New System.Drawing.Point(13, 319)
        Me.LBLCompanyTelephone.Name = "LBLCompanyTelephone"
        Me.LBLCompanyTelephone.Size = New System.Drawing.Size(58, 24)
        Me.LBLCompanyTelephone.TabIndex = 3
        Me.LBLCompanyTelephone.Text = "Label1"
        Me.LBLCompanyTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLCompanyAddress
        '
        Me.LBLCompanyAddress.AutoSize = True
        Me.LBLCompanyAddress.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCompanyAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLCompanyAddress.Location = New System.Drawing.Point(13, 272)
        Me.LBLCompanyAddress.Name = "LBLCompanyAddress"
        Me.LBLCompanyAddress.Size = New System.Drawing.Size(58, 24)
        Me.LBLCompanyAddress.TabIndex = 2
        Me.LBLCompanyAddress.Text = "Label1"
        Me.LBLCompanyAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PW_APGSTG.My.Resources.Resources._15735339
        Me.PictureBox1.Location = New System.Drawing.Point(95, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LBLCompanyName
        '
        Me.LBLCompanyName.AutoSize = True
        Me.LBLCompanyName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCompanyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLCompanyName.Location = New System.Drawing.Point(13, 221)
        Me.LBLCompanyName.Name = "LBLCompanyName"
        Me.LBLCompanyName.Size = New System.Drawing.Size(58, 24)
        Me.LBLCompanyName.TabIndex = 0
        Me.LBLCompanyName.Text = "Label1"
        Me.LBLCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBCompanyInfoN2
        '
        Me.GBCompanyInfoN2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GBCompanyInfoN2.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBCompanyInfoN2.Location = New System.Drawing.Point(342, 12)
        Me.GBCompanyInfoN2.Name = "GBCompanyInfoN2"
        Me.GBCompanyInfoN2.Size = New System.Drawing.Size(626, 100)
        Me.GBCompanyInfoN2.TabIndex = 1
        Me.GBCompanyInfoN2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Location = New System.Drawing.Point(342, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 447)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'CompanyForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(980, 577)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBCompanyInfoN2)
        Me.Controls.Add(Me.GBCompanyInfoN1)
        Me.Name = "CompanyForms"
        Me.Text = "Empresa"
        Me.GBCompanyInfoN1.ResumeLayout(False)
        Me.GBCompanyInfoN1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBCompanyInfoN1 As GroupBox
    Friend WithEvents GBCompanyInfoN2 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLCompanyName As Label
    Friend WithEvents LBLCompanyTelephone As Label
    Friend WithEvents LBLCompanyAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SignOut As Button
    Friend WithEvents Offers As Button
    Friend WithEvents RequestStudents As Button
End Class

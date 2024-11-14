<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoordinatorForms
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuDePracticasProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AprobacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LBLCoordinatorName = New System.Windows.Forms.Label()
        Me.LBLCoordinatorFaculty = New System.Windows.Forms.Label()
        Me.LBLCoordinatorEmail = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkMagenta
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuDePracticasProfesionalesToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(746, 35)
        Me.MenuStrip.TabIndex = 0
        '
        'MenuDePracticasProfesionalesToolStripMenuItem
        '
        Me.MenuDePracticasProfesionalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitudesDePracticasProfesionalesToolStripMenuItem, Me.AprobacionesToolStripMenuItem})
        Me.MenuDePracticasProfesionalesToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDePracticasProfesionalesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuDePracticasProfesionalesToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.practicas
        Me.MenuDePracticasProfesionalesToolStripMenuItem.Name = "MenuDePracticasProfesionalesToolStripMenuItem"
        Me.MenuDePracticasProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(336, 31)
        Me.MenuDePracticasProfesionalesToolStripMenuItem.Text = "Menu de practicas profesionales"
        '
        'SolicitudesDePracticasProfesionalesToolStripMenuItem
        '
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.solicitud
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.Name = "SolicitudesDePracticasProfesionalesToolStripMenuItem"
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(441, 32)
        Me.SolicitudesDePracticasProfesionalesToolStripMenuItem.Text = "Solicitudes de Practicas Profesionales"
        '
        'AprobacionesToolStripMenuItem
        '
        Me.AprobacionesToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.AprobacionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AprobacionesToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.aprobacion
        Me.AprobacionesToolStripMenuItem.Name = "AprobacionesToolStripMenuItem"
        Me.AprobacionesToolStripMenuItem.Size = New System.Drawing.Size(441, 32)
        Me.AprobacionesToolStripMenuItem.Text = "Aprobaciones"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CerrarSesionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSesionToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.Ayuda
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(148, 31)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'LBLCoordinatorName
        '
        Me.LBLCoordinatorName.AutoSize = True
        Me.LBLCoordinatorName.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCoordinatorName.Location = New System.Drawing.Point(214, 50)
        Me.LBLCoordinatorName.Name = "LBLCoordinatorName"
        Me.LBLCoordinatorName.Size = New System.Drawing.Size(58, 24)
        Me.LBLCoordinatorName.TabIndex = 4
        Me.LBLCoordinatorName.Text = "Label1"
        '
        'LBLCoordinatorFaculty
        '
        Me.LBLCoordinatorFaculty.AutoSize = True
        Me.LBLCoordinatorFaculty.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCoordinatorFaculty.Location = New System.Drawing.Point(214, 101)
        Me.LBLCoordinatorFaculty.Name = "LBLCoordinatorFaculty"
        Me.LBLCoordinatorFaculty.Size = New System.Drawing.Size(58, 24)
        Me.LBLCoordinatorFaculty.TabIndex = 5
        Me.LBLCoordinatorFaculty.Text = "Label2"
        '
        'LBLCoordinatorEmail
        '
        Me.LBLCoordinatorEmail.AutoSize = True
        Me.LBLCoordinatorEmail.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCoordinatorEmail.Location = New System.Drawing.Point(214, 152)
        Me.LBLCoordinatorEmail.Name = "LBLCoordinatorEmail"
        Me.LBLCoordinatorEmail.Size = New System.Drawing.Size(58, 24)
        Me.LBLCoordinatorEmail.TabIndex = 7
        Me.LBLCoordinatorEmail.Text = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PW_APGSTG.My.Resources.Resources._15735339
        Me.PictureBox2.Location = New System.Drawing.Point(0, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 171)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PW_APGSTG.My.Resources.Resources.Coordinador1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(746, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CoordinatorForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 358)
        Me.Controls.Add(Me.LBLCoordinatorEmail)
        Me.Controls.Add(Me.LBLCoordinatorFaculty)
        Me.Controls.Add(Me.LBLCoordinatorName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "CoordinatorForms"
        Me.Text = "Coordinador"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents MenuDePracticasProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudesDePracticasProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AprobacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LBLCoordinatorName As Label
    Friend WithEvents LBLCoordinatorFaculty As Label
    Friend WithEvents LBLCoordinatorEmail As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class

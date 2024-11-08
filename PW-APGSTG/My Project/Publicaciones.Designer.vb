<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Publicaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPublicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelOfertasAprobadas2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_SiguientePub = New System.Windows.Forms.Button()
        Me.DGV_OfertaAprobada2 = New System.Windows.Forms.DataGridView()
        Me.PanelOfertapublicada = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOfertasAprobadas2.SuspendLayout()
        CType(Me.DGV_OfertaAprobada2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOfertapublicada.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Publicaciones de ofertas de Práctica Profesionales"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Purple
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 34)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.BackColor = System.Drawing.Color.Purple
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPublicaciónToolStripMenuItem, Me.EditarPublicaciónToolStripMenuItem, Me.EliminarPublicaciónToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OpcionesToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.publicaciones1
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(118, 32)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AgregarPublicaciónToolStripMenuItem
        '
        Me.AgregarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.AgregarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AgregarPublicaciónToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.add_circle_create_expand_new_plus_icon_123218
        Me.AgregarPublicaciónToolStripMenuItem.Name = "AgregarPublicaciónToolStripMenuItem"
        Me.AgregarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.AgregarPublicaciónToolStripMenuItem.Text = "Agregar Publicación"
        '
        'EditarPublicaciónToolStripMenuItem
        '
        Me.EditarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.EditarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditarPublicaciónToolStripMenuItem.Image = Global.PW_APGSTG.My.Resources.Resources.editar
        Me.EditarPublicaciónToolStripMenuItem.Name = "EditarPublicaciónToolStripMenuItem"
        Me.EditarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.EditarPublicaciónToolStripMenuItem.Text = "Editar Publicación"
        '
        'EliminarPublicaciónToolStripMenuItem
        '
        Me.EliminarPublicaciónToolStripMenuItem.BackColor = System.Drawing.Color.DarkMagenta
        Me.EliminarPublicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EliminarPublicaciónToolStripMenuItem.Name = "EliminarPublicaciónToolStripMenuItem"
        Me.EliminarPublicaciónToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.EliminarPublicaciónToolStripMenuItem.Text = "Eliminar Publicación"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 87)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(674, 309)
        Me.DataGridView1.TabIndex = 2
        '
        'PanelOfertasAprobadas2
        '
        Me.PanelOfertasAprobadas2.Controls.Add(Me.Label2)
        Me.PanelOfertasAprobadas2.Controls.Add(Me.BTN_SiguientePub)
        Me.PanelOfertasAprobadas2.Controls.Add(Me.DGV_OfertaAprobada2)
        Me.PanelOfertasAprobadas2.Location = New System.Drawing.Point(41, 48)
        Me.PanelOfertasAprobadas2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelOfertasAprobadas2.Name = "PanelOfertasAprobadas2"
        Me.PanelOfertasAprobadas2.Size = New System.Drawing.Size(689, 366)
        Me.PanelOfertasAprobadas2.TabIndex = 3
        Me.PanelOfertasAprobadas2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione una oferta aprobada"
        '
        'BTN_SiguientePub
        '
        Me.BTN_SiguientePub.BackColor = System.Drawing.Color.DarkMagenta
        Me.BTN_SiguientePub.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SiguientePub.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_SiguientePub.Location = New System.Drawing.Point(269, 301)
        Me.BTN_SiguientePub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BTN_SiguientePub.Name = "BTN_SiguientePub"
        Me.BTN_SiguientePub.Size = New System.Drawing.Size(129, 39)
        Me.BTN_SiguientePub.TabIndex = 1
        Me.BTN_SiguientePub.Text = "Siguiente"
        Me.BTN_SiguientePub.UseVisualStyleBackColor = False
        '
        'DGV_OfertaAprobada2
        '
        Me.DGV_OfertaAprobada2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_OfertaAprobada2.Location = New System.Drawing.Point(42, 61)
        Me.DGV_OfertaAprobada2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGV_OfertaAprobada2.Name = "DGV_OfertaAprobada2"
        Me.DGV_OfertaAprobada2.RowHeadersWidth = 72
        Me.DGV_OfertaAprobada2.RowTemplate.Height = 31
        Me.DGV_OfertaAprobada2.Size = New System.Drawing.Size(598, 236)
        Me.DGV_OfertaAprobada2.TabIndex = 0
        '
        'PanelOfertapublicada
        '
        Me.PanelOfertapublicada.Controls.Add(Me.Panel1)
        Me.PanelOfertapublicada.Controls.Add(Me.Button1)
        Me.PanelOfertapublicada.Controls.Add(Me.Label16)
        Me.PanelOfertapublicada.Controls.Add(Me.DateTimePicker2)
        Me.PanelOfertapublicada.Controls.Add(Me.DateTimePicker1)
        Me.PanelOfertapublicada.Controls.Add(Me.Label15)
        Me.PanelOfertapublicada.Controls.Add(Me.TextBox5)
        Me.PanelOfertapublicada.Controls.Add(Me.Label14)
        Me.PanelOfertapublicada.Controls.Add(Me.Label13)
        Me.PanelOfertapublicada.Controls.Add(Me.Label12)
        Me.PanelOfertapublicada.Controls.Add(Me.Label11)
        Me.PanelOfertapublicada.Controls.Add(Me.TextBox2)
        Me.PanelOfertapublicada.Controls.Add(Me.TextBox1)
        Me.PanelOfertapublicada.Location = New System.Drawing.Point(30, 48)
        Me.PanelOfertapublicada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelOfertapublicada.Name = "PanelOfertapublicada"
        Me.PanelOfertapublicada.Size = New System.Drawing.Size(710, 371)
        Me.PanelOfertapublicada.TabIndex = 24
        Me.PanelOfertapublicada.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.142858!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(290, 305)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.857143!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(261, 11)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(178, 20)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Agregar Publicacion"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(409, 265)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(147, 22)
        Me.DateTimePicker2.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(178, 265)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(147, 22)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(68, 61)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Título"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(68, 79)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 21)
        Me.TextBox5.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(405, 239)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Fecha Inicio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(178, 239)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Fecha Envio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(64, 172)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Requisitos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Descripción"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(68, 191)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(431, 33)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 131)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(431, 40)
        Me.TextBox1.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 371)
        Me.Panel1.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 263)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Esta es la parte que no se hace . PIPIPIPI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Correo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cédula:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Formulario del Estdiante"
        '
        'Publicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 477)
        Me.Controls.Add(Me.PanelOfertasAprobadas2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PanelOfertapublicada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Publicaciones"
        Me.Text = "Publicaciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOfertasAprobadas2.ResumeLayout(False)
        Me.PanelOfertasAprobadas2.PerformLayout()
        CType(Me.DGV_OfertaAprobada2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOfertapublicada.ResumeLayout(False)
        Me.PanelOfertapublicada.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPublicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelOfertasAprobadas2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_SiguientePub As Button
    Friend WithEvents DGV_OfertaAprobada2 As DataGridView
    Friend WithEvents PanelOfertapublicada As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class

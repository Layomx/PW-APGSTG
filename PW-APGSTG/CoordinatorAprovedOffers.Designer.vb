<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoordinadorAprovedOffers
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVPub = New System.Windows.Forms.DataGridView()
        Me.BTNPost = New System.Windows.Forms.Button()
        Me.BTNRefuse1 = New System.Windows.Forms.Button()
        Me.CloseBTN2 = New System.Windows.Forms.Button()
        CType(Me.DGVPub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(772, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Solicitudes Aprobadas de Practica Profesional de Empresas"
        '
        'DGVPub
        '
        Me.DGVPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPub.Location = New System.Drawing.Point(46, 44)
        Me.DGVPub.Name = "DGVPub"
        Me.DGVPub.RowHeadersWidth = 51
        Me.DGVPub.RowTemplate.Height = 24
        Me.DGVPub.Size = New System.Drawing.Size(1008, 484)
        Me.DGVPub.TabIndex = 3
        '
        'BTNPost
        '
        Me.BTNPost.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPost.Location = New System.Drawing.Point(46, 541)
        Me.BTNPost.Name = "BTNPost"
        Me.BTNPost.Size = New System.Drawing.Size(107, 38)
        Me.BTNPost.TabIndex = 5
        Me.BTNPost.Text = "Publicar"
        Me.BTNPost.UseVisualStyleBackColor = True
        '
        'BTNRefuse1
        '
        Me.BTNRefuse1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRefuse1.Location = New System.Drawing.Point(204, 541)
        Me.BTNRefuse1.Name = "BTNRefuse1"
        Me.BTNRefuse1.Size = New System.Drawing.Size(113, 38)
        Me.BTNRefuse1.TabIndex = 6
        Me.BTNRefuse1.Text = "Rechazar"
        Me.BTNRefuse1.UseVisualStyleBackColor = True
        '
        'CloseBTN2
        '
        Me.CloseBTN2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBTN2.Location = New System.Drawing.Point(963, 541)
        Me.CloseBTN2.Name = "CloseBTN2"
        Me.CloseBTN2.Size = New System.Drawing.Size(91, 38)
        Me.CloseBTN2.TabIndex = 7
        Me.CloseBTN2.Text = "Cerrar"
        Me.CloseBTN2.UseVisualStyleBackColor = True
        '
        'CoordinadorAprovedOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 591)
        Me.Controls.Add(Me.CloseBTN2)
        Me.Controls.Add(Me.BTNRefuse1)
        Me.Controls.Add(Me.BTNPost)
        Me.Controls.Add(Me.DGVPub)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CoordinadorAprovedOffers"
        Me.Text = "CoordinatorAprovedOffers"
        CType(Me.DGVPub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DGVPub As DataGridView
    Friend WithEvents BTNPost As Button
    Friend WithEvents BTNRefuse1 As Button
    Friend WithEvents CloseBTN2 As Button
End Class

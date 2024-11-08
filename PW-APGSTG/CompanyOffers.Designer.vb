<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyOffers
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
        Me.DGWCompanyOffers = New System.Windows.Forms.DataGridView()
        Me.CloseBTN = New System.Windows.Forms.Button()
        CType(Me.DGWCompanyOffers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ofertas publicadas"
        '
        'DGWCompanyOffers
        '
        Me.DGWCompanyOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWCompanyOffers.Location = New System.Drawing.Point(61, 83)
        Me.DGWCompanyOffers.Name = "DGWCompanyOffers"
        Me.DGWCompanyOffers.RowHeadersWidth = 51
        Me.DGWCompanyOffers.RowTemplate.Height = 24
        Me.DGWCompanyOffers.Size = New System.Drawing.Size(734, 385)
        Me.DGWCompanyOffers.TabIndex = 1
        '
        'CloseBTN
        '
        Me.CloseBTN.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBTN.Location = New System.Drawing.Point(384, 485)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(91, 38)
        Me.CloseBTN.TabIndex = 2
        Me.CloseBTN.Text = "Cerrar"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'CompanyOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 535)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.DGWCompanyOffers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CompanyOffers"
        Me.Text = "CompanyOffers"
        CType(Me.DGWCompanyOffers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGWCompanyOffers As DataGridView
    Friend WithEvents CloseBTN As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoordinatorRequestOffers
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
        Me.DGVAproved = New System.Windows.Forms.DataGridView()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.BTNAprove = New System.Windows.Forms.Button()
        Me.BTNRefuse = New System.Windows.Forms.Button()
        CType(Me.DGVAproved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(235, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(627, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Solicitudes de Practica Profesional de Empresas"
        '
        'DGVAproved
        '
        Me.DGVAproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAproved.Location = New System.Drawing.Point(40, 57)
        Me.DGVAproved.Name = "DGVAproved"
        Me.DGVAproved.RowHeadersWidth = 51
        Me.DGVAproved.RowTemplate.Height = 24
        Me.DGVAproved.Size = New System.Drawing.Size(1015, 464)
        Me.DGVAproved.TabIndex = 2
        '
        'CloseBTN
        '
        Me.CloseBTN.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBTN.Location = New System.Drawing.Point(964, 545)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(91, 38)
        Me.CloseBTN.TabIndex = 3
        Me.CloseBTN.Text = "Cerrar"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'BTNAprove
        '
        Me.BTNAprove.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAprove.Location = New System.Drawing.Point(40, 545)
        Me.BTNAprove.Name = "BTNAprove"
        Me.BTNAprove.Size = New System.Drawing.Size(107, 38)
        Me.BTNAprove.TabIndex = 4
        Me.BTNAprove.Text = "Aceptar"
        Me.BTNAprove.UseVisualStyleBackColor = True
        '
        'BTNRefuse
        '
        Me.BTNRefuse.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRefuse.Location = New System.Drawing.Point(194, 545)
        Me.BTNRefuse.Name = "BTNRefuse"
        Me.BTNRefuse.Size = New System.Drawing.Size(113, 38)
        Me.BTNRefuse.TabIndex = 5
        Me.BTNRefuse.Text = "Rechazar"
        Me.BTNRefuse.UseVisualStyleBackColor = True
        '
        'CoordinatorRequestOffers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 614)
        Me.Controls.Add(Me.BTNRefuse)
        Me.Controls.Add(Me.BTNAprove)
        Me.Controls.Add(Me.CloseBTN)
        Me.Controls.Add(Me.DGVAproved)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CoordinatorRequestOffers"
        Me.Text = "Solicitudes de practica profesional"
        CType(Me.DGVAproved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGVAproved As DataGridView
    Friend WithEvents CloseBTN As Button
    Friend WithEvents BTNAprove As Button
    Friend WithEvents BTNRefuse As Button
End Class

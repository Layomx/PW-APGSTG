Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlClient
Imports System.Web
Imports System.ComponentModel

Public Class CompanyForms
    ' Funciones
    ' Funcion para limpiar campos
    Private Sub ClearControls(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is GroupBox Then
                ClearControls(ctrl) ' Llamada recursiva para limpiar controles dentro de un GroupBox
            End If
        Next
    End Sub

    Private Sub CompanyForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                ' Variables con la informacion de la empresa que ingreso
                Dim ValCompanyEmail As String = Login.UserEmail

                Dim query As String = "SELECT NombreEmpresa, Direccion, Telefono FROM Usuario_Empresa WHERE EmailEmpresa = @ValCompanyEmail"
                Using nameCommand As New SqlCommand(query, conn)
                    nameCommand.Parameters.AddWithValue("@ValCompanyEmail", ValCompanyEmail)
                    Using nameReader As SqlDataReader = nameCommand.ExecuteReader
                        If nameReader.Read Then
                            Dim CompanyName As String = nameReader("NombreEmpresa").ToString
                            Dim CompanyAddress As String = nameReader("Direccion").ToString
                            Dim CompanyTelephone As String = nameReader("Telefono").ToString

                            GBCompanyInfoN1.Controls("LBLCompanyName").Text = $"{CompanyName}"
                            GBCompanyInfoN1.Controls("LBLCompanyAddress").Text = $"{CompanyAddress}"
                            GBCompanyInfoN1.Controls("LBLCompanyTelephone").Text = $"{CompanyTelephone}"
                        Else
                            MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al buscar el nombre de la empresa: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    ' Cerrar sesion
    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        Dim response As DialogResult = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Confirmar cierre de sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            MessageBox.Show("Sesion cerrada exitosamente")
            Me.Hide()
            ClearControls(Login)
            Login.Show()
        End If
    End Sub
End Class
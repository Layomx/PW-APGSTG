Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.SqlClient
Imports System.Web
Imports System.ComponentModel
Public Class CoordinatorForms
    ' Funcion para desactivar la navegacion por tabulador
    Private Sub DisableTabStop(ByVal controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            ctrl.TabStop = False
            ' Desactivando subcontroles llamando la funcion de forma recursiva
            If ctrl.HasChildren Then
                DisableTabStop(ctrl.Controls)
            End If
        Next
    End Sub

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

    Private Sub CoordinatorForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableTabStop(Me.Controls)
        Me.ActiveControl = Nothing

        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                ' Variables con la informacion del coordinador que ingreso
                Dim ValCoordinatorEmail As String = Login.UserEmail
                Dim IDFacultad As Integer

                ' Con este los labels cambiaran con la informacion de el coordinador
                Dim query As String = "SELECT Nombre_Coordinador, Apellido_Coordinador, ID_Facultad, EmailCoordinador FROM Usuario_Coordinador WHERE EmailCoordinador = @ValCoordinatorEmail"
                Using nameCommand As New SqlCommand(query, conn)
                    nameCommand.Parameters.AddWithValue("@ValCoordinatorEmail", ValCoordinatorEmail)
                    Using nameReader As SqlDataReader = nameCommand.ExecuteReader
                        If nameReader.Read Then
                            Dim CoordinatorName As String = nameReader("Nombre_Coordinador").ToString
                            Dim CoordinatorLastName As String = nameReader("Apellido_Coordinador").ToString
                            IDFacultad = Convert.ToInt32(nameReader("ID_Facultad"))
                            Dim CoordinatorEmail As String = nameReader("EmailCoordinador").ToString

                            LBLCoordinatorName.Text = $"{CoordinatorName} {CoordinatorLastName}"
                            LBLCoordinatorEmail.Text = $"{CoordinatorEmail}"
                        Else
                            MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

                Dim FacultyName As String

                Dim queryFaculty As String = "SELECT NombreFacultad FROM Facultad WHERE ID_Facultad = @IDFacultad"
                Using facultyCommand As New SqlCommand(queryFaculty, conn)
                    facultyCommand.Parameters.AddWithValue("@IDFacultad", IDFacultad)
                    Using facultyReader As SqlDataReader = facultyCommand.ExecuteReader
                        If facultyReader.Read Then
                            FacultyName = facultyReader("NombreFacultad").ToString
                            LBLCoordinatorFaculty.Text = $"{FacultyName}"
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar informacion del coordinator: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim response As DialogResult = MessageBox.Show("Estas seguro que deseas cerrar sesion?", "Confirmar cierre de sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            MessageBox.Show("Sesion cerrada exitosamente")
            Me.Hide()
            ClearControls(Login)
            Login.Show()
        End If
    End Sub

    Private Sub SolicitudesDePracticasProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesDePracticasProfesionalesToolStripMenuItem.Click
        CoordinatorRequestOffers.Show()
    End Sub
End Class
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Diagnostics.Tracing
Imports System.Web

Public Class RequestForm
    'Funciones
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

    ' Obtener el ID a traves del Email
    Private Function GettingID(email As String) As Integer?
        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Consulta SQL para obtener el ID
        Dim query As String = "SELECT ID_Empresa FROM Usuario_Empresa WHERE EmailEmpresa = @ValEmailEmpresa"

        ' Usando una variable nulable para manejar los casos donde no se encuentre el ID
        Dim userID As Integer? = Nothing

        ' Conexion con la base de datos
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ValEmailEmpresa", email)

                ' Abriendo conexion
                connection.Open()

                ' Ejecutando consulta
                Dim result As Object = command.ExecuteScalar()

                ' Comprobando si se encontro el ID
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    userID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        ' Retornando el ID
        Return userID
    End Function

    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableTabStop(Me.Controls)

        ' Configurando la fecha para que sea la actual
        RequestDate.Value = Date.Now
        RequestDate.Enabled = False
        EndDate.Value = Date.Now
        StartDate.Value = Date.Now

        ' Configurando los textos provesionales de los textbox
        RequestTitle.Text = "Titulo de la practica profesional"
        RequestTitle.ForeColor = Color.Gray
        RequestDescription.Text = "Descripcion breve de la practica profesional"
        RequestDescription.ForeColor = Color.Gray
        RequestRequirements.Text = "Requisitos minimos para aplicar a la practica profesional"
        RequestRequirements.ForeColor = Color.Gray

        ' Al cargarse el formulario ningun formulario estara seleccionado automatica
        Me.ActiveControl = Nothing
    End Sub

    ' Controlando los textos provisionales de los textbox
    Private Sub RequestTitle_Enter(sender As Object, e As EventArgs) Handles RequestTitle.Enter
        If RequestTitle.Text = "Titulo de la practica profesional" Then
            RequestTitle.Text = ""
            RequestTitle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RequestTitle_Leave(sender As Object, e As EventArgs) Handles RequestTitle.Leave
        If RequestTitle.Text = "" Then
            RequestTitle.Text = "Titulo de la practica profesional"
            RequestTitle.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RequestDescription_Enter(sender As Object, e As EventArgs) Handles RequestDescription.Enter
        If RequestDescription.Text = "Descripcion breve de la practica profesional" Then
            RequestDescription.Text = ""
            RequestDescription.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RequestDescription_Leave(sender As Object, e As EventArgs) Handles RequestDescription.Leave
        If RequestDescription.Text = "" Then
            RequestDescription.Text = "Descripcion breve de la practica profesional"
            RequestDescription.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub RequestRequirements_Enter(sender As Object, e As EventArgs) Handles RequestRequirements.Enter
        If RequestRequirements.Text = "Requisitos minimos para aplicar a la practica profesional" Then
            RequestRequirements.Text = ""
            RequestRequirements.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RequestRequirements_Leave(sender As Object, e As EventArgs) Handles RequestRequirements.Leave
        If RequestRequirements.Text = "" Then
            RequestRequirements.Text = "Requisitos minimos para aplicar a la practica profesional"
            RequestRequirements.ForeColor = Color.Gray
        End If
    End Sub

    ' Boton de cancelar solicitud
    Private Sub CancelRequest_Click(sender As Object, e As EventArgs) Handles CancelRequest.Click
        Dim response As DialogResult = MessageBox.Show("Estas seguro que cancelar la solicitud?", "Cancelando solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            MessageBox.Show("Solicitud cerrada existosamente")
            Me.Hide()
            ClearControls(Me)
        End If
    End Sub

    Private Sub SendRequest_Click(sender As Object, e As EventArgs) Handles SendRequest.Click
        ' Validando que nada este sin rellenar
        If RequestTitle.Text = "" Or RequestDescription.Text = "" Or RequestRequirements.Text = "" Or Faculty.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, completa todos los campos correctmente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If StartDate.Value = EndDate.Value Then
            MessageBox.Show("La fecha de inicio no puede ser la misma que la fecha final de la practica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Variables para guardar los datos
        Dim ValRequestTitle As String = RequestTitle.Text
        Dim ValRequestDescription As String = RequestDescription.Text
        Dim ValRequestStatus As String = "Enviado para aprobacion"
        Dim ValRequestSentDate As Date = RequestDate.Value.ToString("yyyy-MM-dd")
        Dim ValRequestRequirements As String = RequestRequirements.Text
        Dim ValStartDate As Date = StartDate.Value.ToString("yyyy-MM-dd")
        Dim ValEndDate As Date = EndDate.Value.ToString("yyyy-MM-dd")
        Dim IDFacultad As Integer
        Dim ValCompanyEmail As String = Login.UserEmail
        Dim IDEmpresa As Integer = GettingID(ValCompanyEmail)

        ' Facultad escogida
        Select Case Faculty.SelectedItem.ToString
            Case "Ingenieria en Sistemas Computacionales"
                IDFacultad = 1
            Case "Ingenieria Mecanica"
                IDFacultad = 2
            Case "Ciencias y Tecnologia"
                IDFacultad = 3
        End Select

        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        Using conn As New SqlConnection(connString)
            Try
                conn.Open()

                Dim query As String = "INSERT INTO OfertasEnviadas(Titulo, Descripcion, Estado, FechaEnvio, Requisitos, FechaInicio, FechaFin, ID_Empresa, ID_Facultad)" & "VALUES (@ValRequestTitle, @ValRequestDescription, @ValRequestStatus, @ValRequestSentDate, @ValRequestRequirements, @ValStartDate, @ValEndDate, @IDEmpresa, @IDFacultad)"
                Using commandInsert As New SqlCommand(query, conn)
                    commandInsert.Parameters.AddWithValue("@ValRequestTitle", ValRequestTitle)
                    commandInsert.Parameters.AddWithValue("@ValRequestDescription", ValRequestDescription)
                    commandInsert.Parameters.AddWithValue("@ValRequestStatus", ValRequestStatus)
                    commandInsert.Parameters.AddWithValue("@ValRequestSentDate", ValRequestSentDate)
                    commandInsert.Parameters.AddWithValue("@ValRequestRequirements", ValRequestRequirements)
                    commandInsert.Parameters.AddWithValue("@ValStartDate", ValStartDate)
                    commandInsert.Parameters.AddWithValue("@ValEndDate", ValEndDate)
                    commandInsert.Parameters.AddWithValue("@IDEmpresa", IDEmpresa)
                    commandInsert.Parameters.AddWithValue("@IDFacultad", IDFacultad)

                    Dim affectedRows As Integer = commandInsert.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Solicitud enviada correctamente.", "Envio exitoso", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Else
                        MessageBox.Show("No se pudo enviar la solicitud.", "Error en el envio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al enviar la solicitud: " & ex.Message, "Error en el envio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                conn.Close()
            End Try
            Me.Hide()
        End Using
    End Sub
End Class
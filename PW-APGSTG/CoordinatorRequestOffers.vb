﻿Imports System.Configuration
Imports System.Data.SqlClient

Public Class CoordinatorRequestOffers
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

    ' Obtener el ID a traves del Email
    Private Function GettingID(email As String) As Integer?
        ' Conectando la base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Consulta SQL para obtener el ID
        Dim query As String = "SELECT ID_Facultad FROM Usuario_Coordinador WHERE EmailCoordinador = @ValCoordinator"

        ' Usando una variable nulable para manejar los casos donde no se encuentre el ID
        Dim userID As Integer? = Nothing

        ' Conexion con la base de datos
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ValCoordinator", email)

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

    ' Funcion que consulta las ofertas de la empresa en especifico
    Private Sub CompanyOffersWithID(facultyID As Integer)
        ' Conectando base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Consulta SQL
        Dim query As String = "SELECT COD_Oferta, Titulo, Descripcion, Requisitos, FechaEnvio, Estado, FechaInicio, FechaFin, ID_Facultad, ID_Empresa FROM OfertasEnviadas WHERE ID_Facultad = @IDFacultad"

        ' Creando una tabla de datos 
        Dim dataTable As New DataTable()

        ' Conexion con la base de datos
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDFacultad", facultyID)

                ' Adaptador para llenar la tabla
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        DGVAproved.DataSource = dataTable
        DGVAproved.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGVAproved.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DGVAproved.Columns("COD_Oferta").HeaderText = "ID de la oferta"
        DGVAproved.Columns("Titulo").HeaderText = "Titulo"
        DGVAproved.Columns("Descripcion").HeaderText = "Descripcion"
        DGVAproved.Columns("Descripcion").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGVAproved.Columns("Requisitos").HeaderText = "Requisitos"
        DGVAproved.Columns("Requisitos").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGVAproved.Columns("FechaEnvio").HeaderText = "Fecha de envio"
        DGVAproved.Columns("Estado").HeaderText = "Estado de oferta"
        DGVAproved.Columns("FechaInicio").HeaderText = "Inicio"
        DGVAproved.Columns("FechaFin").HeaderText = "Fin"
        DGVAproved.Columns("ID_Facultad").HeaderText = "Facultad"
        DGVAproved.Columns("ID_Empresa").HeaderText = "Empresa"
    End Sub

    Private Sub CoordinatorRequestOffers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableTabStop(Me.Controls)

        Dim ValCoordinatorEmail = Login.UserEmail
        Dim IDFaculty As Integer = GettingID(ValCoordinatorEmail)

        CompanyOffersWithID(IDFaculty)

        Me.ActiveControl = Nothing
    End Sub

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub

    Private Sub BTNAprove_Click(sender As Object, e As EventArgs) Handles BTNAprove.Click
        If DGVAproved.SelectedRows.Count > 0 Then
            ' Obteniendo la fila seleccionada
            Dim selectedRow As DataGridViewRow = DGVAproved.SelectedRows(0)
            Dim CODOferta As Integer = Convert.ToInt32(selectedRow.Cells("COD_Oferta").Value)
            Dim offerDate As Date = Convert.ToDateTime(selectedRow.Cells(4).Value)
            Dim estado As String = "Publicada"

            ' Cadena de conexion 
            Dim connString As String = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString
            Using conn As New SqlConnection(connString)
                ' Elimina la fila de la base de datos de la tabla OfertasEnviadas
                Dim queryDelete As String = "DELETE FROM OfertasEnviadas WHERE COD_Oferta = @COD_Oferta"
                Dim cmdDelete As New SqlCommand(queryDelete, conn)
                cmdDelete.Parameters.AddWithValue("@COD_Oferta", CODOferta)

                conn.Open()
                Dim affectedRows As Integer = cmdDelete.ExecuteNonQuery()

                If affectedRows > 0 Then
                    ' Insertando la nueva oferta en la base de datos en la tabla OfertasEnviadas
                    Dim queryInsert As String = "INSERT INTO OfertasAprobadas (Titulo, Descripcion, Estado, FechaEnvio, Requisitos, FechaInicio, FechaFin, ID_Empresa, ID_Facultad)" & "VALUES(@Titulo, @Descripcion, @Estado, @FechaEnvio, @Requisitos, @FechaInicio, @FechaFin, @ID_Empresa, @ID_Facultad)"
                    Dim cmdInsert As New SqlCommand(queryInsert, conn)

                    cmdInsert.Parameters.AddWithValue("@Titulo", selectedRow.Cells("Titulo").Value)
                    cmdInsert.Parameters.AddWithValue("@Descripcion", selectedRow.Cells("Descripcion").Value)
                    cmdInsert.Parameters.AddWithValue("@Estado", estado)

                    Dim dateSent As DateTime
                    If DateTime.TryParse(selectedRow.Cells("FechaEnvio").Value.ToString(), dateSent) Then
                        ' Formatea la fecha en el formato que SQL espera
                        cmdInsert.Parameters.AddWithValue("@FechaEnvio", dateSent.ToString("yyyy-MM-dd"))
                    Else
                        ' Manejo de error si la conversion falla
                        MessageBox.Show("El formato de la fecha es invalido")
                        Exit Sub
                    End If

                    cmdInsert.Parameters.AddWithValue("@Requisitos", selectedRow.Cells("Requisitos").Value)

                    Dim dateStart As DateTime
                    If DateTime.TryParse(selectedRow.Cells("FechaInicio").Value.ToString(), dateStart) Then
                        ' Formatea la fecha en el formato que SQL espera
                        cmdInsert.Parameters.AddWithValue("@FechaInicio", dateStart.ToString("yyyy-MM-dd"))
                    Else
                        ' Manejo de error si la conversion falla
                        MessageBox.Show("El formato de la fecha es invalido")
                        Exit Sub
                    End If

                    Dim dateEnd As DateTime
                    If DateTime.TryParse(selectedRow.Cells("FechaFin").Value.ToString(), dateEnd) Then
                        ' Formatea la fecha en el formato que SQL espera
                        cmdInsert.Parameters.AddWithValue("@FechaFin", dateEnd.ToString("yyyy-MM-dd"))
                    Else
                        ' Manejo de error si la conversion falla
                        MessageBox.Show("El formato de la fecha es invalido")
                        Exit Sub
                    End If

                    cmdInsert.Parameters.AddWithValue("ID_Empresa", selectedRow.Cells("ID_Empresa").Value)
                    cmdInsert.Parameters.AddWithValue("ID_Facultad", selectedRow.Cells("ID_Facultad").Value)

                    ' Ejecutando la insercion
                    cmdInsert.ExecuteNonQuery()

                    ' Eliminando la fila del GDV de Solicitudes
                    DGVAproved.Rows.Remove(selectedRow)

                    MessageBox.Show("Oferta aceptada y movida a la lista de ofertas aceptadas.")
                Else
                    MessageBox.Show("No se pudo eliminar la oferta de la base de datos.")
                End If

                conn.Close()
            End Using
        Else
            MessageBox.Show("Por favor, selecciona una fila")
        End If
    End Sub

    Private Sub BTNRefuse_Click(sender As Object, e As EventArgs) Handles BTNRefuse.Click
        If DGVAproved.SelectedRows.Count > 0 Then
            ' Obteniendo la fila seleccionada
            Dim selectedRow As DataGridViewRow = DGVAproved.SelectedRows(0)
            Dim CODOferta As Integer = Convert.ToInt32(selectedRow.Cells("COD_Oferta").Value)

            ' Cadena de conexion 
            Dim connString As String = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString
            Using conn As New SqlConnection(connString)
                ' Elimina la fila de la base de datos de la tabla OfertasEnviadas
                Dim queryDelete As String = "DELETE FROM OfertasEnviadas WHERE COD_Oferta = @COD_Oferta"
                Dim cmdDelete As New SqlCommand(queryDelete, conn)
                cmdDelete.Parameters.AddWithValue("@COD_Oferta", CODOferta)

                conn.Open()
                Dim affectedRows As Integer = cmdDelete.ExecuteNonQuery()
                ' Eliminando la fila del GDV de Solicitudes
                DGVAproved.Rows.Remove(selectedRow)

                conn.Close()
                MessageBox.Show("Oferta eliminada existosamente")
            End Using
        Else
            MessageBox.Show("Por favor, selecciona una fila")
        End If
    End Sub
End Class
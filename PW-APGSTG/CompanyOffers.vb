Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web

Public Class CompanyOffers
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

    ' Funcion que consulta las ofertas de la empresa en especifico
    Private Sub CompanyOffersWithID(empresaID As Integer)
        ' Conectando base de datos
        Dim connString = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString

        ' Consulta SQL
        Dim query As String = "SELECT COD_Oferta AS COD_Oferta, Titulo, FechaEnvio, Estado FROM OfertasEnviadas WHERE ID_Empresa = @IDEmpresa UNION ALL SELECT COD_OfertaAprobada AS COD_Oferta, Titulo, FechaEnvio, Estado FROM OfertasAprobadas WHERE ID_Empresa = @IDEmpresa"

        ' Creando una tabla de datos 
        Dim dataTable As New DataTable()

        ' Conexion con la base de datos
        Using connection As New SqlConnection(connString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IDEmpresa", empresaID)

                ' Adaptador para llenar la tabla
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        DGWCompanyOffers.DataSource = dataTable
        DGWCompanyOffers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGWCompanyOffers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DGWCompanyOffers.Columns("COD_Oferta").HeaderText = "ID de la oferta"
        DGWCompanyOffers.Columns("Titulo").HeaderText = "Titulo"
        DGWCompanyOffers.Columns("FechaEnvio").HeaderText = "Fecha de envio"
        DGWCompanyOffers.Columns("Estado").HeaderText = "Estado de oferta"
    End Sub
    Private Sub CompanyOffers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableTabStop(Me.Controls)

        Dim ValCompanyEmail As String = Login.UserEmail
        Dim IDCompany As Integer = GettingID(ValCompanyEmail)

        CompanyOffersWithID(IDCompany)
    End Sub

    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Me.Close()
    End Sub
End Class
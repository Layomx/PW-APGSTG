Imports System.Configuration
Imports System.Data.SqlClient

Public Class Publicaciones
    Private Sub AgregarPublicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPublicaciónToolStripMenuItem.Click
        PanelOfertasAprobadas2.Visible = Not PanelOfertasAprobadas2.Visible
    End Sub

    Private Sub PanelOfertasAprobadas2_Paint(sender As Object, e As PaintEventArgs) Handles PanelOfertasAprobadas2.Paint
        Dim connString As String = ConfigurationManager.ConnectionStrings("PW_APGSTG.My.MySettings.PW_APGSTGConnectionString").ConnectionString
        Dim query As String = "SELECT * FROM OfertasAprobadas" ' Consulta para obtener los datos de la tabla OfertasAprobadas
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_OfertaAprobada2.DataSource = table ' Asignar la tabla como fuente de datos
        End Using
    End Sub

    Private Sub BTN_SiguientePub_Click(sender As Object, e As EventArgs) Handles BTN_SiguientePub.Click
        ' Evento Click del botón "Siguiente
        ' Verifica si hay una fila seleccionada en DGV_OfertasAprobadas
        If DGV_OfertaAprobada2.SelectedRows.Count > 0 Then
            ' Toma la primera fila seleccionada (por ejemplo)
            Dim filaSeleccionada As DataGridViewRow = DGV_OfertaAprobada2.SelectedRows(0)

            ' Puedes hacer algo con los datos de la fila seleccionada si es necesario
            Dim tituloOferta As String = filaSeleccionada.Cells("Titulo").Value.ToString()
            MessageBox.Show("Has seleccionado la oferta: " & tituloOferta)

            ' Cambia la visibilidad del panel
            PanelOfertapublicada.Visible = True
            ' Opcionalmente, oculta otros paneles si es necesario
            ' PanelOtraSeccion.Visible = False
        Else
            MessageBox.Show("Por favor, selecciona una oferta aprobada antes de continuar.")
        End If
    End Sub
End Class
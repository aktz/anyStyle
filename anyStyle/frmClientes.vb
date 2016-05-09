Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmClientes
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        CargarGrid()
        RecalcularAnchoVGrid()
    End Sub

    Private Sub RecalcularAnchoVGrid()
        vgrdDetalles.RecordWidth = vgrdDetalles.Width - vgrdDetalles.RowHeaderWidth - 5
    End Sub

    Private Sub vgrdDetalles_SizeChanged(sender As Object, e As EventArgs) Handles vgrdDetalles.SizeChanged
        RecalcularAnchoVGrid()
    End Sub

    Private Sub CargarCombos()

    End Sub

    Private Sub CargarGrid()
        gcClientes.DataSource = Nothing

        sSQL = "select * from dbo.Clientes where IDCompania = " & frmMain.oDatosUsuario.Compania
        Dim dtProveedor As New DataTable
        dtProveedor = f.EjecutarQuery(sSQL)

        If dtProveedor.Rows.Count > 0 Then
            RemoveHandler grdClientes.FocusedRowChanged, AddressOf grdClientes_FocusedRowChanged
            gcClientes.DataSource = dtProveedor
            AddHandler grdClientes.FocusedRowChanged, AddressOf grdClientes_FocusedRowChanged

            grdClientes.FocusedRowHandle = iRegistroActivo

            CargarDetalles()
        End If
    End Sub

    Private Sub CargarDetalles()
        For Each row In vgrdDetalles.Rows
            row.Properties.Value = Nothing
        Next

        If Not IsNothing(grdClientes.GetFocusedRow) Then
            Dim dr As DataRowView = grdClientes.GetFocusedRow

            vgrdDetalles.Rows("rowIDCliente").Properties.Value = dr("IDCliente")
            vgrdDetalles.Rows("rowCodigoCliente").Properties.Value = dr("CodigoCliente")
            vgrdDetalles.Rows("rowNombreCliente").Properties.Value = dr("NombreCliente")
            vgrdDetalles.Rows("rowTelefonoCliente").Properties.Value = dr("TelefonoCliente")
            vgrdDetalles.Rows("rowDireccionCliente").Properties.Value = dr("DireccionCliente")
            vgrdDetalles.Rows("rowEmailCliente").Properties.Value = dr("EmailCliente")
            vgrdDetalles.Rows("rowFechaCliente").Properties.Value = dr("FechaCliente")
            vgrdDetalles.Rows("rowIndActivo").Properties.Value = dr("IndActivo")
        End If
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Visible = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdClientes.Columns(7).Visible = bEstado
    End Sub

    Private Sub grdClientes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdClientes.FocusedRowChanged
        If Not IsNothing(gcClientes.DataSource) Then
            iRegistroActivo = grdClientes.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdProveedores_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdClientes.RowCellClick
        If e.Column.Name = "proEliminar" Then

            If MessageBox.Show("Está seguro de eliminar este cliente?", "Eliminar Cliente",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "Select count(*) from ClientesHistorial where IDCliente = " &
                        grdClientes.GetFocusedRowCellValue("IDCliente") &
                        " and IndActivo = 1"
                Dim dt As New DataTable
                dt = f.EjecutarQuery(sSQL)

                If dt.Rows(0)(0) = 0 Then
                    grdClientes.DeleteRow(e.RowHandle)
                    gcClientes.DataSource.AcceptChanges()
                Else
                    MessageBox.Show("No es posible eliminar el cliente. Existe historil vinculado.", "Eliminar Cliente")
                End If

            End If
        End If
    End Sub

    Private Sub frmUsuarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.oListaFormularios.Remove(sender.Text)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        HabilitarControles(True)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar() Then
            Guardar()
        End If

        HabilitarControles(False)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CargarGrid()

        HabilitarControles(False)
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        AgregarRegistro()
    End Sub

    Private Sub AgregarRegistro()
        Dim dt As DataTable
        Dim dr As DataRow

        If Not IsNothing(gcClientes.DataSource) Then
            dt = gcClientes.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDCliente", Type.GetType("System.Int32"))
            dt.Columns.Add("IDCompania", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoCliente", Type.GetType("System.String"))
            dt.Columns.Add("NombreCliente", Type.GetType("System.String"))
            dt.Columns.Add("TelefonoCliente", Type.GetType("System.String"))
            dt.Columns.Add("DireccionCliente", Type.GetType("System.String"))
            dt.Columns.Add("EmailCliente", Type.GetType("System.String"))
            dt.Columns.Add("FechaCliente", Type.GetType("System.DateTime"))
            dt.Columns.Add("IndActivo", Type.GetType("System.Boolean"))
        End If

        dr = dt.NewRow

        dr("IDCliente") = 0
        dr("IDCompania") = frmMain.oDatosUsuario.Compania
        dr("CodigoCliente") = ""
        dr("NombreCliente") = ""
        dr("TelefonoCliente") = ""
        dr("DireccionCliente") = ""
        dr("EmailCliente") = ""
        dr("FechaCliente") = Date.Now
        dr("IndActivo") = True
        dt.Rows.Add(dr)

        gcClientes.DataSource = dt
        grdClientes.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdClientes.FocusedRowHandle
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Try
            Select Case e.Row.Name
                Case "rowCodigoCliente"
                    grdClientes.SetFocusedRowCellValue("CodigoCliente", e.Row.Properties.Value)
                Case "rowNombreCliente"
                    grdClientes.SetFocusedRowCellValue("NombreCliente", e.Row.Properties.Value)
                Case "rowTelefonoCliente"
                    grdClientes.SetFocusedRowCellValue("TelefonoCliente", e.Row.Properties.Value)
                Case "rowDireccionCliente"
                    grdClientes.SetFocusedRowCellValue("DireccionCliente", e.Row.Properties.Value)
                Case "rowEmailCliente"
                    grdClientes.SetFocusedRowCellValue("EmailCliente", e.Row.Properties.Value)
                Case "rowFechaCliente"
                    grdClientes.SetFocusedRowCellValue("FechaCliente", e.Row.Properties.Value)
                Case "rowIndActivo"
                    grdClientes.SetFocusedRowCellValue("IndActivo", e.Row.Properties.Value)
            End Select

            gcClientes.DataSource.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcClientes.DataSource.Rows
            If row("CodigoCliente") = "" OrElse row("NombreCliente") = "" Then
                bValidacion = False
                MessageBox.Show("Existen Campos por configurar")
                Exit For
            End If
        Next

        Return bValidacion
    End Function

    Private Sub Guardar()
        Dim clsPro As New clsProcedimientos
        Dim dtPro As New DataTable

        gcClientes.Focus()

        dtPro = clsPro.pClientes(gcClientes.DataSource)
        CargarGrid()
    End Sub


End Class
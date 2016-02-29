Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmCompanias
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    Private Sub frmGrupos_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        gcCompanias.DataSource = Nothing

        sSQL = "select * from dbo.Companias"
        Dim dtUsuario As New DataTable
        dtUsuario = f.EjecutarQuery(sSQL)

        RemoveHandler grdCompanias.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged
        gcCompanias.DataSource = dtUsuario
        AddHandler grdCompanias.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged

        grdCompanias.FocusedRowHandle = iRegistroActivo
        CargarDetalles()
    End Sub

    Private Sub CargarDetalles()
        Dim dr As DataRowView = grdCompanias.GetFocusedRow

        vgrdDetalles.Rows("rowIDCompania").Properties.Value = dr("IDCompania")
        vgrdDetalles.Rows("rowCodigoCompania").Properties.Value = dr("CodigoCompania")
        vgrdDetalles.Rows("rowNombreCompania").Properties.Value = dr("NombreCompania")
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Enabled = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdCompanias.Columns(3).Visible = bEstado
    End Sub

    Private Sub grdUsuarios_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdCompanias.FocusedRowChanged
        If Not IsNothing(gcCompanias.DataSource) Then
            iRegistroActivo = grdCompanias.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdUsuarios_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdCompanias.RowCellClick
        If e.Column.Name = "comEliminar" Then

            If MessageBox.Show("Está seguro de eliminar esta compañía?", "Eliminar compañía", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "select count(*) from UsuariosCompanias where IDCompania = " & grdCompanias.GetFocusedRowCellValue("IDCompania")
                Dim dt As New DataTable
                dt = f.EjecutarQuery(sSQL)

                If dt.Rows(0)(0) = 0 Then
                    grdCompanias.DeleteRow(e.RowHandle)
                    gcCompanias.DataSource.AcceptChanges()
                Else
                    MessageBox.Show("No es posible eliminar la compañía. Existen usuarios vinculados.", "Eliminar compañía")
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

        If Not IsNothing(gcCompanias.DataSource) Then
            dt = gcCompanias.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDCompania", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoCompania", Type.GetType("System.String"))
            dt.Columns.Add("NombreCompania", Type.GetType("System.String"))
        End If

        dr = dt.NewRow

        dr("IDCompania") = 0
        dr("CodigoCompania") = ""
        dr("Nombrecompania") = ""
        dt.Rows.Add(dr)

        gcCompanias.DataSource = dt
        grdCompanias.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdCompanias.FocusedRowHandle
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Select Case e.Row.Name
            Case "rowCodigoCompania"
                grdCompanias.SetFocusedRowCellValue("CodigoCompania", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowNombreCompania"
                grdCompanias.SetFocusedRowCellValue("NombreCompania", e.Row.Properties.Value.ToString.ToUpper)
        End Select

        gcCompanias.DataSource.AcceptChanges()
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcCompanias.DataSource.Rows
            If row("CodigoCompania") = "" AndAlso row("NombreCompania") = "" Then
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

        gcCompanias.Focus()

        dtPro = clsPro.pCompanias(gcCompanias.DataSource)
        CargarGrid()
    End Sub


End Class
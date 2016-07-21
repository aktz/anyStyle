Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmCategorias
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        CargarGrid()
        RecalcularAnchoVGrid()
        HabilitarControles(False)
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
        gcCategorias.DataSource = Nothing

        sSQL = "select * from dbo.Categorias where IDCompania = " & frmMain.oDatosUsuario.Compania
        Dim dtProveedor As New DataTable
        dtProveedor = f.EjecutarQuery(sSQL)

        If dtProveedor.Rows.Count > 0 Then
            RemoveHandler grdCategorias.FocusedRowChanged, AddressOf grdProveedores_FocusedRowChanged
            gcCategorias.DataSource = dtProveedor
            AddHandler grdCategorias.FocusedRowChanged, AddressOf grdProveedores_FocusedRowChanged

            grdCategorias.FocusedRowHandle = iRegistroActivo
            CargarDetalles()
        End If
    End Sub

    Private Sub CargarDetalles()
        For Each row In vgrdDetalles.Rows
            row.Properties.Value = Nothing
        Next

        If Not IsNothing(grdCategorias.GetFocusedRow) Then
            Dim dr As DataRowView = grdCategorias.GetFocusedRow

            vgrdDetalles.Rows("rowIDCategoria").Properties.Value = dr("IDCategoria")
            vgrdDetalles.Rows("rowCodigoCategoria").Properties.Value = dr("CodigoCategoria")
            vgrdDetalles.Rows("rowNombreCategoria").Properties.Value = dr("NombreCategoria")
            vgrdDetalles.Rows("rowIndActivo").Properties.Value = dr("IndActivo")
        End If
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Visible = bEstado

        grdCategorias.Columns(5).Visible = bEstado

        If grdCategorias.RowCount > 0 Then
            For Each row In vgrdDetalles.Rows
                row.Properties.ReadOnly = Not bEstado
            Next
        Else
            For Each row In vgrdDetalles.Rows
                row.Properties.ReadOnly = True
            Next
        End If
    End Sub

    Private Sub grdProveedores_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdCategorias.FocusedRowChanged
        If Not IsNothing(gcCategorias.DataSource) Then
            iRegistroActivo = grdCategorias.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdProductos_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdCategorias.RowCellClick
        If e.Column.Name = "proEliminar" Then

            If MessageBox.Show("Está seguro de eliminar esta categoría?", "Eliminar Categoría",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "select count(*)" &
                        " from ProductosCategorias" &
                        " where IDCategoria = " & frmMain.oDatosUsuario.Compania
                Dim dt As New DataTable
                dt = f.EjecutarQuery(sSQL)

                If dt.Rows(0)(0) = 0 Then
                    grdCategorias.DeleteRow(e.RowHandle)
                    gcCategorias.DataSource.AcceptChanges()
                Else
                    MessageBox.Show("No es posible eliminar la categoria. Existen productos vinculados.", "Eliminar Categoría")
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
        iOperacion = 0
        HabilitarControles(False)
    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        AgregarRegistro()
    End Sub

    Private Sub AgregarRegistro()
        Dim dt As DataTable
        Dim dr As DataRow

        If Not IsNothing(gcCategorias.DataSource) Then
            dt = gcCategorias.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDCategoria", Type.GetType("System.Int32"))
            dt.Columns.Add("IDCompania", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoCategoria", Type.GetType("System.String"))
            dt.Columns.Add("NombreCategoria", Type.GetType("System.String"))
            dt.Columns.Add("IndActivo", Type.GetType("System.Boolean"))
        End If

        dr = dt.NewRow

        dr("IDCategoria") = 0
        dr("IDCompania") = frmMain.oDatosUsuario.Compania
        dr("CodigoCategoria") = ""
        dr("NombreCategoria") = ""
        dr("IndActivo") = True
        dt.Rows.Add(dr)

        gcCategorias.DataSource = dt
        grdCategorias.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdCategorias.FocusedRowHandle

        HabilitarControles(True)
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Try
            If grdCategorias.RowCount > 0 Then
                Select Case e.Row.Name
                    Case "rowCodigoCategoria"
                        grdCategorias.SetFocusedRowCellValue("CodigoCategoria", e.Row.Properties.Value)
                    Case "rowNombreCategoria"
                        grdCategorias.SetFocusedRowCellValue("NombreCategoria", e.Row.Properties.Value)
                    Case "rowIndActivo"
                        grdCategorias.SetFocusedRowCellValue("IndActivo", e.Row.Properties.Value)
                End Select

                gcCategorias.DataSource.AcceptChanges()
            Else
                MessageBox.Show("No existen registos de categorías. Primero debe insertar una.")

                For Each row In vgrdDetalles.Rows
                    row.Properties.Value = Nothing
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcCategorias.DataSource.Rows
            If row("CodigoCategoria") = "" OrElse row("NombreCategoria") = "" Then
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

        gcCategorias.Focus()

        dtPro = clsPro.pCategorias(gcCategorias.DataSource)
        CargarGrid()
    End Sub


End Class
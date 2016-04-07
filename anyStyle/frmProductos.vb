﻿Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmProductos
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        gcProductos.DataSource = Nothing

        sSQL = "select * from dbo.Productos where IDCompania = " & frmMain.oDatosUsuario.Compania
        Dim dtProveedor As New DataTable
        dtProveedor = f.EjecutarQuery(sSQL)

        If dtProveedor.Rows.Count > 0 Then
            RemoveHandler grdProductos.FocusedRowChanged, AddressOf grdProveedores_FocusedRowChanged
            gcProductos.DataSource = dtProveedor
            AddHandler grdProductos.FocusedRowChanged, AddressOf grdProveedores_FocusedRowChanged

            grdProductos.FocusedRowHandle = iRegistroActivo

            CargarDetalles()
        End If
    End Sub

    Private Sub CargarDetalles()
        For Each row In vgrdDetalles.Rows
            row.Properties.Value = Nothing
        Next

        If Not IsNothing(grdProductos.GetFocusedRow) Then
            Dim dr As DataRowView = grdProductos.GetFocusedRow

            vgrdDetalles.Rows("rowIDProveedor").Properties.Value = dr("IDProveedor")
            vgrdDetalles.Rows("rowCodigoProveedor").Properties.Value = dr("CodigoProveedor")
            vgrdDetalles.Rows("rowNombreProveedor").Properties.Value = dr("NombreProveedor")
            vgrdDetalles.Rows("rowTelefonoProveedor").Properties.Value = dr("TelefonoProveedor")
            vgrdDetalles.Rows("rowDireccionProveedor").Properties.Value = dr("DireccionProveedor")
            vgrdDetalles.Rows("rowIndActivo").Properties.Value = dr("IndActivo")
        End If
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Visible = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdProductos.Columns(7).Visible = bEstado
    End Sub

    Private Sub grdProveedores_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdProductos.FocusedRowChanged
        If Not IsNothing(gcProductos.DataSource) Then
            iRegistroActivo = grdProductos.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdProveedores_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdProductos.RowCellClick
        If e.Column.Name = "proEliminar" Then

            If MessageBox.Show("Está seguro de eliminar este proveedor?", "Eliminar Proveedor",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "Select count(*) from ProveedoresProductos where IDProveedor = " &
                        grdProductos.GetFocusedRowCellValue("IDProveedor") &
                        " and IndActivo = 1"
                Dim dt As New DataTable
                dt = f.EjecutarQuery(sSQL)

                If dt.Rows(0)(0) = 0 Then
                    grdProductos.DeleteRow(e.RowHandle)
                    gcProductos.DataSource.AcceptChanges()
                Else
                    MessageBox.Show("No es posible eliminar el proveedor. Existen productos vinculados.", "Eliminar Proveedor")
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

        If Not IsNothing(gcProductos.DataSource) Then
            dt = gcProductos.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDProveedor", Type.GetType("System.Int32"))
            dt.Columns.Add("IDCompania", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoProveedor", Type.GetType("System.String"))
            dt.Columns.Add("NombreProveedor", Type.GetType("System.String"))
            dt.Columns.Add("TelefonoProveedor", Type.GetType("System.String"))
            dt.Columns.Add("DireccionProveedor", Type.GetType("System.String"))
            dt.Columns.Add("IndActivo", Type.GetType("System.Boolean"))
        End If

        dr = dt.NewRow

        dr("IDProveedor") = 0
        dr("IDCompania") = frmMain.oDatosUsuario.Compania
        dr("CodigoProveedor") = ""
        dr("NombreProveedor") = ""
        dr("TelefonoProveedor") = ""
        dr("DireccionProveedor") = ""
        dr("IndActivo") = True
        dt.Rows.Add(dr)

        gcProductos.DataSource = dt
        grdProductos.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdProductos.FocusedRowHandle
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Try
            Select Case e.Row.Name
                Case "rowCodigoProveedor"
                    grdProductos.SetFocusedRowCellValue("CodigoProveedor", e.Row.Properties.Value)
                Case "rowNombreProveedor"
                    grdProductos.SetFocusedRowCellValue("NombreProveedor", e.Row.Properties.Value)
                Case "rowTelefonoProveedor"
                    grdProductos.SetFocusedRowCellValue("TelefonoProveedor", e.Row.Properties.Value)
                Case "rowDireccionProveedor"
                    grdProductos.SetFocusedRowCellValue("DireccionProveedor", e.Row.Properties.Value)
                Case "rowIndActivo"
                    grdProductos.SetFocusedRowCellValue("IndActivo", e.Row.Properties.Value)
            End Select

            gcProductos.DataSource.AcceptChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcProductos.DataSource.Rows
            If row("CodigoProveedor") = "" AndAlso row("NombreProveedor") = "" Then
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

        gcProductos.Focus()

        dtPro = clsPro.pProveedores(gcProductos.DataSource)
        CargarGrid()
    End Sub


End Class
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmGrupos
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
        gcGrupos.DataSource = Nothing

        sSQL = "select * from dbo.Grupos"
        Dim dtUsuario As New DataTable
        dtUsuario = f.EjecutarQuery(sSQL)

        RemoveHandler grdGrupos.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged
        gcGrupos.DataSource = dtUsuario
        AddHandler grdGrupos.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged

        grdGrupos.FocusedRowHandle = iRegistroActivo
        CargarDetalles()
    End Sub

    Private Sub CargarDetalles()
        Dim dr As DataRowView = grdGrupos.GetFocusedRow

        vgrdDetalles.Rows("rowIDGrupo").Properties.Value = dr("IDGrupo")
        vgrdDetalles.Rows("rowCodigoGrupo").Properties.Value = dr("CodigoGrupo")
        vgrdDetalles.Rows("rowNombreGrupo").Properties.Value = dr("NombreGrupo")
        vgrdDetalles.Rows("rowIndActivo").Properties.Value = dr("IndActivo")
        vgrdDetalles.Rows("rowIndModificar").Properties.Value = dr("IndModificar")
        vgrdDetalles.Rows("rowIndConfigurarUsuarios").Properties.Value = dr("IndConfigurarUsuarios")
        vgrdDetalles.Rows("rowIndReportes").Properties.Value = dr("IndReportes")
        vgrdDetalles.Rows("rowIndManejaCaja").Properties.Value = dr("IndManejaCaja")
        vgrdDetalles.Rows("rowIndManejaProductos").Properties.Value = dr("IndManejaProductos")
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Enabled = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdGrupos.Columns(10).Visible = bEstado
    End Sub

    Private Sub grdUsuarios_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdGrupos.FocusedRowChanged
        If Not IsNothing(gcGrupos.DataSource) Then
            iRegistroActivo = grdGrupos.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdUsuarios_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdGrupos.RowCellClick
        If e.Column.Name = "grpEliminar" Then

            If MessageBox.Show("Está seguro de eliminar este grupo?", "Eliminar Grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "select count(*) from Usuarios where IDGrupoUsuarios = " & grdGrupos.GetFocusedRowCellValue("IDGrupo")
                Dim dt As New DataTable
                dt = f.EjecutarQuery(sSQL)

                If dt.Rows(0)(0) = 0 Then
                    grdGrupos.DeleteRow(e.RowHandle)
                    gcGrupos.DataSource.AcceptChanges()
                Else
                    MessageBox.Show("No es posible eliminar el grupo. Existen usuarios vinculados.", "Eliminar Grupo")
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

        If Not IsNothing(gcGrupos.DataSource) Then
            dt = gcGrupos.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDGrupo", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoGrupo", Type.GetType("System.String"))
            dt.Columns.Add("NombreGrupo", Type.GetType("System.String"))
            dt.Columns.Add("IndActivo", Type.GetType("System.Boolean"))
            dt.Columns.Add("IndModificar", Type.GetType("System.Boolean"))
            dt.Columns.Add("IndConfigurarUsuarios", Type.GetType("System.Boolean"))
            dt.Columns.Add("IndReportes", Type.GetType("System.Boolean"))
            dt.Columns.Add("IndManejaCaja", Type.GetType("System.Boolean"))
            dt.Columns.Add("IndManejaProductos", Type.GetType("System.Boolean"))
        End If

        dr = dt.NewRow

        dr("IDGrupo") = 0
        dr("CodigoGrupo") = ""
        dr("NombreGrupo") = ""
        dr("IndActivo") = True
        dr("IndModificar") = True
        dr("IndConfigurarUsuarios") = True
        dr("IndReportes") = True
        dr("IndManejaCaja") = True
        dr("IndManejaProductos") = True
        dt.Rows.Add(dr)

        gcGrupos.DataSource = dt
        grdGrupos.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdGrupos.FocusedRowHandle
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Select Case e.Row.Name
            Case "rowCodigoGrupo"
                grdGrupos.SetFocusedRowCellValue("CodigoGrupo", e.Row.Properties.Value)
            Case "rowNombreGrupo"
                grdGrupos.SetFocusedRowCellValue("NombreGrupo", e.Row.Properties.Value)
            Case "rowIndActivo"
                grdGrupos.SetFocusedRowCellValue("IndActivo", e.Row.Properties.Value)
            Case "rowIndModificar"
                grdGrupos.SetFocusedRowCellValue("IndModificar", e.Row.Properties.Value)
            Case "rowIndConfigurarUsuarios"
                grdGrupos.SetFocusedRowCellValue("IndConfigurarUsuarios", e.Row.Properties.Value)
            Case "rowIndReportes"
                grdGrupos.SetFocusedRowCellValue("IndReportes", e.Row.Properties.Value)
            Case "rowIndManejaCaja"
                grdGrupos.SetFocusedRowCellValue("IndManejaCaja", e.Row.Properties.Value)
            Case "rowIndManejaProductos"
                grdGrupos.SetFocusedRowCellValue("IndManejaProductos", e.Row.Properties.Value)
        End Select

        gcGrupos.DataSource.AcceptChanges()
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcGrupos.DataSource.Rows
            If row("CodigoGrupo") = "" AndAlso row("NombreGrupo") = "" Then
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

        gcGrupos.Focus()

        dtPro = clsPro.pGrupos(gcGrupos.DataSource)
        CargarGrid()
    End Sub


End Class
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports btnInsertar.XtraVerticalGrid.Events
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Public Class frmUsuarios
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        Dim dt As New DataTable

        sSQL = "select IDGrupo as IDGrupoUsuarios, CodigoGrupo + ' - ' + NombreGrupo as NombreGrupo" &
        " from Grupos where IDCompania = " & frmMain.oDatosUsuario.Compania

        dt = f.EjecutarQuery(sSQL)
        f.LlenarComboGrid(cboGrupoUsuarioCol, dt, 0, 1)
    End Sub

    Private Sub CargarGrid()
        gcUsuarios.DataSource = Nothing

        sSQL = "select * from dbo.Usuarios"
        Dim dtUsuario As New DataTable
        dtUsuario = f.EjecutarQuery(sSQL)

        RemoveHandler grdUsuarios.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged
        gcUsuarios.DataSource = dtUsuario
        AddHandler grdUsuarios.FocusedRowChanged, AddressOf grdUsuarios_FocusedRowChanged

        grdUsuarios.FocusedRowHandle = iRegistroActivo
        CargarDetalles()
    End Sub

    Private Sub CargarDetalles()
        Dim dr As DataRowView = grdUsuarios.GetFocusedRow

        vgrdDetalles.Rows("rowIDUsuario").Properties.Value = dr("IDUsuario")
        vgrdDetalles.Rows("rowCodigoUsuario").Properties.Value = dr("CodigoUsuario")
        vgrdDetalles.Rows("rowNombreUsuario").Properties.Value = dr("NombreUsuario")
        vgrdDetalles.Rows("rowIDGrupoUsuarios").Properties.Value = dr("IDGrupoUsuarios")
        vgrdDetalles.Rows("rowTelefonoUsuario").Properties.Value = dr("TelefonoUsuario")
        vgrdDetalles.Rows("rowEmailUsuario").Properties.Value = dr("EmailUsuario")
        vgrdDetalles.Rows("rowPwdUsuario").Properties.Value = f.Desencriptar(dr("PwdUsuario"))
        vgrdDetalles.Rows("rowIndActivo").Properties.Value = dr("IndActivo")
    End Sub

    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Visible = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdUsuarios.Columns(8).Visible = bEstado
        'chklGruposCompanias.Enabled = bEstado
    End Sub

    Private Sub ActualizarCombos()
        '    Dim iGrupoActual As Integer = vgrdDetalles.Rows("rowIDGrupoUsuario").Properties.Value
        '    CargarCombos()
        '    vgrdDetalles.Rows("rowIDGrupoUsuario").Properties.Value = iGrupoActual
    End Sub

    Private Sub grdUsuarios_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdUsuarios.FocusedRowChanged
        If Not IsNothing(gcUsuarios.DataSource) Then
            iRegistroActivo = grdUsuarios.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    Private Sub grdUsuarios_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdUsuarios.RowCellClick
        If e.Column.Name = "usuEliminar" Then

            If MessageBox.Show("Está seguro de eliminar este usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                grdUsuarios.DeleteRow(e.RowHandle)
                gcUsuarios.DataSource.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub frmUsuarios_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.oListaFormularios.Remove(sender.Text)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ActualizarCombos()
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

    Private Sub btnCompaniaGrupo_Click(sender As Object, e As EventArgs) Handles btnCompaniaGrupo.Click
        LlenarCompaniasGrupos()
        grpCompaniaGrupo.Visible = True
    End Sub

    Private Sub LlenarCompaniasGrupos()
        sSQL = "select com.IDCompania, com.CodigoCompania, com.NombreCompania, uco.IDGrupoUsuarios" &
                " from Companias com" &
                " left outer join UsuariosCompanias uco on com.IDCompania = uco.IDCompania"
        Dim dtCompania As New DataTable
        dtCompania = f.EjecutarQuery(sSQL)

        gcCompanias.DataSource = IIf(dtCompania.Rows.Count > 0, dtCompania, Nothing)
    End Sub

    Private Sub btnAceptarCompaniaGrupo_Click(sender As Object, e As EventArgs) Handles btnAceptarCompaniaGrupo.Click
        'grabar en tabla

        grpCompaniaGrupo.Visible = False
    End Sub

    Private Sub AgregarRegistro()
        Dim dt As DataTable
        Dim dr As DataRow

        If Not IsNothing(gcUsuarios.DataSource) Then
            dt = gcUsuarios.DataSource.Copy
        Else
            dt = New DataTable
            dt.Columns.Add("IDUsuario", Type.GetType("System.Int32"))
            dt.Columns.Add("CodigoUsuario", Type.GetType("System.Int32"))
            dt.Columns.Add("NombreUsuario", Type.GetType("System.String"))
            dt.Columns.Add("IDGrupoUsuarios", Type.GetType("System.Int32"))
            dt.Columns.Add("TelefonoUsuario", Type.GetType("System.String"))
            dt.Columns.Add("EmailUsuario", Type.GetType("System.String"))
            dt.Columns.Add("PwdUsuario", Type.GetType(SqlDbType.Binary))
            dt.Columns.Add("IndActivo", Type.GetType("System.Boolean"))
        End If

        dr = dt.NewRow

        dr("IDUsuario") = 0
        dr("CodigoUsuario") = ""
        dr("NombreUsuario") = ""
        dr("IDGrupoUsuarios") = 0
        dr("TelefonoUsuario") = ""
        dr("EmailUsuario") = ""
        dr("PwdUsuario") = "LdG+QR6uHr8="
        dr("IndActivo") = True
        dt.Rows.Add(dr)

        gcUsuarios.DataSource = dt
        grdUsuarios.FocusedRowHandle = dt.Rows.Count - 1
        iRegistroActivo = grdUsuarios.FocusedRowHandle
    End Sub

    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        Select Case e.Row.Name
            Case "rowCodigoUsuario"
                grdUsuarios.SetFocusedRowCellValue("CodigoUsuario", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowNombreUsuario"
                grdUsuarios.SetFocusedRowCellValue("NombreUsuario", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowIDGrupoUsuarios"
                grdUsuarios.SetFocusedRowCellValue("IDGrupoUsuarios", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowTelefonoUsuario"
                grdUsuarios.SetFocusedRowCellValue("TelefonoUsuario", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowEmailUsuario"
                grdUsuarios.SetFocusedRowCellValue("EmailUsuario", e.Row.Properties.Value.ToString.ToUpper)
            Case "rowPwdUsuario"
                grdUsuarios.SetFocusedRowCellValue("PwdUsuario", f.Encriptar(e.Row.Properties.Value))
            Case "rowIndActivo"
                grdUsuarios.SetFocusedRowCellValue("IndActivo", e.Row.Properties.Value.ToString.ToUpper)
        End Select

        gcUsuarios.DataSource.AcceptChanges()
    End Sub

    Private Function Validar() As Boolean
        Dim bValidacion As Boolean = True

        For Each row As DataRow In gcUsuarios.DataSource.Rows
            If row("CodigoUsuario") = "" AndAlso row("NombreUsuario") = "" AndAlso row("TelefonoUsuario") AndAlso
            row("IDGrupoUsuarios") = 0 AndAlso row("EmailUsuario") = "" AndAlso row("PwdUsuario") = "" Then
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

        gcUsuarios.Focus()

        dtPro = clsPro.pUsuarios(gcUsuarios.DataSource)
        CargarGrid()
    End Sub

    Private Sub grdCompanias_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdCompanias.FocusedRowChanged
        sSQL = "select IDGrupo, CodigoGrupo + ' - ' + NombreGrupo as NombreGrupo" &
                " from Grupos where IDCompania = " & grdCompanias.GetFocusedRowCellValue("IDCompania") &
                " order by CodigoGrupo"

        sSQL = "select gr.IDGrupo, gr.CodigoGrupo + ' - ' + gr.NombreGrupo as NombreGrupo," &
                " case when uc.IDUsuario Is Not null then 1 else 0 end as Activo" &
                " from Grupos gr" &
                " left outer join UsuariosCompanias uc on gr.IDGrupo = uc.IDGrupoUsuarios and gr.IDCompania = uc.IDCompania" &
                " where gr.IDCompania = " & grdCompanias.GetFocusedRowCellValue("IDCompania") &
                " order by gr.CodigoGrupo"

        Dim dt As New DataTable
        dt = f.EjecutarQuery(sSQL)

        chklGruposCompanias.Items.Clear()

        For Each row In dt.Rows
            Dim itm As New CheckedListBoxItem
            itm.Value = row("IDGrupo")
            itm.Description = row("NombreGrupo")
            itm.CheckState = row("Activo")

            chklGruposCompanias.Items.Add(itm)
        Next
    End Sub

    Private Sub chklGruposCompanias_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chklGruposCompanias.ItemCheck
        If e.State = CheckState.Checked Then
            For Each item As CheckedListBoxItem In chklGruposCompanias.Items
                If item.Value <> chklGruposCompanias.Items(e.Index).Value AndAlso item.CheckState = CheckState.Checked Then
                    item.CheckState = CheckState.Unchecked
                End If
            Next
        End If
    End Sub
End Class
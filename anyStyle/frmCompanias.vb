Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmCompanias
    Dim f As New clsFunciones
    Dim sSQL As String
    Dim iOperacion As Integer = 0
    Dim iRegistroActivo As Integer = 0

    ''' <summary>
    ''' Cargue del Formulario Grupos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmGrupos_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        CargarGrid()
        RecalcularAnchoVGrid()
    End Sub

    ''' <summary>
    ''' Recalcular ancho del vertical grid
    ''' </summary>
    Private Sub RecalcularAnchoVGrid()
        vgrdDetalles.RecordWidth = vgrdDetalles.Width - vgrdDetalles.RowHeaderWidth - 5
    End Sub

    ''' <summary>
    ''' Evento de cambio de tamaño del vertical grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub vgrdDetalles_SizeChanged(sender As Object, e As EventArgs) Handles vgrdDetalles.SizeChanged
        RecalcularAnchoVGrid()
    End Sub

    ''' <summary>
    ''' Evento de cargue de combos
    ''' </summary>
    Private Sub CargarCombos()

    End Sub

    ''' <summary>
    ''' Evento de Cargue de grid
    ''' </summary>
    Private Sub CargarGrid()
        gcCompanias.DataSource = Nothing

        sSQL = "select * from dbo.Companias"
        Dim dtCompanias As New DataTable
        dtCompanias = f.EjecutarQuery(sSQL)

        If dtCompanias.Rows.Count Then
            RemoveHandler grdCompanias.FocusedRowChanged, AddressOf grdCompanias_FocusedRowChanged
            gcCompanias.DataSource = dtCompanias
            AddHandler grdCompanias.FocusedRowChanged, AddressOf grdCompanias_FocusedRowChanged

            grdCompanias.FocusedRowHandle = iRegistroActivo
            CargarDetalles()
        End If
    End Sub

    ''' <summary>
    ''' Cargue de datos desde el grid hacia los controles vinculados
    ''' </summary>
    Private Sub CargarDetalles()
        For Each row In vgrdDetalles.Rows
            row.Properties.Value = Nothing
        Next

        If Not IsNothing(grdCompanias.GetFocusedRow) Then
            Dim dr As DataRowView = grdCompanias.GetFocusedRow

            vgrdDetalles.Rows("rowIDCompania").Properties.Value = dr("IDCompania")
            vgrdDetalles.Rows("rowCodigoCompania").Properties.Value = dr("CodigoCompania")
            vgrdDetalles.Rows("rowNombreCompania").Properties.Value = dr("NombreCompania")
        End If
    End Sub

    ''' <summary>
    ''' Habilitación|deshabilitación de controles
    ''' </summary>
    ''' <param name="bEstado"></param>
    Private Sub HabilitarControles(ByVal bEstado As Boolean)
        btnModificar.Enabled = Not bEstado
        btnGuardar.Enabled = bEstado
        btnCancelar.Enabled = bEstado
        btnInsertar.Visible = bEstado

        vgrdDetalles.OptionsBehavior.Editable = bEstado
        grdCompanias.Columns(3).Visible = bEstado
    End Sub

    ''' <summary>
    ''' Evento de cambio de fila en el grid companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub grdCompanias_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdCompanias.FocusedRowChanged
        If Not IsNothing(gcCompanias.DataSource) Then
            iRegistroActivo = grdCompanias.FocusedRowHandle
            CargarDetalles()
        End If
    End Sub

    ''' <summary>
    ''' Evento de click en celda del grid companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub grdUsuarios_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grdCompanias.RowCellClick
        If e.Column.Name = "comEliminar" Then

            If MessageBox.Show("Está seguro de eliminar esta compañía?", "Eliminar compañía",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sSQL = "select count(*) from UsuariosCompanias where IDCompania = " &
                        grdCompanias.GetFocusedRowCellValue("IDCompania")
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

    ''' <summary>
    ''' Evento de cerrado de formulario companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCompanias_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.oListaFormularios.Remove(sender.Text)
    End Sub

    ''' <summary>
    ''' Evento de click boton modificar companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        HabilitarControles(True)
    End Sub

    ''' <summary>
    ''' Evento de click boton guardar companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Validar() Then
            Guardar()
        End If

        HabilitarControles(False)
    End Sub

    ''' <summary>
    ''' Evento click boton cancelar companias
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CargarGrid()

        HabilitarControles(False)
    End Sub

    ''' <summary>
    ''' Evento click boton insertar compania
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        AgregarRegistro()
    End Sub

    ''' <summary>
    ''' Agregar registro
    ''' copia de dt del grid o crea nuevo si el grid está vacío
    ''' </summary>
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

    ''' <summary>
    ''' Evento Valor cambiado en vertical grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub vgrdDetalles_CellValueChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles vgrdDetalles.CellValueChanged
        If grdCompanias.RowCount > 0 Then
            Select Case e.Row.Name
                Case "rowCodigoCompania"
                    grdCompanias.SetFocusedRowCellValue("CodigoCompania", e.Row.Properties.Value.ToString.ToUpper)
                Case "rowNombreCompania"
                    grdCompanias.SetFocusedRowCellValue("NombreCompania", e.Row.Properties.Value.ToString.ToUpper)
            End Select

            gcCompanias.DataSource.AcceptChanges()
        Else
            MessageBox.Show("No existen registos de compañías. Primero debe insertar una.")

            For Each row In vgrdDetalles.Rows
                row.Properties.Value = Nothing
            Next
        End If
    End Sub

    ''' <summary>
    ''' Validar datos requeridos
    ''' </summary>
    ''' <returns></returns>
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

    ''' <summary>
    ''' Guardar Compania
    ''' Si la tabla está vacía, se crea la inicial, luego se crea el grupo superusuario y usuario superusuario 
    ''' y la vinculacion de usuario con compania
    ''' </summary>
    Private Sub Guardar()
        Dim swInicial As Boolean
        Dim iIDCompania As Integer
        Dim iIDGrupoUsuario As Integer
        Dim iIDUsuario As Integer

        sSQL = "select count(*) from dbo.Companias"
        Dim dtNumero As New DataTable
        dtNumero = f.EjecutarQuery(sSQL)

        swInicial = IIf(dtNumero.Rows(0)(0) = 0, True, False)

        Dim clsPro As New clsProcedimientos
        Dim dtPro As New DataTable

        gcCompanias.Focus()

        dtPro = clsPro.pCompanias(gcCompanias.DataSource)
        CargarGrid()

        If swInicial Then
            sSQL = "select IDCompania from Companias"
            Dim dtIDInicial As New DataTable
            dtIDInicial = f.EjecutarQuery(sSQL)
            iIDCompania = dtIDInicial.Rows(0)(0)

            sSQL = "insert into Grupos" &
                    " select " & iIDCompania & ", 'GR999', 'SUPERUSUARIO', 1, 1, 1, 1, 1, 1"
            f.EjecutarComando(sSQL)

            sSQL = "select IDGrupo from Grupos"
            dtIDInicial = f.EjecutarQuery(sSQL)
            iIDGrupoUsuario = dtIDInicial.Rows(0)(0)

            sSQL = "insert into Usuarios" &
                    " select '9999999', 'SUPERUSUARIO', " & iIDGrupoUsuario & ", '3176483284'," &
                    " 'anysw.col@gmail.com', 'k+LLCFDdYof8E5AUDwAADTzAiq31GvWQ', 1"

            f.EjecutarComando(sSQL)

            sSQL = "select IDUsuario from Usuarios"
            dtIDInicial = f.EjecutarQuery(sSQL)
            iIDUsuario = dtIDInicial.Rows(0)(0)

            sSQL = "insert into UsuariosCompanias" &
                    " select " & iIDUsuario & ", " & iIDCompania & ", " & iIDGrupoUsuario & ", 1"

            f.EjecutarComando(sSQL)
        End If
    End Sub


End Class
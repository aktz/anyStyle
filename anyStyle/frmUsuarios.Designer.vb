<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.grpCompaniaGrupo = New DevExpress.XtraEditors.GroupControl()
        Me.chklGruposCompanias = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.btnAceptarCompaniaGrupo = New DevExpress.XtraEditors.SimpleButton()
        Me.gcCompanias = New DevExpress.XtraGrid.GridControl()
        Me.grdCompanias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.comIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comCodigoCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comNombreCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repNombreCompania = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.comIDGrupoUsuarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repIDGrupoUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gcUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.grdUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.usuIDUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuCodigoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuNombreUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuTelefonoUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuEmailUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuPwdUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuIndActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.usuEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.chkActivoCol = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repTelefonoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repPwdUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rowIDUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIDGrupoUsuarios = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTelefonoUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEmailUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPwdUsuario = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndActivo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCompaniaGrupo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.usuIDGrupoUsuarios = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.grpCompaniaGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCompaniaGrupo.SuspendLayout()
        CType(Me.chklGruposCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreCompania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repIDGrupoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivoCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefonoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPwdUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.grpCompaniaGrupo)
        Me.pnlContenedor.Controls.Add(Me.gcUsuarios)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'grpCompaniaGrupo
        '
        Me.grpCompaniaGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCompaniaGrupo.Controls.Add(Me.chklGruposCompanias)
        Me.grpCompaniaGrupo.Controls.Add(Me.btnAceptarCompaniaGrupo)
        Me.grpCompaniaGrupo.Controls.Add(Me.gcCompanias)
        Me.grpCompaniaGrupo.Location = New System.Drawing.Point(652, 425)
        Me.grpCompaniaGrupo.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCompaniaGrupo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grpCompaniaGrupo.Name = "grpCompaniaGrupo"
        Me.grpCompaniaGrupo.Size = New System.Drawing.Size(522, 344)
        Me.grpCompaniaGrupo.TabIndex = 5
        Me.grpCompaniaGrupo.Text = "RELACIÓN USUARIO - COMPAÑÍAS - GRUPO"
        Me.grpCompaniaGrupo.Visible = False
        '
        'chklGruposCompanias
        '
        Me.chklGruposCompanias.CheckOnClick = True
        Me.chklGruposCompanias.ItemHeight = 20
        Me.chklGruposCompanias.Location = New System.Drawing.Point(329, 23)
        Me.chklGruposCompanias.Name = "chklGruposCompanias"
        Me.chklGruposCompanias.Size = New System.Drawing.Size(188, 280)
        Me.chklGruposCompanias.TabIndex = 6
        '
        'btnAceptarCompaniaGrupo
        '
        Me.btnAceptarCompaniaGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptarCompaniaGrupo.Image = CType(resources.GetObject("btnAceptarCompaniaGrupo.Image"), System.Drawing.Image)
        Me.btnAceptarCompaniaGrupo.Location = New System.Drawing.Point(421, 309)
        Me.btnAceptarCompaniaGrupo.Name = "btnAceptarCompaniaGrupo"
        Me.btnAceptarCompaniaGrupo.Size = New System.Drawing.Size(96, 30)
        Me.btnAceptarCompaniaGrupo.TabIndex = 5
        Me.btnAceptarCompaniaGrupo.Text = "ACEPTAR"
        '
        'gcCompanias
        '
        Me.gcCompanias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcCompanias.Location = New System.Drawing.Point(5, 23)
        Me.gcCompanias.MainView = Me.grdCompanias
        Me.gcCompanias.Name = "gcCompanias"
        Me.gcCompanias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repNombreCompania, Me.repIDGrupoUsuarios})
        Me.gcCompanias.Size = New System.Drawing.Size(318, 280)
        Me.gcCompanias.TabIndex = 3
        Me.gcCompanias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCompanias})
        '
        'grdCompanias
        '
        Me.grdCompanias.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdCompanias.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdCompanias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.comIDCompania, Me.comCodigoCompania, Me.comNombreCompania, Me.comIDGrupoUsuarios})
        Me.grdCompanias.GridControl = Me.gcCompanias
        Me.grdCompanias.Name = "grdCompanias"
        Me.grdCompanias.OptionsBehavior.Editable = False
        Me.grdCompanias.OptionsView.RowAutoHeight = True
        Me.grdCompanias.OptionsView.ShowGroupPanel = False
        Me.grdCompanias.OptionsView.ShowIndicator = False
        '
        'comIDCompania
        '
        Me.comIDCompania.Caption = "IDCompania"
        Me.comIDCompania.FieldName = "IDCompania"
        Me.comIDCompania.Name = "comIDCompania"
        '
        'comCodigoCompania
        '
        Me.comCodigoCompania.Caption = "CÓDIGO"
        Me.comCodigoCompania.FieldName = "CodigoCompania"
        Me.comCodigoCompania.Name = "comCodigoCompania"
        Me.comCodigoCompania.Visible = True
        Me.comCodigoCompania.VisibleIndex = 0
        Me.comCodigoCompania.Width = 88
        '
        'comNombreCompania
        '
        Me.comNombreCompania.Caption = "COMPAÑÍA"
        Me.comNombreCompania.ColumnEdit = Me.repNombreCompania
        Me.comNombreCompania.FieldName = "NombreCompania"
        Me.comNombreCompania.Name = "comNombreCompania"
        Me.comNombreCompania.Visible = True
        Me.comNombreCompania.VisibleIndex = 1
        Me.comNombreCompania.Width = 228
        '
        'repNombreCompania
        '
        Me.repNombreCompania.Name = "repNombreCompania"
        '
        'comIDGrupoUsuarios
        '
        Me.comIDGrupoUsuarios.Caption = "IDGrupo"
        Me.comIDGrupoUsuarios.ColumnEdit = Me.repIDGrupoUsuarios
        Me.comIDGrupoUsuarios.FieldName = "IDGrupoUsuarios"
        Me.comIDGrupoUsuarios.Name = "comIDGrupoUsuarios"
        Me.comIDGrupoUsuarios.Width = 208
        '
        'repIDGrupoUsuarios
        '
        Me.repIDGrupoUsuarios.AutoHeight = False
        Me.repIDGrupoUsuarios.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repIDGrupoUsuarios.Name = "repIDGrupoUsuarios"
        '
        'gcUsuarios
        '
        Me.gcUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcUsuarios.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcUsuarios.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcUsuarios.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcUsuarios.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcUsuarios.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcUsuarios.Location = New System.Drawing.Point(5, 5)
        Me.gcUsuarios.MainView = Me.grdUsuarios
        Me.gcUsuarios.Name = "gcUsuarios"
        Me.gcUsuarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar})
        Me.gcUsuarios.Size = New System.Drawing.Size(304, 478)
        Me.gcUsuarios.TabIndex = 0
        Me.gcUsuarios.UseEmbeddedNavigator = True
        Me.gcUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdUsuarios})
        '
        'grdUsuarios
        '
        Me.grdUsuarios.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdUsuarios.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdUsuarios.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdUsuarios.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdUsuarios.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdUsuarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.usuIDUsuario, Me.usuCodigoUsuario, Me.usuNombreUsuario, Me.usuIDGrupoUsuarios, Me.usuTelefonoUsuario, Me.usuEmailUsuario, Me.usuPwdUsuario, Me.usuIndActivo, Me.usuEliminar})
        Me.grdUsuarios.GridControl = Me.gcUsuarios
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.OptionsBehavior.Editable = False
        Me.grdUsuarios.OptionsView.ShowGroupPanel = False
        Me.grdUsuarios.OptionsView.ShowIndicator = False
        '
        'usuIDUsuario
        '
        Me.usuIDUsuario.Caption = "IDUsuario"
        Me.usuIDUsuario.FieldName = "IDUsuario"
        Me.usuIDUsuario.Name = "usuIDUsuario"
        '
        'usuCodigoUsuario
        '
        Me.usuCodigoUsuario.Caption = "DOCUMENTO"
        Me.usuCodigoUsuario.FieldName = "CodigoUsuario"
        Me.usuCodigoUsuario.Name = "usuCodigoUsuario"
        Me.usuCodigoUsuario.Visible = True
        Me.usuCodigoUsuario.VisibleIndex = 0
        Me.usuCodigoUsuario.Width = 67
        '
        'usuNombreUsuario
        '
        Me.usuNombreUsuario.Caption = "NOMBRE"
        Me.usuNombreUsuario.FieldName = "NombreUsuario"
        Me.usuNombreUsuario.Name = "usuNombreUsuario"
        Me.usuNombreUsuario.Visible = True
        Me.usuNombreUsuario.VisibleIndex = 1
        Me.usuNombreUsuario.Width = 214
        '
        'usuTelefonoUsuario
        '
        Me.usuTelefonoUsuario.Caption = "Teléfono"
        Me.usuTelefonoUsuario.FieldName = "TelefonoUsuario"
        Me.usuTelefonoUsuario.Name = "usuTelefonoUsuario"
        '
        'usuEmailUsuario
        '
        Me.usuEmailUsuario.Caption = "Email"
        Me.usuEmailUsuario.FieldName = "EmailUsuario"
        Me.usuEmailUsuario.Name = "usuEmailUsuario"
        '
        'usuPwdUsuario
        '
        Me.usuPwdUsuario.Caption = "PwdUsuario"
        Me.usuPwdUsuario.FieldName = "PwdUsuario"
        Me.usuPwdUsuario.Name = "usuPwdUsuario"
        '
        'usuIndActivo
        '
        Me.usuIndActivo.Caption = "Activo"
        Me.usuIndActivo.FieldName = "IndActivo"
        Me.usuIndActivo.Name = "usuIndActivo"
        '
        'usuEliminar
        '
        Me.usuEliminar.ColumnEdit = Me.repEliminar
        Me.usuEliminar.Name = "usuEliminar"
        Me.usuEliminar.Width = 21
        '
        'repEliminar
        '
        Me.repEliminar.AutoHeight = False
        SerializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        SerializableAppearanceObject1.Options.UseBackColor = True
        Me.repEliminar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "X", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.repEliminar.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.repEliminar.Name = "repEliminar"
        Me.repEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GrupoUsuarioCol
        '
        Me.GrupoUsuarioCol.AutoHeight = False
        Me.GrupoUsuarioCol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GrupoUsuarioCol.Name = "GrupoUsuarioCol"
        '
        'btnAgregar
        '
        Me.btnAgregar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.Appearance.Options.UseBackColor = True
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(5, 405)
        Me.btnAgregar.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.LookAndFeel.SkinName = "Foggy"
        Me.btnAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(304, 30)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "AGREGAR REGISTRO"
        '
        'vgrdDetalles
        '
        Me.vgrdDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.vgrdDetalles.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.vgrdDetalles.Location = New System.Drawing.Point(315, 5)
        Me.vgrdDetalles.Name = "vgrdDetalles"
        Me.vgrdDetalles.OptionsBehavior.Editable = False
        Me.vgrdDetalles.OptionsView.AutoScaleBands = True
        Me.vgrdDetalles.RecordWidth = 354
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkActivoCol, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repNombreUsuario, Me.repTelefonoUsuario, Me.repEmailUsuario, Me.repPwdUsuario})
        Me.vgrdDetalles.RowHeaderWidth = 105
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDUsuario, Me.rowCodigoUsuario, Me.rowNombreUsuario, Me.rowIDGrupoUsuarios, Me.rowTelefonoUsuario, Me.rowEmailUsuario, Me.rowPwdUsuario, Me.rowIndActivo})
        Me.vgrdDetalles.Size = New System.Drawing.Size(465, 478)
        Me.vgrdDetalles.TabIndex = 1
        '
        'chkActivoCol
        '
        Me.chkActivoCol.Appearance.Options.UseTextOptions = True
        Me.chkActivoCol.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkActivoCol.AutoHeight = False
        Me.chkActivoCol.Caption = ""
        Me.chkActivoCol.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.chkActivoCol.Name = "chkActivoCol"
        Me.chkActivoCol.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkActivoCol.ValueGrayed = False
        '
        'cboGrupoUsuarioCol
        '
        Me.cboGrupoUsuarioCol.AutoHeight = False
        Me.cboGrupoUsuarioCol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupoUsuarioCol.Name = "cboGrupoUsuarioCol"
        '
        'repCodigoUsuario
        '
        Me.repCodigoUsuario.AutoHeight = False
        Me.repCodigoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoUsuario.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.repCodigoUsuario.Mask.EditMask = "[0-9]*"
        Me.repCodigoUsuario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoUsuario.Mask.SaveLiteral = False
        Me.repCodigoUsuario.Mask.ShowPlaceHolders = False
        Me.repCodigoUsuario.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoUsuario.MaxLength = 50
        Me.repCodigoUsuario.Name = "repCodigoUsuario"
        '
        'repNombreUsuario
        '
        Me.repNombreUsuario.AutoHeight = False
        Me.repNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreUsuario.Mask.EditMask = "[0-9a-zA-ZñÑáéíóú \-_#$%&]*"
        Me.repNombreUsuario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreUsuario.Mask.ShowPlaceHolders = False
        Me.repNombreUsuario.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreUsuario.MaxLength = 50
        Me.repNombreUsuario.Name = "repNombreUsuario"
        '
        'repTelefonoUsuario
        '
        Me.repTelefonoUsuario.AutoHeight = False
        Me.repTelefonoUsuario.Mask.EditMask = "[0-9]*"
        Me.repTelefonoUsuario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repTelefonoUsuario.Mask.ShowPlaceHolders = False
        Me.repTelefonoUsuario.Mask.UseMaskAsDisplayFormat = True
        Me.repTelefonoUsuario.MaxLength = 50
        Me.repTelefonoUsuario.Name = "repTelefonoUsuario"
        '
        'repEmailUsuario
        '
        Me.repEmailUsuario.AutoHeight = False
        Me.repEmailUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repEmailUsuario.Mask.EditMask = "[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})"
        Me.repEmailUsuario.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repEmailUsuario.Mask.ShowPlaceHolders = False
        Me.repEmailUsuario.Mask.UseMaskAsDisplayFormat = True
        Me.repEmailUsuario.Name = "repEmailUsuario"
        '
        'repPwdUsuario
        '
        Me.repPwdUsuario.AutoHeight = False
        Me.repPwdUsuario.Name = "repPwdUsuario"
        Me.repPwdUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'rowIDUsuario
        '
        Me.rowIDUsuario.Appearance.Options.UseTextOptions = True
        Me.rowIDUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowIDUsuario.Name = "rowIDUsuario"
        Me.rowIDUsuario.Properties.Caption = "IDUSUARIO"
        Me.rowIDUsuario.Properties.FieldName = "IDUsuario"
        Me.rowIDUsuario.Visible = False
        '
        'rowCodigoUsuario
        '
        Me.rowCodigoUsuario.Appearance.Options.UseTextOptions = True
        Me.rowCodigoUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoUsuario.Height = 20
        Me.rowCodigoUsuario.Name = "rowCodigoUsuario"
        Me.rowCodigoUsuario.Properties.Caption = "DOCUMENTO"
        Me.rowCodigoUsuario.Properties.FieldName = "CodigoUsuario"
        Me.rowCodigoUsuario.Properties.RowEdit = Me.repCodigoUsuario
        '
        'rowNombreUsuario
        '
        Me.rowNombreUsuario.Appearance.Options.UseTextOptions = True
        Me.rowNombreUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombreUsuario.Height = 20
        Me.rowNombreUsuario.Name = "rowNombreUsuario"
        Me.rowNombreUsuario.Properties.Caption = "NOMBRE "
        Me.rowNombreUsuario.Properties.FieldName = "NombreUsuario"
        Me.rowNombreUsuario.Properties.RowEdit = Me.repNombreUsuario
        '
        'rowIDGrupoUsuarios
        '
        Me.rowIDGrupoUsuarios.Name = "rowIDGrupoUsuarios"
        Me.rowIDGrupoUsuarios.Properties.Caption = "GRUPO"
        Me.rowIDGrupoUsuarios.Properties.FieldName = "IDGrupoUsuarios"
        Me.rowIDGrupoUsuarios.Properties.RowEdit = Me.cboGrupoUsuarioCol
        '
        'rowTelefonoUsuario
        '
        Me.rowTelefonoUsuario.Appearance.Options.UseTextOptions = True
        Me.rowTelefonoUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowTelefonoUsuario.Height = 20
        Me.rowTelefonoUsuario.Name = "rowTelefonoUsuario"
        Me.rowTelefonoUsuario.Properties.Caption = "TELÉFONO"
        Me.rowTelefonoUsuario.Properties.FieldName = "TelefonoUsuario"
        Me.rowTelefonoUsuario.Properties.RowEdit = Me.repTelefonoUsuario
        '
        'rowEmailUsuario
        '
        Me.rowEmailUsuario.Appearance.Options.UseTextOptions = True
        Me.rowEmailUsuario.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowEmailUsuario.Height = 20
        Me.rowEmailUsuario.Name = "rowEmailUsuario"
        Me.rowEmailUsuario.Properties.Caption = "EMAIL"
        Me.rowEmailUsuario.Properties.FieldName = "EmailUsuario"
        Me.rowEmailUsuario.Properties.RowEdit = Me.repEmailUsuario
        '
        'rowPwdUsuario
        '
        Me.rowPwdUsuario.Height = 20
        Me.rowPwdUsuario.Name = "rowPwdUsuario"
        Me.rowPwdUsuario.Properties.Caption = "CONTRASEÑA"
        Me.rowPwdUsuario.Properties.FieldName = "PwdUsuario"
        Me.rowPwdUsuario.Properties.RowEdit = Me.repPwdUsuario
        '
        'rowIndActivo
        '
        Me.rowIndActivo.Appearance.Options.UseTextOptions = True
        Me.rowIndActivo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rowIndActivo.Height = 20
        Me.rowIndActivo.Name = "rowIndActivo"
        Me.rowIndActivo.Properties.Caption = "ACTIVO"
        Me.rowIndActivo.Properties.FieldName = "IndActivo"
        Me.rowIndActivo.Properties.RowEdit = Me.chkActivoCol
        '
        'panOperaciones
        '
        Me.panOperaciones.Controls.Add(Me.btnInsertar)
        Me.panOperaciones.Controls.Add(Me.btnCompaniaGrupo)
        Me.panOperaciones.Controls.Add(Me.btnCancelar)
        Me.panOperaciones.Controls.Add(Me.btnGuardar)
        Me.panOperaciones.Controls.Add(Me.btnModificar)
        Me.panOperaciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.panOperaciones.Location = New System.Drawing.Point(791, 0)
        Me.panOperaciones.Name = "panOperaciones"
        Me.panOperaciones.Size = New System.Drawing.Size(79, 495)
        Me.panOperaciones.TabIndex = 1
        '
        'btnInsertar
        '
        Me.btnInsertar.AllowFocus = False
        Me.btnInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInsertar.Appearance.Options.UseBackColor = True
        Me.btnInsertar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInsertar.Enabled = False
        Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
        Me.btnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnInsertar.Location = New System.Drawing.Point(5, 429)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(69, 61)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Insertar"
        '
        'btnCompaniaGrupo
        '
        Me.btnCompaniaGrupo.AllowFocus = False
        Me.btnCompaniaGrupo.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCompaniaGrupo.Appearance.Options.UseBackColor = True
        Me.btnCompaniaGrupo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCompaniaGrupo.Image = CType(resources.GetObject("btnCompaniaGrupo.Image"), System.Drawing.Image)
        Me.btnCompaniaGrupo.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCompaniaGrupo.Location = New System.Drawing.Point(5, 282)
        Me.btnCompaniaGrupo.Name = "btnCompaniaGrupo"
        Me.btnCompaniaGrupo.Size = New System.Drawing.Size(69, 61)
        Me.btnCompaniaGrupo.TabIndex = 0
        Me.btnCompaniaGrupo.Text = "Grupos"
        Me.btnCompaniaGrupo.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.AllowFocus = False
        Me.btnCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelar.Appearance.Options.UseBackColor = True
        Me.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(5, 139)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(69, 61)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowFocus = False
        Me.btnGuardar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.Appearance.Options.UseBackColor = True
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(5, 72)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 61)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        '
        'btnModificar
        '
        Me.btnModificar.AllowFocus = False
        Me.btnModificar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Appearance.Options.UseBackColor = True
        Me.btnModificar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(5, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(69, 61)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        '
        'usuIDGrupoUsuarios
        '
        Me.usuIDGrupoUsuarios.Caption = "Grupo"
        Me.usuIDGrupoUsuarios.FieldName = "IDGrupoUsuarios"
        Me.usuIDGrupoUsuarios.Name = "usuIDGrupoUsuarios"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "USUARIOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.grpCompaniaGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCompaniaGrupo.ResumeLayout(False)
        CType(Me.chklGruposCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreCompania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repIDGrupoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivoCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefonoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPwdUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowIDUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents usuIDUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents usuCodigoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents usuNombreUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents usuTelefonoUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents usuEmailUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents usuIndActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTelefonoUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEmailUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndActivo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents chkActivoCol As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboGrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panOperaciones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repCodigoUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents usuEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repEliminar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents repNombreUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repTelefonoUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repPwdUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rowPwdUsuario As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents usuPwdUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCompanias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCompanias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents comIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comCodigoCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comNombreCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNombreCompania As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grpCompaniaGrupo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCompaniaGrupo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptarCompaniaGrupo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repIDGrupoUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents comIDGrupoUsuarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chklGruposCompanias As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents rowIDGrupoUsuarios As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents usuIDGrupoUsuarios As DevExpress.XtraGrid.Columns.GridColumn
End Class

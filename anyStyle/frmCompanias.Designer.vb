<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompanias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompanias))
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.gcCompanias = New DevExpress.XtraGrid.GridControl()
        Me.grdCompanias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.comIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comCodigoCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comNombreCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repActivo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repCodigoCompania = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreCompania = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repModificar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repVisualizar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repConfigurarUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repReportes = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaCaja = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaProductos = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.rowIDCompania = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoCompania = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreCompania = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.comEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.gcCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoCompania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreCompania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOperaciones.SuspendLayout()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.gcCompanias)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'gcCompanias
        '
        Me.gcCompanias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcCompanias.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcCompanias.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcCompanias.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcCompanias.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcCompanias.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcCompanias.Location = New System.Drawing.Point(5, 5)
        Me.gcCompanias.MainView = Me.grdCompanias
        Me.gcCompanias.Name = "gcCompanias"
        Me.gcCompanias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar, Me.RepositoryItemButtonEdit1})
        Me.gcCompanias.Size = New System.Drawing.Size(304, 478)
        Me.gcCompanias.TabIndex = 0
        Me.gcCompanias.UseEmbeddedNavigator = True
        Me.gcCompanias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCompanias})
        '
        'grdCompanias
        '
        Me.grdCompanias.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdCompanias.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdCompanias.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdCompanias.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdCompanias.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdCompanias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.comIDCompania, Me.comCodigoCompania, Me.comNombreCompania, Me.comEliminar})
        Me.grdCompanias.GridControl = Me.gcCompanias
        Me.grdCompanias.Name = "grdCompanias"
        Me.grdCompanias.OptionsBehavior.Editable = False
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
        Me.comCodigoCompania.Width = 72
        '
        'comNombreCompania
        '
        Me.comNombreCompania.Caption = "COMPANIA"
        Me.comNombreCompania.FieldName = "NombreCompania"
        Me.comNombreCompania.Name = "comNombreCompania"
        Me.comNombreCompania.Visible = True
        Me.comNombreCompania.VisibleIndex = 1
        Me.comNombreCompania.Width = 202
        '
        'GrupoUsuarioCol
        '
        Me.GrupoUsuarioCol.AutoHeight = False
        Me.GrupoUsuarioCol.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GrupoUsuarioCol.Name = "GrupoUsuarioCol"
        '
        'repEliminar
        '
        Me.repEliminar.AutoHeight = False
        SerializableAppearanceObject3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        SerializableAppearanceObject3.Options.UseBackColor = True
        Me.repEliminar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "X", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.repEliminar.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.repEliminar.Name = "repEliminar"
        Me.repEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.vgrdDetalles.RecordWidth = 357
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repActivo, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repCodigoCompania, Me.repNombreCompania, Me.repEmailUsuario, Me.repModificar, Me.repVisualizar, Me.repConfigurarUsuarios, Me.repReportes, Me.repManejaCaja, Me.repManejaProductos})
        Me.vgrdDetalles.RowHeaderWidth = 102
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDCompania, Me.rowCodigoCompania, Me.rowNombreCompania})
        Me.vgrdDetalles.Size = New System.Drawing.Size(465, 478)
        Me.vgrdDetalles.TabIndex = 1
        '
        'repActivo
        '
        Me.repActivo.Appearance.Options.UseTextOptions = True
        Me.repActivo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repActivo.AutoHeight = False
        Me.repActivo.Caption = ""
        Me.repActivo.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repActivo.Name = "repActivo"
        Me.repActivo.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repActivo.ValueGrayed = False
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
        'repCodigoCompania
        '
        Me.repCodigoCompania.AutoHeight = False
        Me.repCodigoCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoCompania.Mask.EditMask = "[0-9a-zA-Z]*"
        Me.repCodigoCompania.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoCompania.Mask.ShowPlaceHolders = False
        Me.repCodigoCompania.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoCompania.MaxLength = 50
        Me.repCodigoCompania.Name = "repCodigoCompania"
        '
        'repNombreCompania
        '
        Me.repNombreCompania.AutoHeight = False
        Me.repNombreCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreCompania.Mask.EditMask = "[0-9a-zA-ZáéíóúÁÉÍÓÚ \-_#$%&]*"
        Me.repNombreCompania.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreCompania.Mask.ShowPlaceHolders = False
        Me.repNombreCompania.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreCompania.MaxLength = 50
        Me.repNombreCompania.Name = "repNombreCompania"
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
        'repModificar
        '
        Me.repModificar.AutoHeight = False
        Me.repModificar.Caption = ""
        Me.repModificar.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repModificar.Name = "repModificar"
        Me.repModificar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repModificar.ValueGrayed = False
        '
        'repVisualizar
        '
        Me.repVisualizar.AutoHeight = False
        Me.repVisualizar.Caption = ""
        Me.repVisualizar.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repVisualizar.Name = "repVisualizar"
        Me.repVisualizar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repVisualizar.ValueGrayed = False
        '
        'repConfigurarUsuarios
        '
        Me.repConfigurarUsuarios.AutoHeight = False
        Me.repConfigurarUsuarios.Caption = ""
        Me.repConfigurarUsuarios.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repConfigurarUsuarios.Name = "repConfigurarUsuarios"
        Me.repConfigurarUsuarios.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repConfigurarUsuarios.ValueGrayed = False
        '
        'repReportes
        '
        Me.repReportes.AutoHeight = False
        Me.repReportes.Caption = ""
        Me.repReportes.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repReportes.Name = "repReportes"
        Me.repReportes.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repReportes.ValueGrayed = False
        '
        'repManejaCaja
        '
        Me.repManejaCaja.AutoHeight = False
        Me.repManejaCaja.Caption = ""
        Me.repManejaCaja.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repManejaCaja.Name = "repManejaCaja"
        Me.repManejaCaja.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repManejaCaja.ValueGrayed = False
        '
        'repManejaProductos
        '
        Me.repManejaProductos.AutoHeight = False
        Me.repManejaProductos.Caption = ""
        Me.repManejaProductos.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repManejaProductos.Name = "repManejaProductos"
        Me.repManejaProductos.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repManejaProductos.ValueGrayed = False
        '
        'rowIDCompania
        '
        Me.rowIDCompania.Appearance.Options.UseTextOptions = True
        Me.rowIDCompania.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowIDCompania.Name = "rowIDCompania"
        Me.rowIDCompania.Properties.Caption = "IDCompania"
        Me.rowIDCompania.Properties.FieldName = "IDGrupo"
        Me.rowIDCompania.Visible = False
        '
        'rowCodigoCompania
        '
        Me.rowCodigoCompania.Appearance.Options.UseTextOptions = True
        Me.rowCodigoCompania.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoCompania.Height = 20
        Me.rowCodigoCompania.Name = "rowCodigoCompania"
        Me.rowCodigoCompania.Properties.Caption = "CÓDIGO"
        Me.rowCodigoCompania.Properties.FieldName = "CodigoCompania"
        Me.rowCodigoCompania.Properties.RowEdit = Me.repCodigoCompania
        '
        'rowNombreCompania
        '
        Me.rowNombreCompania.Height = 20
        Me.rowNombreCompania.Name = "rowNombreCompania"
        Me.rowNombreCompania.Properties.Caption = "COMPAÑÍA"
        Me.rowNombreCompania.Properties.FieldName = "NombreCompania"
        Me.rowNombreCompania.Properties.RowEdit = Me.repNombreCompania
        '
        'panOperaciones
        '
        Me.panOperaciones.Controls.Add(Me.btnInsertar)
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
        'comEliminar
        '
        Me.comEliminar.ColumnEdit = Me.repEliminar
        Me.comEliminar.Name = "comEliminar"
        Me.comEliminar.Width = 28
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'frmCompanias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmCompanias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "COMPAÑÍAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.gcCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoCompania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreCompania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcCompanias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCompanias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowIDCompania As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents comIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comCodigoCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoCompania As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repActivo As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cboGrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panOperaciones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnInsertar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repCodigoUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEliminar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents repCodigoCompania As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repNombreCompania As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rowNombreCompania As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repModificar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repVisualizar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repConfigurarUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repReportes As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaCaja As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaProductos As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents comNombreCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class

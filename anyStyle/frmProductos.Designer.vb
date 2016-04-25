<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductos
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.gcProductos = New DevExpress.XtraGrid.GridControl()
        Me.grdProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.proIDProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proCodigoProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proNombreProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proIndPerecedero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proIndActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repActivo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repCodigoProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreProducto = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repTelefonoProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repPerecedero = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repConfigurarUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repDireccionProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaCaja = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaProductos = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repIndPerecedero = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repDireccion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rowIDProducto = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoProducto = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreProducto = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndPerecedero = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndActivo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnPrecios = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.gcProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPerecedero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repIndPerecedero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.gcProductos)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'gcProductos
        '
        Me.gcProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcProductos.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcProductos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcProductos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcProductos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcProductos.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcProductos.Location = New System.Drawing.Point(5, 5)
        Me.gcProductos.MainView = Me.grdProductos
        Me.gcProductos.Name = "gcProductos"
        Me.gcProductos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar})
        Me.gcProductos.Size = New System.Drawing.Size(304, 478)
        Me.gcProductos.TabIndex = 0
        Me.gcProductos.UseEmbeddedNavigator = True
        Me.gcProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdProductos})
        '
        'grdProductos
        '
        Me.grdProductos.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdProductos.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdProductos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdProductos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdProductos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdProductos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.proIDProducto, Me.proIDCompania, Me.proCodigoProducto, Me.proNombreProducto, Me.proIndPerecedero, Me.proIndActivo, Me.proEliminar})
        Me.grdProductos.GridControl = Me.gcProductos
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.OptionsBehavior.Editable = False
        Me.grdProductos.OptionsView.ShowGroupPanel = False
        Me.grdProductos.OptionsView.ShowIndicator = False
        '
        'proIDProducto
        '
        Me.proIDProducto.Caption = "IDProducto"
        Me.proIDProducto.FieldName = "IDProducto"
        Me.proIDProducto.Name = "proIDProducto"
        '
        'proIDCompania
        '
        Me.proIDCompania.Caption = "IDCompania"
        Me.proIDCompania.FieldName = "IDCompania"
        Me.proIDCompania.Name = "proIDCompania"
        '
        'proCodigoProducto
        '
        Me.proCodigoProducto.Caption = "CÓDIGO"
        Me.proCodigoProducto.FieldName = "CodigoProducto"
        Me.proCodigoProducto.Name = "proCodigoProducto"
        Me.proCodigoProducto.Visible = True
        Me.proCodigoProducto.VisibleIndex = 0
        Me.proCodigoProducto.Width = 84
        '
        'proNombreProducto
        '
        Me.proNombreProducto.Caption = "NOMBRE"
        Me.proNombreProducto.FieldName = "NombreProducto"
        Me.proNombreProducto.Name = "proNombreProducto"
        Me.proNombreProducto.Visible = True
        Me.proNombreProducto.VisibleIndex = 1
        Me.proNombreProducto.Width = 218
        '
        'proIndPerecedero
        '
        Me.proIndPerecedero.Caption = "IndPerecedero"
        Me.proIndPerecedero.FieldName = "IndPerecedero"
        Me.proIndPerecedero.Name = "proIndPerecedero"
        '
        'proIndActivo
        '
        Me.proIndActivo.Caption = "Activo"
        Me.proIndActivo.FieldName = "IndActivo"
        Me.proIndActivo.Name = "proIndActivo"
        '
        'proEliminar
        '
        Me.proEliminar.ColumnEdit = Me.repEliminar
        Me.proEliminar.Name = "proEliminar"
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
        Me.vgrdDetalles.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.vgrdDetalles.Location = New System.Drawing.Point(315, 5)
        Me.vgrdDetalles.Name = "vgrdDetalles"
        Me.vgrdDetalles.OptionsView.AutoScaleBands = True
        Me.vgrdDetalles.RecordWidth = 261
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repActivo, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repCodigoProducto, Me.repNombreProducto, Me.repEmailUsuario, Me.repTelefonoProveedor, Me.repPerecedero, Me.repConfigurarUsuarios, Me.repDireccionProveedor, Me.repManejaCaja, Me.repManejaProductos, Me.repIndPerecedero, Me.repDireccion})
        Me.vgrdDetalles.RowHeaderWidth = 198
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDProducto, Me.rowCodigoProducto, Me.rowNombreProducto, Me.rowIndPerecedero, Me.rowIndActivo})
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
        'repCodigoProducto
        '
        Me.repCodigoProducto.AutoHeight = False
        Me.repCodigoProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoProducto.Mask.EditMask = "[0-9a-zA-Z]*"
        Me.repCodigoProducto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoProducto.Mask.ShowPlaceHolders = False
        Me.repCodigoProducto.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoProducto.MaxLength = 50
        Me.repCodigoProducto.Name = "repCodigoProducto"
        '
        'repNombreProducto
        '
        Me.repNombreProducto.AutoHeight = False
        Me.repNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreProducto.Mask.EditMask = "[0-9a-zA-ZáéíóúÁÉÍÓÚ \-_#$%&]*"
        Me.repNombreProducto.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreProducto.Mask.ShowPlaceHolders = False
        Me.repNombreProducto.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreProducto.MaxLength = 50
        Me.repNombreProducto.Name = "repNombreProducto"
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
        'repTelefonoProveedor
        '
        Me.repTelefonoProveedor.AutoHeight = False
        Me.repTelefonoProveedor.Caption = ""
        Me.repTelefonoProveedor.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repTelefonoProveedor.Name = "repTelefonoProveedor"
        Me.repTelefonoProveedor.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repTelefonoProveedor.ValueGrayed = False
        '
        'repPerecedero
        '
        Me.repPerecedero.AutoHeight = False
        Me.repPerecedero.Caption = ""
        Me.repPerecedero.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repPerecedero.Name = "repPerecedero"
        Me.repPerecedero.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repPerecedero.ValueGrayed = False
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
        'repDireccionProveedor
        '
        Me.repDireccionProveedor.AutoHeight = False
        Me.repDireccionProveedor.Caption = ""
        Me.repDireccionProveedor.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.repDireccionProveedor.Name = "repDireccionProveedor"
        Me.repDireccionProveedor.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repDireccionProveedor.ValueGrayed = False
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
        'repIndPerecedero
        '
        Me.repIndPerecedero.AutoHeight = False
        Me.repIndPerecedero.Name = "repIndPerecedero"
        '
        'repDireccion
        '
        Me.repDireccion.AutoHeight = False
        Me.repDireccion.Name = "repDireccion"
        '
        'rowIDProducto
        '
        Me.rowIDProducto.Name = "rowIDProducto"
        Me.rowIDProducto.Properties.Caption = "IDPRODUCTO"
        Me.rowIDProducto.Properties.FieldName = "IDProducto"
        Me.rowIDProducto.Visible = False
        '
        'rowCodigoProducto
        '
        Me.rowCodigoProducto.Appearance.Options.UseTextOptions = True
        Me.rowCodigoProducto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoProducto.Height = 20
        Me.rowCodigoProducto.Name = "rowCodigoProducto"
        Me.rowCodigoProducto.Properties.Caption = "CÓDIGO"
        Me.rowCodigoProducto.Properties.FieldName = "CodigoProducto"
        Me.rowCodigoProducto.Properties.RowEdit = Me.repCodigoProducto
        '
        'rowNombreProducto
        '
        Me.rowNombreProducto.Appearance.Options.UseTextOptions = True
        Me.rowNombreProducto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombreProducto.Height = 20
        Me.rowNombreProducto.Name = "rowNombreProducto"
        Me.rowNombreProducto.Properties.Caption = "NOMBRE"
        Me.rowNombreProducto.Properties.FieldName = "NombreProducto"
        Me.rowNombreProducto.Properties.RowEdit = Me.repNombreProducto
        '
        'rowIndPerecedero
        '
        Me.rowIndPerecedero.Height = 20
        Me.rowIndPerecedero.Name = "rowIndPerecedero"
        Me.rowIndPerecedero.Properties.Caption = "PERECEDERO"
        Me.rowIndPerecedero.Properties.FieldName = "IndPerecedero"
        Me.rowIndPerecedero.Properties.RowEdit = Me.repPerecedero
        '
        'rowIndActivo
        '
        Me.rowIndActivo.Appearance.Options.UseTextOptions = True
        Me.rowIndActivo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rowIndActivo.Height = 20
        Me.rowIndActivo.Name = "rowIndActivo"
        Me.rowIndActivo.Properties.Caption = "ACTIVO"
        Me.rowIndActivo.Properties.FieldName = "IndActivo"
        Me.rowIndActivo.Properties.RowEdit = Me.repActivo
        '
        'panOperaciones
        '
        Me.panOperaciones.Controls.Add(Me.btnPrecios)
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
        'btnPrecios
        '
        Me.btnPrecios.AllowFocus = False
        Me.btnPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrecios.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrecios.Appearance.Options.UseBackColor = True
        Me.btnPrecios.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnPrecios.Image = CType(resources.GetObject("btnPrecios.Image"), System.Drawing.Image)
        Me.btnPrecios.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnPrecios.Location = New System.Drawing.Point(5, 429)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(69, 61)
        Me.btnPrecios.TabIndex = 1
        Me.btnPrecios.Text = "Precios"
        Me.btnPrecios.Visible = False
        '
        'btnInsertar
        '
        Me.btnInsertar.AllowFocus = False
        Me.btnInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsertar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnInsertar.Appearance.Options.UseBackColor = True
        Me.btnInsertar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnInsertar.Image = CType(resources.GetObject("btnInsertar.Image"), System.Drawing.Image)
        Me.btnInsertar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnInsertar.Location = New System.Drawing.Point(5, 226)
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
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "PRODUCTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.gcProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPerecedero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repIndPerecedero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents proIDProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proNombreProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proIndPerecedero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoProducto As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreProducto As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndActivo As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents repCodigoProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repNombreProducto As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proIndActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowIndPerecedero As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repTelefonoProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repPerecedero As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repConfigurarUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repDireccionProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaCaja As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaProductos As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents proCodigoProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repIndPerecedero As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repDireccion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrecios As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rowIDProducto As DevExpress.XtraVerticalGrid.Rows.EditorRow
End Class

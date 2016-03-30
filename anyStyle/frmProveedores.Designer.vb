<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.gcProveedores = New DevExpress.XtraGrid.GridControl()
        Me.grdProveedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.proIDProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proCodigoProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proNombreProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proTelefonoProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proDireccionProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proIndActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repActivo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repCodigoProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repTelefonoProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repVisualizar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repConfigurarUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repDireccionProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaCaja = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaProductos = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repTelefono = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repDireccion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.rowIDProveedor = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoProveedor = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreProveedor = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTelefonoProveedor = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDireccionProveedor = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndActivo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.proIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnProveedorProductos = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.gcProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlContenedor.Controls.Add(Me.gcProveedores)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'gcProveedores
        '
        Me.gcProveedores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcProveedores.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcProveedores.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcProveedores.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcProveedores.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcProveedores.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcProveedores.Location = New System.Drawing.Point(5, 5)
        Me.gcProveedores.MainView = Me.grdProveedores
        Me.gcProveedores.Name = "gcProveedores"
        Me.gcProveedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar})
        Me.gcProveedores.Size = New System.Drawing.Size(304, 478)
        Me.gcProveedores.TabIndex = 0
        Me.gcProveedores.UseEmbeddedNavigator = True
        Me.gcProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdProveedores})
        '
        'grdProveedores
        '
        Me.grdProveedores.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdProveedores.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdProveedores.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdProveedores.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdProveedores.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdProveedores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.proIDProveedor, Me.proIDCompania, Me.proCodigoProveedor, Me.proNombreProveedor, Me.proTelefonoProveedor, Me.proDireccionProveedor, Me.proIndActivo, Me.proEliminar})
        Me.grdProveedores.GridControl = Me.gcProveedores
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.OptionsBehavior.Editable = False
        Me.grdProveedores.OptionsView.ShowGroupPanel = False
        Me.grdProveedores.OptionsView.ShowIndicator = False
        '
        'proIDProveedor
        '
        Me.proIDProveedor.Caption = "IDProveedor"
        Me.proIDProveedor.FieldName = "IDProveedor"
        Me.proIDProveedor.Name = "proIDProveedor"
        '
        'proCodigoProveedor
        '
        Me.proCodigoProveedor.Caption = "DOCUMENTO"
        Me.proCodigoProveedor.FieldName = "CodigoProveedor"
        Me.proCodigoProveedor.Name = "proCodigoProveedor"
        Me.proCodigoProveedor.Visible = True
        Me.proCodigoProveedor.VisibleIndex = 0
        Me.proCodigoProveedor.Width = 84
        '
        'proNombreProveedor
        '
        Me.proNombreProveedor.Caption = "NOMBRE"
        Me.proNombreProveedor.FieldName = "NombreProveedor"
        Me.proNombreProveedor.Name = "proNombreProveedor"
        Me.proNombreProveedor.Visible = True
        Me.proNombreProveedor.VisibleIndex = 1
        Me.proNombreProveedor.Width = 218
        '
        'proTelefonoProveedor
        '
        Me.proTelefonoProveedor.Caption = "Telefono"
        Me.proTelefonoProveedor.FieldName = "TelefonoProveedor"
        Me.proTelefonoProveedor.Name = "proTelefonoProveedor"
        '
        'proDireccionProveedor
        '
        Me.proDireccionProveedor.Caption = "Direccion"
        Me.proDireccionProveedor.FieldName = "DireccionProveedor"
        Me.proDireccionProveedor.Name = "proDireccionProveedor"
        '
        'proIndActivo
        '
        Me.proIndActivo.Caption = "Activo"
        Me.proIndActivo.FieldName = "IndActivo"
        Me.proIndActivo.Name = "proIndActivo"
        '
        'proEliminar
        '
        Me.proEliminar.Name = "proEliminar"
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
        SerializableAppearanceObject2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        SerializableAppearanceObject2.Options.UseBackColor = True
        Me.repEliminar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "X", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
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
        Me.vgrdDetalles.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.vgrdDetalles.Location = New System.Drawing.Point(315, 5)
        Me.vgrdDetalles.Name = "vgrdDetalles"
        Me.vgrdDetalles.OptionsBehavior.Editable = False
        Me.vgrdDetalles.OptionsView.AutoScaleBands = True
        Me.vgrdDetalles.RecordWidth = 261
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repActivo, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repCodigoProveedor, Me.repNombreProveedor, Me.repEmailUsuario, Me.repTelefonoProveedor, Me.repVisualizar, Me.repConfigurarUsuarios, Me.repDireccionProveedor, Me.repManejaCaja, Me.repManejaProductos, Me.repTelefono, Me.repDireccion})
        Me.vgrdDetalles.RowHeaderWidth = 198
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDProveedor, Me.rowCodigoProveedor, Me.rowNombreProveedor, Me.rowTelefonoProveedor, Me.rowDireccionProveedor, Me.rowIndActivo})
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
        'repCodigoProveedor
        '
        Me.repCodigoProveedor.AutoHeight = False
        Me.repCodigoProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoProveedor.Mask.EditMask = "[0-9a-zA-Z]*"
        Me.repCodigoProveedor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoProveedor.Mask.ShowPlaceHolders = False
        Me.repCodigoProveedor.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoProveedor.MaxLength = 50
        Me.repCodigoProveedor.Name = "repCodigoProveedor"
        '
        'repNombreProveedor
        '
        Me.repNombreProveedor.AutoHeight = False
        Me.repNombreProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreProveedor.Mask.EditMask = "[0-9a-zA-ZáéíóúÁÉÍÓÚ \-_#$%&]*"
        Me.repNombreProveedor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreProveedor.Mask.ShowPlaceHolders = False
        Me.repNombreProveedor.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreProveedor.MaxLength = 50
        Me.repNombreProveedor.Name = "repNombreProveedor"
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
        'repTelefono
        '
        Me.repTelefono.AutoHeight = False
        Me.repTelefono.Name = "repTelefono"
        '
        'repDireccion
        '
        Me.repDireccion.AutoHeight = False
        Me.repDireccion.Name = "repDireccion"
        '
        'rowIDProveedor
        '
        Me.rowIDProveedor.Appearance.Options.UseTextOptions = True
        Me.rowIDProveedor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowIDProveedor.Name = "rowIDProveedor"
        Me.rowIDProveedor.Properties.Caption = "IDPROVEEDOR"
        Me.rowIDProveedor.Properties.FieldName = "IDProveedor"
        Me.rowIDProveedor.Visible = False
        '
        'rowCodigoProveedor
        '
        Me.rowCodigoProveedor.Appearance.Options.UseTextOptions = True
        Me.rowCodigoProveedor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoProveedor.Height = 20
        Me.rowCodigoProveedor.Name = "rowCodigoProveedor"
        Me.rowCodigoProveedor.Properties.Caption = "CÓDIGO"
        Me.rowCodigoProveedor.Properties.FieldName = "CodigoProveedor"
        Me.rowCodigoProveedor.Properties.RowEdit = Me.repCodigoProveedor
        '
        'rowNombreProveedor
        '
        Me.rowNombreProveedor.Appearance.Options.UseTextOptions = True
        Me.rowNombreProveedor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombreProveedor.Height = 20
        Me.rowNombreProveedor.Name = "rowNombreProveedor"
        Me.rowNombreProveedor.Properties.Caption = "NOMBRE"
        Me.rowNombreProveedor.Properties.FieldName = "NombreProveedor"
        Me.rowNombreProveedor.Properties.RowEdit = Me.repNombreProveedor
        '
        'rowTelefonoProveedor
        '
        Me.rowTelefonoProveedor.Height = 20
        Me.rowTelefonoProveedor.Name = "rowTelefonoProveedor"
        Me.rowTelefonoProveedor.Properties.Caption = "TELÉFONO"
        Me.rowTelefonoProveedor.Properties.FieldName = "TelefonoProveedor"
        Me.rowTelefonoProveedor.Properties.RowEdit = Me.repTelefono
        '
        'rowDireccionProveedor
        '
        Me.rowDireccionProveedor.Height = 20
        Me.rowDireccionProveedor.Name = "rowDireccionProveedor"
        Me.rowDireccionProveedor.Properties.Caption = "DIRECCIÓN"
        Me.rowDireccionProveedor.Properties.FieldName = "DireccionProveedor"
        Me.rowDireccionProveedor.Properties.RowEdit = Me.repDireccion
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
        Me.panOperaciones.Controls.Add(Me.btnProveedorProductos)
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
        'proIDCompania
        '
        Me.proIDCompania.Caption = "IDCompania"
        Me.proIDCompania.FieldName = "IDCompania"
        Me.proIDCompania.Name = "proIDCompania"
        '
        'btnProveedorProductos
        '
        Me.btnProveedorProductos.AllowFocus = False
        Me.btnProveedorProductos.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProveedorProductos.Appearance.Options.UseBackColor = True
        Me.btnProveedorProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnProveedorProductos.Image = CType(resources.GetObject("btnProveedorProductos.Image"), System.Drawing.Image)
        Me.btnProveedorProductos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnProveedorProductos.Location = New System.Drawing.Point(5, 282)
        Me.btnProveedorProductos.Name = "btnProveedorProductos"
        Me.btnProveedorProductos.Size = New System.Drawing.Size(69, 61)
        Me.btnProveedorProductos.TabIndex = 1
        Me.btnProveedorProductos.Text = "Productos"
        Me.btnProveedorProductos.Visible = False
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "PROVEEDORES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.gcProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdProveedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowIDProveedor As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents proIDProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proNombreProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proTelefonoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoProveedor As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreProveedor As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents repCodigoProveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repNombreProveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proDireccionProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proIndActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowTelefonoProveedor As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDireccionProveedor As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repTelefonoProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repVisualizar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repConfigurarUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repDireccionProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaCaja As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaProductos As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents proCodigoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTelefono As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repDireccion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents proIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProveedorProductos As DevExpress.XtraEditors.SimpleButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.gcClientes = New DevExpress.XtraGrid.GridControl()
        Me.grdClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cliIDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliNombreCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliTelefonoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliDireccionCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliEmailCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliFechaCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cliIndActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.proEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repActivo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repCodigoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreCliente = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repTelefonoProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repVisualizar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repConfigurarUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repDireccionProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaCaja = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaProductos = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repTelefonoCliente = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repDireccionCliente = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailCliente = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repFechaCliente = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rowIDCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTelefonoCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDireccionCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEmailCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFechaCliente = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndActivo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnProveedorProductos = New DevExpress.XtraEditors.SimpleButton()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.gcClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTelefonoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDireccionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repFechaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repFechaCliente.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.gcClientes)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'gcClientes
        '
        Me.gcClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcClientes.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcClientes.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcClientes.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcClientes.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcClientes.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcClientes.Location = New System.Drawing.Point(5, 5)
        Me.gcClientes.MainView = Me.grdClientes
        Me.gcClientes.Name = "gcClientes"
        Me.gcClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar})
        Me.gcClientes.Size = New System.Drawing.Size(304, 478)
        Me.gcClientes.TabIndex = 0
        Me.gcClientes.UseEmbeddedNavigator = True
        Me.gcClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdClientes})
        '
        'grdClientes
        '
        Me.grdClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdClientes.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdClientes.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdClientes.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdClientes.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdClientes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cliIDCliente, Me.cliIDCompania, Me.cliCodigoCliente, Me.cliNombreCliente, Me.cliTelefonoCliente, Me.cliDireccionCliente, Me.cliEmailCliente, Me.cliFechaCliente, Me.cliIndActivo, Me.proEliminar})
        Me.grdClientes.GridControl = Me.gcClientes
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.OptionsBehavior.Editable = False
        Me.grdClientes.OptionsView.ShowGroupPanel = False
        Me.grdClientes.OptionsView.ShowIndicator = False
        '
        'cliIDCliente
        '
        Me.cliIDCliente.Caption = "IDCliente"
        Me.cliIDCliente.FieldName = "IDCliente"
        Me.cliIDCliente.Name = "cliIDCliente"
        '
        'cliIDCompania
        '
        Me.cliIDCompania.Caption = "IDCompania"
        Me.cliIDCompania.FieldName = "IDCompania"
        Me.cliIDCompania.Name = "cliIDCompania"
        '
        'cliCodigoCliente
        '
        Me.cliCodigoCliente.Caption = "DOCUMENTO"
        Me.cliCodigoCliente.FieldName = "CodigoCliente"
        Me.cliCodigoCliente.Name = "cliCodigoCliente"
        Me.cliCodigoCliente.Visible = True
        Me.cliCodigoCliente.VisibleIndex = 0
        Me.cliCodigoCliente.Width = 92
        '
        'cliNombreCliente
        '
        Me.cliNombreCliente.Caption = "NOMBRE"
        Me.cliNombreCliente.FieldName = "NombreCliente"
        Me.cliNombreCliente.Name = "cliNombreCliente"
        Me.cliNombreCliente.Visible = True
        Me.cliNombreCliente.VisibleIndex = 1
        Me.cliNombreCliente.Width = 210
        '
        'cliTelefonoCliente
        '
        Me.cliTelefonoCliente.Caption = "TELÉFONO"
        Me.cliTelefonoCliente.FieldName = "TelefonoCliente"
        Me.cliTelefonoCliente.Name = "cliTelefonoCliente"
        '
        'cliDireccionCliente
        '
        Me.cliDireccionCliente.Caption = "DIRECCIÓN"
        Me.cliDireccionCliente.FieldName = "DireccionCliente"
        Me.cliDireccionCliente.Name = "cliDireccionCliente"
        '
        'cliEmailCliente
        '
        Me.cliEmailCliente.Caption = "EMAIL"
        Me.cliEmailCliente.FieldName = "EmailCliente"
        Me.cliEmailCliente.Name = "cliEmailCliente"
        '
        'cliFechaCliente
        '
        Me.cliFechaCliente.Caption = "FECHA NACIMIENTO"
        Me.cliFechaCliente.FieldName = "FechaCliente"
        Me.cliFechaCliente.Name = "cliFechaCliente"
        '
        'cliIndActivo
        '
        Me.cliIndActivo.Caption = "Activo"
        Me.cliIndActivo.FieldName = "IndActivo"
        Me.cliIndActivo.Name = "cliIndActivo"
        '
        'proEliminar
        '
        Me.proEliminar.ColumnEdit = Me.repEliminar
        Me.proEliminar.Name = "proEliminar"
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
        Me.vgrdDetalles.OptionsBehavior.Editable = False
        Me.vgrdDetalles.OptionsView.AutoScaleBands = True
        Me.vgrdDetalles.RecordWidth = 261
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repActivo, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repCodigoCliente, Me.repNombreCliente, Me.repEmailUsuario, Me.repTelefonoProveedor, Me.repVisualizar, Me.repConfigurarUsuarios, Me.repDireccionProveedor, Me.repManejaCaja, Me.repManejaProductos, Me.repTelefonoCliente, Me.repDireccionCliente, Me.repEmailCliente, Me.repFechaCliente})
        Me.vgrdDetalles.RowHeaderWidth = 198
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDCliente, Me.rowCodigoCliente, Me.rowNombreCliente, Me.rowTelefonoCliente, Me.rowDireccionCliente, Me.rowEmailCliente, Me.rowFechaCliente, Me.rowIndActivo})
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
        'repCodigoCliente
        '
        Me.repCodigoCliente.AutoHeight = False
        Me.repCodigoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoCliente.Mask.EditMask = "[0-9a-zA-Z]*"
        Me.repCodigoCliente.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoCliente.Mask.ShowPlaceHolders = False
        Me.repCodigoCliente.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoCliente.MaxLength = 50
        Me.repCodigoCliente.Name = "repCodigoCliente"
        '
        'repNombreCliente
        '
        Me.repNombreCliente.AutoHeight = False
        Me.repNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreCliente.Mask.EditMask = "[0-9a-zA-ZáéíóúÁÉÍÓÚ \-_#$%&]*"
        Me.repNombreCliente.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreCliente.Mask.ShowPlaceHolders = False
        Me.repNombreCliente.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreCliente.MaxLength = 50
        Me.repNombreCliente.Name = "repNombreCliente"
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
        'repTelefonoCliente
        '
        Me.repTelefonoCliente.AutoHeight = False
        Me.repTelefonoCliente.Name = "repTelefonoCliente"
        '
        'repDireccionCliente
        '
        Me.repDireccionCliente.AutoHeight = False
        Me.repDireccionCliente.Name = "repDireccionCliente"
        '
        'repEmailCliente
        '
        Me.repEmailCliente.AutoHeight = False
        Me.repEmailCliente.Name = "repEmailCliente"
        '
        'repFechaCliente
        '
        Me.repFechaCliente.AutoHeight = False
        Me.repFechaCliente.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repFechaCliente.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repFechaCliente.Name = "repFechaCliente"
        '
        'rowIDCliente
        '
        Me.rowIDCliente.Appearance.Options.UseTextOptions = True
        Me.rowIDCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowIDCliente.Name = "rowIDCliente"
        Me.rowIDCliente.Properties.Caption = "IDCLIENTE"
        Me.rowIDCliente.Properties.FieldName = "IDCliente"
        Me.rowIDCliente.Visible = False
        '
        'rowCodigoCliente
        '
        Me.rowCodigoCliente.Appearance.Options.UseTextOptions = True
        Me.rowCodigoCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoCliente.Height = 20
        Me.rowCodigoCliente.Name = "rowCodigoCliente"
        Me.rowCodigoCliente.Properties.Caption = "CÓDIGO"
        Me.rowCodigoCliente.Properties.FieldName = "CodigoCliente"
        Me.rowCodigoCliente.Properties.RowEdit = Me.repCodigoCliente
        '
        'rowNombreCliente
        '
        Me.rowNombreCliente.Appearance.Options.UseTextOptions = True
        Me.rowNombreCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombreCliente.Height = 20
        Me.rowNombreCliente.Name = "rowNombreCliente"
        Me.rowNombreCliente.Properties.Caption = "NOMBRE"
        Me.rowNombreCliente.Properties.FieldName = "NombreCliente"
        Me.rowNombreCliente.Properties.RowEdit = Me.repNombreCliente
        '
        'rowTelefonoCliente
        '
        Me.rowTelefonoCliente.Height = 20
        Me.rowTelefonoCliente.Name = "rowTelefonoCliente"
        Me.rowTelefonoCliente.Properties.Caption = "TELÉFONO"
        Me.rowTelefonoCliente.Properties.FieldName = "TelefonoCliente"
        Me.rowTelefonoCliente.Properties.RowEdit = Me.repTelefonoCliente
        '
        'rowDireccionCliente
        '
        Me.rowDireccionCliente.Height = 20
        Me.rowDireccionCliente.Name = "rowDireccionCliente"
        Me.rowDireccionCliente.Properties.Caption = "DIRECCIÓN"
        Me.rowDireccionCliente.Properties.FieldName = "DireccionCliente"
        Me.rowDireccionCliente.Properties.RowEdit = Me.repDireccionCliente
        '
        'rowEmailCliente
        '
        Me.rowEmailCliente.Name = "rowEmailCliente"
        Me.rowEmailCliente.Properties.Caption = "EMAIL"
        Me.rowEmailCliente.Properties.FieldName = "EmailCliente"
        Me.rowEmailCliente.Properties.RowEdit = Me.repEmailCliente
        '
        'rowFechaCliente
        '
        Me.rowFechaCliente.Name = "rowFechaCliente"
        Me.rowFechaCliente.Properties.Caption = "FECHA NACIMIENTO"
        Me.rowFechaCliente.Properties.FieldName = "FechaCliente"
        Me.rowFechaCliente.Properties.RowEdit = Me.repFechaCliente
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
        'btnProveedorProductos
        '
        Me.btnProveedorProductos.AllowFocus = False
        Me.btnProveedorProductos.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProveedorProductos.Appearance.Options.UseBackColor = True
        Me.btnProveedorProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnProveedorProductos.Image = CType(resources.GetObject("btnProveedorProductos.Image"), System.Drawing.Image)
        Me.btnProveedorProductos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnProveedorProductos.Location = New System.Drawing.Point(5, 429)
        Me.btnProveedorProductos.Name = "btnProveedorProductos"
        Me.btnProveedorProductos.Size = New System.Drawing.Size(69, 61)
        Me.btnProveedorProductos.TabIndex = 1
        Me.btnProveedorProductos.Text = "Productos"
        Me.btnProveedorProductos.Visible = False
        '
        'btnInsertar
        '
        Me.btnInsertar.AllowFocus = False
        Me.btnInsertar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "CLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.gcClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefonoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccionProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTelefonoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDireccionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repFechaCliente.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repFechaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowIDCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents cliIDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cliNombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cliTelefonoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents repCodigoCliente As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repNombreCliente As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cliDireccionCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cliIndActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowTelefonoCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDireccionCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repTelefonoProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repVisualizar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repConfigurarUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repDireccionProveedor As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaCaja As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaProductos As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cliCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents proEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTelefonoCliente As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repDireccionCliente As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cliIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnProveedorProductos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repEmailCliente As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repFechaCliente As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rowEmailCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFechaCliente As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents cliEmailCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cliFechaCliente As DevExpress.XtraGrid.Columns.GridColumn
End Class

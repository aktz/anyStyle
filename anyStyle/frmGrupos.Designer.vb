<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupos))
        Me.pnlContenedor = New DevExpress.XtraEditors.PanelControl()
        Me.gcGrupos = New DevExpress.XtraGrid.GridControl()
        Me.grdGrupos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grpIDGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpCodigoGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpNombreGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndVisualizar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndModificar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndConfigurarUsuarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndReportes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpManejaCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpIndManejaProductos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grpEliminar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repEliminar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.vgrdDetalles = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.repActivo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboGrupoUsuarioCol = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.repCodigoUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repCodigoGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repNombreGrupo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repEmailUsuario = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.repModificar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repVisualizar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repConfigurarUsuarios = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repReportes = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaCaja = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.repManejaProductos = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.rowIDGrupo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowCodigoGrupo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNombreGrupo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndActivo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndModificar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndConfigurarUsuarios = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndReportes = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndManejaCaja = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIndManejaProductos = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panOperaciones = New DevExpress.XtraEditors.PanelControl()
        Me.btnInsertar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnModificar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.gcGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCodigoGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNombreGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.gcGrupos)
        Me.pnlContenedor.Controls.Add(Me.btnAgregar)
        Me.pnlContenedor.Controls.Add(Me.vgrdDetalles)
        Me.pnlContenedor.Location = New System.Drawing.Point(3, 4)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(785, 488)
        Me.pnlContenedor.TabIndex = 0
        '
        'gcGrupos
        '
        Me.gcGrupos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gcGrupos.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcGrupos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcGrupos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcGrupos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcGrupos.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcGrupos.Location = New System.Drawing.Point(5, 5)
        Me.gcGrupos.MainView = Me.grdGrupos
        Me.gcGrupos.Name = "gcGrupos"
        Me.gcGrupos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GrupoUsuarioCol, Me.repEliminar})
        Me.gcGrupos.Size = New System.Drawing.Size(304, 478)
        Me.gcGrupos.TabIndex = 0
        Me.gcGrupos.UseEmbeddedNavigator = True
        Me.gcGrupos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGrupos})
        '
        'grdGrupos
        '
        Me.grdGrupos.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent
        Me.grdGrupos.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.grdGrupos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grdGrupos.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdGrupos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdGrupos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grpIDGrupo, Me.grpCodigoGrupo, Me.grpNombreGrupo, Me.grpIndActivo, Me.grpIndVisualizar, Me.grpIndModificar, Me.grpIndConfigurarUsuarios, Me.grpIndReportes, Me.grpManejaCaja, Me.grpIndManejaProductos, Me.grpEliminar})
        Me.grdGrupos.GridControl = Me.gcGrupos
        Me.grdGrupos.Name = "grdGrupos"
        Me.grdGrupos.OptionsBehavior.Editable = False
        Me.grdGrupos.OptionsView.ShowGroupPanel = False
        Me.grdGrupos.OptionsView.ShowIndicator = False
        '
        'grpIDGrupo
        '
        Me.grpIDGrupo.Caption = "IDGrupo"
        Me.grpIDGrupo.FieldName = "IDGrupo"
        Me.grpIDGrupo.Name = "grpIDGrupo"
        '
        'grpCodigoGrupo
        '
        Me.grpCodigoGrupo.Caption = "CÓDIGO"
        Me.grpCodigoGrupo.FieldName = "CodigoGrupo"
        Me.grpCodigoGrupo.Name = "grpCodigoGrupo"
        Me.grpCodigoGrupo.Visible = True
        Me.grpCodigoGrupo.VisibleIndex = 0
        Me.grpCodigoGrupo.Width = 67
        '
        'grpNombreGrupo
        '
        Me.grpNombreGrupo.Caption = "NOMBRE"
        Me.grpNombreGrupo.FieldName = "NombreGrupo"
        Me.grpNombreGrupo.Name = "grpNombreGrupo"
        Me.grpNombreGrupo.Visible = True
        Me.grpNombreGrupo.VisibleIndex = 1
        Me.grpNombreGrupo.Width = 214
        '
        'grpIndActivo
        '
        Me.grpIndActivo.Caption = "Activo"
        Me.grpIndActivo.FieldName = "IndActivo"
        Me.grpIndActivo.Name = "grpIndActivo"
        '
        'grpIndVisualizar
        '
        Me.grpIndVisualizar.Caption = "IndVisualizar"
        Me.grpIndVisualizar.FieldName = "IndVisualizar"
        Me.grpIndVisualizar.Name = "grpIndVisualizar"
        '
        'grpIndModificar
        '
        Me.grpIndModificar.Caption = "IndModificar"
        Me.grpIndModificar.FieldName = "IndModificar"
        Me.grpIndModificar.Name = "grpIndModificar"
        '
        'grpIndConfigurarUsuarios
        '
        Me.grpIndConfigurarUsuarios.Caption = "CONFIGURAR USUARIOS"
        Me.grpIndConfigurarUsuarios.FieldName = "IndConfigurarUsuarios"
        Me.grpIndConfigurarUsuarios.Name = "grpIndConfigurarUsuarios"
        '
        'grpIndReportes
        '
        Me.grpIndReportes.Caption = "IndReportes"
        Me.grpIndReportes.FieldName = "IndReportes"
        Me.grpIndReportes.Name = "grpIndReportes"
        '
        'grpManejaCaja
        '
        Me.grpManejaCaja.Caption = "IndManejaCaja"
        Me.grpManejaCaja.FieldName = "IndManejaCaja"
        Me.grpManejaCaja.Name = "grpManejaCaja"
        '
        'grpIndManejaProductos
        '
        Me.grpIndManejaProductos.Caption = "IndManejaProductos"
        Me.grpIndManejaProductos.FieldName = "IndManejaProductos"
        Me.grpIndManejaProductos.Name = "grpIndManejaProductos"
        '
        'grpEliminar
        '
        Me.grpEliminar.ColumnEdit = Me.repEliminar
        Me.grpEliminar.Name = "grpEliminar"
        Me.grpEliminar.Width = 21
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
        Me.vgrdDetalles.Location = New System.Drawing.Point(315, 5)
        Me.vgrdDetalles.Name = "vgrdDetalles"
        Me.vgrdDetalles.OptionsBehavior.Editable = False
        Me.vgrdDetalles.OptionsView.AutoScaleBands = True
        Me.vgrdDetalles.RecordWidth = 261
        Me.vgrdDetalles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repActivo, Me.cboGrupoUsuarioCol, Me.repCodigoUsuario, Me.repCodigoGrupo, Me.repNombreGrupo, Me.repEmailUsuario, Me.repModificar, Me.repVisualizar, Me.repConfigurarUsuarios, Me.repReportes, Me.repManejaCaja, Me.repManejaProductos})
        Me.vgrdDetalles.RowHeaderWidth = 198
        Me.vgrdDetalles.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIDGrupo, Me.rowCodigoGrupo, Me.rowNombreGrupo, Me.rowIndActivo, Me.rowIndModificar, Me.rowIndConfigurarUsuarios, Me.rowIndReportes, Me.rowIndManejaCaja, Me.rowIndManejaProductos})
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
        'repCodigoGrupo
        '
        Me.repCodigoGrupo.AutoHeight = False
        Me.repCodigoGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repCodigoGrupo.Mask.EditMask = "[0-9a-zA-Z]*"
        Me.repCodigoGrupo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repCodigoGrupo.Mask.ShowPlaceHolders = False
        Me.repCodigoGrupo.Mask.UseMaskAsDisplayFormat = True
        Me.repCodigoGrupo.MaxLength = 50
        Me.repCodigoGrupo.Name = "repCodigoGrupo"
        '
        'repNombreGrupo
        '
        Me.repNombreGrupo.AutoHeight = False
        Me.repNombreGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.repNombreGrupo.Mask.EditMask = "[0-9a-zA-ZáéíóúÁÉÍÓÚ \-_#$%&]*"
        Me.repNombreGrupo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.repNombreGrupo.Mask.ShowPlaceHolders = False
        Me.repNombreGrupo.Mask.UseMaskAsDisplayFormat = True
        Me.repNombreGrupo.MaxLength = 50
        Me.repNombreGrupo.Name = "repNombreGrupo"
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
        'rowIDGrupo
        '
        Me.rowIDGrupo.Appearance.Options.UseTextOptions = True
        Me.rowIDGrupo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowIDGrupo.Name = "rowIDGrupo"
        Me.rowIDGrupo.Properties.Caption = "IDGRUPO"
        Me.rowIDGrupo.Properties.FieldName = "IDGrupo"
        Me.rowIDGrupo.Visible = False
        '
        'rowCodigoGrupo
        '
        Me.rowCodigoGrupo.Appearance.Options.UseTextOptions = True
        Me.rowCodigoGrupo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowCodigoGrupo.Height = 20
        Me.rowCodigoGrupo.Name = "rowCodigoGrupo"
        Me.rowCodigoGrupo.Properties.Caption = "CÓDIGO"
        Me.rowCodigoGrupo.Properties.FieldName = "CodigoGrupo"
        Me.rowCodigoGrupo.Properties.RowEdit = Me.repCodigoGrupo
        '
        'rowNombreGrupo
        '
        Me.rowNombreGrupo.Appearance.Options.UseTextOptions = True
        Me.rowNombreGrupo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.rowNombreGrupo.Height = 20
        Me.rowNombreGrupo.Name = "rowNombreGrupo"
        Me.rowNombreGrupo.Properties.Caption = "NOMBRE"
        Me.rowNombreGrupo.Properties.FieldName = "NombreGrupo"
        Me.rowNombreGrupo.Properties.RowEdit = Me.repNombreGrupo
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
        'rowIndModificar
        '
        Me.rowIndModificar.Height = 20
        Me.rowIndModificar.Name = "rowIndModificar"
        Me.rowIndModificar.Properties.Caption = "PUEDE MODIFICAR"
        Me.rowIndModificar.Properties.FieldName = "IndModificar"
        Me.rowIndModificar.Properties.RowEdit = Me.repModificar
        '
        'rowIndConfigurarUsuarios
        '
        Me.rowIndConfigurarUsuarios.Height = 20
        Me.rowIndConfigurarUsuarios.Name = "rowIndConfigurarUsuarios"
        Me.rowIndConfigurarUsuarios.Properties.Caption = "PUEDE CONFIGURAR USUARIOS"
        Me.rowIndConfigurarUsuarios.Properties.FieldName = "IndConfigurarUsuarios"
        Me.rowIndConfigurarUsuarios.Properties.RowEdit = Me.repConfigurarUsuarios
        '
        'rowIndReportes
        '
        Me.rowIndReportes.Height = 20
        Me.rowIndReportes.Name = "rowIndReportes"
        Me.rowIndReportes.Properties.Caption = "PUEDE GENERAR REPORTES"
        Me.rowIndReportes.Properties.FieldName = "IndReportes"
        Me.rowIndReportes.Properties.RowEdit = Me.repReportes
        '
        'rowIndManejaCaja
        '
        Me.rowIndManejaCaja.Height = 20
        Me.rowIndManejaCaja.Name = "rowIndManejaCaja"
        Me.rowIndManejaCaja.Properties.Caption = "PUEDE MANEJAR CAJA"
        Me.rowIndManejaCaja.Properties.FieldName = "IndManejaCaja"
        Me.rowIndManejaCaja.Properties.RowEdit = Me.repManejaCaja
        '
        'rowIndManejaProductos
        '
        Me.rowIndManejaProductos.Height = 20
        Me.rowIndManejaProductos.Name = "rowIndManejaProductos"
        Me.rowIndManejaProductos.Properties.Caption = "PUEDE MANEJAR PRODUCTOS"
        Me.rowIndManejaProductos.Properties.FieldName = "IndManejaProductos"
        Me.rowIndManejaProductos.Properties.RowEdit = Me.repManejaProductos
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
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 495)
        Me.Controls.Add(Me.panOperaciones)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Name = "frmGrupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "MaestroDetalle"
        Me.Text = "GRUPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.gcGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vgrdDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupoUsuarioCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCodigoGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNombreGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repEmailUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repConfigurarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repManejaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlContenedor As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcGrupos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGrupos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents vgrdDetalles As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowIDGrupo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents grpIDGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpCodigoGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpNombreGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpIndActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GrupoUsuarioCol As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rowCodigoGrupo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNombreGrupo As DevExpress.XtraVerticalGrid.Rows.EditorRow
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
    Friend WithEvents grpEliminar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repEliminar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents repCodigoGrupo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repNombreGrupo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents repEmailUsuario As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents grpIndVisualizar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpIndModificar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpIndConfigurarUsuarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpIndReportes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpManejaCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpIndManejaProductos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rowIndModificar As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndConfigurarUsuarios As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndReportes As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndManejaCaja As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIndManejaProductos As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents repModificar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repVisualizar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repConfigurarUsuarios As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repReportes As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaCaja As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents repManejaProductos As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class

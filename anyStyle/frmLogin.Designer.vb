<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gcLoginCompanias = New DevExpress.XtraGrid.GridControl()
        Me.grdLoginCompanias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.comIDCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comCodigoCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.comNombreCompania = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcLoginCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLoginCompanias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl1.Controls.Add(Me.gcLoginCompanias)
        Me.PanelControl1.Controls.Add(Me.btnIngresar)
        Me.PanelControl1.Controls.Add(Me.txtClave)
        Me.PanelControl1.Controls.Add(Me.txtUsuario)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Location = New System.Drawing.Point(25, 25)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(434, 347)
        Me.PanelControl1.TabIndex = 0
        '
        'gcLoginCompanias
        '
        Me.gcLoginCompanias.Location = New System.Drawing.Point(22, 140)
        Me.gcLoginCompanias.MainView = Me.grdLoginCompanias
        Me.gcLoginCompanias.Name = "gcLoginCompanias"
        Me.gcLoginCompanias.Size = New System.Drawing.Size(389, 171)
        Me.gcLoginCompanias.TabIndex = 2
        Me.gcLoginCompanias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdLoginCompanias})
        '
        'grdLoginCompanias
        '
        Me.grdLoginCompanias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.comIDCompania, Me.comCodigoCompania, Me.comNombreCompania})
        Me.grdLoginCompanias.GridControl = Me.gcLoginCompanias
        Me.grdLoginCompanias.Name = "grdLoginCompanias"
        Me.grdLoginCompanias.OptionsBehavior.Editable = False
        Me.grdLoginCompanias.OptionsView.ShowGroupPanel = False
        Me.grdLoginCompanias.OptionsView.ShowIndicator = False
        Me.grdLoginCompanias.RowHeight = 23
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
        Me.comCodigoCompania.Width = 65
        '
        'comNombreCompania
        '
        Me.comNombreCompania.Caption = "COMPAÑÍA"
        Me.comNombreCompania.FieldName = "NombreCompania"
        Me.comNombreCompania.Name = "comNombreCompania"
        Me.comNombreCompania.Visible = True
        Me.comNombreCompania.VisibleIndex = 1
        Me.comNombreCompania.Width = 322
        '
        'btnIngresar
        '
        Me.btnIngresar.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Appearance.Options.UseBackColor = True
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.Location = New System.Drawing.Point(303, 85)
        Me.btnIngresar.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(108, 37)
        Me.btnIngresar.TabIndex = 1
        Me.btnIngresar.Text = "INGRESAR"
        '
        'txtClave
        '
        Me.txtClave.EditValue = ""
        Me.txtClave.Location = New System.Drawing.Point(255, 55)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.MaxLength = 17
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(156, 24)
        Me.txtClave.TabIndex = 0
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(255, 23)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtUsuario.Properties.MaxLength = 17
        Me.txtUsuario.Size = New System.Drawing.Size(156, 24)
        Me.txtUsuario.TabIndex = 0
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.anyStyle.My.Resources.Resources.Llave
        Me.PictureEdit1.Location = New System.Drawing.Point(-4, -4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(196, 188)
        Me.PictureEdit1.TabIndex = 3
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 398)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcLoginCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLoginCompanias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnIngresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gcLoginCompanias As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdLoginCompanias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents comIDCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comCodigoCompania As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comNombreCompania As DevExpress.XtraGrid.Columns.GridColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ribMenu = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.itmUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.itmProductos = New DevExpress.XtraBars.BarButtonItem()
        Me.itmProveedores = New DevExpress.XtraBars.BarButtonItem()
        Me.itmClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.itmGrupos = New DevExpress.XtraBars.BarButtonItem()
        Me.itmAgenda = New DevExpress.XtraBars.BarButtonItem()
        Me.itmReportes = New DevExpress.XtraBars.BarButtonItem()
        Me.itmModificar = New DevExpress.XtraBars.BarButtonItem()
        Me.itmGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.itmCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.itmCompanias = New DevExpress.XtraBars.BarButtonItem()
        Me.itmCerrarSesion = New DevExpress.XtraBars.BarButtonItem()
        Me.itmInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.itmServicios = New DevExpress.XtraBars.BarButtonItem()
        Me.itmCategorias = New DevExpress.XtraBars.BarButtonItem()
        Me.rtabConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpgCerrarSesion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgNoticias = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgCompanias = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgGrupos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgUsuarios = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgProveedores = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgCategorias = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgProductos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgServicios = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgClientes = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rtabProcesos = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rtabInformes = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.ribMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribMenu
        '
        Me.ribMenu.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribMenu.ExpandCollapseItem.Id = 0
        Me.ribMenu.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribMenu.ExpandCollapseItem, Me.itmUsuarios, Me.itmProductos, Me.itmProveedores, Me.itmClientes, Me.itmGrupos, Me.itmAgenda, Me.itmReportes, Me.itmModificar, Me.itmGuardar, Me.itmCancelar, Me.itmCompanias, Me.itmCerrarSesion, Me.itmInfo, Me.itmServicios, Me.itmCategorias})
        Me.ribMenu.Location = New System.Drawing.Point(0, 0)
        Me.ribMenu.MaxItemId = 25
        Me.ribMenu.Name = "ribMenu"
        Me.ribMenu.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rtabConfiguracion, Me.rtabProcesos, Me.rtabInformes})
        Me.ribMenu.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.ribMenu.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribMenu.ShowCategoryInCaption = False
        Me.ribMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribMenu.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribMenu.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.ribMenu.ShowToolbarCustomizeItem = False
        Me.ribMenu.Size = New System.Drawing.Size(1008, 125)
        Me.ribMenu.Toolbar.ShowCustomizeItem = False
        Me.ribMenu.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'itmUsuarios
        '
        Me.itmUsuarios.Caption = "USUARIOS"
        Me.itmUsuarios.Glyph = CType(resources.GetObject("itmUsuarios.Glyph"), System.Drawing.Image)
        Me.itmUsuarios.Id = 5
        Me.itmUsuarios.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmUsuarios.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmUsuarios.LargeGlyph = CType(resources.GetObject("itmUsuarios.LargeGlyph"), System.Drawing.Image)
        Me.itmUsuarios.Name = "itmUsuarios"
        '
        'itmProductos
        '
        Me.itmProductos.Caption = "PRODUCTOS"
        Me.itmProductos.Glyph = CType(resources.GetObject("itmProductos.Glyph"), System.Drawing.Image)
        Me.itmProductos.Id = 6
        Me.itmProductos.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmProductos.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmProductos.LargeGlyph = CType(resources.GetObject("itmProductos.LargeGlyph"), System.Drawing.Image)
        Me.itmProductos.Name = "itmProductos"
        '
        'itmProveedores
        '
        Me.itmProveedores.Caption = "PROVEEDORES"
        Me.itmProveedores.Glyph = CType(resources.GetObject("itmProveedores.Glyph"), System.Drawing.Image)
        Me.itmProveedores.Id = 7
        Me.itmProveedores.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmProveedores.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmProveedores.LargeGlyph = CType(resources.GetObject("itmProveedores.LargeGlyph"), System.Drawing.Image)
        Me.itmProveedores.Name = "itmProveedores"
        '
        'itmClientes
        '
        Me.itmClientes.Caption = "CLIENTES"
        Me.itmClientes.Glyph = CType(resources.GetObject("itmClientes.Glyph"), System.Drawing.Image)
        Me.itmClientes.Id = 8
        Me.itmClientes.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmClientes.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmClientes.LargeGlyph = CType(resources.GetObject("itmClientes.LargeGlyph"), System.Drawing.Image)
        Me.itmClientes.Name = "itmClientes"
        '
        'itmGrupos
        '
        Me.itmGrupos.Caption = "GRUPOS DE USUARIOS"
        Me.itmGrupos.Glyph = CType(resources.GetObject("itmGrupos.Glyph"), System.Drawing.Image)
        Me.itmGrupos.Id = 9
        Me.itmGrupos.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmGrupos.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmGrupos.LargeGlyph = CType(resources.GetObject("itmGrupos.LargeGlyph"), System.Drawing.Image)
        Me.itmGrupos.Name = "itmGrupos"
        '
        'itmAgenda
        '
        Me.itmAgenda.Caption = "AGENDA"
        Me.itmAgenda.Glyph = CType(resources.GetObject("itmAgenda.Glyph"), System.Drawing.Image)
        Me.itmAgenda.Id = 10
        Me.itmAgenda.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmAgenda.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmAgenda.LargeGlyph = CType(resources.GetObject("itmAgenda.LargeGlyph"), System.Drawing.Image)
        Me.itmAgenda.Name = "itmAgenda"
        '
        'itmReportes
        '
        Me.itmReportes.Caption = "REPORTES"
        Me.itmReportes.Glyph = CType(resources.GetObject("itmReportes.Glyph"), System.Drawing.Image)
        Me.itmReportes.Id = 11
        Me.itmReportes.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent
        Me.itmReportes.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmReportes.LargeGlyph = CType(resources.GetObject("itmReportes.LargeGlyph"), System.Drawing.Image)
        Me.itmReportes.Name = "itmReportes"
        '
        'itmModificar
        '
        Me.itmModificar.Caption = "MODIFICAR"
        Me.itmModificar.Enabled = False
        Me.itmModificar.Glyph = CType(resources.GetObject("itmModificar.Glyph"), System.Drawing.Image)
        Me.itmModificar.Id = 16
        Me.itmModificar.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.itmModificar.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmModificar.LargeGlyph = CType(resources.GetObject("itmModificar.LargeGlyph"), System.Drawing.Image)
        Me.itmModificar.Name = "itmModificar"
        '
        'itmGuardar
        '
        Me.itmGuardar.Caption = "GUARDAR"
        Me.itmGuardar.Enabled = False
        Me.itmGuardar.Glyph = CType(resources.GetObject("itmGuardar.Glyph"), System.Drawing.Image)
        Me.itmGuardar.Id = 18
        Me.itmGuardar.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.itmGuardar.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmGuardar.LargeGlyph = CType(resources.GetObject("itmGuardar.LargeGlyph"), System.Drawing.Image)
        Me.itmGuardar.Name = "itmGuardar"
        '
        'itmCancelar
        '
        Me.itmCancelar.Caption = "CANCELAR"
        Me.itmCancelar.Enabled = False
        Me.itmCancelar.Glyph = CType(resources.GetObject("itmCancelar.Glyph"), System.Drawing.Image)
        Me.itmCancelar.Id = 19
        Me.itmCancelar.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.itmCancelar.ItemAppearance.Normal.Options.UseBackColor = True
        Me.itmCancelar.LargeGlyph = CType(resources.GetObject("itmCancelar.LargeGlyph"), System.Drawing.Image)
        Me.itmCancelar.Name = "itmCancelar"
        '
        'itmCompanias
        '
        Me.itmCompanias.Caption = "COMPAÑÍAS"
        Me.itmCompanias.Glyph = CType(resources.GetObject("itmCompanias.Glyph"), System.Drawing.Image)
        Me.itmCompanias.Id = 20
        Me.itmCompanias.LargeGlyph = CType(resources.GetObject("itmCompanias.LargeGlyph"), System.Drawing.Image)
        Me.itmCompanias.Name = "itmCompanias"
        '
        'itmCerrarSesion
        '
        Me.itmCerrarSesion.Caption = "Cerrar Sesión"
        Me.itmCerrarSesion.Glyph = CType(resources.GetObject("itmCerrarSesion.Glyph"), System.Drawing.Image)
        Me.itmCerrarSesion.Id = 21
        Me.itmCerrarSesion.LargeGlyph = CType(resources.GetObject("itmCerrarSesion.LargeGlyph"), System.Drawing.Image)
        Me.itmCerrarSesion.Name = "itmCerrarSesion"
        '
        'itmInfo
        '
        Me.itmInfo.Caption = "Noticias"
        Me.itmInfo.Glyph = CType(resources.GetObject("itmInfo.Glyph"), System.Drawing.Image)
        Me.itmInfo.Id = 22
        Me.itmInfo.LargeGlyph = CType(resources.GetObject("itmInfo.LargeGlyph"), System.Drawing.Image)
        Me.itmInfo.Name = "itmInfo"
        '
        'itmServicios
        '
        Me.itmServicios.Caption = "SERVICIOS"
        Me.itmServicios.Glyph = CType(resources.GetObject("itmServicios.Glyph"), System.Drawing.Image)
        Me.itmServicios.Id = 23
        Me.itmServicios.LargeGlyph = CType(resources.GetObject("itmServicios.LargeGlyph"), System.Drawing.Image)
        Me.itmServicios.Name = "itmServicios"
        '
        'itmCategorias
        '
        Me.itmCategorias.Caption = "CATEGORIAS"
        Me.itmCategorias.Glyph = CType(resources.GetObject("itmCategorias.Glyph"), System.Drawing.Image)
        Me.itmCategorias.Id = 24
        Me.itmCategorias.LargeGlyph = CType(resources.GetObject("itmCategorias.LargeGlyph"), System.Drawing.Image)
        Me.itmCategorias.Name = "itmCategorias"
        '
        'rtabConfiguracion
        '
        Me.rtabConfiguracion.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgCerrarSesion, Me.rpgNoticias, Me.RibbonPageGroup3, Me.rpgCompanias, Me.rpgGrupos, Me.rpgUsuarios, Me.rpgProveedores, Me.rpgCategorias, Me.rpgProductos, Me.rpgServicios, Me.rpgClientes})
        Me.rtabConfiguracion.Name = "rtabConfiguracion"
        Me.rtabConfiguracion.Text = "ADMINISTRACIÓN"
        '
        'rpgCerrarSesion
        '
        Me.rpgCerrarSesion.ItemLinks.Add(Me.itmCerrarSesion)
        Me.rpgCerrarSesion.Name = "rpgCerrarSesion"
        '
        'rpgNoticias
        '
        Me.rpgNoticias.ItemLinks.Add(Me.itmInfo)
        Me.rpgNoticias.Name = "rpgNoticias"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "X"
        '
        'rpgCompanias
        '
        Me.rpgCompanias.ItemLinks.Add(Me.itmCompanias)
        Me.rpgCompanias.Name = "rpgCompanias"
        '
        'rpgGrupos
        '
        Me.rpgGrupos.ItemLinks.Add(Me.itmGrupos)
        Me.rpgGrupos.Name = "rpgGrupos"
        Me.rpgGrupos.ShowCaptionButton = False
        '
        'rpgUsuarios
        '
        Me.rpgUsuarios.Glyph = CType(resources.GetObject("rpgUsuarios.Glyph"), System.Drawing.Image)
        Me.rpgUsuarios.ItemLinks.Add(Me.itmUsuarios)
        Me.rpgUsuarios.Name = "rpgUsuarios"
        Me.rpgUsuarios.ShowCaptionButton = False
        '
        'rpgProveedores
        '
        Me.rpgProveedores.ItemLinks.Add(Me.itmProveedores)
        Me.rpgProveedores.Name = "rpgProveedores"
        Me.rpgProveedores.ShowCaptionButton = False
        '
        'rpgCategorias
        '
        Me.rpgCategorias.ItemLinks.Add(Me.itmCategorias)
        Me.rpgCategorias.Name = "rpgCategorias"
        '
        'rpgProductos
        '
        Me.rpgProductos.ItemLinks.Add(Me.itmProductos)
        Me.rpgProductos.Name = "rpgProductos"
        Me.rpgProductos.ShowCaptionButton = False
        '
        'rpgServicios
        '
        Me.rpgServicios.ItemLinks.Add(Me.itmServicios)
        Me.rpgServicios.Name = "rpgServicios"
        '
        'rpgClientes
        '
        Me.rpgClientes.ItemLinks.Add(Me.itmClientes)
        Me.rpgClientes.Name = "rpgClientes"
        Me.rpgClientes.ShowCaptionButton = False
        '
        'rtabProcesos
        '
        Me.rtabProcesos.Name = "rtabProcesos"
        Me.rtabProcesos.Text = "PROCESOS"
        '
        'rtabInformes
        '
        Me.rtabInformes.Name = "rtabInformes"
        Me.rtabInformes.Text = "INFORMES"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.MenuManager = Me.ribMenu
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 661)
        Me.Controls.Add(Me.ribMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribMenu
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "anyStyle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ribMenu As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents rtabConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents itmUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgUsuarios As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmProductos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgProductos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmProveedores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgProveedores As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itmGrupos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgClientes As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgGrupos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmAgenda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itmReportes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents itmModificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itmGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itmCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itmCompanias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCompanias As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmCerrarSesion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCerrarSesion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgNoticias As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rtabProcesos As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rtabInformes As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents itmServicios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgServicios As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents itmCategorias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgCategorias As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class

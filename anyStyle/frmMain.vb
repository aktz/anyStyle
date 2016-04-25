Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views

Public Class frmMain
    Public oListaFormularios As New ArrayList
    Public oDatosUsuario As clsDatosUsuario

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ribMenu.Enabled = False
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Private Sub itmCompanias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmCompanias.ItemClick
        frmCompanias.MdiParent = Me
        frmCompanias.Show()
    End Sub

    Private Sub itmUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmUsuarios.ItemClick
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub itmGrupos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmGrupos.ItemClick
        frmGrupos.MdiParent = Me
        frmGrupos.Show()
    End Sub

    Private Sub itmModificar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmModificar.ItemClick
        If Not IsNothing(DocumentManager1.View.ActiveDocument) Then
            If DocumentManager1.View.ActiveDocument.Caption = "USUARIOS" Then

            End If
        End If
    End Sub


    Private Sub DocumentManager1_DocumentActivate(sender As Object, e As DocumentEventArgs) Handles DocumentManager1.DocumentActivate
        If Not IsNothing(e.Document) Then
            oListaFormularios.Add(e.Document.Caption)
        End If
    End Sub

    Private Sub itmCerrarSesion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmCerrarSesion.ItemClick
        oListaFormularios.Clear()

        For Each form As Form In Me.MdiChildren
            form.Close()
            form.Dispose()
        Next

        frmLogin.MdiParent = Me
        frmLogin.Show()
        ribMenu.Enabled = False

        If Not IsNothing(oDatosUsuario) Then
            oDatosUsuario.Eliminar()
        End If
    End Sub

    Private Sub itmProveedores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmProveedores.ItemClick
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
    End Sub

    Private Sub itmProductos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles itmProductos.ItemClick
        frmProductos.MdiParent = Me
        frmProductos.Show()
    End Sub
End Class

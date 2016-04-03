Public Class frmLogin
    Dim sSQL As String
    Dim f As New clsFunciones

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsuario.Text = "9999999"
        txtClave.Text = "123"

        CrearPrimeraCompania()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        sSQL = "select IDUsuario from Usuarios" &
                " where CodigoUsuario = '" & f.InjSQL(txtUsuario.Text.Trim) & "'" &
                " and PwdUsuario = '" & f.InjSQL(f.Encriptar(txtClave.Text.Trim)) & "'"

        Dim dt As New DataTable
        dt = f.EjecutarQuery(sSQL)

        If dt.Rows.Count > 0 Then
            sSQL = "select *" &
                    " from UsuariosCompanias uco" &
                    " inner join Companias com on uco.IDCompania = com.IDCompania" &
                    " where IDUsuario = " & dt.Rows(0)("IDUsuario")

            dt = f.EjecutarQuery(sSQL)

            If dt.Rows.Count > 0 Then
                gcLoginCompanias.DataSource = IIf(dt.Rows.Count > 0, dt, Nothing)

                txtUsuario.BackColor = Color.White
                txtClave.BackColor = Color.White
            Else
                CrearPrimeraCompania()
            End If
        Else
            txtUsuario.BackColor = Color.LightPink
            txtClave.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub CrearPrimeraCompania()
        Dim dt As New DataTable

        sSQL = "select * from Companias"
        dt = f.EjecutarQuery(sSQL)

        If dt.Rows.Count = 0 Then
            Dim dtTmp As New DataTable
            dtTmp.Columns.Add("IDCompania", Type.GetType("System.Int32"))
            dtTmp.Columns.Add("CodigoCompania", Type.GetType("System.String"))
            dtTmp.Columns.Add("NombreCompania", Type.GetType("System.String"))
            dtTmp.Rows.Add(0, "0", "CREAR COMPAÑÍA")

            gcLoginCompanias.DataSource = dtTmp

            txtUsuario.Enabled = False
            txtClave.Enabled = False
            btnIngresar.Enabled = False
        End If
    End Sub

    Private Sub txtUsuario_Click(sender As Object, e As EventArgs) Handles txtUsuario.Click
        txtUsuario.Text = String.Empty
        txtUsuario.Focus()
    End Sub

    Private Sub txtClave_Click(sender As Object, e As EventArgs) Handles txtClave.Click
        txtClave.Text = String.Empty
        txtClave.Focus()
    End Sub

    Private Sub gcLoginCompanias_DoubleClick(sender As Object, e As EventArgs) Handles gcLoginCompanias.DoubleClick
        If grdLoginCompanias.RowCount = 1 And grdLoginCompanias.GetFocusedDataRow("CodigoCompania") = "0" Then
            Me.Close()
            Me.Dispose()
            frmMain.ribMenu.Enabled = True
            frmMain.rpgNoticias.Enabled = False
            frmMain.rpgGrupos.Enabled = False
            frmMain.rpgUsuarios.Enabled = False
            frmMain.rpgProveedores.Enabled = False
            frmMain.rpgProductos.Enabled = False
            frmMain.rpgClientes.Enabled = False
            frmMain.rtabProcesos.Visible = False
            frmMain.rtabInformes.Visible = False
        Else
            sSQL = "select usu.IDUsuario, usu.CodigoUsuario, usu.NombreUsuario, uco.IDGrupoUsuarios," &
                        " grp.IDGrupo, grp.CodigoGrupo, grp.NombreGrupo, grp.IndConfigurarUsuarios, grp.IndManejaCaja," &
                        " grp.IndManejaProductos, grp.IndModificar, grp.IndReportes" &
                    " from Usuarios usu" &
                    " inner join UsuariosCompanias uco On usu.IDUsuario = uco.IDUsuario" &
                    " inner join Grupos grp on uco.IDGrupoUsuarios = grp.IDGrupo" &
                    " where CodigoUsuario = '" & f.InjSQL(txtUsuario.Text.Trim) & "'" &
                    " and PwdUsuario = '" & f.Encriptar(txtClave.Text.Trim) & "'" &
                    " and uco.IDCompania = " & grdLoginCompanias.GetFocusedRowCellValue("IDCompania")

            Dim dt As New DataTable
            dt = f.EjecutarQuery(sSQL)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                frmMain.oDatosUsuario = New clsDatosUsuario(grdLoginCompanias.GetFocusedRowCellValue("IDCompania"), row("CodigoUsuario"),
                                                            row("NombreUsuario"), row("IDGrupo"), row("CodigoGrupo"), row("NombreGrupo"),
                                                            My.Computer.Name, "", row("IndModificar"), row("IndConfigurarUsuarios"), row("IndReportes"),
                                                            row("IndManejaCaja"), row("IndManejaProductos"))

                Me.Close()
                Me.Dispose()
                frmMain.ribMenu.Enabled = True
            Else
                MessageBox.Show("No existen Registros")
            End If
        End If
    End Sub
End Class
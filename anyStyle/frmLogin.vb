Public Class frmLogin
    Dim sSQL As String
    Dim f As New clsFunciones

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsuario.Text = "91287004"
        txtClave.Text = "123"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        sSQL = "select count(*) from Usuarios where Codigo = " & txtUsuario.Text.Trim & " and PwdUsuario = '" & f.Encriptar(txtClave.Text.Trim) & "'"
        Dim dt As New DataTable
        dt = f.EjecutarQuery(sSQL)

        If dt.Rows(0)(0) > 0 Then
            sSQL = "select *
                    from usuarios usu
                    inner join Grupos grp on usu.IDGrupoUsuarios = grp.IDGrupo
                    where usu.CodigoUsuario = " & txtUsuario.Text.Trim
            dt = f.EjecutarQuery(sSQL)

            If dt.Rows.Count > 0 Then
                'frmMain.oDatosUsuario = New clsDatosUsuario(
            End If
        Else
            txtUsuario.BackColor = Color.PaleVioletRed
            txtClave.BackColor = Color.PaleVioletRed
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



End Class
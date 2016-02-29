Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class clsFunciones
    'Dim sqlconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\anyDente\anyDente.accdb;Jet OLEDB:Database Password=1q2w3eazsxdc;"
    Dim sqlconn As String = "Server=MMUJICA;Database=anyStyle;User Id=sa;Password=1q2w3eazsxdM.;"
    'Dim sqlconn As String = "Server=DESARROLLO4;Database=ProContrato;Trusted_Connection=True;"
    'Dim conn As New OleDbConnection(sqlconn)
    Public conn As New SqlConnection(sqlconn)
    'Dim comm As OleDbCommand
    Dim comm As SqlCommand
    'Dim da As OleDbDataAdapter
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Public Function EjecutarQuery(ByVal sql As String) As DataTable
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            comm = New SqlCommand(sql, conn)
            da = New SqlDataAdapter(comm)

            dt = New DataTable
            da.Fill(dt)
            Return dt

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function EjecutarComando(ByVal sql As String) As Integer
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If

        comm = New SqlCommand(sql, conn)
        Dim numFilas As Integer = comm.ExecuteNonQuery()

        conn.Close()
        Return numFilas
    End Function

    Public Function InjSQL(ByVal cadena As String) As String
        InjSQL = Replace(cadena, "'", "")
    End Function

    Public Sub LlenarCombo(ByVal combo As DevExpress.XtraEditors.LookUpEdit, ByVal dt As DataTable, ByVal value As Integer, ByVal texto As Integer, Optional ByVal Primero As String = "", Optional ByVal Columnas() As Integer = Nothing, Optional ByVal AnchoColumnas() As Integer = Nothing)
        If Primero.Trim.Length > 0 Then
            Dim dr As DataRow
            Dim colValor As String = dt.Columns(value).ColumnName
            Dim colTexto As String = dt.Columns(texto).ColumnName

            dr = dt.NewRow
            dr(colValor) = -1
            dr(colTexto) = Primero
            dt.Rows.InsertAt(dr, 0)
        End If

        combo.Properties.Columns.Clear()
        combo.Properties.DataSource = dt
        combo.Properties.ValueMember = dt.Columns(value).ColumnName
        combo.Properties.DisplayMember = dt.Columns(texto).ColumnName
        combo.Properties.NullText = "Seleccione una Opción"

        Dim cols As DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection = Nothing
        cols = combo.Properties.Columns

        If Columnas Is Nothing Then
            cols.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(dt.Columns(texto).ColumnName, 0))
        Else
            For i As Integer = 0 To Columnas.LongLength - 1
                cols.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(dt.Columns(Columnas(i)).ColumnName, dt.Columns(Columnas(i)).ColumnName, AnchoColumnas(i), DevExpress.Utils.FormatType.None, "", IIf(AnchoColumnas(i) = 0, False, True), DevExpress.Utils.HorzAlignment.Default))
            Next
        End If
    End Sub

    Public Sub LlenarComboGrid(ByVal combo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal dt As DataTable, ByVal value As Integer, ByVal texto As Integer, Optional ByVal Primero As String = "")
        If Primero.Trim.Length > 0 Then
            Dim dr As DataRow
            Dim colValor As String = dt.Columns(value).ColumnName
            Dim colTexto As String = dt.Columns(texto).ColumnName

            dr = dt.NewRow
            dr(colValor) = -1
            dr(colTexto) = Primero
            dt.Rows.InsertAt(dr, 0)
        End If

        combo.Columns.Clear()
        combo.DataSource = dt
        combo.ValueMember = dt.Columns(value).ColumnName
        combo.DisplayMember = dt.Columns(texto).ColumnName

        Dim cols As DevExpress.XtraEditors.Controls.LookUpColumnInfoCollection = Nothing
        cols = combo.Columns

        cols.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(dt.Columns(texto).ColumnName, 0))
    End Sub

    Public Function ExisteArchivo(ByVal FileFullPath As String) As Boolean

        Dim f As New IO.FileInfo(FileFullPath)
        Return f.Exists

    End Function

    Public Function ExisteFolder(ByVal FolderPath As String) As Boolean

        Dim f As New IO.DirectoryInfo(FolderPath)
        Return f.Exists

    End Function

    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider

    Private Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Function Encriptar(ByVal plaintext As String) As String
        DES.Key = MD5Hash("1q2w3eazsxdM.")
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(plaintext)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function Desencriptar(ByVal encryptedtext As String) As String
        DES.Key = MD5Hash("1q2w3eazsxdM.")
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = Convert.FromBase64String(encryptedtext)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
End Class

Public Class clsDatosUsuario
    Private _Compania As Integer
    Private _CodigoUsuario As String
    Private _NombreUsuario As String
    Private _CodigoGrupo As String
    Private _NombreGrupo As String
    Private _Equipo As String = My.Computer.Name
    Private _Tema As String = "Default"
    Private _PuedeModificar As Boolean
    Private _PuedeConfigurarUsuarios As Boolean
    Private _PuedeGenerarReportes As Boolean
    Private _PuedeManejarCaja As Boolean
    Private _PuedeManejarProductos As Boolean

    Public Property Compania As Integer
        Get
            Return _Compania
        End Get
        Set(value As Integer)
            _Compania = value
        End Set
    End Property

    Public Property CodigoUsuario As Integer
        Get
            Return _CodigoUsuario
        End Get
        Set(value As Integer)
            _CodigoUsuario = value
        End Set
    End Property

    Public Property NombreUsuario As Integer
        Get
            Return _NombreUsuario
        End Get
        Set(value As Integer)
            _NombreUsuario = value
        End Set
    End Property

    Public Property CodigoGrupo As Integer
        Get
            Return _CodigoGrupo
        End Get
        Set(value As Integer)
            _CodigoGrupo = value
        End Set
    End Property

    Public Property NombreGrupo As Integer
        Get
            Return _NombreGrupo
        End Get
        Set(value As Integer)
            _NombreGrupo = value
        End Set
    End Property

    Public Property Equipo As Integer
        Get
            Return _Equipo
        End Get
        Set(value As Integer)
            _Equipo = value
        End Set
    End Property

    Public Property Tema As Integer
        Get
            Return _Tema
        End Get
        Set(value As Integer)
            _Tema = value
        End Set
    End Property

    Public Property PuedeModificar As Integer
        Get
            Return _PuedeModificar
        End Get
        Set(value As Integer)
            _PuedeModificar = value
        End Set
    End Property

    Public Property PuedeConfigurarUsuarios As Integer
        Get
            Return _PuedeConfigurarUsuarios
        End Get
        Set(value As Integer)
            _PuedeConfigurarUsuarios = value
        End Set
    End Property

    Public Property PuedeGenerarReportes As Integer
        Get
            Return _PuedeGenerarReportes
        End Get
        Set(value As Integer)
            _PuedeGenerarReportes = value
        End Set
    End Property

    Public Property PuedeManejarCaja As Integer
        Get
            Return _PuedeManejarCaja
        End Get
        Set(value As Integer)
            _PuedeManejarCaja = value
        End Set
    End Property

    Public Property PuedeManejarProductos As Integer
        Get
            Return _PuedeManejarProductos
        End Get
        Set(value As Integer)
            _PuedeManejarProductos = value
        End Set
    End Property

    Sub New(ByVal pCompania As Integer, ByVal pCodigoUsuario As String, ByVal pNombreUsuario As String, ByVal pCodigoGrupo As String,
            ByVal pNombreGrupo As String, ByVal pTema As String, ByVal pPuedeModificar As Boolean, ByVal pPuedeConfigurarUsuarios As Boolean,
            ByVal pPuedeGenerarReportes As Boolean, ByVal pPuedeManejarCaja As Boolean, ByVal pPuedeManejarProductos As Boolean)
        Compania = pCompania
        CodigoUsuario = pCodigoUsuario
        NombreUsuario = pNombreUsuario
        CodigoGrupo = pCodigoGrupo
        NombreGrupo = pNombreGrupo
        Tema = pTema
        PuedeModificar = pPuedeModificar
        PuedeConfigurarUsuarios = pPuedeConfigurarUsuarios
        PuedeGenerarReportes = pPuedeGenerarReportes
        PuedeManejarCaja = pPuedeManejarCaja
        PuedeManejarProductos = pPuedeManejarProductos
    End Sub


End Class


Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class clsProcedimientos
    Dim f As New clsFunciones

    Public Function pCompanias(ByVal dtCompanias As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Companias"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Companias"
        par.Value = dtCompanias
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function

    Public Function pGrupos(ByVal dtGrupos As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Grupos"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Grupos"
        par.Value = dtGrupos
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function

    Public Function pUsuarios(ByVal dtUsuarios As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Usuarios"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Usuarios"
        par.Value = dtUsuarios
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function

    Public Function pProveedores(ByVal dtProveedores As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Proveedores"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Proveedores"
        par.Value = dtProveedores
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function

    Public Function pProductos(ByVal dtProductos As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Productos"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Productos"
        par.Value = dtProductos
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function


    Public Function pClientes(ByVal dtClientes As DataTable) As DataTable
        Dim cmd As New SqlCommand
        Dim par As New SqlParameter
        Dim dr As SqlDataReader
        Dim dt As New DataTable

        cmd.Connection = f.conn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SP_Clientes"

        par = Nothing
        par = New SqlParameter
        par.ParameterName = "@Clientes"
        par.Value = dtClientes
        cmd.Parameters.Add(par)

        If cmd.Connection.State <> ConnectionState.Open Then
            cmd.Connection.Open()
        End If

        dr = cmd.ExecuteReader
        dt.Load(dr)

        Return dt
    End Function
End Class

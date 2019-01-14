Imports System.Data.OleDb
Module ModKoneksiDB
    Public DTR As OleDbDataReader
    Public CMD As New OleDbCommand
    Public DTA As New OleDbDataAdapter
    Public DTS As New DataSet
    Public DTT As New DataTable
    Public DTGrid As New DataTable
    Public strkon = "Provider=SQLNCLI11;Data Source=DESKTOP-46MH743;Integrated Security=SSPI;Initial Catalog=miniSahabat"
    Public koneksi As New OleDbConnection(strkon)
    Public Function BUKAKONEKSI() As OleDbConnection
        Try
            If koneksi.State = ConnectionState.Closed Then koneksi.Open()
        Catch ex As Exception
        End Try
        Return koneksi
    End Function

    Public Function TUTUPKONEKSI() As OleDbConnection
        If koneksi.State = ConnectionState.Open Then koneksi.Close()
        Return koneksi
    End Function
End Module

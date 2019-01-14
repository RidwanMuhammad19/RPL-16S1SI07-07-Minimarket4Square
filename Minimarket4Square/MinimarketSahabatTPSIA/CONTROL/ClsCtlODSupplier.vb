Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA
Public Class ClsCtlODSupplier : Implements infProses

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(idSupplier,4)) from supplier", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "S" & Strings.Right("000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements infProses.InsertData
        Dim Data As New ClsEntODSupplier
        Data = Ob
        CMD = New OleDbCommand("Insert into Supplier values ('" & Data.idSupplier & "','" _
                               & Data.NamaSupplier & "','" & Data.alamatSupplier & "','" & Data.teleponSup & "','" & Data.emailSup & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Dim Data As New ClsEntODSupplier
        Data = Ob
        CMD = New OleDbCommand("update Supplier set nama = '" _
        & Data.NamaSupplier & "',harga ='" & Data.alamatSupplier & "', telpon='" & Data.teleponSup & "',email ='" & Data.emailSup _
        & "' where idSupplier ='" & Data.idSupplier & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements infProses.DeleteData
        CMD = New OleDbCommand("delete from Supplier " _
                               & "where idSupplier ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements infProses.TampilData
        Try
            DTA = New OleDbDataAdapter("Select * from Supplier", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Supplier")
            Dim grid As New DataView(DTS.Tables("Tabel_Supplier"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements infProses.CariData
        Try
            DTA = New OleDbDataAdapter("Select * from Supplier where NAMA " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Supplier")
            Dim grid As New DataView(DTS.Tables("Cari_Supplier"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function cekSupplierDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = True
        Try
            DTA = New OleDbDataAdapter("Select count(idSupplier) from SUPPLIER " _
                                       & "where idSupplier = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class

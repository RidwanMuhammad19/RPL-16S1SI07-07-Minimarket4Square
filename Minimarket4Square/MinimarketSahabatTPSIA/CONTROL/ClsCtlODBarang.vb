Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA
Public Class ClsCtlODBarang : Implements infProses
    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(kdBarang,4)) from barang", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "BA" & Strings.Right("0000" & kodeakhir + 1, 4)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function CariData(kunci As String) As DataView Implements infProses.CariData
        Try
            DTA = New OleDbDataAdapter("Select * from barang where NAMA " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Barang")
            Dim grid As New DataView(DTS.Tables("Cari_Barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements infProses.DeleteData
        CMD = New OleDbCommand("delete from barang " _
                               & "where kdBarang ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements infProses.InsertData
        Dim Data As New ClsEntODBarang
        Data = Ob
        CMD = New OleDbCommand("Insert into barang values ('" & Data.kdBarang & "','" _
                               & Data.namaBarang & "'," & Data.hargaBarang & "," & Data.stokBarang & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements infProses.TampilData
        Try
            DTA = New OleDbDataAdapter("Select * from barang", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Barang")
            Dim grid As New DataView(DTS.Tables("Tabel_Barang"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Dim Data As New ClsEntODBarang
        Data = Ob
        CMD = New OleDbCommand("update barang set nama = '" _
        & Data.namaBarang & "',harga =" & Data.hargaBarang & ", stok=" & Data.stokBarang _
        & " where kdBarang ='" & Data.kdBarang & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function cekBarangDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = True
        Try
            DTA = New OleDbDataAdapter("Select count(kdBarang) from barang " _
                                       & "where kdBarang = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
        End Function
End Class

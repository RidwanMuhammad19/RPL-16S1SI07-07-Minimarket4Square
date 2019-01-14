Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA
Public Class ClsCtlTransPenjualan : Implements infProses


    'Function kodebaru() As String
    'Dim baru As String
    'Dim kodeakhir As Integer
    'Try
    '       DTA = New OleDbDataAdapter("select Max(right(kdpenjualan,3)) from penjualan", BUKAKONEKSI)
    '      DTS = New DataSet()
    '     DTA.Fill(DTS, "max_kode")
    '    kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
    '   baru = "detail1" & Strings.Right("000" & kodeakhir + 1, 3)
    'Return baru
    'Catch ex As Exception
    'Throw New Exception(ex.Message)
    'End Try
    'End Function

    Public Function KODEBARU(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select DBO.fc_penjualan ('" & kunci & "')", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "KODE")
            Dim grid As New DataView(DTS.Tables("KODE"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function cariDataBarang(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from barang where NAMA " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_barang")
            Dim grid As New DataView(DTS.Tables("Cari_barang"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function CariData(kunci As String) As DataView Implements infProses.CariData
        Throw New NotImplementedException()
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements infProses.DeleteData
        Throw New NotImplementedException()
    End Function

    Public Function HapusDGTransaksi()
        Try
            DTA = New OleDbDataAdapter("delete from sementara", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_sementara")
            Dim grid As New DataView(DTS.Tables("Tabel_sementara"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function InsertData(Ob As Object) As OleDbCommand Implements infProses.InsertData
        Dim Data As New ClsEntSementara
        Data = Ob
        CMD = New OleDbCommand("Insert into sementara values ('" & Data.kdbSementara & "','" & Data.namaSementara & "'," _
                               & Data.hargaSementara & "," & Data.jumlahSementara & "," & Data.subtotalSementara & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function insertPenjualan(Ob As Object) As OleDbCommand
        Dim Data As New ClsEntTransPenjualan
        Data = Ob
        CMD = New OleDbCommand("Insert into Penjualan values ('" & Data.kdPenjualan & "','" _
                               & Data.idOperator & "'," & Data.totalBelanja & ",'" & Format(Data.tanggal, "yyyy/MM/dd") & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function insertDetailPenjualan(Ob As Object) As OleDbCommand
        Dim Data As New ClsEntDetPenjualan
        Data = Ob
        CMD = New OleDbCommand("Insert into detPenjualan values ('" & Data.kodePenjualan & "','" _
                               & Data.kodeBarang & "'," & Data.subtotal & "," & Data.jumlahBeli & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function


    Public Function TampilData() As DataView Implements infProses.TampilData
        Try
            DTA = New OleDbDataAdapter("Select * from SEMENTARA", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_DATA")
            Dim grid As New DataView(DTS.Tables("Tabel_DATA"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function TampilDataLaporan() As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from Penjualan", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_penjualan")
            Dim grid As New DataView(DTS.Tables("Tabel_penjualan"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function


    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Throw New NotImplementedException()
    End Function
End Class

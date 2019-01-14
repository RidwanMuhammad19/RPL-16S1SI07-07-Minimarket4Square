Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA
Public Class ClsCtlTransPembelian : Implements infProses

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

    Public Function cariDataSupplier(kunci As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from supplier where NAMA " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Supplier")
            Dim grid As New DataView(DTS.Tables("Cari_Supplier"))
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

    Public Function insertPembelian(Ob As Object) As OleDbCommand
        Dim Data As New ClsEntTransPembelian
        Data = Ob
        CMD = New OleDbCommand("Insert into Pembelian values ('" & Data.kdPembelian & "','" _
                               & Data.idOperator & "','" & Format(Data.tanggal, "yyyy/MM/dd") & "'," & Data.totalPembelian & ")", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function insertDetailPembelian(Ob As Object) As OleDbCommand
        Dim Data As New ClsEntDetPembelian
        Data = Ob
        CMD = New OleDbCommand("Insert into detPembelian values ('" & Data.kdPembelian & "','" _
                               & Data.idSupplier & "'," & Data.quantity & "," & Data.subTotal & ")", BUKAKONEKSI)
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
            DTA = New OleDbDataAdapter("Select * from Pembelian", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_pembelian")
            Dim grid As New DataView(DTS.Tables("Tabel_pembelian"))

            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Throw New NotImplementedException()
    End Function
End Class

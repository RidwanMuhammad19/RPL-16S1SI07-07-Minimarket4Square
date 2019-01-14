Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA

Public Class ClsCtlODOperator : Implements infProses

    Function kodebaru() As String
        Dim baru As String
        Dim kodeAkhir As Integer
        Try
            DTA = New OleDbDataAdapter("select Max(right(IDUSER,3)) from OPERATOR", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeAkhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "OP" & Strings.Right("000" & kodeAkhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function CariData(kunci As String) As DataView Implements infProses.CariData
        Try
            DTA = New OleDbDataAdapter("Select * from operator where NAMA " _
                                        & "like '%" & kunci & "%'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Operator")
            Dim grid As New DataView(DTS.Tables("Cari_Operator"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function DeleteData(kunci As String) As OleDbCommand Implements infProses.DeleteData
        CMD = New OleDbCommand("delete from Operator " _
                               & "where idUser ='" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function InsertData(Ob As Object) As OleDbCommand Implements infProses.InsertData
        Dim Data As New ClsEntODOperator
        Data = Ob
        CMD = New OleDbCommand("Insert into Operator values('" & Data.idOperator & "','" _
                               & Data.NamaOperator & "','" & Data.alamatOperator & "','" _
                               & Data.telponOperator & "','" & Data.statusOperator & "','" _
                               & Data.usernameOp & "','" & Data.passOp & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function TampilData() As DataView Implements infProses.TampilData
        Try
            DTA = New OleDbDataAdapter("Select * from operator", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Operator")
            Dim grid As New DataView(DTS.Tables("Tabel_Operator"))
            Return grid

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Dim Data As New ClsEntODOperator
        Data = Ob
        CMD = New OleDbCommand("update Operator set nama = '" _
        & Data.NamaOperator & "',alamat ='" & Data.alamatOperator _
        & "', telpon = '" & Data.telponOperator & "', status ='" & Data.statusOperator _
        & "', username = '" & Data.usernameOp & "', password ='" & Data.passOp _
        & "', where idUser ='" & Data.idOperator & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OleDbCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function cekOperatorDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OleDbDataAdapter("Select count(idUser) from operator " _
                                       & "where idUser = '" & kunci & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return cek
    End Function
End Class

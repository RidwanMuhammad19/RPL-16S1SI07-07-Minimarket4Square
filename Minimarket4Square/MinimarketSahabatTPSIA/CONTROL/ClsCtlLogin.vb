Imports System.Data.OleDb
Imports MinimarketSahabatTPSIA
Public Class ClsCtlLogin : Implements infProses
    Public Function LoginOperator(username As String) As DataView
        Try
            DTA = New OleDbDataAdapter("Select * from Operator where username = '" & username & "'", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Operator")
            Dim grid As New DataView(DTS.Tables("Cari_Operator"))
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

    Public Function InsertData(Ob As Object) As OleDbCommand Implements infProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements infProses.TampilData
        Throw New NotImplementedException()
    End Function

    Public Function UpdateData(Ob As Object) As OleDbCommand Implements infProses.UpdateData
        Throw New NotImplementedException()
    End Function
End Class

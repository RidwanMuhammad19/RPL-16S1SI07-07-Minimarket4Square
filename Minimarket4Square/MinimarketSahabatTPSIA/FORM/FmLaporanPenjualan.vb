Public Class FmLaporanPenjualan
    Dim baris, totBeli, modeproses As Integer
    Dim kodepenjualan, iduser As String
    Dim tgl As Date
    Private Sub FmLaporanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
    End Sub

    Private Sub refreshGrid()
        DTGrid = ControlTransPenjualan.TampilDataLaporan.ToTable
        DGLaporan.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGLaporan.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGLaporan.CurrentCell = DGLaporan.Item(1, baris)
        End If

    End Sub


    Public Sub Penjualan(pe As Integer)
        With DGLaporan.Rows(pe)
            kodepenjualan = .Cells(0).Value
            iduser = .Cells(1).Value
            totBeli = .Cells(2).Value
            tgl = .Cells(3).Value
        End With

    End Sub
End Class
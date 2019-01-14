Public Class FmUtamaKasir
    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Me.Hide()
        FmTransPenjualan.Show()
    End Sub

    Private Sub btnLapPenjualan_Click(sender As Object, e As EventArgs) Handles btnLapPenjualan.Click
        FmLaporanPenjualan.Show()
    End Sub
End Class
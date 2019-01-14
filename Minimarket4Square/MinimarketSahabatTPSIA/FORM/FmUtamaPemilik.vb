Public Class FmUtamaPemilik
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LoginOperator.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FmLaporanPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FmTransPembelian.Show()
        Me.Hide()
    End Sub
End Class
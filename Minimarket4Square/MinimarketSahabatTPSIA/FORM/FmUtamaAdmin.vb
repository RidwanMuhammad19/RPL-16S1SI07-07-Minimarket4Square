Public Class FmUtamaAdmin
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        FmODBarang.Show()
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnOperator.Click
        FmODoperator.Show()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click

    End Sub
End Class
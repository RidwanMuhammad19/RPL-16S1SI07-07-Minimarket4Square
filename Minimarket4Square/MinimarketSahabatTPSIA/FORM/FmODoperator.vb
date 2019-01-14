Public Class FmODoperator
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub isiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGOperator.Rows(br)
                txtIdOperator.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelpon.Text = .Cells(3).Value.ToString
                CBStatus.Text = .Cells(4).Value.ToString
                txtUsername.Text = .Cells(5).Value.ToString
                txtPassword.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub

    Private Sub refreshGrid()
        DTGrid = ControlODOperator.TampilData.ToTable
        DGOperator.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            isiBox(baris)
        End If
    End Sub

    Private Sub bersihdata()
        txtIdOperator.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelpon.Text = ""
        CBStatus.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = ControlODOperator.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGOperator.DataSource = DTGrid
            DGOperator.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGOperator.CurrentCell = DGOperator.Item(1, baris)
            isiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            refreshGrid()
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FmUtamaAdmin.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call bersihdata()
    End Sub

    Private Sub FmODoperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call refreshGrid()
        Call bersihdata()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasODOperator
            .idOperator = txtIdOperator.Text
            .NamaOperator = txtNama.Text
            .alamatOperator = txtAlamat.Text
            .telponOperator = txtTelpon.Text
            .statusOperator = CBStatus.Text
            .usernameOp = txtUsername.Text
            .passOp = txtPassword.Text
        End With

        If modeProses = 1 Then
            ControlODOperator.InsertData(EntitasODOperator)
        ElseIf modeProses = 2 Then
            ControlODOperator.UpdateData(EntitasODOperator)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_refrensi As Boolean
        status_refrensi = ControlODOperator.cekOperatorDireferensi(txtIdOperator.Text)
        If status_refrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            ControlODOperator.DeleteData(txtIdOperator.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call refreshGrid()

        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1

        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelpon.Text = ""
        CBStatus.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""

        txtIdOperator.Text = ControlODOperator.kodeBaru()
        txtNama.Focus()
    End Sub
    Private Sub DGOperator_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGOperator.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGOperator.Rows(baris).Selected = True
            isiBox(baris)

        End If
    End Sub

End Class
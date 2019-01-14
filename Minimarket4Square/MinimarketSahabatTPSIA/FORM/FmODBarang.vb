
Public Class FmODBarang
    Dim modeProses As Integer

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                lblKdBarang.Text = .Cells(0).Value.ToString
                txtMenu.Text = .Cells(1).Value.ToString
                txtHarga.Text = .Cells(2).Value.ToString
                txtStok.Text = .Cells(3).Value.ToString

            End With
        End If
    End Sub

    Private Sub refreshGrid()
        Dim baris As Integer
        DTGrid = ControlODBarang.TampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        FmUtamaAdmin.Show()
    End Sub

    Private Sub FmODBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim status_direfrensi As Boolean
        status_direfrensi = ControlODBarang.cekBarangDireferensi(lblKdBarang.Text)
        If status_direfrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            ControlODBarang.DeleteData(lblKdBarang.Text)
        End If
        Call refreshGrid()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1

        txtMenu.Text = ""
        txtHarga.Text = ""
        txtStok.Text = ""

        lblKdBarang.Text = ControlODBarang.kodebaru()
        txtMenu.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With EntitasODBarang
            .kdBarang = lblKdBarang.Text
            .namaBarang = txtMenu.Text
            .hargaBarang = txtHarga.Text
            .stokBarang = txtStok.Text
        End With

        If modeProses = 1 Then
            ControlODBarang.InsertData(EntitasODBarang)
        ElseIf modeProses = 2 Then
            ControlODBarang.UpdateData(EntitasODBarang)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub TampilCari(kunci As String)
        Dim baris As Integer
        DTGrid = ControlODBarang.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            refreshGrid()
        End If
    End Sub

    Private Sub DGBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellContentClick
        Dim baris As Integer
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call refreshGrid()

        Else
            Call TampilCari(btnCari.Text)
            txtCari.Focus()
        End If
        txtCari.Text = ""
    End Sub
End Class
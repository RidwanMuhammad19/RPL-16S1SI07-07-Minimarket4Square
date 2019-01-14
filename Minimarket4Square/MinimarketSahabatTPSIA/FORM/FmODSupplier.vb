Public Class FmODSupplier
    Dim modeProses As Integer

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FmUtamaAdmin.Show()
        Me.Hide()
    End Sub



    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGSupplier.Rows(br)
                txtIdSupplier.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtAlamat.Text = .Cells(2).Value.ToString
                txtTelpon.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString

            End With
        End If
    End Sub

    Private Sub refreshGrid()
        Dim baris As Integer
        DTGrid = controlODSupplier.TampilData.ToTable
        DGSupplier.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            IsiBox(baris)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1

        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelpon.Text = ""
        txtEmail.Text = ""

        txtIdSupplier.Text = controlODSupplier.kodebaru()
        txtNama.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        With entitasODSupplier
            .idSupplier = txtIdSupplier.Text
            .NamaSupplier = txtNama.Text
            .alamatSupplier = txtAlamat.Text
            .teleponSup = txtTelpon.Text
            .emailSup = txtEmail.Text
        End With

        If modeProses = 1 Then
            controlODSupplier.InsertData(entitasODSupplier)
        ElseIf modeProses = 2 Then
            controlODSupplier.UpdateData(entitasODSupplier)
        End If
        MsgBox("Data telah tersimpan", MsgBoxStyle.Information, "info")
        refreshGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim status_direfrensi As Boolean
        status_direfrensi = controlODSupplier.cekSupplierDireferensi(txtIdSupplier.Text)
        If status_direfrensi Then
            MsgBox("Data masih digunakan, Tidak boleh dihapus ", MsgBoxStyle.Exclamation, "peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah anda yakin ingin menghapus data ?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            controlODSupplier.DeleteData(txtIdSupplier.Text)
        End If
        refreshGrid()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtIdSupplier.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelpon.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub TampilCari(kunci As String)
        Dim baris As Integer
        DTGrid = controlODSupplier.CariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGSupplier.DataSource = DTGrid
            DGSupplier.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGSupplier.CurrentCell = DGSupplier.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("Data tidak ditemukan")
            refreshGrid()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call refreshGrid()

        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
        txtCari.Text = ""
    End Sub

    Private Sub FmODSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call refreshGrid()
    End Sub

    Private Sub DGSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellContentClick
        Dim baris As Integer
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSupplier.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub
End Class
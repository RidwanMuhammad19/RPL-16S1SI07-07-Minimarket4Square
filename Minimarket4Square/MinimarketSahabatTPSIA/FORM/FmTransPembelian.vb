Imports System.Data.OleDb
Public Class FmTransPembelian
    Dim baris As Integer
    Dim modeProses As Integer
    Dim kode, nama, email As String
    Dim harga, subtotal, total, qty, stok, kembalian As Integer



    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FmUtamaPemilik.Show()
    End Sub

    Private Sub refreshGrid()
        DTGrid = controlTransPembelian.TampilData.ToTable
        DGTransaksi.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGTransaksi.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGTransaksi.CurrentCell = DGTransaksi.Item(1, baris)
        End If
    End Sub

    Sub panggilDataBarang()
        DTA = New OleDbDataAdapter("Select * from Barang", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "Barang")
        DGSupplier.DataSource = (DTS.Tables("Barang"))
    End Sub

    Sub panggilDataSupplier()
        DTA = New OleDbDataAdapter("Select * from Supplier", BUKAKONEKSI)
        DTS = New DataSet
        DTS.Clear()
        DTA.Fill(DTS, "supplier")
        DGSupplier.DataSource = (DTS.Tables("Supplier"))
    End Sub

    Public Sub Barang(ba As Integer)
        With DGSupplier.Rows(ba)
            kode = .Cells(0).Value
            nama = .Cells(1).Value
            harga = .Cells(2).Value
            stok = .Cells(3).Value
        End With
    End Sub

    Public Sub Supplier(su As Integer)
        With DGSupplier.Rows(su)
            kode = .Cells(0).Value
            nama = .Cells(1).Value
            email = .Cells(2).Value
        End With
    End Sub

    Private Sub DGSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGSupplier.Rows(baris).Selected = True
            Call Barang(baris)
        End If
    End Sub

    Private Sub DGBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBarang.CellContentClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGBarang.Rows(baris).Selected = True
            Call Barang(baris)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        modeProses = 1
        txtCariSupplier.Text = ""
        txtQty.Text = ""
        'lblKdPembelian.Text = controlTransPembelian.KODEBARU(Format(Today(), "yyyy/MM/dd")).ToString

        txtCariBarang.Focus()
    End Sub
    Private Sub masukdataDetail()
        With entitasDetailPembelian
            .kdPembelian = lblKdPembelian.Text
            .idSupplier = kode
            .quantity = qty
            .subTotal = subtotal
            controlTransPembelian.insertDetailPembelian(entitasDetailPembelian)
        End With
        refreshGrid()
    End Sub

    Private Sub masukdataSementara()
        With entitasSementara
            .kdbSementara = kode
            .namaSementara = nama
            .jumlahSementara = txtQty.Text
            .hargaSementara = harga
            .subtotalSementara = subtotal

            controlTransPembelian.InsertData(entitasSementara)
        End With
        refreshGrid()
    End Sub

    Private Sub masukdataPembelian()
        With entitasTransPembelian
            .kdPembelian = lblKdPembelian.Text
            .idOperator = lblOperator.Text
            .tanggal = lblTgl.Text
            .totalPembelian = txtTotal.Text
            controlTransPembelian.insertPembelian(entitasTransPembelian)
        End With
        refreshGrid()
    End Sub



    Private Sub btnOke_Click(sender As Object, e As EventArgs) Handles btnOke.Click
        subtotal = Val(txtQty.Text) * harga
        qty = Val(txtQty.Text)

        Call masukdataSementara()
        Call refreshGrid()
        txtQty.Text = ""
    End Sub


End Class
Imports System.Data.OleDb
Public Class FmTransPenjualan
    Dim baris As Integer
    Dim modeProses As Integer
    Dim kode, nama As String
    Dim harga, subTotal, total, qty, stok, kembalian As Integer



    Private Sub FmTransPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTgl.Text = Today
        Call panggilDataBarang()
        ControlTransPenjualan.HapusDGTransaksi()
        Call refreshGridBarang()
        Call refreshGrid()
        qty = 0
        total = 0
        subTotal = 0
        kembalian = 0

    End Sub

    Private Sub refreshGrid()
        DTGrid = ControlTransPenjualan.TampilData.ToTable
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
        DGBarang.DataSource = (DTS.Tables("Barang"))
    End Sub

    Public Sub Barang(ba As Integer)
        With DGBarang.Rows(ba)
            kode = .Cells(0).Value
            nama = .Cells(1).Value
            harga = .Cells(2).Value
            stok = .Cells(3).Value
        End With

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
        txtCari.Text = ""
        txtQty.Text = ""

        lblKdPenjualan.Text = ControlTransPenjualan.KODEBARU(Format(Today(), "yyyy/MM/dd")).ToString

        txtCari.Focus()
    End Sub

    Private Sub masukdataDetail()
        With entitasDetailPenjualan
            .kodePenjualan = lblKdPenjualan.Text
            .kodeBarang = kode
            .subtotal = subTotal
            .jumlahBeli = qty
            ControlTransPenjualan.insertDetailPenjualan(entitasDetailPenjualan)
        End With
        refreshGrid()
    End Sub

    Private Sub masukdataSementara()
        With entitasSementara
            .kdbSementara = kode
            .namaSementara = nama
            .jumlahSementara = txtQty.Text
            .hargaSementara = harga
            .subtotalSementara = subTotal

            ControlTransPenjualan.InsertData(entitasSementara)
        End With
        refreshGrid()
    End Sub

    Private Sub masukdataPenjualan()
        With EntitasTransPenjualan
            .kdPenjualan = lblKdPenjualan.Text
            .idOperator = lblOperator.Text
            .tanggal = lblTgl.Text
            .totalBelanja = txtTotal.Text
            ControlTransPenjualan.insertPenjualan(EntitasTransPenjualan)
        End With
        refreshGrid()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        subTotal = Val(txtQty.Text) * harga
        qty = Val(txtQty.Text)
        total = total + subTotal
        txtTotal.Text = total
        Call masukdataSementara()
        Call refreshGrid()
        txtQty.Text = ""
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Call masukdataPenjualan()
        Call masukdataDetail()

    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        Dim kembalian As Integer

        kembalian = Val(txtBayar.Text) - txtTotal.Text
        txtKembali.Text = kembalian

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        FmUtamaKasir.Show()
    End Sub


    Private Sub TampilCari(kunci As String)
        DTGrid = ControlTransPenjualan.cariDataBarang(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            Barang(baris)
        Else
            MsgBox("Data tidak ditemukan")
            refreshGridBarang()
        End If
    End Sub


    Sub refreshGridBarang()
        DTGrid = ControlODBarang.TampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
        End If
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text = "" Then
            Call refreshGridBarang()

        Else
            Call TampilCari(txtCari.Text)
            txtCari.Focus()
        End If
        txtCari.Text = ""
    End Sub



End Class
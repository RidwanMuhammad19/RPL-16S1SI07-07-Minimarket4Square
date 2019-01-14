<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmTransPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblKdPembelian = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DATA = New System.Windows.Forms.GroupBox()
        Me.txtCariSupplier = New System.Windows.Forms.TextBox()
        Me.btnCariSupplier = New System.Windows.Forms.Button()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOke = New System.Windows.Forms.Button()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCariBarang = New System.Windows.Forms.Button()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblTgl = New System.Windows.Forms.Label()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.DATA.SuspendLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(319, 160)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.Size = New System.Drawing.Size(387, 165)
        Me.DGTransaksi.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblKdPembelian)
        Me.GroupBox2.Controls.Add(Me.lblOperator)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(319, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 71)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA PENJUALAN"
        '
        'lblKdPembelian
        '
        Me.lblKdPembelian.AutoSize = True
        Me.lblKdPembelian.Location = New System.Drawing.Point(111, 23)
        Me.lblKdPembelian.Name = "lblKdPembelian"
        Me.lblKdPembelian.Size = New System.Drawing.Size(68, 13)
        Me.lblKdPembelian.TabIndex = 2
        Me.lblKdPembelian.Text = "P181211011"
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(111, 48)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(14, 13)
        Me.lblOperator.TabIndex = 2
        Me.lblOperator.Text = "~"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "KASIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KD PEMBELIAN"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(523, 344)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(181, 28)
        Me.txtTotal.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(362, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 26)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TOTAL PEMBELIAN"
        '
        'DATA
        '
        Me.DATA.Controls.Add(Me.txtCariSupplier)
        Me.DATA.Controls.Add(Me.btnCariSupplier)
        Me.DATA.Controls.Add(Me.DGSupplier)
        Me.DATA.Location = New System.Drawing.Point(12, 80)
        Me.DATA.Name = "DATA"
        Me.DATA.Size = New System.Drawing.Size(301, 159)
        Me.DATA.TabIndex = 17
        Me.DATA.TabStop = False
        Me.DATA.Text = "DATA SUPPLIER"
        '
        'txtCariSupplier
        '
        Me.txtCariSupplier.Location = New System.Drawing.Point(6, 18)
        Me.txtCariSupplier.Multiline = True
        Me.txtCariSupplier.Name = "txtCariSupplier"
        Me.txtCariSupplier.Size = New System.Drawing.Size(199, 23)
        Me.txtCariSupplier.TabIndex = 10
        '
        'btnCariSupplier
        '
        Me.btnCariSupplier.Location = New System.Drawing.Point(211, 18)
        Me.btnCariSupplier.Name = "btnCariSupplier"
        Me.btnCariSupplier.Size = New System.Drawing.Size(75, 23)
        Me.btnCariSupplier.TabIndex = 12
        Me.btnCariSupplier.Text = "CARI"
        Me.btnCariSupplier.UseVisualStyleBackColor = True
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(6, 48)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(278, 96)
        Me.DGSupplier.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(199, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 33)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "MINIMARKET SAHABAT"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(12, 23)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 37)
        Me.btnKembali.TabIndex = 25
        Me.btnKembali.Text = "KEMBALI"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(310, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TRANSAKSI PEMBELIAN"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(172, 453)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 37)
        Me.btnCetak.TabIndex = 26
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(91, 453)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 37)
        Me.btnHapus.TabIndex = 27
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(12, 453)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 37)
        Me.btnTambah.TabIndex = 28
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOke)
        Me.GroupBox1.Controls.Add(Me.txtCariBarang)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnCariBarang)
        Me.GroupBox1.Controls.Add(Me.DGBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 202)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA BARANG"
        '
        'btnOke
        '
        Me.btnOke.Location = New System.Drawing.Point(214, 150)
        Me.btnOke.Name = "btnOke"
        Me.btnOke.Size = New System.Drawing.Size(75, 23)
        Me.btnOke.TabIndex = 11
        Me.btnOke.Text = "OK"
        Me.btnOke.UseVisualStyleBackColor = True
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Location = New System.Drawing.Point(8, 19)
        Me.txtCariBarang.Multiline = True
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(199, 23)
        Me.txtCariBarang.TabIndex = 10
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(156, 150)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(51, 23)
        Me.txtQty.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "QTY"
        '
        'btnCariBarang
        '
        Me.btnCariBarang.Location = New System.Drawing.Point(213, 19)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(75, 23)
        Me.btnCariBarang.TabIndex = 12
        Me.btnCariBarang.Text = "CARI"
        Me.btnCariBarang.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(6, 48)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(278, 96)
        Me.DGBarang.TabIndex = 8
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(253, 453)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 37)
        Me.btnSimpan.TabIndex = 26
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblTgl.ForeColor = System.Drawing.Color.Yellow
        Me.lblTgl.Location = New System.Drawing.Point(642, 59)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(14, 13)
        Me.lblTgl.TabIndex = 30
        Me.lblTgl.Text = "~"
        '
        'FmTransPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(728, 524)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGTransaksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DATA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FmTransPembelian"
        Me.Text = "FmTransPembelian"
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DATA.ResumeLayout(False)
        Me.DATA.PerformLayout()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGTransaksi As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblKdPembelian As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DATA As GroupBox
    Friend WithEvents txtCariSupplier As TextBox
    Friend WithEvents btnCariSupplier As Button
    Friend WithEvents DGSupplier As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOke As Button
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCariBarang As Button
    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblTgl As Label
End Class

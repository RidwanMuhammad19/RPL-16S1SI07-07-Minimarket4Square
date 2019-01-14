<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmTransPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DATA = New System.Windows.Forms.GroupBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblKdPenjualan = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.DATA.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Navy
        Me.ListView1.Location = New System.Drawing.Point(-16, -11)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(948, 85)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Navy
        Me.ListView2.Location = New System.Drawing.Point(-16, 499)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(948, 30)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(199, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MINIMARKET 4 SQUARE"
        '
        'DATA
        '
        Me.DATA.Controls.Add(Me.btnOk)
        Me.DATA.Controls.Add(Me.txtCari)
        Me.DATA.Controls.Add(Me.txtQty)
        Me.DATA.Controls.Add(Me.Label1)
        Me.DATA.Controls.Add(Me.btnCari)
        Me.DATA.Controls.Add(Me.DGBarang)
        Me.DATA.Location = New System.Drawing.Point(12, 80)
        Me.DATA.Name = "DATA"
        Me.DATA.Size = New System.Drawing.Size(475, 188)
        Me.DATA.TabIndex = 6
        Me.DATA.TabStop = False
        Me.DATA.Text = "DATA BARANG"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(378, 152)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(169, 19)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(203, 23)
        Me.txtCari.TabIndex = 10
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(320, 152)
        Me.txtQty.Multiline = True
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(51, 23)
        Me.txtQty.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "QTY"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(378, 19)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 12
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(6, 48)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(463, 96)
        Me.DGBarang.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "KD PENJUALAN"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblKdPenjualan)
        Me.GroupBox2.Controls.Add(Me.lblOperator)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(493, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 71)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA PENJUALAN"
        '
        'lblKdPenjualan
        '
        Me.lblKdPenjualan.AutoSize = True
        Me.lblKdPenjualan.Location = New System.Drawing.Point(111, 23)
        Me.lblKdPenjualan.Name = "lblKdPenjualan"
        Me.lblKdPenjualan.Size = New System.Drawing.Size(68, 13)
        Me.lblKdPenjualan.TabIndex = 2
        Me.lblKdPenjualan.Text = "P181211012"
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
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.BackColor = System.Drawing.Color.Navy
        Me.lblTgl.ForeColor = System.Drawing.Color.Yellow
        Me.lblTgl.Location = New System.Drawing.Point(658, 45)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(14, 13)
        Me.lblTgl.TabIndex = 2
        Me.lblTgl.Text = "~"
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(493, 157)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(255, 55)
        Me.txtHasil.TabIndex = 10
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(493, 225)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 37)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(574, 225)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 37)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(655, 225)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 37)
        Me.btnCetak.TabIndex = 12
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(12, 9)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 37)
        Me.btnKembali.TabIndex = 12
        Me.btnKembali.Text = "KEMBALI"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Navy
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(310, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "TRANSAKSI PENJUALAN"
        '
        'txtKembali
        '
        Me.txtKembali.Enabled = False
        Me.txtKembali.Location = New System.Drawing.Point(525, 438)
        Me.txtKembali.Multiline = True
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(181, 28)
        Me.txtKembali.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(525, 370)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(181, 28)
        Me.txtTotal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(420, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TOTAL BELI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(456, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 26)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "BAYAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 438)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "KEMBALI"
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(12, 274)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.Size = New System.Drawing.Size(694, 90)
        Me.DGTransaksi.TabIndex = 13
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(525, 404)
        Me.txtBayar.Multiline = True
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(181, 28)
        Me.txtBayar.TabIndex = 14
        '
        'FmTransPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(770, 522)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.DGTransaksi)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.DATA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FmTransPenjualan"
        Me.Text = "FmTransPenjualan"
        Me.DATA.ResumeLayout(False)
        Me.DATA.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents DATA As GroupBox
    Friend WithEvents btnOk As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblKdPenjualan As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGTransaksi As DataGridView
    Friend WithEvents txtBayar As TextBox
End Class

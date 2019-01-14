<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmODBarang
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
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblKdBarang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMenu = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(15, 231)
        Me.DGBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(529, 261)
        Me.DGBarang.TabIndex = 53
        Me.DGBarang.UseWaitCursor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(428, 48)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 31)
        Me.btnDelete.TabIndex = 50
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.UseWaitCursor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(428, 116)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(84, 31)
        Me.btnKembali.TabIndex = 51
        Me.btnKembali.Text = "KEMBALI"
        Me.btnKembali.UseVisualStyleBackColor = True
        Me.btnKembali.UseWaitCursor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(19, 199)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(421, 22)
        Me.txtCari.TabIndex = 53
        Me.txtCari.UseWaitCursor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(447, 196)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(84, 31)
        Me.btnCari.TabIndex = 46
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        Me.btnCari.UseWaitCursor = True
        '
        'lblKdBarang
        '
        Me.lblKdBarang.AutoSize = True
        Me.lblKdBarang.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKdBarang.Location = New System.Drawing.Point(160, 32)
        Me.lblKdBarang.Name = "lblKdBarang"
        Me.lblKdBarang.Size = New System.Drawing.Size(22, 23)
        Me.lblKdBarang.TabIndex = 52
        Me.lblKdBarang.Text = "~"
        Me.lblKdBarang.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "HARGA"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "MENU"
        Me.Label1.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "STOK"
        Me.Label3.UseWaitCursor = True
        '
        'txtMenu
        '
        Me.txtMenu.Location = New System.Drawing.Point(164, 57)
        Me.txtMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMenu.Name = "txtMenu"
        Me.txtMenu.Size = New System.Drawing.Size(215, 22)
        Me.txtMenu.TabIndex = 54
        Me.txtMenu.UseWaitCursor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 17)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "KD BARANG"
        Me.Label13.UseWaitCursor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(428, 16)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(84, 31)
        Me.btnTambah.TabIndex = 46
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        Me.btnTambah.UseWaitCursor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(428, 82)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(84, 31)
        Me.btnSimpan.TabIndex = 46
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.UseWaitCursor = True
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(164, 84)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(215, 22)
        Me.txtHarga.TabIndex = 53
        Me.txtHarga.UseWaitCursor = True
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(164, 112)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(215, 22)
        Me.txtStok.TabIndex = 53
        Me.txtStok.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.btnKembali)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtMenu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblKdBarang)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(15, 34)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(529, 159)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA ABRANG"
        Me.GroupBox1.UseWaitCursor = True
        '
        'FmODBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(565, 507)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FmODBarang"
        Me.Text = "FmODBarang"
        Me.UseWaitCursor = True
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGBarang As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents lblKdBarang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMenu As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

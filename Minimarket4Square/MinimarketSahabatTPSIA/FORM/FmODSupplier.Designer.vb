<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmODSupplier
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
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtTelpon = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtIdSupplier = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Orange
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(8, 16)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(52, 28)
        Me.btnKembali.TabIndex = 62
        Me.btnKembali.Text = "<<--"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(268, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 41)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "OLAH DATA SUPPLIER"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Navy
        Me.ListView1.Location = New System.Drawing.Point(-12, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(913, 94)
        Me.ListView1.TabIndex = 60
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(345, 223)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(129, 223)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 28)
        Me.btnSimpan.TabIndex = 58
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(237, 223)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 57
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(21, 223)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 28)
        Me.btnTambah.TabIndex = 56
        Me.btnTambah.Text = "TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(774, 223)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(100, 28)
        Me.btnCari.TabIndex = 55
        Me.btnCari.Text = "CARI"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(21, 259)
        Me.DGSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(860, 218)
        Me.DGSupplier.TabIndex = 54
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(517, 139)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(367, 62)
        Me.txtAlamat.TabIndex = 52
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(513, 227)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(251, 22)
        Me.txtCari.TabIndex = 51
        '
        'txtTelpon
        '
        Me.txtTelpon.Location = New System.Drawing.Point(183, 179)
        Me.txtTelpon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelpon.Name = "txtTelpon"
        Me.txtTelpon.Size = New System.Drawing.Size(155, 22)
        Me.txtTelpon.TabIndex = 50
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(183, 143)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(195, 22)
        Me.txtNama.TabIndex = 47
        '
        'txtIdSupplier
        '
        Me.txtIdSupplier.Enabled = False
        Me.txtIdSupplier.Location = New System.Drawing.Point(183, 105)
        Me.txtIdSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdSupplier.Name = "txtIdSupplier"
        Me.txtIdSupplier.Size = New System.Drawing.Size(135, 22)
        Me.txtIdSupplier.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(31, 179)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "TELPON"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(409, 147)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "ALAMAT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(31, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "NAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "ID SUPPLIER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(409, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "EMAIL"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(517, 107)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 22)
        Me.txtEmail.TabIndex = 47
        '
        'FmODSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 498)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtTelpon)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtIdSupplier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FmODSupplier"
        Me.Text = "FmODSupplier"
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents DGSupplier As DataGridView
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents txtTelpon As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtIdSupplier As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
End Class

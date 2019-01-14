<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmUtamaAdmin
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
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNamaAdminLogin = New System.Windows.Forms.Label()
        Me.TimerAdmin = New System.Windows.Forms.Timer(Me.components)
        Me.timer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Navy
        Me.ListView1.Location = New System.Drawing.Point(0, -1)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(542, 97)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Navy
        Me.ListView2.Location = New System.Drawing.Point(0, 192)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(596, 29)
        Me.ListView2.TabIndex = 0
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Swis721 Hv BT", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(195, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMIN"
        '
        'btnBarang
        '
        Me.btnBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.Location = New System.Drawing.Point(141, 111)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(121, 65)
        Me.btnBarang.TabIndex = 3
        Me.btnBarang.Text = "BARANG"
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'btnOperator
        '
        Me.btnOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOperator.Location = New System.Drawing.Point(268, 111)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(121, 65)
        Me.btnOperator.TabIndex = 3
        Me.btnOperator.Text = "OPERATOR"
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplier.Location = New System.Drawing.Point(396, 111)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(121, 65)
        Me.btnSupplier.TabIndex = 3
        Me.btnSupplier.Text = "SUPPLIER"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(14, 111)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(121, 65)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ADMIN"
        '
        'lblNamaAdminLogin
        '
        Me.lblNamaAdminLogin.AutoSize = True
        Me.lblNamaAdminLogin.BackColor = System.Drawing.Color.Navy
        Me.lblNamaAdminLogin.ForeColor = System.Drawing.Color.Yellow
        Me.lblNamaAdminLogin.Location = New System.Drawing.Point(66, 72)
        Me.lblNamaAdminLogin.Name = "lblNamaAdminLogin"
        Me.lblNamaAdminLogin.Size = New System.Drawing.Size(14, 13)
        Me.lblNamaAdminLogin.TabIndex = 4
        Me.lblNamaAdminLogin.Text = "~"
        '
        'timer
        '
        Me.timer.AutoSize = True
        Me.timer.BackColor = System.Drawing.Color.Navy
        Me.timer.ForeColor = System.Drawing.Color.Yellow
        Me.timer.Location = New System.Drawing.Point(463, 72)
        Me.timer.Name = "timer"
        Me.timer.Size = New System.Drawing.Size(29, 13)
        Me.timer.TabIndex = 5
        Me.timer.Text = "timer"
        '
        'FmUtamaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(533, 220)
        Me.Controls.Add(Me.timer)
        Me.Controls.Add(Me.lblNamaAdminLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnOperator)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FmUtamaAdmin"
        Me.Text = "FmUtamaAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnOperator As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNamaAdminLogin As Label
    Friend WithEvents TimerAdmin As Timer
    Friend WithEvents timer As Label
End Class

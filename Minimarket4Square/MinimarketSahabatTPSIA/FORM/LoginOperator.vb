Public Class LoginOperator
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = ControlLogin.LoginOperator(txtUsername.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasLogin.kodeOperator = DTGrid.Rows(0).Item(0)
            EntitasLogin.statusOperator = DTGrid.Rows(0).Item(4)
            EntitasLogin.usernameOperator = DTGrid.Rows(0).Item(5)
            EntitasLogin.passOperator = DTGrid.Rows(0).Item(6)


            If (EntitasLogin.statusOperator = "ADMIN") Then

                If txtPassword.Text = EntitasLogin.passOperator Then
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                    FmUtamaAdmin.Show()
                    FmUtamaAdmin.lblNamaAdminLogin.Text = EntitasLogin.kodeOperator

                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()


                End If

            ElseIf (EntitasLogin.statusOperator = "KASIR") Then

                If txtPassword.Text = EntitasLogin.passOperator Then
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    Me.Hide()
                    FmUtamaKasir.Show()
                    FmTransPenjualan.lblOperator.Text = EntitasLogin.kodeOperator

                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.Text = ""
                    txtUsername.Focus()
                End If
            End If
        ElseIf (EntitasLogin.statusOperator = "PEMILIK") Then

            If txtPassword.Text = EntitasLogin.passOperator Then
                txtUsername.Text = ""
                txtPassword.Text = ""
                Me.Hide()
                FmUtamaPemilik.Show()
            End If
        End If


    End Sub

End Class

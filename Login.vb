Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "Pahrurozi" And txtpass.Text = "Pahrurozi17" Then
            LatihanUTS.Show()
        Else
            MessageBox.Show("Username & Password Salah",
                            "Pesan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
Public Class KUIS
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

        If txtNama.Text = "Pahrurozi" Then
            lblNim.Text = "1901010238"
            lblJenjang.Text = "S1"
            lblJurusan.Text = "Ilmu Komputer"
        ElseIf txtNama.Text = "Wisnu Mahendra" Then
            lblNim.Text = "1901010239"
            lblJenjang.Text = "S1"
            lblJurusan.Text = "Sistem Informasi"
        ElseIf txtNama.Text = "Muhammad Zakaria" Then
            lblNim.Text = "1901010210"
            lblJenjang.Text = "S1"
            lblJurusan.Text = "Ilmu Farmasi"
        Else
            lblNim.Text = "Tidak ditemukan!"
            lblJenjang.Text = "Tidak ditemukan!"
            lblJurusan.Text = "Tidak ditemukan!"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNama.Text = ""
        lblNim.Text = ""
        lblJenjang.Text = ""
        lblJurusan.Text = ""
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim kehadiran, tugas, uts, uas As Double

        kehadiran = txtHadir.Text
        tugas = txtTugas.Text
        uts = txtUts.Text
        uas = txtUts.Text

        lblAkhir.Text = (kehadiran + tugas + uts + uas) / 4

        If lblAkhir.Text >= 90 Then
            lblGrade.Text = "A"
            lblKet.Text = "Sangat Baik"
        ElseIf lblAkhir.Text >= 80 Then
            lblGrade.Text = "B"
            lblKet.Text = "Baik"
        ElseIf lblAkhir.Text >= 70 Then
            lblGrade.Text = "C"
            lblGrade.Text = "Cukup"
        ElseIf lblAkhir.Text >= 50 Then
            lblGrade.Text = "D"
            lblKet.Text = "Kurang"
        Else
            lblGrade.Text = "E"
            lblKet.Text = "Sangat Kurang"
        End If
    End Sub

    Private Sub btnUlangi_Click(sender As Object, e As EventArgs) Handles btnUlangi.Click
        txtHadir.Text = ""
        txtTugas.Text = ""
        txtUts.Text = ""
        txtUas.Text = ""
        lblAkhir.Text = ""
        lblGrade.Text = ""
        lblKet.Text = ""
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        End
    End Sub
End Class

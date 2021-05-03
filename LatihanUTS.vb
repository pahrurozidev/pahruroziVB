Public Class LatihanUTS
    Private Sub cbnama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnama.SelectedIndexChanged
        Select Case cbnama.Text
            Case "Pahrurozi"
                txtnim.Text = "1901010238"
                txtjenjang.Text = "Strata 1"
                txtjurusan.Text = "Ilmu Komputer"
            Case "Muhammad Zakaria"
                txtnim.Text = "1901010237"
                txtjenjang.Text = "Diploma 3"
                txtjurusan.Text = "Teknik Fisika"
            Case "Titin Yustika"
                txtnim.Text = "1901010236"
                txtjenjang.Text = "Magister"
                txtjurusan.Text = "Teknik Kimia"
            Case "Hafif Nur Muhammad"
                txtnim.Text = "1901010235"
                txtjenjang.Text = "Master"
                txtjurusan.Text = "Programmer"
        End Select
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Dim kehadiran, tugas, uts, uas, akhir As Integer
        Dim Arr(2) As String
        kehadiran = txtkehadiran.Text
        tugas = txttugas.Text
        uts = txtuts.Text
        uas = txtuas.Text

        akhir = (kehadiran * 0.1) + (tugas * 0.2) + (uts * 0.3) + (uas * 0.4)

        If akhir >= 85 Then
            Arr(0) = akhir
            Arr(1) = "A"
            Arr(2) = "Lulus"
        ElseIf akhir >= 75 Then
            Arr(0) = akhir
            Arr(1) = "B"
            Arr(2) = "Lulus"
        ElseIf akhir >= 60 Then
            Arr(0) = akhir
            Arr(1) = "C"
            Arr(2) = "Lulus"
        ElseIf akhir >= 40 Then
            Arr(0) = akhir
            Arr(1) = "D"
            Arr(2) = "Gagal"
        ElseIf akhir >= 0 Then
            Arr(0) = akhir
            Arr(1) = "E"
            Arr(2) = "Gagal"
        End If

        Dim listItem As ListViewItem
        listItem = New ListViewItem
        listItem = ListView1.Items.Add(Arr(0))
        listItem.SubItems.Add(Arr(1))
        listItem.SubItems.Add(Arr(2))

        txtkehadiran.Text = ""
        txttugas.Text = ""
        txtuts.Text = ""
        txtuas.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtkehadiran.Text = ""
        txttugas.Text = ""
        txtuts.Text = ""
        txtuas.Text = ""
    End Sub

    Private Sub Latihan1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Nilai Akhir", 150)
        ListView1.Columns.Add("Grade", 170)
        ListView1.Columns.Add("Keterangan", 190)
    End Sub
End Class
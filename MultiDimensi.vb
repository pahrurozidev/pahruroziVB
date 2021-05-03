Public Class MultiDimensi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(3) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        arr(2) = ComboBox1.Text
        arr(3) = ComboBox2.Text

        Dim listItem As ListViewItem
        listItem = New ListViewItem
        listItem = ListView1.Items.Add(arr(0))
        listItem.SubItems.Add(arr(1))
        listItem.SubItems.Add(arr(2))
        listItem.SubItems.Add(arr(3))

        TextBox1.Text = TextBox1.Text + 1
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub MultiDimensi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "Nim"
        arr(0, 1) = "Nama"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Prodi"
        arr(2, 0) = "Laki laki"
        arr(2, 1) = "Perempuan"
        arr(3, 0) = "Sistem Informasi"
        arr(3, 1) = "Komputerisasi Akutansi"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For Baris = 0 To 1
            For Kolom = 0 To 1
                ListView1.Columns.Add(arr(Baris, Kolom), 100)
            Next
        Next

        For Baris = 2 To 2
            For Kolom = 0 To 1
                ComboBox1.Items.Add(arr(Baris, Kolom))
            Next
        Next

        For Baris = 3 To 3
            For Kolom = 0 To 1
                ComboBox2.Items.Add(arr(Baris, Kolom))
            Next
        Next
    End Sub
End Class
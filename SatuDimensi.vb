Public Class SatuDimensi
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Arr(2) As String
        Arr(0) = txtNim.Text
        Arr(1) = txtNama.Text
        Arr(2) = txtProdi.Text

        Dim listItem As ListViewItem
        listItem = New ListViewItem
        listItem = ListView.Items.Add(Arr(0))
        listItem.SubItems.Add(Arr(1))
        listItem.SubItems.Add(Arr(2))

        txtNim.Text = ""
        txtNama.Text = ""
        txtProdi.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub arrayList_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListView.GridLines = True
        ListView.View = View.Details
        ListView.Columns.Add("Nim", 70)
        ListView.Columns.Add("Nama", 90)
        ListView.Columns.Add("Prodi", 110)
        txtNim.Text = 1
        txtNama.Focus()
    End Sub
End Class
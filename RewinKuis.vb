Public Class form1
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "1901021075"
                TextBox1.Text = "Dinda Ayu"
                TextBox2.Text = "S1"
                TextBox3.Text = "Teknik Informatika"
            Case "1901021076"
                TextBox1.Text = "Ade Irma Suryanti"
                TextBox2.Text = "D-3"
                TextBox3.Text = "Sistem Informasi"
            Case "1901021077"
                TextBox1.Text = "Arya Rony"
                TextBox2.Text = "S1"
                TextBox3.Text = "Sistem Informasi"
            Case "1901021078"
                TextBox1.Text = "Abdul Muhammi"
                TextBox2.Text = "D-3"
                TextBox3.Text = "Sistem Informasi"
        End Select
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cb2, cb3, cb4, cb5 As Double
        cb2 = Val(ComboBox2.Text)
        cb3 = Val(ComboBox3.Text)
        cb4 = Val(ComboBox4.Text)
        cb5 = Val(ComboBox5.Text)

        TextBox4.Text = (cb2 + cb3 + cb4 + cb5) / 4

        If TextBox4.Text > 90 Then
            TextBox5.Text = "A"
            TextBox6.Text = "lulus"
        ElseIf TextBox4.Text > 75 Then
            TextBox5.Text = "B"
            TextBox6.Text = "baik"
        ElseIf TextBox4.Text > 50 Then
            TextBox5.Text = "C"
            TextBox6.Text = "cukup"
        ElseIf TextBox4.Text > 40 Then
            TextBox5.Text = "D"
            TextBox6.Text = "kurang"
        Else
            TextBox5.Text = "E"
            TextBox6.Text = "Tidak Lulus"

        End If
    End Sub

End Class
Public Class aritmatika
    Private Sub btPangkat_Click(sender As Object, e As EventArgs) Handles btPangkat.Click
        Dim HasilPangkat, na, np As Double
        na = txtAngkaPangkat.Text
        np = txtPangkat.Text
        HasilPangkat = na ^ np
        txtHasilPangkat.Text = HasilPangkat
    End Sub
    '' mendeklarasikan variable untuk hasil
    '' saya taruh disini agar fungsinya dibaca oleh seluruh class tombol
    Dim Hasil As String
    Private Sub btPembagi_Click(sender As Object, e As EventArgs) Handles btPembagi.Click
        Dim val1, val2 As Double
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 / val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub btModulus_Click(sender As Object, e As EventArgs) Handles btModulus.Click
        Dim val1, val2 As Double
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 Mod val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub btKurang_Click(sender As Object, e As EventArgs) Handles btKurang.Click
        Dim val1, val2 As Double
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 - val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub btTambah_Click(sender As Object, e As EventArgs) Handles btTambah.Click
        Dim val1, val2 As Double
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 + val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub btKali_Click(sender As Object, e As EventArgs) Handles btKali.Click
        Dim val1, val2 As Double
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 * val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub btString_Click(sender As Object, e As EventArgs) Handles btString.Click
        Dim val1, val2 As String
        val1 = txtValue1.Text
        val2 = txtValue2.Text
        Hasil = val1 & val2
        txtHasValue.Text = Hasil
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
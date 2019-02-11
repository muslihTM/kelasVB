Public Class logika
    Private Sub logika_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkval1.Text = "A"
        chkval2.Text = "B"
    End Sub

    Private Sub btHasil_Click(sender As Object, e As EventArgs) Handles btHasil.Click
        Dim A As Boolean = Me.chkval1.Checked
        Dim B As Boolean = Me.chkval2.Checked
        Dim sResult As String = ""
        sResult &= "A And B : " & (A And B) & vbCrLf
        sResult &= "A Or B : " & (A Or B) & vbCrLf
        sResult &= "Not (A And B): " & CStr(Not (A And B)) & vbCrLf
        sResult &= "A XOr B : " & (A Xor B) & vbCrLf
        sResult &= "A AndAlso B : " & (A AndAlso B) & vbCrLf
        sResult &= "A OrElse B : " & (A OrElse B) & vbCrLf

        Label2.Text = sResult
    End Sub
    '' Keterangan
    ''  vbCrLf adalah fungsi untuk membuat baris baru
    '' CStr adalah fungsi untuk Konversi ke string
End Class
Public Class pembanding
    Private Sub btHasil_Click(sender As Object, e As EventArgs) Handles btHasil.Click
        Dim a, b As Integer
        a = txtA.Text
        b = txtB.Text

        If a > b Then
            Label6.Text = "A:" & a & " Lebih besar dari B:" & b
        Else
            Label6.Text = "A:" & a & " Tidak lebih besar dari B:" & b
        End If

        If a < b Then
            Label7.Text = "A:" & a & " Lebih Kecil dari B:" & b
        Else
            Label7.Text = "A:" & a & " Tidak lebih Kecil dari B:" & b
        End If

        If a = b Then
            Label8.Text = "A:" & a & " Bernilai sama dengan B:" & b
        Else
            Label8.Text = "A:" & a & " Tidak Sama dengan B:" & b
        End If
    End Sub
End Class
Public Class Input5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As Integer
        Dim Hasil As Integer
        X = T_1.Text
        Hasil = 2 * (X * X) - (4 * X) + 1
        T_Hasil.Text = Hasil
    End Sub
End Class
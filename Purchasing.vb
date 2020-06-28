Public Class Purchasing
    Private Sub Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pesan In clsPemesanan.database
            ComboBox1.Items.Add(pesan.kode)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim simpan As New Purchase(txtpurchasing.Text, badansp.Text, pintusp.Text, rodasp.Text, kursisp.Text, mesinsp.Text,
badansd.Text, pintusd.Text, rodasd.Text, kursisd.Text, mesinsd.Text, sport.Text, sedan.Text, total.Text)
        simpan.savedata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
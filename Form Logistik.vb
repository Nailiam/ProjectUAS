Public Class Form_Logistik
    Private Sub Form_Logistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pesan In clsPemesanan.database
            ComboBox1.Items.Add(pesan.kode)
        Next
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex.Equals(0)) Then
            For Each pesan In clsPemesanan.database
                txtsedan.Text = clsPemesanan.database(0).mobilsedan
                txtsport.Text = clsPemesanan.database(0).mobilsport
            Next
        End If
        If (ComboBox1.SelectedIndex.Equals(1)) Then
            For Each pesan In clsPemesanan.database
                txtsedan.Text = clsPemesanan.database(1).mobilsedan
                txtsport.Text = clsPemesanan.database(1).mobilsport
            Next
        End If
        If (ComboBox1.SelectedIndex.Equals(2)) Then
            For Each pesan In clsPemesanan.database
                txtsedan.Text = clsPemesanan.database(2).mobilsedan
                txtsport.Text = clsPemesanan.database(2).mobilsport
            Next
        End If
    End Sub

    Private Sub btnkirim_Click(sender As Object, e As EventArgs) Handles btnkirim.Click
        Dim kirim As New clsLogistik(txtsedan.Text, txtsport.Text)
        kirim.savedata()
    End Sub
End Class
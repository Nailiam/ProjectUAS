Public Class BOM
    Private Sub BOM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtpintusp.Text = Convert.ToInt32(txtsport.Text) * 2
        txtbadansp.Text = Convert.ToInt32(txtsport.Text)
        txtrodasp.Text = Convert.ToInt32(txtsport.Text) * 4
        txtkursisp.Text = Convert.ToInt32(txtsport.Text) * 2
        txtmesinsp.Text = Convert.ToInt32(txtsport.Text)
        txtpintusd.Text = Convert.ToInt32(txtsedan.Text) * 4
        txtbadansd.Text = Convert.ToInt32(txtsedan.Text)
        txtrodasd.Text = Convert.ToInt32(txtsedan.Text) * 4
        txtkursisd.Text = Convert.ToInt32(txtsedan.Text) * 4
        txtmesinsd.Text = Convert.ToInt32(txtsedan.Text)
    End Sub
End Class
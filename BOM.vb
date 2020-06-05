Public Class BOM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalsport As Integer = 0
        Dim totalsedan As Integer = 0
        Dim pintusp, badansp, rodasp, kursisp, mesinsp As Integer
        Dim pintusd, badansd, rodasd, kursisd, mesinsd As Integer
        For Each pesan In clsPemesanan.database
            totalsport = totalsport + pesan.mobilsport
            totalsedan = totalsedan + pesan.mobilsedan
            pintusp = totalsport * 2
            badansp = totalsport
            rodasp = totalsport * 4
            kursisp = totalsport * 2
            mesinsp = totalsport
            pintusd = totalsedan * 4
            badansd = totalsedan
            rodasd = totalsedan * 4
            kursisd = totalsedan * 5
            mesinsd = totalsedan
        Next
        txtpintusp.Text = pintusp
        txtbadansp.Text = badansp
        txtrodasp.Text = rodasp
        txtkursisp.Text = kursisp
        txtmesinsp.Text = mesinsp
        txtpintusd.Text = pintusd
        txtbadansd.Text = badansd
        txtrodasd.Text = rodasd
        txtkursisd.Text = kursisd
        txtmesinsd.Text = mesinsd
        txtsport.Text = totalsport
        txtsedan.Text = totalsedan
    End Sub
End Class
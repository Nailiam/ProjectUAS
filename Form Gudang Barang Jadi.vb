Public Class Form_Gudang_Barang_Jadi
    Private Stok As New Menu_Utama
    Dim jumlahsedan As Integer
    Dim jumlahsport As Integer
    Private Sub Btnstok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstok.Click
        For Each save In produksi2.database
            Stok.Sport_masuk1 = jumlahsport
            Stok.Sedan_masuk1 = jumlahsedan
        Next
        For Each kirim In clsLogistik.database
            Stok.Sport_keluar1 = kirim.jmlsport
            Stok.Sedan_keluar1 = kirim.jmlsedan
        Next
        Stok.Stok_sport1 = Stok.Sport_masuk1 - Stok.Sport_keluar1
        Stok.Stok_sedan1 = Stok.Sedan_masuk1 - Stok.Sedan_keluar1

        ListView1.Items.Add(New ListViewItem(New String() {Stok.Stok_sedan1, Stok.Stok_sport1}))
    End Sub

    Private Sub Btninfomasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfomasuk.Click
        For Each pesan In clsPemesanan.database
            jumlahsedan = clsPemesanan.database(0).mobilsedan + clsPemesanan.database(1).mobilsedan + clsPemesanan.database(2).mobilsedan
            jumlahsport = clsPemesanan.database(0).mobilsport + clsPemesanan.database(1).mobilsport + clsPemesanan.database(2).mobilsport
        Next
        ListView2.Items.Add(New ListViewItem(New String() {jumlahsedan, jumlahsport}))
    End Sub

    Private Sub Btninfokeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfokeluar.Click
        For Each kirim In clsLogistik.database
            ListView3.Items.Add(New ListViewItem(New String() {kirim.jmlsedan, kirim.jmlsport}))
        Next
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Menu_Utama.Show()
        Me.Close()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Form_Logistik.Show()
        Me.Close()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form_Produksi.Show()
        Me.Close()
    End Sub
End Class
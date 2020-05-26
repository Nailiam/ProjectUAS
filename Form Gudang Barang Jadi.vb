Public Class Form_Gudang_Barang_Jadi
    Private GudangBJ As New Menu_Utama
    Private Sub Btnstok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstok.Click
        GudangBJ.Stok_badan = GudangBJ.Stok_badan + GudangBJ.Pro_badan - GudangBJ.Log_badan
        GudangBJ.Stok_pintu = GudangBJ.Stok_pintu + GudangBJ.Pro_pintu - GudangBJ.Log_pintu
        GudangBJ.Stok_roda = GudangBJ.Stok_roda + GudangBJ.Pro_roda - GudangBJ.Log_roda
        GudangBJ.Stok_kursi = GudangBJ.Stok_kursi + GudangBJ.Pro_kursi - GudangBJ.Log_kursi
        GudangBJ.Stok_mesin = GudangBJ.Stok_mesin + GudangBJ.Pro_mesin - GudangBJ.Log_mesin
        ListView1.Items.Add(New ListViewItem(New String() {GudangBJ.Stok_badan, GudangBJ.Stok_pintu, GudangBJ.Stok_roda, GudangBJ.Stok_kursi, GudangBJ.Stok_mesin}))
    End Sub

    Private Sub Btninfomasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfomasuk.Click
        ListView1.Items.Add(New ListViewItem(New String() {GudangBJ.Pro_badan, GudangBJ.Pro_pintu, GudangBJ.Pro_roda, GudangBJ.Pro_kursi, GudangBJ.Pro_mesin}))
    End Sub

    Private Sub Btninfokeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfokeluar.Click
        ListView1.Items.Add(New ListViewItem(New String() {GudangBJ.Log_badan, GudangBJ.Log_pintu, GudangBJ.Log_roda, GudangBJ.Log_kursi, GudangBJ.Log_mesin}))
    End Sub
End Class
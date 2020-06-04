Public Class Form_Gudang_Barang_Jadi
    Private GudangBJ As New Menu_Utama
    Private Sub Btnstok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstok.Click
        GudangBJ.Stok_badan1 = GudangBJ.Stok_badan1 + GudangBJ.Pro_badan1 - GudangBJ.Log_badan1
        GudangBJ.Stok_pintu1 = GudangBJ.Stok_pintu1 + GudangBJ.Pro_pintu1 - GudangBJ.Log_pintu1
        GudangBJ.Stok_roda1 = GudangBJ.Stok_roda1 + GudangBJ.Pro_roda1 - GudangBJ.Log_roda1
        GudangBJ.Stok_kursi1 = GudangBJ.Stok_kursi1 + GudangBJ.Pro_kursi1 - GudangBJ.Log_kursi1
        GudangBJ.Stok_mesin1 = GudangBJ.Stok_mesin1 + GudangBJ.Pro_mesin1 - GudangBJ.Log_mesin1
        ListView1.Items.Add(New ListViewItem(New String() {GudangBJ.Stok_badan1, GudangBJ.Stok_pintu1, GudangBJ.Stok_roda1, GudangBJ.Stok_kursi1, GudangBJ.Stok_mesin1}))
    End Sub

    Private Sub Btninfomasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfomasuk.Click
        ListView2.Items.Add(New ListViewItem(New String() {GudangBJ.Pro_badan1, GudangBJ.Pro_pintu1, GudangBJ.Pro_roda1, GudangBJ.Pro_kursi1, GudangBJ.Pro_mesin1}))
    End Sub

    Private Sub Btninfokeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfokeluar.Click
        ListView3.Items.Add(New ListViewItem(New String() {GudangBJ.Log_badan1, GudangBJ.Log_pintu1, GudangBJ.Log_roda1, GudangBJ.Log_kursi1, GudangBJ.Log_mesin1}))
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        Menu_Utama.Show()
        Me.Close()
    End Sub
End Class
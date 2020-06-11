Public Class Form_Gudang_Barang_Jadi

    Private Sub Btnstok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnstok.Click

        ListView1.Items.Add(New ListViewItem(New String() {}))
    End Sub

    Private Sub Btninfomasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninfomasuk.Click
        For Each pesan In clsPemesanan.database
            ListView2.Items.Add(New ListViewItem(New String() {pesan.mobilsedan, pesan.mobilsport}))
        Next
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
End Class
Public Class mobil_sedan
    Inherits Produksi
    Public Function produksikerangkabadan(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsedan
        Next
        produksikerangkabadan = Form_Produksi.Pro_badan.Text
        Return (jumlah_produksi * 1)
    End Function
    Public Function produksikerangkapintu(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsedan
        Next
        produksikerangkapintu = Form_Produksi.Pro_pintu.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksiroda(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsedan
        Next
        produksiroda = Form_Produksi.Pro_roda.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksikursi(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsedan
        Next
        produksikursi = Form_Produksi.Pro_kursi.Text
        Return (jumlah_produksi * 5)
    End Function
    Public Function produksimesin(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsedan
        Next
        produksimesin = Form_Produksi.Pro_mesin.Text
        Return (jumlah_produksi * 1)
    End Function
End Class

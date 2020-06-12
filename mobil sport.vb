Public Class mobil_sport
    Inherits Produksi
    Public Function produksikerangkabadan1(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsport
        Next
        produksikerangkabadan1 = Form_Produksi.txtbadansport.Text
        Return (jumlah_produksi * 1)
    End Function
    Public Function produksikerangkapintu1(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsport
        Next
        produksikerangkapintu1 = Form_Produksi.txtpintusport.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksiroda1(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsport
        Next
        produksiroda1 = Form_Produksi.txtrodasport.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksikursi1(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsport
        Next
        produksikursi1 = Form_Produksi.txtkursisport.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksimesin1(ByVal jumlah_produksi As Integer) As String
        For Each pesan In clsPemesanan.database
            jumlah_produksi = pesan.mobilsport
        Next
        produksimesin1 = Form_Produksi.txtmesinsport.Text
        Return (jumlah_produksi * 1)
    End Function
End Class

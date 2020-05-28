Public Class mobil_sedan
    Inherits Produksi
    Public Function produksikerangkabadan(ByVal jumlah_produksi As Integer) As Integer
        produksikerangkabadan = Form_Produksi.Pro_badan.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 1)
    End Function
    Public Function produksikerangkapintu(ByVal jumlah_produksi As Integer) As Integer
        produksikerangkapintu = Form_Produksi.Pro_pintu.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksiroda(ByVal jumlah_produksi As Integer) As Integer
        produksiroda = Form_Produksi.Pro_roda.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksikursi(ByVal jumlah_produksi As Integer) As Integer
        produksikursi = Form_Produksi.Pro_kursi.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 5)
    End Function
    Public Function produksimesin(ByVal jumlah_produksi As Integer) As Integer
        produksimesin = Form_Produksi.Pro_mesin.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 1)
    End Function
End Class

Public Class mobil_sport
    Inherits Produksi
    Public Function produksikerangkabadan1(ByVal jumlah_produksi As Integer) As String
        produksikerangkabadan1 = Form_Produksi.Pro_badan.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 1)
    End Function
    Public Function produksikerangkapintu1(ByVal jumlah_produksi As Integer) As String
        produksikerangkapintu1 = Form_Produksi.Pro_pintu.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksiroda1(ByVal jumlah_produksi As Integer) As String
        produksiroda1 = Form_Produksi.Pro_roda.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksikursi1(ByVal jumlah_produksi As Integer) As String
        produksikursi1 = Form_Produksi.Pro_kursi.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksimesin1(ByVal jumlah_produksi As Integer) As String
        produksimesin1 = Form_Produksi.Pro_mesin.Text
        jumlah_produksi = Form_Produksi.txtjumlah.Text
        Return (jumlah_produksi * 1)
    End Function
End Class

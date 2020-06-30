Public Class mobil_sport
    Inherits Produksi
    Public Function produksikerangkabadan1(ByVal jumlah_produksi As Integer) As String
        jumlah_produksi = Form_Produksi.txtjmlsport.Text
        produksikerangkabadan1 = Form_Produksi.txtbadansport.Text
        Return (jumlah_produksi * 1)
    End Function
    Public Function produksikerangkapintu1(ByVal jumlah_produksi As Integer) As String
        jumlah_produksi = Form_Produksi.txtjmlsport.Text
        produksikerangkapintu1 = Form_Produksi.txtpintusport.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksiroda1(ByVal jumlah_produksi As Integer) As String
        jumlah_produksi = Form_Produksi.txtjmlsport.Text
        produksiroda1 = Form_Produksi.txtrodasport.Text
        Return (jumlah_produksi * 4)
    End Function
    Public Function produksikursi1(ByVal jumlah_produksi As Integer) As String
        jumlah_produksi = Form_Produksi.txtjmlsport.Text
        produksikursi1 = Form_Produksi.txtkursisport.Text
        Return (jumlah_produksi * 2)
    End Function
    Public Function produksimesin1(ByVal jumlah_produksi As Integer) As String
        jumlah_produksi = Form_Produksi.txtjmlsport.Text
        produksimesin1 = Form_Produksi.txtmesinsport.Text
        Return (jumlah_produksi * 1)
    End Function
End Class

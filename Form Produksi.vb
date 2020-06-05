Public Class Form_Produksi
    Dim tanggalproduksi As DateTime
    Dim jenismobil As String
    Dim jumlah As Integer, stokkerangkabadan As Integer, stokkerangkapintu As Integer, stokroda As Integer, stokkursi As Integer, stokmesin As Integer

    Dim gudangbarangjadi As Form_Gudang_Barang_Jadi = New Form_Gudang_Barang_Jadi
    Dim gudangbahanbaku As Gudang_bahan_baku = New Gudang_bahan_baku
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form_Gudang_Barang_Jadi.Show()
    End Sub

    Private Sub Form_Produksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Menu_Utama.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Gudang_bahan_baku.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox1.Text = "mobil sport" Then
            Dim objmobilsport As New mobil_sport
            Dim jumlah_produksi As Integer
            For Each pesan In clsPemesanan.database
                jumlah_produksi = pesan.mobilsport
            Next
            txtjumlah.Text = jumlah_produksi
            With objmobilsport
                .mjenis_mobil = ComboBox1.Text
                Pro_badan.Text = .produksikerangkabadan1(.mjumlah_produksi)
                Pro_pintu.Text = .produksikerangkapintu1(.mjumlah_produksi)
                Pro_roda.Text = .produksiroda1(.mjumlah_produksi)
                Pro_kursi.Text = .produksikursi1(.mjumlah_produksi)
                Pro_mesin.Text = .produksimesin1(.mjumlah_produksi)
            End With
        Else
            Dim objmobilsedan As New mobil_sedan
            Dim jumlah_produksi As Integer
            For Each pesan In clsPemesanan.database
                jumlah_produksi = pesan.mobilsedan
            Next
            txtjumlah.Text = jumlah_produksi
            With objmobilsedan
                .mjenis_mobil = ComboBox1.Text
                Pro_badan.Text = .produksikerangkabadan(.mjumlah_produksi)
                Pro_pintu.Text = .produksikerangkapintu(.mjumlah_produksi)
                Pro_roda.Text = .produksiroda(.mjumlah_produksi)
                Pro_kursi.Text = .produksikursi(.mjumlah_produksi)
                Pro_mesin.Text = .produksimesin(.mjumlah_produksi)
            End With
        End If
    End Sub
End Class
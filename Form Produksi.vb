Public Class Form_Produksi
    Dim tanggalproduksi As DateTime
    Dim jenismobil As String
    Dim jumlah As Integer, stokkerangkabadan As Integer, stokkerangkapintu As Integer, stokroda As Integer, stokkursi As Integer, stokmesin As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim save As New produksi2(txtjumlahsedan.Text, txtjmlsport.Text)
        save.savedata()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex.Equals(0)) Then
            For Each pesan In clsPemesanan.database
                txtjumlahsedan.Text = clsPemesanan.database(0).mobilsedan
                txtjmlsport.Text = clsPemesanan.database(0).mobilsport
            Next
        End If
        If (ComboBox1.SelectedIndex.Equals(1)) Then
            For Each pesan In clsPemesanan.database
                txtjumlahsedan.Text = clsPemesanan.database(1).mobilsedan
                txtjmlsport.Text = clsPemesanan.database(1).mobilsport
            Next
        End If
        If (ComboBox1.SelectedIndex.Equals(2)) Then
            For Each pesan In clsPemesanan.database
                txtjumlahsedan.Text = clsPemesanan.database(2).mobilsedan
                txtjmlsport.Text = clsPemesanan.database(2).mobilsport
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim statuspemesanan As String
        For Each pesan In clsPemesanan.database
            statuspemesanan = "Dalam Proses"
            ListView1.Items.Add(New ListViewItem(New String() {ComboBox1.Text, statuspemesanan}))
        Next
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form_Gudang_Barang_Jadi.Show()
    End Sub

    Private Sub Form_Produksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each pesan In clsPemesanan.database
            ComboBox1.Items.Add(pesan.kode)
        Next
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Gudang_bahan_baku.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sedan As New mobil_sedan
        With sedan
            Pro_badan.Text = .produksikerangkabadan(.mjumlah_produksi)
            Pro_pintu.Text = .produksikerangkapintu(.mjumlah_produksi)
            Pro_roda.Text = .produksiroda(.mjumlah_produksi)
            Pro_kursi.Text = .produksikursi(.mjumlah_produksi)
            Pro_mesin.Text = .produksimesin(.mjumlah_produksi)
        End With
        Dim sport As New mobil_sport
        With sport
            txtbadansport.Text = .produksikerangkabadan1(.mjumlah_produksi)
            txtpintusport.Text = .produksikerangkapintu1(.mjumlah_produksi)
            txtrodasport.Text = .produksiroda1(.mjumlah_produksi)
            txtkursisport.Text = .produksikursi1(.mjumlah_produksi)
            txtmesinsport.Text = .produksimesin1(.mjumlah_produksi)
        End With
    End Sub
End Class
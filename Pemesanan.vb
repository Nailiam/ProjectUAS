Public Class Pemesanan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan As New clsPemesanan(txtkode.Text, txtnama.Text, txtalamat.Text, txtsport.Text, txtsedan.Text)
        pesan.savedata()
        ListView1.Items.Clear()
        For Each pesan In clsPemesanan.database
            Dim tanggalproduksi As DateTime
            tanggalproduksi = DateTimePicker1.Text
            ListView1.Items.Add(New ListViewItem({tanggalproduksi, pesan.kode, pesan.nama, pesan.alamat, pesan.mobilsport, pesan.mobilsedan}))
        Next
    End Sub
    Private Sub Pemesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        BOM.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtkode.Clear()
        txtnama.Clear()
        txtalamat.Clear()
        txtsport.Clear()
        txtsedan.Clear()
    End Sub
End Class
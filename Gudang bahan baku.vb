Public Class Gudang_bahan_baku
    Public bahanbaku As New clsbaku
    Private Sub tmplknmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmplknmasuk.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stokbadan As Integer = 50
        Dim stokpintu As Integer = 50
        Dim stokroda As Integer = 50
        Dim stokkursi As Integer = 50
        Dim stokmesin As Integer = 50
        For Each save In produksi2.database
            ListView3.Items.Add(New ListViewItem(New String() {stokbadan, stokpintu, stokroda, stokkursi, stokmesin}))
        Next
    End Sub

    Private Sub tmplknkeluar_Click(sender As Object, e As EventArgs) Handles tmplknkeluar.Click
        For Each save In produksi2.database
            Dim tanggalproduksi As DateTime
            Dim badan As Integer
            Dim mesin As Integer
            Dim kursi As Integer
            Dim roda As Integer
            Dim pintu As Integer
            tanggalproduksi = Form_Produksi.DateTimePicker1.Text
            badan = save.badansport1 + save.badansedan1
            mesin = save.mesinsport1 + save.mesinsedan1
            kursi = save.kursisport1 + save.kursisedan1
            roda = save.rodasport1 + save.rodasedan1
            pintu = save.pintusport1 + save.pintusedan1
            ListView2.Items.Add(New ListViewItem(New String() {tanggalproduksi, badan, mesin, kursi, roda, pintu}))
        Next
    End Sub
End Class

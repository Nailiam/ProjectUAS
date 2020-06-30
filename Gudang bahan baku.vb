Public Class Gudang_bahan_baku
    Dim badan As Integer = 3
    Dim pintu As Integer = 5
    Dim roda As Integer = 5
    Dim kursi As Integer = 5
    Dim mesin As Integer = 2
    Dim badan1 As Integer = 3
    Dim pintu1 As Integer = 5
    Dim roda1 As Integer = 5
    Dim kursi1 As Integer = 5
    Dim mesin1 As Integer = 2
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim baku As New clsbaku(stokbadansp.Text, stokpintusp.Text, stokrodasp.Text, stokkursisp.Text, stokmesinsp.Text,
       stokbadansd.Text, stokpintusd.Text, stokrodasd.Text, stokkursisd.Text, stokmesinsd.Text,
       krgbadansp.Text, krgpintusp.Text, krgrodasp.Text, krgkursisp.Text, krgmesinsp.Text,
       krgbadansd.Text, krgpintusd.Text, krgrodasd.Text, krgkursisd.Text, krgmesinsd.Text)
        baku.savedata()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each simpan In Purchase.database
            ListView1.Items.Add(New ListViewItem(New String() {simpan.badansport2, simpan.pintusport2, simpan.rodasport2,
                                                 simpan.kursisport2, simpan.mesinsport2, simpan.badansedan2, simpan.pintusedan2,
                                                 simpan.rodasedan2, simpan.kursisedan2, simpan.mesinsedan2}))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        stokbadansp.Text = badan
        stokpintusp.Text = pintu
        stokrodasp.Text = roda
        stokkursisp.Text = kursi
        stokmesinsp.Text = mesin
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        stokbadansd.Text = badan1
        stokpintusd.Text = pintu1
        stokrodasd.Text = roda1
        stokkursisd.Text = kursi1
        stokmesinsd.Text = mesin1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each sv In clsbom.databasebom
            If sv.badansport <= (badan) Then
                krgbadansp.Text = 0
            Else
                krgbadansp.Text = sv.badansport - badan
            End If
            If sv.pintusport <= pintu Then
                krgpintusp.Text = 0
            Else
                krgpintusp.Text = sv.pintusport - pintu
            End If
            If sv.rodasport <= roda Then
                krgrodasp.Text = 0
            Else
                krgrodasp.Text = sv.rodasport - roda
            End If
            If sv.kursisport <= kursi Then
                krgkursisp.Text = 0
            Else
                krgkursisp.Text = sv.kursisport - kursi
            End If
            If sv.mesinsport <= mesin Then
                krgmesinsp.Text = 0
            Else
                krgmesinsp.Text = sv.mesinsport - mesin
            End If
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each sv In clsbom.databasebom
            If sv.badansedan <= badan1 Then
                krgbadansd.Text = 0
            Else
                krgbadansd.Text = sv.badansedan - badan1
            End If
            If sv.pintusedan <= pintu1 Then
                krgpintusd.Text = 0
            Else
                krgpintusd.Text = sv.pintusedan - pintu1
            End If
            If sv.rodasedan <= roda1 Then
                krgrodasd.Text = 0
            Else
                krgrodasd.Text = sv.rodasedan - roda1
            End If
            If sv.kursisedan <= kursi1 Then
                krgkursisd.Text = 0
            Else
                krgkursisd.Text = sv.kursisedan - kursi1
            End If
            If sv.mesinsedan <= mesin1 Then
                krgmesinsd.Text = 0
            Else
                krgmesinsd.Text = sv.mesinsedan - mesin1
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim badan2 As Integer
        Dim pintu2 As Integer
        Dim roda2 As Integer
        Dim kursi2 As Integer
        Dim mesin2 As Integer
        Dim badan3 As Integer
        Dim pintu3 As Integer
        Dim roda3 As Integer
        Dim kursi3 As Integer
        Dim mesin3 As Integer
        For Each sv In clsbom.databasebom '
            badan2 = sv.badansport
            pintu2 = sv.pintusport
            roda2 = sv.rodasport
            kursi2 = sv.kursisport
            mesin2 = sv.mesinsport
        Next
        For Each simpan In Purchase.database
            badan3 = simpan.badansport2 + badan
            pintu3 = simpan.pintusport2 + pintu
            roda3 = simpan.rodasport2 + roda
            kursi3 = simpan.kursisport2 + kursi
            mesin3 = simpan.mesinsport2 + mesin
        Next
        stokbadansp.Text = badan3 - badan2
        stokpintusp.Text = pintu3 - pintu2
        stokrodasp.Text = roda3 - roda2
        stokkursisp.Text = kursi3 - kursi2
        stokmesinsp.Text = mesin3 - mesin2
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each save In produksi2.database
            Dim tanggalproduksi As String
            tanggalproduksi = Form_Produksi.DateTimePicker1.Text
            ListView2.Items.Add(New ListViewItem(New String() {tanggalproduksi, save.badansport1, save.pintusport1, save.rodasport1,
                                                 save.kursisport1, save.mesinsport1, save.badansedan1, save.pintusedan1,
                                                 save.rodasedan1, save.kursisedan1, save.mesinsedan1}))
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form_Produksi.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Purchasing.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim badan4 As Integer
        Dim pintu4 As Integer
        Dim roda4 As Integer
        Dim kursi4 As Integer
        Dim mesin4 As Integer
        Dim badan5 As Integer
        Dim pintu5 As Integer
        Dim roda5 As Integer
        Dim kursi5 As Integer
        Dim mesin5 As Integer
        For Each sv In clsbom.databasebom '
            badan4 = sv.badansedan
            pintu4 = sv.pintusedan
            roda4 = sv.rodasedan
            kursi4 = sv.kursisedan
            mesin4 = sv.mesinsedan
        Next
        For Each simpan In Purchase.database
            badan5 = simpan.badansedan2 + badan1
            pintu5 = simpan.pintusedan2 + pintu1
            roda5 = simpan.rodasedan2 + roda1
            kursi5 = simpan.kursisedan2 + kursi1
            mesin5 = simpan.mesinsedan2 + mesin1
        Next
        stokbadansd.Text = badan5 - badan4
        stokpintusd.Text = pintu5 - pintu4
        stokrodasd.Text = roda5 - roda4
        stokkursisd.Text = kursi5 - kursi4
        stokmesinsd.Text = mesin5 - mesin4
    End Sub
End Class

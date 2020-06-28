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

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each save In produksi2.database
            Dim tanggalproduksi As DateTime
            tanggalproduksi = Form_Produksi.DateTimePicker1.Text
            ListView2.Items.Add(New ListViewItem(New String() {tanggalproduksi, save.badansport1, save.pintusport1, save.rodasport1,
                                                 save.kursisport1, save.mesinsport1, save.badansedan1, save.pintusedan1,
                                                 save.rodasedan1, save.kursisedan1, save.mesinsedan1}))
        Next
    End Sub
End Class

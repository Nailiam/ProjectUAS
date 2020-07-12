Public Class Purchasing
    Dim safetystok As Integer = 2
    Private Sub Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each pesan In clsPemesanan.database
            ComboBox1.Items.Add(pesan.kode)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim simpan As New Purchase(txtpurchasing.Text, badansp.Text, pintusp.Text, rodasp.Text, kursisp.Text, mesinsp.Text,
badansd.Text, pintusd.Text, rodasd.Text, kursisd.Text, mesinsd.Text, sport.Text, sedan.Text, total.Text)
        simpan.savedata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim badan As Integer
        Dim pintu As Integer
        Dim roda As Integer
        Dim kursi As Integer
        Dim mesin As Integer
        Dim badan1 As Integer
        Dim pintu1 As Integer
        Dim roda1 As Integer
        Dim kursi1 As Integer
        Dim mesin1 As Integer
        For Each sv In clsbom.databasebom
            badan = sv.badansport
            pintu = sv.pintusport
            roda = sv.rodasport
            kursi = sv.kursisport
            mesin = sv.mesinsport
        Next
        badan1 = Gudang_bahan_baku.stokbadansp.Text
        pintu1 = Gudang_bahan_baku.stokpintusp.Text
        roda1 = Gudang_bahan_baku.stokrodasp.Text
        kursi1 = Gudang_bahan_baku.stokkursisp.Text
        mesin1 = Gudang_bahan_baku.stokmesinsp.Text
        badansp.Text = (badan - badan1) + safetystok
        pintusp.Text = (pintu - pintu1) + safetystok
        rodasp.Text = (roda - roda1) + safetystok
        kursisp.Text = (kursi - kursi1) + safetystok
        mesinsp.text=(mesin-mesin1) + safetystok
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
        For Each sv In clsbom.databasebom
            badan2 = sv.badansedan
            pintu2 = sv.pintusedan
            roda2 = sv.rodasedan
            kursi2 = sv.kursisedan
            mesin2 = sv.mesinsedan
        Next
        badan3 = Gudang_bahan_baku.stokbadansd.Text
        pintu3 = Gudang_bahan_baku.stokpintusd.Text
        roda3 = Gudang_bahan_baku.stokrodasd.Text
        kursi3 = Gudang_bahan_baku.stokkursisd.Text
        mesin3 = Gudang_bahan_baku.stokmesinsd.Text
        badansd.Text = (badan2 - badan3) + safetystok
        pintusd.Text = (pintu2 - pintu3) + safetystok
        rodasd.Text = (roda2 - roda3) + safetystok
        kursisd.Text = (kursi2 - kursi3) + safetystok
        mesinsd.Text = (mesin2 - mesin3) + safetystok
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mobilsport As Integer
        Dim mobilsedan As Integer
        Dim totalbiaya As Integer
        mobilsport = (badansp.Text * lblsport.Text) + (pintusp.Text * lblsport1.Text) + (rodasp.Text * lblsport2.Text) + (kursisp.Text * lblsport3.Text) + (mesinsp.Text * lblsport4.Text)
        mobilsedan = (badansd.Text * lblsedan.Text) + (pintusd.Text * lblsedan1.Text) + (rodasd.Text * lblsedan2.Text) + (kursisd.Text * lblsedan3.Text) + (mesinsd.Text * lblsedan4.Text)
        totalbiaya = mobilsport + mobilsedan
        sport.Text = mobilsport
        sedan.Text = mobilsedan
        total.Text = totalbiaya
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Gudang_bahan_baku.Show()
        Me.Close()
    End Sub
End Class
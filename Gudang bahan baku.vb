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
            krgbadansp.Text = badan - sv.badansport
            krgpintusp.Text = pintu - sv.pintusport
            krgrodasp.Text = roda - sv.rodasport
            krgkursisp.Text = kursi - sv.kursisport
            krgmesinsp.Text = mesin - sv.mesinsport
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each sv In clsbom.databasebom
            krgbadansd.Text = badan1 - sv.badansedan
            krgpintusd.Text = pintu1 - sv.pintusedan
            krgrodasd.Text = roda1 - sv.rodasedan
            krgkursisd.Text = kursi1 - sv.kursisedan
            krgmesinsd.Text = mesin1 - sv.mesinsedan
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class

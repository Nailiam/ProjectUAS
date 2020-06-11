Public Class Menu_Utama
    Dim Pro_badan, Pro_pintu, Pro_kursi, Pro_roda, Pro_mesin As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_Produksi.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_Gudang_Barang_Jadi.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pemesanan.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form_Logistik.Show()
    End Sub



    Public Property Pro_badan1 As Integer
        Get
            Return Pro_badan
        End Get
        Set(ByVal value As Integer)
            Pro_badan = value
        End Set
    End Property

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BOM.Show()
    End Sub

    Public Property Pro_pintu1 As Integer
        Get
            Return Pro_pintu
        End Get
        Set(ByVal value As Integer)
            Pro_pintu = value
        End Set
    End Property

    Public Property Pro_roda1 As Integer
        Get
            Return Pro_roda
        End Get
        Set(ByVal value As Integer)
            Pro_roda = value
        End Set
    End Property

    Public Property Pro_kursi1 As Integer
        Get
            Return Pro_kursi
        End Get
        Set(ByVal value As Integer)
            Pro_kursi = value
        End Set
    End Property

    Public Property Pro_mesin1 As Integer
        Get
            Return Pro_mesin
        End Get
        Set(ByVal value As Integer)
            Pro_mesin = value
        End Set
    End Property
End Class


Public Class Menu_Utama
    Dim Pro_badan, Pro_pintu, Pro_kursi, Pro_roda, Pro_mesin, Stok_badan, Stok_pintu, Stok_roda, Stok_kursi, Stok_mesin, Log_badan, Log_pintu, Log_roda, Log_kursi, Log_mesin As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_Produksi.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form_Gudang_Barang_Jadi.Show()
    End Sub
    Public Property Stok_badan1 As Integer
        Get
            Return Stok_badan
        End Get
        Set(ByVal value As Integer)
            Stok_badan = value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pemesanan.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form_Logistik.Show()
    End Sub

    Public Property Stok_pintu1 As Integer
        Get
            Return Stok_pintu
        End Get
        Set(ByVal value As Integer)
            Stok_pintu = value
        End Set
    End Property

    Public Property Stok_roda1 As Integer
        Get
            Return Stok_roda
        End Get
        Set(ByVal value As Integer)
            Stok_roda = value
        End Set
    End Property

    Public Property Stok_kursi1 As Integer
        Get
            Return Stok_kursi
        End Get
        Set(ByVal value As Integer)
            Stok_kursi = value
        End Set
    End Property

    Public Property Stok_mesin1 As Integer
        Get
            Return Stok_mesin
        End Get
        Set(ByVal value As Integer)
            Stok_mesin = value
        End Set
    End Property

    Public Property Pro_badan1 As Integer
        Get
            Return Pro_badan
        End Get
        Set(ByVal value As Integer)
            Pro_badan = value
        End Set
    End Property

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

    Public Property Log_badan1 As Integer
        Get
            Return Log_badan
        End Get
        Set(ByVal value As Integer)
            Log_badan = value
        End Set
    End Property

    Public Property Log_pintu1 As Integer
        Get
            Return Log_pintu
        End Get
        Set(ByVal value As Integer)
            Log_pintu = value
        End Set
    End Property

    Public Property Log_kursi1 As Integer
        Get
            Return Log_kursi
        End Get
        Set(ByVal value As Integer)
            Log_kursi = value
        End Set
    End Property

    Public Property Log_roda1 As Integer
        Get
            Return Log_roda
        End Get
        Set(ByVal value As Integer)
            Log_roda = value
        End Set
    End Property

    Public Property Log_mesin1 As Integer
        Get
            Return Log_mesin
        End Get
        Set(ByVal value As Integer)
            Log_mesin = value
        End Set
    End Property
End Class


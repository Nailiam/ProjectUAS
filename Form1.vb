Public Class Menu_Utama
    Dim No, Nama, Hp, Alamat, Pesanan, Kode_BOM, Kode_purchasing As String
    Dim Jml_pesan, Jml_badan, Jml_pintu, Jml_roda, Jml_kursi, Jml_mesin, Baku_badan, Baku_pintu, Baku_roda, Baku_kursi, Baku_mesin, Pur_badan, Pur_pintu, Pur_roda, Pur_kursi, Pur_mesin, Total_pur, Jml_pro, Pro_badan, Pro_pintu, Pro_kursi, Pro_roda, Pro_mesin, Stok_badan, Stok_pintu, Stok_roda, Stok_kursi, Stok_mesin, Log_badan, Log_pintu, Log_roda, Log_kursi, Log_mesin As Integer
    Dim produksi As Form_Produksi = New Form_Produksi
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form_Produksi.Show()
    End Sub

    Dim Tanggal, Tanggal_pro As Date

    Public Property No1 As String
        Get
            Return No
        End Get
        Set(ByVal value As String)
            No = value
        End Set
    End Property

    Public Property Nama1 As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property

    Public Property Hp1 As String
        Get
            Return Hp
        End Get
        Set(ByVal value As String)
            Hp = value
        End Set
    End Property

    Public Property Alamat1 As String
        Get
            Return Alamat
        End Get
        Set(ByVal value As String)
            Alamat = value
        End Set
    End Property

    Public Property Pesanan1 As String
        Get
            Return Pesanan
        End Get
        Set(ByVal value As String)
            Pesanan = value
        End Set
    End Property

    Public Property Kode_BOM1 As String
        Get
            Return Kode_BOM
        End Get
        Set(ByVal value As String)
            Kode_BOM = value
        End Set
    End Property

    Public Property Kode_purchasing1 As String
        Get
            Return Kode_purchasing
        End Get
        Set(ByVal value As String)
            Kode_purchasing = value
        End Set
    End Property

    Public Property Jml_pesan1 As Integer
        Get
            Return Jml_pesan
        End Get
        Set(ByVal value As Integer)
            Jml_pesan = value
        End Set
    End Property

    Public Property Jml_badan1 As Integer
        Get
            Return Jml_badan
        End Get
        Set(ByVal value As Integer)
            Jml_badan = value
        End Set
    End Property

    Public Property Jml_pintu1 As Integer
        Get
            Return Jml_pintu
        End Get
        Set(ByVal value As Integer)
            Jml_pintu = value
        End Set
    End Property

    Public Property Jml_roda1 As Integer
        Get
            Return Jml_roda
        End Get
        Set(ByVal value As Integer)
            Jml_roda = value
        End Set
    End Property

    Public Property Jml_kursi1 As Integer
        Get
            Return Jml_kursi
        End Get
        Set(ByVal value As Integer)
            Jml_kursi = value
        End Set
    End Property

    Public Property Jml_mesin1 As Integer
        Get
            Return Jml_mesin
        End Get
        Set(ByVal value As Integer)
            Jml_mesin = value
        End Set
    End Property

    Public Property Baku_badan1 As Integer
        Get
            Return Baku_badan
        End Get
        Set(ByVal value As Integer)
            Baku_badan = value
        End Set
    End Property

    Public Property Baku_pintu1 As Integer
        Get
            Return Baku_pintu
        End Get
        Set(ByVal value As Integer)
            Baku_pintu = value
        End Set
    End Property

    Public Property Baku_roda1 As Integer
        Get
            Return Baku_roda
        End Get
        Set(ByVal value As Integer)
            Baku_roda = value
        End Set
    End Property

    Public Property Baku_kursi1 As Integer
        Get
            Return Baku_kursi
        End Get
        Set(ByVal value As Integer)
            Baku_kursi = value
        End Set
    End Property

    Public Property Baku_mesin1 As Integer
        Get
            Return Baku_mesin
        End Get
        Set(ByVal value As Integer)
            Baku_mesin = value
        End Set
    End Property

    Public Property Pur_badan1 As Integer
        Get
            Return Pur_badan
        End Get
        Set(ByVal value As Integer)
            Pur_badan = value
        End Set
    End Property

    Public Property Pur_pintu1 As Integer
        Get
            Return Pur_pintu
        End Get
        Set(ByVal value As Integer)
            Pur_pintu = value
        End Set
    End Property

End Class


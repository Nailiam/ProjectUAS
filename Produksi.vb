Public Class Produksi
    Public Shared database As New List(Of Produksi)
    Private jumlah_produksi As Integer
    Private jenis_mobil As String
    Public Property mjumlah_produksi As Integer
        Get
            Return jumlah_produksi
        End Get
        Set(value As Integer)
            jumlah_produksi = value
        End Set
    End Property
    Public Property mjenis_mobil As String
        Get
            Return jenis_mobil
        End Get
        Set(value As String)
            jenis_mobil = value
        End Set
    End Property
    Sub savedata()
        database.add(Me)
    End Sub
End Class

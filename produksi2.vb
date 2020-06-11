Public Class produksi2
    Public Shared database As New List(Of produksi2)
    Public Property jumlahproduksi As Integer
    Public Property jenismobil As String
    Sub New(jmlproduksi As Integer, jnsmobil As String)
        jumlahproduksi = jmlproduksi
        jenismobil = jnsmobil
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

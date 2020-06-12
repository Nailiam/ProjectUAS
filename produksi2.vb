Public Class produksi2
    Public Shared database As New List(Of produksi2)
    Public Property jumlahsedan As Integer
    Public Property jumlahsport As Integer
    Sub New(jmlsedan As Integer, jmlsport As Integer)
        jumlahsedan = jmlsedan
        jumlahsport = jmlsport
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

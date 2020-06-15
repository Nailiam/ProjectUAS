Public Class produksi2
    Public Shared database As New List(Of produksi2)
    Public Property jumlahsedan As Integer
    Public Property jumlahsport As Integer
    Public Property badansport1 As Integer
    Public Property pintusport1 As Integer
    Public Property rodasport1 As Integer
    Public Property kursisport1 As Integer
    Public Property mesinsport1 As Integer
    Public Property badansedan1 As Integer
    Public Property pintusedan1 As Integer
    Public Property rodasedan1 As Integer
    Public Property kursisedan1 As Integer
    Public Property mesinsedan1 As Integer
    Sub New(jmlsedan As Integer, jmlsport As Integer, badansp As Integer, pintusp As Integer, rodasp As Integer, kursisp As Integer,
            mesinsp As Integer, badansd As Integer, pintusd As Integer, rodasd As Integer, kursisd As Integer, mesinsd As Integer)
        jumlahsedan = jmlsedan
        jumlahsport = jmlsport
        badansport1 = badansp
        pintusport1 = pintusp
        rodasport1 = rodasp
        kursisport1 = kursisp
        mesinsport1 = mesinsp
        badansedan1 = badansd
        pintusedan1 = pintusd
        rodasedan1 = rodasd
        kursisedan1 = kursisd
        mesinsedan1 = mesinsd
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

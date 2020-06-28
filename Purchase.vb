Public Class Purchase
    Public Shared database As New List(Of Purchase)
    Public Property kodepurchase As String
    Public Property badansport2 As Integer
    Public Property pintusport2 As Integer
    Public Property rodasport2 As Integer
    Public Property kursisport2 As Integer
    Public Property mesinsport2 As Integer
    Public Property badansedan2 As Integer
    Public Property pintusedan2 As Integer
    Public Property rodasedan2 As Integer
    Public Property kursisedan2 As Integer
    Public Property mesinsedan2 As Integer
    Public Property mobilsport As Integer
    Public Property mobilsedan As Integer
    Public Property totalbiaya As Integer
    Sub New(codepurchase As String, badansp2 As Integer, pintusp2 As Integer, rodasp2 As Integer, kursisp2 As Integer,
            mesinsp2 As Integer, badansd2 As Integer, pintusd2 As Integer, rodasd2 As Integer, kursisd2 As Integer, mesinsd2 As Integer,
            msport As Integer, msedan As Integer, totalb As Integer)
        kodepurchase = codepurchase
        badansport2 = badansp2
        pintusport2 = pintusp2
        rodasport2 = rodasp2
        kursisport2 = kursisp2
        mesinsport2 = mesinsp2
        badansedan2 = badansd2
        pintusedan2 = pintusd2
        rodasedan2 = rodasd2
        kursisedan2 = kursisd2
        mesinsedan2 = mesinsd2
        mobilsport = msport
        mobilsedan = msedan
        totalbiaya = totalb
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

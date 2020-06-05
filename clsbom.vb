Public Class clsbom
    Public Shared databasebom As New List(Of clsbom)
    Public Property kode As String
    Public Property pintusport As Integer
    Public Property badansport As Integer
    Public Property rodasport As Integer
    Public Property kursisport As Integer
    Public Property mesinsport As Integer
    Public Property pintusedan As Integer
    Public Property badansedan As Integer
    Public Property rodasedan As Integer
    Public Property kursisedan As Integer
    Public Property mesinsedan As Integer
    Sub New(code As String, pintusp As Integer, badansp As Integer, rodasp As Integer, kursisp As Integer,
                mesinsp As Integer, pintusd As Integer, badansd As Integer, rodasd As Integer, kursisd As Integer, mesinsd As Integer)
        kode = code
        pintusport = pintusp
        badansport = badansp
        rodasport = rodasp
        kursisport = kursisp
        mesinsport = mesinsp
        pintusedan = pintusd
        badansedan = badansd
        rodasedan = rodasd
        kursisedan = kursisd
        mesinsedan = mesinsd
    End Sub
    Sub saveData()
        databasebom.Add(Me)
    End Sub
End Class

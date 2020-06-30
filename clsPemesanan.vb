Public Class clsPemesanan
    Public Shared database As New List(Of clsPemesanan)
    Public Property kode As String
    Public Property nama As String
    Public Property alamat As String
    Public Property mobilsport As Integer = 0
    Public Property mobilsedan As Integer = 0
    Sub New(code As String, name As String, addres As String, sport As Integer, sedan As Integer)
        kode = code
        nama = name
        alamat = addres
        mobilsport = sport
        mobilsedan = sedan
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

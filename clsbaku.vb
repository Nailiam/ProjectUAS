Public Class clsbaku
    Public Shared database As New List(Of clsbaku)
    Public Property stokbadansport As Integer
    Public Property stokpintusport As Integer
    Public Property stokrodasport As Integer
    Public Property stokkursisport As Integer
    Public Property stokmesinsport As Integer
    Public Property stokbadansedan As Integer
    Public Property stokpintusedan As Integer
    Public Property stokrodasedan As Integer
    Public Property stokkursisedan As Integer
    Public Property stokmesinsedan As Integer
    Public Property krgbadansp As Integer
    Public Property krgpintusp As Integer
    Public Property krgrodasp As Integer
    Public Property krgkursisp As Integer
    Public Property krgmesinsp As Integer
    Public Property krgbadansd As Integer
    Public Property krgpintusd As Integer
    Public Property krgrodasd As Integer
    Public Property krgkursisd As Integer
    Public Property krgmesinsd As Integer
    Sub New(stokbadansp As Integer, stokpintusp As Integer, stokrodasp As Integer, stokkursisp As Integer, stokmesinsp As Integer,
            stokbadansd As Integer, stokpintusd As Integer, stokrodasd As Integer, stokkursisd As Integer, stokmesinsd As Integer,
            badansp As Integer, pintusp As Integer, rodasp As Integer, kursisp As Integer, mesinsp As Integer,
            badansd As Integer, pintusd As Integer, rodasd As Integer, kursisd As Integer, mesinsd As Integer)
        stokbadansport = stokbadansp
        stokpintusport = stokpintusp
        stokrodasport = stokrodasp
        stokkursisport = stokkursisp
        stokmesinsport = stokmesinsp
        stokbadansedan = stokbadansd
        stokpintusedan = stokpintusd
        stokrodasedan = stokrodasd
        stokkursisedan = stokkursisd
        stokmesinsedan = stokmesinsd
        krgbadansp = badansp
        krgpintusp = pintusp
        krgrodasp = rodasp
        krgkursisp = kursisp
        krgmesinsp = mesinsp
        krgbadansd = badansd
        krgpintusd = pintusd
        krgrodasd = rodasd
        krgkursisd = kursisd
        krgmesinsd = mesinsd
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class
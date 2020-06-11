Public Class clsLogistik
    Public Shared database As New List(Of clsLogistik)
    Public Property jmlsport As Integer
    Public Property jmlsedan As Integer
    Sub New(newjmlsport As Integer, newjmlsedan As Integer)
        jmlsport = newjmlsport
        jmlsedan = newjmlsedan
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

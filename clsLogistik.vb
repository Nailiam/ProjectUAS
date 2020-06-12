Public Class clsLogistik
    Public Shared database As New List(Of clsLogistik)
    Public Property jmlsport As Integer
    Public Property jmlsedan As Integer
    Sub New(newjmlsedan As Integer, newjmlsport As Integer)
        jmlsedan = newjmlsedan
        jmlsport = newjmlsport
    End Sub
    Sub savedata()
        database.Add(Me)
    End Sub
End Class

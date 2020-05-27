Public Class Form_Produksi
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Form_Produksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub
End Class
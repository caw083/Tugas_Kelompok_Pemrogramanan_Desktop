Public Class Form3
    Public Property ButtonText As String
    Public Property ClickedPanel As Panel

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dateTimeParts() As String = ButtonText.Split(" "c)
        ' dateTimeParts now contains two elements: "11/03/2024" and "20:54:02"
        Dim datePart As String = dateTimeParts(0)
        Dim timePart As String = dateTimeParts(1)
        Label3.Text = datePart
        Label2.Text = timePart
    End Sub

    Private Sub DeleteAlarm_Click(sender As Object, e As EventArgs) Handles DeleteAlarm.Click
        If ClickedPanel IsNot Nothing Then
            ' Dispose the clicked panel to release resources
            ClickedPanel.Dispose()

            ' Close Form3 after deletion
            Me.Close()
        End If
    End Sub
End Class
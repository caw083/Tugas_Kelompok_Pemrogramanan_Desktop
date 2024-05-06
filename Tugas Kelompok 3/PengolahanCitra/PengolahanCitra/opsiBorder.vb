Public Class opsiBorder

    Private Sub opsiBorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboWarna.Items.AddRange([Enum].GetNames(GetType(KnownColor)))

        For i As Integer = 1 To 20
            comboKetebalan.Items.Add(i.ToString())
        Next
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim selectedColor As Color = Color.FromName(comboWarna.SelectedItem.ToString())
        Dim borderWidth As Integer = Integer.Parse(comboKetebalan.SelectedItem.ToString())


        If Application.OpenForms().OfType(Of Form1).Any() Then
            Dim form1 As Form1 = Application.OpenForms().OfType(Of Form1).First()
            form1.BorderColor = selectedColor
            form1.BorderWidth = borderWidth
            form1.ApplyBorder()
        End If

        Me.Close()
    End Sub

End Class

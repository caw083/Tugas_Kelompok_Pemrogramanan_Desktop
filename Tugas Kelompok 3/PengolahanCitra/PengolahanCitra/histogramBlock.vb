Public Class histogramBlock
    Private Sub frmHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r, g, b, max As Integer
        Dim hR, hG, hB As Integer
        Dim bmp = New Bitmap(Form1.PictureBox1.Image)
        Dim frekR(256), frekG(256), frekB(256) As Integer
        For i As Integer = 0 To 255
            frekR(i) = 0
            frekG(i) = 0
            frekB(i) = 0
        Next
        For bar As Integer = 1 To Form1.PictureBox1.Image.Height - 2
            For kol As Integer = 1 To Form1.PictureBox1.Image.Width - 2
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                frekR(r) = frekR(r) + 1
                frekG(g) = frekG(g) + 1
                frekB(b) = frekB(b) + 1
            Next
        Next
        max = 0
        For i As Integer = 0 To 255
            If frekR(i) > max Then max = frekR(i)
            If frekG(i) > max Then max = frekG(i)
            If frekB(i) > max Then max = frekB(i)
        Next

        Dim bmpHistogram As New Bitmap(300, 250)
        Using gr As Graphics = Graphics.FromImage(bmpHistogram)
            Dim barWidth As Integer = 5
            Dim spacing As Integer = 1
            Dim x As Integer = 10
            For i As Integer = 0 To 255
                ' Menghitung tinggi balok histogram sesuai dengan frekuensi warna
                hR = Math.Round(frekR(i) / max * 200)
                hG = Math.Round(frekG(i) / max * 200)
                hB = Math.Round(frekB(i) / max * 200)

                ' Menggambar balok histogram untuk warna merah
                Dim rectR As New Rectangle(x, 200 - hR, barWidth, hR)
                gr.FillRectangle(Brushes.Red, rectR)

                ' Menggambar balok histogram untuk warna hijau
                Dim rectG As New Rectangle(x + barWidth + spacing, 200 - hG, barWidth, hG)
                gr.FillRectangle(Brushes.Green, rectG)

                ' Menggambar balok histogram untuk warna biru
                Dim rectB As New Rectangle(x + (barWidth + spacing) * 2, 200 - hB, barWidth, hB)
                gr.FillRectangle(Brushes.Blue, rectB)

                ' Menambahkan jarak antara balok histogram
                x += (barWidth + spacing) * 3
            Next
        End Using

        ' Menampilkan histogram di PictureBox
        PictureBox1.Image = bmpHistogram
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
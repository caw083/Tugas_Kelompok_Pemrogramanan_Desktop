Public Class Form1
    Dim namafile

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Properti_Click(sender As Object, e As EventArgs) Handles Properti.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " +
PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " +
PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub GreyScale_Click(sender As Object, e As EventArgs) Handles GreyScale.Click
        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        'Dim img As Image
        'img = CType(bmp, Image)
        'PictureBox1.Image = img
        PictureBox1.Image = bmp
    End Sub

    Private Sub Cerahkan_Click(sender As Object, e As EventArgs) Handles Cerahkan.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Gelapkan_Click(sender As Object, e As EventArgs) Handles Gelapkan.Click

        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KurangiKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp As Bitmap = Bitmap.FromFile(namafile)

        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TampilkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanToolStripMenuItem.Click
        frmHistogram.ShowDialog()

    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 2, 1, 2, 4, 2, 1, 2, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 +
                   (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Rotasi90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Rotasi90DerajatToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
            PictureBox1.Image = bmp

            'manual
            'If PictureBox1.Image IsNot Nothing Then
            ' Dim bmp As Bitmap = CType(PictureBox1.Image, Bitmap)
            'Dim width As Integer = bmp.Width
            'Dim height As Integer = bmp.Height
            'Dim tempColor As Color
            '
            ' For y As Integer = 0 To height - 1
            '  For x As Integer = 0 To width / 2 - 1
            '  tempColor = bmp.GetPixel(x, y)
            '  bmp.SetPixel(x, y, bmp.GetPixel(width - 1 - x, y))
            '  bmp.SetPixel(width - 1 - x, y, tempColor)
            '  Next
            'ext

            'PictureBox1.Image = bmp
            'Else
            ' MessageBox.Show("Tidak ada citra yang dibuka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Else
            MessageBox.Show("Tidak ada citra yang dibuka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Public Property BorderColor As Color
    Public Property BorderWidth As Integer

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click

        Dim borderForm As New opsiBorder()
        borderForm.PictureBox1.Image = PictureBox1.Image
        borderForm.ShowDialog()
    End Sub

    Public Sub ApplyBorder()
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim pen As New Pen(BorderColor, BorderWidth)
            g.DrawRectangle(pen, 0, 0, bmp.Width - 1, bmp.Height - 1)
            PictureBox1.Image = bmp
            g.Dispose()
            pen.Dispose()
        End If
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        Dim watermarkForm As New opsiWatermark(Me)
        watermarkForm.Show()
    End Sub


    Public Sub ApplyWatermark(text As String)
        Dim originalImage As Image = PictureBox1.Image.Clone()
        Dim bmp As New Bitmap(originalImage.Width, originalImage.Height)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(originalImage, Point.Empty)
        End Using

        Dim watermarkFont As New Font("Arial", 40)
        Dim textSize As SizeF = TextRenderer.MeasureText(text, watermarkFont)

        ' Calculate the optimal number of rows and columns
        Dim numRows As Integer = Math.Ceiling(bmp.Height / textSize.Height)
        Dim numCols As Integer = Math.Ceiling(bmp.Width / textSize.Width)

        ' Loop through each row and column to draw the watermark text
        For row As Integer = 0 To numRows - 1
            For col As Integer = 0 To numCols - 1
                Dim textX As Integer = col * textSize.Width
                Dim textY As Integer = row * textSize.Height

                Using g As Graphics = Graphics.FromImage(bmp)
                    g.DrawString(text, watermarkFont, New SolidBrush(Color.FromArgb(140, Color.White)), textX, textY)
                End Using
            Next
        Next

        PictureBox1.Image = bmp
        originalImage.Dispose()
    End Sub




    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B


                r = 255 - r
                g = 255 - g
                b = 255 - b

                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B

                r = Math.Round(0.9 * r)
                g = Math.Round(0.2 * g)
                b = Math.Round(0.2 * b)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B

                r = Math.Round(0.1 * r)
                g = Math.Round(0.9 * g)
                b = Math.Round(0.1 * b)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B

                r = Math.Round(0.2 * r)
                g = Math.Round(0.2 * g)
                b = Math.Round(0.9 * b)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub


    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B

                r = Math.Round(1 * r)
                g = Math.Round(0.2 * g)
                b = Math.Round(0.9 * b)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub HistogramBlokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBlokToolStripMenuItem.Click
        ' Ensure histogramBlock is the correct form name

        ' Consider using Show() if you don't want to block the main thread
        histogramBlock.Show() ' or histogramBlock.ShowDialog()

    End Sub

End Class

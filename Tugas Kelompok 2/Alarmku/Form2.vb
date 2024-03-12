
Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateTime()

        ' Set the text boxes to current hour, minute, and second
        txtBoxHour.Text = Now.Hour.ToString().PadLeft(2, "0"c)
        txtBoxMinutes.Text = Now.Minute.ToString().PadLeft(2, "0"c)
        txtBoxSecond.Text = Now.Second.ToString().PadLeft(2, "0"c)
    End Sub



    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        ' Update the label text with the selected date
        Label2.Text = "Deskripsi:  " + MonthCalendar1.SelectionStart.ToString("dd/MM/yyyy")
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
    End Sub

    Private Sub UpdateTime()
        Label3.Text = "Waktu Sekarang: " + DateTime.Now.ToString("HH:mm:ss") + " WIB"
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub



    Public Event ChosenDateTimeReady(ByVal chosenDateTime As Date)
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Retrieve the chosen date and time from the MonthCalendar and time TextBoxes
        Dim chosenDate As Date = MonthCalendar1.SelectionStart.Date
        Dim chosenHour As Integer = txtBoxHour.Text
        Dim chosenMinutes As Integer = txtBoxMinutes.Text
        Dim chosenSecond As Integer = txtBoxSecond.Text

        Dim chosenDateTime As New DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, chosenHour, chosenMinutes, chosenSecond)



        ' Send Date to the form 1
        RaiseEvent ChosenDateTimeReady(chosenDateTime)
        Me.Hide()
    End Sub















    ''' Bagian Jam

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(txtBoxHour.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxHour.Text)
            If value < 23 Then
                value += 1
                txtBoxHour.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxHour.Text = "00"
            End If
        Else
            txtBoxHour.Text = "01"
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(txtBoxHour.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxHour.Text)
            If value > 0 Then
                value -= 1
                txtBoxHour.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxHour.Text = "23"
            End If
        Else
            txtBoxHour.Text = "01"
        End If
    End Sub
    Private Sub txtBoxHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxHour.KeyPress
        ' Allowing only numeric input (0-9) and control characters (e.g., Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub txtBoxHour_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHour.TextChanged
        ' Check if the entered text is a valid integer
        Dim intValue As Integer

        ' Check if the entered text is numeric
        If Integer.TryParse(txtBoxHour.Text, intValue) Then
            ' If the value is greater than 23, reset it to zero
            If intValue > 23 Then
                txtBoxHour.Text = "00"
            End If
        Else
            ' If not a valid integer, remove the last entered character
            If txtBoxHour.Text.Length > 0 Then
                txtBoxHour.Text = txtBoxHour.Text.Substring(0, txtBoxHour.Text.Length - 1)
                txtBoxHour.SelectionStart = txtBoxHour.Text.Length
            End If
        End If
    End Sub






    ''' Bagian Menit

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(txtBoxMinutes.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxMinutes.Text)
            If value < 59 Then
                value += 1
                txtBoxMinutes.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxMinutes.Text = "00"
            End If
        Else
            txtBoxMinutes.Text = "01"
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNumeric(txtBoxMinutes.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxMinutes.Text)
            If value > 0 Then
                value -= 1
                txtBoxMinutes.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxMinutes.Text = "59"
            End If
        Else
            txtBoxMinutes.Text = "01"
        End If
    End Sub

    Private Sub txtBoxMinutes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxMinutes.KeyPress
        ' Allowing only numeric input (0-9) and control characters (e.g., Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub


    Private Sub txtBoxMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtBoxMinutes.TextChanged
        ' Check if the entered text is a valid integer
        Dim intValue As Integer

        ' Check if the entered text is numeric
        If Integer.TryParse(txtBoxMinutes.Text, intValue) Then
            ' If the value is greater than 59, reset it to zero
            If intValue > 59 Then
                txtBoxMinutes.Text = "00"
            End If
        Else
            ' If not a valid integer, remove the last entered character
            If txtBoxMinutes.Text.Length > 0 Then
                txtBoxMinutes.Text = txtBoxMinutes.Text.Substring(0, txtBoxMinutes.Text.Length - 1)
                txtBoxMinutes.SelectionStart = txtBoxMinutes.Text.Length
            End If
        End If
    End Sub











    ''' Bagian Detik
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(txtBoxSecond.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxSecond.Text)
            If value < 59 Then
                value += 1
                txtBoxSecond.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxSecond.Text = "00"
            End If
        Else
            txtBoxSecond.Text = "01"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If IsNumeric(txtBoxSecond.Text) Then
            Dim value As Integer = Integer.Parse(txtBoxSecond.Text)
            If value > 0 Then
                value -= 1
                txtBoxSecond.Text = value.ToString().PadLeft(2, "0"c)
            Else
                txtBoxSecond.Text = "59"
            End If
        Else
            txtBoxSecond.Text = "01"
        End If
    End Sub

    Private Sub txtBoxSecond_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxSecond.KeyPress
        ' Allowing only numeric input (0-9) and control characters (e.g., Backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Ignore the key press
        End If
    End Sub

    Private Sub txtBoxSecond_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSecond.TextChanged
        ' Check if the entered text is a valid integer
        Dim intValue As Integer
        ' Check if the entered text is numeric
        If Integer.TryParse(txtBoxSecond.Text, intValue) Then
            ' If the value is greater than 59, reset it to zero
            If intValue > 59 Then
                txtBoxSecond.Text = "00"
            End If
        Else
            ' If not a valid integer, remove the last entered character
            If txtBoxSecond.Text.Length > 0 Then
                txtBoxSecond.Text = txtBoxSecond.Text.Substring(0, txtBoxSecond.Text.Length - 1)
                txtBoxSecond.SelectionStart = txtBoxSecond.Text.Length
            End If
        End If
    End Sub


End Class
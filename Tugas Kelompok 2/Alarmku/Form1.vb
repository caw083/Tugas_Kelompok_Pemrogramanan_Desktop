Imports System.Globalization
Imports System.IO

Public Class Form1
    Dim relativePath1 As String = AppDomain.CurrentDomain.BaseDirectory

    Dim relativePath = Path.Combine(relativePath1.Substring(0, relativePath1.Length - 25), "src\alarm_sound.wav")

    Private Sub ReceiveChosenDateTimeHandler(ByVal chosenDateTime As Date)
        AddDateTimePanel(chosenDateTime)
    End Sub

    Private Sub AddDateTimePanel(ByVal chosenDateTime As Date)
        ' Check if the maximum number of panels (8) has been reached
        If FlowLayoutPanel1.Controls.Count >= 8 Then
            MessageBox.Show("Maximum number of panels reached.")
            Return
        End If

        ' Create a panel to contain the date and time information
        Dim panel As New Panel()
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.AutoSize = False ' Set AutoSize to False to allow setting the size manually
        panel.Size = New Size(100, 120) ' Set the size of the panel
        panel.BackColor = Color.Purple ' Set the background color of the panel to purple

        ' Do something with the received formatted date and time, such as displaying it in labels or processing it further
        Dim formattedDateTime As String = chosenDateTime.ToString("dd/MM/yyyy") & Environment.NewLine & chosenDateTime.ToString("HH:mm:ss")
        formattedDateTime = formattedDateTime.Replace(Environment.NewLine, " ")
        Dim button As New Button
        button.Text = formattedDateTime
        button.AutoSize = False ' Set AutoSize to False to allow the label to fill the panel
        button.Dock = DockStyle.Fill ' Dock the label within the panel to fill it completely
        button.TextAlign = ContentAlignment.MiddleCenter ' Center the text within the label

        AddHandler button.Click, AddressOf Panel_Click


        ' Add the label to the panel
        panel.Controls.Add(button)


        ' Add the panel to the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(panel)

        ' If the number of panels in the FlowLayoutPanel is divisible by 4, add a flow break
        If FlowLayoutPanel1.Controls.Count Mod 4 = 0 Then
            FlowLayoutPanel1.SetFlowBreak(panel, True)
        End If
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs)
        ' Cast the sender object to a Button
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Get the text from the clicked button
        Dim buttonText As String = clickedButton.Text
        Dim clickedPanel As Panel = DirectCast(clickedButton.Parent, Panel)


        ' Create an instance of Form3 and pass the button text
        Dim form3 As New Form3()
        form3.ButtonText = buttonText
        form3.ClickedPanel = clickedPanel


        ' Show Form3
        form3.Show()
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UpdateTime()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateTime()
        CheckAlarms()
    End Sub

    Private Sub UpdateTime()
        Label1.Text = "Waktu Sekarang: " + DateTime.Now.ToString("HH:mm:ss") + " WIB"
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        ' Extract alarm times from the FlowLayoutPanel's panels and save them to a file
        SaveAlarmTimesToFile("alarmsTopher.txt")
    End Sub

    Private Sub SaveAlarmTimesToFile(filename As String)
        Try
            ' Open or create the text file for writing
            Using writer As New StreamWriter(filename)
                ' Iterate over each panel in the FlowLayoutPanel
                For Each panel As Panel In FlowLayoutPanel1.Controls
                    ' Extract the text from the label within the panel
                    Dim formattedDateTime As String = panel.Controls.OfType(Of Button)().FirstOrDefault()?.Text

                    ' Write the extracted text to the file
                    If formattedDateTime IsNot Nothing Then
                        writer.WriteLine(formattedDateTime)
                    End If
                Next
            End Using

            MessageBox.Show("Data saved to " & filename, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub TambahAlarmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TambahAlarmToolStripMenuItem1.Click
        Dim form2 As New Form2()

        ' Subscribe to the MessageReady event of Form2
        AddHandler form2.ChosenDateTimeReady, AddressOf ReceiveChosenDateTimeHandler

        ' Display Form2
        form2.Show()
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub




    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        ' Declare variables
        Dim filePath As String = "alarmsTopher.txt"

        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read all lines from the file
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Iterate through every line
            For i As Integer = 0 To lines.Length - 1
                ' Try to parse each line as DateTime
                Dim dateTimeValue As DateTime
                If DateTime.TryParseExact(lines(i), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dateTimeValue) Then
                    ' If parsing successful, display the DateTime
                    AddDateTimePanel(dateTimeValue)
                Else
                    ' If parsing failed, show an error message
                    MessageBox.Show("Line " & (i + 1) & " has an invalid date-time format.")
                End If
            Next
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    Private Sub CheckAlarms()
        ' Get the current date and time
        Dim nowDate As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        ' Iterate through each panel in the FlowLayoutPanel
        For Each panel As Panel In FlowLayoutPanel1.Controls
            ' Extract the text from the button within the panel
            Dim formattedDateTime As String = panel.Controls.OfType(Of Button)().FirstOrDefault()?.Text
            If nowDate = formattedDateTime Then
                My.Computer.Audio.Play(relativePath, AudioPlayMode.Background)
                Panel_Click(panel.Controls(0), EventArgs.Empty)
                FlowLayoutPanel1.Controls.Remove(panel)
            End If
        Next
    End Sub


End Class

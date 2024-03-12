<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        txtBoxHour = New TextBox()
        txtBoxMinutes = New TextBox()
        txtBoxSecond = New TextBox()
        Button7 = New Button()
        Button8 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(164, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 38)
        Label1.TabIndex = 0
        Label1.Text = "Tambah Alarm Baru"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(9, 56)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Location = New Point(310, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 29)
        Button1.TabIndex = 2
        Button1.Text = "+"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLightLight
        Button2.Location = New Point(416, 62)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 29)
        Button2.TabIndex = 3
        Button2.Text = "+"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ControlLightLight
        Button3.Location = New Point(525, 62)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 29)
        Button3.TabIndex = 4
        Button3.Text = "+"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlLightLight
        Button4.Location = New Point(310, 162)
        Button4.Name = "Button4"
        Button4.Size = New Size(40, 29)
        Button4.TabIndex = 5
        Button4.Text = "-"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlLightLight
        Button5.Location = New Point(416, 162)
        Button5.Name = "Button5"
        Button5.Size = New Size(40, 29)
        Button5.TabIndex = 6
        Button5.Text = "-"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ControlLightLight
        Button6.Location = New Point(525, 162)
        Button6.Name = "Button6"
        Button6.Size = New Size(40, 29)
        Button6.TabIndex = 7
        Button6.Text = "-"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' txtBoxHour
        ' 
        txtBoxHour.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoxHour.Location = New Point(297, 97)
        txtBoxHour.Multiline = True
        txtBoxHour.Name = "txtBoxHour"
        txtBoxHour.Size = New Size(63, 59)
        txtBoxHour.TabIndex = 8
        txtBoxHour.Text = "12"
        txtBoxHour.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBoxMinutes
        ' 
        txtBoxMinutes.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoxMinutes.Location = New Point(403, 97)
        txtBoxMinutes.Multiline = True
        txtBoxMinutes.Name = "txtBoxMinutes"
        txtBoxMinutes.Size = New Size(67, 59)
        txtBoxMinutes.TabIndex = 9
        txtBoxMinutes.Text = "12"
        txtBoxMinutes.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBoxSecond
        ' 
        txtBoxSecond.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBoxSecond.Location = New Point(510, 97)
        txtBoxSecond.Multiline = True
        txtBoxSecond.Name = "txtBoxSecond"
        txtBoxSecond.Size = New Size(67, 59)
        txtBoxSecond.TabIndex = 10
        txtBoxSecond.Text = "12"
        txtBoxSecond.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Red
        Button7.Location = New Point(319, 212)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 29)
        Button7.TabIndex = 11
        Button7.Text = "Cancel"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Lime
        Button8.Location = New Point(463, 212)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 29)
        Button8.TabIndex = 12
        Button8.Text = "Save"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 13
        Label2.Text = "Deskripsi :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(366, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 20)
        Label3.TabIndex = 14
        Label3.Text = "Waktu Sekarang:  __:__:__ WIB"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(371, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 38)
        Label4.TabIndex = 15
        Label4.Text = ":"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(479, 106)
        Label5.Name = "Label5"
        Label5.Size = New Size(25, 38)
        Label5.TabIndex = 16
        Label5.Text = ":"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 310)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(txtBoxSecond)
        Controls.Add(txtBoxMinutes)
        Controls.Add(txtBoxHour)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "New Alarm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtBoxHour As TextBox
    Friend WithEvents txtBoxMinutes As TextBox
    Friend WithEvents txtBoxSecond As TextBox
End Class

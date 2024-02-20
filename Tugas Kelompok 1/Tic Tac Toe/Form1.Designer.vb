<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Round_Label = New Label()
        Label3 = New Label()
        Giliran_Pemain_text = New Label()
        Timer_Count = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Score_X_Player = New Label()
        Score_Y_Player = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Countdown_player = New Timer(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 65)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 117)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonHighlight
        Button2.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(177, 65)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 117)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonHighlight
        Button3.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(337, 65)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 117)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonHighlight
        Button4.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(12, 197)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 117)
        Button4.TabIndex = 3
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ButtonHighlight
        Button5.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(177, 197)
        Button5.Name = "Button5"
        Button5.Size = New Size(147, 117)
        Button5.TabIndex = 4
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ButtonHighlight
        Button6.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(336, 197)
        Button6.Name = "Button6"
        Button6.Size = New Size(147, 117)
        Button6.TabIndex = 5
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.ButtonHighlight
        Button7.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(12, 321)
        Button7.Name = "Button7"
        Button7.Size = New Size(147, 117)
        Button7.TabIndex = 6
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = SystemColors.ButtonHighlight
        Button8.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(177, 321)
        Button8.Name = "Button8"
        Button8.Size = New Size(147, 117)
        Button8.TabIndex = 7
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = SystemColors.ButtonHighlight
        Button9.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button9.Location = New Point(338, 322)
        Button9.Name = "Button9"
        Button9.Size = New Size(147, 117)
        Button9.TabIndex = 8
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Round_Label
        ' 
        Round_Label.BackColor = SystemColors.ControlLightLight
        Round_Label.BorderStyle = BorderStyle.Fixed3D
        Round_Label.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Round_Label.Location = New Point(13, 1)
        Round_Label.Name = "Round_Label"
        Round_Label.Size = New Size(785, 55)
        Round_Label.TabIndex = 9
        Round_Label.Text = "Round : 1"
        Round_Label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(617, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 11
        ' 
        ' Giliran_Pemain_text
        ' 
        Giliran_Pemain_text.AutoSize = True
        Giliran_Pemain_text.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Giliran_Pemain_text.Location = New Point(543, 162)
        Giliran_Pemain_text.Name = "Giliran_Pemain_text"
        Giliran_Pemain_text.Size = New Size(28, 31)
        Giliran_Pemain_text.TabIndex = 12
        Giliran_Pemain_text.Text = "X"
        ' 
        ' Timer_Count
        ' 
        Timer_Count.AutoSize = True
        Timer_Count.Font = New Font("Segoe UI", 14F)
        Timer_Count.Location = New Point(697, 162)
        Timer_Count.Name = "Timer_Count"
        Timer_Count.Size = New Size(40, 32)
        Timer_Count.TabIndex = 13
        Timer_Count.Text = "10"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(537, 252)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 28)
        Label6.TabIndex = 14
        Label6.Text = "Score Pemain X :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(537, 294)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 28)
        Label7.TabIndex = 15
        Label7.Text = "Score Pemain O :"
        ' 
        ' Score_X_Player
        ' 
        Score_X_Player.AutoSize = True
        Score_X_Player.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Score_X_Player.Location = New Point(701, 255)
        Score_X_Player.Name = "Score_X_Player"
        Score_X_Player.Size = New Size(26, 31)
        Score_X_Player.TabIndex = 16
        Score_X_Player.Text = "0"
        ' 
        ' Score_Y_Player
        ' 
        Score_Y_Player.AutoSize = True
        Score_Y_Player.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Score_Y_Player.Location = New Point(701, 294)
        Score_Y_Player.Name = "Score_Y_Player"
        Score_Y_Player.Size = New Size(26, 31)
        Score_Y_Player.TabIndex = 17
        Score_Y_Player.Text = "0"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Location = New Point(512, 87)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(96, 62)
        TextBox1.TabIndex = 18
        TextBox1.Text = "Giliran Pemain :"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Info
        TextBox2.Location = New Point(662, 87)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(105, 62)
        TextBox2.TabIndex = 19
        TextBox2.Text = "Waktu Giliran yang tersisa :"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Countdown_player
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Score_Y_Player)
        Controls.Add(Score_X_Player)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Timer_Count)
        Controls.Add(Giliran_Pemain_text)
        Controls.Add(Label3)
        Controls.Add(Round_Label)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Round_Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Giliran_Pemain_text As Label
    Friend WithEvents Timer_Count As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Countdown_player As Timer
    Friend WithEvents Score_X_Player As Label
    Friend WithEvents Score_Y_Player As Label

End Class

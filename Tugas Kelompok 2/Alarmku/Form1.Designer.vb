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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        TambahAlarmToolStripMenuItem = New ToolStripMenuItem()
        TambahAlarmToolStripMenuItem1 = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        LoadToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        Timer1 = New Timer(components)
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ButtonHighlight
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TambahAlarmToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1212, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TambahAlarmToolStripMenuItem
        ' 
        TambahAlarmToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TambahAlarmToolStripMenuItem1, SimpanToolStripMenuItem, LoadToolStripMenuItem, KeluarToolStripMenuItem})
        TambahAlarmToolStripMenuItem.Name = "TambahAlarmToolStripMenuItem"
        TambahAlarmToolStripMenuItem.Size = New Size(63, 24)
        TambahAlarmToolStripMenuItem.Text = "Alarm"
        ' 
        ' TambahAlarmToolStripMenuItem1
        ' 
        TambahAlarmToolStripMenuItem1.Name = "TambahAlarmToolStripMenuItem1"
        TambahAlarmToolStripMenuItem1.Size = New Size(188, 26)
        TambahAlarmToolStripMenuItem1.Text = "Tambah Alarm"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(188, 26)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' LoadToolStripMenuItem
        ' 
        LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        LoadToolStripMenuItem.Size = New Size(188, 26)
        LoadToolStripMenuItem.Text = "Load"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(188, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(12, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 20)
        Label1.TabIndex = 1
        Label1.Text = "Waktu Sekarang:  __:__:__ WIB"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(131, 61)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1058, 310)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1212, 383)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.ActiveCaptionText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Alarmku"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TambahAlarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahAlarmToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel

End Class

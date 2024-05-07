<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSimpan = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Properti = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyScale = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cerahkan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gelapkan = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Rotasi90DerajatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfekTugas3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatermarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InversiWarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaMerahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaHijauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaBiruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaSpesialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HistogramBlokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.HistogramToolStripMenuItem, Me.EffectsToolStripMenuItem, Me.EfekTugas3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSimpan, Me.OpenToolStripMenuItem, Me.Properti})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(46, 24)
        Me.File.Text = "File"
        '
        'btnSimpan
        '
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(145, 26)
        Me.btnSimpan.Text = "Simpan"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'Properti
        '
        Me.Properti.Name = "Properti"
        Me.Properti.Size = New System.Drawing.Size(145, 26)
        Me.Properti.Text = "Properti"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyScale, Me.Cerahkan, Me.Gelapkan, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ResetToolStripMenuItem, Me.TampilkanToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'GreyScale
        '
        Me.GreyScale.Name = "GreyScale"
        Me.GreyScale.Size = New System.Drawing.Size(233, 26)
        Me.GreyScale.Text = "GreyScale"
        '
        'Cerahkan
        '
        Me.Cerahkan.Name = "Cerahkan"
        Me.Cerahkan.Size = New System.Drawing.Size(233, 26)
        Me.Cerahkan.Text = "Cerahkan"
        '
        'Gelapkan
        '
        Me.Gelapkan.Name = "Gelapkan"
        Me.Gelapkan.Size = New System.Drawing.Size(233, 26)
        Me.Gelapkan.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanToolStripMenuItem
        '
        Me.TampilkanToolStripMenuItem.Name = "TampilkanToolStripMenuItem"
        Me.TampilkanToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TampilkanToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'EffectsToolStripMenuItem
        '
        Me.EffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamkanToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.Rotasi90DerajatToolStripMenuItem, Me.FlipToolStripMenuItem, Me.FlipVertikalToolStripMenuItem})
        Me.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        Me.EffectsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.EffectsToolStripMenuItem.Text = "Effects"
        '
        'TajamkanToolStripMenuItem
        '
        Me.TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        Me.TajamkanToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.TajamkanToolStripMenuItem.Text = "Tajamkan"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'Rotasi90DerajatToolStripMenuItem
        '
        Me.Rotasi90DerajatToolStripMenuItem.Name = "Rotasi90DerajatToolStripMenuItem"
        Me.Rotasi90DerajatToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.Rotasi90DerajatToolStripMenuItem.Text = "Rotasi 90 Derajat"
        '
        'FlipToolStripMenuItem
        '
        Me.FlipToolStripMenuItem.Name = "FlipToolStripMenuItem"
        Me.FlipToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.FlipToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipVertikalToolStripMenuItem
        '
        Me.FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        Me.FlipVertikalToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        '
        'EfekTugas3ToolStripMenuItem
        '
        Me.EfekTugas3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorderToolStripMenuItem, Me.WatermarkToolStripMenuItem, Me.InversiWarnaToolStripMenuItem, Me.RonaMerahToolStripMenuItem, Me.RonaHijauToolStripMenuItem, Me.RonaBiruToolStripMenuItem, Me.RonaSpesialToolStripMenuItem, Me.HistogramBlokToolStripMenuItem})
        Me.EfekTugas3ToolStripMenuItem.Name = "EfekTugas3ToolStripMenuItem"
        Me.EfekTugas3ToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.EfekTugas3ToolStripMenuItem.Text = "Efek Tugas 3"
        '
        'BorderToolStripMenuItem
        '
        Me.BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        Me.BorderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BorderToolStripMenuItem.Text = "Border"
        '
        'WatermarkToolStripMenuItem
        '
        Me.WatermarkToolStripMenuItem.Name = "WatermarkToolStripMenuItem"
        Me.WatermarkToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.WatermarkToolStripMenuItem.Text = "Watermark"
        '
        'InversiWarnaToolStripMenuItem
        '
        Me.InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        Me.InversiWarnaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InversiWarnaToolStripMenuItem.Text = "Inversi Warna"
        '
        'RonaMerahToolStripMenuItem
        '
        Me.RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        Me.RonaMerahToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaMerahToolStripMenuItem.Text = "Rona Merah"
        '
        'RonaHijauToolStripMenuItem
        '
        Me.RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        Me.RonaHijauToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaHijauToolStripMenuItem.Text = "Rona Hijau"
        '
        'RonaBiruToolStripMenuItem
        '
        Me.RonaBiruToolStripMenuItem.Name = "RonaBiruToolStripMenuItem"
        Me.RonaBiruToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaBiruToolStripMenuItem.Text = "Rona Biru"
        '
        'RonaSpesialToolStripMenuItem
        '
        Me.RonaSpesialToolStripMenuItem.Name = "RonaSpesialToolStripMenuItem"
        Me.RonaSpesialToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RonaSpesialToolStripMenuItem.Text = "Rona Spesial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 422)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HistogramBlokToolStripMenuItem
        '
        Me.HistogramBlokToolStripMenuItem.Name = "HistogramBlokToolStripMenuItem"
        Me.HistogramBlokToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.HistogramBlokToolStripMenuItem.Text = "Histogram Blok"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents btnSimpan As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Properti As ToolStripMenuItem
    Friend WithEvents GreyScale As ToolStripMenuItem
    Friend WithEvents Cerahkan As ToolStripMenuItem
    Friend WithEvents Gelapkan As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Rotasi90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfekTugas3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBiruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpesialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramBlokToolStripMenuItem As ToolStripMenuItem
End Class

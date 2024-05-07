Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class opsiWatermark
    Private WithEvents parentForm As Form1

    ' Constructor to receive reference to Form1
    Public Sub New(ByRef parentForm As Form1)
        InitializeComponent()
        Me.parentForm = parentForm
    End Sub

    ' Event handler for Simpan button click
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Get the text from the textbox
        Dim watermarkText As String = inputWatermark.Text
        ' Pass the text to Form1
        parentForm.ApplyWatermark(watermarkText)
        ' Close this form
        Me.Close()
    End Sub
End Class
Public Class Form1
    Dim Form2 As New Form2
    Dim Form3 As New Form3
    Dim Form4 As New Form4

    Private Sub ПравилнаЧетПирToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2.Show()
    End Sub
    Private Sub КонусToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub
    Private Sub ЦилиндърToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    
End Class

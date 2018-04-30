Public Class Form4
    Dim h As Double
    Dim r As Double
    Dim Form2 As New Form2
    Dim Form3 As New Form3
    Dim Form4 As New Form4

    Private Sub ПравилнаЧетПирToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ПравилнаЧетПирToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub КонусToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles КонусToolStripMenuItem.Click
        Form3.Show()
    End Sub
    Private Sub ЦилиндърToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЦилиндърToolStripMenuItem.Click
        Form4.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        h = TextBox1.Text
        r = TextBox2.Text
        TextBox3.Text = 2 * 3.14 * r * (r + h)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        h = TextBox1.Text
        r = TextBox2.Text
        TextBox4.Text = 3.14 * (r * r) * h
    End Sub

    
End Class
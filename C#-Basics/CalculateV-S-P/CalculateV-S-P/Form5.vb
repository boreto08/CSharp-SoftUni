Public Class Form5
    Dim a As Double
    Dim c As Double
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
        a = TextBox1.Text
        c = TextBox3.Text
        TextBox4.Text = (a * a) * c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        c = TextBox3.Text
        TextBox5.Text = (4 * a) * c
    End Sub
End Class
Public Class Form2
    Dim a As Integer
    Dim h As Integer
    Dim k As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        h = TextBox2.Text

        TextBox4.Text = ((a * a) * h) / 3

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        h = TextBox2.Text
        k = TextBox3.Text
        TextBox5.Text = (((4 * a) * k) / 2) + a * a

    End Sub
End Class
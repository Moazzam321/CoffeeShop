Public Class Form1

    Dim b As String

    Dim l As String
    Dim k As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim a As String


        a = Val(TextBox2.Text)
        a = a + 1


        TextBox2.Text = a
        b = a * 1
        TextBox4.Text = "$" + b


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim a As String

        a = Val(TextBox3.Text)
        a = a + 1

        l = a * 3
        TextBox5.Text = "$" + l
        TextBox3.Text = a
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a As String
        a = Val(TextBox1.Text)
        a = a + 1


        TextBox1.Text = a
        k = a * 2
        TextBox6.Text = "$" + k
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox7.Text = Convert.ToInt32(k) + Convert.ToInt32(l) + Convert.ToInt32(b)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        TextBox8.Text = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As String = Val(TextBox8.Text)
        Dim g As String = i - TextBox7.Text
        Dim h As String = TextBox7.Text - i
        If i >= TextBox7.Text Then
            MessageBox.Show("Your exchange is $" + Convert.ToString(g))
        Else
            MessageBox.Show("You need to pay $" + Convert.ToString(h))


        End If
    End Sub
End Class

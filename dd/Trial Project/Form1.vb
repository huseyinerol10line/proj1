Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.ForeColor = Color.Pink
        Button5.BackColor = Color.Pink
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.ForeColor = Color.Purple
        Button6.BackColor = Color.Purple
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.ForeColor = Color.Red
        Button1.BackColor = Color.Red
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.ForeColor = Color.Blue
        Button2.BackColor = Color.Blue
        Button1.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.ForeColor = Color.Yellow
        Button3.BackColor = Color.Yellow
        Button2.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.ForeColor = Color.Green
        Button4.BackColor = Color.Green
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label1.ForeColor = Color.Black
        Button7.BackColor = Color.Black
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
        Button8.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.ForeColor = Color.White
        Button8.BackColor = Color.White
        Button2.BackColor = SystemColors.ControlLight
        Button3.BackColor = SystemColors.ControlLight
        Button4.BackColor = SystemColors.ControlLight
        Button5.BackColor = SystemColors.ControlLight
        Button6.BackColor = SystemColors.ControlLight
        Button7.BackColor = SystemColors.ControlLight
        Button1.BackColor = SystemColors.ControlLight
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label1.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label1.Text = TextBox1.Text
    End Sub
End Class

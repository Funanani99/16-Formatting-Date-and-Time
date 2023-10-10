Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox4.Text = Format(Now, "General Date")
        TextBox3.Text = Format(Now, "Long Date")
        TextBox2.Text = Format(Now, "short Date")
        TextBox1.Text = Format(Now, "Long Time")

        TextBox5.Text = Format(Now, "Short Time")
    End Sub

End Class

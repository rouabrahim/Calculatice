Public Class Form1
    Dim op As Char
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        op = "+"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        op = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        op = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        op = "/"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a = Integer.Parse(txt_A.Text)
        Dim b = Integer.Parse(txt_B.Text)
        Dim res = 0
        Dim test = True
        If op = "+" Then
            res = a + b
        ElseIf op = "-" Then
            res = a - b
        ElseIf op = "*" Then
            res = a * b
        ElseIf op = "/" And Not b = 0 Then
            res = a / b
        Else
            MessageBox.Show("veuille choisir un operateur")
            test = False
        End If
        If test Then
            lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString
        End If
    End Sub
End Class

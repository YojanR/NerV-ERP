Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
Button1: If TextBox1.Text = "Uriel" And TextBox2.Text = "1234" Then
            MsgBox("Bienvenido a NERV")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("La contraseña es incorrecta", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class

Public Class MenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Height = Height
        Panel2.Width = 120
        Panel1.Width = Width
        Panel1.Height = 100
        Panel1.Left = 0
        Panel1.Top = 0
        Panel2.Left = 0
        Panel2.Top = 0
        Panel3.Top = 0
        Panel3.Left = 0
        Panel3.Width = Panel2.Width
        Panel3.Height = Panel1.Height
        Panel4.Top = Panel1.Top + Panel1.Height
        Panel4.Left = Panel2.Left + Panel2.Width
        Panel4.Width = Width - Panel2.Width
        Panel4.Height = Height - Panel1.Height
        Button1.Left = Width - 100
        Button1.Top = Height - 100
        Panel4.GetContainerControl()


    End Sub
End Class
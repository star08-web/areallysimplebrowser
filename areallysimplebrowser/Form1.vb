Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        about.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browserurl As New Uri(url.Text)
        webView.Source = browserurl
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim browserurl As New Uri(url.Text)
        Dim homeurl As New Uri("https://google.it")
        webView.Source = homeurl
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homeurl As New Uri("https://google.it")
        webView.Source = homeurl
        url.Text = ("https://google.it")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub webView_Click(sender As Object, e As EventArgs) Handles webView.Click

    End Sub
End Class

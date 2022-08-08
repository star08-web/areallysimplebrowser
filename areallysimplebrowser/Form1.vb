Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        about.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim browserurl As New Uri("https://" + url.Text)
        webView.Source = browserurl
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim browserurl As New Uri("https://" + url.Text)
        Dim homeurl As New Uri("https://google.it")
        webView.Source = homeurl
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim homeurl As New Uri("https://google.it")
        webView.Source = homeurl
        url.Text = ("google.it")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub webView_Click(sender As Object, e As EventArgs) Handles webView.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim search As New Uri("https://www.google.it/search?q=" + searchstring.Text)
        webView.Source = search
        searchstring.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

Public Class Socials
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://x.com/DiscoverJKUAT"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.facebook.com/DiscoverJKUAT/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub
End Class

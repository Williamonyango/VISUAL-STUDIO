Public Class Socials
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://x.com/DiscoverJKUAT"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.facebook.com/DiscoverJKUAT/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

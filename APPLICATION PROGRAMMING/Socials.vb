Public Class Socials

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.facebook.com/DiscoverJKUAT/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://x.com/DiscoverJKUAT"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.facebook.com/DiscoverJKUAT/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://x.com/DiscoverJKUAT"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub
End Class

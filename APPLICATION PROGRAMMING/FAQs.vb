Public Class FAQs
    Private Sub FAQs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim psi As New ProcessStartInfo
        psi.FileName = "https://www.jkuat.ac.ke/faq/"
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub
End Class
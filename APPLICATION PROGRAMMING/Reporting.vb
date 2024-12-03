Public Class Reporting
    Private Sub Reporting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with years from Year 1 to Year 5
        ComboBox1.Items.Add("Year 1")
        ComboBox1.Items.Add("Year 2")
        ComboBox1.Items.Add("Year 3")
        ComboBox1.Items.Add("Year 4")
        ComboBox1.Items.Add("Year 5")

        ComboBox2.Items.Add("Semester 1")
        ComboBox2.Items.Add("Semester 2")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Switch to Admission form
        Dim admissionForm As New Admission()
        admissionForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
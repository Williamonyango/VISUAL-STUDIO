Public Class Message
    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox with names on form load
        ComboBox1.Items.AddRange(New String() {"Alice", "Bob", "Charlie", "Diana", "Eve"})
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Handle ComboBox selection change if needed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Message sent successfully!")
    End Sub
End Class
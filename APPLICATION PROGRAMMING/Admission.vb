Public Class Admission
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Autofit the contents of the DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Admission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add predefined rows to the DataGridView
        DataGridView1.Rows.Add("Semester 1", "01/01/2023", "Reported Online")
        DataGridView1.Rows.Add("Semester 2", "01/02/2023", "Reported Online")
        DataGridView1.Rows.Add("Semester 1", "01/03/2023", "Reported Online")
        DataGridView1.Rows.Add("Semester 2", "01/04/2023", "Reported Online")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
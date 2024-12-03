Public Class Dashboard
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub btnUnits_Click(sender As Object, e As EventArgs) Handles btnUnits.Click
        DataGridView1.Visible = True

        Me.DataGridView1.Rows.Add("Digital Signal Processing", "EEE 3516", "Approved")
        Me.DataGridView1.Rows.Add("Microprocessors and Microcontrollers", "EEE 3616", "Approved")
        Me.DataGridView1.Rows.Add("Control Systems Engineering", "EEE 3716", "Approved")
        Me.DataGridView1.Rows.Add("Power Electronics", "EEE 3816", "Approved")
        Me.DataGridView1.Rows.Add("Communication Systems", "EEE 3916", "Approved")
        Me.DataGridView1.Rows.Add("Embedded Systems", "EEE 4016", "Approved")
        Me.DataGridView1.Rows.Add("VLSI Design", "EEE 4116", "Approved")
        Me.DataGridView1.Rows.Add("Renewable Energy Systems", "EEE 4216", "Approved")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblProgress.Click
        lblProgress.Text = "Current Session Progress"
    End Sub

    Private Sub lblfee_Click(sender As Object, e As EventArgs) Handles lblfee.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 50
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
Public Class Dashboard
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnUnits_Click(sender As Object, e As EventArgs) Handles btnUnits.Click
        DataGridView1.Visible = True

        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
        Me.DataGridView1.Rows.Add("Antenna and Propagation", "EEE 2516", "Approved")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblProgress.Click

    End Sub

    Private Sub lblfee_Click(sender As Object, e As EventArgs) Handles lblfee.Click

    End Sub
End Class
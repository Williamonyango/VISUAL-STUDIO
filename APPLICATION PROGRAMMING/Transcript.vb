Imports System.ComponentModel

Public Class Transcript
    Private Sub Transcript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add content to the DataGridView
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")
        Me.DataGridView1.Rows.Add("EEE 2516", "Antenna and Propagation", "A", "PASS")

        ' Autosize columns and rows
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelTitle.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
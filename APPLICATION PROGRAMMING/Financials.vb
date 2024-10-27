Public Class Financials
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Handle the selected index change event here
        Dim selectedYear As String = ComboBox1.SelectedItem.ToString()
        PopulateDataGridView(selectedYear)
    End Sub

    Private Sub Financials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add predefined items to ComboBox1
        ComboBox1.Items.Add("Year 1")
        ComboBox1.Items.Add("Year 2")
        ComboBox1.Items.Add("Year 3")
        ComboBox1.Items.Add("Year 4")
    End Sub

    Private Sub PopulateDataGridView(year As String)
        ' Clear existing rows
        DataGridView1.Rows.Clear()

        ' Add columns if not already added
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("Column1", "Column1")
            DataGridView1.Columns.Add("Column2", "Column2")
            DataGridView1.Columns.Add("Column3", "Column3")
            ' Add more columns as needed
        End If

        ' Add rows based on the selected year
        Select Case year
            Case "Year 1"
                DataGridView1.Rows.Add("1", "Examination Fees", "1,000")
                DataGridView1.Rows.Add("2", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("3", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("4", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("5", "Computer Fees", "2,000")

                ' Add more rows as needed
            Case "Year 2"
                DataGridView1.Rows.Add("1", "Medical Feels", "5,000")
                DataGridView1.Rows.Add("2", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("3", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("4", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("5", "Computer Fees", "2,000")

                ' Add more rows as needed
            Case "Year 3"
                DataGridView1.Rows.Add("1", "Internet Fees", "3,000")
                DataGridView1.Rows.Add("2", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("3", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("4", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("5", "Computer Fees", "2,000")

                ' Add more rows as needed
            Case "Year 4"
                DataGridView1.Rows.Add("1", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("2", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("3", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("4", "Computer Fees", "2,000")
                DataGridView1.Rows.Add("5", "Computer Fees", "2,000")

                ' Add more rows as needed
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Complaints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LimeGreen
        Label1.Location = New Point(154, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 41)
        Label1.TabIndex = 0
        Label1.Text = "Complaints"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1122, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(258, 60)
        Button1.TabIndex = 1
        Button1.Text = "+ File Complaint"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DataGridView1.Location = New Point(12, 121)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1504, 410)
        DataGridView1.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "User Name"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Type"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Description"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Hostel"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Date"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Action Date"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Status"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Assignee"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 150
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Action Status"
        Column9.MinimumWidth = 8
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 150
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Remarks"
        Column10.MinimumWidth = 8
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 150
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Comments"
        Column11.MinimumWidth = 8
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 150
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Action"
        Column12.MinimumWidth = 8
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 150
        ' 
        ' Complaints
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1564, 667)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Complaints"
        Text = "Complaints"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transcript
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
        labelTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Location = New Point(507, 47)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(108, 25)
        labelTitle.TabIndex = 0
        labelTitle.Text = "RESULT SLIP"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 25)
        Label1.TabIndex = 1
        Label1.Text = "REG. NO. ENE212-0000/1999"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(158, 25)
        Label2.TabIndex = 2
        Label2.Text = "NAME: JOHN DOE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 25)
        Label3.TabIndex = 3
        Label3.Text = "PROGRAMME: Bsc. ECE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 25)
        Label4.TabIndex = 4
        Label4.Text = "YEAR: 1 SEMESTER: 1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(645, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(244, 25)
        Label5.TabIndex = 5
        Label5.Text = "ACADEMIC YEAR: 1999/2000"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(133, 286)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(666, 255)
        DataGridView1.TabIndex = 6
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "UNIT CODE"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "UNIT TITLE"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "GRADE"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "REMARK"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Transcript
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1564, 667)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(labelTitle)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Transcript"
        Text = "Transcript"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Financials
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(142, 34)
        Button1.Name = "Button1"
        Button1.Size = New Size(230, 52)
        Button1.TabIndex = 0
        Button1.Text = "Fee Structure"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.ForestGreen
        Button2.Font = New Font("Segoe UI", 15F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(455, 34)
        Button2.Name = "Button2"
        Button2.Size = New Size(221, 52)
        Button2.TabIndex = 1
        Button2.Text = "Fee Statement"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(142, 109)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(352, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.ForestGreen
        Button3.Font = New Font("Segoe UI", 15F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(518, 92)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 55)
        Button3.TabIndex = 3
        Button3.Text = "Generate"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(142, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(534, 225)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = "No"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Account"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Amount (KES)"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Financials
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1240, 659)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Financials"
        Text = "Financials"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class

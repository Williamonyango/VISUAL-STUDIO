<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        btnUnits = New Button()
        lblfee = New Label()
        lblProgress = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(74, 109)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(653, 233)
        DataGridView1.TabIndex = 20
        DataGridView1.Visible = False
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Unit Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Unit Code"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Status"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' btnUnits
        ' 
        btnUnits.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnUnits.Location = New Point(61, 32)
        btnUnits.Name = "btnUnits"
        btnUnits.Size = New Size(75, 23)
        btnUnits.TabIndex = 21
        btnUnits.Text = "Show units"
        btnUnits.UseVisualStyleBackColor = True
        ' 
        ' lblfee
        ' 
        lblfee.AutoSize = True
        lblfee.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblfee.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblfee.Location = New Point(917, 69)
        lblfee.Name = "lblfee"
        lblfee.Size = New Size(113, 25)
        lblfee.TabIndex = 22
        lblfee.Text = "Fee Balance"
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        lblProgress.Location = New Point(917, 288)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(85, 25)
        lblProgress.TabIndex = 23
        lblProgress.Text = "Progress"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1095, 400)
        Controls.Add(lblProgress)
        Controls.Add(lblfee)
        Controls.Add(btnUnits)
        Controls.Add(DataGridView1)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnUnits As Button
    Friend WithEvents lblfee As Label
    Friend WithEvents lblProgress As Label
End Class

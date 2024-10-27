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
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
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
        DataGridView1.Location = New Point(106, 182)
        DataGridView1.Margin = New Padding(4, 5, 4, 5)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(933, 388)
        DataGridView1.TabIndex = 20
        DataGridView1.Visible = False
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Unit Name"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Unit Code"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Status"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' btnUnits
        ' 
        btnUnits.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        btnUnits.ForeColor = Color.LimeGreen
        btnUnits.Location = New Point(106, 53)
        btnUnits.Margin = New Padding(4, 5, 4, 5)
        btnUnits.Name = "btnUnits"
        btnUnits.Size = New Size(199, 83)
        btnUnits.TabIndex = 21
        btnUnits.Text = "Show units"
        btnUnits.UseVisualStyleBackColor = True
        ' 
        ' lblfee
        ' 
        lblfee.AutoSize = True
        lblfee.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblfee.ForeColor = Color.LimeGreen
        lblfee.Location = New Point(1308, 117)
        lblfee.Margin = New Padding(4, 0, 4, 0)
        lblfee.Name = "lblfee"
        lblfee.Size = New Size(179, 41)
        lblfee.TabIndex = 22
        lblfee.Text = "Fee Balance"
        ' 
        ' lblProgress
        ' 
        lblProgress.AutoSize = True
        lblProgress.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgress.ForeColor = Color.LimeGreen
        lblProgress.Location = New Point(1308, 440)
        lblProgress.Margin = New Padding(4, 0, 4, 0)
        lblProgress.Name = "lblProgress"
        lblProgress.Size = New Size(136, 41)
        lblProgress.TabIndex = 23
        lblProgress.Text = "Progress"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(1361, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 25)
        Label1.TabIndex = 24
        Label1.Text = "KES 0.00"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(1308, 543)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(218, 39)
        ProgressBar1.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1308, 490)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 50)
        Label2.TabIndex = 26
        Label2.Text = "Bsc. ECE" & vbCrLf & "Current Session Progress" & vbCrLf
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1564, 667)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Controls.Add(lblProgress)
        Controls.Add(lblfee)
        Controls.Add(btnUnits)
        Controls.Add(DataGridView1)
        Margin = New Padding(4, 5, 4, 5)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
End Class

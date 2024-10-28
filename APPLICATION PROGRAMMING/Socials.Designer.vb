<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socials
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
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Lime
        LinkLabel1.Font = New Font("Segoe UI", 15F)
        LinkLabel1.LinkColor = Color.Blue
        LinkLabel1.Location = New Point(736, 105)
        LinkLabel1.Margin = New Padding(5, 0, 5, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(208, 41)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Go to Website"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Lime
        LinkLabel2.Font = New Font("Segoe UI", 15F)
        LinkLabel2.LinkColor = Color.Blue
        LinkLabel2.Location = New Point(736, 266)
        LinkLabel2.Margin = New Padding(5, 0, 5, 0)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(241, 41)
        LinkLabel2.TabIndex = 4
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "@DiscoverJKUAT"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.BackColor = Color.Lime
        LinkLabel3.Font = New Font("Segoe UI", 15F)
        LinkLabel3.LinkColor = Color.Blue
        LinkLabel3.Location = New Point(736, 419)
        LinkLabel3.Margin = New Padding(5, 0, 5, 0)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(212, 41)
        LinkLabel3.TabIndex = 5
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "DiscoverJKUAT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.LimeGreen
        Label1.Location = New Point(454, 105)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 41)
        Label1.TabIndex = 6
        Label1.Text = "Website"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.LimeGreen
        Label2.Location = New Point(454, 266)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 41)
        Label2.TabIndex = 7
        Label2.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.LimeGreen
        Label3.Location = New Point(444, 433)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 41)
        Label3.TabIndex = 8
        Label3.Text = "Facebook"
        ' 
        ' Socials
        ' 
        AutoScaleDimensions = New SizeF(18F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2815, 1094)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        ForeColor = Color.LimeGreen
        Margin = New Padding(7, 8, 7, 8)
        Name = "Socials"
        Text = "Socials"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

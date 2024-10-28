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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 15F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(193, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(274, 97)
        Button1.TabIndex = 0
        Button1.Text = "Go to Website"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.ForestGreen
        Button2.Font = New Font("Segoe UI", 15F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(193, 161)
        Button2.Name = "Button2"
        Button2.Size = New Size(274, 97)
        Button2.TabIndex = 1
        Button2.Text = "@DiscoverJKUAT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.ForestGreen
        Button3.Font = New Font("Segoe UI", 15F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(193, 286)
        Button3.Name = "Button3"
        Button3.Size = New Size(274, 97)
        Button3.TabIndex = 2
        Button3.Text = "DiscoverJKUAT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Socials
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1564, 667)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Socials"
        Text = "Socials"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

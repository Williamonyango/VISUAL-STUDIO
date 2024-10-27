<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.ForestGreen
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 41)
        Label1.TabIndex = 0
        Label1.Text = "All Contacts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.ForestGreen
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(296, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 41)
        Label2.TabIndex = 1
        Label2.Text = "Inbox"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(98, 103)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(500, 206)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(439, 331)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 58)
        Button1.TabIndex = 3
        Button1.Text = "Send"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Message
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1564, 667)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Message"
        Text = "Message"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class

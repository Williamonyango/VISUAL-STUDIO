<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporting
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
        Label3 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.ForeColor = Color.ForestGreen
        Label1.Location = New Point(581, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 41)
        Label1.TabIndex = 0
        Label1.Text = "Online Reporting"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Cursor = Cursors.No
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.ForestGreen
        Label2.Location = New Point(270, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 41)
        Label2.TabIndex = 1
        Label2.Text = "Year"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.ForeColor = Color.ForestGreen
        Label3.Location = New Point(815, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 41)
        Label3.TabIndex = 2
        Label3.Text = "Semester"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"EEE 2121 Application Programming", "EEE 3516 Digital Signal Processing", "EEE 3616" & vbTab & " Microprocessors and Microcontrollers", "EEE 3816 Power Electronics", "EEE 4016" & vbTab & "Communication Systems", "EEE 4216 Renewable Energy", "EEE 3916" & vbTab & " Embedded Systems", "EEE 4106 " & vbTab & "VLSI Design"})
        CheckedListBox1.Location = New Point(433, 216)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(390, 228)
        CheckedListBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(668, 476)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 53)
        Button1.TabIndex = 4
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(373, 111)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(983, 114)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 6
        ' 
        ' Reporting
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1551, 773)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(CheckedListBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Reporting"
        Text = "Reporting"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class

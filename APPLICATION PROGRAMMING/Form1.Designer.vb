<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblRegNumber = New Label()
        lblCourse = New Label()
        txtFname = New TextBox()
        txtSname = New TextBox()
        txtCourse = New TextBox()
        lblWelcome = New Label()
        btnDashboard = New Button()
        btnSocial = New Button()
        btnMessage = New Button()
        Button4 = New Button()
        btnAdmission = New Button()
        btnAcademic = New Button()
        btnFinacials = New Button()
        Button8 = New Button()
        btnComplaints = New Button()
        btnFAQs = New Button()
        btnLogin = New Button()
        Panel1 = New Panel()
        lblFname = New Label()
        lblWelcomeMessage = New Label()
        SuspendLayout()
        ' 
        ' lblRegNumber
        ' 
        lblRegNumber.AutoSize = True
        lblRegNumber.Font = New Font("Segoe UI", 15F)
        lblRegNumber.ForeColor = Color.ForestGreen
        lblRegNumber.Location = New Point(787, 95)
        lblRegNumber.Margin = New Padding(4, 0, 4, 0)
        lblRegNumber.Name = "lblRegNumber"
        lblRegNumber.Size = New Size(131, 41)
        lblRegNumber.TabIndex = 1
        lblRegNumber.Text = "Reg. No."
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 15F)
        lblCourse.ForeColor = Color.ForestGreen
        lblCourse.Location = New Point(1157, 93)
        lblCourse.Margin = New Padding(4, 0, 4, 0)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(111, 41)
        lblCourse.TabIndex = 2
        lblCourse.Text = "Course"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(525, 105)
        txtFname.Margin = New Padding(4, 5, 4, 5)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(221, 31)
        txtFname.TabIndex = 3
        ' 
        ' txtSname
        ' 
        txtSname.Location = New Point(946, 105)
        txtSname.Margin = New Padding(4, 5, 4, 5)
        txtSname.Name = "txtSname"
        txtSname.Size = New Size(183, 31)
        txtSname.TabIndex = 4
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(1276, 103)
        txtCourse.Margin = New Padding(4, 5, 4, 5)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(141, 31)
        txtCourse.TabIndex = 5
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.ForestGreen
        lblWelcome.Location = New Point(481, 43)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(997, 41)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome to Jomo Kenyatta  University of Agriculture and Technology"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(40, 182)
        btnDashboard.Margin = New Padding(4, 5, 4, 5)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(130, 38)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        btnDashboard.Visible = False
        ' 
        ' btnSocial
        ' 
        btnSocial.Location = New Point(40, 230)
        btnSocial.Margin = New Padding(4, 5, 4, 5)
        btnSocial.Name = "btnSocial"
        btnSocial.Size = New Size(130, 38)
        btnSocial.TabIndex = 8
        btnSocial.Text = "Socials"
        btnSocial.UseVisualStyleBackColor = True
        btnSocial.Visible = False
        ' 
        ' btnMessage
        ' 
        btnMessage.Location = New Point(40, 278)
        btnMessage.Margin = New Padding(4, 5, 4, 5)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(130, 38)
        btnMessage.TabIndex = 9
        btnMessage.Text = "Message"
        btnMessage.UseVisualStyleBackColor = True
        btnMessage.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(61, 345)
        Button4.Margin = New Padding(4, 5, 4, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(11, 13)
        Button4.TabIndex = 10
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnAdmission
        ' 
        btnAdmission.Location = New Point(40, 327)
        btnAdmission.Margin = New Padding(4, 5, 4, 5)
        btnAdmission.Name = "btnAdmission"
        btnAdmission.Size = New Size(130, 38)
        btnAdmission.TabIndex = 11
        btnAdmission.Text = "Admission"
        btnAdmission.UseVisualStyleBackColor = True
        btnAdmission.Visible = False
        ' 
        ' btnAcademic
        ' 
        btnAcademic.Location = New Point(40, 375)
        btnAcademic.Margin = New Padding(4, 5, 4, 5)
        btnAcademic.Name = "btnAcademic"
        btnAcademic.Size = New Size(130, 38)
        btnAcademic.TabIndex = 12
        btnAcademic.Text = "Academic"
        btnAcademic.UseVisualStyleBackColor = True
        btnAcademic.Visible = False
        ' 
        ' btnFinacials
        ' 
        btnFinacials.Location = New Point(40, 423)
        btnFinacials.Margin = New Padding(4, 5, 4, 5)
        btnFinacials.Name = "btnFinacials"
        btnFinacials.Size = New Size(130, 38)
        btnFinacials.TabIndex = 13
        btnFinacials.Text = "Financials"
        btnFinacials.UseVisualStyleBackColor = True
        btnFinacials.Visible = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(159, 638)
        Button8.Margin = New Padding(4, 5, 4, 5)
        Button8.Name = "Button8"
        Button8.Size = New Size(11, 13)
        Button8.TabIndex = 14
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' btnComplaints
        ' 
        btnComplaints.Location = New Point(40, 472)
        btnComplaints.Margin = New Padding(4, 5, 4, 5)
        btnComplaints.Name = "btnComplaints"
        btnComplaints.Size = New Size(130, 38)
        btnComplaints.TabIndex = 15
        btnComplaints.Text = "Complaints"
        btnComplaints.UseVisualStyleBackColor = True
        btnComplaints.Visible = False
        ' 
        ' btnFAQs
        ' 
        btnFAQs.Location = New Point(40, 520)
        btnFAQs.Margin = New Padding(4, 5, 4, 5)
        btnFAQs.Name = "btnFAQs"
        btnFAQs.Size = New Size(130, 38)
        btnFAQs.TabIndex = 16
        btnFAQs.Text = "FAQs"
        btnFAQs.UseVisualStyleBackColor = True
        btnFAQs.Visible = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.ForestGreen
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(1546, 78)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(111, 65)
        btnLogin.TabIndex = 17
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(179, 192)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1587, 732)
        Panel1.TabIndex = 21
        ' 
        ' lblFname
        ' 
        lblFname.AutoSize = True
        lblFname.Font = New Font("Segoe UI", 15F)
        lblFname.ForeColor = Color.ForestGreen
        lblFname.Location = New Point(408, 95)
        lblFname.Margin = New Padding(4, 0, 4, 0)
        lblFname.Name = "lblFname"
        lblFname.Size = New Size(97, 41)
        lblFname.TabIndex = 0
        lblFname.Text = "Name"
        ' 
        ' lblWelcomeMessage
        ' 
        lblWelcomeMessage.AutoSize = True
        lblWelcomeMessage.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcomeMessage.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblWelcomeMessage.Location = New Point(579, 150)
        lblWelcomeMessage.Margin = New Padding(4, 0, 4, 0)
        lblWelcomeMessage.Name = "lblWelcomeMessage"
        lblWelcomeMessage.Size = New Size(99, 32)
        lblWelcomeMessage.TabIndex = 20
        lblWelcomeMessage.Text = "Label1"
        lblWelcomeMessage.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1783, 918)
        Controls.Add(Panel1)
        Controls.Add(lblWelcomeMessage)
        Controls.Add(btnLogin)
        Controls.Add(btnFAQs)
        Controls.Add(btnComplaints)
        Controls.Add(Button8)
        Controls.Add(btnFinacials)
        Controls.Add(btnAcademic)
        Controls.Add(btnAdmission)
        Controls.Add(Button4)
        Controls.Add(btnMessage)
        Controls.Add(btnSocial)
        Controls.Add(btnDashboard)
        Controls.Add(lblWelcome)
        Controls.Add(txtCourse)
        Controls.Add(txtSname)
        Controls.Add(txtFname)
        Controls.Add(lblCourse)
        Controls.Add(lblRegNumber)
        Controls.Add(lblFname)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblRegNumber As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtSname As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnSocial As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnAdmission As Button
    Friend WithEvents btnAcademic As Button
    Friend WithEvents btnFinacials As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnComplaints As Button
    Friend WithEvents btnFAQs As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFname As Label
    Friend WithEvents lblWelcomeMessage As Label

End Class

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
        btnAdmission = New Button()
        btnAcademic = New Button()
        btnFinacials = New Button()
        btnComplaints = New Button()
        btnFAQs = New Button()
        btnLogin = New Button()
        lblFname = New Label()
        lblWelcomeMessage = New Label()
        Panel1 = New Panel()
        btnReporting = New Button()
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
        lblWelcome.Location = New Point(481, 24)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(997, 41)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome to Jomo Kenyatta  University of Agriculture and Technology"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.ForestGreen
        btnDashboard.Font = New Font("Segoe UI", 15F)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(40, 182)
        btnDashboard.Margin = New Padding(4, 5, 4, 5)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(171, 52)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        btnDashboard.Visible = False
        ' 
        ' btnSocial
        ' 
        btnSocial.BackColor = Color.ForestGreen
        btnSocial.Font = New Font("Segoe UI", 15F)
        btnSocial.ForeColor = Color.White
        btnSocial.Location = New Point(40, 244)
        btnSocial.Margin = New Padding(4, 5, 4, 5)
        btnSocial.Name = "btnSocial"
        btnSocial.Size = New Size(130, 50)
        btnSocial.TabIndex = 8
        btnSocial.Text = "Socials"
        btnSocial.UseVisualStyleBackColor = False
        btnSocial.Visible = False
        ' 
        ' btnMessage
        ' 
        btnMessage.BackColor = Color.ForestGreen
        btnMessage.Font = New Font("Segoe UI", 15F)
        btnMessage.ForeColor = Color.White
        btnMessage.Location = New Point(33, 318)
        btnMessage.Margin = New Padding(4, 5, 4, 5)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(164, 57)
        btnMessage.TabIndex = 9
        btnMessage.Text = "Messages"
        btnMessage.UseVisualStyleBackColor = False
        btnMessage.Visible = False
        ' 
        ' btnAdmission
        ' 
        btnAdmission.BackColor = Color.ForestGreen
        btnAdmission.Font = New Font("Segoe UI", 15F)
        btnAdmission.ForeColor = Color.White
        btnAdmission.Location = New Point(33, 398)
        btnAdmission.Margin = New Padding(4, 5, 4, 5)
        btnAdmission.Name = "btnAdmission"
        btnAdmission.Size = New Size(171, 57)
        btnAdmission.TabIndex = 11
        btnAdmission.Text = "Admissions"
        btnAdmission.UseVisualStyleBackColor = False
        btnAdmission.Visible = False
        ' 
        ' btnAcademic
        ' 
        btnAcademic.BackColor = Color.ForestGreen
        btnAcademic.Font = New Font("Segoe UI", 15F)
        btnAcademic.ForeColor = Color.White
        btnAcademic.Location = New Point(33, 535)
        btnAcademic.Margin = New Padding(4, 5, 4, 5)
        btnAcademic.Name = "btnAcademic"
        btnAcademic.Size = New Size(164, 50)
        btnAcademic.TabIndex = 12
        btnAcademic.Text = "Academic"
        btnAcademic.UseVisualStyleBackColor = False
        btnAcademic.Visible = False
        ' 
        ' btnFinacials
        ' 
        btnFinacials.BackColor = Color.ForestGreen
        btnFinacials.Font = New Font("Segoe UI", 15F)
        btnFinacials.ForeColor = Color.White
        btnFinacials.Location = New Point(33, 600)
        btnFinacials.Margin = New Padding(4, 5, 4, 5)
        btnFinacials.Name = "btnFinacials"
        btnFinacials.Size = New Size(164, 51)
        btnFinacials.TabIndex = 13
        btnFinacials.Text = "Financials"
        btnFinacials.UseVisualStyleBackColor = False
        btnFinacials.Visible = False
        ' 
        ' btnComplaints
        ' 
        btnComplaints.BackColor = Color.ForestGreen
        btnComplaints.Font = New Font("Segoe UI", 15F)
        btnComplaints.ForeColor = Color.White
        btnComplaints.Location = New Point(33, 661)
        btnComplaints.Margin = New Padding(4, 5, 4, 5)
        btnComplaints.Name = "btnComplaints"
        btnComplaints.Size = New Size(187, 49)
        btnComplaints.TabIndex = 15
        btnComplaints.Text = "Complaints"
        btnComplaints.UseVisualStyleBackColor = False
        btnComplaints.Visible = False
        ' 
        ' btnFAQs
        ' 
        btnFAQs.BackColor = Color.ForestGreen
        btnFAQs.Font = New Font("Segoe UI", 15F)
        btnFAQs.ForeColor = Color.White
        btnFAQs.Location = New Point(33, 720)
        btnFAQs.Margin = New Padding(4, 5, 4, 5)
        btnFAQs.Name = "btnFAQs"
        btnFAQs.Size = New Size(130, 48)
        btnFAQs.TabIndex = 16
        btnFAQs.Text = "FAQs"
        btnFAQs.UseVisualStyleBackColor = False
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
        lblWelcomeMessage.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWelcomeMessage.ForeColor = Color.LimeGreen
        lblWelcomeMessage.Location = New Point(582, 145)
        lblWelcomeMessage.Margin = New Padding(4, 0, 4, 0)
        lblWelcomeMessage.Name = "lblWelcomeMessage"
        lblWelcomeMessage.Size = New Size(105, 36)
        lblWelcomeMessage.TabIndex = 20
        lblWelcomeMessage.Text = "Label1"
        lblWelcomeMessage.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(235, 182)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1691, 736)
        Panel1.TabIndex = 21
        ' 
        ' btnReporting
        ' 
        btnReporting.BackColor = Color.ForestGreen
        btnReporting.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReporting.ForeColor = Color.White
        btnReporting.Location = New Point(40, 477)
        btnReporting.Name = "btnReporting"
        btnReporting.Size = New Size(158, 50)
        btnReporting.TabIndex = 0
        btnReporting.Text = "Reporting"
        btnReporting.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1783, 918)
        Controls.Add(btnReporting)
        Controls.Add(Panel1)
        Controls.Add(lblWelcomeMessage)
        Controls.Add(btnLogin)
        Controls.Add(btnFAQs)
        Controls.Add(btnComplaints)
        Controls.Add(btnFinacials)
        Controls.Add(btnAcademic)
        Controls.Add(btnAdmission)
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
    Friend WithEvents btnAdmission As Button
    Friend WithEvents btnAcademic As Button
    Friend WithEvents btnFinacials As Button
    Friend WithEvents btnComplaints As Button
    Friend WithEvents btnFAQs As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblFname As Label
    Friend WithEvents lblWelcomeMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnReporting As Button

End Class

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
        lblFname = New Label()
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
        lblWelcomeMessage = New Label()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' lblFname
        ' 
        lblFname.AutoSize = True
        lblFname.Location = New Point(256, 71)
        lblFname.Name = "lblFname"
        lblFname.Size = New Size(143, 15)
        lblFname.TabIndex = 0
        lblFname.Text = "ENTER YOUR FIRST NAME"
        ' 
        ' lblRegNumber
        ' 
        lblRegNumber.AutoSize = True
        lblRegNumber.Location = New Point(542, 71)
        lblRegNumber.Name = "lblRegNumber"
        lblRegNumber.Size = New Size(150, 15)
        lblRegNumber.TabIndex = 1
        lblRegNumber.Text = "ENTER YOUR REG NUMBER"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(826, 70)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(51, 15)
        lblCourse.TabIndex = 2
        lblCourse.Text = "COURSE"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(405, 63)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(118, 23)
        txtFname.TabIndex = 3
        ' 
        ' txtSname
        ' 
        txtSname.Location = New Point(691, 63)
        txtSname.Name = "txtSname"
        txtSname.Size = New Size(129, 23)
        txtSname.TabIndex = 4
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(893, 62)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(100, 23)
        txtCourse.TabIndex = 5
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.MediumAquamarine
        lblWelcome.Location = New Point(335, 36)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(578, 22)
        lblWelcome.TabIndex = 6
        lblWelcome.Text = "Welcome to Jomo Kenyatta  University of Agriculture and Technology"
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Location = New Point(28, 109)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(91, 23)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = True
        btnDashboard.Visible = False
        ' 
        ' btnSocial
        ' 
        btnSocial.Location = New Point(28, 138)
        btnSocial.Name = "btnSocial"
        btnSocial.Size = New Size(91, 23)
        btnSocial.TabIndex = 8
        btnSocial.Text = "Socials"
        btnSocial.UseVisualStyleBackColor = True
        btnSocial.Visible = False
        ' 
        ' btnMessage
        ' 
        btnMessage.Location = New Point(28, 167)
        btnMessage.Name = "btnMessage"
        btnMessage.Size = New Size(91, 23)
        btnMessage.TabIndex = 9
        btnMessage.Text = "Message"
        btnMessage.UseVisualStyleBackColor = True
        btnMessage.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(43, 207)
        Button4.Name = "Button4"
        Button4.Size = New Size(8, 8)
        Button4.TabIndex = 10
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnAdmission
        ' 
        btnAdmission.Location = New Point(28, 196)
        btnAdmission.Name = "btnAdmission"
        btnAdmission.Size = New Size(91, 23)
        btnAdmission.TabIndex = 11
        btnAdmission.Text = "Admission"
        btnAdmission.UseVisualStyleBackColor = True
        btnAdmission.Visible = False
        ' 
        ' btnAcademic
        ' 
        btnAcademic.Location = New Point(28, 225)
        btnAcademic.Name = "btnAcademic"
        btnAcademic.Size = New Size(91, 23)
        btnAcademic.TabIndex = 12
        btnAcademic.Text = "Academic"
        btnAcademic.UseVisualStyleBackColor = True
        btnAcademic.Visible = False
        ' 
        ' btnFinacials
        ' 
        btnFinacials.Location = New Point(28, 254)
        btnFinacials.Name = "btnFinacials"
        btnFinacials.Size = New Size(91, 23)
        btnFinacials.TabIndex = 13
        btnFinacials.Text = "Financials"
        btnFinacials.UseVisualStyleBackColor = True
        btnFinacials.Visible = False
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(111, 383)
        Button8.Name = "Button8"
        Button8.Size = New Size(8, 8)
        Button8.TabIndex = 14
        Button8.Text = "Button8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' btnComplaints
        ' 
        btnComplaints.Location = New Point(28, 283)
        btnComplaints.Name = "btnComplaints"
        btnComplaints.Size = New Size(91, 23)
        btnComplaints.TabIndex = 15
        btnComplaints.Text = "Complaints"
        btnComplaints.UseVisualStyleBackColor = True
        btnComplaints.Visible = False
        ' 
        ' btnFAQs
        ' 
        btnFAQs.Location = New Point(28, 312)
        btnFAQs.Name = "btnFAQs"
        btnFAQs.Size = New Size(91, 23)
        btnFAQs.TabIndex = 16
        btnFAQs.Text = "FAQs"
        btnFAQs.UseVisualStyleBackColor = True
        btnFAQs.Visible = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(1085, 47)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 39)
        btnLogin.TabIndex = 17
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblWelcomeMessage
        ' 
        lblWelcomeMessage.AutoSize = True
        lblWelcomeMessage.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcomeMessage.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblWelcomeMessage.Location = New Point(405, 90)
        lblWelcomeMessage.Name = "lblWelcomeMessage"
        lblWelcomeMessage.Size = New Size(66, 22)
        lblWelcomeMessage.TabIndex = 20
        lblWelcomeMessage.Text = "Label1"
        lblWelcomeMessage.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(125, 115)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1111, 439)
        Panel1.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 551)
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
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFname As Label
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
    Friend WithEvents lblWelcomeMessage As Label
    Friend WithEvents Panel1 As Panel

End Class

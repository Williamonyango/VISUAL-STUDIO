﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReporting.Visible = False
        btnLogout.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        btnAcademic.Visible = True
        btnAdmission.Visible = True
        btnComplaints.Visible = True
        btnDashboard.Visible = True
        btnFAQs.Visible = True
        btnMessage.Visible = True
        btnFinacials.Visible = True
        btnSocial.Visible = True
        btnReporting.Visible = True
        btnLogout.Visible = True

        lblFname.Visible = False
        lblRegNumber.Visible = False
        lblCourse.Visible = False

        Dim userName As String = txtFname.Text


        lblWelcomeMessage.Text = "Welcome back " + userName
        lblWelcomeMessage.Visible = True


        txtFname.Visible = False
        txtSname.Visible = False
        txtCourse.Visible = False

        btnLogin.Visible = False
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(Dashboard)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnSocial_Click(sender As Object, e As EventArgs) Handles btnSocial.Click
        switchPanel(Socials)
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        switchPanel(Message)
    End Sub

    Private Sub btnAdmission_Click(sender As Object, e As EventArgs) Handles btnAdmission.Click
        switchPanel(Admission)
    End Sub
    Private Sub btnReporting_Click(sender As Object, e As EventArgs) Handles btnReporting.Click
        switchPanel(Reporting)
    End Sub
    Private Sub btnAcademic_Click(sender As Object, e As EventArgs) Handles btnAcademic.Click
        switchPanel(Transcript)
    End Sub

    Private Sub btnComplaints_Click(sender As Object, e As EventArgs) Handles btnComplaints.Click
        switchPanel(Complaints)
    End Sub

    Private Sub btnFAQs_Click(sender As Object, e As EventArgs) Handles btnFAQs.Click
        switchPanel(FAQs)
    End Sub

    Private Sub lblWelcomeMessage_Click(sender As Object, e As EventArgs) Handles lblWelcomeMessage.Click

    End Sub

    Private Sub btnFinacials_Click(sender As Object, e As EventArgs) Handles btnFinacials.Click
        switchPanel(Financials)
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class

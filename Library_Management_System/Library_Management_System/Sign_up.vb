Imports System.Data
Imports System.Data.SqlClient
Public Class Sign_up
    Private Sub Label8_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    'Dim count As Integer = text_password.TextLength
    Dim res As Integer
    Function validation()
        If text_firstname.Text = "" Or text_lastname.Text = "" Or text_username.Text = "" Or text_password.Text = "" Or text_conpassword.Text = "" Or text_contactno.Text = "" Then
            MessageBox.Show("Please fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        ElseIf text_password.Text <> text_conpassword.Text Then
            MessageBox.Show("Password does not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_password.Text = ""
            text_conpassword.Text = ""
            Return 1
        ElseIf text_contactno.TextLength <= 9 Then
            MessageBox.Show("Contact Number should be of 10 Digits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_contactno.Text = ""
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function check_password()
        Dim count As Integer
        count = text_password.TextLength
        If count <= 7 Then
            lbl_password.Text = "password should be of 8 characters"
            Return 1
        Else
            lbl_password.Text = ""
            Return 0
        End If
    End Function

    Private Sub btn_sign_up_Click(sender As Object, e As EventArgs) Handles btn_sign_up.Click
        Dim result As Integer
        result = validation()
        If result = 0 Then
            If res = 0 Then
                Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")
                con.Open()
                Dim cmd As SqlCommand = New SqlCommand("INSERT INTO Sign_up
        VALUES ('" + text_firstname.Text + "','" + text_lastname.Text + "','" + text_username.Text + "','" + text_password.Text + "','" + text_contactno.Text + "')")
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                Dim res = New DialogResult
                res = MessageBox.Show("Registered Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                If res = 1 Then
                    Dim DU = New Login
                    DU.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim DU = New Login
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub text_contactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_contactno.KeyPress
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Allowed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub text_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_password.KeyPress
        res = check_password()
    End Sub

    Private Sub text_password_Leave(sender As Object, e As EventArgs) Handles text_password.Leave
        lbl_password.Text = ""
    End Sub
End Class
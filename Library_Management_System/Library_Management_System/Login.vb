Imports System.Data.SqlClient

Public Class Login
    Function validation()
        If text_username.Text = "" Then
            MessageBox.Show("Enter Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        ElseIf text_password.Text = "" Then
            MessageBox.Show("Enter Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub check_record()
        Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")
        con.Open()
        Dim query = "select * from Sign_up where Username = '" & text_username.Text & "' and Password = '" & text_password.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        Dim d As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim ds As DataSet = New DataSet()
        d.Fill(ds)
        Dim var As Integer
        var = ds.Tables(0).Rows.Count

        If var = 0 Then
            MessageBox.Show("Incorrect Username or Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_username.Text = ""
            text_password.Text = ""
        Else
            MessageBox.Show("Login Succesfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim home = New Report
            home.Show()
            Me.Hide()
        End If
        con.Close()
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim login = New Sign_up
        login.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim result As Integer
        result = validation()
        If result = 0 Then
            check_record()
        End If
    End Sub

    Private Sub text_password_Click(sender As Object, e As EventArgs) 
        text_password.PasswordChar = "*"
    End Sub
End Class
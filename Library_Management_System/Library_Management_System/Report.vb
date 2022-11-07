Imports System.Data.SqlClient

Public Class Report
    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")

    Private Sub display_bookrecords()
        Try
            con.Open()
            Dim query = "select Student_ID,Student_Name,Book_ID,Book_Name,Issue_Date,Return_Date,Fine from Return_books"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As SqlDataAdapter
            Adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(Adapter)
            Dim Ds = New DataSet()
            Adapter.Fill(Ds)
            report_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub display_student()
        Try
            con.Open()
            Dim query = "select count(*) from Student_records"
            Dim cmd = New SqlCommand(query, con)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            lbl_student.Text = count
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub display_books()
        Try
            con.Open()
            Dim query = "select count(*) from Books_records"
            Dim cmd = New SqlCommand(query, con)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            lbl_books.Text = count
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub display_issuebook()
        Try
            con.Open()
            Dim query = "select count(*) from Issue_books"
            Dim cmd = New SqlCommand(query, con)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            lbl_issuebook.Text = count
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub display_returnbook()
        Try
            con.Open()
            Dim query = "select count(*) from Return_books"
            Dim cmd = New SqlCommand(query, con)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            lbl_bookreturn.Text = count
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub display_fine()
        Try
            con.Open()
            Dim query = "select sum(Fine) from Return_books"
            Dim cmd = New SqlCommand(query, con)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            lbl_fine.Text = count
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_student()
        display_books()
        display_issuebook()
        display_returnbook()
        display_fine()
        display_bookrecords()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs)
        Dim DU = New Home_page
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label1.Click
        Dim DU = New Student_records
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Panel5.Click, Label2.Click
        Dim DU = New Add_Books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click, Panel6.Click, Label3.Click
        Dim DU = New Issue_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Panel7.Click, Label4.Click
        Dim DU = New Return_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click, Panel8.Click, Label5.Click
        Dim DU = New Search_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click, Panel3.Click, Panel10.Click, Label10.Click
        Dim DU = New Report
        DU.Show()
        DU.Hide()
    End Sub

    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click, Panel12.Click, Label9.Click
        Dim DU = New Login
        DU.Show()
        Me.Hide()
    End Sub
End Class
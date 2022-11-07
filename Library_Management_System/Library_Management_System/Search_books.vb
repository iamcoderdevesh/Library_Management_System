Imports System.Data.SqlClient

Public Class Search_books

    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")

    Private Sub display_booksrecords()
        Try
            con.Open()
            Dim query = "select * from Books_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As SqlDataAdapter
            Adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(Adapter)
            Dim Ds = New DataSet()
            Adapter.Fill(Ds)
            searchbook_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fill_book()
        Try
            con.Open()
            Dim query = "select * from Books_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            Adapter.Fill(table)

            If cmb_searchbook.SelectedIndex = 0 Then
                cmb_search.DataSource = table
                cmb_search.DisplayMember = "Book_ID"
                cmb_search.ValueMember = "Book_ID"

            ElseIf cmb_searchbook.SelectedIndex = 1 Then
                cmb_search.DataSource = table
                cmb_search.DisplayMember = "Book_Name"
                cmb_search.ValueMember = "Book_Name"

            ElseIf cmb_searchbook.SelectedIndex = 2 Then
                cmb_search.DataSource = table
                cmb_search.DisplayMember = "Book_Author"
                cmb_search.ValueMember = "Book_Author"

            ElseIf cmb_searchbook.SelectedIndex = 3 Then
                cmb_search.DataSource = table
                cmb_search.DisplayMember = "Book_Publisher"
                cmb_search.ValueMember = "Book_Publisher"

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub getbooks()
        Try
            con.Open()
            Dim query = "select * from Books_records where " & cmb_searchbook.SelectedItem.ToString() & " = '" & cmb_search.Text & "'"
            Dim cmd = New SqlCommand(query, con)
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                reader.Close()
                Dim Adapter As SqlDataAdapter
                Adapter = New SqlDataAdapter(cmd)
                Dim builder = New SqlCommandBuilder(Adapter)
                Dim Ds = New DataSet()
                Adapter.Fill(Ds)
                searchbook_DGV.DataSource = Ds.Tables(0)
            Else
                Dim result As DialogResult = MessageBox.Show("No records found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Search_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_booksrecords()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If cmb_searchbook.SelectedIndex = -1 Or cmb_search.SelectedIndex = -1 Then
            MessageBox.Show("missing information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            getbooks()
        End If
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label8.Click
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

    Private Sub cmb_searchbook_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_searchbook.SelectionChangeCommitted
        fill_book()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Panel10.Click, Label10.Click
        Dim DU = New Report
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click, Panel9.Click, Label6.Click
        Dim DU = New Login
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
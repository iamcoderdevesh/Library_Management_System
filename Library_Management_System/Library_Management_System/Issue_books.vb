Imports System.Data.SqlClient
Public Class Issue_books

    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")
    Dim ID = 0
    Dim id1 As String
    Public Function validation()
        Dim i As Integer
        i = 0
        If cmb_rollno.SelectedIndex = -1 Or cmb_bookname.SelectedIndex = -1 Or text_name.Text = "" Or text_bookid.Text = "" Then
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return i + 1
        Else
            Return i
        End If
    End Function

    Public Function check_books() As Integer
        Dim i As Integer
        Dim val As String
        i = 0
        If ConnectionState.Open Then
            con.Close()
            Try
                con.Open()
                Dim query = "Select Student_ID from Issue_books"
                Dim cmd = New SqlCommand(query, con)
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader()
                While reader.Read
                    val = reader("Student_ID").ToString()
                    If val.Equals(cmb_rollno.Text.ToString()) Then
                        MessageBox.Show("Book is Already issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return i + 1
                        Exit While
                    End If
                End While
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Return i
    End Function
    Private Sub getID()
        Try
            con.Open()
            Dim query = "Select max(Issue_No) from Issue_books"
            Dim cmd = New SqlCommand(query, con)
            Dim Data As New DataTable
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                id1 = "" + reader(0).ToString()
                If id1 = "" Then
                    id1 = 1
                Else
                    Dim val As Integer = Integer.Parse(id1)
                    val = val + 1
                    id1 = val.ToString()
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Reset()
        cmb_rollno.SelectedIndex = -1
        cmb_bookname.SelectedIndex = -1
        text_name.Text = ""
        text_bookid.Text = ""
    End Sub
    Private Sub display_booksrecords()
        Try
            con.Open()
            Dim query = "select * from Issue_books"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As SqlDataAdapter
            Adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(Adapter)
            Dim Ds = New DataSet()
            Adapter.Fill(Ds)
            issuebook_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub getbooks()
        If ConnectionState.Open Then
            con.Close()
            Try
                con.Open()
                Dim query = "select * from Books_records where Book_Name = '" & cmb_bookname.SelectedValue.ToString() & "'"
                Dim cmd = New SqlCommand(query, con)
                Dim Data As New DataTable
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader()
                While reader.Read
                    text_bookid.Text = "" + reader(0).ToString()
                End While
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub getstudent()
        Try
            con.Open()
            Dim query = "select * from Student_records where Student_ID = '" & cmb_rollno.SelectedValue.ToString() & "'"
            Dim cmd = New SqlCommand(query, con)
            Dim Data As New DataTable
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                text_name.Text = "" + reader(1).ToString()
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fill_student()
        Try
            con.Open()
            Dim query = "select * from Student_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            Adapter.Fill(table)
            cmb_rollno.DataSource = table
            cmb_rollno.DisplayMember = "Student_ID"
            cmb_rollno.ValueMember = "Student_ID"
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fill_Book()
        Try
            con.Open()
            Dim query = "select * from Books_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            Adapter.Fill(table)
            cmb_bookname.DataSource = table
            cmb_bookname.DisplayMember = "Book_Name"
            cmb_bookname.ValueMember = "Book_Name"
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reload()
        Dim i = New Issue_books()
        i.Show()
        Me.Hide()
    End Sub
    Private Sub insert_records()

        Dim result = check_books()
        If (result = 0) Then
            Try
                con.Open()
                Dim query = "insert into Issue_books values('" & id1 & "','" & text_name.Text & "','" & cmb_rollno.SelectedValue.ToString() & "','" & cmb_bookname.SelectedValue.ToString() & "','" & text_bookid.Text & "','" & dtc_issuedate.Value.Date & "')"
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book Issued successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                reload()
                Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub update_records()
        If ID = 0 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Open()
            Dim query = "update Issue_books set Student_Name = '" & text_name.Text & "', Book_Name = '" & cmb_bookname.Text & "', Book_ID = '" & text_bookid.Text & "', Issue_Date = '" & dtc_issuedate.Value.Date & "' where Issue_No = " & ID & ""
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Book Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            display_booksrecords()
            Reset()
        End If
    End Sub

    Private Sub delete_records()
        If ID = 0 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Open()
            Dim query = "delete from Issue_books where Issue_No = " & id1 & ""
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Book Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            display_booksrecords()
            Reset()
        End If
    End Sub
    Private Sub Issue_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_student()
        fill_Book()
        display_booksrecords()
        getID()
        dtc_issuedate.Value = Date.Today
    End Sub

    Private Sub issuebook_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles issuebook_DGV.CellMouseClick
        Dim row As DataGridViewRow = issuebook_DGV.Rows(e.RowIndex)
        id1 = row.Cells(0).Value.ToString
        text_name.Text = row.Cells(1).Value.ToString
        cmb_rollno.SelectedValue = row.Cells(2).Value.ToString
        cmb_bookname.SelectedValue = row.Cells(3).Value.ToString
        text_bookid.Text = row.Cells(4).Value.ToString
        dtc_issuedate.Value = row.Cells(5).Value.ToString

        If text_name.Text = "" Then
            ID = 0
        Else
            ID = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub cmb_bookname_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_bookname.SelectionChangeCommitted
        getbooks()
    End Sub

    Private Sub cmb_rollno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_rollno.SelectionChangeCommitted
        getstudent()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim res = validation()
        If (res = 0) Then
            insert_records()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete_records()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        update_records()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label7.Click
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Panel3.Click, Label10.Click
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim DU = New Issue_books
        DU.Show()
        Me.Hide()
    End Sub
End Class
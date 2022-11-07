Imports System.Data.SqlClient
Public Class Return_books

    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")
    Dim ID = 0
    Dim id1 As String
    Public Function validation()
        Dim i As Integer
        i = 0
        If cmb_studentname.SelectedIndex = -1 Or text_rollno.Text = "" Or cmb_bookname.SelectedIndex = -1 Or text_bookid.Text = "" Or text_fine.Text = "" Then
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return i + 1
        Else
            Return i
        End If
    End Function

    Dim fine As Integer
    Private Sub calculate_fine()
        Dim da As TimeSpan

        da = dtc_returndate.Value.Date - dtc_issuedate.Value.Date
        Dim days = da.Days
        If days <= 10 Then
            fine = 0
            text_fine.Text = 0
        Else
            fine = (days - 10) * 30
            text_fine.Text = Convert.ToString(fine)
        End If
    End Sub
    Private Sub getID()
        Try
            con.Open()
            Dim query = "Select max(Return_No) from Return_books"
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
        cmb_studentname.SelectedIndex = -1
        cmb_bookname.SelectedIndex = -1
        text_rollno.Text = ""
        text_bookid.Text = ""
        text_fine.Text = ""
    End Sub

    Private Sub Resetforbook()
        cmb_bookname.SelectedIndex = -1
        text_rollno.Text = ""
        text_bookid.Text = ""
        text_fine.Text = ""
    End Sub
    Private Sub display_booksrecords()
        Try
            con.Open()
            Dim query = "select * from Return_books"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As SqlDataAdapter
            Adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(Adapter)
            Dim Ds = New DataSet()
            Adapter.Fill(Ds)
            returnbook_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub getbooks()
        Try
            con.Open()
            Dim query = "select * from Issue_books where Student_Name = '" & cmb_studentname.SelectedValue.ToString() & "'"
            Dim cmd = New SqlCommand(query, con)
            Dim Data As New DataTable
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            While reader.Read
                text_rollno.Text = "" + reader(2).ToString()
                cmb_bookname.SelectedValue = reader(3).ToString()
                text_bookid.Text = "" + reader(4).ToString()
                dtc_issuedate.Value = reader(5).ToString
            End While

            If text_rollno.Text = "" Then
                Dim result As DialogResult = MessageBox.Show("Book is not issued", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

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
            cmb_studentname.DataSource = table
            cmb_studentname.DisplayMember = "Student_Name"
            cmb_studentname.ValueMember = "Student_Name"
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fill_Book()
        Try
            con.Open()
            Dim query = "select * from Issue_books"
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
    Private Sub fill_Bookafterdelete()
        Try
            con.Open()
            Dim query = "select * from Return_books"
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
    Private Sub insert_records()
        Try
            con.Open()
            Dim query = "insert into Return_books values('" & id1 & "','" & text_rollno.Text & "','" & cmb_studentname.SelectedValue.ToString() & "','" & text_bookid.Text & "','" & cmb_bookname.SelectedValue.ToString() & "','" & dtc_issuedate.Value.Date & "','" & dtc_returndate.Value.Date & "','" & text_fine.Text & "')"
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Book returned successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            delete_issuebook()
            fill_Bookafterdelete()
            display_booksrecords()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub delete_issuebook()
        Try
            con.Open()
            Dim query = "delete from issue_books where Student_ID = " & text_rollno.Text & ""
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub delete_records()
        If ID = 0 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con.Open()
                Dim query = "delete from Return_books where Return_No = " & id1 & ""
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Book Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                display_booksrecords()
                Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub Return_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_booksrecords()
        fill_Book()
        fill_student()
        getID()
        dtc_returndate.Value = Date.Today
    End Sub

    Private Sub returnbook_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles returnbook_DGV.CellMouseClick
        Dim row As DataGridViewRow = returnbook_DGV.Rows(e.RowIndex)
        fill_Bookafterdelete()
        id1 = row.Cells(0).Value.ToString
        text_rollno.Text = row.Cells(1).Value.ToString
        cmb_studentname.SelectedValue = row.Cells(2).Value.ToString
        text_bookid.Text = row.Cells(3).Value.ToString
        cmb_bookname.SelectedValue = row.Cells(4).Value.ToString
        dtc_issuedate.Text = row.Cells(5).Value.ToString
        dtc_returndate.Text = row.Cells(6).Value.ToString
        text_fine.Text = row.Cells(7).Value.ToString

        If text_rollno.Text = "" Then
            ID = 0
        Else
            ID = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub cmb_studentname_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_studentname.SelectionChangeCommitted
        Resetforbook()
        fill_Book()
        getbooks()
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim DU = New Return_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        calculate_fine()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label8.Click
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
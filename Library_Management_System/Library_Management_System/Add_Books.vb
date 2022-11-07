
Imports System.Data.SqlClient
Public Class Add_Books

    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")
    Dim ID = 100
    Function validation()
        Dim a = 0
        If text_bookname.Text = "" Or text_author.Text = "" Or cmb_publisher.SelectedIndex = -1 Or text_price.Text = "" Or text_quantity.Text = "" Then
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return a + 1
        End If
        Return a
    End Function

    Private Sub getID()
        Dim defid As Integer
        defid = 1001
        Dim id As String
        Try
            con.Open()
            Dim query = "select max(Book_ID) from Books_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Data As New DataTable
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                id = "" + reader(0).ToString()
                If id = "" Then
                    text_bookid.Text = defid.ToString()
                Else
                    Dim val As Integer = Integer.Parse(id)
                    val = val + 1
                    text_bookid.Text = val.ToString()
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
            AddBooks_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reset()
        text_bookname.Text = ""
        text_price.Text = ""
        text_author.Text = ""
        cmb_publisher.SelectedIndex = -1
        text_quantity.Text = ""
        ID = 100
    End Sub

    Private Sub reload()
        Dim a = New Add_Books
        a.Show()
        Me.Hide()
    End Sub
    Private Sub insert_records()
        Try
            con.Open()
            Dim query = "insert into Books_records values('" & text_bookid.Text & "','" & text_bookname.Text & "','" & text_author.Text & "','" & cmb_publisher.SelectedItem.ToString() & "','" & text_price.Text & "','" & text_quantity.Text & "')"
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Book Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            If result.Equals(DialogResult.OK) Then
                reload()
            End If
            display_booksrecords()
            reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub update_records()
        If ID = 100 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con.Open()
                Dim query = "update Books_records set Book_Name ='" & text_bookname.Text & "', Book_Author = '" & text_author.Text & "', Book_Publisher = '" & cmb_publisher.Text & "', Book_Price = '" & text_price.Text & "', Book_Quantity = '" & text_quantity.Text & "' where Book_ID = " & text_bookid.Text & ""
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Book updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = 1 Then
                    reload()
                End If
                con.Close()
                reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub delete_records()
        If ID = 100 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con.Open()
                Dim query = "delete from Books_records where Book_ID = " & text_bookid.Text & ""
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Book Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If result = 1 Then
                    reload()
                End If
                reset()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Add_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_booksrecords()
        getID()
    End Sub

    Private Sub AddBooks_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AddBooks_DGV.CellMouseClick
        Dim row As DataGridViewRow = AddBooks_DGV.Rows(e.RowIndex)
        text_bookid.Text = row.Cells(0).Value.ToString
        text_bookname.Text = row.Cells(1).Value.ToString
        text_author.Text = row.Cells(2).Value.ToString
        cmb_publisher.SelectedItem = row.Cells(3).Value.ToString
        text_price.Text = row.Cells(4).Value.ToString
        text_quantity.Text = row.Cells(5).Value.ToString

        If text_bookname.Text = "" Then
            ID = 100
        Else
            ID = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim a = validation()
        If a = 0 Then
            insert_records()
        End If
    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete_records()
    End Sub

    Private Sub btn_update_Click_1(sender As Object, e As EventArgs) Handles btn_update.Click
        update_records()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label7.Click
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click, Panel7.Click, Label4.Click
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
        Dim DU = New Add_Books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub text_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_price.KeyPress
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Allowed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
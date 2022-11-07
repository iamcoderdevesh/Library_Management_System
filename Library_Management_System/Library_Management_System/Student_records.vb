Imports System.Data
Imports System.Data.SqlClient
Public Class Student_records
    Dim ID = 0
    Dim con As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=Library_Management_System;Integrated Security=True")

    Private Function validation()
        Dim a As Integer
        a = 0
        If text_name.Text = "" Or cmb_course.SelectedIndex = -1 Or text_phone.Text = "" Or cmb_semester.SelectedIndex = -1 Or text_id.Text = "" Then
            MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return a + 1
        ElseIf text_phone.TextLength <= 9 Then
            MessageBox.Show("Contact Number should be of 10 Digits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_phone.Text = ""
            Return a + 1
        Else
            Return a
        End If
    End Function
    Private Sub reload()
        Dim DU = New Student_records
        DU.Show()
        Me.Hide()
    End Sub
    Private Sub getID()
        Dim defid As Integer
        defid = 100
        Dim id As String
        Try
            con.Open()
            Dim query = "select max(Student_ID) from Student_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Data As New DataTable
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader()
            If reader.Read Then
                id = "" + reader(0).ToString()
                If id = "" Then
                    text_id.Text = defid.ToString()
                Else
                    Dim val As Integer = Integer.Parse(id)
                    val = val + 1
                    text_id.Text = val.ToString()
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub display_studentrecords()
        Try
            con.Open()
            Dim query = "select * from Student_records"
            Dim cmd = New SqlCommand(query, con)
            Dim Adapter As SqlDataAdapter
            Adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(Adapter)
            Dim Ds = New DataSet()
            Adapter.Fill(Ds)
            Students_DGV.DataSource = Ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reset()
        text_name.Text = ""
        cmb_course.SelectedIndex = -1
        text_phone.Text = ""
        cmb_semester.SelectedIndex = -1
        ID = 0
    End Sub
    Private Sub insert_records()
        Try
            con.Open() '" & text_name.Text & "',
            Dim query = "insert into Student_records values('" & text_id.Text & "','" & text_name.Text & "','" & cmb_course.SelectedItem.ToString() & "','" & cmb_semester.SelectedItem.ToString() & "','" & text_phone.Text & "')"
            Dim cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Student Added successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reload()
            con.Close()
            display_studentrecords()
            reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub update_records()
        If ID = 0 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con.Open()
                Dim query = "update Student_records set Student_Name ='" & text_name.Text & "', Course = '" & cmb_course.SelectedItem.ToString() & "', Year = '" & cmb_semester.SelectedItem.ToString() & "', Phone = '" & text_phone.Text & "' where Student_ID = " & text_id.Text & ""
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Student Updated successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                display_studentrecords()
                reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub delete_records()
        If ID = 0 Then
            MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con.Open()
                Dim query = "delete from Student_records where Student_ID = '" & text_id.Text & "'"
                Dim cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim result As DialogResult = MessageBox.Show("Student Deleted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                display_studentrecords()
                reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim DU = validation()
        If DU = 0 Then
            insert_records()
        End If
    End Sub

    Private Sub Student_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_studentrecords()
        getID()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        delete_records()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        update_records()
    End Sub

    Private Sub Students_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Students_DGV.CellMouseClick
        Dim row As DataGridViewRow = Students_DGV.Rows(e.RowIndex)
        text_id.Text = row.Cells(0).Value.ToString
        text_name.Text = row.Cells(1).Value.ToString
        cmb_course.SelectedItem = row.Cells(2).Value.ToString
        cmb_semester.SelectedItem = row.Cells(3).Value.ToString
        text_phone.Text = row.Cells(4).Value.ToString

        If text_name.Text = "" Then
            ID = 0
        Else
            ID = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs)
        Dim DU = New Home_page
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, Panel4.Click, Label8.Click
        Dim DU = New Student_records
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click, Panel5.Click, Label2.Click
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

    Private Sub text_phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_phone.KeyPress
        If Asc(e.KeyChar) = 8 Then
            e.Handled = False
        ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Only Numeric Values Allowed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim DU = New Student_records
        DU.Show()
        Me.Hide()
    End Sub
End Class
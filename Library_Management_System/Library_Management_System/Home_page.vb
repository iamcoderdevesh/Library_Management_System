Public Class Home_page

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick, Panel4.MouseClick, Label1.MouseClick
        Dim DU = New Student_records
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick, Panel5.MouseClick, Label2.MouseClick
        Dim DU = New Add_Books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick, Panel6.MouseClick, Label3.MouseClick
        Dim DU = New Issue_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseClick, Panel7.MouseClick, Label4.MouseClick
        Dim DU = New Return_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseClick, Panel8.MouseClick, Label5.MouseClick
        Dim DU = New Search_books
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Panel9_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseClick, Panel9.MouseClick, Label6.MouseClick
        Dim DU = New Report
        DU.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
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
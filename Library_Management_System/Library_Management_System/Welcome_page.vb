Public Class Welcome_page
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Progressbar.Increment(1.4)

        If Progressbar.Value = 15 Then
            lbl_text.Text = "Turning on Modules...."

        ElseIf Progressbar.Value = 30 Then
            lbl_text.Text = "Starting Modules...."

        ElseIf Progressbar.Value = 50 Then
            lbl_text.Text = "Connecting Databases...."

        ElseIf Progressbar.Value = 70 Then
            lbl_text.Text = "Intializing Databases...."

        ElseIf Progressbar.Value = 85 Then
            lbl_text.Text = "Done Loading Modules...."

        ElseIf Progressbar.Value = 100 Then
            Dim l = New Login
            l.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub Welcome_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class
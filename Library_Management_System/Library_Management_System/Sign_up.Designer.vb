<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_up
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_up))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_sign_up = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_login = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_firstname = New System.Windows.Forms.TextBox()
        Me.text_lastname = New System.Windows.Forms.TextBox()
        Me.text_username = New System.Windows.Forms.TextBox()
        Me.text_password = New System.Windows.Forms.TextBox()
        Me.text_conpassword = New System.Windows.Forms.TextBox()
        Me.text_contactno = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(502, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 31)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(702, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 38)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Sign_up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(502, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 31)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(502, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 31)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(502, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 31)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(502, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 62)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Confirm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(502, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 31)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Contact No."
        '
        'btn_sign_up
        '
        Me.btn_sign_up.BorderRadius = 20
        Me.btn_sign_up.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sign_up.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sign_up.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sign_up.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sign_up.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sign_up.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sign_up.FillColor = System.Drawing.Color.DarkViolet
        Me.btn_sign_up.FillColor2 = System.Drawing.Color.DeepPink
        Me.btn_sign_up.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_sign_up.ForeColor = System.Drawing.Color.White
        Me.btn_sign_up.Location = New System.Drawing.Point(801, 580)
        Me.btn_sign_up.Name = "btn_sign_up"
        Me.btn_sign_up.Size = New System.Drawing.Size(172, 45)
        Me.btn_sign_up.TabIndex = 6
        Me.btn_sign_up.Text = "Sign_up"
        '
        'btn_login
        '
        Me.btn_login.BorderRadius = 20
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.DarkViolet
        Me.btn_login.FillColor2 = System.Drawing.Color.DeepPink
        Me.btn_login.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(502, 580)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(165, 45)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Login"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(502, 548)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 18)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Already have an account"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.cross
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(989, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.CausesValidation = False
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2CircleButton1.FocusedColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(-258, -18)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(690, 702)
        Me.Guna2CircleButton1.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Font = New System.Drawing.Font("Georgia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 56)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "System"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Font = New System.Drawing.Font("Georgia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(357, 56)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Management"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Font = New System.Drawing.Font("Georgia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 56)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Library"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Font = New System.Drawing.Font("Georgia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(330, 56)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Welcome To"
        '
        'text_firstname
        '
        Me.text_firstname.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_firstname.Location = New System.Drawing.Point(702, 136)
        Me.text_firstname.Name = "text_firstname"
        Me.text_firstname.Size = New System.Drawing.Size(271, 35)
        Me.text_firstname.TabIndex = 0
        '
        'text_lastname
        '
        Me.text_lastname.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_lastname.Location = New System.Drawing.Point(702, 203)
        Me.text_lastname.Name = "text_lastname"
        Me.text_lastname.Size = New System.Drawing.Size(271, 35)
        Me.text_lastname.TabIndex = 1
        '
        'text_username
        '
        Me.text_username.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_username.Location = New System.Drawing.Point(702, 267)
        Me.text_username.Name = "text_username"
        Me.text_username.Size = New System.Drawing.Size(271, 35)
        Me.text_username.TabIndex = 2
        '
        'text_password
        '
        Me.text_password.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_password.Location = New System.Drawing.Point(702, 329)
        Me.text_password.Name = "text_password"
        Me.text_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_password.Size = New System.Drawing.Size(271, 35)
        Me.text_password.TabIndex = 3
        '
        'text_conpassword
        '
        Me.text_conpassword.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_conpassword.Location = New System.Drawing.Point(702, 418)
        Me.text_conpassword.Name = "text_conpassword"
        Me.text_conpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.text_conpassword.Size = New System.Drawing.Size(271, 35)
        Me.text_conpassword.TabIndex = 4
        '
        'text_contactno
        '
        Me.text_contactno.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_contactno.Location = New System.Drawing.Point(702, 472)
        Me.text_contactno.MaxLength = 10
        Me.text_contactno.Name = "text_contactno"
        Me.text_contactno.Size = New System.Drawing.Size(271, 35)
        Me.text_contactno.TabIndex = 5
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Georgia", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.ForeColor = System.Drawing.Color.Red
        Me.lbl_password.Location = New System.Drawing.Point(702, 367)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(0, 18)
        Me.lbl_password.TabIndex = 49
        '
        'Sign_up
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 653)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.text_contactno)
        Me.Controls.Add(Me.text_conpassword)
        Me.Controls.Add(Me.text_password)
        Me.Controls.Add(Me.text_username)
        Me.Controls.Add(Me.text_lastname)
        Me.Controls.Add(Me.text_firstname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_sign_up)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sign_up"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign_up"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_sign_up As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_firstname As TextBox
    Friend WithEvents text_lastname As TextBox
    Friend WithEvents text_username As TextBox
    Friend WithEvents text_password As TextBox
    Friend WithEvents text_conpassword As TextBox
    Friend WithEvents text_contactno As TextBox
    Friend WithEvents lbl_password As Label
End Class

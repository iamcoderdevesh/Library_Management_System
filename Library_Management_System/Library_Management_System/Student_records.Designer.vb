<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_records
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_records))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Students_DGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.text_phone = New System.Windows.Forms.TextBox()
        Me.text_name = New System.Windows.Forms.TextBox()
        Me.cmb_course = New System.Windows.Forms.ComboBox()
        Me.cmb_semester = New System.Windows.Forms.ComboBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_save = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.text_id = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.lblrollno = New System.Windows.Forms.Label()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel1.SuspendLayout()
        CType(Me.Students_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Students_DGV)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Guna2GradientButton3)
        Me.Panel1.Location = New System.Drawing.Point(372, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1206, 788)
        Me.Panel1.TabIndex = 2
        '
        'Students_DGV
        '
        Me.Students_DGV.AllowUserToAddRows = False
        Me.Students_DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Students_DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Students_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Students_DGV.BackgroundColor = System.Drawing.Color.White
        Me.Students_DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Students_DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Students_DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Students_DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Students_DGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Students_DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.Students_DGV.EnableHeadersVisualStyles = False
        Me.Students_DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Students_DGV.Location = New System.Drawing.Point(63, 276)
        Me.Students_DGV.Name = "Students_DGV"
        Me.Students_DGV.ReadOnly = True
        Me.Students_DGV.RowHeadersVisible = False
        Me.Students_DGV.RowTemplate.Height = 27
        Me.Students_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Students_DGV.Size = New System.Drawing.Size(1115, 493)
        Me.Students_DGV.TabIndex = 8
        Me.Students_DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Students_DGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Students_DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Students_DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Students_DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Students_DGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Students_DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Students_DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Students_DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Students_DGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Students_DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Students_DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Students_DGV.ThemeStyle.HeaderStyle.Height = 30
        Me.Students_DGV.ThemeStyle.ReadOnly = True
        Me.Students_DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Students_DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Students_DGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Students_DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Students_DGV.ThemeStyle.RowsStyle.Height = 27
        Me.Students_DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Students_DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Guna2GradientButton1)
        Me.Panel12.Controls.Add(Me.text_phone)
        Me.Panel12.Controls.Add(Me.text_name)
        Me.Panel12.Controls.Add(Me.cmb_course)
        Me.Panel12.Controls.Add(Me.cmb_semester)
        Me.Panel12.Controls.Add(Me.lblyear)
        Me.Panel12.Controls.Add(Me.Label9)
        Me.Panel12.Controls.Add(Me.btn_update)
        Me.Panel12.Controls.Add(Me.btn_delete)
        Me.Panel12.Controls.Add(Me.btn_save)
        Me.Panel12.Controls.Add(Me.text_id)
        Me.Panel12.Controls.Add(Me.lblname)
        Me.Panel12.Controls.Add(Me.lblcourse)
        Me.Panel12.Controls.Add(Me.lblrollno)
        Me.Panel12.Location = New System.Drawing.Point(63, 34)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1115, 201)
        Me.Panel12.TabIndex = 46
        '
        'text_phone
        '
        Me.text_phone.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_phone.Location = New System.Drawing.Point(900, 62)
        Me.text_phone.MaxLength = 10
        Me.text_phone.Name = "text_phone"
        Me.text_phone.Size = New System.Drawing.Size(196, 35)
        Me.text_phone.TabIndex = 3
        '
        'text_name
        '
        Me.text_name.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_name.Location = New System.Drawing.Point(246, 60)
        Me.text_name.Name = "text_name"
        Me.text_name.Size = New System.Drawing.Size(196, 35)
        Me.text_name.TabIndex = 0
        '
        'cmb_course
        '
        Me.cmb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_course.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmb_course.FormattingEnabled = True
        Me.cmb_course.ItemHeight = 30
        Me.cmb_course.Items.AddRange(New Object() {"BCA", "BSCIT", "MCA", "MSCIT", "BCOM", "BBA", "BAF", "MCOM", "MBA"})
        Me.cmb_course.Location = New System.Drawing.Point(475, 59)
        Me.cmb_course.Name = "cmb_course"
        Me.cmb_course.Size = New System.Drawing.Size(171, 38)
        Me.cmb_course.TabIndex = 1
        '
        'cmb_semester
        '
        Me.cmb_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_semester.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmb_semester.FormattingEnabled = True
        Me.cmb_semester.ItemHeight = 30
        Me.cmb_semester.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year"})
        Me.cmb_semester.Location = New System.Drawing.Point(695, 59)
        Me.cmb_semester.Name = "cmb_semester"
        Me.cmb_semester.Size = New System.Drawing.Size(171, 38)
        Me.cmb_semester.TabIndex = 2
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblyear.ForeColor = System.Drawing.Color.Black
        Me.lblyear.Location = New System.Drawing.Point(695, 22)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(73, 29)
        Me.lblyear.TabIndex = 52
        Me.lblyear.Text = "Year"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(900, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 29)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Phone"
        '
        'btn_update
        '
        Me.btn_update.BorderRadius = 20
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_update.FillColor = System.Drawing.Color.DarkViolet
        Me.btn_update.FillColor2 = System.Drawing.Color.DeepPink
        Me.btn_update.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(612, 129)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(146, 45)
        Me.btn_update.TabIndex = 6
        Me.btn_update.Text = "Update"
        '
        'btn_delete
        '
        Me.btn_delete.BorderRadius = 20
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.FillColor = System.Drawing.Color.DarkViolet
        Me.btn_delete.FillColor2 = System.Drawing.Color.DeepPink
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(428, 129)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(146, 45)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Delete"
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 20
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_save.FillColor = System.Drawing.Color.DarkViolet
        Me.btn_save.FillColor2 = System.Drawing.Color.DeepPink
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(256, 129)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(129, 45)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        '
        'text_id
        '
        Me.text_id.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.text_id.Location = New System.Drawing.Point(29, 59)
        Me.text_id.Multiline = True
        Me.text_id.Name = "text_id"
        Me.text_id.ReadOnly = True
        Me.text_id.Size = New System.Drawing.Size(155, 32)
        Me.text_id.TabIndex = 20
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Georgia", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Location = New System.Drawing.Point(246, 22)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(183, 27)
        Me.lblname.TabIndex = 48
        Me.lblname.Text = "Student Name"
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblcourse.ForeColor = System.Drawing.Color.Black
        Me.lblcourse.Location = New System.Drawing.Point(475, 21)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(99, 29)
        Me.lblcourse.TabIndex = 51
        Me.lblcourse.Text = "Course"
        '
        'lblrollno
        '
        Me.lblrollno.AutoSize = True
        Me.lblrollno.Font = New System.Drawing.Font("Georgia", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblrollno.ForeColor = System.Drawing.Color.Black
        Me.lblrollno.Location = New System.Drawing.Point(29, 21)
        Me.lblrollno.Name = "lblrollno"
        Me.lblrollno.Size = New System.Drawing.Size(142, 27)
        Me.lblrollno.TabIndex = 50
        Me.lblrollno.Text = "Student ID"
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.BorderRadius = 20
        Me.Guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Guna2GradientButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(454, 830)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(129, 45)
        Me.Guna2GradientButton3.TabIndex = 45
        Me.Guna2GradientButton3.Text = "Back"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(63, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Records"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 100)
        Me.Panel2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(148, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 40)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "LMS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Library_Management_System.My.Resources.Resources._4885202_removebg_preview__1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(178, 160)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(-6, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 897)
        Me.Panel3.TabIndex = 48
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.PictureBox8)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel9.Location = New System.Drawing.Point(3, 672)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(372, 83)
        Me.Panel9.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(94, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 40)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Logout"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Library_Management_System.My.Resources.Resources._exit
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(25, 22)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(63, 47)
        Me.PictureBox8.TabIndex = 56
        Me.PictureBox8.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.PictureBox1)
        Me.Panel10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel10.Location = New System.Drawing.Point(3, 148)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(372, 82)
        Me.Panel10.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(94, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 40)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Dashboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.dashboard
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.PictureBox7)
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel8.Location = New System.Drawing.Point(3, 586)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(369, 80)
        Me.Panel8.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(94, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Search Books"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.search_document
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.PictureBox6)
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel7.Location = New System.Drawing.Point(3, 496)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(372, 84)
        Me.Panel7.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(94, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Return Books"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.Library_Management_System.My.Resources.Resources._3533407_book_education_entrepreneur_knowledge_learning_icon
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PictureBox5)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel6.Location = New System.Drawing.Point(3, 411)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(372, 79)
        Me.Panel6.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Issue Books"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Library_Management_System.My.Resources.Resources._4243328_ux_book_app_basic_icon
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Location = New System.Drawing.Point(3, 321)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 84)
        Me.Panel5.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Add Books"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Library_Management_System.My.Resources.Resources._103409_text_add_book_icon
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepPink
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(3, 236)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(372, 79)
        Me.Panel4.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(94, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 40)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Student Records"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.admin1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(25, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(63, 54)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.PictureBox9)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel11.Location = New System.Drawing.Point(372, -1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1206, 108)
        Me.Panel11.TabIndex = 48
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Library_Management_System.My.Resources.Resources.cross
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Location = New System.Drawing.Point(1159, 13)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox9.TabIndex = 49
        Me.PictureBox9.TabStop = False
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderRadius = 20
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.DarkViolet
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.DeepPink
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Georgia", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(795, 129)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(140, 45)
        Me.Guna2GradientButton1.TabIndex = 49
        Me.Guna2GradientButton1.Text = "Reset"
        '
        'Student_records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1582, 886)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Student_records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student_records"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Students_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents text_id As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents cmb_semester As ComboBox
    Friend WithEvents lblyear As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents lblrollno As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btn_update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Students_DGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmb_course As ComboBox
    Friend WithEvents text_phone As TextBox
    Friend WithEvents text_name As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
End Class

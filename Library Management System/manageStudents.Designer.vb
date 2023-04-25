<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageStudents
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageStudents))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastnameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.firstnameLbl = New System.Windows.Forms.Label()
        Me.midnameLbl = New System.Windows.Forms.Label()
        Me.lastnameLbl = New System.Windows.Forms.Label()
        Me.firstnameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.midnameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yearSecLbl = New System.Windows.Forms.Label()
        Me.studentIDLbl = New System.Windows.Forms.Label()
        Me.courseLbl = New System.Windows.Forms.Label()
        Me.manageStudentsDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentIDTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.yearSecTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.courseTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.manageStudentsDeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsUpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageStudentsCloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.passwordTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.usernameTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.searchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.showAll = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.manageStudentsDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Schibsted Grotesk", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(9, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(292, 40)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "MANAGE STUDENTS"
        '
        'lastnameTxtbox
        '
        Me.lastnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastnameTxtbox.DefaultText = ""
        Me.lastnameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastnameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastnameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastnameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnameTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnameTxtbox.ForeColor = System.Drawing.Color.Black
        Me.lastnameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lastnameTxtbox.Location = New System.Drawing.Point(122, 85)
        Me.lastnameTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.lastnameTxtbox.Name = "lastnameTxtbox"
        Me.lastnameTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lastnameTxtbox.PlaceholderText = ""
        Me.lastnameTxtbox.SelectedText = ""
        Me.lastnameTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.lastnameTxtbox.TabIndex = 22
        '
        'firstnameLbl
        '
        Me.firstnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.firstnameLbl.AutoSize = True
        Me.firstnameLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnameLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.firstnameLbl.Location = New System.Drawing.Point(17, 125)
        Me.firstnameLbl.Name = "firstnameLbl"
        Me.firstnameLbl.Size = New System.Drawing.Size(95, 26)
        Me.firstnameLbl.TabIndex = 25
        Me.firstnameLbl.Text = "FIRSTNAME"
        '
        'midnameLbl
        '
        Me.midnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.midnameLbl.AutoSize = True
        Me.midnameLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midnameLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.midnameLbl.Location = New System.Drawing.Point(15, 162)
        Me.midnameLbl.Name = "midnameLbl"
        Me.midnameLbl.Size = New System.Drawing.Size(109, 26)
        Me.midnameLbl.TabIndex = 24
        Me.midnameLbl.Text = "MIDDLENAME"
        '
        'lastnameLbl
        '
        Me.lastnameLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lastnameLbl.AutoSize = True
        Me.lastnameLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastnameLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.lastnameLbl.Location = New System.Drawing.Point(17, 88)
        Me.lastnameLbl.Name = "lastnameLbl"
        Me.lastnameLbl.Size = New System.Drawing.Size(91, 26)
        Me.lastnameLbl.TabIndex = 23
        Me.lastnameLbl.Text = "LASTNAME"
        '
        'firstnameTxtbox
        '
        Me.firstnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstnameTxtbox.DefaultText = ""
        Me.firstnameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstnameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstnameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstnameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstnameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstnameTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstnameTxtbox.ForeColor = System.Drawing.Color.Black
        Me.firstnameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstnameTxtbox.Location = New System.Drawing.Point(122, 122)
        Me.firstnameTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.firstnameTxtbox.Name = "firstnameTxtbox"
        Me.firstnameTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstnameTxtbox.PlaceholderText = ""
        Me.firstnameTxtbox.SelectedText = ""
        Me.firstnameTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.firstnameTxtbox.TabIndex = 26
        '
        'midnameTxtbox
        '
        Me.midnameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.midnameTxtbox.DefaultText = ""
        Me.midnameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.midnameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.midnameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.midnameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.midnameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.midnameTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midnameTxtbox.ForeColor = System.Drawing.Color.Black
        Me.midnameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.midnameTxtbox.Location = New System.Drawing.Point(122, 159)
        Me.midnameTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.midnameTxtbox.Name = "midnameTxtbox"
        Me.midnameTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.midnameTxtbox.PlaceholderText = ""
        Me.midnameTxtbox.SelectedText = ""
        Me.midnameTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.midnameTxtbox.TabIndex = 27
        '
        'yearSecLbl
        '
        Me.yearSecLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.yearSecLbl.AutoSize = True
        Me.yearSecLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearSecLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.yearSecLbl.Location = New System.Drawing.Point(305, 125)
        Me.yearSecLbl.Name = "yearSecLbl"
        Me.yearSecLbl.Size = New System.Drawing.Size(157, 26)
        Me.yearSecLbl.TabIndex = 31
        Me.yearSecLbl.Text = "YEAR AND SECTION"
        '
        'studentIDLbl
        '
        Me.studentIDLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.studentIDLbl.AutoSize = True
        Me.studentIDLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.studentIDLbl.Location = New System.Drawing.Point(303, 162)
        Me.studentIDLbl.Name = "studentIDLbl"
        Me.studentIDLbl.Size = New System.Drawing.Size(98, 26)
        Me.studentIDLbl.TabIndex = 30
        Me.studentIDLbl.Text = "STUDENT ID"
        '
        'courseLbl
        '
        Me.courseLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.courseLbl.AutoSize = True
        Me.courseLbl.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.courseLbl.Location = New System.Drawing.Point(305, 88)
        Me.courseLbl.Name = "courseLbl"
        Me.courseLbl.Size = New System.Drawing.Size(73, 26)
        Me.courseLbl.TabIndex = 29
        Me.courseLbl.Text = "COURSE"
        '
        'manageStudentsDgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.manageStudentsDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageStudentsDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.manageStudentsDgv.ColumnHeadersHeight = 42
        Me.manageStudentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageStudentsDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lastname, Me.firstname, Me.middlename, Me.course, Me.yearSection, Me.studentID, Me.username, Me.password})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.manageStudentsDgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.manageStudentsDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDgv.Location = New System.Drawing.Point(23, 266)
        Me.manageStudentsDgv.Name = "manageStudentsDgv"
        Me.manageStudentsDgv.RowHeadersVisible = False
        Me.manageStudentsDgv.Size = New System.Drawing.Size(898, 306)
        Me.manageStudentsDgv.TabIndex = 40
        Me.manageStudentsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.manageStudentsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.manageStudentsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.manageStudentsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.manageStudentsDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageStudentsDgv.ThemeStyle.HeaderStyle.Height = 42
        Me.manageStudentsDgv.ThemeStyle.ReadOnly = False
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.Height = 22
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageStudentsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lastname
        '
        Me.lastname.HeaderText = "LASTNAME"
        Me.lastname.Name = "lastname"
        '
        'firstname
        '
        Me.firstname.HeaderText = "FIRSTNAME"
        Me.firstname.Name = "firstname"
        '
        'middlename
        '
        Me.middlename.HeaderText = "MIDDLENAME"
        Me.middlename.Name = "middlename"
        '
        'course
        '
        Me.course.HeaderText = "COURSE"
        Me.course.Name = "course"
        '
        'yearSection
        '
        Me.yearSection.HeaderText = "YEAR AND SECTION"
        Me.yearSection.Name = "yearSection"
        '
        'studentID
        '
        Me.studentID.HeaderText = "STUDENT ID"
        Me.studentID.Name = "studentID"
        '
        'username
        '
        Me.username.HeaderText = "USERNAME"
        Me.username.Name = "username"
        '
        'password
        '
        Me.password.HeaderText = "PASSWORD"
        Me.password.Name = "password"
        '
        'studentIDTxtbox
        '
        Me.studentIDTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentIDTxtbox.DefaultText = ""
        Me.studentIDTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentIDTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentIDTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentIDTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentIDTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentIDTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDTxtbox.ForeColor = System.Drawing.Color.Black
        Me.studentIDTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentIDTxtbox.Location = New System.Drawing.Point(459, 159)
        Me.studentIDTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.studentIDTxtbox.Name = "studentIDTxtbox"
        Me.studentIDTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentIDTxtbox.PlaceholderText = ""
        Me.studentIDTxtbox.SelectedText = ""
        Me.studentIDTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.studentIDTxtbox.TabIndex = 43
        '
        'yearSecTxtbox
        '
        Me.yearSecTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.yearSecTxtbox.DefaultText = ""
        Me.yearSecTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.yearSecTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.yearSecTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearSecTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.yearSecTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearSecTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearSecTxtbox.ForeColor = System.Drawing.Color.Black
        Me.yearSecTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearSecTxtbox.Location = New System.Drawing.Point(459, 122)
        Me.yearSecTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.yearSecTxtbox.Name = "yearSecTxtbox"
        Me.yearSecTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.yearSecTxtbox.PlaceholderText = ""
        Me.yearSecTxtbox.SelectedText = ""
        Me.yearSecTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.yearSecTxtbox.TabIndex = 42
        '
        'courseTxtbox
        '
        Me.courseTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.courseTxtbox.DefaultText = ""
        Me.courseTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.courseTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.courseTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.courseTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseTxtbox.ForeColor = System.Drawing.Color.Black
        Me.courseTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.courseTxtbox.Location = New System.Drawing.Point(459, 85)
        Me.courseTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.courseTxtbox.Name = "courseTxtbox"
        Me.courseTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.courseTxtbox.PlaceholderText = ""
        Me.courseTxtbox.SelectedText = ""
        Me.courseTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.courseTxtbox.TabIndex = 41
        '
        'manageStudentsDeleteButton
        '
        Me.manageStudentsDeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.manageStudentsDeleteButton.BorderRadius = 20
        Me.manageStudentsDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageStudentsDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsDeleteButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsDeleteButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsDeleteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageStudentsDeleteButton.Location = New System.Drawing.Point(36, 11)
        Me.manageStudentsDeleteButton.Name = "manageStudentsDeleteButton"
        Me.manageStudentsDeleteButton.Size = New System.Drawing.Size(150, 38)
        Me.manageStudentsDeleteButton.TabIndex = 37
        Me.manageStudentsDeleteButton.Text = "DELETE"
        '
        'manageStudentsUpdateButton
        '
        Me.manageStudentsUpdateButton.BorderRadius = 20
        Me.manageStudentsUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageStudentsUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsUpdateButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsUpdateButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsUpdateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageStudentsUpdateButton.Location = New System.Drawing.Point(255, 11)
        Me.manageStudentsUpdateButton.Name = "manageStudentsUpdateButton"
        Me.manageStudentsUpdateButton.Size = New System.Drawing.Size(150, 38)
        Me.manageStudentsUpdateButton.TabIndex = 36
        Me.manageStudentsUpdateButton.Text = "UPDATE"
        '
        'manageStudentsClearButton
        '
        Me.manageStudentsClearButton.BorderRadius = 20
        Me.manageStudentsClearButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageStudentsClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsClearButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsClearButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageStudentsClearButton.Location = New System.Drawing.Point(474, 11)
        Me.manageStudentsClearButton.Name = "manageStudentsClearButton"
        Me.manageStudentsClearButton.Size = New System.Drawing.Size(150, 38)
        Me.manageStudentsClearButton.TabIndex = 38
        Me.manageStudentsClearButton.Text = "CLEAR"
        '
        'manageStudentsCloseButton
        '
        Me.manageStudentsCloseButton.BorderRadius = 20
        Me.manageStudentsCloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageStudentsCloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsCloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudentsCloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudentsCloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudentsCloseButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageStudentsCloseButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudentsCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageStudentsCloseButton.Location = New System.Drawing.Point(685, 11)
        Me.manageStudentsCloseButton.Name = "manageStudentsCloseButton"
        Me.manageStudentsCloseButton.Size = New System.Drawing.Size(150, 38)
        Me.manageStudentsCloseButton.TabIndex = 39
        Me.manageStudentsCloseButton.Text = "CLOSE"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.manageStudentsCloseButton)
        Me.Guna2Panel2.Controls.Add(Me.manageStudentsClearButton)
        Me.Guna2Panel2.Controls.Add(Me.manageStudentsUpdateButton)
        Me.Guna2Panel2.Controls.Add(Me.manageStudentsDeleteButton)
        Me.Guna2Panel2.Location = New System.Drawing.Point(25, 200)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(896, 60)
        Me.Guna2Panel2.TabIndex = 46
        '
        'passwordTxtbox
        '
        Me.passwordTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTxtbox.DefaultText = ""
        Me.passwordTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTxtbox.ForeColor = System.Drawing.Color.Black
        Me.passwordTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordTxtbox.Location = New System.Drawing.Point(736, 122)
        Me.passwordTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.passwordTxtbox.Name = "passwordTxtbox"
        Me.passwordTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTxtbox.PlaceholderText = ""
        Me.passwordTxtbox.SelectedText = ""
        Me.passwordTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.passwordTxtbox.TabIndex = 50
        '
        'usernameTxtbox
        '
        Me.usernameTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTxtbox.DefaultText = ""
        Me.usernameTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTxtbox.ForeColor = System.Drawing.Color.Black
        Me.usernameTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTxtbox.Location = New System.Drawing.Point(736, 85)
        Me.usernameTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.usernameTxtbox.Name = "usernameTxtbox"
        Me.usernameTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTxtbox.PlaceholderText = ""
        Me.usernameTxtbox.SelectedText = ""
        Me.usernameTxtbox.Size = New System.Drawing.Size(167, 24)
        Me.usernameTxtbox.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(639, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 26)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(639, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 26)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "USERNAME"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 30
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(946, 50)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(307, 476)
        Me.Guna2GroupBox1.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 60)
        Me.Label8.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 50)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = """Connect to the world's knowledge with our library system."""
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(58, 190)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(201, 177)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 22
        Me.Guna2PictureBox2.TabStop = False
        '
        'searchTextBox
        '
        Me.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchTextBox.DefaultText = ""
        Me.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTextBox.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.Black
        Me.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(707, 25)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTextBox.PlaceholderText = ""
        Me.searchTextBox.SelectedText = ""
        Me.searchTextBox.Size = New System.Drawing.Size(200, 34)
        Me.searchTextBox.TabIndex = 53
        '
        'searchBtn
        '
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.searchBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.searchBtn.Font = New System.Drawing.Font("Rubik", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(620, 25)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 34)
        Me.searchBtn.TabIndex = 52
        Me.searchBtn.Text = "SEARCH"
        '
        'showAll
        '
        Me.showAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showAll.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.showAll.Font = New System.Drawing.Font("Rubik", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.showAll.Location = New System.Drawing.Point(523, 25)
        Me.showAll.Name = "showAll"
        Me.showAll.Size = New System.Drawing.Size(87, 34)
        Me.showAll.TabIndex = 54
        Me.showAll.Text = "SHOW ALL"
        '
        'manageStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1282, 581)
        Me.Controls.Add(Me.showAll)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.passwordTxtbox)
        Me.Controls.Add(Me.usernameTxtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.studentIDTxtbox)
        Me.Controls.Add(Me.yearSecTxtbox)
        Me.Controls.Add(Me.courseTxtbox)
        Me.Controls.Add(Me.manageStudentsDgv)
        Me.Controls.Add(Me.yearSecLbl)
        Me.Controls.Add(Me.studentIDLbl)
        Me.Controls.Add(Me.courseLbl)
        Me.Controls.Add(Me.midnameTxtbox)
        Me.Controls.Add(Me.firstnameTxtbox)
        Me.Controls.Add(Me.firstnameLbl)
        Me.Controls.Add(Me.midnameLbl)
        Me.Controls.Add(Me.lastnameLbl)
        Me.Controls.Add(Me.lastnameTxtbox)
        Me.Controls.Add(Me.Label5)
        Me.Name = "manageStudents"
        Me.Text = "Manage Students"
        CType(Me.manageStudentsDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents lastnameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents firstnameLbl As Label
    Friend WithEvents midnameLbl As Label
    Friend WithEvents lastnameLbl As Label
    Friend WithEvents firstnameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents midnameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yearSecLbl As Label
    Friend WithEvents studentIDLbl As Label
    Friend WithEvents courseLbl As Label
    Friend WithEvents manageStudentsDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents studentIDTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents yearSecTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents courseTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents course As DataGridViewTextBoxColumn
    Friend WithEvents yearSection As DataGridViewTextBoxColumn
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents manageStudentsDeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsUpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageStudentsCloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents passwordTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernameTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents searchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showAll As Guna.UI2.WinForms.Guna2Button
End Class

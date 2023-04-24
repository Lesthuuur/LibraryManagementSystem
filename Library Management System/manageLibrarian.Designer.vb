<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manageLibrarian
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageLibrarian))
        Me.manageLibrarianDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manageUsersCloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersClearButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersDeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageUsersUpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.librarianLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.librarianFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.librarianMname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.librarianPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.librarianUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.searchTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.manageLibrarianDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageLibrarianDgv
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.manageLibrarianDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.manageLibrarianDgv.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageLibrarianDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.manageLibrarianDgv.ColumnHeadersHeight = 30
        Me.manageLibrarianDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageLibrarianDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.lastname, Me.firstname, Me.middlename, Me.username, Me.password})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.manageLibrarianDgv.DefaultCellStyle = DataGridViewCellStyle7
        Me.manageLibrarianDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageLibrarianDgv.Location = New System.Drawing.Point(14, 318)
        Me.manageLibrarianDgv.Name = "manageLibrarianDgv"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageLibrarianDgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.manageLibrarianDgv.RowHeadersVisible = False
        Me.manageLibrarianDgv.Size = New System.Drawing.Size(625, 262)
        Me.manageLibrarianDgv.TabIndex = 15
        Me.manageLibrarianDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.manageLibrarianDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.manageLibrarianDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.manageLibrarianDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.manageLibrarianDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.manageLibrarianDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.manageLibrarianDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageLibrarianDgv.ThemeStyle.HeaderStyle.Height = 30
        Me.manageLibrarianDgv.ThemeStyle.ReadOnly = False
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.Height = 22
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageLibrarianDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
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
        'manageUsersCloseButton
        '
        Me.manageUsersCloseButton.BorderRadius = 20
        Me.manageUsersCloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersCloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersCloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersCloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersCloseButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersCloseButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersCloseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageUsersCloseButton.Location = New System.Drawing.Point(386, 6)
        Me.manageUsersCloseButton.Name = "manageUsersCloseButton"
        Me.manageUsersCloseButton.Size = New System.Drawing.Size(114, 38)
        Me.manageUsersCloseButton.TabIndex = 43
        Me.manageUsersCloseButton.Text = "CLOSE"
        '
        'manageUsersClearButton
        '
        Me.manageUsersClearButton.BorderRadius = 20
        Me.manageUsersClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersClearButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersClearButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersClearButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageUsersClearButton.Location = New System.Drawing.Point(259, 5)
        Me.manageUsersClearButton.Name = "manageUsersClearButton"
        Me.manageUsersClearButton.Size = New System.Drawing.Size(111, 38)
        Me.manageUsersClearButton.TabIndex = 42
        Me.manageUsersClearButton.Text = "CLEAR"
        '
        'manageUsersDeleteButton
        '
        Me.manageUsersDeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.manageUsersDeleteButton.BorderRadius = 20
        Me.manageUsersDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersDeleteButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersDeleteButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersDeleteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageUsersDeleteButton.Location = New System.Drawing.Point(135, 7)
        Me.manageUsersDeleteButton.Name = "manageUsersDeleteButton"
        Me.manageUsersDeleteButton.Size = New System.Drawing.Size(111, 38)
        Me.manageUsersDeleteButton.TabIndex = 41
        Me.manageUsersDeleteButton.Text = "DELETE"
        '
        'manageUsersUpdateButton
        '
        Me.manageUsersUpdateButton.BorderRadius = 20
        Me.manageUsersUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageUsersUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageUsersUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageUsersUpdateButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageUsersUpdateButton.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageUsersUpdateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageUsersUpdateButton.Location = New System.Drawing.Point(5, 7)
        Me.manageUsersUpdateButton.Name = "manageUsersUpdateButton"
        Me.manageUsersUpdateButton.Size = New System.Drawing.Size(114, 38)
        Me.manageUsersUpdateButton.TabIndex = 40
        Me.manageUsersUpdateButton.Text = "UPDATE"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.manageUsersDeleteButton)
        Me.Guna2Panel1.Controls.Add(Me.manageUsersUpdateButton)
        Me.Guna2Panel1.Controls.Add(Me.manageUsersCloseButton)
        Me.Guna2Panel1.Controls.Add(Me.manageUsersClearButton)
        Me.Guna2Panel1.Location = New System.Drawing.Point(13, 254)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(628, 51)
        Me.Guna2Panel1.TabIndex = 44
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button1.Font = New System.Drawing.Font("Rubik SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(506, 7)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(114, 38)
        Me.Guna2Button1.TabIndex = 44
        Me.Guna2Button1.Text = "SHOW ALL"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2GroupBox1.BorderRadius = 30
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox3)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(691, 75)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(313, 429)
        Me.Guna2GroupBox1.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(26, 25)
        Me.Label8.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 44)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = """Connect to the world's knowledge with our library system."""
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(33, 107)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(256, 256)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox3.TabIndex = 22
        Me.Guna2PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "MANAGE LIBRARIAN"
        '
        'librarianLname
        '
        Me.librarianLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.librarianLname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianLname.Location = New System.Drawing.Point(21, 98)
        Me.librarianLname.Multiline = True
        Me.librarianLname.Name = "librarianLname"
        Me.librarianLname.Size = New System.Drawing.Size(190, 28)
        Me.librarianLname.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "LASTNAME"
        '
        'librarianFname
        '
        Me.librarianFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.librarianFname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianFname.Location = New System.Drawing.Point(24, 157)
        Me.librarianFname.Multiline = True
        Me.librarianFname.Name = "librarianFname"
        Me.librarianFname.Size = New System.Drawing.Size(190, 28)
        Me.librarianFname.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "FIRSTNAME"
        '
        'librarianMname
        '
        Me.librarianMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.librarianMname.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianMname.Location = New System.Drawing.Point(23, 216)
        Me.librarianMname.Multiline = True
        Me.librarianMname.Name = "librarianMname"
        Me.librarianMname.Size = New System.Drawing.Size(190, 28)
        Me.librarianMname.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "MIDDLENAME"
        '
        'librarianPassword
        '
        Me.librarianPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.librarianPassword.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianPassword.Location = New System.Drawing.Point(267, 185)
        Me.librarianPassword.Multiline = True
        Me.librarianPassword.Name = "librarianPassword"
        Me.librarianPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.librarianPassword.Size = New System.Drawing.Size(190, 28)
        Me.librarianPassword.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(264, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "PASSWORD"
        '
        'librarianUsername
        '
        Me.librarianUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.librarianUsername.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianUsername.Location = New System.Drawing.Point(268, 126)
        Me.librarianUsername.Multiline = True
        Me.librarianUsername.Name = "librarianUsername"
        Me.librarianUsername.Size = New System.Drawing.Size(190, 28)
        Me.librarianUsername.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(265, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 21)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "USERNAME"
        '
        'searchTxtbox
        '
        Me.searchTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchTxtbox.DefaultText = ""
        Me.searchTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTxtbox.ForeColor = System.Drawing.Color.Black
        Me.searchTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTxtbox.Location = New System.Drawing.Point(429, 19)
        Me.searchTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxtbox.PlaceholderText = ""
        Me.searchTxtbox.SelectedText = ""
        Me.searchTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.searchTxtbox.TabIndex = 57
        '
        'searchBtn
        '
        Me.searchBtn.BorderRadius = 20
        Me.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.searchBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.searchBtn.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.searchBtn.Location = New System.Drawing.Point(324, 19)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(90, 36)
        Me.searchBtn.TabIndex = 56
        Me.searchBtn.Text = "SEARCH"
        '
        'manageLibrarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1028, 593)
        Me.Controls.Add(Me.searchTxtbox)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.librarianPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.librarianUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.librarianMname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.librarianFname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.librarianLname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.manageLibrarianDgv)
        Me.Name = "manageLibrarian"
        Me.Text = "Manage Users"
        CType(Me.manageLibrarianDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents manageLibrarianDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents manageUsersCloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersClearButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersDeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageUsersUpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents librarianLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents librarianFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents librarianMname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents librarianPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents librarianUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents searchTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
End Class

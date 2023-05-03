<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.accountsPicBox = New System.Windows.Forms.PictureBox()
        Me.headerTitle = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.bookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookTitleChange = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.authorTextChange = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.readBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.searchTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.searchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.addReview = New Guna.UI2.WinForms.Guna2Button()
        Me.viewReviewsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.programmingGradientBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.selfhelpGradientBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.historyGradientBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.fictionGradBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.romanceGradBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.allBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.homeClearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.accountsPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Controls.Add(Me.logoutBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.accountsPicBox)
        Me.Guna2GroupBox1.Controls.Add(Me.headerTitle)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1266, 115)
        Me.Guna2GroupBox1.TabIndex = 5
        Me.Guna2GroupBox1.Text = "Guna2GroupBox1"
        '
        'logoutBtn
        '
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logoutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.logoutBtn.Font = New System.Drawing.Font("Rubik", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.logoutBtn.Location = New System.Drawing.Point(1079, 41)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(75, 34)
        Me.logoutBtn.TabIndex = 16
        Me.logoutBtn.Text = "LOGOUT"
        '
        'accountsPicBox
        '
        Me.accountsPicBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accountsPicBox.Image = CType(resources.GetObject("accountsPicBox.Image"), System.Drawing.Image)
        Me.accountsPicBox.Location = New System.Drawing.Point(1174, 23)
        Me.accountsPicBox.Name = "accountsPicBox"
        Me.accountsPicBox.Size = New System.Drawing.Size(74, 71)
        Me.accountsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.accountsPicBox.TabIndex = 1
        Me.accountsPicBox.TabStop = False
        '
        'headerTitle
        '
        Me.headerTitle.AutoSize = True
        Me.headerTitle.Font = New System.Drawing.Font("EB Garamond Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.headerTitle.Location = New System.Drawing.Point(7, 24)
        Me.headerTitle.Name = "headerTitle"
        Me.headerTitle.Size = New System.Drawing.Size(811, 69)
        Me.headerTitle.TabIndex = 0
        Me.headerTitle.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.dgv)
        Me.Guna2Panel2.Location = New System.Drawing.Point(7, 177)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(655, 458)
        Me.Guna2Panel2.TabIndex = 6
        '
        'dgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Schibsted Grotesk SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeight = 30
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bookTitle, Me.bookAuthor, Me.bookDescription, Me.bookPath})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(6, 9)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(645, 434)
        Me.dgv.TabIndex = 4
        Me.dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv.ThemeStyle.ReadOnly = False
        Me.dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.Height = 22
        Me.dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'bookTitle
        '
        Me.bookTitle.HeaderText = "TITLE"
        Me.bookTitle.Name = "bookTitle"
        '
        'bookAuthor
        '
        Me.bookAuthor.HeaderText = "AUTHOR"
        Me.bookAuthor.Name = "bookAuthor"
        '
        'bookDescription
        '
        Me.bookDescription.HeaderText = "DESCRIPTION"
        Me.bookDescription.Name = "bookDescription"
        Me.bookDescription.Visible = False
        '
        'bookPath
        '
        Me.bookPath.HeaderText = "PATH"
        Me.bookPath.Name = "bookPath"
        Me.bookPath.Visible = False
        '
        'bookTitleChange
        '
        Me.bookTitleChange.AutoSize = True
        Me.bookTitleChange.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitleChange.Location = New System.Drawing.Point(248, 13)
        Me.bookTitleChange.Name = "bookTitleChange"
        Me.bookTitleChange.Size = New System.Drawing.Size(84, 33)
        Me.bookTitleChange.TabIndex = 0
        Me.bookTitleChange.Text = "TITLE"
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Font = New System.Drawing.Font("Schibsted Grotesk SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.Location = New System.Drawing.Point(669, 241)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(79, 22)
        Me.author.TabIndex = 3
        Me.author.Text = "AUTHOR:"
        '
        'authorTextChange
        '
        Me.authorTextChange.AutoSize = True
        Me.authorTextChange.Font = New System.Drawing.Font("Schibsted Grotesk", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorTextChange.Location = New System.Drawing.Point(18, 3)
        Me.authorTextChange.Name = "authorTextChange"
        Me.authorTextChange.Size = New System.Drawing.Size(101, 28)
        Me.authorTextChange.TabIndex = 5
        Me.authorTextChange.Text = "AUTHOR:"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.authorTextChange)
        Me.Guna2Panel3.Location = New System.Drawing.Point(667, 264)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(595, 35)
        Me.Guna2Panel3.TabIndex = 7
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(669, 345)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(595, 226)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'readBtn
        '
        Me.readBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.readBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.readBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.readBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.readBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.readBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.readBtn.Font = New System.Drawing.Font("Rubik", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readBtn.ForeColor = System.Drawing.Color.White
        Me.readBtn.Location = New System.Drawing.Point(672, 588)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(138, 39)
        Me.readBtn.TabIndex = 10
        Me.readBtn.Text = "READ"
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
        Me.searchTxtbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTxtbox.Location = New System.Drawing.Point(1322, 225)
        Me.searchTxtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxtbox.PlaceholderText = ""
        Me.searchTxtbox.SelectedText = ""
        Me.searchTxtbox.Size = New System.Drawing.Size(282, 62)
        Me.searchTxtbox.TabIndex = 11
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
        Me.searchBtn.Location = New System.Drawing.Point(946, 131)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(75, 34)
        Me.searchBtn.TabIndex = 12
        Me.searchBtn.Text = "SEARCH"
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
        Me.searchTextBox.Location = New System.Drawing.Point(1033, 131)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTextBox.PlaceholderText = ""
        Me.searchTextBox.SelectedText = ""
        Me.searchTextBox.Size = New System.Drawing.Size(200, 34)
        Me.searchTextBox.TabIndex = 13
        '
        'addReview
        '
        Me.addReview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addReview.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.addReview.Font = New System.Drawing.Font("Rubik", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addReview.ForeColor = System.Drawing.Color.White
        Me.addReview.Location = New System.Drawing.Point(817, 588)
        Me.addReview.Name = "addReview"
        Me.addReview.Size = New System.Drawing.Size(138, 39)
        Me.addReview.TabIndex = 14
        Me.addReview.Text = "ADD REVIEW"
        '
        'viewReviewsBtn
        '
        Me.viewReviewsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewReviewsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.viewReviewsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.viewReviewsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.viewReviewsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.viewReviewsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.viewReviewsBtn.Font = New System.Drawing.Font("Rubik", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewReviewsBtn.ForeColor = System.Drawing.Color.White
        Me.viewReviewsBtn.Location = New System.Drawing.Point(968, 589)
        Me.viewReviewsBtn.Name = "viewReviewsBtn"
        Me.viewReviewsBtn.Size = New System.Drawing.Size(138, 39)
        Me.viewReviewsBtn.TabIndex = 15
        Me.viewReviewsBtn.Text = "VIEW REVIEWS"
        '
        'programmingGradientBtn
        '
        Me.programmingGradientBtn.BackColor = System.Drawing.Color.Transparent
        Me.programmingGradientBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.programmingGradientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.programmingGradientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.programmingGradientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.programmingGradientBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.programmingGradientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.programmingGradientBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.programmingGradientBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.programmingGradientBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.programmingGradientBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programmingGradientBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.programmingGradientBtn.Location = New System.Drawing.Point(328, 3)
        Me.programmingGradientBtn.Name = "programmingGradientBtn"
        Me.programmingGradientBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.programmingGradientBtn.Size = New System.Drawing.Size(144, 47)
        Me.programmingGradientBtn.TabIndex = 3
        Me.programmingGradientBtn.Text = "PROGRAMMING"
        '
        'selfhelpGradientBtn
        '
        Me.selfhelpGradientBtn.BackColor = System.Drawing.Color.Transparent
        Me.selfhelpGradientBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selfhelpGradientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.selfhelpGradientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.selfhelpGradientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.selfhelpGradientBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.selfhelpGradientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.selfhelpGradientBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.selfhelpGradientBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.selfhelpGradientBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.selfhelpGradientBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selfhelpGradientBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.selfhelpGradientBtn.Location = New System.Drawing.Point(3, 3)
        Me.selfhelpGradientBtn.Name = "selfhelpGradientBtn"
        Me.selfhelpGradientBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.selfhelpGradientBtn.Size = New System.Drawing.Size(105, 47)
        Me.selfhelpGradientBtn.TabIndex = 0
        Me.selfhelpGradientBtn.Text = "SELF HELP"
        '
        'historyGradientBtn
        '
        Me.historyGradientBtn.BackColor = System.Drawing.Color.Transparent
        Me.historyGradientBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.historyGradientBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.historyGradientBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.historyGradientBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.historyGradientBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.historyGradientBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.historyGradientBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.historyGradientBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.historyGradientBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.historyGradientBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.historyGradientBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.historyGradientBtn.Location = New System.Drawing.Point(114, 3)
        Me.historyGradientBtn.Name = "historyGradientBtn"
        Me.historyGradientBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.historyGradientBtn.Size = New System.Drawing.Size(96, 47)
        Me.historyGradientBtn.TabIndex = 1
        Me.historyGradientBtn.Text = "HISTORY"
        '
        'fictionGradBtn
        '
        Me.fictionGradBtn.BackColor = System.Drawing.Color.Transparent
        Me.fictionGradBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fictionGradBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.fictionGradBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.fictionGradBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fictionGradBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.fictionGradBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.fictionGradBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fictionGradBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fictionGradBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.fictionGradBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fictionGradBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.fictionGradBtn.Location = New System.Drawing.Point(478, 3)
        Me.fictionGradBtn.Name = "fictionGradBtn"
        Me.fictionGradBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.fictionGradBtn.Size = New System.Drawing.Size(100, 46)
        Me.fictionGradBtn.TabIndex = 4
        Me.fictionGradBtn.Text = "FICTION"
        '
        'romanceGradBtn
        '
        Me.romanceGradBtn.BackColor = System.Drawing.Color.Transparent
        Me.romanceGradBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.romanceGradBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.romanceGradBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.romanceGradBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.romanceGradBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.romanceGradBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.romanceGradBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.romanceGradBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.romanceGradBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.romanceGradBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.romanceGradBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.romanceGradBtn.Location = New System.Drawing.Point(216, 3)
        Me.romanceGradBtn.Name = "romanceGradBtn"
        Me.romanceGradBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.romanceGradBtn.Size = New System.Drawing.Size(106, 47)
        Me.romanceGradBtn.TabIndex = 2
        Me.romanceGradBtn.Text = "ROMANCE"
        '
        'allBtn
        '
        Me.allBtn.BackColor = System.Drawing.Color.Transparent
        Me.allBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.allBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.allBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.allBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.allBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.allBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.allBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.allBtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.allBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.allBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.allBtn.Location = New System.Drawing.Point(584, 3)
        Me.allBtn.Name = "allBtn"
        Me.allBtn.PressedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.allBtn.Size = New System.Drawing.Size(66, 46)
        Me.allBtn.TabIndex = 5
        Me.allBtn.Text = "ALL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(668, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "OVERVIEW"
        '
        'homeClearBtn
        '
        Me.homeClearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.homeClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.homeClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.homeClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.homeClearBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.homeClearBtn.Font = New System.Drawing.Font("Rubik", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeClearBtn.ForeColor = System.Drawing.Color.White
        Me.homeClearBtn.Location = New System.Drawing.Point(1122, 590)
        Me.homeClearBtn.Name = "homeClearBtn"
        Me.homeClearBtn.Size = New System.Drawing.Size(138, 39)
        Me.homeClearBtn.TabIndex = 59
        Me.homeClearBtn.Text = "CLEAR"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.bookTitleChange)
        Me.Guna2Panel4.Location = New System.Drawing.Point(666, 176)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(595, 62)
        Me.Guna2Panel4.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.selfhelpGradientBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.historyGradientBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.romanceGradBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.programmingGradientBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.fictionGradBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.allBtn)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 116)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(656, 52)
        Me.FlowLayoutPanel1.TabIndex = 60
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 650)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.homeClearBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.viewReviewsBtn)
        Me.Controls.Add(Me.addReview)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.searchTxtbox)
        Me.Controls.Add(Me.readBtn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.accountsPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents headerTitle As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents bookTitleChange As Label
    Friend WithEvents author As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents authorTextChange As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents dgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents readBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents addReview As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents viewReviewsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bookTitle As DataGridViewTextBoxColumn
    Friend WithEvents bookAuthor As DataGridViewTextBoxColumn
    Friend WithEvents bookDescription As DataGridViewTextBoxColumn
    Friend WithEvents bookPath As DataGridViewTextBoxColumn
    Friend WithEvents accountsPicBox As PictureBox
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents programmingGradientBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents selfhelpGradientBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents historyGradientBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents fictionGradBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents romanceGradBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents allBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents homeClearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class

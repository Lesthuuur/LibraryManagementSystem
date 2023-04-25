<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageBooks
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
        Me.manageBooksSearchButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageBooksDeleteButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageBooksAddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageBooksUpdateButton = New Guna.UI2.WinForms.Guna2Button()
        Me.manageBooksDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.titleTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.authorTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.authorLbl = New System.Windows.Forms.Label()
        Me.pathTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pathLbl = New System.Windows.Forms.Label()
        Me.genreTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.genreLbl = New System.Windows.Forms.Label()
        Me.descriptionRichTxtbox = New System.Windows.Forms.RichTextBox()
        Me.searchTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.showAll = New Guna.UI2.WinForms.Guna2Button()
        Me.openFileDialog = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.manageBooksDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageBooksSearchButton
        '
        Me.manageBooksSearchButton.BorderRadius = 20
        Me.manageBooksSearchButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageBooksSearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksSearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksSearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageBooksSearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageBooksSearchButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageBooksSearchButton.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksSearchButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageBooksSearchButton.Location = New System.Drawing.Point(1099, 38)
        Me.manageBooksSearchButton.Name = "manageBooksSearchButton"
        Me.manageBooksSearchButton.Size = New System.Drawing.Size(90, 36)
        Me.manageBooksSearchButton.TabIndex = 43
        Me.manageBooksSearchButton.Text = "SEARCH"
        '
        'manageBooksDeleteButton
        '
        Me.manageBooksDeleteButton.BorderRadius = 20
        Me.manageBooksDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageBooksDeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksDeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksDeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageBooksDeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageBooksDeleteButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageBooksDeleteButton.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksDeleteButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageBooksDeleteButton.Location = New System.Drawing.Point(961, 574)
        Me.manageBooksDeleteButton.Name = "manageBooksDeleteButton"
        Me.manageBooksDeleteButton.Size = New System.Drawing.Size(89, 39)
        Me.manageBooksDeleteButton.TabIndex = 43
        Me.manageBooksDeleteButton.Text = "DELETE"
        '
        'manageBooksAddButton
        '
        Me.manageBooksAddButton.BorderRadius = 20
        Me.manageBooksAddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageBooksAddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksAddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksAddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageBooksAddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageBooksAddButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageBooksAddButton.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksAddButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageBooksAddButton.Location = New System.Drawing.Point(1195, 570)
        Me.manageBooksAddButton.Name = "manageBooksAddButton"
        Me.manageBooksAddButton.Size = New System.Drawing.Size(89, 39)
        Me.manageBooksAddButton.TabIndex = 42
        Me.manageBooksAddButton.Text = "ADD"
        '
        'manageBooksUpdateButton
        '
        Me.manageBooksUpdateButton.BorderRadius = 20
        Me.manageBooksUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageBooksUpdateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksUpdateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksUpdateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageBooksUpdateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageBooksUpdateButton.FillColor = System.Drawing.Color.Goldenrod
        Me.manageBooksUpdateButton.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksUpdateButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.manageBooksUpdateButton.Location = New System.Drawing.Point(1076, 573)
        Me.manageBooksUpdateButton.Name = "manageBooksUpdateButton"
        Me.manageBooksUpdateButton.Size = New System.Drawing.Size(89, 39)
        Me.manageBooksUpdateButton.TabIndex = 40
        Me.manageBooksUpdateButton.Text = "UPDATE"
        '
        'manageBooksDgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.manageBooksDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.manageBooksDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.manageBooksDgv.ColumnHeadersHeight = 30
        Me.manageBooksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageBooksDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.title, Me.author, Me.genre, Me.description, Me.path})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.manageBooksDgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.manageBooksDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageBooksDgv.Location = New System.Drawing.Point(8, 100)
        Me.manageBooksDgv.Name = "manageBooksDgv"
        Me.manageBooksDgv.RowHeadersVisible = False
        Me.manageBooksDgv.Size = New System.Drawing.Size(917, 513)
        Me.manageBooksDgv.TabIndex = 1
        Me.manageBooksDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.manageBooksDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.manageBooksDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.manageBooksDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.manageBooksDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.manageBooksDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.manageBooksDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.manageBooksDgv.ThemeStyle.HeaderStyle.Height = 30
        Me.manageBooksDgv.ThemeStyle.ReadOnly = False
        Me.manageBooksDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.manageBooksDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.manageBooksDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.manageBooksDgv.ThemeStyle.RowsStyle.Height = 22
        Me.manageBooksDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.manageBooksDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'title
        '
        Me.title.HeaderText = "TITLE"
        Me.title.Name = "title"
        '
        'author
        '
        Me.author.HeaderText = "AUTHOR"
        Me.author.Name = "author"
        '
        'genre
        '
        Me.genre.HeaderText = "GENRE"
        Me.genre.Name = "genre"
        '
        'description
        '
        Me.description.HeaderText = "DESCRIPTION"
        Me.description.Name = "description"
        '
        'path
        '
        Me.path.HeaderText = "PATH"
        Me.path.Name = "path"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Schibsted Grotesk", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(228, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MANAGE BOOKS"
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.White
        Me.titleLbl.Location = New System.Drawing.Point(946, 92)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(50, 28)
        Me.titleLbl.TabIndex = 44
        Me.titleLbl.Text = "TITLE"
        '
        'titleTxtbox
        '
        Me.titleTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.titleTxtbox.DefaultText = ""
        Me.titleTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.titleTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.titleTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.titleTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.titleTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titleTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleTxtbox.ForeColor = System.Drawing.Color.Black
        Me.titleTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titleTxtbox.Location = New System.Drawing.Point(954, 120)
        Me.titleTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.titleTxtbox.Name = "titleTxtbox"
        Me.titleTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.titleTxtbox.PlaceholderText = ""
        Me.titleTxtbox.SelectedText = ""
        Me.titleTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.titleTxtbox.TabIndex = 45
        '
        'authorTxtbox
        '
        Me.authorTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.authorTxtbox.DefaultText = ""
        Me.authorTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.authorTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.authorTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.authorTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.authorTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.authorTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorTxtbox.ForeColor = System.Drawing.Color.Black
        Me.authorTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.authorTxtbox.Location = New System.Drawing.Point(955, 188)
        Me.authorTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.authorTxtbox.Name = "authorTxtbox"
        Me.authorTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.authorTxtbox.PlaceholderText = ""
        Me.authorTxtbox.SelectedText = ""
        Me.authorTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.authorTxtbox.TabIndex = 49
        '
        'authorLbl
        '
        Me.authorLbl.AutoSize = True
        Me.authorLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLbl.ForeColor = System.Drawing.Color.White
        Me.authorLbl.Location = New System.Drawing.Point(947, 160)
        Me.authorLbl.Name = "authorLbl"
        Me.authorLbl.Size = New System.Drawing.Size(77, 28)
        Me.authorLbl.TabIndex = 48
        Me.authorLbl.Text = "AUTHOR"
        '
        'pathTxtbox
        '
        Me.pathTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pathTxtbox.DefaultText = ""
        Me.pathTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pathTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pathTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pathTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pathTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pathTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathTxtbox.ForeColor = System.Drawing.Color.Black
        Me.pathTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pathTxtbox.Location = New System.Drawing.Point(1206, 188)
        Me.pathTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pathTxtbox.Name = "pathTxtbox"
        Me.pathTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pathTxtbox.PlaceholderText = ""
        Me.pathTxtbox.SelectedText = ""
        Me.pathTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.pathTxtbox.TabIndex = 53
        '
        'pathLbl
        '
        Me.pathLbl.AutoSize = True
        Me.pathLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathLbl.ForeColor = System.Drawing.Color.White
        Me.pathLbl.Location = New System.Drawing.Point(1198, 160)
        Me.pathLbl.Name = "pathLbl"
        Me.pathLbl.Size = New System.Drawing.Size(53, 28)
        Me.pathLbl.TabIndex = 52
        Me.pathLbl.Text = "PATH"
        '
        'genreTxtbox
        '
        Me.genreTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.genreTxtbox.DefaultText = ""
        Me.genreTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.genreTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.genreTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genreTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genreTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genreTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genreTxtbox.ForeColor = System.Drawing.Color.Black
        Me.genreTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genreTxtbox.Location = New System.Drawing.Point(1205, 120)
        Me.genreTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.genreTxtbox.Name = "genreTxtbox"
        Me.genreTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.genreTxtbox.PlaceholderText = ""
        Me.genreTxtbox.SelectedText = ""
        Me.genreTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.genreTxtbox.TabIndex = 51
        '
        'genreLbl
        '
        Me.genreLbl.AutoSize = True
        Me.genreLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genreLbl.ForeColor = System.Drawing.Color.White
        Me.genreLbl.Location = New System.Drawing.Point(1197, 92)
        Me.genreLbl.Name = "genreLbl"
        Me.genreLbl.Size = New System.Drawing.Size(64, 28)
        Me.genreLbl.TabIndex = 50
        Me.genreLbl.Text = "GENRE"
        '
        'descriptionRichTxtbox
        '
        Me.descriptionRichTxtbox.Font = New System.Drawing.Font("Poppins Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionRichTxtbox.Location = New System.Drawing.Point(959, 294)
        Me.descriptionRichTxtbox.Name = "descriptionRichTxtbox"
        Me.descriptionRichTxtbox.Size = New System.Drawing.Size(430, 260)
        Me.descriptionRichTxtbox.TabIndex = 54
        Me.descriptionRichTxtbox.Text = ""
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
        Me.searchTxtbox.Location = New System.Drawing.Point(1204, 38)
        Me.searchTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.searchTxtbox.Name = "searchTxtbox"
        Me.searchTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTxtbox.PlaceholderText = ""
        Me.searchTxtbox.SelectedText = ""
        Me.searchTxtbox.Size = New System.Drawing.Size(189, 34)
        Me.searchTxtbox.TabIndex = 55
        '
        'clearBtn
        '
        Me.clearBtn.BorderRadius = 20
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clearBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.clearBtn.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.clearBtn.Location = New System.Drawing.Point(1304, 569)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(89, 39)
        Me.clearBtn.TabIndex = 56
        Me.clearBtn.Text = "CLEAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(958, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 28)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "OVERVIEW"
        '
        'showAll
        '
        Me.showAll.BorderRadius = 20
        Me.showAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.showAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.showAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.showAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.showAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.showAll.FillColor = System.Drawing.Color.Goldenrod
        Me.showAll.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.showAll.Location = New System.Drawing.Point(824, 49)
        Me.showAll.Name = "showAll"
        Me.showAll.Size = New System.Drawing.Size(98, 36)
        Me.showAll.TabIndex = 58
        Me.showAll.Text = "SHOW  ALL"
        '
        'openFileDialog
        '
        Me.openFileDialog.BorderRadius = 20
        Me.openFileDialog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.openFileDialog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.openFileDialog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.openFileDialog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.openFileDialog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.openFileDialog.FillColor = System.Drawing.Color.Goldenrod
        Me.openFileDialog.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openFileDialog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.openFileDialog.Location = New System.Drawing.Point(1317, 230)
        Me.openFileDialog.Name = "openFileDialog"
        Me.openFileDialog.Size = New System.Drawing.Size(78, 36)
        Me.openFileDialog.TabIndex = 59
        Me.openFileDialog.Text = "OPEN"
        '
        'manageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1417, 633)
        Me.Controls.Add(Me.openFileDialog)
        Me.Controls.Add(Me.showAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.searchTxtbox)
        Me.Controls.Add(Me.descriptionRichTxtbox)
        Me.Controls.Add(Me.pathTxtbox)
        Me.Controls.Add(Me.pathLbl)
        Me.Controls.Add(Me.genreTxtbox)
        Me.Controls.Add(Me.genreLbl)
        Me.Controls.Add(Me.authorTxtbox)
        Me.Controls.Add(Me.authorLbl)
        Me.Controls.Add(Me.titleTxtbox)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.manageBooksDeleteButton)
        Me.Controls.Add(Me.manageBooksSearchButton)
        Me.Controls.Add(Me.manageBooksUpdateButton)
        Me.Controls.Add(Me.manageBooksAddButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.manageBooksDgv)
        Me.Name = "manageBooks"
        Me.Text = "Manage Books"
        CType(Me.manageBooksDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents manageBooksDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents manageBooksSearchButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageBooksAddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageBooksUpdateButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageBooksDeleteButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents titleLbl As Label
    Friend WithEvents titleTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents authorTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents authorLbl As Label
    Friend WithEvents pathTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pathLbl As Label
    Friend WithEvents genreTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents genreLbl As Label
    Friend WithEvents descriptionRichTxtbox As RichTextBox
    Friend WithEvents title As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents genre As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents path As DataGridViewTextBoxColumn
    Friend WithEvents searchTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents showAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents openFileDialog As Guna.UI2.WinForms.Guna2Button
End Class

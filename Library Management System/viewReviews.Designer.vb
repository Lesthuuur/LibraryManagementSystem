<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewReviews
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
        Me.reviewsDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.studentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.review = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rating = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reviewRichTxtbox = New System.Windows.Forms.RichTextBox()
        Me.viewReviewLbl = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.studentIDChangeLbl = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.bookTitleChangeLbl = New System.Windows.Forms.Label()
        Me.bookTitleLbl = New System.Windows.Forms.Label()
        Me.studentIDLbl = New System.Windows.Forms.Label()
        Me.ratings = New System.Windows.Forms.Label()
        Me.ratingsLblChanged = New System.Windows.Forms.Label()
        Me.reviewLbltxtbox = New System.Windows.Forms.Label()
        Me.dateTimeLblChange = New System.Windows.Forms.Label()
        Me.dateTimeLbl = New System.Windows.Forms.Label()
        CType(Me.reviewsDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'reviewsDgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.reviewsDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Schibsted Grotesk Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reviewsDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.reviewsDgv.ColumnHeadersHeight = 30
        Me.reviewsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.reviewsDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.studentID, Me.bookTitle, Me.review, Me.rating, Me.timeDate})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reviewsDgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.reviewsDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.reviewsDgv.Location = New System.Drawing.Point(11, 198)
        Me.reviewsDgv.Name = "reviewsDgv"
        Me.reviewsDgv.RowHeadersVisible = False
        Me.reviewsDgv.Size = New System.Drawing.Size(617, 340)
        Me.reviewsDgv.TabIndex = 0
        Me.reviewsDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.reviewsDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.reviewsDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.reviewsDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.reviewsDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.reviewsDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.reviewsDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.reviewsDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.reviewsDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.reviewsDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewsDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.reviewsDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.reviewsDgv.ThemeStyle.HeaderStyle.Height = 30
        Me.reviewsDgv.ThemeStyle.ReadOnly = False
        Me.reviewsDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.reviewsDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.reviewsDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewsDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.reviewsDgv.ThemeStyle.RowsStyle.Height = 22
        Me.reviewsDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.reviewsDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'studentID
        '
        Me.studentID.HeaderText = "STUDENT ID"
        Me.studentID.Name = "studentID"
        '
        'bookTitle
        '
        Me.bookTitle.HeaderText = "TITLE"
        Me.bookTitle.Name = "bookTitle"
        '
        'review
        '
        Me.review.HeaderText = "REVIEW"
        Me.review.Name = "review"
        '
        'rating
        '
        Me.rating.HeaderText = "RATING"
        Me.rating.Name = "rating"
        '
        'timeDate
        '
        Me.timeDate.HeaderText = "TIME AND DATE"
        Me.timeDate.Name = "timeDate"
        '
        'reviewRichTxtbox
        '
        Me.reviewRichTxtbox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewRichTxtbox.ForeColor = System.Drawing.Color.Black
        Me.reviewRichTxtbox.Location = New System.Drawing.Point(650, 198)
        Me.reviewRichTxtbox.Name = "reviewRichTxtbox"
        Me.reviewRichTxtbox.Size = New System.Drawing.Size(350, 336)
        Me.reviewRichTxtbox.TabIndex = 67
        Me.reviewRichTxtbox.Text = ""
        '
        'viewReviewLbl
        '
        Me.viewReviewLbl.Font = New System.Drawing.Font("Schibsted Grotesk Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewReviewLbl.ForeColor = System.Drawing.Color.Goldenrod
        Me.viewReviewLbl.Location = New System.Drawing.Point(13, 14)
        Me.viewReviewLbl.Name = "viewReviewLbl"
        Me.viewReviewLbl.Size = New System.Drawing.Size(285, 47)
        Me.viewReviewLbl.TabIndex = 68
        Me.viewReviewLbl.Text = "BOOKS REVIEWS"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.studentIDChangeLbl)
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(689, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(206, 40)
        Me.Guna2Panel2.TabIndex = 77
        '
        'studentIDChangeLbl
        '
        Me.studentIDChangeLbl.AutoSize = True
        Me.studentIDChangeLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDChangeLbl.ForeColor = System.Drawing.Color.White
        Me.studentIDChangeLbl.Location = New System.Drawing.Point(1, 7)
        Me.studentIDChangeLbl.Name = "studentIDChangeLbl"
        Me.studentIDChangeLbl.Size = New System.Drawing.Size(118, 28)
        Me.studentIDChangeLbl.TabIndex = 74
        Me.studentIDChangeLbl.Text = "ANONYMOUS"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.bookTitleChangeLbl)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(618, 45)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(389, 40)
        Me.Guna2Panel1.TabIndex = 76
        '
        'bookTitleChangeLbl
        '
        Me.bookTitleChangeLbl.AutoSize = True
        Me.bookTitleChangeLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitleChangeLbl.ForeColor = System.Drawing.Color.White
        Me.bookTitleChangeLbl.Location = New System.Drawing.Point(2, 12)
        Me.bookTitleChangeLbl.Name = "bookTitleChangeLbl"
        Me.bookTitleChangeLbl.Size = New System.Drawing.Size(101, 28)
        Me.bookTitleChangeLbl.TabIndex = 75
        Me.bookTitleChangeLbl.Text = "BOOK TITLE"
        '
        'bookTitleLbl
        '
        Me.bookTitleLbl.AutoSize = True
        Me.bookTitleLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitleLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.bookTitleLbl.Location = New System.Drawing.Point(549, 54)
        Me.bookTitleLbl.Name = "bookTitleLbl"
        Me.bookTitleLbl.Size = New System.Drawing.Size(63, 24)
        Me.bookTitleLbl.TabIndex = 75
        Me.bookTitleLbl.Text = "TITLE:"
        '
        'studentIDLbl
        '
        Me.studentIDLbl.AutoSize = True
        Me.studentIDLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.studentIDLbl.Location = New System.Drawing.Point(546, 12)
        Me.studentIDLbl.Name = "studentIDLbl"
        Me.studentIDLbl.Size = New System.Drawing.Size(148, 24)
        Me.studentIDLbl.TabIndex = 74
        Me.studentIDLbl.Text = "STUDENT NAME:"
        '
        'ratings
        '
        Me.ratings.AutoSize = True
        Me.ratings.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ratings.Location = New System.Drawing.Point(551, 94)
        Me.ratings.Name = "ratings"
        Me.ratings.Size = New System.Drawing.Size(90, 24)
        Me.ratings.TabIndex = 78
        Me.ratings.Text = "RATINGS:"
        '
        'ratingsLblChanged
        '
        Me.ratingsLblChanged.AutoSize = True
        Me.ratingsLblChanged.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratingsLblChanged.ForeColor = System.Drawing.Color.White
        Me.ratingsLblChanged.Location = New System.Drawing.Point(639, 97)
        Me.ratingsLblChanged.Name = "ratingsLblChanged"
        Me.ratingsLblChanged.Size = New System.Drawing.Size(61, 28)
        Me.ratingsLblChanged.TabIndex = 76
        Me.ratingsLblChanged.Text = "rating"
        '
        'reviewLbltxtbox
        '
        Me.reviewLbltxtbox.AutoSize = True
        Me.reviewLbltxtbox.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewLbltxtbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.reviewLbltxtbox.Location = New System.Drawing.Point(649, 168)
        Me.reviewLbltxtbox.Name = "reviewLbltxtbox"
        Me.reviewLbltxtbox.Size = New System.Drawing.Size(77, 24)
        Me.reviewLbltxtbox.TabIndex = 79
        Me.reviewLbltxtbox.Text = "REVIEW"
        '
        'dateTimeLblChange
        '
        Me.dateTimeLblChange.AutoSize = True
        Me.dateTimeLblChange.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeLblChange.ForeColor = System.Drawing.Color.White
        Me.dateTimeLblChange.Location = New System.Drawing.Point(801, 138)
        Me.dateTimeLblChange.Name = "dateTimeLblChange"
        Me.dateTimeLblChange.Size = New System.Drawing.Size(90, 28)
        Me.dateTimeLblChange.TabIndex = 80
        Me.dateTimeLblChange.Text = "dateTime"
        '
        'dateTimeLbl
        '
        Me.dateTimeLbl.AutoSize = True
        Me.dateTimeLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTimeLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dateTimeLbl.Location = New System.Drawing.Point(556, 134)
        Me.dateTimeLbl.Name = "dateTimeLbl"
        Me.dateTimeLbl.Size = New System.Drawing.Size(239, 24)
        Me.dateTimeLbl.TabIndex = 81
        Me.dateTimeLbl.Text = "TIME AND DATE OF REVIEW:"
        '
        'viewReviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1025, 549)
        Me.Controls.Add(Me.dateTimeLblChange)
        Me.Controls.Add(Me.dateTimeLbl)
        Me.Controls.Add(Me.reviewLbltxtbox)
        Me.Controls.Add(Me.ratingsLblChanged)
        Me.Controls.Add(Me.ratings)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.bookTitleLbl)
        Me.Controls.Add(Me.studentIDLbl)
        Me.Controls.Add(Me.viewReviewLbl)
        Me.Controls.Add(Me.reviewRichTxtbox)
        Me.Controls.Add(Me.reviewsDgv)
        Me.Name = "viewReviews"
        Me.Text = "viewReviews"
        CType(Me.reviewsDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reviewsDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents reviewRichTxtbox As RichTextBox
    Friend WithEvents viewReviewLbl As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents studentIDChangeLbl As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents bookTitleChangeLbl As Label
    Friend WithEvents bookTitleLbl As Label
    Friend WithEvents studentIDLbl As Label
    Friend WithEvents ratings As Label
    Friend WithEvents ratingsLblChanged As Label
    Friend WithEvents reviewLbltxtbox As Label
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents bookTitle As DataGridViewTextBoxColumn
    Friend WithEvents review As DataGridViewTextBoxColumn
    Friend WithEvents rating As DataGridViewTextBoxColumn
    Friend WithEvents timeDate As DataGridViewTextBoxColumn
    Friend WithEvents dateTimeLblChange As Label
    Friend WithEvents dateTimeLbl As Label
End Class

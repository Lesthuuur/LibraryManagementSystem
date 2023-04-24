<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reviews
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reviewRichTxtbox = New System.Windows.Forms.RichTextBox()
        Me.bookTitleLbl = New System.Windows.Forms.Label()
        Me.studentIDLbl = New System.Windows.Forms.Label()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.reviewsAddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ratingTxtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rating = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.studentIDChangeLbl = New System.Windows.Forms.Label()
        Me.bookTitleChangeLbl = New System.Windows.Forms.Label()
        Me.addReviewsLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "REVIEW"
        '
        'reviewRichTxtbox
        '
        Me.reviewRichTxtbox.Font = New System.Drawing.Font("Poppins Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewRichTxtbox.ForeColor = System.Drawing.Color.Black
        Me.reviewRichTxtbox.Location = New System.Drawing.Point(18, 261)
        Me.reviewRichTxtbox.Name = "reviewRichTxtbox"
        Me.reviewRichTxtbox.Size = New System.Drawing.Size(430, 260)
        Me.reviewRichTxtbox.TabIndex = 66
        Me.reviewRichTxtbox.Text = ""
        '
        'bookTitleLbl
        '
        Me.bookTitleLbl.AutoSize = True
        Me.bookTitleLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitleLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.bookTitleLbl.Location = New System.Drawing.Point(12, 135)
        Me.bookTitleLbl.Name = "bookTitleLbl"
        Me.bookTitleLbl.Size = New System.Drawing.Size(63, 24)
        Me.bookTitleLbl.TabIndex = 60
        Me.bookTitleLbl.Text = "TITLE:"
        '
        'studentIDLbl
        '
        Me.studentIDLbl.AutoSize = True
        Me.studentIDLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.studentIDLbl.Location = New System.Drawing.Point(8, 73)
        Me.studentIDLbl.Name = "studentIDLbl"
        Me.studentIDLbl.Size = New System.Drawing.Size(117, 24)
        Me.studentIDLbl.TabIndex = 58
        Me.studentIDLbl.Text = "STUDENT ID:"
        '
        'clearBtn
        '
        Me.clearBtn.BorderRadius = 20
        Me.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clearBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.clearBtn.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.clearBtn.Location = New System.Drawing.Point(238, 530)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(89, 39)
        Me.clearBtn.TabIndex = 69
        Me.clearBtn.Text = "CLEAR"
        '
        'reviewsAddBtn
        '
        Me.reviewsAddBtn.BorderRadius = 20
        Me.reviewsAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.reviewsAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.reviewsAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.reviewsAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.reviewsAddBtn.FillColor = System.Drawing.Color.Goldenrod
        Me.reviewsAddBtn.Font = New System.Drawing.Font("Rubik", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewsAddBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.reviewsAddBtn.Location = New System.Drawing.Point(129, 531)
        Me.reviewsAddBtn.Name = "reviewsAddBtn"
        Me.reviewsAddBtn.Size = New System.Drawing.Size(89, 39)
        Me.reviewsAddBtn.TabIndex = 68
        Me.reviewsAddBtn.Text = "ADD"
        '
        'ratingTxtbox
        '
        Me.ratingTxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ratingTxtbox.DefaultText = ""
        Me.ratingTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ratingTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ratingTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ratingTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ratingTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ratingTxtbox.Font = New System.Drawing.Font("Poppins Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratingTxtbox.ForeColor = System.Drawing.Color.Black
        Me.ratingTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ratingTxtbox.Location = New System.Drawing.Point(88, 186)
        Me.ratingTxtbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ratingTxtbox.Name = "ratingTxtbox"
        Me.ratingTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ratingTxtbox.PlaceholderText = ""
        Me.ratingTxtbox.SelectedText = ""
        Me.ratingTxtbox.Size = New System.Drawing.Size(60, 25)
        Me.ratingTxtbox.TabIndex = 71
        '
        'rating
        '
        Me.rating.AutoSize = True
        Me.rating.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.rating.Location = New System.Drawing.Point(16, 186)
        Me.rating.Name = "rating"
        Me.rating.Size = New System.Drawing.Size(74, 24)
        Me.rating.TabIndex = 70
        Me.rating.Text = "RATING"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.bookTitleChangeLbl)
        Me.Guna2Panel1.Location = New System.Drawing.Point(81, 126)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(389, 40)
        Me.Guna2Panel1.TabIndex = 72
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.studentIDChangeLbl)
        Me.Guna2Panel2.Location = New System.Drawing.Point(123, 66)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(206, 40)
        Me.Guna2Panel2.TabIndex = 73
        '
        'studentIDChangeLbl
        '
        Me.studentIDChangeLbl.AutoSize = True
        Me.studentIDChangeLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentIDChangeLbl.ForeColor = System.Drawing.Color.Black
        Me.studentIDChangeLbl.Location = New System.Drawing.Point(1, 7)
        Me.studentIDChangeLbl.Name = "studentIDChangeLbl"
        Me.studentIDChangeLbl.Size = New System.Drawing.Size(102, 28)
        Me.studentIDChangeLbl.TabIndex = 74
        Me.studentIDChangeLbl.Text = "STUDENT ID"
        '
        'bookTitleChangeLbl
        '
        Me.bookTitleChangeLbl.AutoSize = True
        Me.bookTitleChangeLbl.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitleChangeLbl.ForeColor = System.Drawing.Color.Black
        Me.bookTitleChangeLbl.Location = New System.Drawing.Point(2, 7)
        Me.bookTitleChangeLbl.Name = "bookTitleChangeLbl"
        Me.bookTitleChangeLbl.Size = New System.Drawing.Size(101, 28)
        Me.bookTitleChangeLbl.TabIndex = 75
        Me.bookTitleChangeLbl.Text = "BOOK TITLE"
        '
        'addReviewsLbl
        '
        Me.addReviewsLbl.AutoSize = True
        Me.addReviewsLbl.Font = New System.Drawing.Font("Schibsted Grotesk ExtraBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addReviewsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.addReviewsLbl.Location = New System.Drawing.Point(65, 12)
        Me.addReviewsLbl.Name = "addReviewsLbl"
        Me.addReviewsLbl.Size = New System.Drawing.Size(339, 40)
        Me.addReviewsLbl.TabIndex = 74
        Me.addReviewsLbl.Text = "SHARE YOUR INSIGHTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(149, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Add ratings 1 - 10"
        '
        'reviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 585)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addReviewsLbl)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ratingTxtbox)
        Me.Controls.Add(Me.rating)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.reviewsAddBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.reviewRichTxtbox)
        Me.Controls.Add(Me.bookTitleLbl)
        Me.Controls.Add(Me.studentIDLbl)
        Me.Name = "reviews"
        Me.Text = "reviews"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents reviewRichTxtbox As RichTextBox
    Friend WithEvents bookTitleLbl As Label
    Friend WithEvents studentIDLbl As Label
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents reviewsAddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ratingTxtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents rating As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents bookTitleChangeLbl As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents studentIDChangeLbl As Label
    Friend WithEvents addReviewsLbl As Label
    Friend WithEvents Label3 As Label
End Class

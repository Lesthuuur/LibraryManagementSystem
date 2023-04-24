<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accounts))
        Me.manageStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.manageLibrarianBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.manageBooksBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manageStudent
        '
        Me.manageStudent.BackColor = System.Drawing.Color.Transparent
        Me.manageStudent.BorderColor = System.Drawing.Color.Transparent
        Me.manageStudent.BorderRadius = 20
        Me.manageStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.manageStudent.Font = New System.Drawing.Font("Schibsted Grotesk", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.manageStudent.Location = New System.Drawing.Point(98, 315)
        Me.manageStudent.Name = "manageStudent"
        Me.manageStudent.Size = New System.Drawing.Size(175, 42)
        Me.manageStudent.TabIndex = 7
        Me.manageStudent.Text = "MANAGE STUDENT"
        '
        'manageLibrarianBtn
        '
        Me.manageLibrarianBtn.BackColor = System.Drawing.Color.Transparent
        Me.manageLibrarianBtn.BorderColor = System.Drawing.Color.Transparent
        Me.manageLibrarianBtn.BorderRadius = 20
        Me.manageLibrarianBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageLibrarianBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageLibrarianBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageLibrarianBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageLibrarianBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.manageLibrarianBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageLibrarianBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.manageLibrarianBtn.Location = New System.Drawing.Point(98, 377)
        Me.manageLibrarianBtn.Name = "manageLibrarianBtn"
        Me.manageLibrarianBtn.Size = New System.Drawing.Size(175, 42)
        Me.manageLibrarianBtn.TabIndex = 8
        Me.manageLibrarianBtn.Text = "MANAGE LIBRARIAN"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(368, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(392, 588)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'manageBooksBtn
        '
        Me.manageBooksBtn.BackColor = System.Drawing.Color.Transparent
        Me.manageBooksBtn.BorderColor = System.Drawing.Color.Transparent
        Me.manageBooksBtn.BorderRadius = 20
        Me.manageBooksBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manageBooksBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manageBooksBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manageBooksBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.manageBooksBtn.Font = New System.Drawing.Font("Schibsted Grotesk", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageBooksBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.manageBooksBtn.Location = New System.Drawing.Point(99, 440)
        Me.manageBooksBtn.Name = "manageBooksBtn"
        Me.manageBooksBtn.Size = New System.Drawing.Size(175, 42)
        Me.manageBooksBtn.TabIndex = 10
        Me.manageBooksBtn.Text = "MANAGE BOOKS"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(84, 109)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(203, 160)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox2.TabIndex = 11
        Me.Guna2PictureBox2.TabStop = False
        '
        'accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(761, 587)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.manageBooksBtn)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.manageLibrarianBtn)
        Me.Controls.Add(Me.manageStudent)
        Me.Name = "accounts"
        Me.Text = "accounts"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents manageStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manageLibrarianBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents manageBooksBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class

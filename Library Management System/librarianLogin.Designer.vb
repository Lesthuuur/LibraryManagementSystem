<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class librarianLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(librarianLogin))
        Me.adminLogBgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.librarianCreateAccLbl = New System.Windows.Forms.Label()
        Me.librarianLogButton = New Guna.UI2.WinForms.Guna2Button()
        Me.librarianUserLogTextBox = New System.Windows.Forms.TextBox()
        Me.loginLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.librarianPassLogTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.showPassLbl = New System.Windows.Forms.Label()
        Me.adminLogBgPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'adminLogBgPanel
        '
        Me.adminLogBgPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminLogBgPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.adminLogBgPanel.Controls.Add(Me.PictureBox1)
        Me.adminLogBgPanel.Location = New System.Drawing.Point(374, 0)
        Me.adminLogBgPanel.Name = "adminLogBgPanel"
        Me.adminLogBgPanel.Size = New System.Drawing.Size(427, 460)
        Me.adminLogBgPanel.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(427, 460)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'librarianCreateAccLbl
        '
        Me.librarianCreateAccLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.librarianCreateAccLbl.AutoSize = True
        Me.librarianCreateAccLbl.BackColor = System.Drawing.Color.Transparent
        Me.librarianCreateAccLbl.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.librarianCreateAccLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.librarianCreateAccLbl.Location = New System.Drawing.Point(74, 321)
        Me.librarianCreateAccLbl.Name = "librarianCreateAccLbl"
        Me.librarianCreateAccLbl.Size = New System.Drawing.Size(112, 19)
        Me.librarianCreateAccLbl.TabIndex = 12
        Me.librarianCreateAccLbl.Text = "Create an account"
        '
        'librarianLogButton
        '
        Me.librarianLogButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.librarianLogButton.BackColor = System.Drawing.Color.Transparent
        Me.librarianLogButton.BorderColor = System.Drawing.Color.Transparent
        Me.librarianLogButton.BorderRadius = 20
        Me.librarianLogButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.librarianLogButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.librarianLogButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.librarianLogButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.librarianLogButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.librarianLogButton.Font = New System.Drawing.Font("Rubik Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.librarianLogButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.librarianLogButton.Location = New System.Drawing.Point(60, 269)
        Me.librarianLogButton.Name = "librarianLogButton"
        Me.librarianLogButton.Size = New System.Drawing.Size(146, 40)
        Me.librarianLogButton.TabIndex = 11
        Me.librarianLogButton.Text = "LOGIN"
        '
        'librarianUserLogTextBox
        '
        Me.librarianUserLogTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.librarianUserLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.librarianUserLogTextBox.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianUserLogTextBox.Location = New System.Drawing.Point(39, 125)
        Me.librarianUserLogTextBox.Multiline = True
        Me.librarianUserLogTextBox.Name = "librarianUserLogTextBox"
        Me.librarianUserLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.librarianUserLogTextBox.TabIndex = 0
        '
        'loginLbl
        '
        Me.loginLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginLbl.AutoSize = True
        Me.loginLbl.BackColor = System.Drawing.Color.Transparent
        Me.loginLbl.Font = New System.Drawing.Font("Schibsted Grotesk", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.loginLbl.Location = New System.Drawing.Point(18, 27)
        Me.loginLbl.Name = "loginLbl"
        Me.loginLbl.Size = New System.Drawing.Size(236, 36)
        Me.loginLbl.TabIndex = 2
        Me.loginLbl.Text = "LIBRARIAN LOGIN"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(39, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PASSWORD"
        '
        'librarianPassLogTextBox
        '
        Me.librarianPassLogTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.librarianPassLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.librarianPassLogTextBox.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.librarianPassLogTextBox.Location = New System.Drawing.Point(39, 203)
        Me.librarianPassLogTextBox.Multiline = True
        Me.librarianPassLogTextBox.Name = "librarianPassLogTextBox"
        Me.librarianPassLogTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.librarianPassLogTextBox.Size = New System.Drawing.Size(190, 28)
        Me.librarianPassLogTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.BorderRadius = 30
        Me.Guna2GroupBox1.Controls.Add(Me.showPassLbl)
        Me.Guna2GroupBox1.Controls.Add(Me.librarianCreateAccLbl)
        Me.Guna2GroupBox1.Controls.Add(Me.loginLbl)
        Me.Guna2GroupBox1.Controls.Add(Me.librarianLogButton)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.librarianUserLogTextBox)
        Me.Guna2GroupBox1.Controls.Add(Me.librarianPassLogTextBox)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(44, 43)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(268, 359)
        Me.Guna2GroupBox1.TabIndex = 7
        '
        'showPassLbl
        '
        Me.showPassLbl.AutoSize = True
        Me.showPassLbl.BackColor = System.Drawing.Color.Transparent
        Me.showPassLbl.Font = New System.Drawing.Font("Poppins", 8.0!)
        Me.showPassLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.showPassLbl.Location = New System.Drawing.Point(140, 233)
        Me.showPassLbl.Name = "showPassLbl"
        Me.showPassLbl.Size = New System.Drawing.Size(93, 19)
        Me.showPassLbl.TabIndex = 15
        Me.showPassLbl.Text = "Show Password"
        '
        'librarianLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.adminLogBgPanel)
        Me.Name = "librarianLogin"
        Me.Text = "Admin Login"
        Me.adminLogBgPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents adminLogBgPanel As Panel
    Friend WithEvents librarianUserLogTextBox As TextBox
    Friend WithEvents loginLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents librarianPassLogTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents librarianLogButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents librarianCreateAccLbl As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents showPassLbl As Label
End Class

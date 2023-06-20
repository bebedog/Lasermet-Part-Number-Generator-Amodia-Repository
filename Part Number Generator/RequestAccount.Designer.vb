<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestAccount))
        Me.tbPassword = New MetroFramework.Controls.MetroTextBox()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.lblPassword = New MetroFramework.Controls.MetroLabel()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.tbEmail = New MetroFramework.Controls.MetroTextBox()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.tbFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.lblFirstName = New MetroFramework.Controls.MetroLabel()
        Me.tbSurname = New MetroFramework.Controls.MetroTextBox()
        Me.lblSurname = New MetroFramework.Controls.MetroLabel()
        Me.btnSendRequest = New MetroFramework.Controls.MetroButton()
        Me.btnGoBack = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbLocation = New MetroFramework.Controls.MetroComboBox()
        Me.pbLasermet = New System.Windows.Forms.PictureBox()
        Me.cbDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbPassword.CustomButton.Image = Nothing
        Me.tbPassword.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbPassword.CustomButton.Name = ""
        Me.tbPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPassword.CustomButton.TabIndex = 1
        Me.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPassword.CustomButton.UseSelectable = True
        Me.tbPassword.CustomButton.Visible = False
        Me.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPassword.Lines = New String(-1) {}
        Me.tbPassword.Location = New System.Drawing.Point(128, 266)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPassword.PromptText = "Password"
        Me.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.SelectionLength = 0
        Me.tbPassword.SelectionStart = 0
        Me.tbPassword.ShortcutsEnabled = True
        Me.tbPassword.Size = New System.Drawing.Size(330, 23)
        Me.tbPassword.TabIndex = 3
        Me.tbPassword.UseSelectable = True
        Me.tbPassword.UseSystemPasswordChar = True
        Me.tbPassword.WaterMark = "Password"
        Me.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPassword.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbUsername.CustomButton.Image = Nothing
        Me.tbUsername.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbUsername.CustomButton.Name = ""
        Me.tbUsername.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUsername.CustomButton.TabIndex = 1
        Me.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUsername.CustomButton.UseSelectable = True
        Me.tbUsername.CustomButton.Visible = False
        Me.tbUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUsername.Lines = New String(-1) {}
        Me.tbUsername.Location = New System.Drawing.Point(128, 226)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.PromptText = "Username"
        Me.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.SelectionLength = 0
        Me.tbUsername.SelectionStart = 0
        Me.tbUsername.ShortcutsEnabled = True
        Me.tbUsername.Size = New System.Drawing.Size(330, 23)
        Me.tbUsername.TabIndex = 2
        Me.tbUsername.UseSelectable = True
        Me.tbUsername.WaterMark = "Username"
        Me.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUsername.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPassword.Location = New System.Drawing.Point(28, 264)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 25)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblUsername.Location = New System.Drawing.Point(22, 224)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        '
        'tbEmail
        '
        Me.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbEmail.CustomButton.Image = Nothing
        Me.tbEmail.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbEmail.CustomButton.Name = ""
        Me.tbEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbEmail.CustomButton.TabIndex = 1
        Me.tbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbEmail.CustomButton.UseSelectable = True
        Me.tbEmail.CustomButton.Visible = False
        Me.tbEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbEmail.Lines = New String(-1) {}
        Me.tbEmail.Location = New System.Drawing.Point(128, 394)
        Me.tbEmail.MaxLength = 32767
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmail.PromptText = "Lasermet E-mail"
        Me.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.SelectionLength = 0
        Me.tbEmail.SelectionStart = 0
        Me.tbEmail.ShortcutsEnabled = True
        Me.tbEmail.Size = New System.Drawing.Size(330, 23)
        Me.tbEmail.TabIndex = 6
        Me.tbEmail.UseSelectable = True
        Me.tbEmail.WaterMark = "Lasermet E-mail"
        Me.tbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbEmail.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblEmail.Location = New System.Drawing.Point(54, 391)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(70, 25)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "E-mail:"
        '
        'tbFirstname
        '
        Me.tbFirstname.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFirstname.CustomButton.Image = Nothing
        Me.tbFirstname.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbFirstname.CustomButton.Name = ""
        Me.tbFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFirstname.CustomButton.TabIndex = 1
        Me.tbFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFirstname.CustomButton.UseSelectable = True
        Me.tbFirstname.CustomButton.Visible = False
        Me.tbFirstname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbFirstname.Lines = New String(-1) {}
        Me.tbFirstname.Location = New System.Drawing.Point(128, 147)
        Me.tbFirstname.MaxLength = 32767
        Me.tbFirstname.Name = "tbFirstname"
        Me.tbFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFirstname.PromptText = "First Name"
        Me.tbFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFirstname.SelectedText = ""
        Me.tbFirstname.SelectionLength = 0
        Me.tbFirstname.SelectionStart = 0
        Me.tbFirstname.ShortcutsEnabled = True
        Me.tbFirstname.Size = New System.Drawing.Size(330, 23)
        Me.tbFirstname.TabIndex = 0
        Me.tbFirstname.UseSelectable = True
        Me.tbFirstname.WaterMark = "First Name"
        Me.tbFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFirstname.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblFirstName.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblFirstName.Location = New System.Drawing.Point(16, 144)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(108, 25)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "First Name:"
        '
        'tbSurname
        '
        Me.tbSurname.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSurname.CustomButton.Image = Nothing
        Me.tbSurname.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbSurname.CustomButton.Name = ""
        Me.tbSurname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSurname.CustomButton.TabIndex = 1
        Me.tbSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSurname.CustomButton.UseSelectable = True
        Me.tbSurname.CustomButton.Visible = False
        Me.tbSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSurname.Lines = New String(-1) {}
        Me.tbSurname.Location = New System.Drawing.Point(128, 187)
        Me.tbSurname.MaxLength = 32767
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSurname.PromptText = "Surname"
        Me.tbSurname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSurname.SelectedText = ""
        Me.tbSurname.SelectionLength = 0
        Me.tbSurname.SelectionStart = 0
        Me.tbSurname.ShortcutsEnabled = True
        Me.tbSurname.Size = New System.Drawing.Size(330, 23)
        Me.tbSurname.TabIndex = 1
        Me.tbSurname.UseSelectable = True
        Me.tbSurname.WaterMark = "Surname"
        Me.tbSurname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSurname.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblSurname
        '
        Me.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSurname.AutoSize = True
        Me.lblSurname.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblSurname.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSurname.Location = New System.Drawing.Point(32, 184)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(92, 25)
        Me.lblSurname.TabIndex = 14
        Me.lblSurname.Text = "Surname:"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnSendRequest
        '
        Me.btnSendRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSendRequest.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSendRequest.Location = New System.Drawing.Point(56, 446)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.Size = New System.Drawing.Size(180, 32)
        Me.btnSendRequest.TabIndex = 7
        Me.btnSendRequest.Text = "Send Request"
        Me.btnSendRequest.UseSelectable = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGoBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnGoBack.Location = New System.Drawing.Point(248, 446)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(180, 32)
        Me.btnGoBack.TabIndex = 8
        Me.btnGoBack.Text = "Go Back to Log In"
        Me.btnGoBack.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(32, 352)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(90, 25)
        Me.MetroLabel1.TabIndex = 16
        Me.MetroLabel1.Text = "Location:"
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.ItemHeight = 23
        Me.cbLocation.Location = New System.Drawing.Point(128, 351)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(330, 29)
        Me.cbLocation.TabIndex = 5
        Me.cbLocation.UseSelectable = True
        '
        'pbLasermet
        '
        Me.pbLasermet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLasermet.Image = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.InitialImage = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.Location = New System.Drawing.Point(80, 24)
        Me.pbLasermet.Name = "pbLasermet"
        Me.pbLasermet.Size = New System.Drawing.Size(330, 104)
        Me.pbLasermet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLasermet.TabIndex = 9
        Me.pbLasermet.TabStop = False
        '
        'cbDepartment
        '
        Me.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.ItemHeight = 23
        Me.cbDepartment.Items.AddRange(New Object() {"Admin", "Electronics", "Mechanical"})
        Me.cbDepartment.Location = New System.Drawing.Point(128, 304)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(330, 29)
        Me.cbDepartment.TabIndex = 4
        Me.cbDepartment.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(5, 305)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(120, 25)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Department:"
        '
        'RequestAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbDepartment)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnSendRequest)
        Me.Controls.Add(Me.tbSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.tbFirstname)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.pbLasermet)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RequestAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Account Request"
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLasermet As PictureBox
    Friend WithEvents tbPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblFirstName As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSurname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblSurname As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSendRequest As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGoBack As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbLocation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class

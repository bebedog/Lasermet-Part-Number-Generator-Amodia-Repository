<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblPassword = New MetroFramework.Controls.MetroLabel()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.tbPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        Me.btnRequestAccount = New MetroFramework.Controls.MetroButton()
        Me.btnChangePW = New MetroFramework.Controls.MetroButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbLasermet = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblUsername.Location = New System.Drawing.Point(24, 128)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(102, 25)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPassword.Location = New System.Drawing.Point(24, 190)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 25)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbUsername.CustomButton.Image = Nothing
        Me.tbUsername.CustomButton.Location = New System.Drawing.Point(309, 1)
        Me.tbUsername.CustomButton.Name = ""
        Me.tbUsername.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUsername.CustomButton.TabIndex = 1
        Me.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUsername.CustomButton.UseSelectable = True
        Me.tbUsername.CustomButton.Visible = False
        Me.tbUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUsername.Lines = New String(-1) {}
        Me.tbUsername.Location = New System.Drawing.Point(24, 158)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.PromptText = "Username"
        Me.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.SelectionLength = 0
        Me.tbUsername.SelectionStart = 0
        Me.tbUsername.ShortcutsEnabled = True
        Me.tbUsername.Size = New System.Drawing.Size(331, 23)
        Me.tbUsername.TabIndex = 0
        Me.tbUsername.UseSelectable = True
        Me.tbUsername.WaterMark = "Username"
        Me.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUsername.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbPassword.CustomButton.Image = Nothing
        Me.tbPassword.CustomButton.Location = New System.Drawing.Point(309, 1)
        Me.tbPassword.CustomButton.Name = ""
        Me.tbPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPassword.CustomButton.TabIndex = 1
        Me.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPassword.CustomButton.UseSelectable = True
        Me.tbPassword.CustomButton.Visible = False
        Me.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPassword.Lines = New String(-1) {}
        Me.tbPassword.Location = New System.Drawing.Point(24, 220)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPassword.PromptText = "Password"
        Me.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.SelectionLength = 0
        Me.tbPassword.SelectionStart = 0
        Me.tbPassword.ShortcutsEnabled = True
        Me.tbPassword.Size = New System.Drawing.Size(331, 23)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.UseSelectable = True
        Me.tbPassword.UseSystemPasswordChar = True
        Me.tbPassword.WaterMark = "Password"
        Me.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPassword.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnLogin.Location = New System.Drawing.Point(134, 256)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(220, 32)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseSelectable = True
        '
        'btnRequestAccount
        '
        Me.btnRequestAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRequestAccount.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnRequestAccount.Location = New System.Drawing.Point(134, 330)
        Me.btnRequestAccount.Name = "btnRequestAccount"
        Me.btnRequestAccount.Size = New System.Drawing.Size(220, 32)
        Me.btnRequestAccount.TabIndex = 4
        Me.btnRequestAccount.Text = "Request for Account"
        Me.btnRequestAccount.UseSelectable = True
        '
        'btnChangePW
        '
        Me.btnChangePW.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangePW.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnChangePW.Location = New System.Drawing.Point(134, 293)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(220, 32)
        Me.btnChangePW.TabIndex = 3
        Me.btnChangePW.Text = "Change Password"
        Me.btnChangePW.UseSelectable = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 379)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(384, 22)
        Me.StatusStrip1.Stretch = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'pbLasermet
        '
        Me.pbLasermet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLasermet.Image = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.InitialImage = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.Location = New System.Drawing.Point(24, 16)
        Me.pbLasermet.Name = "pbLasermet"
        Me.pbLasermet.Size = New System.Drawing.Size(331, 104)
        Me.pbLasermet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLasermet.TabIndex = 4
        Me.pbLasermet.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 401)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnChangePW)
        Me.Controls.Add(Me.btnRequestAccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.pbLasermet)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pbLasermet As PictureBox
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRequestAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents btnChangePW As MetroFramework.Controls.MetroButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class

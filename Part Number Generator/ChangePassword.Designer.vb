<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.pbLasermet = New System.Windows.Forms.PictureBox()
        Me.tbPasswordOld = New MetroFramework.Controls.MetroTextBox()
        Me.tbUsername = New MetroFramework.Controls.MetroTextBox()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.btnChangePW = New MetroFramework.Controls.MetroButton()
        Me.tbPasswordNew = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblPasswordOld = New MetroFramework.Controls.MetroLabel()
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLasermet
        '
        Me.pbLasermet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLasermet.Image = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.InitialImage = Global.Part_Number_Generator.My.Resources.Resources.LasermetPH_logo
        Me.pbLasermet.Location = New System.Drawing.Point(80, 35)
        Me.pbLasermet.Name = "pbLasermet"
        Me.pbLasermet.Size = New System.Drawing.Size(330, 104)
        Me.pbLasermet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLasermet.TabIndex = 10
        Me.pbLasermet.TabStop = False
        '
        'tbPasswordOld
        '
        Me.tbPasswordOld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbPasswordOld.CustomButton.Image = Nothing
        Me.tbPasswordOld.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbPasswordOld.CustomButton.Name = ""
        Me.tbPasswordOld.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPasswordOld.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPasswordOld.CustomButton.TabIndex = 1
        Me.tbPasswordOld.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPasswordOld.CustomButton.UseSelectable = True
        Me.tbPasswordOld.CustomButton.Visible = False
        Me.tbPasswordOld.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPasswordOld.Lines = New String(-1) {}
        Me.tbPasswordOld.Location = New System.Drawing.Point(123, 243)
        Me.tbPasswordOld.MaxLength = 32767
        Me.tbPasswordOld.Name = "tbPasswordOld"
        Me.tbPasswordOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPasswordOld.PromptText = "Old Password"
        Me.tbPasswordOld.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPasswordOld.SelectedText = ""
        Me.tbPasswordOld.SelectionLength = 0
        Me.tbPasswordOld.SelectionStart = 0
        Me.tbPasswordOld.ShortcutsEnabled = True
        Me.tbPasswordOld.Size = New System.Drawing.Size(330, 23)
        Me.tbPasswordOld.TabIndex = 2
        Me.tbPasswordOld.UseSelectable = True
        Me.tbPasswordOld.UseSystemPasswordChar = True
        Me.tbPasswordOld.WaterMark = "Old Password"
        Me.tbPasswordOld.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPasswordOld.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbUsername
        '
        Me.tbUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.tbUsername.Location = New System.Drawing.Point(123, 201)
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
        Me.tbUsername.TabIndex = 1
        Me.tbUsername.UseSelectable = True
        Me.tbUsername.WaterMark = "Username"
        Me.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUsername.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblUsername.Location = New System.Drawing.Point(43, 201)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 19)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(248, 336)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(180, 32)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Go Back to Log In"
        Me.btnBack.UseSelectable = True
        '
        'btnChangePW
        '
        Me.btnChangePW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangePW.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnChangePW.Location = New System.Drawing.Point(56, 336)
        Me.btnChangePW.Name = "btnChangePW"
        Me.btnChangePW.Size = New System.Drawing.Size(180, 32)
        Me.btnChangePW.TabIndex = 4
        Me.btnChangePW.Text = "Change Password"
        Me.btnChangePW.UseSelectable = True
        '
        'tbPasswordNew
        '
        Me.tbPasswordNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbPasswordNew.CustomButton.Image = Nothing
        Me.tbPasswordNew.CustomButton.Location = New System.Drawing.Point(308, 1)
        Me.tbPasswordNew.CustomButton.Name = ""
        Me.tbPasswordNew.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPasswordNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPasswordNew.CustomButton.TabIndex = 1
        Me.tbPasswordNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPasswordNew.CustomButton.UseSelectable = True
        Me.tbPasswordNew.CustomButton.Visible = False
        Me.tbPasswordNew.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPasswordNew.Lines = New String(-1) {}
        Me.tbPasswordNew.Location = New System.Drawing.Point(123, 286)
        Me.tbPasswordNew.MaxLength = 32767
        Me.tbPasswordNew.Name = "tbPasswordNew"
        Me.tbPasswordNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPasswordNew.PromptText = "New Password"
        Me.tbPasswordNew.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPasswordNew.SelectedText = ""
        Me.tbPasswordNew.SelectionLength = 0
        Me.tbPasswordNew.SelectionStart = 0
        Me.tbPasswordNew.ShortcutsEnabled = True
        Me.tbPasswordNew.Size = New System.Drawing.Size(330, 23)
        Me.tbPasswordNew.TabIndex = 3
        Me.tbPasswordNew.UseSelectable = True
        Me.tbPasswordNew.UseSystemPasswordChar = True
        Me.tbPasswordNew.WaterMark = "New Password"
        Me.tbPasswordNew.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPasswordNew.WaterMarkFont = New System.Drawing.Font("Myanmar Text", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 288)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel1.TabIndex = 18
        Me.MetroLabel1.Text = "New Password:"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPasswordOld
        '
        Me.lblPasswordOld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblPasswordOld.AutoSize = True
        Me.lblPasswordOld.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordOld.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblPasswordOld.Location = New System.Drawing.Point(19, 243)
        Me.lblPasswordOld.Name = "lblPasswordOld"
        Me.lblPasswordOld.Size = New System.Drawing.Size(105, 19)
        Me.lblPasswordOld.TabIndex = 14
        Me.lblPasswordOld.Text = "Old Password:"
        Me.lblPasswordOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbPasswordNew)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnChangePW)
        Me.Controls.Add(Me.tbPasswordOld)
        Me.Controls.Add(Me.tbUsername)
        Me.Controls.Add(Me.lblPasswordOld)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pbLasermet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        CType(Me.pbLasermet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLasermet As PictureBox
    Friend WithEvents tbPasswordOld As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents btnChangePW As MetroFramework.Controls.MetroButton
    Friend WithEvents tbPasswordNew As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPasswordOld As MetroFramework.Controls.MetroLabel
End Class

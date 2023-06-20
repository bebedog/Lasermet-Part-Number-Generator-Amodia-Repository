<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LasermetPNG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LasermetPNG))
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblSubcategory = New System.Windows.Forms.Label()
        Me.lblGroupName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.btnSendRequest = New MetroFramework.Controls.MetroButton()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblProjectNum = New System.Windows.Forms.Label()
        Me.cbCategories = New MetroFramework.Controls.MetroComboBox()
        Me.cbSubcategories = New MetroFramework.Controls.MetroComboBox()
        Me.cbGroupNames = New MetroFramework.Controls.MetroComboBox()
        Me.cbLocation = New MetroFramework.Controls.MetroComboBox()
        Me.tbProjectNum = New MetroFramework.Controls.MetroTextBox()
        Me.tbDescription = New MetroFramework.Controls.MetroTextBox()
        Me.tbSpecs = New MetroFramework.Controls.MetroTextBox()
        Me.tbComments = New MetroFramework.Controls.MetroTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.requestStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbUKNominalCode = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbUKCC = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMPN = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbSRN = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbWarehouse = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(127, 75)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(75, 16)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Category:"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubcategory
        '
        Me.lblSubcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSubcategory.AutoSize = True
        Me.lblSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubcategory.Location = New System.Drawing.Point(98, 116)
        Me.lblSubcategory.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblSubcategory.Name = "lblSubcategory"
        Me.lblSubcategory.Size = New System.Drawing.Size(104, 17)
        Me.lblSubcategory.TabIndex = 1
        Me.lblSubcategory.Text = "Subcategory:"
        Me.lblSubcategory.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGroupName
        '
        Me.lblGroupName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGroupName.Location = New System.Drawing.Point(99, 156)
        Me.lblGroupName.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(104, 17)
        Me.lblGroupName.TabIndex = 2
        Me.lblGroupName.Text = "Group Name:"
        Me.lblGroupName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(107, 479)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Description:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(84, 580)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Specifications:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblComments
        '
        Me.lblComments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblComments.Location = New System.Drawing.Point(111, 684)
        Me.lblComments.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(87, 17)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Comments:"
        '
        'btnSendRequest
        '
        Me.btnSendRequest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSendRequest.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSendRequest.Location = New System.Drawing.Point(117, 795)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.Size = New System.Drawing.Size(177, 32)
        Me.btnSendRequest.TabIndex = 15
        Me.btnSendRequest.Text = "Send Add Part Request"
        Me.btnSendRequest.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(352, 795)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(177, 32)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Go Back to Dashboard"
        Me.btnBack.UseSelectable = True
        '
        'lblLocation
        '
        Me.lblLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocation.Location = New System.Drawing.Point(128, 196)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(75, 17)
        Me.lblLocation.TabIndex = 13
        Me.lblLocation.Text = "Location:"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProjectNum
        '
        Me.lblProjectNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProjectNum.AutoSize = True
        Me.lblProjectNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProjectNum.Location = New System.Drawing.Point(61, 269)
        Me.lblProjectNum.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.lblProjectNum.Name = "lblProjectNum"
        Me.lblProjectNum.Size = New System.Drawing.Size(142, 17)
        Me.lblProjectNum.TabIndex = 18
        Me.lblProjectNum.Text = "Mfg. / Drawing No:"
        Me.lblProjectNum.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbCategories
        '
        Me.cbCategories.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCategories.FormattingEnabled = True
        Me.cbCategories.ItemHeight = 23
        Me.cbCategories.Location = New System.Drawing.Point(210, 69)
        Me.cbCategories.Name = "cbCategories"
        Me.cbCategories.PromptText = "Required"
        Me.cbCategories.Size = New System.Drawing.Size(351, 29)
        Me.cbCategories.TabIndex = 1
        Me.cbCategories.UseCustomForeColor = True
        Me.cbCategories.UseSelectable = True
        '
        'cbSubcategories
        '
        Me.cbSubcategories.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcategories.FormattingEnabled = True
        Me.cbSubcategories.ItemHeight = 23
        Me.cbSubcategories.Location = New System.Drawing.Point(210, 110)
        Me.cbSubcategories.Name = "cbSubcategories"
        Me.cbSubcategories.PromptText = "Required if Applicable"
        Me.cbSubcategories.Size = New System.Drawing.Size(351, 29)
        Me.cbSubcategories.TabIndex = 2
        Me.cbSubcategories.UseSelectable = True
        '
        'cbGroupNames
        '
        Me.cbGroupNames.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGroupNames.FormattingEnabled = True
        Me.cbGroupNames.ItemHeight = 23
        Me.cbGroupNames.Location = New System.Drawing.Point(210, 150)
        Me.cbGroupNames.Name = "cbGroupNames"
        Me.cbGroupNames.PromptText = "Required if Applicable"
        Me.cbGroupNames.Size = New System.Drawing.Size(351, 29)
        Me.cbGroupNames.TabIndex = 3
        Me.cbGroupNames.UseSelectable = True
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.ItemHeight = 23
        Me.cbLocation.Location = New System.Drawing.Point(210, 190)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.PromptText = "Required"
        Me.cbLocation.Size = New System.Drawing.Size(351, 29)
        Me.cbLocation.TabIndex = 4
        Me.cbLocation.UseSelectable = True
        '
        'tbProjectNum
        '
        Me.tbProjectNum.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbProjectNum.CustomButton.Image = Nothing
        Me.tbProjectNum.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbProjectNum.CustomButton.Name = ""
        Me.tbProjectNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbProjectNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbProjectNum.CustomButton.TabIndex = 1
        Me.tbProjectNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbProjectNum.CustomButton.UseSelectable = True
        Me.tbProjectNum.CustomButton.Visible = False
        Me.tbProjectNum.Lines = New String(-1) {}
        Me.tbProjectNum.Location = New System.Drawing.Point(210, 265)
        Me.tbProjectNum.MaxLength = 32767
        Me.tbProjectNum.Name = "tbProjectNum"
        Me.tbProjectNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbProjectNum.PromptText = "Optional"
        Me.tbProjectNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbProjectNum.SelectedText = ""
        Me.tbProjectNum.SelectionLength = 0
        Me.tbProjectNum.SelectionStart = 0
        Me.tbProjectNum.ShortcutsEnabled = True
        Me.tbProjectNum.Size = New System.Drawing.Size(351, 23)
        Me.tbProjectNum.TabIndex = 6
        Me.tbProjectNum.UseSelectable = True
        Me.tbProjectNum.WaterMark = "Optional"
        Me.tbProjectNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbProjectNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDescription
        '
        Me.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbDescription.CustomButton.Image = Nothing
        Me.tbDescription.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.tbDescription.CustomButton.Name = ""
        Me.tbDescription.CustomButton.Size = New System.Drawing.Size(85, 85)
        Me.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDescription.CustomButton.TabIndex = 1
        Me.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDescription.CustomButton.UseSelectable = True
        Me.tbDescription.CustomButton.Visible = False
        Me.tbDescription.Lines = New String(-1) {}
        Me.tbDescription.Location = New System.Drawing.Point(210, 476)
        Me.tbDescription.MaxLength = 32767
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDescription.PromptText = "Required"
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDescription.SelectedText = ""
        Me.tbDescription.SelectionLength = 0
        Me.tbDescription.SelectionStart = 0
        Me.tbDescription.ShortcutsEnabled = True
        Me.tbDescription.Size = New System.Drawing.Size(351, 90)
        Me.tbDescription.TabIndex = 12
        Me.tbDescription.UseSelectable = True
        Me.tbDescription.WaterMark = "Required"
        Me.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbSpecs
        '
        Me.tbSpecs.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSpecs.CustomButton.Image = Nothing
        Me.tbSpecs.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.tbSpecs.CustomButton.Name = ""
        Me.tbSpecs.CustomButton.Size = New System.Drawing.Size(85, 85)
        Me.tbSpecs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSpecs.CustomButton.TabIndex = 1
        Me.tbSpecs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSpecs.CustomButton.UseSelectable = True
        Me.tbSpecs.CustomButton.Visible = False
        Me.tbSpecs.Lines = New String(-1) {}
        Me.tbSpecs.Location = New System.Drawing.Point(210, 581)
        Me.tbSpecs.MaxLength = 32767
        Me.tbSpecs.Multiline = True
        Me.tbSpecs.Name = "tbSpecs"
        Me.tbSpecs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSpecs.PromptText = "Optional"
        Me.tbSpecs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSpecs.SelectedText = ""
        Me.tbSpecs.SelectionLength = 0
        Me.tbSpecs.SelectionStart = 0
        Me.tbSpecs.ShortcutsEnabled = True
        Me.tbSpecs.Size = New System.Drawing.Size(351, 90)
        Me.tbSpecs.TabIndex = 13
        Me.tbSpecs.UseSelectable = True
        Me.tbSpecs.WaterMark = "Optional"
        Me.tbSpecs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSpecs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbComments
        '
        Me.tbComments.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbComments.CustomButton.Image = Nothing
        Me.tbComments.CustomButton.Location = New System.Drawing.Point(263, 2)
        Me.tbComments.CustomButton.Name = ""
        Me.tbComments.CustomButton.Size = New System.Drawing.Size(85, 85)
        Me.tbComments.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbComments.CustomButton.TabIndex = 1
        Me.tbComments.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbComments.CustomButton.UseSelectable = True
        Me.tbComments.CustomButton.Visible = False
        Me.tbComments.Lines = New String(-1) {}
        Me.tbComments.Location = New System.Drawing.Point(210, 685)
        Me.tbComments.MaxLength = 32767
        Me.tbComments.Multiline = True
        Me.tbComments.Name = "tbComments"
        Me.tbComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbComments.PromptText = "Optional"
        Me.tbComments.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbComments.SelectedText = ""
        Me.tbComments.SelectionLength = 0
        Me.tbComments.SelectionStart = 0
        Me.tbComments.ShortcutsEnabled = True
        Me.tbComments.Size = New System.Drawing.Size(351, 90)
        Me.tbComments.TabIndex = 14
        Me.tbComments.UseSelectable = True
        Me.tbComments.WaterMark = "Optional"
        Me.tbComments.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbComments.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.requestStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 901)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(639, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'requestStatus
        '
        Me.requestStatus.Name = "requestStatus"
        Me.requestStatus.Size = New System.Drawing.Size(0, 17)
        '
        'tbUKNominalCode
        '
        Me.tbUKNominalCode.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbUKNominalCode.CustomButton.Image = Nothing
        Me.tbUKNominalCode.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbUKNominalCode.CustomButton.Name = ""
        Me.tbUKNominalCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUKNominalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUKNominalCode.CustomButton.TabIndex = 1
        Me.tbUKNominalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUKNominalCode.CustomButton.UseSelectable = True
        Me.tbUKNominalCode.CustomButton.Visible = False
        Me.tbUKNominalCode.Lines = New String(-1) {}
        Me.tbUKNominalCode.Location = New System.Drawing.Point(210, 301)
        Me.tbUKNominalCode.MaxLength = 32767
        Me.tbUKNominalCode.Name = "tbUKNominalCode"
        Me.tbUKNominalCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUKNominalCode.PromptText = "Automatically Generated"
        Me.tbUKNominalCode.ReadOnly = True
        Me.tbUKNominalCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUKNominalCode.SelectedText = ""
        Me.tbUKNominalCode.SelectionLength = 0
        Me.tbUKNominalCode.SelectionStart = 0
        Me.tbUKNominalCode.ShortcutsEnabled = True
        Me.tbUKNominalCode.Size = New System.Drawing.Size(351, 23)
        Me.tbUKNominalCode.TabIndex = 7
        Me.tbUKNominalCode.UseSelectable = True
        Me.tbUKNominalCode.WaterMark = "Automatically Generated"
        Me.tbUKNominalCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUKNominalCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(91, 305)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Nominal Code:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbUKCC
        '
        Me.tbUKCC.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbUKCC.CustomButton.Image = Nothing
        Me.tbUKCC.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbUKCC.CustomButton.Name = ""
        Me.tbUKCC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUKCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUKCC.CustomButton.TabIndex = 1
        Me.tbUKCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUKCC.CustomButton.UseSelectable = True
        Me.tbUKCC.CustomButton.Visible = False
        Me.tbUKCC.Lines = New String(-1) {}
        Me.tbUKCC.Location = New System.Drawing.Point(210, 336)
        Me.tbUKCC.MaxLength = 32767
        Me.tbUKCC.Name = "tbUKCC"
        Me.tbUKCC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUKCC.PromptText = "Automatically Generated"
        Me.tbUKCC.ReadOnly = True
        Me.tbUKCC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUKCC.SelectedText = ""
        Me.tbUKCC.SelectionLength = 0
        Me.tbUKCC.SelectionStart = 0
        Me.tbUKCC.ShortcutsEnabled = True
        Me.tbUKCC.Size = New System.Drawing.Size(351, 23)
        Me.tbUKCC.TabIndex = 8
        Me.tbUKCC.UseSelectable = True
        Me.tbUKCC.WaterMark = "Automatically Generated"
        Me.tbUKCC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUKCC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(106, 340)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Cost Center:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSupplier
        '
        Me.tbSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSupplier.CustomButton.Image = Nothing
        Me.tbSupplier.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbSupplier.CustomButton.Name = ""
        Me.tbSupplier.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSupplier.CustomButton.TabIndex = 1
        Me.tbSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSupplier.CustomButton.UseSelectable = True
        Me.tbSupplier.CustomButton.Visible = False
        Me.tbSupplier.Lines = New String(-1) {}
        Me.tbSupplier.Location = New System.Drawing.Point(211, 370)
        Me.tbSupplier.MaxLength = 32767
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSupplier.PromptText = "Optional"
        Me.tbSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSupplier.SelectedText = ""
        Me.tbSupplier.SelectionLength = 0
        Me.tbSupplier.SelectionStart = 0
        Me.tbSupplier.ShortcutsEnabled = True
        Me.tbSupplier.Size = New System.Drawing.Size(351, 23)
        Me.tbSupplier.TabIndex = 9
        Me.tbSupplier.UseSelectable = True
        Me.tbSupplier.WaterMark = "Optional"
        Me.tbSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(130, 374)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Supplier:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbDepartment
        '
        Me.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.ItemHeight = 23
        Me.cbDepartment.Items.AddRange(New Object() {"All", "Electronics", "Mechanical"})
        Me.cbDepartment.Location = New System.Drawing.Point(210, 30)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.PromptText = "Required"
        Me.cbDepartment.Size = New System.Drawing.Size(351, 29)
        Me.cbDepartment.TabIndex = 0
        Me.cbDepartment.UseCustomForeColor = True
        Me.cbDepartment.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Department:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbMPN
        '
        Me.tbMPN.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbMPN.CustomButton.Image = Nothing
        Me.tbMPN.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbMPN.CustomButton.Name = ""
        Me.tbMPN.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbMPN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbMPN.CustomButton.TabIndex = 1
        Me.tbMPN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbMPN.CustomButton.UseSelectable = True
        Me.tbMPN.CustomButton.Visible = False
        Me.tbMPN.Lines = New String(-1) {}
        Me.tbMPN.Location = New System.Drawing.Point(211, 406)
        Me.tbMPN.MaxLength = 32767
        Me.tbMPN.Name = "tbMPN"
        Me.tbMPN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMPN.PromptText = "Optional"
        Me.tbMPN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMPN.SelectedText = ""
        Me.tbMPN.SelectionLength = 0
        Me.tbMPN.SelectionStart = 0
        Me.tbMPN.ShortcutsEnabled = True
        Me.tbMPN.Size = New System.Drawing.Size(351, 23)
        Me.tbMPN.TabIndex = 10
        Me.tbMPN.UseSelectable = True
        Me.tbMPN.WaterMark = "Optional"
        Me.tbMPN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbMPN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(29, 410)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Manufacturer Part No.:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSRN
        '
        Me.tbSRN.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSRN.CustomButton.Image = Nothing
        Me.tbSRN.CustomButton.Location = New System.Drawing.Point(329, 1)
        Me.tbSRN.CustomButton.Name = ""
        Me.tbSRN.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSRN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSRN.CustomButton.TabIndex = 1
        Me.tbSRN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSRN.CustomButton.UseSelectable = True
        Me.tbSRN.CustomButton.Visible = False
        Me.tbSRN.Lines = New String(-1) {}
        Me.tbSRN.Location = New System.Drawing.Point(211, 441)
        Me.tbSRN.MaxLength = 32767
        Me.tbSRN.Name = "tbSRN"
        Me.tbSRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSRN.PromptText = "Optional"
        Me.tbSRN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSRN.SelectedText = ""
        Me.tbSRN.SelectionLength = 0
        Me.tbSRN.SelectionStart = 0
        Me.tbSRN.ShortcutsEnabled = True
        Me.tbSRN.Size = New System.Drawing.Size(351, 23)
        Me.tbSRN.TabIndex = 11
        Me.tbSRN.UseSelectable = True
        Me.tbSRN.WaterMark = "Optional"
        Me.tbSRN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSRN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(65, 445)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Supplier Ref. No.:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbWarehouse
        '
        Me.cbWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbWarehouse.FormattingEnabled = True
        Me.cbWarehouse.ItemHeight = 23
        Me.cbWarehouse.Location = New System.Drawing.Point(210, 228)
        Me.cbWarehouse.Name = "cbWarehouse"
        Me.cbWarehouse.PromptText = "Required"
        Me.cbWarehouse.Size = New System.Drawing.Size(351, 29)
        Me.cbWarehouse.TabIndex = 5
        Me.cbWarehouse.UseSelectable = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(108, 234)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Warehouse:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LasermetPNG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 923)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbWarehouse)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbSRN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbMPN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbDepartment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbUKCC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbUKNominalCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbComments)
        Me.Controls.Add(Me.tbSpecs)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.tbProjectNum)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.cbGroupNames)
        Me.Controls.Add(Me.cbSubcategories)
        Me.Controls.Add(Me.cbCategories)
        Me.Controls.Add(Me.lblProjectNum)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSendRequest)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGroupName)
        Me.Controls.Add(Me.lblSubcategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LasermetPNG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Single Part Request"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents lblSubcategory As Label
    Friend WithEvents lblGroupName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblComments As Label
    Friend WithEvents btnSendRequest As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblProjectNum As Label
    Friend WithEvents cbCategories As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbSubcategories As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbGroupNames As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbLocation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbProjectNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbSpecs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbComments As MetroFramework.Controls.MetroTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents requestStatus As ToolStripStatusLabel
    Friend WithEvents tbUKNominalCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbUKCC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSRN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbMPN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbWarehouse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label9 As Label
End Class

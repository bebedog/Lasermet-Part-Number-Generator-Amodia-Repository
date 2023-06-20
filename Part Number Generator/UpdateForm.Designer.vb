<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbPartNum = New MetroFramework.Controls.MetroTextBox()
        Me.tbDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tbSpecifications = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tbComments = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.tbCurrentStock = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.cbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.cbSubcategory = New MetroFramework.Controls.MetroComboBox()
        Me.cbGroupName = New MetroFramework.Controls.MetroComboBox()
        Me.tbDrawingNo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbUKNominalCode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.tbIssuesCC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.tbSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.cbDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.tbMPN = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.tbSRN = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.cbLocation = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.cbWarehouse = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(57, 40)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(173, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Lasermet Category  No.:"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPartNum
        '
        Me.tbPartNum.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbPartNum.CustomButton.Image = Nothing
        Me.tbPartNum.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbPartNum.CustomButton.Name = ""
        Me.tbPartNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbPartNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbPartNum.CustomButton.TabIndex = 1
        Me.tbPartNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbPartNum.CustomButton.UseSelectable = True
        Me.tbPartNum.CustomButton.Visible = False
        Me.tbPartNum.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbPartNum.Lines = New String(-1) {}
        Me.tbPartNum.Location = New System.Drawing.Point(243, 39)
        Me.tbPartNum.MaxLength = 32767
        Me.tbPartNum.Name = "tbPartNum"
        Me.tbPartNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPartNum.ReadOnly = True
        Me.tbPartNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbPartNum.SelectedText = ""
        Me.tbPartNum.SelectionLength = 0
        Me.tbPartNum.SelectionStart = 0
        Me.tbPartNum.ShortcutsEnabled = True
        Me.tbPartNum.Size = New System.Drawing.Size(328, 23)
        Me.tbPartNum.TabIndex = 0
        Me.tbPartNum.UseSelectable = True
        Me.tbPartNum.UseStyleColors = True
        Me.tbPartNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbPartNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDescription
        '
        Me.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbDescription.CustomButton.Image = Nothing
        Me.tbDescription.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbDescription.CustomButton.Name = ""
        Me.tbDescription.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDescription.CustomButton.TabIndex = 1
        Me.tbDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDescription.CustomButton.UseSelectable = True
        Me.tbDescription.CustomButton.Visible = False
        Me.tbDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDescription.Lines = New String(-1) {}
        Me.tbDescription.Location = New System.Drawing.Point(242, 150)
        Me.tbDescription.MaxLength = 32767
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDescription.SelectedText = ""
        Me.tbDescription.SelectionLength = 0
        Me.tbDescription.SelectionStart = 0
        Me.tbDescription.ShortcutsEnabled = True
        Me.tbDescription.Size = New System.Drawing.Size(328, 23)
        Me.tbDescription.TabIndex = 3
        Me.tbDescription.UseSelectable = True
        Me.tbDescription.UseStyleColors = True
        Me.tbDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(142, 150)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Description:"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSpecifications
        '
        Me.tbSpecifications.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSpecifications.CustomButton.Image = Nothing
        Me.tbSpecifications.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbSpecifications.CustomButton.Name = ""
        Me.tbSpecifications.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSpecifications.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSpecifications.CustomButton.TabIndex = 1
        Me.tbSpecifications.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSpecifications.CustomButton.UseSelectable = True
        Me.tbSpecifications.CustomButton.Visible = False
        Me.tbSpecifications.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSpecifications.Lines = New String(-1) {}
        Me.tbSpecifications.Location = New System.Drawing.Point(242, 182)
        Me.tbSpecifications.MaxLength = 32767
        Me.tbSpecifications.Name = "tbSpecifications"
        Me.tbSpecifications.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSpecifications.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSpecifications.SelectedText = ""
        Me.tbSpecifications.SelectionLength = 0
        Me.tbSpecifications.SelectionStart = 0
        Me.tbSpecifications.ShortcutsEnabled = True
        Me.tbSpecifications.Size = New System.Drawing.Size(328, 23)
        Me.tbSpecifications.TabIndex = 4
        Me.tbSpecifications.UseSelectable = True
        Me.tbSpecifications.UseStyleColors = True
        Me.tbSpecifications.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSpecifications.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(126, 183)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Specifications:"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(155, 399)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Category:"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(132, 436)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Subcategory:"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(132, 477)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Group Name:"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbComments
        '
        Me.tbComments.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbComments.CustomButton.Image = Nothing
        Me.tbComments.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbComments.CustomButton.Name = ""
        Me.tbComments.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbComments.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbComments.CustomButton.TabIndex = 1
        Me.tbComments.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbComments.CustomButton.UseSelectable = True
        Me.tbComments.CustomButton.Visible = False
        Me.tbComments.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbComments.Lines = New String(-1) {}
        Me.tbComments.Location = New System.Drawing.Point(242, 512)
        Me.tbComments.MaxLength = 32767
        Me.tbComments.Name = "tbComments"
        Me.tbComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbComments.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbComments.SelectedText = ""
        Me.tbComments.SelectionLength = 0
        Me.tbComments.SelectionStart = 0
        Me.tbComments.ShortcutsEnabled = True
        Me.tbComments.Size = New System.Drawing.Size(328, 23)
        Me.tbComments.TabIndex = 13
        Me.tbComments.UseSelectable = True
        Me.tbComments.UseStyleColors = True
        Me.tbComments.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbComments.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(147, 513)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Comments:"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbCurrentStock
        '
        Me.tbCurrentStock.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbCurrentStock.CustomButton.Image = Nothing
        Me.tbCurrentStock.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbCurrentStock.CustomButton.Name = ""
        Me.tbCurrentStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbCurrentStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbCurrentStock.CustomButton.TabIndex = 1
        Me.tbCurrentStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbCurrentStock.CustomButton.UseSelectable = True
        Me.tbCurrentStock.CustomButton.Visible = False
        Me.tbCurrentStock.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCurrentStock.Lines = New String(-1) {}
        Me.tbCurrentStock.Location = New System.Drawing.Point(242, 544)
        Me.tbCurrentStock.MaxLength = 32767
        Me.tbCurrentStock.Name = "tbCurrentStock"
        Me.tbCurrentStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCurrentStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCurrentStock.SelectedText = ""
        Me.tbCurrentStock.SelectionLength = 0
        Me.tbCurrentStock.SelectionStart = 0
        Me.tbCurrentStock.ShortcutsEnabled = True
        Me.tbCurrentStock.Size = New System.Drawing.Size(328, 23)
        Me.tbCurrentStock.TabIndex = 14
        Me.tbCurrentStock.UseSelectable = True
        Me.tbCurrentStock.UseStyleColors = True
        Me.tbCurrentStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbCurrentStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(126, 545)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel8.TabIndex = 14
        Me.MetroLabel8.Text = "Current Stock:"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnCancel.Location = New System.Drawing.Point(90, 653)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(184, 32)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.Location = New System.Drawing.Point(347, 653)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(184, 32)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'cbCategory
        '
        Me.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.ItemHeight = 23
        Me.cbCategory.Location = New System.Drawing.Point(242, 395)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(328, 29)
        Me.cbCategory.TabIndex = 10
        Me.cbCategory.UseSelectable = True
        '
        'cbSubcategory
        '
        Me.cbSubcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSubcategory.FormattingEnabled = True
        Me.cbSubcategory.ItemHeight = 23
        Me.cbSubcategory.Location = New System.Drawing.Point(243, 432)
        Me.cbSubcategory.Name = "cbSubcategory"
        Me.cbSubcategory.Size = New System.Drawing.Size(328, 29)
        Me.cbSubcategory.TabIndex = 11
        Me.cbSubcategory.UseSelectable = True
        '
        'cbGroupName
        '
        Me.cbGroupName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbGroupName.FormattingEnabled = True
        Me.cbGroupName.ItemHeight = 23
        Me.cbGroupName.Location = New System.Drawing.Point(243, 472)
        Me.cbGroupName.Name = "cbGroupName"
        Me.cbGroupName.Size = New System.Drawing.Size(328, 29)
        Me.cbGroupName.TabIndex = 12
        Me.cbGroupName.UseSelectable = True
        '
        'tbDrawingNo
        '
        Me.tbDrawingNo.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbDrawingNo.CustomButton.Image = Nothing
        Me.tbDrawingNo.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbDrawingNo.CustomButton.Name = ""
        Me.tbDrawingNo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbDrawingNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDrawingNo.CustomButton.TabIndex = 1
        Me.tbDrawingNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDrawingNo.CustomButton.UseSelectable = True
        Me.tbDrawingNo.CustomButton.Visible = False
        Me.tbDrawingNo.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDrawingNo.Lines = New String(-1) {}
        Me.tbDrawingNo.Location = New System.Drawing.Point(242, 321)
        Me.tbDrawingNo.MaxLength = 32767
        Me.tbDrawingNo.Name = "tbDrawingNo"
        Me.tbDrawingNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDrawingNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDrawingNo.SelectedText = ""
        Me.tbDrawingNo.SelectionLength = 0
        Me.tbDrawingNo.SelectionStart = 0
        Me.tbDrawingNo.ShortcutsEnabled = True
        Me.tbDrawingNo.Size = New System.Drawing.Size(328, 23)
        Me.tbDrawingNo.TabIndex = 8
        Me.tbDrawingNo.UseSelectable = True
        Me.tbDrawingNo.UseStyleColors = True
        Me.tbDrawingNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDrawingNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(138, 322)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel9.TabIndex = 23
        Me.MetroLabel9.Text = "Drawing No:"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 741)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'tbUKNominalCode
        '
        Me.tbUKNominalCode.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbUKNominalCode.CustomButton.Image = Nothing
        Me.tbUKNominalCode.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbUKNominalCode.CustomButton.Name = ""
        Me.tbUKNominalCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbUKNominalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbUKNominalCode.CustomButton.TabIndex = 1
        Me.tbUKNominalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbUKNominalCode.CustomButton.UseSelectable = True
        Me.tbUKNominalCode.CustomButton.Visible = False
        Me.tbUKNominalCode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbUKNominalCode.Lines = New String(-1) {}
        Me.tbUKNominalCode.Location = New System.Drawing.Point(242, 581)
        Me.tbUKNominalCode.MaxLength = 32767
        Me.tbUKNominalCode.Name = "tbUKNominalCode"
        Me.tbUKNominalCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUKNominalCode.ReadOnly = True
        Me.tbUKNominalCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbUKNominalCode.SelectedText = ""
        Me.tbUKNominalCode.SelectionLength = 0
        Me.tbUKNominalCode.SelectionStart = 0
        Me.tbUKNominalCode.ShortcutsEnabled = True
        Me.tbUKNominalCode.Size = New System.Drawing.Size(328, 23)
        Me.tbUKNominalCode.TabIndex = 15
        Me.tbUKNominalCode.UseSelectable = True
        Me.tbUKNominalCode.UseStyleColors = True
        Me.tbUKNominalCode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbUKNominalCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel10.Location = New System.Drawing.Point(99, 582)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel10.TabIndex = 26
        Me.MetroLabel10.Text = "UK Nominal Code:"
        Me.MetroLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbIssuesCC
        '
        Me.tbIssuesCC.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbIssuesCC.CustomButton.Image = Nothing
        Me.tbIssuesCC.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbIssuesCC.CustomButton.Name = ""
        Me.tbIssuesCC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbIssuesCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbIssuesCC.CustomButton.TabIndex = 1
        Me.tbIssuesCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbIssuesCC.CustomButton.UseSelectable = True
        Me.tbIssuesCC.CustomButton.Visible = False
        Me.tbIssuesCC.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbIssuesCC.Lines = New String(-1) {}
        Me.tbIssuesCC.Location = New System.Drawing.Point(242, 616)
        Me.tbIssuesCC.MaxLength = 32767
        Me.tbIssuesCC.Name = "tbIssuesCC"
        Me.tbIssuesCC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbIssuesCC.ReadOnly = True
        Me.tbIssuesCC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbIssuesCC.SelectedText = ""
        Me.tbIssuesCC.SelectionLength = 0
        Me.tbIssuesCC.SelectionStart = 0
        Me.tbIssuesCC.ShortcutsEnabled = True
        Me.tbIssuesCC.Size = New System.Drawing.Size(328, 23)
        Me.tbIssuesCC.TabIndex = 16
        Me.tbIssuesCC.UseSelectable = True
        Me.tbIssuesCC.UseStyleColors = True
        Me.tbIssuesCC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbIssuesCC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel11.Location = New System.Drawing.Point(117, 617)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel11.TabIndex = 28
        Me.MetroLabel11.Text = "UK Cost Center:"
        Me.MetroLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSupplier
        '
        Me.tbSupplier.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSupplier.CustomButton.Image = Nothing
        Me.tbSupplier.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbSupplier.CustomButton.Name = ""
        Me.tbSupplier.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSupplier.CustomButton.TabIndex = 1
        Me.tbSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSupplier.CustomButton.UseSelectable = True
        Me.tbSupplier.CustomButton.Visible = False
        Me.tbSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSupplier.Lines = New String(-1) {}
        Me.tbSupplier.Location = New System.Drawing.Point(242, 252)
        Me.tbSupplier.MaxLength = 32767
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSupplier.SelectedText = ""
        Me.tbSupplier.SelectionLength = 0
        Me.tbSupplier.SelectionStart = 0
        Me.tbSupplier.ShortcutsEnabled = True
        Me.tbSupplier.Size = New System.Drawing.Size(328, 23)
        Me.tbSupplier.TabIndex = 6
        Me.tbSupplier.UseSelectable = True
        Me.tbSupplier.UseStyleColors = True
        Me.tbSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.Location = New System.Drawing.Point(161, 253)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel12.TabIndex = 30
        Me.MetroLabel12.Text = "Supplier:"
        Me.MetroLabel12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbDepartment
        '
        Me.cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.ItemHeight = 23
        Me.cbDepartment.Items.AddRange(New Object() {"All", "Electronics", "Mechanical"})
        Me.cbDepartment.Location = New System.Drawing.Point(242, 355)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(328, 29)
        Me.cbDepartment.TabIndex = 9
        Me.cbDepartment.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel13.Location = New System.Drawing.Point(138, 359)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel13.TabIndex = 32
        Me.MetroLabel13.Text = "Department:"
        Me.MetroLabel13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbMPN
        '
        Me.tbMPN.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbMPN.CustomButton.Image = Nothing
        Me.tbMPN.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbMPN.CustomButton.Name = ""
        Me.tbMPN.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbMPN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbMPN.CustomButton.TabIndex = 1
        Me.tbMPN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbMPN.CustomButton.UseSelectable = True
        Me.tbMPN.CustomButton.Visible = False
        Me.tbMPN.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbMPN.Lines = New String(-1) {}
        Me.tbMPN.Location = New System.Drawing.Point(242, 218)
        Me.tbMPN.MaxLength = 32767
        Me.tbMPN.Name = "tbMPN"
        Me.tbMPN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMPN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMPN.SelectedText = ""
        Me.tbMPN.SelectionLength = 0
        Me.tbMPN.SelectionStart = 0
        Me.tbMPN.ShortcutsEnabled = True
        Me.tbMPN.Size = New System.Drawing.Size(328, 23)
        Me.tbMPN.TabIndex = 5
        Me.tbMPN.UseSelectable = True
        Me.tbMPN.UseStyleColors = True
        Me.tbMPN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbMPN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel14.Location = New System.Drawing.Point(130, 219)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel14.TabIndex = 34
        Me.MetroLabel14.Text = "Mfr. Part No.:"
        Me.MetroLabel14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSRN
        '
        Me.tbSRN.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSRN.CustomButton.Image = Nothing
        Me.tbSRN.CustomButton.Location = New System.Drawing.Point(306, 1)
        Me.tbSRN.CustomButton.Name = ""
        Me.tbSRN.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSRN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSRN.CustomButton.TabIndex = 1
        Me.tbSRN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSRN.CustomButton.UseSelectable = True
        Me.tbSRN.CustomButton.Visible = False
        Me.tbSRN.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSRN.Lines = New String(-1) {}
        Me.tbSRN.Location = New System.Drawing.Point(242, 288)
        Me.tbSRN.MaxLength = 32767
        Me.tbSRN.Name = "tbSRN"
        Me.tbSRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSRN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSRN.SelectedText = ""
        Me.tbSRN.SelectionLength = 0
        Me.tbSRN.SelectionStart = 0
        Me.tbSRN.ShortcutsEnabled = True
        Me.tbSRN.Size = New System.Drawing.Size(328, 23)
        Me.tbSRN.TabIndex = 7
        Me.tbSRN.UseSelectable = True
        Me.tbSRN.UseStyleColors = True
        Me.tbSRN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSRN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel15.Location = New System.Drawing.Point(106, 289)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel15.TabIndex = 36
        Me.MetroLabel15.Text = "Supplier Ref. No.:"
        Me.MetroLabel15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbLocation
        '
        Me.cbLocation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbLocation.FormattingEnabled = True
        Me.cbLocation.ItemHeight = 23
        Me.cbLocation.Location = New System.Drawing.Point(242, 72)
        Me.cbLocation.Name = "cbLocation"
        Me.cbLocation.Size = New System.Drawing.Size(328, 29)
        Me.cbLocation.TabIndex = 1
        Me.cbLocation.UseSelectable = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel16.Location = New System.Drawing.Point(160, 76)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel16.TabIndex = 38
        Me.MetroLabel16.Text = "Location:"
        Me.MetroLabel16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbWarehouse
        '
        Me.cbWarehouse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbWarehouse.FormattingEnabled = True
        Me.cbWarehouse.ItemHeight = 23
        Me.cbWarehouse.Location = New System.Drawing.Point(242, 112)
        Me.cbWarehouse.Name = "cbWarehouse"
        Me.cbWarehouse.Size = New System.Drawing.Size(328, 29)
        Me.cbWarehouse.TabIndex = 2
        Me.cbWarehouse.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel17.Location = New System.Drawing.Point(143, 116)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel17.TabIndex = 40
        Me.MetroLabel17.Text = "Warehouse:"
        Me.MetroLabel17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 763)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbWarehouse)
        Me.Controls.Add(Me.MetroLabel17)
        Me.Controls.Add(Me.cbLocation)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.tbSRN)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.tbMPN)
        Me.Controls.Add(Me.MetroLabel14)
        Me.Controls.Add(Me.cbDepartment)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.tbSupplier)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.tbIssuesCC)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.tbUKNominalCode)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbDrawingNo)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.cbGroupName)
        Me.Controls.Add(Me.cbSubcategory)
        Me.Controls.Add(Me.cbCategory)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tbCurrentStock)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.tbComments)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.tbSpecifications)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.tbPartNum)
        Me.Controls.Add(Me.MetroLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbPartNum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSpecifications As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbComments As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbCurrentStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents cbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbSubcategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbGroupName As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbDrawingNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tbUKNominalCode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbIssuesCC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbMPN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSRN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbLocation As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbWarehouse As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
End Class

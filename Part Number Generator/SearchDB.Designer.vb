<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchDB))
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDashboardStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblKeyword = New MetroFramework.Controls.MetroLabel()
        Me.tbSearchKeyword = New MetroFramework.Controls.MetroTextBox()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.gbFilters = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New MetroFramework.Controls.MetroLabel()
        Me.tbSearchAll = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterbyDept = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterByMfgOrDwg = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterByPartNo = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterbySpecs = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterbyDescription = New MetroFramework.Controls.MetroTextBox()
        Me.tbFilterbyGroupName = New MetroFramework.Controls.MetroTextBox()
        Me.tbSubcategoryFilter = New MetroFramework.Controls.MetroTextBox()
        Me.tbCategoryFilter = New MetroFramework.Controls.MetroTextBox()
        Me.chbFilterByDept = New MetroFramework.Controls.MetroCheckBox()
        Me.chbFilterByMFGorDWG = New MetroFramework.Controls.MetroCheckBox()
        Me.chbPartNo = New MetroFramework.Controls.MetroCheckBox()
        Me.chbSpecs = New MetroFramework.Controls.MetroCheckBox()
        Me.chbDescription = New MetroFramework.Controls.MetroCheckBox()
        Me.chbGroupName = New MetroFramework.Controls.MetroCheckBox()
        Me.chbSubcategory = New MetroFramework.Controls.MetroCheckBox()
        Me.chbCategory = New MetroFramework.Controls.MetroCheckBox()
        Me.panelSearchFilters = New MetroFramework.Controls.MetroPanel()
        Me.panelMasterListOptions = New System.Windows.Forms.Panel()
        Me.btnExport = New MetroFramework.Controls.MetroButton()
        Me.btnBack2 = New MetroFramework.Controls.MetroButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.gbFilters.SuspendLayout()
        Me.panelSearchFilters.SuspendLayout()
        Me.panelMasterListOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.AllowUserToAddRows = False
        Me.dgvSearchResults.AllowUserToDeleteRows = False
        Me.dgvSearchResults.AllowUserToResizeColumns = False
        Me.dgvSearchResults.AllowUserToResizeRows = False
        Me.dgvSearchResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchResults.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchResults.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSearchResults.Location = New System.Drawing.Point(8, 232)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.Size = New System.Drawing.Size(768, 258)
        Me.dgvSearchResults.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDashboardStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDashboardStatus
        '
        Me.lblDashboardStatus.Name = "lblDashboardStatus"
        Me.lblDashboardStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'lblKeyword
        '
        Me.lblKeyword.AutoSize = True
        Me.lblKeyword.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblKeyword.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblKeyword.Location = New System.Drawing.Point(8, 8)
        Me.lblKeyword.Name = "lblKeyword"
        Me.lblKeyword.Size = New System.Drawing.Size(92, 25)
        Me.lblKeyword.TabIndex = 2
        Me.lblKeyword.Text = "Keyword:"
        Me.lblKeyword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbSearchKeyword
        '
        Me.tbSearchKeyword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbSearchKeyword.CustomButton.Image = Nothing
        Me.tbSearchKeyword.CustomButton.Location = New System.Drawing.Point(650, 1)
        Me.tbSearchKeyword.CustomButton.Name = ""
        Me.tbSearchKeyword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSearchKeyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSearchKeyword.CustomButton.TabIndex = 1
        Me.tbSearchKeyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSearchKeyword.CustomButton.UseSelectable = True
        Me.tbSearchKeyword.CustomButton.Visible = False
        Me.tbSearchKeyword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSearchKeyword.Lines = New String(-1) {}
        Me.tbSearchKeyword.Location = New System.Drawing.Point(104, 10)
        Me.tbSearchKeyword.MaxLength = 32767
        Me.tbSearchKeyword.Name = "tbSearchKeyword"
        Me.tbSearchKeyword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchKeyword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSearchKeyword.SelectedText = ""
        Me.tbSearchKeyword.SelectionLength = 0
        Me.tbSearchKeyword.SelectionStart = 0
        Me.tbSearchKeyword.ShortcutsEnabled = True
        Me.tbSearchKeyword.Size = New System.Drawing.Size(672, 23)
        Me.tbSearchKeyword.TabIndex = 3
        Me.tbSearchKeyword.UseSelectable = True
        Me.tbSearchKeyword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSearchKeyword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(232, 499)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(288, 32)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Go Back to Dashboard"
        Me.btnBack.UseSelectable = True
        '
        'gbFilters
        '
        Me.gbFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFilters.Controls.Add(Me.lblSearch)
        Me.gbFilters.Controls.Add(Me.tbSearchAll)
        Me.gbFilters.Controls.Add(Me.tbFilterbyDept)
        Me.gbFilters.Controls.Add(Me.tbFilterByMfgOrDwg)
        Me.gbFilters.Controls.Add(Me.tbFilterByPartNo)
        Me.gbFilters.Controls.Add(Me.tbFilterbySpecs)
        Me.gbFilters.Controls.Add(Me.tbFilterbyDescription)
        Me.gbFilters.Controls.Add(Me.tbFilterbyGroupName)
        Me.gbFilters.Controls.Add(Me.tbSubcategoryFilter)
        Me.gbFilters.Controls.Add(Me.tbCategoryFilter)
        Me.gbFilters.Controls.Add(Me.chbFilterByDept)
        Me.gbFilters.Controls.Add(Me.chbFilterByMFGorDWG)
        Me.gbFilters.Controls.Add(Me.chbPartNo)
        Me.gbFilters.Controls.Add(Me.chbSpecs)
        Me.gbFilters.Controls.Add(Me.chbDescription)
        Me.gbFilters.Controls.Add(Me.chbGroupName)
        Me.gbFilters.Controls.Add(Me.chbSubcategory)
        Me.gbFilters.Controls.Add(Me.chbCategory)
        Me.gbFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFilters.Location = New System.Drawing.Point(8, 8)
        Me.gbFilters.Name = "gbFilters"
        Me.gbFilters.Size = New System.Drawing.Size(768, 208)
        Me.gbFilters.TabIndex = 2
        Me.gbFilters.TabStop = False
        Me.gbFilters.Text = "Search Filters:"
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearch.AutoSize = True
        Me.lblSearch.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSearch.Location = New System.Drawing.Point(15, 170)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(73, 19)
        Me.lblSearch.TabIndex = 20
        Me.lblSearch.Text = "Keyword:"
        '
        'tbSearchAll
        '
        Me.tbSearchAll.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSearchAll.CustomButton.Image = Nothing
        Me.tbSearchAll.CustomButton.Location = New System.Drawing.Point(635, 1)
        Me.tbSearchAll.CustomButton.Name = ""
        Me.tbSearchAll.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSearchAll.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSearchAll.CustomButton.TabIndex = 1
        Me.tbSearchAll.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSearchAll.CustomButton.UseSelectable = True
        Me.tbSearchAll.CustomButton.Visible = False
        Me.tbSearchAll.Lines = New String(-1) {}
        Me.tbSearchAll.Location = New System.Drawing.Point(103, 168)
        Me.tbSearchAll.MaxLength = 32767
        Me.tbSearchAll.Name = "tbSearchAll"
        Me.tbSearchAll.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearchAll.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSearchAll.SelectedText = ""
        Me.tbSearchAll.SelectionLength = 0
        Me.tbSearchAll.SelectionStart = 0
        Me.tbSearchAll.ShortcutsEnabled = True
        Me.tbSearchAll.Size = New System.Drawing.Size(657, 23)
        Me.tbSearchAll.TabIndex = 19
        Me.tbSearchAll.UseSelectable = True
        Me.tbSearchAll.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSearchAll.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterbyDept
        '
        Me.tbFilterbyDept.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterbyDept.CustomButton.Image = Nothing
        Me.tbFilterbyDept.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterbyDept.CustomButton.Name = ""
        Me.tbFilterbyDept.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterbyDept.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterbyDept.CustomButton.TabIndex = 1
        Me.tbFilterbyDept.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterbyDept.CustomButton.UseSelectable = True
        Me.tbFilterbyDept.CustomButton.Visible = False
        Me.tbFilterbyDept.Enabled = False
        Me.tbFilterbyDept.Lines = New String(-1) {}
        Me.tbFilterbyDept.Location = New System.Drawing.Point(505, 127)
        Me.tbFilterbyDept.MaxLength = 32767
        Me.tbFilterbyDept.Name = "tbFilterbyDept"
        Me.tbFilterbyDept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterbyDept.PromptText = "Filter by Department"
        Me.tbFilterbyDept.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterbyDept.SelectedText = ""
        Me.tbFilterbyDept.SelectionLength = 0
        Me.tbFilterbyDept.SelectionStart = 0
        Me.tbFilterbyDept.ShortcutsEnabled = True
        Me.tbFilterbyDept.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterbyDept.TabIndex = 15
        Me.tbFilterbyDept.UseSelectable = True
        Me.tbFilterbyDept.WaterMark = "Filter by Department"
        Me.tbFilterbyDept.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterbyDept.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterByMfgOrDwg
        '
        Me.tbFilterByMfgOrDwg.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterByMfgOrDwg.CustomButton.Image = Nothing
        Me.tbFilterByMfgOrDwg.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterByMfgOrDwg.CustomButton.Name = ""
        Me.tbFilterByMfgOrDwg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterByMfgOrDwg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterByMfgOrDwg.CustomButton.TabIndex = 1
        Me.tbFilterByMfgOrDwg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterByMfgOrDwg.CustomButton.UseSelectable = True
        Me.tbFilterByMfgOrDwg.CustomButton.Visible = False
        Me.tbFilterByMfgOrDwg.Enabled = False
        Me.tbFilterByMfgOrDwg.Lines = New String(-1) {}
        Me.tbFilterByMfgOrDwg.Location = New System.Drawing.Point(505, 94)
        Me.tbFilterByMfgOrDwg.MaxLength = 32767
        Me.tbFilterByMfgOrDwg.Name = "tbFilterByMfgOrDwg"
        Me.tbFilterByMfgOrDwg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterByMfgOrDwg.PromptText = "Filter by Mfg. / Drawing No."
        Me.tbFilterByMfgOrDwg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterByMfgOrDwg.SelectedText = ""
        Me.tbFilterByMfgOrDwg.SelectionLength = 0
        Me.tbFilterByMfgOrDwg.SelectionStart = 0
        Me.tbFilterByMfgOrDwg.ShortcutsEnabled = True
        Me.tbFilterByMfgOrDwg.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterByMfgOrDwg.TabIndex = 14
        Me.tbFilterByMfgOrDwg.UseSelectable = True
        Me.tbFilterByMfgOrDwg.WaterMark = "Filter by Mfg. / Drawing No."
        Me.tbFilterByMfgOrDwg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterByMfgOrDwg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterByPartNo
        '
        Me.tbFilterByPartNo.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterByPartNo.CustomButton.Image = Nothing
        Me.tbFilterByPartNo.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterByPartNo.CustomButton.Name = ""
        Me.tbFilterByPartNo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterByPartNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterByPartNo.CustomButton.TabIndex = 1
        Me.tbFilterByPartNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterByPartNo.CustomButton.UseSelectable = True
        Me.tbFilterByPartNo.CustomButton.Visible = False
        Me.tbFilterByPartNo.Enabled = False
        Me.tbFilterByPartNo.Lines = New String(-1) {}
        Me.tbFilterByPartNo.Location = New System.Drawing.Point(505, 62)
        Me.tbFilterByPartNo.MaxLength = 32767
        Me.tbFilterByPartNo.Name = "tbFilterByPartNo"
        Me.tbFilterByPartNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterByPartNo.PromptText = "Filter by  Part No."
        Me.tbFilterByPartNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterByPartNo.SelectedText = ""
        Me.tbFilterByPartNo.SelectionLength = 0
        Me.tbFilterByPartNo.SelectionStart = 0
        Me.tbFilterByPartNo.ShortcutsEnabled = True
        Me.tbFilterByPartNo.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterByPartNo.TabIndex = 13
        Me.tbFilterByPartNo.UseSelectable = True
        Me.tbFilterByPartNo.WaterMark = "Filter by  Part No."
        Me.tbFilterByPartNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterByPartNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterbySpecs
        '
        Me.tbFilterbySpecs.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterbySpecs.CustomButton.Image = Nothing
        Me.tbFilterbySpecs.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterbySpecs.CustomButton.Name = ""
        Me.tbFilterbySpecs.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterbySpecs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterbySpecs.CustomButton.TabIndex = 1
        Me.tbFilterbySpecs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterbySpecs.CustomButton.UseSelectable = True
        Me.tbFilterbySpecs.CustomButton.Visible = False
        Me.tbFilterbySpecs.Enabled = False
        Me.tbFilterbySpecs.Lines = New String(-1) {}
        Me.tbFilterbySpecs.Location = New System.Drawing.Point(504, 28)
        Me.tbFilterbySpecs.MaxLength = 32767
        Me.tbFilterbySpecs.Name = "tbFilterbySpecs"
        Me.tbFilterbySpecs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterbySpecs.PromptText = "Filter by Specifications"
        Me.tbFilterbySpecs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterbySpecs.SelectedText = ""
        Me.tbFilterbySpecs.SelectionLength = 0
        Me.tbFilterbySpecs.SelectionStart = 0
        Me.tbFilterbySpecs.ShortcutsEnabled = True
        Me.tbFilterbySpecs.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterbySpecs.TabIndex = 12
        Me.tbFilterbySpecs.UseSelectable = True
        Me.tbFilterbySpecs.WaterMark = "Filter by Specifications"
        Me.tbFilterbySpecs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterbySpecs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterbyDescription
        '
        Me.tbFilterbyDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterbyDescription.CustomButton.Image = Nothing
        Me.tbFilterbyDescription.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterbyDescription.CustomButton.Name = ""
        Me.tbFilterbyDescription.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterbyDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterbyDescription.CustomButton.TabIndex = 1
        Me.tbFilterbyDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterbyDescription.CustomButton.UseSelectable = True
        Me.tbFilterbyDescription.CustomButton.Visible = False
        Me.tbFilterbyDescription.Enabled = False
        Me.tbFilterbyDescription.Lines = New String(-1) {}
        Me.tbFilterbyDescription.Location = New System.Drawing.Point(113, 125)
        Me.tbFilterbyDescription.MaxLength = 32767
        Me.tbFilterbyDescription.Name = "tbFilterbyDescription"
        Me.tbFilterbyDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterbyDescription.PromptText = "Filter by Description"
        Me.tbFilterbyDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterbyDescription.SelectedText = ""
        Me.tbFilterbyDescription.SelectionLength = 0
        Me.tbFilterbyDescription.SelectionStart = 0
        Me.tbFilterbyDescription.ShortcutsEnabled = True
        Me.tbFilterbyDescription.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterbyDescription.TabIndex = 11
        Me.tbFilterbyDescription.UseSelectable = True
        Me.tbFilterbyDescription.WaterMark = "Filter by Description"
        Me.tbFilterbyDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterbyDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbFilterbyGroupName
        '
        Me.tbFilterbyGroupName.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbFilterbyGroupName.CustomButton.Image = Nothing
        Me.tbFilterbyGroupName.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbFilterbyGroupName.CustomButton.Name = ""
        Me.tbFilterbyGroupName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbFilterbyGroupName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbFilterbyGroupName.CustomButton.TabIndex = 1
        Me.tbFilterbyGroupName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbFilterbyGroupName.CustomButton.UseSelectable = True
        Me.tbFilterbyGroupName.CustomButton.Visible = False
        Me.tbFilterbyGroupName.Enabled = False
        Me.tbFilterbyGroupName.Lines = New String(-1) {}
        Me.tbFilterbyGroupName.Location = New System.Drawing.Point(113, 93)
        Me.tbFilterbyGroupName.MaxLength = 32767
        Me.tbFilterbyGroupName.Name = "tbFilterbyGroupName"
        Me.tbFilterbyGroupName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFilterbyGroupName.PromptText = "Filter by Group Name"
        Me.tbFilterbyGroupName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbFilterbyGroupName.SelectedText = ""
        Me.tbFilterbyGroupName.SelectionLength = 0
        Me.tbFilterbyGroupName.SelectionStart = 0
        Me.tbFilterbyGroupName.ShortcutsEnabled = True
        Me.tbFilterbyGroupName.Size = New System.Drawing.Size(256, 23)
        Me.tbFilterbyGroupName.TabIndex = 10
        Me.tbFilterbyGroupName.UseSelectable = True
        Me.tbFilterbyGroupName.WaterMark = "Filter by Group Name"
        Me.tbFilterbyGroupName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbFilterbyGroupName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbSubcategoryFilter
        '
        Me.tbSubcategoryFilter.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbSubcategoryFilter.CustomButton.Image = Nothing
        Me.tbSubcategoryFilter.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbSubcategoryFilter.CustomButton.Name = ""
        Me.tbSubcategoryFilter.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbSubcategoryFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSubcategoryFilter.CustomButton.TabIndex = 1
        Me.tbSubcategoryFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSubcategoryFilter.CustomButton.UseSelectable = True
        Me.tbSubcategoryFilter.CustomButton.Visible = False
        Me.tbSubcategoryFilter.Enabled = False
        Me.tbSubcategoryFilter.Lines = New String(-1) {}
        Me.tbSubcategoryFilter.Location = New System.Drawing.Point(113, 60)
        Me.tbSubcategoryFilter.MaxLength = 32767
        Me.tbSubcategoryFilter.Name = "tbSubcategoryFilter"
        Me.tbSubcategoryFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSubcategoryFilter.PromptText = "Filter by Subcategory"
        Me.tbSubcategoryFilter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSubcategoryFilter.SelectedText = ""
        Me.tbSubcategoryFilter.SelectionLength = 0
        Me.tbSubcategoryFilter.SelectionStart = 0
        Me.tbSubcategoryFilter.ShortcutsEnabled = True
        Me.tbSubcategoryFilter.Size = New System.Drawing.Size(256, 23)
        Me.tbSubcategoryFilter.TabIndex = 9
        Me.tbSubcategoryFilter.UseSelectable = True
        Me.tbSubcategoryFilter.WaterMark = "Filter by Subcategory"
        Me.tbSubcategoryFilter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSubcategoryFilter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbCategoryFilter
        '
        Me.tbCategoryFilter.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.tbCategoryFilter.CustomButton.Image = Nothing
        Me.tbCategoryFilter.CustomButton.Location = New System.Drawing.Point(234, 1)
        Me.tbCategoryFilter.CustomButton.Name = ""
        Me.tbCategoryFilter.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbCategoryFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbCategoryFilter.CustomButton.TabIndex = 1
        Me.tbCategoryFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbCategoryFilter.CustomButton.UseSelectable = True
        Me.tbCategoryFilter.CustomButton.Visible = False
        Me.tbCategoryFilter.Enabled = False
        Me.tbCategoryFilter.Lines = New String(-1) {}
        Me.tbCategoryFilter.Location = New System.Drawing.Point(113, 28)
        Me.tbCategoryFilter.MaxLength = 32767
        Me.tbCategoryFilter.Name = "tbCategoryFilter"
        Me.tbCategoryFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCategoryFilter.PromptText = "Filter by Category"
        Me.tbCategoryFilter.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCategoryFilter.SelectedText = ""
        Me.tbCategoryFilter.SelectionLength = 0
        Me.tbCategoryFilter.SelectionStart = 0
        Me.tbCategoryFilter.ShortcutsEnabled = True
        Me.tbCategoryFilter.Size = New System.Drawing.Size(256, 23)
        Me.tbCategoryFilter.TabIndex = 8
        Me.tbCategoryFilter.UseSelectable = True
        Me.tbCategoryFilter.WaterMark = "Filter by Category"
        Me.tbCategoryFilter.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbCategoryFilter.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chbFilterByDept
        '
        Me.chbFilterByDept.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbFilterByDept.AutoSize = True
        Me.chbFilterByDept.Location = New System.Drawing.Point(377, 128)
        Me.chbFilterByDept.Name = "chbFilterByDept"
        Me.chbFilterByDept.Size = New System.Drawing.Size(89, 15)
        Me.chbFilterByDept.TabIndex = 7
        Me.chbFilterByDept.Text = "Department:"
        Me.chbFilterByDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbFilterByDept.UseSelectable = True
        '
        'chbFilterByMFGorDWG
        '
        Me.chbFilterByMFGorDWG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbFilterByMFGorDWG.AutoSize = True
        Me.chbFilterByMFGorDWG.Location = New System.Drawing.Point(377, 96)
        Me.chbFilterByMFGorDWG.Name = "chbFilterByMFGorDWG"
        Me.chbFilterByMFGorDWG.Size = New System.Drawing.Size(125, 15)
        Me.chbFilterByMFGorDWG.TabIndex = 6
        Me.chbFilterByMFGorDWG.Text = "Mfg. / Drawing No:"
        Me.chbFilterByMFGorDWG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbFilterByMFGorDWG.UseSelectable = True
        '
        'chbPartNo
        '
        Me.chbPartNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbPartNo.AutoSize = True
        Me.chbPartNo.Location = New System.Drawing.Point(377, 64)
        Me.chbPartNo.Name = "chbPartNo"
        Me.chbPartNo.Size = New System.Drawing.Size(66, 15)
        Me.chbPartNo.TabIndex = 5
        Me.chbPartNo.Text = "Part No:"
        Me.chbPartNo.UseSelectable = True
        '
        'chbSpecs
        '
        Me.chbSpecs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbSpecs.AutoSize = True
        Me.chbSpecs.Location = New System.Drawing.Point(377, 32)
        Me.chbSpecs.Name = "chbSpecs"
        Me.chbSpecs.Size = New System.Drawing.Size(96, 15)
        Me.chbSpecs.TabIndex = 4
        Me.chbSpecs.Text = "Specifications"
        Me.chbSpecs.UseSelectable = True
        '
        'chbDescription
        '
        Me.chbDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbDescription.AutoSize = True
        Me.chbDescription.Location = New System.Drawing.Point(13, 128)
        Me.chbDescription.Name = "chbDescription"
        Me.chbDescription.Size = New System.Drawing.Size(83, 15)
        Me.chbDescription.TabIndex = 3
        Me.chbDescription.Text = "Description"
        Me.chbDescription.UseSelectable = True
        '
        'chbGroupName
        '
        Me.chbGroupName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbGroupName.AutoSize = True
        Me.chbGroupName.Location = New System.Drawing.Point(13, 96)
        Me.chbGroupName.Name = "chbGroupName"
        Me.chbGroupName.Size = New System.Drawing.Size(91, 15)
        Me.chbGroupName.TabIndex = 2
        Me.chbGroupName.Text = "Group Name"
        Me.chbGroupName.UseSelectable = True
        '
        'chbSubcategory
        '
        Me.chbSubcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbSubcategory.AutoSize = True
        Me.chbSubcategory.Location = New System.Drawing.Point(13, 64)
        Me.chbSubcategory.Name = "chbSubcategory"
        Me.chbSubcategory.Size = New System.Drawing.Size(89, 15)
        Me.chbSubcategory.TabIndex = 1
        Me.chbSubcategory.Text = "Subcategory"
        Me.chbSubcategory.UseSelectable = True
        '
        'chbCategory
        '
        Me.chbCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbCategory.AutoSize = True
        Me.chbCategory.Location = New System.Drawing.Point(13, 32)
        Me.chbCategory.Name = "chbCategory"
        Me.chbCategory.Size = New System.Drawing.Size(71, 15)
        Me.chbCategory.TabIndex = 0
        Me.chbCategory.Text = "Category"
        Me.chbCategory.UseSelectable = True
        '
        'panelSearchFilters
        '
        Me.panelSearchFilters.Controls.Add(Me.gbFilters)
        Me.panelSearchFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSearchFilters.HorizontalScrollbarBarColor = True
        Me.panelSearchFilters.HorizontalScrollbarHighlightOnWheel = False
        Me.panelSearchFilters.HorizontalScrollbarSize = 10
        Me.panelSearchFilters.Location = New System.Drawing.Point(0, 0)
        Me.panelSearchFilters.Name = "panelSearchFilters"
        Me.panelSearchFilters.Size = New System.Drawing.Size(784, 224)
        Me.panelSearchFilters.TabIndex = 18
        Me.panelSearchFilters.VerticalScrollbarBarColor = True
        Me.panelSearchFilters.VerticalScrollbarHighlightOnWheel = False
        Me.panelSearchFilters.VerticalScrollbarSize = 10
        '
        'panelMasterListOptions
        '
        Me.panelMasterListOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelMasterListOptions.Controls.Add(Me.btnExport)
        Me.panelMasterListOptions.Controls.Add(Me.btnBack2)
        Me.panelMasterListOptions.Location = New System.Drawing.Point(0, 491)
        Me.panelMasterListOptions.Name = "panelMasterListOptions"
        Me.panelMasterListOptions.Size = New System.Drawing.Size(784, 48)
        Me.panelMasterListOptions.TabIndex = 19
        '
        'btnExport
        '
        Me.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExport.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnExport.Location = New System.Drawing.Point(392, 9)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(288, 32)
        Me.btnExport.TabIndex = 21
        Me.btnExport.Text = "Export to Master List"
        Me.btnExport.UseSelectable = True
        '
        'btnBack2
        '
        Me.btnBack2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack2.Location = New System.Drawing.Point(96, 9)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(288, 32)
        Me.btnBack2.TabIndex = 20
        Me.btnBack2.Text = "Go Back to Dashboard"
        Me.btnBack2.UseSelectable = True
        '
        'SearchDB
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMasterListOptions)
        Me.Controls.Add(Me.panelSearchFilters)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.tbSearchKeyword)
        Me.Controls.Add(Me.lblKeyword)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Inventory DB"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbFilters.ResumeLayout(False)
        Me.gbFilters.PerformLayout()
        Me.panelSearchFilters.ResumeLayout(False)
        Me.panelMasterListOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSearchResults As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblDashboardStatus As ToolStripStatusLabel
    Friend WithEvents lblKeyword As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSearchKeyword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents gbFilters As GroupBox
    Friend WithEvents chbSpecs As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbDescription As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbGroupName As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbSubcategory As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbCategory As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents panelSearchFilters As MetroFramework.Controls.MetroPanel
    Friend WithEvents tbFilterbyDept As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbFilterByMfgOrDwg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbFilterByPartNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbFilterbySpecs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbFilterbyDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbFilterbyGroupName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbSubcategoryFilter As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbCategoryFilter As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chbFilterByDept As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbFilterByMFGorDWG As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chbPartNo As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblSearch As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbSearchAll As MetroFramework.Controls.MetroTextBox
    Friend WithEvents panelMasterListOptions As Panel
    Friend WithEvents btnExport As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBack2 As MetroFramework.Controls.MetroButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class

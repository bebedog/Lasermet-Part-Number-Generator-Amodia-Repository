<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryAdminDashboard
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
        Dim btnLogout As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryAdminDashboard))
        Me.btnSearchInventory = New MetroFramework.Controls.MetroButton()
        Me.btnSearchParts = New MetroFramework.Controls.MetroButton()
        Me.btnAddPart = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        btnLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New System.Drawing.Size(180, 22)
        btnLogout.Text = "Log Out"
        AddHandler btnLogout.Click, AddressOf Me.btnLogout_Click
        '
        'btnSearchInventory
        '
        Me.btnSearchInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchInventory.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearchInventory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchInventory.Location = New System.Drawing.Point(48, 264)
        Me.btnSearchInventory.Name = "btnSearchInventory"
        Me.btnSearchInventory.Size = New System.Drawing.Size(287, 48)
        Me.btnSearchInventory.TabIndex = 2
        Me.btnSearchInventory.Text = "Search Master List"
        Me.btnSearchInventory.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSearchInventory.UseSelectable = True
        '
        'btnSearchParts
        '
        Me.btnSearchParts.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchParts.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearchParts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchParts.Location = New System.Drawing.Point(48, 172)
        Me.btnSearchParts.Name = "btnSearchParts"
        Me.btnSearchParts.Size = New System.Drawing.Size(287, 48)
        Me.btnSearchParts.TabIndex = 1
        Me.btnSearchParts.Text = "New Parts Requests"
        Me.btnSearchParts.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSearchParts.UseSelectable = True
        '
        'btnAddPart
        '
        Me.btnAddPart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPart.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAddPart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddPart.Location = New System.Drawing.Point(48, 80)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(287, 48)
        Me.btnAddPart.TabIndex = 0
        Me.btnAddPart.Text = "Add New Part to Database"
        Me.btnAddPart.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAddPart.UseSelectable = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {btnLogout, Me.btnExit})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 22)
        Me.btnExit.Text = "Exit"
        '
        'InventoryAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSearchInventory)
        Me.Controls.Add(Me.btnSearchParts)
        Me.Controls.Add(Me.btnAddPart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "InventoryAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Admin Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchInventory As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearchParts As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddPart As MetroFramework.Controls.MetroButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnExit As ToolStripMenuItem
End Class

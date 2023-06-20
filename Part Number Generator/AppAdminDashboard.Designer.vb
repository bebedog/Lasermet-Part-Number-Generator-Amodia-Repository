<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppAdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppAdminDashboard))
        Me.btnAddPart = New MetroFramework.Controls.MetroButton()
        Me.btnSearchParts = New MetroFramework.Controls.MetroButton()
        Me.btnSearchInventory = New MetroFramework.Controls.MetroButton()
        Me.btnAccountsRequests = New MetroFramework.Controls.MetroButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddPart
        '
        Me.btnAddPart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPart.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAddPart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddPart.Location = New System.Drawing.Point(46, 48)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(293, 54)
        Me.btnAddPart.TabIndex = 0
        Me.btnAddPart.Text = "Add New Part to Database"
        Me.btnAddPart.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAddPart.UseSelectable = True
        '
        'btnSearchParts
        '
        Me.btnSearchParts.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchParts.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearchParts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchParts.Location = New System.Drawing.Point(46, 136)
        Me.btnSearchParts.Name = "btnSearchParts"
        Me.btnSearchParts.Size = New System.Drawing.Size(293, 54)
        Me.btnSearchParts.TabIndex = 1
        Me.btnSearchParts.Text = "New Parts Requests"
        Me.btnSearchParts.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSearchParts.UseSelectable = True
        '
        'btnSearchInventory
        '
        Me.btnSearchInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchInventory.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnSearchInventory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearchInventory.Location = New System.Drawing.Point(46, 304)
        Me.btnSearchInventory.Name = "btnSearchInventory"
        Me.btnSearchInventory.Size = New System.Drawing.Size(293, 54)
        Me.btnSearchInventory.TabIndex = 3
        Me.btnSearchInventory.Text = "Search Master List"
        Me.btnSearchInventory.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSearchInventory.UseSelectable = True
        '
        'btnAccountsRequests
        '
        Me.btnAccountsRequests.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccountsRequests.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnAccountsRequests.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAccountsRequests.Location = New System.Drawing.Point(46, 224)
        Me.btnAccountsRequests.Name = "btnAccountsRequests"
        Me.btnAccountsRequests.Size = New System.Drawing.Size(293, 54)
        Me.btnAccountsRequests.TabIndex = 2
        Me.btnAccountsRequests.Text = "Account Requests"
        Me.btnAccountsRequests.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAccountsRequests.UseSelectable = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripMenuItem1.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'AppAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAccountsRequests)
        Me.Controls.Add(Me.btnSearchInventory)
        Me.Controls.Add(Me.btnSearchParts)
        Me.Controls.Add(Me.btnAddPart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AppAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddPart As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearchParts As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSearchInventory As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAccountsRequests As MetroFramework.Controls.MetroButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class

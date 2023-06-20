<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestForMoreInfoOrDeny
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RequestForMoreInfoOrDeny))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbRequestDetails = New MetroFramework.Controls.MetroTextBox()
        Me.lblMessage = New MetroFramework.Controls.MetroLabel()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 265)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(528, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'tbRequestDetails
        '
        Me.tbRequestDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbRequestDetails.CustomButton.Image = Nothing
        Me.tbRequestDetails.CustomButton.Location = New System.Drawing.Point(346, 2)
        Me.tbRequestDetails.CustomButton.Name = ""
        Me.tbRequestDetails.CustomButton.Size = New System.Drawing.Size(147, 147)
        Me.tbRequestDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbRequestDetails.CustomButton.TabIndex = 1
        Me.tbRequestDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbRequestDetails.CustomButton.UseSelectable = True
        Me.tbRequestDetails.CustomButton.Visible = False
        Me.tbRequestDetails.Lines = New String(-1) {}
        Me.tbRequestDetails.Location = New System.Drawing.Point(16, 48)
        Me.tbRequestDetails.MaxLength = 32767
        Me.tbRequestDetails.Multiline = True
        Me.tbRequestDetails.Name = "tbRequestDetails"
        Me.tbRequestDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRequestDetails.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbRequestDetails.SelectedText = ""
        Me.tbRequestDetails.SelectionLength = 0
        Me.tbRequestDetails.SelectionStart = 0
        Me.tbRequestDetails.ShortcutsEnabled = True
        Me.tbRequestDetails.Size = New System.Drawing.Size(496, 152)
        Me.tbRequestDetails.TabIndex = 0
        Me.tbRequestDetails.UseSelectable = True
        Me.tbRequestDetails.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbRequestDetails.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblMessage.Location = New System.Drawing.Point(16, 16)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(78, 19)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Comment:"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.Location = New System.Drawing.Point(64, 216)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(184, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Send Comment"
        Me.btnUpdate.UseSelectable = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(264, 216)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(184, 32)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Go Back"
        Me.btnBack.UseSelectable = True
        '
        'RequestForMoreInfoOrDeny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.tbRequestDetails)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RequestForMoreInfoOrDeny"
        Me.Text = "RequestForMoreInfo"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tbRequestDetails As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblMessage As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
End Class

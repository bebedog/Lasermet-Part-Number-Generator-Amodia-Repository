<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchPartRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatchPartRequest))
        Me.dgvBatchRequest = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.btnImportFile = New MetroFramework.Controls.MetroButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSendRequest = New MetroFramework.Controls.MetroButton()
        Me.btnGetTemplate = New MetroFramework.Controls.MetroButton()
        Me.dlgSaveTemplate = New System.Windows.Forms.SaveFileDialog()
        CType(Me.dgvBatchRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBatchRequest
        '
        Me.dgvBatchRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBatchRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBatchRequest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBatchRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBatchRequest.Location = New System.Drawing.Point(16, 16)
        Me.dgvBatchRequest.Name = "dgvBatchRequest"
        Me.dgvBatchRequest.Size = New System.Drawing.Size(768, 410)
        Me.dgvBatchRequest.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.AutoSize = True
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(584, 442)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(177, 32)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Go Back to Dashboard"
        Me.btnBack.UseSelectable = True
        '
        'btnImportFile
        '
        Me.btnImportFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImportFile.AutoSize = True
        Me.btnImportFile.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnImportFile.Location = New System.Drawing.Point(32, 442)
        Me.btnImportFile.Name = "btnImportFile"
        Me.btnImportFile.Size = New System.Drawing.Size(177, 32)
        Me.btnImportFile.TabIndex = 19
        Me.btnImportFile.Text = "Import File"
        Me.btnImportFile.UseSelectable = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 486)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(266, 17)
        Me.ToolStripStatusLabel1.Text = "Please import a valid CSV template to get started."
        '
        'btnSendRequest
        '
        Me.btnSendRequest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSendRequest.AutoSize = True
        Me.btnSendRequest.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSendRequest.Location = New System.Drawing.Point(400, 442)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.Size = New System.Drawing.Size(177, 32)
        Me.btnSendRequest.TabIndex = 21
        Me.btnSendRequest.Text = "Send Request"
        Me.btnSendRequest.UseSelectable = True
        '
        'btnGetTemplate
        '
        Me.btnGetTemplate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGetTemplate.AutoSize = True
        Me.btnGetTemplate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnGetTemplate.Location = New System.Drawing.Point(216, 442)
        Me.btnGetTemplate.Name = "btnGetTemplate"
        Me.btnGetTemplate.Size = New System.Drawing.Size(177, 32)
        Me.btnGetTemplate.TabIndex = 22
        Me.btnGetTemplate.Text = "Get Template"
        Me.btnGetTemplate.UseSelectable = True
        '
        'BatchPartRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGetTemplate)
        Me.Controls.Add(Me.btnSendRequest)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnImportFile)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvBatchRequest)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BatchPartRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Part Request"
        CType(Me.dgvBatchRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBatchRequest As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImportFile As MetroFramework.Controls.MetroButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnSendRequest As MetroFramework.Controls.MetroButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnGetTemplate As MetroFramework.Controls.MetroButton
    Friend WithEvents dlgSaveTemplate As SaveFileDialog
End Class

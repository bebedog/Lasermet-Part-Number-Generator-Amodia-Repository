<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newPartOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newPartOptions))
        Me.btnBack = New MetroFramework.Controls.MetroButton()
        Me.btnBatchRequest = New MetroFramework.Controls.MetroButton()
        Me.btnSingleRequest = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBack.Location = New System.Drawing.Point(48, 152)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(272, 56)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Go Back to Dashboard"
        Me.btnBack.UseSelectable = True
        '
        'btnBatchRequest
        '
        Me.btnBatchRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBatchRequest.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnBatchRequest.Location = New System.Drawing.Point(47, 88)
        Me.btnBatchRequest.Name = "btnBatchRequest"
        Me.btnBatchRequest.Size = New System.Drawing.Size(272, 56)
        Me.btnBatchRequest.TabIndex = 18
        Me.btnBatchRequest.Text = "Batch Request"
        Me.btnBatchRequest.UseSelectable = True
        '
        'btnSingleRequest
        '
        Me.btnSingleRequest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSingleRequest.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnSingleRequest.Location = New System.Drawing.Point(48, 24)
        Me.btnSingleRequest.Name = "btnSingleRequest"
        Me.btnSingleRequest.Size = New System.Drawing.Size(272, 56)
        Me.btnSingleRequest.TabIndex = 19
        Me.btnSingleRequest.Text = "Single Part Request"
        Me.btnSingleRequest.UseSelectable = True
        '
        'newPartOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSingleRequest)
        Me.Controls.Add(Me.btnBatchRequest)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "newPartOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Request Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBatchRequest As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSingleRequest As MetroFramework.Controls.MetroButton
End Class
